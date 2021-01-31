export class Automobil
{
    constructor(id, model, cena, slika, SveOAutomobilima)
    {
        this.id = id;
        this.model = model;
        this.cena = cena;
        this.slika = slika;
        this.kwks = [];
        this.pogoni=[];
        this.karoserije=[];
        this.kubikaze=[];
        this.oprema=[];
        SveOAutomobilima.forEach(SveOAutomobilu => {
            this.karoserije.push(SveOAutomobilu.vrsteKaroserija);
            this.kubikaze.push(SveOAutomobilu.vrsteKubikaza);
            this.kwks.push(SveOAutomobilu.vrsteKwks);
            this.pogoni.push(SveOAutomobilu.vrstaPogona);
            this.oprema.push(SveOAutomobilu.vrstaOpreme);
        });
        /*this.karoserija = karoserija;
        this.kubikaza = kubikaza;
        
        this.pogon = pogon;
        this.oprema = oprema;;*/
    }
}