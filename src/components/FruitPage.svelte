<script>
    
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

	var goldenDelicous = new Item(1001, "Golden Delicous Apple", "Apple", 4.50, 25, "https://www.applesfromny.com/wp-content/uploads/2020/06/Golden-DeliciousNEW.png");
	var grannySmith = new Item(1002, "Granny Smith Apple", "Apple", 3.75, 30, "#");
	var cantelope = new Item(1003, "Cantelope", "Cantelope", 6.99, 15, "#");
	var pineApple = new Item(1004, "Pineapple", "Pineapple", 5.45, 29, "#");
	var fruitList = [goldenDelicous, grannySmith, cantelope, pineApple];
    localStorage.setItem("fruitList", JSON.stringify(fruitList));

    const handleWish = (fruit) => {
		var currentProfile = JSON.parse(sessionStorage.getItem("currentlyLogedIn"));
		var localWishList = currentProfile.getWishList();
		localWishList.push(fruit);
		currentProfile.wishList = localWishList;
		sessionStorage.setItem("currentlyLogedIn", JSON.stringify(currentProfile));
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
				<button class="addWishlist" on:click={() => handleWish(fruit)}>Add to WishList</button>
			</div></div>
    {/each}
</div>