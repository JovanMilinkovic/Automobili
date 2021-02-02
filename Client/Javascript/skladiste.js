import {Mesto} from "./mesto.js";

export class Skladiste {
    
    constructor(naziv){
        this.naziv=naziv;
        this.kontejner=null;
        this.skladiste=[];
    }
    dodajMesto(lok){
        this.skladiste.push(lok);
    }
    napraviSkladiste(host){
        
        if(!host)
            throw new Exception("Roditeljski element ne postoji");

        this.kontejner = document.createElement("div");
        this.kontejner.classList.add("kontejner");
        host.appendChild(this.kontejner);

        this.crtajFormu(this.kontejner);
        this.napraviSkladiste(this.kontejner);
    }
    crtajFormu(host){
        
        const 
    }
}