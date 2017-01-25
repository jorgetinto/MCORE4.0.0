$(function () {

    $("#CodigoPais").change(function () {

        $.ajax({

            url: urlGetAllRegionesByPais,

            type: 'POST',

            data: {

                CodigoPais: $(this).val()
            },

            success: function (data) {

                var idRegion = $("#IdRegion");

                idRegion.find('option')
                    .remove()
                    .end()
                    .append('<option value="">-- Seleccione --</option>');

                $.each(data.Regiones, function (index, item) {
                    idRegion.append('<option value="' + item.IdRegion + '">' + item.Nombre + '</option>');

                    if (item.EsDefault) {
                        idRegion.val(item.IdRegion);
                    }

                });
            }
        });
    });

    $("#CodigoPais").change();
});