////// Call the dataTables jQuery plugin
////const icons =
////    `<div class="d-flex align-items-center">
////    <a href="#" class="dtActionButton" id="createFolder"><i class="far fa-folder"></i></a>
////    <a href="#" class="dtActionButton" id="seeImages"><i class="far fa-image"></i></a>
////    <a href="#" class="dtActionButton" id="seeStatistics"><i class="fas fa-chart-line"></i></a>
////    <a href="#" class="dtActionButton" id="exportProject"><i class="fas fa-sign-out-alt"></i></a>
////    <a href="#" class="dtActionButton" id="addShortcut"></i><i class="fas fa-heart"></i></a>
////  </div>`;

////$(document).ready(function () {

////    /* Primary Buttons for DataTable. Must be common on all tables. */
////    $.fn.dataTable.ext.buttons.alert = {
////        className: 'btn btn-primary btn-circle border-0',

////        action: function (e, dt, node, config) {
////            alert("Buton çalışıyor!");
////        }
////    };

////    /* Initiate Table */
////    let table = $("#dataTable").DataTable({
////        searching: true,
////        dom: '<"top d-flex justify-content-start my-2"B>rt<"d-flex justify-content-between flex-column align-items-baseline flex-md-row mt-3"ipl><"clear">',
////        buttons: [
////            {
////                extend: 'alert',
////                text: '<i class="fas fa-eye-slash"></i>',
////                className: 'bg-primary pt-2',
////            },
////            {
////                extend: 'alert',
////                text: '<i class="fas fa-map-marker-alt"></i>',
////                className: 'bg-success pt-2',
////            },
////            {
////                extend: 'alert',
////                text: '<i class="fas fa-file-export"></i>',
////                className: 'bg-info pt-2 pr-2',
////            }
////        ],
////        language: {
////            url: "https://cdn.datatables.net/plug-ins/1.10.25/i18n/Turkish.json",
////        },

////        initComplete: function () {
////            this.api()
////                .columns()
////                .every(function () {
////                    let column = this;
////                    column
////                        .data()
////                        .unique()
////                        .sort()
////                });
////        },
////    });

    /* 
    Create individual search inputs for each column. We use custom template strings to initialize dynamic search fields.
    Until a better method is proposed, this is the best way to initialize sort and search for each column. For any additional
    extension of this code, please add data-{customOption} attribute to table head columns and use it in this section.
    
    data-index: for individual column search, we need to specify column indexes. Remember is starts with zero!
    data-search-type: specify search type. select, input, datetime etc.
    */

//Set index to 0. Even if there is a search-type: none, we should always start with 0 and go to end of the length.
    let index = 0;
    $('#dataTable thead #tableLabels th').each(function () {
        const columnSearchType = $(this).attr('data-search-type');
        let htmlString;
        switch (columnSearchType) {
            case "text":
                htmlString = `
          <th scope="col"><input class="form-control w-100" data-index="${index}" type="text" placeholder="Ara..."/></th>
        `;
                break;

            case "select":
                htmlString = `
          <th scope="col">

              <select class="form-control" id="exampleFormControlSelect1" data-index="${index}">
                <option>ADALAR</option>
                <option>ARNAVUTKÖY</option>
                <option>BAĞCILAR</option>
                <option>BAHÇELİEVLER</option>
                <option>BAKIRKÖY</option>
              </select>

          </th>
          `;
                break;

            case "none":
                htmlString = `<th scope="col"><input class="form-control w-100" data-index="${index}" type="hidden" placeholder="Ara..."/></th>`;
                break;

            default:
                htmlString = `
            <th scope="col"><input class="form-control w-100" data-index="${index}" type="text" placeholder="Ara..."/></th>
          `;
                break;
        }
        $('#dataTable thead .filter').append(htmlString);
        htmlString = ``;
        index += 1;
    });

    index = 0;

