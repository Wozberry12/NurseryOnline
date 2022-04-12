<script>
    class fruit{
		constructor(name, fruitType, price, quanity, img){
			this.name =name;
			this.fruitType = fruitType;
			this.price = price;
			this.quanity = quanity;
			this.img = img;
		}
	}
	
	var goldenDelicous = new fruit("Golden Delicous Apple", "Apple", 4.50, 25, "https://www.applesfromny.com/wp-content/uploads/2020/06/Golden-DeliciousNEW.png");
	var grannySmith = new fruit("Granny Smith Apple", "Apple", 3.75, 30, "#");
	var cantelope = new fruit("Cantelope", "Cantelope", 6.99, 15, "#");
	var pineApple = new fruit("Pineapple", "Pineapple", 5.45, 29, "#");
	var fruitList = [goldenDelicous, grannySmith, cantelope, pineApple];
    localStorage.setItem("fruitList", JSON.stringify(fruitList));

    
</script>

<div id="fruitList">
    {#each fruitList as fruit}
        <div class="fruitBox">
			<img src={fruit.img} alt={fruit.name}>
			
			Name:{fruit.name}
			<br>
			Price: {fruit.price}
			<br>
			Quantity {fruit.quanity}
			<br>
		</div>
    {/each}
</div>