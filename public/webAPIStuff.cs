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
    public class frutiController : Controller
    {
    [HttpGet]
    public List<Fruit> Get(){
        
        DBConnect objDB = new DBConnect();
        DataSet ds = objDB.getDataSet("SELECT * FROM Fruits");
        List<Fruit> forSaleFruit = new List<Fruit>();
    
        
        }
    }
} 



    
        
          



