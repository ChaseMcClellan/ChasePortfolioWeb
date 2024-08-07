$(document).ready(function () {
    $("#contactForm").on("submit", function (event) {
        event.preventDefault();

        var formData = {
            name: $("#name").val(),
            email: $("#email").val(),
            message: $("#message").val()
        };

        $.ajax({
            type: "POST",
            url: "/Home/Contact",
            data: formData,
            success: function (response) {
                alert("Message sent successfully!");
                $("#contactForm")[0].reset();
            },
            error: function () {
                alert("There was an error sending the message.");
            }
        });
    });
});

$(document).ready(function () {
    $(".navbar a").each(function (index) {
        $(this).css('animation-delay', (index * 0.1) + 's');
    });

    $(".navbar a").hover(
        function () {
            $(this).animate({ paddingLeft: '25px' }, 300);
        },
        function () {
            $(this).animate({ paddingLeft: '20px' }, 300);
        }
    );
});