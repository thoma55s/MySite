var googleHelper = (function ($) {
    //var module = {
    //    onReady: function () {
            $('#resumeButton').on("click", function () {
                console.log("BUTTON CLICKED!");
                ga('send', 'pageview', 'resume/onClick');
            });
    //    }
    //}
    //return module;
})(jQuery);