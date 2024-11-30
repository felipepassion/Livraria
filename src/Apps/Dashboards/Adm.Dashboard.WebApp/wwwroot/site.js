window.setTheme = (themeName) => {
    localStorage.setItem('theme', themeName);
};

window.getTheme = () => {
    return localStorage.getItem('theme');
};


function openModal(id) {
    try {
        $("#btn_" + id).animatedModal();
        $("#btn_" + id).click();
        $("#modal_" + id).show();
        $("#modal_" + id).focus();
    } catch (e) {

    }
}

function submitForm() {
    console.log($(".btn-proxima"));

    $(".btn-proxima").click();
}

function closeModal(id) {
    $(".close-modal_" + id).click();
}


function exportSave(filename, bytesBase64) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-stream;base64," + bytesBase64;
    document.body.appendChild(link); // Needed for Firefox

    link.click();
    document.body.removeChild(link);
}

function updateMyReferences(searchClss, newVal) {
    $("." + searchClss).html(newVal);
}

function clickMe(elementId) {
    $("#" + elementId).click();
}

function clickMe2(elementId) {
    $("#" + elementId).find("button").click();
}

$(document).keydown(function (event) {
    if (event.keyCode == 27) {
        $('.btn-closemodal').click();
    }
});

var modals = [];


function SetDotNetHelper(dotNetHelper) {
    window.dotNetHelper = dotNetHelper;
}


$(document).ready(function () {
});

function updateMyHtml(id, htmlContent) {
    console.log($("#" + id));
    console.log(htmlContent);
    $("#" + id).html(htmlContent);
}