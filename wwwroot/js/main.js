(function ($) {
    "use strict";

    window.ToggleSidebar = function () {
        console.log("JS ToggleSidebar called by C#");
        window.dotNetAdminHelper.invokeMethodAsync('ToggleSidebar');

        return "111"
    };





    window.initializeAdminInterop = (dotNetHelper) => {
        console.log("zzz");
        window.dotNetAdminHelper = dotNetHelper;
        return "zzz";
    };
    window.initializeHeaderInterop = (dotNetHelper) => {
        window.dotNetHeaderHelper = dotNetHelper;
    };
    window.initializeInterop = (dotNetHelper) => {
        window.dotNetHelper = dotNetHelper;
    };
   
    window.ClearCart = () => {
        dotNetHeaderHelper.invokeMethodAsync('ClearCart');
    };
    window.RemoveFromCart = (id) => {
        dotNetHeaderHelper.invokeMethodAsync('RemoveFromCart', id);
    };
    window.HeaderGoTo = (path) => {
        dotNetHeaderHelper.invokeMethodAsync('HeaderGoTo', path);
    };
    window.AddToCart = (id) => {
        dotNetHelper.invokeMethodAsync('AddToCart', id);
    };
    window.GoToDetails = (id) => {
        dotNetHelper.invokeMethodAsync('GoToDetails', id);
    };
   
    window.initializeScripts = (max, dotNetHelper) => {
        // Mobile Nav toggle
        $('.menu-toggle > a').off('click').on('click', function (e) {
            e.preventDefault();
            $('#responsive-nav').toggleClass('active');
        });

        // Fix cart dropdown from closing
        $('.cart-dropdown').off('click').on('click', function (e) {
            e.stopPropagation();
        });

        /////////////////////////////////////////

        // Products Slick
        $('.products-slick').each(function () {
            var $this = $(this),
                $nav = $this.attr('data-nav');

            if (!$this.hasClass('slick-initialized')) {
                $this.slick({
                    slidesToShow: 4,
                    slidesToScroll: 1,
                    autoplay: true,
                    infinite: true,
                    speed: 300,
                    dots: false,
                    arrows: true,
                    draggable: false,      // Disables mouse/touch dragging
                    swipe: false,          // Disables swipe gestures
                    touchMove: false,       // Disables touch movement
                    appendArrows: $nav ? $nav : false,
                    responsive: [
                        {
                            breakpoint: 991,
                            settings: {
                                slidesToShow: 2,
                                slidesToScroll: 1,
                            }
                        },
                        {
                            breakpoint: 480,
                            settings: {
                                slidesToShow: 1,
                                slidesToScroll: 1,
                            }
                        },
                    ]
                });
            }
        });

        // Products Widget Slick
        $('.products-widget-slick').each(function () {
            var $this = $(this),
                $nav = $this.attr('data-nav');

            if (!$this.hasClass('slick-initialized')) {
                $this.slick({
                    infinite: true,
                    autoplay: true,
                    speed: 300,
                    dots: false,
                    arrows: true,
                    draggable: false,      // Disables mouse/touch dragging
                    swipe: false,          // Disables swipe gestures
                    touchMove: false,       // Disables touch movement
                    appendArrows: $nav ? $nav : false,
                });
            }
        });

        /////////////////////////////////////////

        // Product Main img Slick
        if (!$('#product-main-img').hasClass('slick-initialized')) {
            $('#product-main-img').slick({
                infinite: true,
                speed: 300,
                dots: false,
                arrows: true,
                fade: true,
                asNavFor: '#product-imgs',
            });
        }

        if (!$('#product-imgs').hasClass('slick-initialized')) {
            $('#product-imgs').slick({
                slidesToShow: 3,
                slidesToScroll: 1,
                arrows: true,
                centerMode: true,
                focusOnSelect: true,
                centerPadding: 0,
                vertical: true,
                asNavFor: '#product-main-img',
                responsive: [
                    {
                        breakpoint: 991,
                        settings: {
                            vertical: false,
                            arrows: false,
                            dots: true,
                        }
                    },
                ]
            });
        }

        // Product img zoom
        var zoomMainProduct = document.getElementById('product-main-img');
        if (zoomMainProduct) {
            $('#product-main-img .product-preview').zoom();
        }

        /////////////////////////////////////////

        // Input number
        $('.input-number').each(function () {
            var $this = $(this),
                $input = $this.find('input[type="number"]'),
                up = $this.find('.qty-up'),
                down = $this.find('.qty-down');

            down.off('click').on('click', function () {
                var value = parseInt($input.val()) - 1;
                value = value <= 0 ? 0 : value;
                $input.val(value);
                $input.change();
                updatePriceSlider($this, value);
            });

            up.off('click').on('click', function () {
                var value = parseInt($input.val()) + 1;
                $input.val(value);
                $input.change();
                updatePriceSlider($this, value);
            });
        });

        var priceInputMax = document.getElementById('price-max');
        var priceInputMin = document.getElementById('price-min');

        if (priceInputMax && priceInputMin) {
            priceInputMax.addEventListener('input', function () {
                updatePriceSlider($(this).parent(), this.value);
            });

            priceInputMin.addEventListener('input', function () {
                updatePriceSlider($(this).parent(), this.value);
            });
        }

        function updatePriceSlider(elem, value) {
            if (elem.hasClass('price-min')) {
                priceSlider.noUiSlider.set([value, null]);
            } else if (elem.hasClass('price-max')) {
                priceSlider.noUiSlider.set([null, value]);
            }
        }

        // Price Slider
        var priceSlider = document.getElementById('price-slider');
        if (priceSlider && !priceSlider.noUiSlider) {
            noUiSlider.create(priceSlider, {
                start: [0, max],
                connect: true,
                step: 1,
                range: {
                    'min': 0,
                    'max': max
                }
            });

            priceSlider.noUiSlider.on('update', function (values, handle) {
                dotNetHelper.invokeMethodAsync('OnPrixChange', parseFloat(values[handle]), handle);

                var value = values[handle];
                if (handle) {
                    priceInputMax.value = value;
                } else {
                    priceInputMin.value = value;
                }
            });
        }
    };

})(jQuery);
