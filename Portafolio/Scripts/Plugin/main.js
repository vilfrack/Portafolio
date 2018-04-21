$(function() {  
    var header = $("#cabecera");

    // obtenemos el height + padding de la sección 1
    var altoSeccion1 = $("#inicio").outerHeight();

    // obtenemos el height + padding de la sección 2
    // y le sumamos el de la sección 1
    var altoSeccion2 = $("#portafolio").outerHeight() + altoSeccion1;

    // cada vez que se produzca scroll en la ventana
    $(window).scroll(function(event) {

        // scrollTop la posición del elemento
        height = $(event.target).scrollTop();

        // dependiendo el lugar de la pantalla
        // modificamos la clase del header
        // par cambiar su color de fondo
        if (height > 400 ) {
            header.addClass("cambioCabecera").removeClass("cabecera");
        } else {
            header.addClass("cabecera").removeClass("cambioCabecera");
        }
    });
});