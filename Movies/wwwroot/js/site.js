// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    //var table =
    $('#users').DataTable({
        "oLanguage": {
            "sLengthMenu": "Display _MENU_ Users",
            "sInfo": "Showing _START_ to _END_ of _TOTAL_ Users",
            "sInfoEmpty": "Showing 0 to 0 of 0 Users"
        },
        "aLengthMenu": [[5, 10, 15, -1], [5, 10, 15, "All"]],
        "pageLength": 5,



    });
    $('#movies').DataTable({
        "oLanguage": {
            "sLengthMenu": "Display _MENU_ Movies",
            "sInfo": "Showing _START_ to _END_ of _TOTAL_ Movies",
            "sInfoEmpty": "Showing 0 to 0 of 0 Movies"
        },
        "aLengthMenu": [[5, 10, 15, -1], [5, 10, 15, "All"]],
        "pageLength": 5,



    });
    $('#orders').DataTable({
        "oLanguage": {
            "sLengthMenu": "Display _MENU_ Orders",
            "sInfo": "Showing _START_ to _END_ of _TOTAL_ Orders",
            "sInfoEmpty": "Showing 0 to 0 of 0 Orders"
        },
        "aLengthMenu": [[5, 10, 15, -1], [5, 10, 15, "All"]],
        "pageLength": 5,



    });
    $('#genres').DataTable({
        "oLanguage": {
            "sLengthMenu": "Display _MENU_ Genre",
            "sInfo": "Showing _START_ to _END_ of _TOTAL_ Genres",
            "sInfoEmpty": "Showing 0 to 0 of 0 Genres"
        },
        "aLengthMenu": [[5, 10, 15, -1], [5, 10, 15, "All"]],
        "pageLength": 5,



    });
});