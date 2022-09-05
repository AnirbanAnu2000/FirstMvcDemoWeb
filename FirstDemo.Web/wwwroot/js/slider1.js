$(document).ready(function () {

    $('#p-1').click(function () {
        deselect();
        $(this).addClass('p-active');
        $('#s-1').addClass('s-selected');
    });

    $('#p-2').click(function () {
        deselect();
        $(this).addClass('p-active');
        $('#s-2').addClass('s-selected');
    });

    $('#p-3').click(function () {
        deselect();
        $(this).addClass('p-active');
        $('#s-3').addClass('s-selected');
    });

    $('#p-4').click(function () {
        deselect();
        $(this).addClass('p-active');
        $('#s-4').addClass('s-selected');
    });

});

function deselect() {
    $('#p-1, #p-2, #p-3, #p-4').removeClass('p-active');
    $('#s-1, #s-2, #s-3, #s-4').removeClass('s-selected');
}