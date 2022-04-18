<script>
    class Item{
		constructor(id, name, Type, price, quanity, img, reviews){
			this.id = id;
			this.name =name;
			this.Type = Type;
			this.price = price;
			this.quanity = quanity;
			this.img = img;
			this.reviews = reviews;
		}
	}
    
    const handleAddFruit = () =>{
        var currentFruit = JSON.parse(localStorage.getItem("fruitList"));
        var name = document.getElementById("nameInput").value;
        var type = document.getElementById("typeInput").value;
        var price = document.getElementById("priceInput").value;
        var quanity = document.getElementById("amountInput").value;
        var img = document.getElementById("imgInput").value;
        
        var id = currentFruit[currentFruit.length-1].id + 1;
        let reviewArray = [];
        
        var addFruit = new Item(id,name, type, price, quanity, img, reviewArray);
        currentFruit.push(addFruit);
        localStorage.setItem("fruitList", JSON.stringify(currentFruit));
        window.alert("Added Fruit " + name);
    }
    
    
</script>

<h1>Add New Fruits</h1>
<br>

<div id="addFruitDiv">
        <label for="name">Fruit Name:</label>
        <input type="text" id="nameInput" name="name">
        <label for="type">Type:</label>
        <input type="text" id="typeInput" name="type">
        <label for="price">Price:</label>
        <input type="text" id="priceInput" name="price">
        <label for="amount">Quanitiy:</label>
        <input type="text" id="amountInput" name="amount">
        <label for="img">Image URL:</label>
        <input type="text" id="imgInput" name="img">
        <br>
        <button class="addReview" on:click={() => handleAddFruit()}>Add Fruit</button>
    
</div>
<style>    
    #addFruitDiv{
        clear: both;
        display: grid;
        grid-template-columns: repeat(2, 1fr);
        text-align: right;
        font-family: Georgia, 'Times New Roman', Times, serif;
        font-size: 20px;
    }

</style>