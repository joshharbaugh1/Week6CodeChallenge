$(document).ready(function () {

    $('body').on('click', '.ajax-link', function () {

        var url = $(this).data('url');
        
        $.get(url, function (data) {
            $("#content").html(data);
        });
    });

        $('body').on('click', '.ajax-tab', function () {

            var url = $(this).data('url');
        
            $.get(url, function (data) {
                $(".tab-content").html(data);
            });
        });

        $('body').on('submit', '.ajax-form', function (data) {
            event.preventDefault();

            $.post($(this).data('posturl'), $(this).serialize(), function (data) {
                $('.ajax-form-content').html(data);
            });
        });
});