
treeGenerate: function(data, $Tree, initObj) {

    var treedata = new Array();

    var pattern = new RegExp('\\,\\"nodes\\"\\:\\[\\]', 'g');



    for (var i = 0; i < data.length; i++) {

        if (i == 0) {

            var state = {

                expanded: true

            };

            data[i].state = state;

        }

        var tempStr = JSON.stringify(data[i]);

        treedata.push(JSON.parse(tempStr.replace(pattern, "")));

    }

    if (initObj != null || initObj != undefined) {

        initObj.levels = 1;

        initObj.data = treedata;

        $Tree.treeview(initObj);

    } else {

        $Tree.treeview({

            data: treedata,

            showIcon: true,

            showCheckbox: false,

            showBorder: true,

            levels: 1,

            multiSelect: false,

            highlightSearchResults: true,

            highlightSelected: true

        });

    }

    return this;

},

checkTreeChildNode: function(node, $Tree) {

    var str = JSON.stringify(node);

    var pattern = new RegExp('nodes');

    if (pattern.test(str)) {

        $.each(node.nodes, function (key, val) {

            $Tree.treeview('checkNode', [val.nodeId]);

            Substation.DOMOperator.checkTreeChildNode(val, $Tree);

        });

    }

},

unCheckTreeChildNode: function(node, $Tree) {

    var str = JSON.stringify(node);

    var pattern = new RegExp('nodes');

    if (pattern.test(str)) {

        $.each(node.nodes, function (key, val) {

            $Tree.treeview('uncheckNode', [val.nodeId]);

            Substation.DOMOperator.unCheckTreeChildNode(val, $Tree);

        });

    }

},
