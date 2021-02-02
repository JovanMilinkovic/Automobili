export class Mesto{
    constructor(){
        this.manjiKontejner = null;
    }
    crtajMesto(host) {
        this.manjiKontejner = document.createElement("div");
        this.manjiKontejner.className = "lok";
        this.manjiKontejner.innerHTML = "prazno";
        host.appendChild(this.manjiKontejner);
    }
}