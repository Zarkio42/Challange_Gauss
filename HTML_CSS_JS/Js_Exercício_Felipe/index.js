

(function () {

    function carrinho() {
        const sacola = [];

        function addProduto(produto) {
            const index = findItemIndex(produto.name)
            if (index != -1) {
                sacola[index].amount += produto.amount
            }
            else {
                sacola.push({
                    id: sacola.length + 1,
                    name: produto.name,
                    price: produto.price,
                    description: produto.description,
                    amount: produto.amount
                }
                )
            }
            saveOnLocalStg();
            atualizarCarrinho();
            Swal.fire({
                position: "center",
                icon: "success",
                title: "Produto adcionado na sacola!",
                showConfirmButton: false,
                timer: 3000
            })
        }
        function calcularTotal() {
            let total = 0;

            for (const produto of sacola) {
                total += produto.price * produto.amount;
            }
            return total;
        }
        function getSacola() {
            return sacola;
        }
        function findItemIndex(nameItem) {
            return sacola.findIndex(produto => produto.name == nameItem);
        }
        function saveOnLocalStg() {
            localStorage.setItem('sacola', JSON.stringify(sacola));
        }

        return {
            addProduto: addProduto,
            getSacola: getSacola,
            calcularTotal: calcularTotal,
        }
    }

    const minhaSacola = carrinho();
    const addBtns = document.querySelectorAll(".add-btn");

    addBtns.forEach(btn => {
        btn.addEventListener("click", () => {
            const nomeItem = btn.getAttribute("data-name");
            const precoItem = parseFloat(btn.getAttribute("data-preco"));
            minhaSacola.addProduto({
                name: nomeItem,
                price: precoItem,
                amount: 1
            })
        })
    })


    function atualizarCarrinho() {
        const carrinhoItensDiv = document.getElementById("carrinho-itens");
        const totalCarrinhoDiv = document.getElementById("total-carrinho");

        carrinhoItensDiv.innerHTML = ""
        totalCarrinhoDiv.textContent = ""

        let total = 0;

        /*minhaSacola.getSacola().forEach(item => {
            total += item.price * item.amount;
            carrinhoItensDiv.innerHTML += `<div class="dropdown-item">${item.name} - Quantidade: ${item.amount} - 
        R$ ${item.price.toFixed(2)}</div>`;
        })
        totalCarrinhoDiv.textContent = `Total: R$ ${total.toFixed(2)}`
        */

        let localString = localStorage.getItem('sacola');
        let objPessoa = JSON.parse(localString);
        console.log(objPessoa);

        objPessoa.forEach(item => {
            total += item.price * item.amount;
            carrinhoItensDiv.innerHTML += `<div class="dropdown-item">${item.name} - Quantidade: ${item.amount} - 
        R$ ${item.price.toFixed(2)}</div>`
        })
        totalCarrinhoDiv.textContent = `Total: R$ ${total.toFixed(2)}`

    }

})();



/* ADCIONANDO NA MÃO
const minhaSacola = carrinho();
carrinho();



minhaSacola.addProduto({
    name: 'X-Tudão',
    price: 40.00,
    description: "Pão Australiano, queijo, hamburguer angus 200g, ovo, presunto, bacon, alface, tomate.",
    amount: 1
});

minhaSacola.addProduto({
    name: 'X-Tudão',
    price: 40.00,
    description: "Pão Australiano, queijo, hamburguer angus 200g, ovo, presunto, bacon, alface, tomate.",
    amount: 1
});

minhaSacola.addProduto({
    name: 'X-Bacon',
    price: 30.00,
    description: "Pão Australiano, queijo, hamburguer angus 200g, Bacon.",
    amount: 1
});

console.log(minhaSacola.getSacola(), minhaSacola.calcularTotal());
*/