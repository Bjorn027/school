
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

    } else {
        alert('Wrong username or password')
        $('.clear1 input').val('')
    }
}

