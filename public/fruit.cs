using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

 

using Newtonsoft.Json.Serialization;
namespace Core2WebAPI{
    public class Fruit{
        string name;
        double price;
        int quantity;
        string img;
        public Fruit(name, price, quantity, img){
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.img = img;
        }

    }
}
