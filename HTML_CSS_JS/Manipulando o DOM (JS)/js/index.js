
const salvarBtn = document.getElementById("btn");

salvarBtn.addEventListener("click", salvarDados, exibirDados);

function salvarDados() {
    let inputTitle = document.getElementById("titulo").value;
    let inputDescription = document.getElementById("description").value;

    console.log(inputTitle, inputDescription);

    let tarefas = localStorage.getItem("tarefas");

    if (tarefas) {
        tarefas = JSON.parse(tarefas);
    }
    else {
        tarefas = [];
    }

    tarefas.push({ titulo: inputTitle, description: inputDescription });
    localStorage.setItem("tarefas", JSON.stringify(tarefas))

    alert("Dados Salvos!");
    exibirDados();
}

function exibirDados() {
    let dadosSalvos = document.getElementById("dadosSalvos");
    dadosSalvos.innerHTML = "";

    let tarefas = localStorage.getItem("tarefas");

    if (tarefas) {
        tarefas = JSON.parse(tarefas);
        tarefas.forEach(function (tarefa) {
            let card = document.createElement("div");
            card.classList.add("card")

            let tituloElement = document.createElement("p");
            tituloElement.textContent = `Titulo: ${tarefa.titulo}`
            card.appendChild(tituloElement);

            let descriptionElement = document.createElement("p");
            descriptionElement.textContent = `Descrição: ${tarefa.description}`
            card.appendChild(descriptionElement);

            dadosSalvos.appendChild(card);
        })
    }

}

window.addEventListener("DOMContentLoaded", exibirDados);

function alterarModo() {
    let body = document.getElementsByTagName("body")[0];
    body.classList.toggle("dark");

    let toggleButton = document.getElementById("modoDark");
    if (body.classList.contains("dark")) {
        toggleButton.textContent = "Modo Dia";
    }
    else {
        toggleButton.textContent = "Modo Noite"
    }
}