

let colors = [
    '#003f5c',
    '#2f4b7c',
    '#665191',
    '#a05195',
    '#d45087',
    '#f95d6a',
    '#ff7c43',
    '#ffa600',
];

function buildMap() {

    initMap();
    markers = [];

    if (currentProject) {
        showBorders(currentProject, true);
        showMarker(currentProject);
    }

    $('.loadingDiv').hide();
    
    const projectTitle = $("#projectTitle").val();
    const projectID = $("#projectID").val();
    const showIntersectingProjects = $('#showIntersectingProjects').is(':checked');
    const closeProjectsKM = $('#closeProjectsKM').val();
    
    var queryString = "projectKeyword=" + projectTitle;
    queryString += "&showIntersectingProjects=" + showIntersectingProjects;
    queryString += "&closeProjectsKM=" + closeProjectsKM;
    queryString += "&projectID=" + projectID;

    const showProjectBorders = true;
    console.log(queryString);
    //return true;

    
    
    $('.loadingDiv').show();
    $.getJSON("/Project/MapDetail/?" + queryString, function (json) {
        //console.log("data", data);
        //console.log(json.data[0]);
        //console.log(json);
        console.log("Building map...");

        for (var i = 0; i < json.data.length; i++) {
            markers.push(showMarker(json.data[i]));
            if (showProjectBorders == true) {
                console.log('showing border...');
                showBorders(json.data[i]);
            } else {
                console.log('hiding border...');
                p = showBorders(json.data[i]);
                p.setMap(null);
            }
        }

        /*new MarkerClusterer(map, markers, {
            imagePath:
                "https://developers.google.com/maps/documentation/javascript/examples/markerclusterer/m",
        });*/

        $('.loadingDiv').hide();

    }).fail(function () {
        alert('Harita bilgileri yüklenirken bir sorun oluþtu. Lütfen yeniden deneyin. Hata tekrar ederse sistem yöneticinizle görüþün.');
    });
}

function showBorders(m, main = false) {

    if (main) {
        color = "#FF0000";
    } else {
        color = colors[0];
    }

    const project_coordinates = m.coordinates.split(' ');
    mapCoors = [];
    let shapeArea = 0;
    for (i = 0; i < project_coordinates.length; i++) {
        mapCoors.push({
            lat: parseFloat(project_coordinates[i].split(',')[1]),
            lng: parseFloat(project_coordinates[i].split(',')[0]),
        });

        if (i > 0) {
            const [x1, y1] = [mapCoors[i - 1].lat, mapCoors[i - 1].lng];
            const [x2, y2] = [mapCoors[i % project_coordinates.length].lat, mapCoors[i % project_coordinates.length].lng];
            shapeArea += x1 * y2 - x2 * y1;
        }
        
    }

    shapeArea = Math.abs(shapeArea) / 2;

    //console.log("shapeArea", shapeArea);


    const projectPolygon = new google.maps.Polygon({
        paths: mapCoors,
        strokeColor: color,
        strokeOpacity: 0.8,
        strokeWeight: 2,
        fillColor: color,
        fillOpacity: 0.35,
    });
    projectPolygon.setMap(map);

    //console.log("Area", google.maps.geometry.spherical.computeArea(projectPolygon.getPath()));

    return projectPolygon;
}

function showMarker(m, main=false) {

    var url = "";
    if (main == true) {
        url = "/images/main.png"
    } else {
        url = "/images/default.png"
    }

    const image = {
        //url: "/images/" + m.responsibleDepartmentID + ".png",
        url: url,
        scaledSize: new google.maps.Size(32, 32),

        //origin: new google.maps.Point(-16, -16),

        anchor: new google.maps.Point(16, 16),
    };

    const LatLng = { lat: m.latitude, lng: m.longitude };
    const marker = new google.maps.Marker({
        position: LatLng,
        map,
        title: m.projectTitle,
        icon: image,
    });

    const contentString =
        '<div id="content">' +
        '<div id="siteNotice">' +
        "</div>" +
        '<h5 id="firstHeading" class="firstHeading">' + m.projectTitle + '</h4>' +
        '<div id="bodyContent"><p>' +
        'Hizmet Alaný: ' + m.serviceAreaTitle + '<br/>' +
        'Sorumlu Müdürlük: ' + m.responsibleDepartmentTitle + '<br/>' +
        'Proje Önemi: ' + m.projectImportanceTitle + '<br/>' +
        '</p>' +
        '<p><a class="btn btn-info btn-sm" href="/Project/Edit/' + m.projectID + '">Detaylar</a></p>' +
        "</div>" +
        "</div>";
    const infowindow = new google.maps.InfoWindow({
        content: contentString,
    });

    marker.addListener("click", () => {
        infowindow.open({
            anchor: marker,
            map,
            shouldFocus: false,
        });
    });
    //map.setCenter(marker.getPosition());
    marker.setMap(map);
    
    return marker;
    //;
}

$(document).ready(function () {
    $("#closeFilter").click(function () {
        $(".floatingFormForDetailPage").hide();
        $(".floatingFormClosedForDetailPage").show();
    });

    $("#openFilter").click(function () {
        $(".floatingFormClosedForDetailPage").hide();
        $(".floatingFormForDetailPage").show();

    });

    /*$('#selectDepartment').select2({
        theme: "ibb",
        language: "tr",
        ajax: {
            url: '/Department/JsonSelectData',
            dataType: 'json',
            processResults: function (response) {

                return {
                    results: response.results,
                };
            }
        }
    });*/

    /*$('#selectProjectOwner').select2({
        theme: "ibb",
        language: "tr",
        ajax: {
            url: '/Person/JsonSelectData',
            dataType: 'json',
            processResults: function (response) {

                return {
                    results: response.results,
                };
            }
        }
    });*/


    //Get full year and create year selection
    var d = new Date();
    var n = d.getFullYear();

    for (var i = 0; i < 10; i++) {
        var y = n - i;
        $('#selectYear').append('<option value="' + y + '">' + y + '</option>');
    }

    //$('#selectYear').append('<option value="test1">test1</option>');



    $('#selectYear').select2({
        theme: "ibb",
        language: "tr"
    }
    );

    $('#toggleFilter').click(function () {
        buildMap();
    })

    buildMap();
});