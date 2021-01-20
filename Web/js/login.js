$(document).ready(function(){
    $("#go").click(function (e) {
        e.preventDefault();
        var username = $("#login").val().trim();
        var password = $("#password").val().trim();

        if( username != "" && password != "" ){
            $.ajax({
                url: 'https://localhost:44371/login',
                dataType: 'json',
                type: 'post',
                contentType: 'application/json',
                data: JSON.stringify({username:username,password:password}),
                success: function(data, status){
                    //alert("Data: " + data + "\nStatus: " + status);
                    if(data){ 
                        window.location.replace("/Web/views/welcome.html");
                    } else {
                        $("#error").css("display","block");
                    }
              }
            })
        }
    });
});