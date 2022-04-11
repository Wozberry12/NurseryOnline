using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;              
using System.Data.SqlClient;    
using Utilities;

namespace Core2WebAPI.Controllers{
    [Route("api/[controller]")]
    public class frutiController : Controller{
        [HttpGet]
        public List<Fruit> Get(){
        
            DBConnect objDB = new DBConnect();
            DataSet ds = objDB.getDataSet("SELECT * FROM Fruits");
            List<Fruit> forSaleFruit = new List<Fruit>();
            Fruit fruit;
        
            foreach(DataRow record in ds.Tables[0].Rows){
                string name = record["Name"].ToString();
                double price = double.Parse(record["Price"].ToString());
                int quantity = int.Parse(record["Quanitiy"].ToString());
                string img = record["img"].ToString();
                fruit = new Fruit(name, price, quantity, img);
                forSaleFruit.Add(fruit);
            }
            return forSaleFruit;
        }
    }
} 



    
        
          



