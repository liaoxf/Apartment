var $gridList;
var colModel=[
                    { label: "主键", name: "Id", hidden: true, key: true },
                    {
                        label: '标题', name: 'HouseTitle', width: 150, align: 'left',
                        formatter: function (cellvalue, options, rowObject) {
                            return '<a href="/CommonPageManage/House/HouseDetail?houseId=' + rowObject.Id + '">' + cellvalue + '</a>';
                        }
                    },
                     { label: '挂牌价', name: 'HRent', width: 60, align: 'left' },
                    {
                        label: '房源状态', name: 'AuditStatus', width: 60, align: 'left',
                        formatter: function (cellvalue, options, rowObject) {
                            return rowObject.AuditStatus == "0" ? "<span class='label label-default'>未审核</span>" : rowObject.AuditStatus == "1" ? "<span  class='label label-success'>已审核</span>" : "<span class='label label-warning'>审核拒绝</span>";
                        }
                    },
                     {
                         label: '是否上架', name: 'IsOn', width: 60, align: 'left',
                         formatter: function (cellvalue, options, rowObject) {
                             return rowObject.IsOn == "0" ? "<span class='label label-default'>未上架</span>" : "<span class='label label-success'>已上架</span>";
                         }
                     },
                    {
                        label: '出租状态', name: 'HStatus', width: 60, align: 'left',
                        formatter: function (cellvalue, options, rowObject) {
                            return rowObject.HStatus == "0" ? "<span class='label label-default'>未出租</span>" : "<span class='label label-success'>已出租</span>";
                        }
                    },
                    {
                        label: '室厅卫', name: 'HRoom', width: 80, align: 'left',
                        formatter: function (cellvalue, options, rowObject) {
                            return '<span>' + rowObject.HRoom + "室" + rowObject.HOffice + "厅" + rowObject.HWashroom + "卫" + '</span>';
                        }
                    },
                     {
                         label: '图片数', name: 'PicsCount', width: 60, align: 'left', formatter: function (cellvalue, options, rowObject) {
                             return '<a href="/CommonPageManage/House/HouseDetail?houseId=' + rowObject.Id + '">' + (cellvalue <= 0 ? "<span class='label label-default'>0</span>" : "<span class='label label-success'>" + cellvalue + "</span>") + '</a>';
                         }
                     },
                    {
                        label: '视频数', name: 'VideoCount', width: 60, align: 'left',
                        formatter: function (cellvalue, options, rowObject) {
                            return '<a href="/CommonPageManage/House/HouseDetail?houseId=' + rowObject.Id + '">' + (cellvalue <= 0 ? "<span class='label label-default'>0</span>" : "<span class='label label-success'>" + cellvalue + "</span>") + '</a>';
                        }
                    },
                    {
                        label: '收藏量', name: 'CollectionNumber', width: 60, align: 'left',
                        formatter: function (cellvalue, options, rowObject) {
                            return '<a href="/CommonPageManage/House/HouseDetail?houseId=' + rowObject.Id + '">' + (cellvalue <= 0 ? "<span class='label label-default'>0</span>" : "<span class='label label-success'>" + cellvalue + "</span>") + '</a>';
                        }
                    },
                     {
                         label: '意向数', name: 'InterestNumber', width: 80, align: 'left',
                         formatter: function (cellvalue, options, rowObject) {
                             return '<a href="/CommonPageManage/House/HouseDetail?houseId=' + rowObject.Id + '">' + (cellvalue <= 0 ? "<span class='label label-default'>0</span>" : "<span class='label label-success'>" + cellvalue + "</span>") + '</a>';
                         }
                     },
                    {
                        label: '通话量', name: 'CallNumber', width: 60, align: 'left',
                        formatter: function (cellvalue, options, rowObject) {
                            return '<a href="/CommonPageManage/House/HouseDetail?houseId=' + rowObject.Id + '">' + (cellvalue <= 0 ? "<span class='label label-default'>0</span>" : "<span class='label label-success'>" + cellvalue + "</span>") + '</a>';
                        }
                    },
                     { label: '付款方式', name: 'RentMoneyWay', width: 80, align: 'left' },

                    {
                        label: '房东', name: 'UserRealName', width: 120, align: 'left', formatter: function (cellvalue, options, rowObject) {
                            return '<a href="/CommonPageManage/User/UserDetail?userId=' + rowObject.UserId + '">' + cellvalue + '/' + rowObject.LinkTel + '</a>';
                        }
                    },

                    {
                        label: '小区名称', name: 'AreasName', width: 80, align: 'left',
                        formatter: function (cellvalue, options, rowObject) {
                            return '<a href="/CommonPageManage/housevillage/villagedetails?villageId=' + rowObject.HouseVillageId + '">' +rowObject.HouseVillageId +"|"+ rowObject.AreasName + '</a>';
                        }
                    },
                    {
                        label: '来源', name: 'Souce', width: 60, align: 'left',
                        formatter: function (cellvalue, options, rowObject) {
                            return rowObject.Souce == "0" ? "<span class='label label-default'>房东上传</span>" : rowObject.AuditStatus == "1" ? "<span  class='label label-success'>后台上传</span>" : "<span class='label label-warning'>其他</span>";
                        }
                    },
                    {
                        label: '是否置顶', name: 'IsUp', width: 60, align: 'left',
                        formatter: function (cellvalue, options, rowObject) {
                            return rowObject.IsUp == "0" ? "<span class='label label-default'>未置顶</span>" : rowObject.IsUp == "1" ? "<span  class='label label-success'>已置顶</span>" : "<span class='label label-warning'>未置顶</span>";
                        }
                    },
                    {
                        label: '出租方式', name: 'RentMode', width: 60, align: 'left',
                    },
                    //{
                    //    label: '省市区', name: 'Province', width: 150, align: 'left',
                    //    formatter: function (cellvalue, options, rowObject) {
                    //        console.log(rowObject.LeaseCustomerId)
                    //        return '<span>' + rowObject.Province + "-" + rowObject.City + "-" + rowObject.District + '</span>';
                    //    }
                    //},
                     { label: '标签', name: 'HTags', width: 80, align: 'left' },
                    { label: '详细地址', name: 'DetailAddress', width: 150, align: 'left' },
                    { label: '使用面积', name: 'RentalArea', width: 60, align: 'left' },
        { label: '审核备注', name: 'CommentsByAdmin', width: 60, align: 'left' },
                    {
                        label: '创建时间', name: 'AddTime', width: 70, align: 'left', formatter: "date", formatoptions: { srcformat: 'Y-m-d H:i:s', newformat: 'Y-m-d H:i:s' }
                    },
                    {
                        label: '更新时间', name: 'LastUpdateTime', width: 70, align: 'left', formatter: "date", formatoptions: { srcformat: 'Y-m-d H:i:s', newformat: 'Y-m-d H:i:s' }
                    },
                    { label: '审核人', name: 'AuditName', width: 80, align: 'left' },


];
function gridList(action, multiselect, colModel2) {
    $gridList = $("#gridList");
    var multiselect = multiselect || true;//是否为多选
    $gridList.dataGrid({
        url: modulelUrl + action,
        height: $(window).height() - 128,
        datatype: 'local',
        colModel: colModel2 ||colModel,
        pager: "#gridPager",
        viewrecords: true,
        multiselect: multiselect,
    });
}

function SearchHandler() {
    //console.log($('#SearchForm').formSerialize());
    //console.log(JSON.stringify($('#SearchForm').formSerialize()));
    $gridList.jqGrid('setGridParam', {
        datatype: 'json',
        postData: $('#SearchForm').formSerialize(),
    }).trigger('reloadGrid');
}

//商圈选择
function gettareas(obj) {
    var $this = $(obj);
    $("#TradingArea").val('').trigger("change");
    $.ajax({
        url: "/SystemManage/Subway/GetTreeSelectJsonByDistrict",
        data: { district: $this.val() },
        dataType: "json",
        async: false,
        success: function (MYDATA) {
            if (MYDATA.length == 0) {
                $("#TradingArea").empty();
            } else {
                $("#TradingArea").select2({
                    minimumResultsForSearch: true,
                    placeholder: "请选择商圈",
                    allowClear: true,
                    data: MYDATA
                });
            }
        }
    });
}
//小区选择
function getvillages(obj,villageid) {
    var $this = $(obj);
    var villageid = villageid || "";
    $("#TradingArea").val('').trigger("change");
    $.ajax({
        url: "/housevillage/village/GetSelectJson",
        dataType: "json",
        async: false,
        data: { district: $this.val() },
        success: function (MYDATA) {
            $("#HouseVillageId").empty();
            // sessionStorage.setItem("villageselectData", JSON.stringify(MYDATA));
            $("#HouseVillageId").select2({
                placeholder: "请选择小区",
                multiple: false,
                allowClear: true,
                data: MYDATA
            });
           
        }
    });
}
//地铁选择
function getsubway() {
    var city = $("#City").val();
    $.ajax({
        url: "/SystemManage/Area/GetTreeSelectJson3",
        dataType: "json",
        async: false,
        success: function (MYDATA) {
            $("#HDistrict").select2({
                placeholder: "请选择版块",
                tokenSeparators: [',', ' '],
                multiple: true,
                allowClear: true,
                data: MYDATA
            });
        }
    });
}
//地铁站选择
function GetTreeSelectJsonByCity(obj) {
    $("#SubwayStations").val('').trigger("change");
    $.ajax({
        url: "/SystemManage/Subway/GetTreeSelectJsonByCity",
        data: { city: "上海市" },
        dataType: "json",
        async: false,
        success: function (MYDATA) {
            if (MYDATA.length == 0) {
                $("#SubwayStations").empty();
            } else {
                $("#SubwayStations").select2({
                    minimumResultsForSearch: true,
                    placeholder: "请选择地铁站",
                    allowClear: true,
                    data: MYDATA
                });
            }
        }
    });

}
function btn_add() {
    $.nfinetab.addTabByUrl('/housemanage/house/create');
    //$.modalOpen({
    //    id: "Form",
    //    title: "新增房源",
    //    url: modulelUrl + "/create",
    //    width: "800px",
    //    height: "600px",
    //    btn:null,
    //});
}
function btn_addpics() {
    var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalOpen({
            id: "Form",
            title: "新增房源图片",
            url: "/housemanage/housepics/create?id=" + keyValue,
            width: "800px",
            height: "600px",
            callBack: function (iframeId) {
                top.frames[iframeId].submitForm();
            }
        });
    }

}
function btn_pics() {
    var keyValue = getkeyvalue();// $("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalOpen({
            id: "Form",
            title: "新增房源图片",
            url: "/housemanage/housepics/index?id=" + keyValue,
            width: "800px",
            height: "600px",
            callBack: function (iframeId) {
                top.frames[iframeId].submitForm();
            }
        });
    }
}
function btn_addexpand() {
    var keyValue = getkeyvalue();// $("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalOpen({
            id: "Form",
            title: "新增房源扩展信息",
            url: "/housemanage/houseexpand/create?id=" + keyValue,
            width: "800px",
            height: "600px",
            callBack: function (iframeId) {
                top.frames[iframeId].submitForm();
            }
        });
    }
}
function btn_edit() {
    var keyValue = getkeyvalue();// $("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalOpen({
            id: "Form",
            title: "修改房源",
            url: modulelUrl + "edit?id=" + keyValue,
            width: "1200px",
            height: "750px",
            btn: null
        });
    }
}
function btn_refresh() {
    var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalOpen({
            id: "Form",
            title: "刷新房源",
            url: "/housemanage/houserefreshlog/create?id=" + keyValue,
            width: "800px",
            height: "600px",
            callBack: function (iframeId) {
                top.frames[iframeId].submitForm();
            }
        });
    }
}

function btn_audit() {
    var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalOpen({
            id: "Form",
            title: "审核房源",
            url: "/housemanage/house/edit2?id=" + keyValue,//"/housemanage/houseauditlog/create?id=" + keyValue,
            width: "1200px",
            height: "750px",
            btn: null
        });
    }
}
function btn_auditAndPass(id) {
    if (id) {
        $.modalOpen({
            id: "Form",
            title: "审核房源",
            url: "/housemanage/houseauditlog/create?id=" + id,
            width: "700px",
            height: "275px",
            btn: null
        });
    }
}
function btn_delete() {
    var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.deleteForm({
            url: modulelUrl + "DeleteForm",
            param: { keyValue: keyValue },
            success: function () {
                $.currentWindow().$("#gridList").trigger("reloadGrid");
            }
        })
    }
}
function btn_details() {
    var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalOpen({
            id: "Form",
            title: "查看房源",
            url: modulelUrl + "/Form?id=" + keyValue,
            width: "800px",
            height: "600px",
            btn: null,
        });
    }
}
function btn_village() {
    var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalOpen({
            id: "Form",
            title: "小区信息",
            url: "/housevillage/village/Form?houseid=" + keyValue,
            width: "800px",
            height: "600px",
            btn: null,
        });
    }
}
function btn_picadd() {
    var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalOpen({
            id: "Form",
            title: "图片新增",
            url: "/housemanage/housepics/create?id=" + keyValue,
            width: "800px",
            height: "600px",
            btn: null,
        });
    }
}

function btn_collect() {
    var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalOpen({
            id: "Form",
            title: "收藏管理",
            url: "/HouseCollectLog/CollectLog/details?houseId=" + keyValue,
            width: "800px",
            height: "600px",
            btn: null,
        });
    }
}
function btn_sale() {
    //var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    //if (keyValue == undefined) {
    //    $.modalAlert("请选择要操作的行！", 2);
    //    return;
    //}
    //$.modalOpen({
    //    id: "Form",
    //    title: "租赁管理",
    //    url: "/ordermanage/order/searchlist?HouseID=" + keyValue,
    //    width: "800px",
    //    height: "600px",
    //    btn: null,
    //});
    var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.nfinetab.addTabByUrl('/OrderManage/Order/SearchList?HouseID=' + keyValue);
    }
}
function btn_refershlogs() {
    var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalOpen({
            id: "Form",
            title: "房源动态",
            url: "/housemanage/houseauditlog/index?id=" + keyValue,
            width: "800px",
            height: "600px",
            btn:null,
        });
    }
}
//function btn_auditlogs() {
//    var keyValue = $("#gridList").jqGridRowValue().Id;
//    if (keyValue == undefined) {
//        $.modalAlert("请选择要操作的行！", 2);
//        return;
//    }
//    $.modalOpen({
//        id: "Form",
//        title: "审核日志",
//        url: "/housemanage/houseauditlog/index?id=" + keyValue,
//        width: "800px",
//        height: "600px",
//        btn: null,
//    });
//}
function btn_feedback() {
    var keyValue = getkeyvalue();// $("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalOpen({
            id: "Form",
            title: "通话记录",
            url: "/FeedBackManage/feedbacks/index?houseid=" + keyValue,
            width: "800px",
            height: "600px",
            btn: null,
        });
    }
}

//意向单
function btn_sale() {
    var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.nfinetab.addTabByUrl('/OrderManage/Order/SearchList?HouseID=' + keyValue);
    }
}
//合同
function btn_contract()
{
    var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.nfinetab.addTabByUrl('/LeaseContractManage/LeaseContract/QuickSearch?HouseID=' + keyValue);
    }
}
//通话管理
function btn_calllogs() {
    var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        
        $.modalOpen({
            id: "Form",
            title: "通话记录",
            url: "/UserManage/User/UserCallLogList?HouseId=" + keyValue,
            width: "800px",
            height: "600px",
            btn: null,
        });
    }
   
}
//收藏管理
function btn_collect() {
    var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.nfinetab.addTabByUrl('/UserManage/User/UserCollectList?houseid=' + keyValue );
    }
}
//出价管理
function btn_price() {
    //var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    //if (keyValue == undefined) {
    //    $.modalAlert("请选择要操作的行！", 2);
    //    return;
    //}
    //$.modalOpen({
    //    id: "Form",
    //    title: "竞价管理",
    //    url: "/LeaseOfferManage/LeaseOffer/LeaseOfferList?HouseID=" + keyValue,
    //    width: "800px",
    //    height: "600px",
    //    btn: null,
    //});
    var keyValue = getkeyvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.nfinetab.addTabByUrl('/LeaseOfferManage/LeaseOffer/LeaseOfferList?HouseID=' + keyValue);
    }
}
//审核，批量
function btn_audit_mutil() {

    id = getmutilvalue();
    if (id) {
        $.modalOpen({
            id: "Form",
            title: "审核房源",
            url: "/housemanage/houseauditlog/createmutil?id=" + id,
            width: "700px",
            height: "275px",
            btn: null
        });
    }
}
// 上架，支持批量
function btn_online() {

    var keyValue = getmutilvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalConfirm('您确认要将该房源<span class="label label-danger" style="margin:0px 5px;">上架</span>吗？请谨慎操作！', function (r) {
            if (r) {
                var postdata = { keyValue: keyValue, IsOn: 1 };
                $.submitForm({
                    url: modulelUrl + "OnlineSet",
                    param: postdata,
                    success: function () {
                        $.currentWindow().$("#gridList").trigger("reloadGrid");
                    }
                })
            }
        });
    }
}
//下架，支持批量
function btn_offline() {

    var keyValue = getmutilvalue();// $("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalConfirm('您确认要将该房源<span class="label label-danger" style="margin:0px 5px;">下架</span>吗？请谨慎操作！', function (r) {
            if (r) {
                var postdata = { keyValue: keyValue, IsOn: 0 };
                $.submitForm({
                    url: modulelUrl + "OnlineSet",
                    param: postdata,
                    success: function () {
                        $.currentWindow().$("#gridList").trigger("reloadGrid");
                    }
                })
            }
        });
    }
}
//恢复，支持批量

function btn_restore() {
    var keyValue = getmutilvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalConfirm('您确认要将该房源<span class="label label-danger" style="margin:0px 5px;">恢复</span>吗？请谨慎操作！', function (r) {
            if (r) {
                var postdata = { keyValue: keyValue };
                $.submitForm({
                    url: modulelUrl + "Restored",
                    param: postdata,
                    success: function () {
                        $.currentWindow().$("#gridList").trigger("reloadGrid");
                    }
                })
            }
        });
    }
}
//置顶
function btn_up() {
    var keyValue = getmutilvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalConfirm('您确认要将该房源<span class="label label-danger" style="margin:0px 5px;">置顶/取消置顶</span>吗？请谨慎操作！', function (r) {
            if (r) {
                var postdata = { keyValue: keyValue };
                $.submitForm({
                    url: modulelUrl + "SetUp",
                    param: postdata,
                    success: function () {
                        $.currentWindow().$("#gridList").trigger("reloadGrid");
                    }
                })
            }
        });
    }
}
//取消置顶
function btn_down() {
    var keyValue = getmutilvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalConfirm('您确认要将该房源<span class="label label-danger" style="margin:0px 5px;">取消置顶</span>吗？请谨慎操作！', function (r) {
            if (r) {
                var postdata = { keyValue: keyValue };
                $.submitForm({
                    url: modulelUrl + "SetDown",
                    param: postdata,
                    success: function () {
                        $.currentWindow().$("#gridList").trigger("reloadGrid");
                    }
                })
            }
        });
    }
}
//取消锁定
function btn_relock() {
    var keyValue = getmutilvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalConfirm('您确认要将该房源<span class="label label-danger" style="margin:0px 5px;">取消锁定</span>吗？请谨慎操作！', function (r) {
            if (r) {
                var postdata = { keyValue: keyValue };
                $.submitForm({
                    url: modulelUrl + "ReLock",
                    param: postdata,
                    success: function () {
                        $.currentWindow().$("#gridList").trigger("reloadGrid");
                    }
                })
            }
        });
    }
}
//锁定
function btn_lock() {
    var keyValue = getmutilvalue();//$("#gridList").jqGridRowValue().Id;
    if (keyValue) {
        $.modalConfirm('您确认要将该房源<span class="label label-danger" style="margin:0px 5px;">锁定</span>吗？请谨慎操作！', function (r) {
            if (r) {
                var postdata = { keyValue: keyValue };
                $.submitForm({
                    url: modulelUrl + "Lock",
                    param: postdata,
                    success: function () {
                        $.currentWindow().$("#gridList").trigger("reloadGrid");
                    }
                })
            }
        });
    }
}
function selectall(obj) {
    // 全选或者取消
    var ischecked = $(obj).prop("checked");
    if (ischecked) {
        $(obj).parent().parent().parent().find(".checkbox_wrap label input:checkbox").each(function () { $(this).prop("checked", true); })
    }
    else {
        $(obj).parent().parent().parent().find(".checkbox_wrap label input:checkbox").each(function () { $(this).prop("checked", false); })

    }
}
function getkeyvalue() {
    var ids = $("#gridList").jqGrid('getGridParam', 'selarrrow');
    if (ids.length == 0) {
        $.modalAlert('请先选择数据行！', 2);
        return false;
    }
    if (ids.length > 1) {
        $.modalAlert('只能选择一个！', 2);
        return false;
    }
    var arrData = [];
    //遍历访问这个集合
    $(ids).each(function (index, id) {
        //由id获得对应数据行
        var row = $("#gridList").jqGrid('getRowData', id);
        //arrData.push({ HouseId: row.Id, HouseTitle: row.HouseTitle });
        arrData.push(row.Id);
    });
    return arrData[0];

}
function getmutilvalue() {
    // return with ',' 
    //获取多选到的id集合
    var ids = $("#gridList").jqGrid('getGridParam', 'selarrrow');
    if (ids.length == 0) {
        $.modalAlert('请先选择数据行！', 2);
        return false;
    }
    var arrData = [];
    //遍历访问这个集合
    $(ids).each(function (index, id) {
        //由id获得对应数据行
        var row = $("#gridList").jqGrid('getRowData', id);
        //arrData.push({ HouseId: row.Id, HouseTitle: row.HouseTitle });
        arrData.push(row.Id);
    });
    return arrData.join(',');
}