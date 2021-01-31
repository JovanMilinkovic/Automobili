import {Automobil} from "./Automobil/automobil.js"
import {AutomobilView} from "./Automobil/automobilView.js"

const html = document.getElementsByTagName("html")[0];
const body = document.getElementsByTagName("body")[0];
const container = document.createElement("div");
body.appendChild(container);
var naslov = document.createElement("p");
naslov.id = "naslovna";
naslov.innerHTML="Dobrodošli na admin stranu Audi kompanije";
body.appendChild(naslov);
var dugmeDodaj = document.createElement("button");
dugmeDodaj.className = "dodaj";
dugmeDodaj.innerHTML = "Dodaj automobil";
body.appendChild(dugmeDodaj);
var dugmeBrisiSve = document.createElement("button");
dugmeBrisiSve.className = "brisi";
dugmeBrisiSve.innerHTML = "Obriši sve automobile";
body.appendChild(dugmeBrisiSve);
function obrisiSve()
{
    var djeca = [];
    djeca = container.children;
    console.log(djeca.length);
    while(container.children.length > 0)
    {
        container.removeChild(container.children[0]);
    }
    body.appendChild(container);
    body.appendChild(dugmeDodaj);
    body.appendChild(dugmeBrisiSve);
}
dugmeBrisiSve.addEventListener("click", function(){
    obrisiSve();
});
dugmeDodaj.addEventListener("click", function(){
    crtajFormu();
    /*fetch("http://localhost:5000/API/Automobili").then(p =>
    {
       p.json().then(data =>
           {
                data.forEach(Automobil1 =>
                    {
                        const Automobil11 = new Automobil(Automobil1.id, Automobil1.model, Automobil1.cena, Automobil1.slika, Automobil1.sveOAutomobilima);
                        var a1 = new AutomobilView(container, Automobil11);
                        a1.CrtajListuAutomobila();
                    });
            })
    });*/
});
function crtajFormu()
{
    var forma = document.createElement("div");
    forma.className = "forma";

    var inputModel = document.createElement("input");
    inputModel.type = "Text";
    inputModel.placeholder = "Unesite model:";
    forma.appendChild(inputModel);

    var inputCena = document.createElement("input");
    inputCena.type = "Text";
    inputCena.placeholder = "Unesite cenu modela:";
    forma.appendChild(inputCena);

    var inputKubikaza = document.createElement("input");
    inputKubikaza.type = "Text";
    inputKubikaza.placeholder = "Izaberi kubikazu:";
    forma.appendChild(inputKubikaza);
    
    var inputKaroserija = document.createElement("select");
    var inputKaroserijaOpt1 = document.createElement("option");
    inputKaroserijaOpt1.value = "limuzina";
    inputKaroserijaOpt1.innerHTML = "limuzina";
    inputKaroserija.appendChild(inputKaroserijaOpt1);
    var inputKaroserijaOpt2 = document.createElement("option");
    inputKaroserijaOpt2.value = "karavan";
    inputKaroserijaOpt2.innerHTML = "karavan";
    inputKaroserija.appendChild(inputKaroserijaOpt2);
    var inputKaroserijaOpt1 = document.createElement("option");
    forma.appendChild(inputKaroserija);
    var inputKwks = document.createElement("input");
    inputKwks.type = "Text";
    inputKwks.placeholder = "Izaberi kW/ks:";
    forma.appendChild(inputKwks);
    var inputPogon = document.createElement("input");
    inputPogon.type = "Text";
    inputPogon.placeholder = "Izaberi pogon:";
    forma.appendChild(inputPogon);
    var inputOprema = document.createElement("input");
    inputOprema.type = "Checkbox";
    inputOprema.placeholder = "Izaberi opremu:";
    forma.appendChild(inputOprema);
    var unesiPodatke = document.createElement("button");
    unesiPodatke.className = "unesiPodatke";
    unesiPodatke.innerHTML = "Unesi model u bazu";
    forma.appendChild(unesiPodatke);
    container.appendChild(forma);
}
