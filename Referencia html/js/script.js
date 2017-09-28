function escondeDiv() {
	var display = document.getElementById('listaProjetos').style.display;
	if(display == "none"){
    document.getElementById('listaProjetos').style.display = 'block';
	}else{
    document.getElementById('listaProjetos').style.display = 'none';
	}
}
