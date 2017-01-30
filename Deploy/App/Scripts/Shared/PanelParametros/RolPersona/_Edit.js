$(function () {

    $("#GuardarRolPersona").click(function () {

        $.ajax({

            url: urlRolPersonaEdit,

            type: 'POST',

            data: {

                IdRolPersona: $("#IdRolPersona").val(),

                Nombre: $("#Nombre").val()

            },

            success: function (data) {

                $("#RolPersonasEdit").html(data.View);

                if (data.Success) {

                    $("#Titulo").html("Datos guardados de <br /> forma correcta.");

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

    $("#modalOk").click(function () {
        $(location).attr('href', 'index');
    });
});
