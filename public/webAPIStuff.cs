[HttpGet("{id}")]
public Fruit get(int id){
    string strConnection ="";
    string strSQL ="";
    OleDbConnection myConnection = new OleDbConnection(strConnection);
    OleDbCommand myCommand = new OleDbCommand(strSQL, myConnection);
    OleDbDataReader myDataReader;
    List<Fruit> forSaleFruit = new List<Fruit>();
    
    try{
        myConnection.Open();
        myDataReader = myCommand.ExecuteReader();

        while(myDataReader.Read()){
            string name = myDataReader["Name"].ToString();
            double price = myDataReader["Price"].ToString(); //when database setup will change this to the int parse
            int quantity = myDataReader["Quantity"].ToString(); //^^
            string img = myDataReader["img"].ToString(); //img string we can use in html to load an image idk how this will work yet
            Fruit fruit = new Fruit(name, price, quantity, img);
            forSaleFruit.Add(fruit);
        }
    }

}