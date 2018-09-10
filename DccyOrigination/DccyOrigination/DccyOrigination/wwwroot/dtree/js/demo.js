//$(function () {
//    $('#treeviewdep').treeview({
//        data: getTree(),//节点数据
//        showBorder: true, //是否在节点周围显示边框
//        showCheckbox: true, //是否在节点上显示复选框
//        showIcon: true, //是否显示节点图标
//        highlightSelected: true,
//        levels: level,
//        multiSelect: true, //是否可以同时选择多个节点
//        showTags: true
//    });
//});

function nextDownTree(obj) {
   level = 1;
    var node = {
        text: obj.depName, //节点显示的文本值	string
        icon: "glyphicon glyphicon-play-circle", //节点上显示的图标，支持bootstrap的图标	string
        selectedIcon: "glyphicon glyphicon-ok", //节点被选中时显示的图标		string
        color: "#ff0000", //节点的前景色		string
        backColor: "#1606ec", //节点的背景色		string
        href: obj.url, //节点上的超链接
        selectable: true, //标记节点是否可以选择。false表示节点应该作为扩展标题，不会触发选择事件。	string
        state: { //描述节点的初始状态	Object
            checked: true, //是否选中节点
            /*disabled: true,*/ //是否禁用节点
            expanded: true, //是否展开节点
            selected: true //是否选中节点
        },
        tags: ['标签信息1', '标签信息2'], //向节点的右侧添加附加信息（类似与boostrap的徽章）	Array of Strings
    };
    if (obj.children.length > 0) {
        level++;
        var objnodes = [];
        $.each(obj.children, function (i, v) {
            var childnode = {
                text: v.depName, //节点显示的文本值	string
                icon: "glyphicon glyphicon-play-circle", //节点上显示的图标，支持bootstrap的图标	string
                selectedIcon: "glyphicon glyphicon-ok", //节点被选中时显示的图标		string
                color: "#ff0000", //节点的前景色		string
                backColor: "#1606ec", //节点的背景色		string
                href: v.url, //节点上的超链接
                selectable: true, //标记节点是否可以选择。false表示节点应该作为扩展标题，不会触发选择事件。	string
                state: { //描述节点的初始状态	Object
                    checked: true, //是否选中节点
                    /*disabled: true,*/ //是否禁用节点
                    expanded: true, //是否展开节点
                    selected: true //是否选中节点
                },
                tags: ['标签信息1', '标签信息2'], //向节点的右侧添加附加信息（类似与boostrap的徽章）	Array of Strings
            };
            if (v.children.length > 0) {
                nextDownTree(v);
            } else {
                objnodes.push(childnode);
                node.nodes = objnodes;
                return node;
            }
        });
    } 
    level = 0;
    return node;
}
var tree = [];
var level = 0;
function getTree() {
    tree = [];
    $.ajax({
        type: 'get',
        url: "../AdmDepartments/GetAcountUserAdmDepsTree",
        success: function (result) {
            if (result.stateCode != 200) {
                alert("此用户暂无部门或组织归属，请联系管理员配置此用户的部门组织属性！！！");
                return;
            }
            $.each(result.data, function (i, v) {
                var node = nextDownTree(v);
                tree.push(node);
            });
        }, error: function (result) {

        }
    });          
    return tree;
}