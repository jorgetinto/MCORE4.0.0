
    var item_to_delete,
        item_nombre;

    $(".deleteItem").click(function (e) {
        item_to_delete = $(this).data('id');
        item_nombre = $(this).data('nombre');
    });

    $('#btnContinueDelete').click(function () {

        $('#basic').modal('hide');

        $.ajax({

            url: urlRubroDelete,

            type: 'POST',

            data: {

                IdRubro: item_to_delete,

                Nombre: item_nombre
            },

            success: function (data) {

                $("#RubrosEdit").html(data.View);

                if (data.Success) {

                    $("#Titulo").html("Datos Eliminados de <br /> forma correcta.");

                    $('#ModalOK').modal('show');

                    RefrescarListadoRubros();
                }
                else {
                    var messages = "";

                    $.each(data.ValidationMessages, function (key, value) {
                        messages += value + "<br />";
                    });

                    $("#TituloError").html(messages);

                    $('#ModalError').modal('show');

                    RefrescarListadoRubros();
                }
            }
        });

    });

