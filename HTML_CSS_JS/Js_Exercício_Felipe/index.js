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

    return {
        addProduto: addProduto,
        getSacola: getSacola,
        calcularTotal: calcularTotal,
    }
}

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