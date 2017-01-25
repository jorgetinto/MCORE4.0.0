
    var item_id,
        item_nombre;

    $(".deleteItem").click(function (e) {
        item_id = $(this).data('id');
        item_nombre = $(this).data('nombre');
    });

    $('#btnContinueDelete').click(function () {

        $('#basic').modal('hide');

        $.ajax({

            url: urlRolDelete,

            type: 'POST',

            data: {

                IdRolPersona: item_id,

                Nombre: item_nombre
            },

            success: function (data) {

                $("#RolPersonaEdit").html(data.View);

                if (data.Success) {

                    $("#Titulo").html("Datos Eliminados de <br /> forma correcta.");

                    $('#ModalOK').modal('show');

                    RefrescarListadoRolPersonas();
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

