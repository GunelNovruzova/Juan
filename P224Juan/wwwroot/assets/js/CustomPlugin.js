$(document).ready(function () {
    $('.pro-nav').slick({
        slidesToShow: 4,
        asNavFor: '.product-large-slider',
        arrows: false,
        focusOnSelect: true
    });

    $('.product-large-slider').slick({
        fade: true,
        arrows: false,
        asNavFor: '.pro-nav'
    });

    $('.testimonial-active').slick({
        dots: true,
        arrows: false,
        responsive: [
            {
                breakpoint: 992,
                settings: {
                    dots: false
                }
            }
        ]
    });

    $('.img-zoom').zoom();
})