$(document).ready(function () {
    $('[data-toggle="tooltip"]').tooltip();
});

function MarcarParametroActual(idParametro) {
   $("#" + idParametro).addClass("active");
}

function RefrescarListadoRubros() {
    $.ajax({

        url: urlRubroList,

        type: 'POST',

        success: function (data) {

            $("#RubrosList").html(data);
        }
    });
}

function RefrescarListadoCondicionPagos() {
    $.ajax({

        url: urlCondicionPagoList,

        type: 'POST',

        success: function (data) {

            $("#CondicionPagosList").html(data);
        }
    });
}

function RefrescarListadoRolPersonas() {
    $.ajax({

        url: urlRolPersonaList,

        type: 'POST',

        success: function (data) {

            $("#RolPersonaList").html(data);
        }
    });
}

function RefrescarListadoPaises() {
    $.ajax({

        url: urlPaisList,

        type: 'POST',

        success: function (data) {

            $("#PaisList").html(data);
        }
    });
}

function RefrescarListTipoIdPersona() {
    $.ajax({

        url: urlTipoIdPersonaList,

        type: 'POST',

        success: function (data) {

            $("#TipoIdentificadorPersonaList").html(data);
        }
    });
}

function RefrescarListadoRegiones() {
    $.ajax({

        url: urlRegionList,

        type: 'POST',

        success: function (data) {

            $("#RegionList").html(data);
        }
    });
}

function RefrescarListadoComunas() {
    $.ajax({

        url: urlComunaList,

        type: 'POST',

        success: function (data) {

            $("#ComunaList").html(data);
        }
    });
}

function RefrescarListadoParametros() {
    $.ajax({

        url: urlParametroList,

        type: 'POST',

        success: function (data) {

            $("#ParametroListCabecera").html(data);
        }
    });
}

function resetValidation() {
    $('.field-validation-error').each(function () {
        $(this).html("");
    })
}

$(function () {
    $('#SearchableContainer').searchable({
        searchField: '#Search',
        selector: '.row',
        childSelector: '.col-xs-12',
        show: function (elem) {
            elem.slideDown(100);
        },
        hide: function (elem) {
            elem.slideUp(100);
        }
    })
});

