$(function () {

    $("#GuardarRubro").click(function () {

        $.ajax({

            url: urlRubroEdit,

            type: 'POST',

            data: {

                IdRubro: $("#IdRubro").val(),

                Nombre: $("#Nombre").val()

            },

            success: function (data) {

                $("#RubrosEdit").html(data.View);

                if (data.Success) {

                    $("#Titulo").html("Datos guardados de <br /> forma correcta.");

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

                }

            }

        });
    });

});
