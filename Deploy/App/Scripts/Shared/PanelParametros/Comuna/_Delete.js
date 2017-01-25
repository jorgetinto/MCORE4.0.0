    var item_id,
        item_nombre,
        item_region,
        item_pais,
        item_default;

    $(".deleteItem").click(function (e) {
        item_id = $(this).data('id');
        item_nombre = $(this).data('nombre');
        item_region = $(this).data('region');
        item_pais = $(this).data('pais');
        item_default = $(this).data('EsDefault');
    });

    $('#btnContinueDelete').click(function () {

        $('#basic').modal('hide');

        $.ajax({

            url: urlComunaDelete,

            type: 'POST',

            data: {

                CodigoPais: item_pais,

                IdRegion: item_region,

                IdComuna: item_id,

                Nombre: item_nombre,

                EsDefault: item_default

            },

            success: function (data) {

                $("#ComunasEdit").html(data.View);

                if (data.Success) {

                    $("#Titulo").html("Datos Eliminados de <br /> forma correcta.");

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

                    RefrescarListadoComunas();
                }
            }
        });

    });

