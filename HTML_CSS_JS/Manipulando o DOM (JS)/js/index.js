
const salvarBtn = document.getElementById("btn");
const excluirCardBtn = document.getElementsByClassName("deleteBtn");

salvarBtn.addEventListener("click", salvarDados, exibirDados);

document.addEventListener("click", function (event) {
    if (event.target.classList.contains("deleteBtn") || event.target.className.contains("bi bi-trash")) {
        deleteCards(event);
    }
});

function salvarDados() {
    let inputTitle = document.getElementById("titulo").value;
    let inputDescription = document.getElementById("description").value;

    if (inputTitle !== "" && inputDescription !== "") {
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
    else {
        alert("Campos Vazios!")
    }
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

            let deleteElement = document.createElement("button");
            deleteElement.classList.add("deleteBtn")
            card.appendChild(deleteElement);
            iconDelete = document.createElement("i");
            iconDelete.className = "bi bi-trash";
            //prepend adciona o item icon dentro do button.
            deleteElement.prepend(iconDelete);

            let tituloElement = document.createElement("h4");
            tituloElement.textContent = `${tarefa.titulo}`
            card.appendChild(tituloElement);

            let descriptionElement = document.createElement("p");
            descriptionElement.textContent = `${tarefa.description}`
            card.appendChild(descriptionElement);

            dadosSalvos.appendChild(card);
        })
    }

}

function deleteCards(event) {
        let card = event.target.closest(".card");
        if (card) {
            card.remove();
    
            // Remove o card do localStorage
            let tarefas = localStorage.getItem("tarefas");
            if (tarefas) {
                tarefas = JSON.parse(tarefas);
                let titulo = card.querySelector("h4").textContent;
                let description = card.querySelector("p").textContent;
    
                // Procura o índice do card a ser removido
                let index = tarefas.findIndex(function(tarefa) {
                    return tarefa.titulo === titulo && tarefa.description === description;
                });
    
                // Remove o card do array
                if (index !== -1) {
                    tarefas.splice(index, 1);
                    localStorage.setItem("tarefas", JSON.stringify(tarefas));
                }
            }
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