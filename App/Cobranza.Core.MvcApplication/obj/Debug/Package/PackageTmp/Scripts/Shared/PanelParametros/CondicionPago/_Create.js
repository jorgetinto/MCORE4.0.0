$(function () {

    $("#GuardarNuevaCondicionPago").click(function () {

        $.ajax({

            url: urlCondicionPagoCreate,

            type: 'POST',

            data: {

                IdCondicionPago: $("#IdCondicionPago").val(),

                Nombre: $("#Nombre").val(),

                Dias: $("#Dias").val()

            },

            success: function (data) {

                $("#CondicionPagosCreate").html(data.View);

                if (data.Success) {

                    $("#Titulo").html("Datos guardados de <br /> forma correcta.");

                    $('#ModalOK').modal('show');

                    RefrescarListadoCondicionPagos();

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

