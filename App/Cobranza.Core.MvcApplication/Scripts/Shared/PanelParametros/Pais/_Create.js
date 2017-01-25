$(function () {

    $("#GuardarNuevoPais").click(function () {

        $.ajax({

            url: urlPaisCreate,

            type: 'POST',

            data: {

                CodigoPais: $("#CodigoPais").val(),

                Nombre: $("#Nombre").val(),

                Nacionalidad: $("#Nacionalidad").val(),

                EsDefault: $("#EsDefault").is(':checked')

            },

            success: function (data) {

                $("#PaisCreate").html(data.View);

                if (data.Success) {

                    $("#Titulo").html("Datos guardados de <br /> forma correcta.");

                    $('#ModalOK').modal('show');

                    RefrescarListadoPaises();

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

