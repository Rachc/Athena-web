function escondeDiv() {
	var display = document.getElementById('listaProjetos').style.display;
	if(display == "block"){
    document.getElementById('listaProjetos').style.display = 'none';
	}else{
    document.getElementById('listaProjetos').style.display = 'block';
	}
}

function escondeProjeto() {
	var display = document.getElementById('telaConteudo').style.display;
	if(display == "block"){
    document.getElementById('telaConteudo').style.display = 'none';
	}else{
    document.getElementById('telaConteudo').style.display = 'block';
	}
}