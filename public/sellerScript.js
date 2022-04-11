class fruit{
    constructor(name, price, image, quantity){
        this.name = name;
        this.price = price;
        this.image = image;
        this.quantity = quantity;
    }
}
//this is a base thing for whenever we figure out the webAPI stuff 
//this list below is assuming we have a list of fruit objects from an access database we made
var databaseFruits = []; 
function fillFruitForSale(){
    var forSaleDiv = document.getElementById("forSaleContents");
    forSaleDiv.innerHTML("");
    for(var i = 0; i<databaseFruits.length; i++){
        //the way I did this for a previous lab was horrible so if you guys have a better way lets do that :)
    }
}