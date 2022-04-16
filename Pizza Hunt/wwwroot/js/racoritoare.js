const cardtemplate=document.querySelector("[data-user-template]");
const cardcontainer=document.querySelector("[data-user-cards]");
let desertVec=[];
fetch("/JSON/racoritoare.json")
    .then(res=>res.json())
    .then(data=>{
        racoritoareVec=data.map(racoritoare=>{
            const card=cardtemplate.content.cloneNode(true).children[0];
            const image=card.querySelector("[data-image]");
            const racoritoareName=card.querySelector("[data-name]");
            const racoritoarePrice=card.querySelector("[data-price]");

            image.src=racoritoare.imageLink;
            racoritoareName.textContent=racoritoare.name;
            racoritoarePrice.textContent="Pret: " + racoritoare.price;

            cardcontainer.append(card);
        })
    })