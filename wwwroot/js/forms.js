(function ($) {
    "use strict"; // Start of use strict  

    // Initialize Select2
    $('.initialize-select2').each(function () {
        $(this).select2({
            theme: "ibb"
        });
    });

    //Initialize Datepicker
    $('.datepicker').each(function () {
        $(this).datepicker({
            format: "dd.mm.yyyy",
            todayBtn: "linked",
            clearBtn: true,
            language: "tr",
            autoclose: true,
        });
    });

    //Initialize Currency
    $("input[data-input-type]").on({
        keyup: function () {
            formatCurrency($(this));
        },
        blur: function () {
            formatCurrency($(this), "blur");
        }
    });


    function formatNumber(n) {
        // format number 1000000 to 1,234,567
        return n.replace(/\D/g, "").replace(/\B(?=(\d{3})+(?!\d))/g, ",")
    }


    function formatCurrency(input, blur) {
        // appends $ to value, validates decimal side
        // and puts cursor back in right position.

        // get input value
        let input_val = input.val();

        let inputType = input.attr("data-input-type");

        // don't validate empty input
        if (input_val === "") { return; }

        // original length
        var original_len = input_val.length;

        // initial caret position 
        var caret_pos = input.prop("selectionStart");

        // check for decimal
        if (input_val.indexOf(".") >= 0) {

            // get position of first decimal
            // this prevents multiple decimals from
            // being entered
            var decimal_pos = input_val.indexOf(".");

            // split number by decimal point
            var left_side = input_val.substring(0, decimal_pos);
            var right_side = input_val.substring(decimal_pos);

            // add commas to left side of number
            left_side = formatNumber(left_side);

            // validate right side
            right_side = formatNumber(right_side);

            // On blur make sure 2 numbers after decimal
            if (blur === "blur") {
                right_side += "00";
            }

            // Limit decimal to only 2 digits
            right_side = right_side.substring(0, 2);

            // join number by .
            switch (inputType) {
                case 'currency':
                    input_val = "₺ " + left_side + "." + right_side;
                    break;

                case 'length':
                    input_val = left_side + "." + right_side;
                    break;
            }
        } else {
            // no decimal entered
            // add commas to number
            // remove all non-digits
            input_val = formatNumber(input_val);

            // final formatting
            if (blur === "blur") {
                input_val += ".00";
            }

            switch (inputType) {
                case 'currency':
                    input_val = "₺ " + input_val;
                    break;

                case 'length':
                    input_val = input_val;
                    break;
            }
        }

        // send updated string to input
        input.val(input_val);

        // put caret back in the right position
        var updated_len = input_val.length;
        caret_pos = updated_len - original_len + caret_pos;
        input[0].setSelectionRange(caret_pos, caret_pos);
    }

    //Format Phone  Number
    $(".phoneField").mask("999-999-9999");

    //Format Current Date
    let currentdate = new Date();
    let datetime = currentdate.getDate() + "/"
        + (currentdate.getMonth() + 1) + "/"
        + currentdate.getFullYear() + " "
        + currentdate.getHours() + ":"
        + currentdate.getMinutes() + ":"
        + currentdate.getSeconds();
    $("#currentDate").val(datetime);

})(jQuery); // End of use strict
