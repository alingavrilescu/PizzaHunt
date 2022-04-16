const cardtemplate=document.querySelector("[data-user-template]");
const cardcontainer=document.querySelector("[data-user-cards]");
let pasteVec=[];
fetch("/JSON/paste.json")
    .then(res=>res.json())
    .then(data=>{
        pasteVec=data.map(paste=>{
            const card=cardtemplate.content.cloneNode(true).children[0];
            const image=card.querySelector("[data-image]");
            const pasteName=card.querySelector("[data-name]");
            const pasteIngredients=card.querySelector("[data-ingredients]");
            const pastePrice=card.querySelector("[data-price]");

            image.src=paste.imageLink;
            pasteName.textContent=paste.name;
            pasteIngredients.textContent="Ingrediente: " + paste.ingredients;
            pastePrice.textContent="Pret: " + paste.price;

            cardcontainer.append(card);
        })
    })