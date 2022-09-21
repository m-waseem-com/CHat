$(document).on('click', '#btnAddComments1', function () {
    var editorData = CKEDITOR.instances['Msg'].getData();
    var url1 = window.location.href; debugger
    $.ajax({
        url: "/Home/AddComent",
        type: 'POST',
        data: {
            msg : editorData,
            path : url1
        }

    });
})