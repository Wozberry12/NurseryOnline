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
    
    const handleAddTree = () =>{
        var currentTree = JSON.parse(localStorage.getItem("treeList"));
        var name = document.getElementById("nameInput").value;
        var type = document.getElementById("typeInput").value;
        var price = document.getElementById("priceInput").value;
        var quanity = document.getElementById("amountInput").value;
        var img = document.getElementById("imgInput").value;
        
        var id = currentTree[currentTree.length-1].id + 1;
        let reviewArray = [];
        
        var addTree = new Item(id,name, type, price, quanity, img, reviewArray);
        currentTree.push(addTree);
        localStorage.setItem("treeList", JSON.stringify(currentTree));
        window.alert("Added Tree " + name);
    }
    
    
</script>

<h1>Add New Tree</h1>
<br>
<div id="addTreeDiv">
        <label for="name">Tree Name:</label>
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
        <button class="addReview" on:click={() => handleAddTree()}>Add Tree</button>
    
</div>
<style>
    #addTreeDiv{
        display: grid;
        grid-template-columns: repeat(2, 1fr);
        text-align: right;
        font-family: Georgia, 'Times New Roman', Times, serif;
        font-size: 20px;
    }
</style>