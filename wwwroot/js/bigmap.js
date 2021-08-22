let map;

function initMap() {
  map = new google.maps.Map(document.getElementById("map"), {
      center: { lat: 40.97871410284052, lng: 29.04875532823787 },
      disableDefaultUI: true,
    zoom: 8,
  });
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
            url: '/District/JsonSelectData',
            data: function () {
                let query = {
                    cityCode: 34,
                }
                return query;
            },
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

    for (var i = 0; i < 25; i++) {
        var y = n - i;
        $('#selectYear').append('<option value="'+y+'">'+y+'</option>');
    }

    //$('#selectYear').append('<option value="test1">test1</option>');
       

   
    $('#selectYear').select2({
        theme: "ibb",
        language: "tr"
    }
    );
});