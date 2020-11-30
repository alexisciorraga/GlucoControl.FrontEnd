// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    //Initialize Select2 Elements
    $('.select2').select2()

    //Initialize Select2 Elements
    $('.select2bs4').select2({
        theme: 'bootstrap4'
    })

    moment().subtract(10, 'days').calendar();

    //Date range picker
    $('#inputFechaControl').datetimepicker({
        format: 'L',
        locale: 'es'
    });
})