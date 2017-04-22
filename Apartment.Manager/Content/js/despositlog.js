function btn_add() {
    $.modalOpen({
        id: "Form",
        title: "新增用户保障金记录",
        url: modulelUrl + "create",
        width: "800px",
        height: "600px",
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
}
function btn_edit() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "Form",
        title: "修改用户保障金记录",
        url: modulelUrl + "Edit?keyValue=" + keyValue,
        width: "800px",
        height: "600px",
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
}
function btn_delete() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.deleteForm({
        url: modulelUrl + "DeleteForm",
        param: { keyValue: keyValue },
        success: function () {
            $.currentWindow().$("#gridList").trigger("reloadGrid");
        }
    })
}

function btn_refund()
{
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
   
    $.modalOpen({
        id: "Form",
        title: "保障金退款",
        url: "/DepositRefund/DepositRefund/Create?keyvalue=" + keyValue,
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
    $.modalConfirm('您确认保障金交付<span class="label label-danger" style="margin:0px 5px;">成功</span>吗？请谨慎操作！', function (r) {
        if (r) {
            var postdata = { keyValue: keyValue };
            $.submitForm({
                url: modulelUrl + "Success",
                param: postdata,
                success: function () {
                    $.currentWindow().$("#gridList").trigger("reloadGrid");
                }
            })
        }
    });
}
function btn_failed() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalConfirm('您确认保障金交付<span class="label label-danger" style="margin:0px 5px;">失败</span>吗？请谨慎操作！', function (r) {
        if (r) {
            var postdata = { keyValue: keyValue };
            $.submitForm({
                url: modulelUrl + "Failed",
                param: postdata,
                success: function () {
                    $.currentWindow().$("#gridList").trigger("reloadGrid");
                }
            })
        }
    });
}