// Call the dataTables jQuery plugin

const dataFunction = [
    {
        "user": "Cami",
        "assignmentInProject": "1000",
        "field": "200",
        "organization": " - ",
        "classRoom": "25",
        "totalUnits": "1",
        "totalLength": "250",
        "totalWidth": " - ",

    },
    {
        "user": "Anaokulu",
        "assignmentInProject": "1000",
        "field": "200",
        "organization": " - ",
        "classRoom": "25",
        "totalUnits": "1",
        "totalLength": "250",
        "totalWidth": " - ",

    },
];

$(document).ready(function () {

  /* Initiate Table */
  let table = $("#dataTableFunction").DataTable({
    data: dataFunction,
    searching: true,
    dom:'rt<"d-flex justify-content-between flex-column align-items-baseline flex-md-row mt-3"ipl><"clear">',
    columns: [
        { data: 'user', targets: 0 },
        { data: 'assignmentInProject', targets: 1 },
        { data: 'field', targets: 2 },
        { data: 'organization', targets: 3 },
        { data: 'classRoom', targets: 4 },
        { data: 'totalUnits', targets: 5 },
        { data: 'totalWidth', targets: 6 },
        { data: 'totalLength', targets: 7 },
        {
          "data": null,
          "render": function (data, type, full, meta, row) {
              return `<div class="d-flex align-items-center justify-content-end">\
                        <a class="btn btn-circle bg-turqoise text-white mr-1" href="#"><i class="fas fa-edit"></i></a>\
                        <button type="button" class="btn btn-circle bg-warning text-white mr-1"><i class="fas fa-info-circle"></i></button>\
                        <button type="button" class="btn btn-circle bg-danger text-white"><i class="fas fa-trash-alt"></i></button>\
                      </div>`;
          }
      },
    ],
    language: {
      url: "https://cdn.datatables.net/plug-ins/1.10.25/i18n/Turkish.json",
    },

      "columnDefs": [
          { "targets": -1, "orderable": false },
      ],
      "initComplete": function () {
          let api = this.api();

          $('input.searchInput, select.searchInput').on('input', function () {
              let columnIndex = $(this).data("index");
              let desiredColumn = api.columns(columnIndex);
              if (desiredColumn.search() !== this.value) {
                  desiredColumn
                      .search(this.value)
                      .draw();
              }
          });
      }
  });


  //Demo alerts for actions buttons.
    $('#dataTableFunction tbody').on( 'click', '.dtActionButton', function () {
    let data = table.row( $(this).parents('tr') ).data();
    let action = $(this).attr('id');
    if(action == "createFolder") alert(data.code + " kodlu projenin dosyaları oluşturulmuştur.");
    else if(action == "seeImages") alert(data.code + " kodlu projenin medyası indirilmiştir.");
    else if(action == "seeStatistics") alert(data.code + " kodlu projenin istatistikleri indirilmiştir.");
    else if(action == "exportProject") alert(data.code + " kodlu proje başarıyla dışarı aktarılmıştır.");
    else if(action == "addShortcut") alert(data.code + " kodlu proje kısayollarınıza eklenmiştir.");

    $(this).toggleClass('active');
} );
  
});
