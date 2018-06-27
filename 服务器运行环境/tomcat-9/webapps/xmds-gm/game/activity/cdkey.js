// Ajax 文件下载
function download(url, data, method) {
	if (url && data) {
		data = typeof data == 'string' ? data : $.param(data);
		var inputs = '';
		$.each(data.split('&'), function() {
			var pair = this.split('=');
			inputs += '<input type="hidden" name="' + pair[0] + '" value=\''
					+ pair[1] + '\' />';
		});
		$(
				'<form action="' + url + '" method="' + (method || 'post')
						+ '">' + inputs + '</form>').appendTo('body').submit()
				.remove();
	}
	;
};

function generate() {
	if (!$('#cdkForm').form('validate')) {
		return;
	}
	// 提交表单前先拼凑附件数据
	var items = "";
	var rows = $("#itemDg").datagrid('getRows');
	if (rows.length == 0) {
		parent.show("错误提示", "请选择物品！");
		return;
	}
	for (var i = 0; i < rows.length; i++) {
		items = items + rows[i].id + ":" + rows[i].num + ";";
	}
	if (items != "") {
		items = items.substring(0, items.length - 1);
	}
	var checkServerId = "";
	$('input[name="serverCheckbox"]:checked').each(function() {
		if (checkServerId == "") {
			checkServerId = $(this).val();
		} else {
			checkServerId += ";" + $(this).val();
		}
	});
	var cdkType = parseInt($("input[type='radio'][name='cdkType']:checked").val());
	var data = [ $("#cdkeycode").val(), parseInt($("#cdkeycount").val()),
			parseInt($("#channel").val()), $("#sdate").datetimebox("getText"),
			$("#edate").datetimebox("getText"), $("#cdkeygift").val(),
			parseInt($("#cdkeylen").val()), $("#minLevel").val(), checkServerId, cdkType, items];

	download("../../action/cdkey", "type=1120&value=" + parent.toJson(data)
			+ "&servers=" + parent.getSingleServer() + "&filename="
			+ $("#cdkeygift").val() + "[" + $("#cdkeycode").val() + "].txt",
			"post");
}