var heightShowMore = '150px';
var inithHeight = '100px';
var modulelUrl = "/OrderManage/Order/";//区域的路径
$(function () {
    $("#District").GetSelectCity();
    gridList();
})
var $gridList;
function gridList() {
    $gridList = $("#gridList");
    $gridList.dataGrid({
        url: modulelUrl + "GetDemandGridJson?Proc=" + Proc,
        height: $(window).height() - 128,
        colModel: [
                    { label: "主键", name: "Id", hidden: true, key: true },
                    //{
                    //    label: "是否已经处理", name: "IsHandle", width: 100, align: "center",
                    //    formatter: function (cellvalue, options, rowObject) {
                    //        if (cellvalue == 0) {
                    //            return '<span class=\"label label-danger\">否</span>';
                    //        } if (cellvalue == 1) {
                    //            return '<span class=\"label label-info\">是</span>';
                    //        } else {
                    //            return '';
                    //        }
                    //    }
                    //},
                    //{
                    //    label: "是否已删除", name: "IsDel", width: 100, align: "center",
                    //    formatter: function (cellvalue, options, rowObject) {
                    //        if (cellvalue == 0) {
                    //            return '<span class=\"label label-info\">否</span>';
                    //        } if (cellvalue == 1) {
                    //            return '<span class=\"label label-danger\">是</span>';
                    //        } else {
                    //            return '';
                    //        }
                    //    }
                    //},
                    {
                        label: '租客', name: 'UserName', width: 150, align: 'left',
                        formatter: function (cellvalue, options, rowObject) {
                            return '<a href="javascript:void(0);" onclick="$.GetUserDetailModal(' + rowObject.UserId + ')">' + cellvalue + rowObject.UserGender + '/' + rowObject.UserAccount + ''
                                + '</a>';
                        }
                    },
                    { label: '用户账号', name: 'UserAccount', width: 100, align: 'left', hidden: true },
                    { label: '出价范围', name: 'Price', width: 100, align: 'left' },
                    { label: '出租方式', name: 'RentMode', width: 70, align: 'left' },
                    { label: '区', name: 'District', width: 70, align: 'left' },
                    {
                        label: "是否登录", name: "IsLogin", width: 100, align: "center",
                        formatter: function (cellvalue, options, rowObject) {
                            if (cellvalue == 0) {
                                return '<span class=\"label label-danger\">未登录</span>';
                            } if (cellvalue == 1) {
                                return '<span class=\"label label-info\">已登录</span>';
                            } else {
                                return '';
                            }
                        }
                    },
                    {
                        label: "保障金", name: "IsPay", width: 100, align: "center",
                        formatter: function (cellvalue, options, rowObject) {
                            if (cellvalue == 0) {
                                return '<span class=\"label label-danger\">未支付</span>';
                            } if (cellvalue == 1) {
                                return '<span class=\"label label-info\">已支付</span>';
                            } else {
                                return '';
                            }
                        }
                    },
                    { label: '拨打电话的次数', name: 'CallNum', width: 100, align: 'center' },
                    { label: '户型', name: 'HRoom', width: 70, align: 'left' },
                    {
                        label: "来源", name: "Source", width: 100, align: "center",
                        formatter: function (cellvalue, options, rowObject) {
                            if (cellvalue == 0) {
                                return '<span class=\"label label-info\">系统</span>';
                            } if (cellvalue == 1) {
                                return '<span class=\"label label-danger\">微信</span>';
                            } if (cellvalue == 2) {
                                return '<span class=\"label label-info\">苹果</span>';
                            } if (cellvalue == 3) {
                                return '<span class=\"label label-info\">安卓</span>';
                            } if (cellvalue == 4) {
                                return '<span class=\"label label-info\">PC</span>';
                            } else {
                                return '';
                            }
                        }
                    },
                    { label: '创建时间', name: 'AddTime', width: 150, align: 'left' },
                    //{ label: '更新时间', name: 'LastUpdateTime', width: 150, align: 'left' },
                    { label: '操作人账号', name: 'OperatorName', width: 150, align: 'left' },
                    { label: '其他需求', name: 'Other', width: 150, align: 'left' },
                    { label: '退单原因', name: 'BackReason', width: 150, align: 'left' },
        ],
        pager: "#gridPager",
        viewrecords: true
    });
    $("#btn_search").click(function () {
        $gridList.jqGrid('setGridParam', {
            postData: { keyword: $("#txt_keyword").val() },
        }).trigger('reloadGrid');
    });
}
function btn_add() {
    $.modalOpen({
        id: "Form",
        title: "新增需求单",
        url: modulelUrl + "DemandForm",
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
        title: "修改需求单",
        url: modulelUrl + "DemandForm?keyValue=" + keyValue,
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
        url: modulelUrl + "DeleteDemandForm",
        param: { keyValue: keyValue },
        success: function () {
            $.currentWindow().$("#gridList").trigger("reloadGrid");
        }
    })
}
function btn_details() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "Details",
        title: "查看需求单",
        url: modulelUrl + "Form?action=Details&keyValue=" + keyValue,
        width: "800px",
        height: "600px",
        btn: null,
    });
}
///派单
function btn_send() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "SendForm",
        title: "派单",
        url: modulelUrl + "SendForm?keyValue=" + keyValue,
        width: "800px",
        height: "600px",
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
}
//派单记录
function btn_sendLog() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "SendFormLog",
        title: "派单",
        url: modulelUrl + "SendFormLog?keyValue=" + keyValue,
        width: "800px",
        height: "600px",
        btn: null,
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
}
//退单
function btn_back() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "BackForm",
        title: "退单",
        url: modulelUrl + "BackForm?keyValue=" + keyValue,
        width: "800px",
        height: "300px",
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
}
//推荐房源
function btn_recommend() {
    var row = $("#gridList").jqGridRowValue();
    var keyValue = row.Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    var HRoomArr = row.HRoom.replace('室', ',').replace('厅', ',').replace(' ', '').split(',');
    var jsonParam = {
        UserAccount: row.UserAccount,
        Price: row.Price,
        RentMode: row.RentMode,
        District: row.District,
        HRoom: HRoomArr[0],
        HOffice: HRoomArr[1],
        Other: row.Other
    };
    console.log(jsonParam);
    sessionStorage["HouseParam"] = JSON.stringify(jsonParam);
    $.nfinetab.addTabByUrl('/OrderManage/Order/IntentForm?action=demand&param=' + encodeURI(JSON.stringify(jsonParam)));
}