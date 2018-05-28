var uri = "http://localhost:63027/";
var ADD_BOOK_URI = "addBook"
var selectedBookId = ""

function addItem() {
    const book = {
        'title': $('#titleInput').val(),
        'authorFirstName': $('#authorFirstName').val(),
        'authorLastName': $('#authorLastName').val(),
        'gender': $('#bookGender').val()
    };

    var count = $('#bookCount').val()

    $.ajax({
        type: 'POST',
        accepts: 'application/json',
        url: uri + ADD_BOOK_URI + "/" + count,
        data: JSON.stringify(book),
        contentType: 'application/json',
        success: function (result) {
        }
    });
}

function setSelectedBookId(id) {
    selectedBookId = id
}

function loanBook(bookId) {
    const loan = {
        'bookId': selectedBookId,
        'readerEmail': $('#readerEmailLoan').val(),
    };

    $.ajax({
        type: 'POST',
        accepts: 'application/json',
        url: uri + "loan",
        data: JSON.stringify(loan),
        contentType: 'application/json',
        success: function (response) {

        },
        error: function (response) {

        }
    });
    
}

function takeUserLoan() {
    window.location.replace(uri + "userLoans/" + $('#readerEmailCheckLoan').val())
}

function userExists() {
    const reader = {
        'email': $('#readerEmailCheckLoan').val()
    };

    $.ajax({
        type: 'POST',
        accepts: 'application/json',
        url: uri + "Reader" + "/" + "UserExists",
        data: JSON.stringify(reader),
        contentType: 'application/json',
        success: function (response) {
            returnVal = response
            alert(returnVal)
        },
        error: function (response) {
            test(response)
        }
    });
}

function test(t) {
    console.log(t)
}

function registerUser() {
    const reader = {
        'firstName': $('#readerName').val(),
        'lastName': $('#lastName').val(),
        'adress': $('#adress').val(),
        'email': $('#readerEmail').val()
    };

    $.ajax({
        type: 'POST',
        accepts: 'application/json',
        url: uri + "Reader" + "/" + "RegisterUser",
        data: JSON.stringify(reader),
        contentType: 'application/json',
        success: function (result) {
        }
    });
}