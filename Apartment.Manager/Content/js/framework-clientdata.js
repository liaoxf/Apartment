var clients = [];
$(function () {
    clients = $.clientsInit();
})
$.clientsInit = function () {
    var dataJson = {
        dataItems: [],
        organize: [],
        role: [],
        duty: [],
        user: [],
        authorizeMenu: [],
        authorizeButton: []
    };
    var init = function () {
        $.ajax({
            url: "/ClientsData/GetClientsDataJson",
            type: "get",
            dataType: "json",
            async: false,
            success: function (data) {
                dataJson.dataItems = data.dataItems;
                dataJson.organize = data.organize;
                dataJson.role = data.role;
                dataJson.duty = data.duty;
                dataJson.authorizeMenu = eval(data.authorizeMenu);
                dataJson.authorizeButton = data.authorizeButton;
            }
        });
    }
    init();
    Another();
    return dataJson;
}
function Notify() {
    var url = "https://wxapi.zfx365.com/api/Common/IsNewDemand";
    //var url = "http://localhost:9000/api/Common/IsNewDemand";
    //notifyAll("有新的私人定制订单产生，请查看");
       var old = localStorage.getItem("old")||0;
      
    $.post(url, function (results, status) {
        if (results.data != old) {
            localStorage.setItem("old", results.data)
            notifyAll("有新的私人定制订单产生，请查看");
        }
    }, 'json');
    //timeer

};
function Another() {
    setInterval("Notify()", 1000 * 30);
    Unhandle();
    setInterval("Unhandle()", 1000 * 60);//“未处理的出价单”、“未处理的需求单”条数
}
function notifyAll(data) {
    var options = {
        dir: "rtl",
        lang: "zh-CN",
        body: data,
        icon: "/content/img/logo.jpg",
        // tag:"msgId",
    }
    var notification_test = new Notification("指房向", options);
    notification_test.onclick = function () {
        window.focus();
        top.$("#nav-col").find('a[data-id="ad835712-90ba-46b7-b488-656fb57821c9"]').trigger("click");
        $.nfinetab.refreshTab();
    }


}
function Unhandle() {
    //$.post("/OrderManage/Order/GetUnhandleCount", function (results, status) {
    //    console.log(results);
    //    if (results.status == 1) {
    //        SetUnHandleCount(results.data.DemandCount, $('#UnDemandCount'));
    //        SetUnHandleCount(results.data.LeaseOfferCount, $('#UnLeaseCount'));
    //    }
    //}, 'json');
}

function SetUnHandleCount(count,obj) {
    if (count > 0) {
        if (obj.find("span").length > 0) {
            obj.find("span").text(count);
        } else {
            obj.append('<span class="count">' + count + '</span>');
        }
    } else {
        obj.find("span").remove();
    }
}
