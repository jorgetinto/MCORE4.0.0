$(function () {

    $("#GuardarNuevaComuna").click(function () {

        $.ajax({

            url: urlComunaCreate,

            type: 'POST',

            data: {

                CodigoPais: $("#CodigoPais").val(),

                IdRegion: $("#IdRegion").val(),

                IdComuna: $("#IdComuna").val(),

                Nombre: $("#Nombre").val(),

                EsDefault: $("#EsDefault").is(':checked'),

            },

            success: function (data) {

                $("#ComunaCreate").html(data.View);

                if (data.Success) {

                    $("#Titulo").html("Datos guardados de <br /> forma correcta.");

                    $('#ModalOK').modal('show');

                    RefrescarListadoComunas();

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

