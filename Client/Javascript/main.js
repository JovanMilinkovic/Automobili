import {Automobil} from "./Automobil/automobil.js"
import {AutomobilView} from "./Automobil/automobilView.js"

const html = document.getElementsByTagName("html")[0];
const body = document.getElementsByTagName("body")[0];
const container = document.createElement("div");
body.appendChild(container);
var naslov = document.createElement("p");
naslov.className = "naslovna";
naslov.innerHTML="Admin stranica kompanije 'Audi'";
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
unesiPodatke.addEventListener("click", function(){
    uBazuUnesi();
})
function crtajFormu()
{
    var forma = document.createElement("div");
    forma.className = "forma";

    var formaLogo = document.createElement("img");
    formaLogo.className = "formaLogo";
    formaLogo.setAttribute("src", "./Images/logoAudi.png");
    forma.appendChild(formaLogo);
    var formaTekst = document.createElement("p");
    formaTekst.className = "formaTekst";
    formaTekst.innerHTML = "Unesite potrebne podatke za unos automobila u bazu podataka kompanije 'Audi' ";
    forma.appendChild(formaTekst);
    var slikaTekst = document.createElement("p");
    slikaTekst.className = "slikaTekst";
    slikaTekst.innerHTML = "Unesite sliku modela:";
    forma.appendChild(slikaTekst);
    var formaSlika = document.createElement("input");
    formaSlika.type = "File";
    forma.appendChild(formaSlika);

    var inputModel = document.createElement("input");
    inputModel.type = "Text";
    inputModel.placeholder = "Unesite ime modela";
    forma.appendChild(inputModel);

    var inputCena = document.createElement("input");
    inputCena.type = "Text";
    inputCena.placeholder = "Unesite cenu modela u evrima";
    forma.appendChild(inputCena);
    //select opcije za kubikazu
    var inputKubikaza = document.createElement("select");
    var kubikazaTekst = document.createElement("p");
    kubikazaTekst.className = "kubikazaTekst";
    kubikazaTekst.innerHTML = "Izaberite kubikažu:";
    forma.appendChild(kubikazaTekst);

    var inputKubikazaOpt1 = document.createElement("option");
    inputKubikazaOpt1.value = "1.4";
    inputKubikazaOpt1.innerHTML = "1.4"
    inputKubikaza.appendChild(inputKubikazaOpt1);
    forma.appendChild(inputKubikaza); 

    var inputKubikazaOpt2 = document.createElement("option");
    inputKubikazaOpt2.value = "1.6";
    inputKubikazaOpt2.innerHTML = "1.6"
    inputKubikaza.appendChild(inputKubikazaOpt2);

    var inputKubikazaOpt3 = document.createElement("option");
    inputKubikazaOpt3.value = "1.7";
    inputKubikazaOpt3.innerHTML = "1.7"
    inputKubikaza.appendChild(inputKubikazaOpt3);

    var inputKubikazaOpt4 = document.createElement("option");
    inputKubikazaOpt4.value = "1.9";
    inputKubikazaOpt4.innerHTML = "1.9"
    inputKubikaza.appendChild(inputKubikazaOpt4);

    var inputKubikazaOpt5 = document.createElement("option");
    inputKubikazaOpt5.value = "2.0";
    inputKubikazaOpt5.innerHTML = "2.0"
    inputKubikaza.appendChild(inputKubikazaOpt5);

    var inputKubikazaOpt6 = document.createElement("option");
    inputKubikazaOpt6.value = "2.2";
    inputKubikazaOpt6.innerHTML = "2.2"
    inputKubikaza.appendChild(inputKubikazaOpt6);

    var inputKubikazaOpt7 = document.createElement("option");
    inputKubikazaOpt7.value = "2.4";
    inputKubikazaOpt7.innerHTML = "2.4"
    inputKubikaza.appendChild(inputKubikazaOpt7);

    var inputKubikazaOpt8 = document.createElement("option");
    inputKubikazaOpt8.value = "2.6";
    inputKubikazaOpt8.innerHTML = "2.6"
    inputKubikaza.appendChild(inputKubikazaOpt8);

    var inputKubikazaOpt8 = document.createElement("option");
    inputKubikazaOpt8.value = "3.0";
    inputKubikazaOpt8.innerHTML = "3.0"
    inputKubikaza.appendChild(inputKubikazaOpt8);

    //select opcije za karoseriju
    var inputKaroserija = document.createElement("select");
    var karoserijaTekst = document.createElement("p");
    karoserijaTekst.className = "karoserijaTekst";
    karoserijaTekst.innerHTML = "Izaberite karoseriju:";
    forma.appendChild(karoserijaTekst);

    var inputKaroserijaOpt1 = document.createElement("option");
    inputKaroserijaOpt1.value = "Limuzina";
    inputKaroserijaOpt1.innerHTML = "Limuzina";
    inputKaroserija.appendChild(inputKaroserijaOpt1);

    var inputKaroserijaOpt2 = document.createElement("option");
    inputKaroserijaOpt2.value = "Karavan";
    inputKaroserijaOpt2.innerHTML = "Karavan";
    inputKaroserija.appendChild(inputKaroserijaOpt2);

    var inputKaroserijaOpt3 = document.createElement("option");
    inputKaroserijaOpt3.value = "Hečbek";
    inputKaroserijaOpt3.innerHTML = "Hečbek";
    inputKaroserija.appendChild(inputKaroserijaOpt3);

    var inputKaroserijaOpt4 = document.createElement("option");
    inputKaroserijaOpt4.value = "SUV";
    inputKaroserijaOpt4.innerHTML = "SUV";
    inputKaroserija.appendChild(inputKaroserijaOpt4);
    forma.appendChild(inputKaroserija);
    
    var inputKwks = document.createElement("input");
    inputKwks.type = "Text";
    inputKwks.placeholder = "Unesite kW/ks";
    forma.appendChild(inputKwks);
    //select opcije za pogon
    var inputPogon = document.createElement("select");
    var pogonTekst = document.createElement("p");
    pogonTekst.className = "pogonTekst";
    pogonTekst.innerHTML = "Izaberite pogon:";
    forma.appendChild(pogonTekst);

    var inputPogonOpt1 = document.createElement("option");
    inputPogonOpt1.value = "Dizel";
    inputPogonOpt1.innerHTML = "Dizel";
    inputPogon.appendChild(inputPogonOpt1);

    var inputPogonOpt2 = document.createElement("option");
    inputPogonOpt2.value = "Benzin";
    inputPogonOpt2.innerHTML = "Benzin";
    inputPogon.appendChild(inputPogonOpt2);

    var inputPogonOpt3 = document.createElement("option");
    inputPogonOpt3.value = "Elektro-pogon";
    inputPogonOpt3.innerHTML = "Elektro-pogon";
    inputPogon.appendChild(inputPogonOpt3);
    forma.appendChild(inputPogon);

    var unesiPodatke = document.createElement("button");
    unesiPodatke.className = "unesiPodatke";
    unesiPodatke.innerHTML = "Unesite model u bazu";
    forma.appendChild(unesiPodatke);
    container.appendChild(forma);
}
