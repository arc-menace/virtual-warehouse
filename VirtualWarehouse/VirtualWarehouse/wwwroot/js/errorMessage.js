function SetSuccessMessage(messageElement, messageText) {
    MessageElementIsjQuery(messageElement);

    messageElement.removeClass('alert-danger');
    messageElement.addClass('alert-success');
    messageElement.text(messageText);
    messageElement.css('display', 'block');
}

function SetErrorMessage(messageElement, messageText) {
    MessageElementIsjQuery(messageElement);

    messageElement.removeClass('alert-success');
    messageElement.addClass('alert-danger');
    messageElement.text(messageText);
    messageElement.css('display', 'block');
}

function HideMessage(messageElement) {
    MessageElementIsjQuery(messageElement);

    messageElement.text('');
    messageElement.css('display', 'none');
}

function MessageElementIsjQuery(messageElement) {
    if (!(messageElement instanceof jQuery)) {
        throw 'messageElement must be a jQuery object';
    }
}