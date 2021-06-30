$(document).ready(function() {
    $("#SignUpButton").click(function (e) {
        if ($("#SignUpUsername").text().isEmpty) {
            $("#SignUpMessage").text("Please specify a username");
        }
    });

});
