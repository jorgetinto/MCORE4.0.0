    var item_id,
        item_codigopais,
        item_nombre,
        item_descripcion;

    $(".deleteItem").click(function (e) {
        item_id = $(this).data('id');
        item_codigopais = $(this).data('codigopais');
        item_nombre = $(this).data('nombre');
        item_descripcion = $(this).data('descripcion');

        console.log(item_id + " " + item_codigopais + " " + item_nombre + " " + item_descripcion + " " + urlTipoIdPersonaDelete);
    });

    $('#btnContinueDelete').click(function () {

        $('#basic').modal('hide');

        $.ajax({

            url: urlTipoIdPersonaDelete,

            type: 'POST',

            data: {

                CodigoPais: item_codigopais,

                IdTipoIdentificadorPersona: item_id,

                Nombre: item_nombre,

                Descripcion: item_descripcion
            },

            success: function (data) {

                $("#TipoIdentificadorPersonaEdit").html(data.View);

                if (data.Success) {

                    $("#Titulo").html("Datos Eliminados de <br /> forma correcta.");

                    $('#ModalOK').modal('show');

                    RefrescarListTipoIdPersona();
                }
                else {
                    var messages = "";

                    $.each(data.ValidationMessages, function (key, value) {
                        messages += value + "<br />";
                    });

                    $("#TituloError").html(messages);

                    $('#ModalError').modal('show');

                    RefrescarListTipoIdPersona();
                }
            }
        });

    });

