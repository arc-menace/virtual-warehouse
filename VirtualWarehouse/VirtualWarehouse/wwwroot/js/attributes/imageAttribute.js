var newImage = $('#newImage');
var newImageId = $('#newImageId');
var newImageUpload = $('#newImageUpload');
var newImageErrorMessage = $('#addImageErrorMessage');

newImageUpload.on('change', function () {
    var formData = new FormData();
    formData.append('image', newImageUpload[0].files[0]);

    $.ajax({
        url: "/Image/Upload",
        method: "POST",
        data: formData,
        processData: false,
        contentType: false,
        success: function (data) {
            newImage.prop('src', data.externalUrl);
            newImage.prop('title', data.fileName);
            newImage.css('display', 'block');
            newImageId.val(data.id);

            SetSuccessMessage(newImageErrorMessage, "Image Successfully Loaded")
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(jqXHR.responseText);
            SetErrorMessage(newImageErrorMessage, jqXHR.responseText);
            newImageUpload.val('');
        }
    });
});