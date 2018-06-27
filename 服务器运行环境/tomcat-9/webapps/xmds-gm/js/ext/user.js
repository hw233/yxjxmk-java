$(function(){
	$('#login').dialog({
		closable: false,
		draggable:false,
		resizable:false,
		buttons: [{
			text:' 登 录 ',
			iconCls:'icon-ok',
			handler:function(){
				login();
			}
		},{
			text:' 重 置 ',
			iconCls:'icon-undo',
			handler:function(){
				$('#loginForm').form('clear');
			}
		}]
	});
	$('#uname').textbox('textbox').bind('keypress', function(e) {
		enter();
	})
	$('#pwd').textbox('textbox').bind('keypress', function(e) {
		enter();
	})
	$('#loginForm').show();
});

function login(){
	$('#loginForm').form('submit', {   
	    url : 'action/login',
	    onSubmit: function(){   
	        return $('#loginForm').form('validate');
	    },   
	    success:function(data){
	    	if(data=="suc"){
				window.location.href = "gmsys.html";
	        } else {
	      		$.messager.alert('信息提示',data,'warning');
	        }
	    }   
	});
}

function enter() {
	if(event.keyCode == 13){ 
		login();
	} 
}