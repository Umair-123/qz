$(document).ready(function () {
    $("#facebookbtn").sticky({ bottomSpacing: 0, center: true, className: "hey" });
    $('#btnCheck').click(function () {
        $('#btnCheck').hide();
        var userName = $('#UserName').val();
        var newbtn = $('<img  id="loadingimg" src="/Images/loading_spinner.gif" >');
        $('#loginbtncheck').append(newbtn);
        $.getJSON("/Account/CheckUserName?UserName=" + userName, function (data) {
            $('#loadingimg').remove();
            $('#btnCheck').show();
            if (data) {
                $('#result').text("User already exists in database");
                alertify.success("User already exists in database");
            }
            else {

                $('#result').text("User Name is available");
                alertify.success("User Name is Available ");
            }
        });

    });
    
    $('#userpass').keypress(function () {
        $("#userpass").complexify({}, function (valid, complexity) {
            alert("Complexity is :" + complexity);
        }); 
    });

     

});
