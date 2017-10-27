function escondeDiv() {
	var display = document.getElementById('listaProjetos').style.display;
	if(display === "none"){
    document.getElementById('listaProjetos').style.display = 'block';
	}else{
    document.getElementById('listaProjetos').style.display = 'none';
	}
}

function menuUsuario() {
	var display = document.getElementById('menuUsuario').style.display;
	if(display == "none"){
    document.getElementById('menuUsuario').style.display = 'block';
	}else{
    document.getElementById('menuUsuario').style.display = 'none';
	}
}
