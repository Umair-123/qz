$(document).ready(function () {
    $('#Button1').click(function () {
        
        var movie = $('#moviename').val().toString();
        $.getJSON("/Search/SearchMoviesAjax",
            {
                moviename: movie
            },
            function (data) {
                if (data != null && data!=false) {
                    var str = " ";
                    var count = 1;
                    alertify.success("Match Found");
                    for(var i=0;i<data.length;i++) {
                        str += "<h1>Movie number :  " + "<span>" + (count) + "</span></h1>";
                        str += "<h3>  MOVIE Title  :" + "&#8195;<span>" + data[i].Title + "</span></h3>";
                        str += "<h3>  Director:" + "<span>" + data[i].Director + "</span></h3>";
                        str += "<h3>  Year of Realease:" + "<span>" + data[i].YearReleased + "</span></h3>";
                        str += "<h3>  Genre:" + "<span>" + data[i].Genre + "</span></h3>";
                        count++;    
                    }
                
                
            }
            else if(data==false) {
                    str += "<h2>No Match Found</h2>";
                alertify.success("No match Found ");
                }
                $('#t1').html(str);
        });

    });
});