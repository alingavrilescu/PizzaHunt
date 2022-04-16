const cardtemplate=document.querySelector("[data-user-template]");
const cardcontainer=document.querySelector("[data-user-cards]");
let pizzas=[];
fetch("/JSON/pizza.json")
    .then(res=>res.json())
    .then(data=>{
        pizzas=data.map(pizza=>{
            const card=cardtemplate.content.cloneNode(true).children[0];
            const image=card.querySelector("[data-image]");
            const pizzaName=card.querySelector("[data-name]");
            const pizzaIngredients=card.querySelector("[data-ingredients]");
            const dimensionSmall=card.querySelector("[data-dimensionSmall]");
            const dimensionMedium=card.querySelector("[data-dimensionMedium]");
            const dimensionBig=card.querySelector("[data-dimensionBig]");
            const priceSmall=card.querySelector("[data-priceSmall]");
            const priceMedium=card.querySelector("[data-priceMedium]");
            const priceBig=card.querySelector("[data-priceBig]");

            image.src=pizza.imageLink;
            pizzaName.textContent=pizza.name;
            pizzaIngredients.textContent="Ingrediente: " + pizza.ingredients;
            dimensionSmall.textContent=pizza.dimension[0];
            dimensionMedium.textContent=pizza.dimension[1];
            dimensionBig.textContent=pizza.dimension[2];
            priceSmall.textContent=pizza.price[0];
            priceMedium.textContent=pizza.price[1];
            priceBig.textContent=pizza.price[2];

            cardcontainer.append(card);
        })
    })