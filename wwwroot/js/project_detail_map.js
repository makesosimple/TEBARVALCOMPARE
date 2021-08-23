let map;

function initMap() {
  map = new google.maps.Map(document.getElementById("map"), {
      center: {
          lat: parseFloat(project_coordinates[0].split(',')[1]),
          lng: parseFloat(project_coordinates[0].split(',')[0]),
              },
      disableDefaultUI: true,
    zoom: 16,
  });
    mapCoors = [];
    for (i = 0; i < project_coordinates.length; i++) {
        mapCoors.push({
            lat: parseFloat(project_coordinates[i].split(',')[1]),
            lng: parseFloat(project_coordinates[i].split(',')[0]),
        });
    }

   
    const projectPolygon = new google.maps.Polygon({
        paths: mapCoors,
        strokeColor: "#FF0000",
        strokeOpacity: 0.8,
        strokeWeight: 2,
        fillColor: "#FF0000",
        fillOpacity: 0.35,
    });
    projectPolygon.setMap(map);
}