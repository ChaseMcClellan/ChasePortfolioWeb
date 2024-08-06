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