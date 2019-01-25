var googleHelper = (function ($) {
    var module = {
        onReady: function () {
            $('#resumeButton').on("click", function () {
                console.log("BUTTON CLICKED!");
                var path = location.pathname + "/onClick"
                ga('send', 'event', path);
            });
        }
    }
    return module;
})(jQuery);