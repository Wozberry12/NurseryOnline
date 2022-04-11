using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

 

using Newtonsoft.Json.Serialization;
namespace Core2WebAPI{
    public class Fruit{
        public string name {get; set;}
        public double price {get; set;}
        public int quantity {get; set;}
        public string img {get; set;}
        public Fruit(){
            
        }
        public Fruit(name, price, quantity, img){
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.img = img;
        }

    }
}
