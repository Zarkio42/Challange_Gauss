function salvarInformacao() {
  // pega as do DOM do html e guarda o valor nas variaveis alimento/calorias/quantidade


  var alimento = document.getElementById("alimento").value;
  var calorias = document.getElementById("calorias").value;
  var quantidade = document.getElementById("quantidade").value;
  var tipo = document.getElementById("tipos_select").value;

  //recupera la do DOM do html a tabela e guarda na variavel tabela

  if (alimento !== "" && calorias !== "" && quantidade !== "" && tipo !== "null") {
    var tabela = document.getElementById("tabela");

    var newRow = tabela.insertRow();
    var cell1 = newRow.insertCell(0);
    cell1.innerHTML = alimento;
    var cell2 = newRow.insertCell(1);
    cell2.innerHTML = calorias;
    var cell3 = newRow.insertCell(2);
    cell3.innerHTML = quantidade;
    var cell4 = newRow.insertCell(3);
    cell4.innerHTML = tipo;


    //limpar tudo para recomeçar
    document.getElementById("alimento").value = ""
    document.getElementById("calorias").value = ""
    document.getElementById("quantidade").value = ""
  }

  else {
    alert("Preencha os campos!")
  }
}

function deletatabela() {
  var tabela = document.getElementById("tabela");
  var rowCount = tabela.rows.length;
  if (rowCount > 1) {
    tabela.deleteRow(rowCount - 1); // Remove a última linha da tabela
  }
}