<script>
    class Fruit{
		constructor(id, name, fruitType, price, quanity, img){
			this.id = id;
			this.name =name;
			this.fruitType = fruitType;
			this.price = price;
			this.quanity = quanity;
			this.img = img;
		}
	}
	
	var goldenDelicous = new Fruit(1001, "Golden Delicous Apple", "Apple", 4.50, 25, "https://www.applesfromny.com/wp-content/uploads/2020/06/Golden-DeliciousNEW.png");
	var grannySmith = new Fruit(1002, "Granny Smith Apple", "Apple", 3.75, 30, "#");
	var cantelope = new Fruit(1003, "Cantelope", "Cantelope", 6.99, 15, "#");
	var pineApple = new Fruit(1004, "Pineapple", "Pineapple", 5.45, 29, "#");
	var fruitList = [goldenDelicous, grannySmith, cantelope, pineApple];
    localStorage.setItem("fruitList", JSON.stringify(fruitList));

    const handleWish = (fruitID) => {
		console.log(fruitID)
	}
</script>

<div id="itemList">
    {#each fruitList as fruit}
        <div class="container">
			<img  class="itemImage" src={fruit.img} alt={fruit.name}>
			<div class="itemDescription">
				Name:{fruit.name}
				<br>
				Price: {fruit.price}
				<br>
				Quantity {fruit.quanity}
				<br>
			</div>
			<div class="wishlistButton">
				<button class="addWishlist" on:click={() => handleWish(Fruit.id)}>Add to WishList</button>
			</div></div>
    {/each}
</div>