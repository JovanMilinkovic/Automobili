import {Automobil} from "./automobil.js"

export class AutomobilView
{
    constructor (osnova, objekat)
    {
        this.osnova = osnova;
        this.objekat = objekat;
    };

    CrtajListuAutomobila() 
    {
        //var blok = document.createElement("div");
        var img = document.createElement("img");
        img.src = this.objekat.slika;
        var imeModela = document.createElement("p");
        imeModela.innerHTML = this.objekat.model;
        var cena = document.createElement("p");
        cena.innerHTML = this.objekat.cena;
        var kwks = document.createElement("p");
        kwks.innerHTML = this.objekat.kwks;
        var pogoni = document.createElement("p");
        pogoni.innerHTML = this.objekat.pogoni;
        var karoserije = document.createElement("p");
        karoserije.innerHTML = this.objekat.karoserije;
        var kubikaze = document.createElement("p");
        kubikaze.innerHTML = this.objekat.kubikaze;
        var oprema = document.createElement("p");
        oprema.innerHTML = this.objekat.oprema;
        this.osnova.appendChild(img);
        this.osnova.appendChild(imeModela);
        this.osnova.appendChild(cena);
        this.osnova.appendChild(kwks);
        this.osnova.appendChild(pogoni);
        this.osnova.appendChild(karoserije);
        this.osnova.appendChild(kubikaze);
        this.osnova.appendChild(oprema);
        /*this.blok.appendChild(img);
        this.blok.appendChild(imeModela);
        this.blok.appendChild(cena);
        this.blok.appendChild(kwks);
        this.blok.appendChild(pogoni);
        this.blok.appendChild(karoserije);
        this.blok.appendChild(kubikaze);
        this.blok.appendChild(oprema);*/
    }
}