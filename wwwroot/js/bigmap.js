let map;

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



function initMap() {
  map = new google.maps.Map(document.getElementById("map"), {
      center: { lat: 41.01871410284052, lng: 29.04875532823787 },
      disableDefaultUI: true,
      zoom: 10,
      styles: [{ "featureType": "water", "elementType": "geometry", "stylers": [{ "color": "#3399CC" }, { "lightness": 17 }] }, { "featureType": "landscape", "elementType": "geometry", "stylers": [{ "color": "#f5f5f5" }, { "lightness": 20 }] }, { "featureType": "road.highway", "elementType": "geometry.fill", "stylers": [{ "color": "#ffffff" }, { "lightness": 17 }] }, { "featureType": "road.highway", "elementType": "geometry.stroke", "stylers": [{ "color": "#ffffff" }, { "lightness": 29 }, { "weight": 0.2 }] }, { "featureType": "road.arterial", "elementType": "geometry", "stylers": [{ "color": "#ffffff" }, { "lightness": 18 }] }, { "featureType": "road.local", "elementType": "geometry", "stylers": [{ "color": "#ffffff" }, { "lightness": 16 }] }, { "featureType": "poi", "elementType": "geometry", "stylers": [{ "color": "#f5f5f5" }, { "lightness": 21 }] }, { "featureType": "poi.park", "elementType": "geometry", "stylers": [{ "color": "#dedede" }, { "lightness": 21 }] }, { "elementType": "labels.text.stroke", "stylers": [{ "visibility": "on" }, { "color": "#ffffff" }, { "lightness": 16 }] }, { "elementType": "labels.text.fill", "stylers": [{ "saturation": 36 }, { "color": "#333333" }, { "lightness": 40 }] }, { "elementType": "labels.icon", "stylers": [{ "visibility": "off" }] }, { "featureType": "transit", "elementType": "geometry", "stylers": [{ "color": "#f2f2f2" }, { "lightness": 19 }] }, { "featureType": "administrative", "elementType": "geometry.fill", "stylers": [{ "color": "#fefefe" }, { "lightness": 20 }] }, { "featureType": "administrative", "elementType": "geometry.stroke", "stylers": [{ "color": "#fefefe" }, { "lightness": 17 }, { "weight": 1.2 }] }],
  });
}

function buildMap() {

    initMap();
    const projectTitle = $("#projectTitle").val();
    
    const selectYear = $("#selectYear").val();
    const selectDepartment = $("#selectDepartment").val();
    const selectProjectOwner = $("#selectProjectOwner").val();
    const showProjectBorders = $('#showProjectBorders').is(':checked');
    const selectDistrict = $("#selectDistrict").val();

    

    var queryString = "projectKeyword=" + projectTitle;
    queryString += "&districtID=" + selectDistrict;
    queryString += "&respDepartmentID=" + selectDepartment;
    queryString += "&ProjectOwnerID=" + selectProjectOwner;
    queryString += "&yearSelected=" + selectYear;
    queryString += "&showProjectBorders=" + showProjectBorders;

    console.log(queryString);
    markers = [];
    $('.loadingDiv').show();
    $.getJSON("/Project/MapData/?" + queryString, function (json) {
        //console.log("data", data);
        //console.log(json.data[0]);
        console.log(json);
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

        new MarkerClusterer(map, markers, {
            imagePath:
                "https://developers.google.com/maps/documentation/javascript/examples/markerclusterer/m",
        });

        $('.loadingDiv').hide();

    }).fail(function () {
        alert('Harita bilgileri yüklenirken bir sorun oluştu. Lütfen yeniden deneyin. Hata tekrar ederse sistem yöneticinizle görüşün.');
    });
}

function showBorders(m) {
    const project_coordinates = m.coordinates.split(' ');
    mapCoors = [];
    for (i = 0; i < project_coordinates.length; i++) {
        mapCoors.push({
            lat: parseFloat(project_coordinates[i].split(',')[1]),
            lng: parseFloat(project_coordinates[i].split(',')[0]),
        });
    }


    const projectPolygon = new google.maps.Polygon({
        paths: mapCoors,
        strokeColor: colors[m.responsibleDepartmentID],
        strokeOpacity: 0.8,
        strokeWeight: 2,
        fillColor: colors[m.responsibleDepartmentID],
        fillOpacity: 0.35,
    });
    projectPolygon.setMap(map);
    return projectPolygon;
}

function showMarker(m) {
    
    console.log("/images/mapicons/departments/" + m.mapIcon);
    const image = {
        //url: "/images/mapicons/departments/" + m.mapIcon,
        url: "/images/default.png",
        scaledSize: new google.maps.Size(32, 32),
        
        //origin: new google.maps.Point(-16, -16),
        
        anchor: new google.maps.Point(16, 32),
        labelOrigin: new google.maps.Point(0, 40),
    };

    const LatLng = { lat: parseFloat(m.latitude), lng: parseFloat(m.longitude) };
    const text = m.projectTitle.slice(0,32)+'...';
    const marker = new google.maps.Marker({
        position: LatLng,
        map,
        title: m.projectTitle,
        label: {
            text: text,
            color: "#0a1a33",
            fontSize: "10pt",
            fontWeight: "bold",
        },
        labelClass: "btn",
        
        icon: image,
    });

   /* const marker = new SVGMarker({
        map: map,
        position: new google.maps.LatLng(parseFloat(m.latitude), parseFloat(m.longitude)),
        icon: {
            anchor: new google.maps.Point(30, 30.26),
            size: new google.maps.Size(60, 30.26),
            url: "/images/mapicons/departments/" + m.mapIcon,
        }
    });*/


    const contentString =
        '<div id="content">' +
        '<div id="siteNotice">' +
        "</div>" +
        '<h5 id="firstHeading" class="firstHeading">'+m.projectTitle+'</h4>' +
        '<div id="bodyContent"><p>' +
        'Hizmet Alanı: ' + m.serviceAreaTitle + '<br/>' +
        'Sorumlu Müdürlük: ' + m.responsibleDepartmentTitle + '<br/>' +
        'Proje Önemi: ' + m.projectImportanceTitle + '<br/>' +
        '</p>' +
        '<p><a class="link" href="/Project/Edit/' + m.projectID + '">Proje <i class="fas fa-arrow-circle-right"></i></a></p>' +
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

    return marker;
    //map.setCenter(marker.getPosition());
}

$(document).ready(function () {
    $("#closeFilter").click(function () {
        $(".floatingForm").hide();
        $(".floatingFormClosed").show();
    });

    $("#openFilter").click(function () {
        $(".floatingFormClosed").hide();
        $(".floatingForm").show();
   
    });

    $('#selectDistrict').select2({
        theme: "ibb",
        language: "tr",
        ajax: {
            url: '/District/JsonSelectData?cityCode=34',
            /*data: function () {
                let query = {
                    cityCode: 34,
                }
                return query;
            },*/
            dataType: 'json',
            processResults: function (response) {

                return {
                    results: response.results,
                };
            }
        }
    });

    $('#selectDepartment').select2({
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
    });

    $('#selectProjectOwner').select2({
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
    });


    //Get full year and create year selection
    var d = new Date();
    var n = d.getFullYear();

    for (var i = 0; i < 10; i++) {
        var y = n - i;
        $('#selectYear').append('<option value="'+y+'">'+y+'</option>');
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