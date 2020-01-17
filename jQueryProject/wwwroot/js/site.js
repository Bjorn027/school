
var ClassicP = 299.99
var HingesP = 199.99
var HardP = 399.99



function addClassic() {
    //add this to the cart
    $("#myTable tbody").append(
    "<tr>" +
    "<td>Classic</td>" +
    "<td>" + ClassicP + "</td>" +
    "</tr>"
   );
}
function addHinges() {
    //add this to the cart
    $("#myTable tbody").append(
        "<tr>" +
        "<td>Hinges</td>" +
        "<td>" + HingesP + "</td>" +
        "</tr>"
    );
}

function addHard() {
    //add this to the cart
    $("#myTable tbody").append(
        "<tr>" +
        "<td>Hardwood</td>" +
        "<td>" + HardP + "</td>" +
        "</tr>"
    );
}



function hide() {
    $('#myTable').fadeOut(600)
}
function show() {
    $('#myTable').fadeIn(600)
}


function doLogin() {
    var user = $('#username').val()
    var pass = $('#password').val()
    if (user == "Shawn" && pass == "jQuery") {
        alert('You are now logged in')
        $('.clear1 input').val('')
    }
    else {
        alert('Wrong username and/or password')
        $('.clear1 input').val('')
    }
}

function randColor () {
    var font = ["Impact", "Times New Roman", "Trebuchet MS", "Rockwell Nova", "Comic Sans MS", ];
    var rand = font[Math.floor(Math.random() * font.length)];
    $('#randomness').css('font-family', rand);
    var size = [10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50];
    var rand2 = size[Math.floor(Math.random() * size.length)];
    $('#randomness').css('font-size', rand2);
    var color = ["red", "blue", "gray", "white", "black", "yellow", "green", "pink", "purple", "orange"];
    var rand3 = color[Math.floor(Math.random() * color.length)];
    $('#randomness').css('color', rand3);
    //$('#randomness').animate({opacity: 0.25})
}