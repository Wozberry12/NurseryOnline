import {writable} from 'svelte/store'

class Item{
    constructor(id, name, Type, price, quanity, img){
        this.id = id;
        this.name =name;
        this.Type = Type;
        this.price = price;
        this.quanity = quanity;
        this.img = img;
    }
}