
function gridList(url) {
    $gridList = $("#gridList");
    $gridList.dataGrid({
        url: modulelUrl + url,
        height: $(window).height() - 128,
        colModel: [
                    { label: "主键", name: "Id", hidden: true, key: true },
                        {
                            label: '小区名称', name: 'VillagName', width: 80, align: 'left', formatter: function (cellvalue, options, rowObject) {
                                return '<a href="/CommonPageManage/housevillage/villageDetails?villageId=' + rowObject.Id + '">' + cellvalue + '</a>';
                            }
                        },
                        {
                            label: '历史成交量', name: 'SaledHouse', width: 80, align: 'left', formatter: function (cellvalue, options, rowObject) {
                                return '<a href="/CommonPageManage/housevillage/villageDetails?villageId=' + rowObject.Id + '">' + (cellvalue <= 0 ? "<span class='label label-default'>0</span>" : "<span class='label label-success'>" + cellvalue + "</span>") + '</a>';
                            }
                        },
                        {
                            label: '目前出租数', name: 'HouseCount', width: 80, align: 'left',
                            formatter: function (cellvalue, options, rowObject) {
                                return '<a href="/CommonPageManage/housevillage/villageDetails?villageId=' + rowObject.Id + '">' + (cellvalue <= 0 ? "<span class='label label-default'>0</span>" : "<span class='label label-success'>" + cellvalue + "</span>") + '</a>';
                            }
                        },
                        {
                            label: '收藏数', name: 'CollectionNumber', width: 80, align: 'left', formatter: function (cellvalue, options, rowObject) {
                                return '<a href="/CommonPageManage/housevillage/villageDetails?villageId=' + rowObject.Id + '">' + (cellvalue <= 0 ? "<span class='label label-default'>0</span>" : "<span class='label label-success'>" + cellvalue + "</span>") + '</a>';

                            }
                        },
                        { label: '公交配套', name: 'Line', width: 250, align: 'left' },
                         { label: '所在版块', name: 'VillageArea', width: 150, align: 'left' },
                        { label: '详细地址', name: 'DetailsAddress', width: 250, align: 'left' },
                        { label: '维护人', name: 'Maintenancer', width: 80, align: 'left' },
                          {
                              label: '来源', name: 'Source', width: 80, align: 'left',
                              formatter: function (cellvalue, options, rowObject) {
                                  return rowObject.Source == "0" ? "<span class='label label-default'>导入</span>" : rowObject.Source == "1" ? "<span  class='label label-success'>后台上传</span>" : "<span class='label label-warning'>后台导入</span>";
                              }
                          },
                        { label: '创建时间', name: 'AddTime', width: 150, align: 'left', formatter: "date", formatoptions: { srcformat: 'Y-m-d H:i:s', newformat: 'Y-m-d H:i:s' } },
                        { label: '更新时间', name: 'LastUpdateTime', width: 150, align: 'left', formatter: "date", formatoptions: { srcformat: 'Y-m-d H:i:s', newformat: 'Y-m-d H:i:s' } },

        ],
        pager: "#gridPager",
        viewrecords: true
    });
    $("#btn_search").click(function () {
        SearchHandler();
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
//商圈
function gettareas(obj) {
    var $this = $(obj);
    $("#VillageArea").val('').trigger("change");
    $.ajax({
        url: "/SystemManage/Subway/GetTreeSelectJsonByDistrict",
        data: { district: $this.val() },
        dataType: "json",
        async: false,
        success: function (MYDATA) {
            console.log(MYDATA);
            if (MYDATA.length == 0) {
                $("#VillageArea").empty();
            } else {
                $("#VillageArea").select2({
                    minimumResultsForSearch: true,
                    placeholder: "请选择商圈",
                    allowClear: true,
                    data: MYDATA
                });
            }
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
            console.log(MYDATA);
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
//小区标签选择 457c704e-bd41-4e9a-8e46-785adcc10d93

//新增
function btn_add() {
    $.modalOpen({
        id: "Form",
        title: "新增房源小区信息",
        url: modulelUrl + "create",
        width: "800px",
        height: "600px",
        btn: null
    });
}
//修改
function btn_edit() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "Form",
        title: "修改房源小区信息",
        url: modulelUrl + "edit?id=" + keyValue,
        width: "800px",
        height: "600px",
        btn: null
    });
}
//审核
function btn_audit() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "Form",
        title: "审核",
        url: "/housevillage/villageauditlog/create?id=" + keyValue,
        width: "800px",
        height: "600px",
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
}
//查看图片
function btn_pic() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "Form",
        title: "查看图片",
        url: "/housevillage/villagepic/index?id=" + keyValue,
        width: "800px",
        height: "600px",
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
}
//增加图片
function btn_picAdd() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "Form",
        title: "增加图片",
        url: "/housevillage/villagepic/create?id=" + keyValue,
        width: "800px",
        height: "600px",
        callBack: function (iframeId) {
            top.frames[iframeId].submitForm();
        }
    });
}
//删除
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
//详情
function btn_details() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "Details",
        title: "查看房源小区信息",
        url: modulelUrl + "details?action=Details&id=" + keyValue,
        width: "800px",
        height: "600px",
        btn: null,
    });
}
//收藏记录
function btn_collection() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "Details",
        title: "查看房源小区信息",
        url: modulelUrl + "details?action=Details&id=" + keyValue,
        width: "800px",
        height: "600px",
        btn: null,
    });
}

function btn_picadd() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "Details",
        title: "图片新增",
        url: "/housevillage/villagepic/create?id=" + keyValue,
        width: "800px",
        height: "600px",
        btn: null,
    });
}
//成交记录
function btn_order() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalOpen({
        id: "Details",
        title: "成交记录",
        url: modulelUrl + "details?action=Details&id=" + keyValue,
        width: "800px",
        height: "600px",
        btn: null,
    });
}
//恢复

function btn_restore() {
    var keyValue = $("#gridList").jqGridRowValue().Id;
    if (keyValue == undefined) {
        $.modalAlert("请选择要操作的行！", 2);
        return;
    }
    $.modalConfirm('您确认要将该小区<span class="label label-danger" style="margin:0px 5px;">恢复</span>吗？请谨慎操作！', function (r) {
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