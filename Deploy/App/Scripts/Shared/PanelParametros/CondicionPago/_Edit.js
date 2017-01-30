$(function () {

    $("#GuardarCondicionPago").click(function () {

        $.ajax({

            url: urlCondicionPagoEdit,

            type: 'POST',

            data: {
                IdCondicionPago: $("#IdCondicionPago").val(),

                Nombre: $("#Nombre").val(),

                Dias: $("#Dias").val()

            },

            success: function (data) {

                $("#CondicionPagosEdit").html(data.View);

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

    $("#modalOk").click(function () {
        $(location).attr('href', 'index');
    });
});
