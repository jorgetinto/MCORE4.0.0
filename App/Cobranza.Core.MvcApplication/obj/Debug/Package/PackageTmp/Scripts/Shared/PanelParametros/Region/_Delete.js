    var item_id,
        item_codigopais,
        item_nombre,
        item_default;

    $(".deleteItem").click(function (e) {
        item_codigopais = $(this).data('codigopais');
        item_id = $(this).data('id');
        item_nombre = $(this).data('nombre');
        item_default = $(this).data('EsDefault').is(':checked');

        console.log(item_codigopais+" "+item_id+" "+item_nombre+" "+item_default);
    });

    $('#btnContinueDelete').click(function () {

        $('#basic').modal('hide');

        $.ajax({

            url: urlRegionDelete,

            type: 'POST',

            data: {

                CodigoPais: item_codigopais,

                IdRegion: item_id,

                Nombre: item_nombre,

                EsDefault: item_default
            },

            success: function (data) {

                $("#RegionesEdit").html(data.View);

                if (data.Success) {

                    $("#Titulo").html("Datos Eliminados de <br /> forma correcta.");

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

                    RefrescarListadoRegiones();
                }
            }
        });

    });

