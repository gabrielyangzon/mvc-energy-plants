﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function formSubmit(type) {

    swal({
        title: "Are you sure?",
        text: "",
        icon: "info",
        buttons: true,

    })
        .then((accept) => {
            if (accept) {

                document.getElementById(type).submit()

                //swal("Success", {
                //    icon: "success",
                //    showConfirmButton: false
                //});

                //setTimeout(() => {

                //}, 900)


            }
        });


}

