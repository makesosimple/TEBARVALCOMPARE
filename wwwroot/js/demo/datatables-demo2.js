// Call the dataTables jQuery plugin
const icons =
    `<div class="d-flex align-items-center cem">
    <a href="#" class="dtActionButton" id="createFolder"><i class="far fa-folder"></i></a>
    <a href="#" class="dtActionButton" id="seeImages"><i class="far fa-image"></i></a>
    <a href="#" class="dtActionButton" id="seeStatistics"><i class="fas fa-chart-line"></i></a>
    <a href="#" class="dtActionButton" id="exportProject"><i class="fas fa-sign-out-alt"></i></a>
    <a href="#" class="dtActionButton" id="addShortcut"></i><i class="fas fa-heart"></i></a>
  </div>`;

const data = [
    {
        "code": "3400210201XX",
        "name": "Arnavutköy Hizmet Merkezi",
        "location": "Beyoğlu",
        "function": "Müze,Bilim Merkezi Kültür Yapısı",
        "owner": "Altyapı Projeler M",
        "responsible": "Ömer Yılmaz",
        "fee": "10.000,83 TL",
        "date": "2021",
        "projectArea": "2.000.000 m<sup>2</sup>",
        "constructionArea": "2.000.000 m<sup>2</sup>",
        "designer": "Foster + Partners",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210201XX",
        "name": "Arnavutköy Hizmet Merkezi",
        "location": "Beyoğlu",
        "function": "Müze,Bilim Merkezi Kültür Yapısı",
        "owner": "Altyapı Projeler M",
        "responsible": "Ömer Yılmaz",
        "fee": "10.000,83 TL",
        "date": "2021",
        "projectArea": "2.000.000 m<sup>2</sup>",
        "constructionArea": "2.000.000 m<sup>2</sup>",
        "designer": "Foster + Partners",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210201XX",
        "name": "Arnavutköy Hizmet Merkezi",
        "location": "Beyoğlu",
        "function": "Müze,Bilim Merkezi Kültür Yapısı",
        "owner": "Altyapı Projeler M",
        "responsible": "Ömer Yılmaz",
        "fee": "10.000,83 TL",
        "date": "2021",
        "projectArea": "2.000.000 m<sup>2</sup>",
        "constructionArea": "2.000.000 m<sup>2</sup>",
        "designer": "Foster + Partners",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210201XX",
        "name": "Arnavutköy Hizmet Merkezi",
        "location": "Beyoğlu",
        "function": "Müze,Bilim Merkezi Kültür Yapısı",
        "owner": "Altyapı Projeler M",
        "responsible": "Ömer Yılmaz",
        "fee": "10.000,83 TL",
        "date": "2021",
        "projectArea": "2.000.000 m<sup>2</sup>",
        "constructionArea": "2.000.000 m<sup>2</sup>",
        "designer": "Foster + Partners",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210202XX",
        "name": "Beyoğlu Hizmet Merkezi",
        "location": "Kadıköy",
        "function": "Müze, Hizmet, Bilim Merkezi Kültür Yapısı",
        "owner": "Üstyapı Projeler M",
        "responsible": "Cem Üstün",
        "fee": "120.980,83 TL",
        "date": "2022",
        "projectArea": "3.135.000 m<sup>2</sup>",
        "constructionArea": "3.450.000 m<sup>2</sup>",
        "designer": "Richard Rogers",
    },
    {
        "code": "3400210201XX",
        "name": "Arnavutköy Hizmet Merkezi",
        "location": "Beyoğlu",
        "function": "Müze,Bilim Merkezi Kültür Yapısı",
        "owner": "Altyapı Projeler M",
        "responsible": "Ömer Yılmaz",
        "fee": "10.000,83 TL",
        "date": "2021",
        "projectArea": "2.000.000 m<sup>2</sup>",
        "constructionArea": "2.000.000 m<sup>2</sup>",
        "designer": "Foster + Partners",
    }
];

$(document).ready(function () {

    /* Primary Buttons for DataTable. Must be common on all tables. */
    $.fn.dataTable.ext.buttons.alert = {
        className: 'btn btn-primary btn-circle border-0',

        action: function (e, dt, node, config) {
            window.location = '/samplemap.html';
        }
    };

    $.fn.dataTable.ext.buttons.none = {
        className: 'btn btn-primary btn-circle border-0',

        action: function (e, dt, node, config) {
            
        }
    };

    /* Initiate Table */
    let table = $("#dataTable").DataTable({
        data: data,
        searching: true,
        dom: '<"top d-flex justify-content-start my-2"B>rt<"d-flex justify-content-between flex-column align-items-baseline flex-md-row mt-3"ipl><"clear">',
        buttons: [
            {
                extend: 'alert',
                text: '<i class="fas fa-map-marker-alt"></i>',
                className: 'bg-primary',
            },
            {
                extend: 'none',
                text: '<i class="fas fa-table"></i>',
                className: 'bg-success',
            },
            {
                extend: 'none',
                text: '<i class="fas fa-file-excel"></i>',
                className: 'bg-info',
            }
        ],
        columns: [
            { data: null, defaultContent: icons },
            { data: 'code', targets: 1 },
            { data: 'name', targets: 2 },
            { data: 'location', targets: 3 },
            { data: 'function', targets: 4 },
            { data: 'owner', targets: 5 },
            { data: 'responsible', targets: 6 },
            { data: 'fee', targets: 7 },
            { data: 'date', targets: 8 },
            { data: 'projectArea', targets: 9 },
            { data: 'constructionArea', targets: 10 },
            { data: 'designer', targets: 11 }
        ],
        language: {
            url: "https://cdn.datatables.net/plug-ins/1.10.25/i18n/Turkish.json",
        },

        initComplete: function () {
            this.api()
                .columns()
                .every(function () {
                    let column = this;
                    column
                        .data()
                        .unique()
                        .sort()
                });
        },
    });

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
            case "select-test":
                htmlString = `
            <th scope="col">
              <input class="form-control w-100" data-index="${index}" type="text" placeholder="Ara..."/>
              <div class="select-holder bg-turqoise p-3 position-absolute">
                <input type="text" name="filterSelect" id="filterSelect" class="form-control dropdown-filter text-white text-sm mb-3" />
                <div class="data-holder d-flex align-items-center position-relative">
                  <input type="radio" name="selectDistrict" id="selectDistrict" class="form-control dropdown-select-district" />
                  <div class="customSelectBox"></div>
                  <label class="text-white text-sm" for="selectDistrict">ADALAR</label>
                </div>
                <div class="data-holder d-flex align-items-center">
                  <input type="radio" name="selectDistrict" id="selectDistrict" class="form-control dropdown-select-district" />
                  <label class="text-white text-sm" for="selectDistrict">ARNAVUTKÖY</label>
                </div>
                <div class="data-holder d-flex align-items-center">
                  <input type="radio" name="selectDistrict" id="selectDistrict" class="form-control dropdown-select-district" />
                  <label class="text-white text-sm" for="selectDistrict">BAĞCILAR</label>
                </div>
                <div class="data-holder d-flex align-items-center">
                  <input type="radio" name="selectDistrict" id="selectDistrict" class="form-control dropdown-select-district" />
                  <label class="text-white text-sm" for="selectDistrict">BAHÇELİEVLER</label>
                </div>
            </th>
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

    //Here we initialize search for the specific column with that column's index.
    $('#dataTable thead input, #dataTable thead select').on('keyup change clear', function () {
        let columnIndex = $(this).attr('data-index');
        table
            .columns(columnIndex)
            .search(this.value)
            .draw();
    });


    //Demo alerts for actions buttons.
    $('#dataTable tbody').on('click', '.dtActionButton', function () {
        let data = table.row($(this).parents('tr')).data();
        let action = $(this).attr('id');
        if (action == "createFolder") alert(data.code + " kodlu projenin dosyaları oluşturulmuştur.");
        else if (action == "seeImages") alert(data.code + " kodlu projenin medyası indirilmiştir.");
        else if (action == "seeStatistics") alert(data.code + " kodlu projenin istatistikleri indirilmiştir.");
        else if (action == "exportProject") alert(data.code + " kodlu proje başarıyla dışarı aktarılmıştır.");
        else if (action == "addShortcut") alert(data.code + " kodlu proje kısayollarınıza eklenmiştir.");

        $(this).toggleClass('active');
    });

});
