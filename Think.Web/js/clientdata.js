var clients = [];
$(function () {
    clients = $.clientsInit();
})
$.clientsInit = function () {
    var dataJson = {
      //  dataItems: [],
      //  organize: [],
      //  role: [],
      //  duty: [],
      //  user: [],
        emailcount: [],
        email:[], //导航显示未读邮件数量
        authorizeMenu: [],
      //  authorizeButton: []
    };
    var init = function () {
        $.ajax({
            url: "/Home/GetClientsDataJson",
            type: "get",
            dataType: "json",
            async: false,
            success: function (data) {
             //   dataJson.dataItems = data.dataItems;
            //    dataJson.organize = data.organize;
                //  dataJson.role = data.role;
                dataJson.emailcount = data.emailcount;
                dataJson.email = data.email;
                dataJson.authorizeMenu = eval(data.authorizeMenu);
               // dataJson.authorizeButton = data.authorizeButton;
            }
        });
    }
    init();
    return dataJson;
}