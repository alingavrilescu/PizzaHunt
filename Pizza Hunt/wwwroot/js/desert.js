const cardtemplate=document.querySelector("[data-user-template]");
const cardcontainer=document.querySelector("[data-user-cards]");
let desertVec=[];
fetch("/JSON/desert.json")
    .then(res=>res.json())
    .then(data=>{
        desertVec=data.map(desert=>{
            const card=cardtemplate.content.cloneNode(true).children[0];
            const image=card.querySelector("[data-image]");
            const desertName=card.querySelector("[data-name]");
            const desertPrice=card.querySelector("[data-price]");

            image.src=desert.imageLink;
            desertName.textContent=desert.name;
            desertPrice.textContent="Pret: " + desert.price;

            cardcontainer.append(card);
        })
    })