
    var item_id,
        item_nombre,
        item_dias;

    $(".deleteItem").click(function (e) {
        item_id = $(this).data('id');
        item_nombre = $(this).data('nombre');
        item_dias = $(this).data('dias');
    });

    $('#btnContinueDelete').click(function () {

        $('#basic').modal('hide');

        $.ajax({

            url: urlCondicionPagoDelete,

            type: 'POST',

            data: {

                IdCondicionPago: item_id,

                Nombre: item_nombre,

                Dias: item_dias
            },

            success: function (data) {

                $("#CondicionPagosEdit").html(data.View);

                if (data.Success) {

                    $("#Titulo").html("Datos Eliminados de <br /> forma correcta.");

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

                    RefrescarListadoCondicionPagos();
                }
            }
        });

    });

