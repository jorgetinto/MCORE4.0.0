$(function () {

    $("#GuardarNuevoRolPersona").click(function () {

        $.ajax({

            url: urlRolPersonaCreate,

            type: 'POST',

            data: {

                IdRolPersona: $("#IdRolPersona").val(),

                Nombre: $("#Nombre").val()

            },

            success: function (data) {

                $("#RolPersonasCreate").html(data.View);

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

});

