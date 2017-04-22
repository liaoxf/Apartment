var modulelUrl = "/LeaseContractManage/LeaseContract/";//区域的路径
//合同生成确认
//生成合同
function btn_sure() {
    var RowObj = $("#gridList").jqGridRowValue();
    var orderNo = RowObj.OrderNo;
    var userId = RowObj.LeaseCustomerId;
    if (orderNo == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "GenerateForm",
        title: "生成合同",
        url: modulelUrl + "GenerateForm?orderNo=" + orderNo + "&UserId=" + userId,
        width: "800px",
        height: "600px",
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
    //$.modalConfirm('您确认要生成该<span class="label label-danger" style="margin:0px 5px;">订单合同</span>吗？请谨慎操作！', function (r) {
    //    if (r) {
    //        var postdata = { orderNo: orderNo, UserId: userId };
    //        $.submitForm({
    //            url: modulelUrl + "Sure",
    //            param: postdata,
    //            success: function () {
    //                //$.currentWindow().$("#gridList").trigger("reloadGrid");
    //                $.modalOpen({
    //                    id: "Form",
    //                    title: "填写/修改合同资料",
    //                    url: modulelUrl + "form?orderNo=" + orderNo,
    //                    width: "800px",
    //                    height: "600px",
    //                    callBack: function (iframeId) {
    //                        top.frames[iframeId].submitForm();
    //                    }
    //                });
    //            }
    //        })
    //    }
    //});
}
//填写合同资料
function btn_generate() {
    var orderNo = $("#gridList").jqGridRowValue().OrderNo;
    if (orderNo == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "ContractForm",
        title: "填写/修改合同资料",
        url: modulelUrl + "form?orderNo=" + orderNo,
        width: "800px",
        height: "600px",
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
}
//查看合同
function btn_details() {
    var orderNo = $("#gridList").jqGridRowValue().OrderNo;
    if (orderNo == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "Form",
        title: "查看合同资料",
        url: modulelUrl + "form?action=Details&orderNo=" + orderNo,
        width: "800px",
        height: "600px",
        btn: null,
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
}
//即将到期提醒
function btn_remind() {
    var orderNo = $("#gridList").jqGridRowValue().OrderNo;
    if (orderNo == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalConfirm('您确认要发送到期提醒吗？', function (r) {
        if (r) {
            var postdata = { orderNo: orderNo };
            $.submitForm({
                url: modulelUrl + "SendRemind",
                param: postdata,
                success: function () {
                    $.currentWindow().$("#gridList").trigger("reloadGrid");
                }
            })
        }
    });

}
//添加日志
function btn_addLog() {
    var row = $("#gridList").jqGridRowValue();
    if (row) {
        var LeaseCustomerId = row.LeaseCustomerId;
        var houseID = row.HouseID;
        var orderNo = row.OrderNo;
        if (orderNo == undefined) {
            $.modalAlert("请选择要操作的行！", 2);
            return;
        }
        $.modalOpen({
            id: "LogForm",
            title: "添加日志",
            url: "/OrderManage/Order/LogForm?LeaseCustomerId=" + LeaseCustomerId + "&houseID=" + houseID + "&orderNo=" + orderNo,
            width: "1000px",
            height: $(window).height() + "px",
            btn: null,
            //callBack: function (iframeId) {
            //    top.frames[iframeId].submitForm();
            //}
        });
    }
}