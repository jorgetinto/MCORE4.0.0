
var item_id,
item_nombre,
item_nacionalidad,
item_default;

    $(".deleteItem").click(function (e) {
        item_id = $(this).data('id');
        item_nombre = $(this).data('nombre');
        item_nacionalidad =  $(this).data('nacionalidad');
        item_default = $(this).data('EsDefault');
    });

    $('#btnContinueDelete').click(function () {

        $('#basic').modal('hide');

        $.ajax({

            url: urlPaisDelete,

            type: 'POST',

            data: {

                CodigoPais: item_id,

                Nombre: item_nombre,

                Nacionalidad: item_nacionalidad,

                EsDefault: item_default
            },

            success: function (data) {

                $("#PaisEdit").html(data.View);

                if (data.Success) {

                    $("#Titulo").html("Datos Eliminados de <br /> forma correcta.");

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

                    RefrescarListadoPaises();
                }
            }
        });

    });

