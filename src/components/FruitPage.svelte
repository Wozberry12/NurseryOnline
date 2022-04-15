<script>
    // import {item} from './Item.svelte'
	// export const item = new item();
	

	class Item{
		constructor(id, name, Type, price, quanity, img, review){
			this.id = id;
			this.name =name;
			this.Type = Type;
			this.price = price;
			this.quanity = quanity;
			this.img = img;
			
		}
	}
	
	
	var goldenDelicous = new Item(1001, "Golden Delicous Apple", "Apple", 4.50, 25, "https://www.maxdelivery.com/nkz/gifs/60056277.jpg");
	var grannySmith = new Item(1002, "Granny Smith Apple", "Apple", 3.75, 30, "https://i5.walmartimages.com/asr/bf2ec88a-2f36-41f2-93d3-c3161772733d_1.cdc913433c6acc6bf9201dc1fa86bac9.jpeg");
	var cantelope = new Item(1003, "Cantelope", "Cantelope", 6.99, 15, "https://images.heb.com/is/image/HEBGrocery/000325202?fit=constrain,1&wid=800&hei=800&fmt=jpg&qlt=85,0&resMode=sharp2&op_usm=1.75,0.3,2,0");
	var pineapple = new Item(1004, "Pineapple", "Pineapple", 5.45, 29, "https://m.media-amazon.com/images/I/71+qAJehpkL._SL1500_.jpg");
	var grape = new Item(1005, "Concord Grape", "Grape", 15.99, 30, "https://cdn.shopify.com/s/files/1/0004/4426/8609/products/Concord-Grapes_v2_400x400.jpg?v=1537881231");
	var orange = new Item(1006, "Blood Orange", "Orange", 39.99, 48, "https://images.heb.com/is/image/HEBGrocery/000377507");
	var watermelon = new Item(1007, "Square Watermelon", "Watermelon", 27.99, 30, "https://atlas-content1-cdn.pixelsquid.com/assets_v2/242/2421099256203974413/jpeg-600/G03.jpg");
	var item8 = new Item(1008, "", "", 29.99, 8, "");
	var item9 = new Item(1009, "", "", 33.99, 14, "");
	var item10 = new Item(1010, "", "", 49.99, 17, "");

	var fruitList = [goldenDelicous, grannySmith, cantelope, pineapple, grape, orange, watermelon];
	localStorage.setItem("fruitList", JSON.stringify(fruitList));

    const handleWish = (fruit) => {
		console.log(JSON.parse(localStorage.getItem("fruitList")));		
		console.log(JSON.parse(sessionStorage.getItem("currentlyLogedIn")));
		var currentProfile = JSON.parse(sessionStorage.getItem("currentlyLogedIn"));
		var localWishList = currentProfile.wishList;
		localWishList.push(fruit);
		console.log(localWishList);
		console.log(currentProfile.username);
		currentProfile.wishList = localWishList;
		console.log(currentProfile.wishList);
		window.alert(fruit.name + " added to wishlist");
		sessionStorage.setItem("currentlyLogedIn", JSON.stringify(currentProfile));
	}

	const handleReview = (tree) => {
		
	}
</script>

<div id="itemList">
    {#each fruitList as fruit}
        <div class="container">
			<img  class="itemImage" src={fruit.img} alt={fruit.name}>
			<div class="itemDescription">
				Name: {fruit.name}
				<br>
				Price: {fruit.price}
				<br>
				Quantity: {fruit.quanity}
				<br>
			</div>
			<div class="itemButton">
				<button class="addWishlist" on:click={() => handleWish(fruit)}>Add to WishList</button>
				<br>
				<button class="viewReview" on:click={() => handleReview(fruit)}>View Reviews</button>
			</div></div>
    {/each}
</div>