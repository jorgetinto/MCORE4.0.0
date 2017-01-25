﻿$(function () {

    $("#GuardarNuevaRegion").click(function () {

        $.ajax({

            url: urlRegionCreate,

            type: 'POST',

            data: {

                CodigoPais: $("#CodigoPais").val(),

                IdRegion: $("#IdRegion").val(),

                Nombre: $("#Nombre").val(),

                EsDefault: $("#EsDefault").is(':checked')

            },

            success: function (data) {

                $("#RegionCreate").html(data.View);

                if (data.Success) {

                    $("#Titulo").html("Datos guardados de <br /> forma correcta.");

                    $('#ModalOK').modal('show');

                    RefrescarListadoRegiones();

                }
                else {

                    var messages = "";

                    $.each(data.ValidationMessages, function (key, value) {
                        messages += value + "<br />";
                    });

                    $("#TituloError").html(messages);

                    $('#ModalError').modal('show');

                }

            }

        });
    });

});

