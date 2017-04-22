function btn_add() {
    $.modalOpen({
        id: "Form",
        title: "新增保障金退款",
        url: modulelUrl + "create",
        width: "800px",
        height: "600px",
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
}
function btn_applyfailed() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "Form",
        title: "退款审核失败",
        url: modulelUrl + "ApplyFailed?keyValue=" + keyValue,
        width: "800px",
        height: "600px",
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
}
function btn_applysus() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "Form",
        title: "退款审核成功",
        url: modulelUrl + "ApplySuccess?keyValue=" + keyValue,
        width: "800px",
        height: "600px",
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
}
function btn_failed() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "Form",
        title: "退款失败",
        url: modulelUrl + "RefundFailed?keyValue=" + keyValue,
        width: "800px",
        height: "600px",
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
}
function btn_sus() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "Form",
        title: "退款成功",
        url: modulelUrl + "Success?keyValue=" + keyValue,
        width: "800px",
        height: "600px",
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
}