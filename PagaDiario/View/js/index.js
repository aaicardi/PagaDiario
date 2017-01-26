function index() {

    this.enviar = function () {

        var valor = document.getElementById("idText").value;

        
        var request = new XMLHttpRequest();
        request.open("GET", "/api/cliente", false);
        request.send();
        id_div.innerHTML = request.responseText;

    }


} var objIndex = new index();