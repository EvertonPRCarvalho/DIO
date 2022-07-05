function removeExemplo(){
    var node = document.getElementById("exemplo"); 
    if(node.parentNode){ 
        node.parentNode.removeChild(node);
    }//<--Essa condição elimina o exemplo que é listado para o usuário.
}


function adicionar() {

    var tarefa = document.getElementById("new-checkbox").value;
    var lista  = document.getElementById("lista").innerHTML;
    lista = lista +"<li><input type='checkbox' class='checkbox'>"+tarefa+"</li>";
  
    document.getElementById("lista").innerHTML = lista;
    document.getElementById("new-checkbox").value=''; //Limpa o input após a inserção

  }