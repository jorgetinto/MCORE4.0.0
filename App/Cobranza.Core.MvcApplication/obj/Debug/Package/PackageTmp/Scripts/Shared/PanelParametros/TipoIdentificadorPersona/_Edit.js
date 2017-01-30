$(function () {

    $("#GuardarTipoIdentificadorPersona").click(function () {

        $.ajax({

            url: urlTipoIdPersonaEdit,

            type: 'POST',

            data: {

                CodigoPais: $("#CodigoPais").val(),

                IdTipoIdentificadorPersona: $("#IdTipoIdentificadorPersona").val(),

                Nombre: $("#Nombre").val(),

                Descripcion: $("#Descripcion").val()

            },

            success: function (data) {

                $("#TipoIdentificadorPersonaEdit").html(data.View);

                if (data.Success) {

                    $("#Titulo").html("Datos guardados de <br /> forma correcta.");

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
                }
            }
        });
    });

    $("#modalOk").click(function () {
        $(location).attr('href', 'index');
    });

});
