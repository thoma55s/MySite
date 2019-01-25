var googleHelper = (function ($) {
    var module = {
        onReady: function () {
            $('#resumeButton').on("click", function () {
                console.log("BUTTON CLICKED!");
                var path = location.pathname + "/onClick"
                ga('send', 'pageview', path);
            });
        }
    }
    return module;
})(jQuery);