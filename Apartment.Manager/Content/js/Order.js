//新增预约看房
function btn_addBooking() {
    var orderNo = $("#gridList").jqGridRowValue().OrderNo;
    if (orderNo == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "BookingForm",
        title: "新增预约看房",
        url: modulelUrl + "BookingForm?orderNo=" + orderNo,
        width: "900px",
        height: "600px",
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
}
//释放订单
function btn_drop() {
    var Ids = getMultipleRow();
    if (Ids) {
        $.modalOpen({
            id: "IsPassForm",
            title: "释放订单",
            url: modulelUrl + "RemarkForm?Ids=" + Ids.toString() + "&action=drop",
            width: "900px",
            height: "300px",
            callBack: function (iframeId) {
                top.frames[iframeId].submitForm();
            }
        });
    }
}
//是否满意
function btn_isPass() {
    var orderNo = $("#gridList").jqGridRowValue().OrderNo;
    if (orderNo == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "IsPassForm",
        title: "是否满意",
        url: modulelUrl + "IsPassForm?orderNo=" + orderNo,
        width: "900px",
        height: "600px",
        btn: null
    });
}
//查看日志
function btn_tracking() {
    var row = getSingleRow();
    if (row) {
        var LeaseCustomerId = row.LeaseCustomerId;
        var houseID = row.HouseID;
        var orderNo = row.OrderNo;
        $.modalOpen({
            id: "TrackingList",
            title: "查看日志",
            url: "/OrderManage/Order/TrackingList?LeaseCustomerId=" + LeaseCustomerId + "&houseID=" + houseID + "&orderNo=" + orderNo,
            width: "1000px",
            height: $(window).height() + "px",
            btn: null
        });
    }
}

//查看出价
function btn_priceDetails() {
    var row = getSingleRow();
    if (row) {
        var houseID = row.HouseID;
        var orderNo = row.OrderNo;
        $.modalOpen({
            id: "PriceList",
            title: "查看出价",
            url: "/LeaseOfferManage/LeaseOffer/PriceList?orderNo=" + orderNo + "&houseID=" + houseID,
            width: "1000px",
            height: "600px",
            btn: null
        });
    }
}

//新增出价
function btn_addPrice() {
    var row = getSingleRow();
    if (row) {
        var orderNo = row.OrderNo;
        var houseID = row.HouseID;
        if (orderNo == undefined) {
            $.modalAlert("请选择要操作的行！", 2);
            return;
        }
        $.modalOpen({
            id: "PriceForm",
            title: "新增出价",
            url: "/LeaseOfferManage/LeaseOffer/PriceForm?orderNo=" + orderNo + "&houseID=" + houseID + "&action=add",
            width: "800px",
            height: "600px",
            callBack: function (iframeId) {
                top.frames[iframeId].submitForm();
            }
        });
    }
}
//修改出价
function btn_editPrice() {
    var row = getSingleRow();
    if (row) {
        var keyValue = row.Id;
        var houseID = row.HouseID;
        $.modalOpen({
            id: "EditPrice",
            title: "修改出价",
            url: "/LeaseOfferManage/LeaseOffer/PriceForm?keyValue=" + keyValue + "&houseID=" + houseID + "&action=edit",
            width: "1000px",
            height: "600px",
            callBack: function (iframeId) {
                top.frames[iframeId].submitForm();
            }
        });
    }
}
//再次出价
function btn_againPrice() {
    var row = getSingleRow();
    if (row) {
        var keyValue = row.Id;
        var houseID = row.HouseID;
        $.modalOpen({
            id: "AgainPrice",
            title: "再次出价",
            url: "/LeaseOfferManage/LeaseOffer/PriceForm?keyValue=" + keyValue + "&houseID=" + houseID + "&action=again",
            width: "1000px",
            height: "600px",
            callBack: function (iframeId) {
                top.frames[iframeId].submitForm();
            }
        });
    }
}
//强制同意出价
function btn_compulsoryPrice() {
    var row = getSingleRow();
    if (row) {
        var keyValue = row.Id;
        var houseID = row.HouseID;
        $.modalOpen({
            id: "CompulsoryPrice",
            title: "强制同意出价",
            url: "/LeaseOfferManage/LeaseOffer/CompulsoryPrice?keyValue=" + keyValue + "&houseID=" + houseID,
            width: "1000px",
            height: "600px",
            callBack: function (iframeId) {
                top.frames[iframeId].submitForm();
            }
        });
    }
}
//订单恢复（删除）
function btn_restore() {
    var row = getSingleRow();
    if (row) {
        $.modalOpen({
            id: "RemarkForm",
            title: "订单恢复",
            url: modulelUrl + "RemarkForm?Ids=" + row.Id + "&action=RestoredByDel",
            width: "800px",
            height: "300px",
            callBack: function (iframeId) {
                top.frames[iframeId].submitForm();
            }
        });
    }
}
//订单恢复（释放）
function btn_restoreByRelease() {
    var row = getSingleRow();
    if (row) {
        $.modalOpen({
            id: "RestoredForm",
            title: "订单恢复",
            url: modulelUrl + "RemarkForm?Ids=" + row.Id + "&action=RestoreByRelease",
            width: "800px",
            height: "300px",
            callBack: function (iframeId) {
                top.frames[iframeId].submitForm();
            }
        });
    }
}
//订单删除
function btn_delete() {
    var Ids = getMultipleRow();
    if (Ids) {
        $.modalOpen({
            id: "RestoredForm",
            title: "订单删除",
            url: modulelUrl + "RemarkForm?Ids=" + Ids.toString() + "&action=delete",
            width: "800px",
            height: "300px",
            callBack: function (iframeId) {
                top.frames[iframeId].submitForm();
            }
        });
    }
}
//推荐房源
function btn_recommend() {
    var row = getSingleRow();
    if (row) {
        var keyValue = row.Id;
        if (keyValue == undefined) {
            $.modalAlert("请选择要操作的行！", 2);
            return;
        }
        //查询房源详细
        $.ajax({
            url: "/HouseManage/House/GetFormJson",
            data: { keyValue: row.HouseID },
            dataType: "json",
            async: false,
            success: function (data) {
                var _Price = data.HRent;
                var _price = "";
                if (_Price >= 0 && _Price < 1500)
                    _price = "1500元以下";
                if (_Price >= 1500 && _Price < 3000)
                    _price = "1500-3000元";
                if (_Price >= 3000 && _Price < 4000)
                    _price = "3000-4000元";
                if (_Price >= 4000 && _Price < 5000)
                    _price = "4000-5000元";
                if (_Price >= 5000 && _Price < 7000)
                    _price = "5000-7000元";
                if (_Price >= 7000)
                    _price = "7000元以上";
                var jsonParam = {
                    UserAccount: row.LeasingCustomerMobile,
                    Price: _price,
                    RentMode: data.RentMode,
                    District: data.District,
                    HRoom: data.HRoom,
                    HOffice: data.HOffice,
                    Other: ''
                };
                //sessionStorage["HouseParam"] = JSON.stringify(jsonParam);
                $.nfinetab.addTabByUrl('/OrderManage/Order/IntentForm?action=demand&param=' + encodeURI(JSON.stringify(jsonParam)));
            }
        });
    }
}
//生成合同
function btn_sure() {
    var row = getSingleRow();
    if (row) {
        $.modalOpen({
            id: "GenerateForm",
            title: "生成合同",
            url: "/LeaseContractManage/LeaseContract/GenerateForm?orderNo=" + row.OrderNo + "&UserId=" + row.LeaseCustomerId,
            width: "800px",
            height: "300px",
            callBack: function (iframeId) {
                top.frames[iframeId].submitForm();
            }
        });
    }
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
//添加日志
function btn_addLog() {
    var row = getSingleRow();
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
//删除订单
function btn_ODelete() {
    var row = getSingleRow();
    if (row) {
        $.modalOpen({
            id: "DeleteForm",
            title: "删除订单",
            url: "/OrderManage/Order/RemarkForm?orderNo=" + row.OrderNo + "&userId=" + row.LeaseCustomerId + "&action=delete",
            width: "900px",
            height: "300px",
            callBack: function (iframeId) {
                top.frames[iframeId].submitForm();
            }
        });
    }
}
//处理出价（满意、不满意）
function btn_handlePrice() {
    var row = getSingleRow();
    if (row) {
        var keyValue = row.Id;
        var houseID = row.HouseID;
        $.modalOpen({
            id: "HandlePrice",
            title: "处理出价",
            url: "/LeaseOfferManage/LeaseOffer/HandlePrice?keyValue=" + keyValue + "&houseID=" + houseID,
            width: "1000px",
            height: "600px",
            btn: null
        });
    }
}
//获取单行数据
function getSingleRow() {
    var ids = $("#gridList").jqGrid('getGridParam', 'selarrrow');
    if (ids.length == 0) {
        $.modalAlert('请先选择数据行！', 2);
        return false;
    }
    if (ids.length > 1) {
        $.modalAlert('只能选择一行记录！', 2);
        return false;
    }
    return $("#gridList").jqGrid('getRowData', ids[0]);
}
//获取多行数据
function getMultipleRow() {
    var ids = $("#gridList").jqGrid('getGridParam', 'selarrrow');
    if (ids.length == 0) {
        $.modalAlert('请先选择数据行！', 2);
        return false;
    }
    return ids;
}