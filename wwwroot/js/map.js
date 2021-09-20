let map;

function initMap() {
  map = new google.maps.Map(document.getElementById("map"), {
      center: { lat: 40.97871410284052, lng: 29.04875532823787 },
      disableDefaultUI: true,
      zoomControl: true,
    zoom: 8,
  });
}