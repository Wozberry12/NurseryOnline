<script>
    // import {item} from './Item.svelte'
	// export const item = new item();
	let name;
	let description;
	let rating;
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
	class Review{
		constructor(rating, description, starImg, nameOfReviewer){
			this.rating = rating;
			this.description = description;
			this.starImg = starImg;
			this.nameOfReviewer = nameOfReviewer;
		}
	}
	
	var review = [];
	var review2 = [];	
	var review3=[];
	var review4=[];
	var review5=[];
	var review6 = [];
	var review7 = [];
	var review8=[];
	var review9=[];
	var review10=[];

	var goldenDelicous = new Item(1001, "Golden Delicous Apple", "Apple", 4.50, 25, "https://www.maxdelivery.com/nkz/gifs/60056277.jpg", review2);
	var grannySmith = new Item(1002, "Granny Smith Apple", "Apple", 3.75, 30, "https://i5.walmartimages.com/asr/bf2ec88a-2f36-41f2-93d3-c3161772733d_1.cdc913433c6acc6bf9201dc1fa86bac9.jpeg", review);
	var cantelope = new Item(1003, "Cantelope", "Cantelope", 6.99, 15, "https://images.heb.com/is/image/HEBGrocery/000325202?fit=constrain,1&wid=800&hei=800&fmt=jpg&qlt=85,0&resMode=sharp2&op_usm=1.75,0.3,2,0", review3);
	var pineapple = new Item(1004, "Pineapple", "Pineapple", 5.45, 29, "https://m.media-amazon.com/images/I/71+qAJehpkL._SL1500_.jpg", review4);
	var grape = new Item(1005, "Concord Grape", "Grape", 15.99, 30, "https://cdn.shopify.com/s/files/1/0004/4426/8609/products/Concord-Grapes_v2_400x400.jpg?v=1537881231", review5);
	var orange = new Item(1006, "Blood Orange", "Orange", 39.99, 48, "https://images.heb.com/is/image/HEBGrocery/000377507", review6);
	var watermelon = new Item(1007, "Square Watermelon", "Watermelon", 27.99, 30, "https://atlas-content1-cdn.pixelsquid.com/assets_v2/242/2421099256203974413/jpeg-600/G03.jpg", review7);
	var rambutan = new Item(1008, "Rambutan", "Rambutan", 9.99, 8, "https://produits.bienmanger.com/38127-0w600h600_Rambutan.jpg", review8);
	var durian = new Item(1009, "Durian", "Durian", 33.99, 14, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT-2_6SRJK2viP847Hy6Vcq2SUj7UkuHVZ_6k94SEB26nj01zSKrepPpqc-ylMzYXbkX7o&usqp=CAU", review9);
	var dragonfruit = new Item(1010, "DragonFruit", "DragonFruit", 49.99, 17, "https://cdn.shopify.com/s/files/1/0336/7167/5948/products/3-count-image-of-dragon-fruit-white-fruit-29921760706604_600x600.jpg?v=1648081574", review10);
	
	var newReview = new Review(4, "Great Taste", "#", "Ben");
	var newReview2 = new Review(3, "Average Taste", "#", "Will");
	var newReview3 = new Review(2, "Could've been better", "#", "Marco");
	var newReview4 = new Review(1, "Would Not Buy Again", "#", "Ben");
	var newReview5 = new Review(5, "Amazing Product!", "#", "Will");
	var newReview6 = new Review(4, "Pretty great quality", "#", "Ben");
	var newReview7 = new Review(3, "Average quality", "#", "Marco");
	var newReview8 = new Review(2, "Bad Taste", "#", "Ben");
	var newReview9 = new Review(1, "Rotting", "#", "Will");
	var newReview10 = new Review(5, "Would buy 50 more!", "#", "Marco");
	
	goldenDelicous.reviews.push(newReview);
	grannySmith.reviews.push(newReview2);
	cantelope.reviews.push(newReview3);
	pineapple.reviews.push(newReview4);
	grape.reviews.push(newReview5);
	orange.reviews.push(newReview6);
	watermelon.reviews.push(newReview7);
	rambutan.reviews.push(newReview8);
	durian.reviews.push(newReview9);
	dragonfruit.reviews.push(newReview10);


	var baseFruitList = [goldenDelicous, grannySmith, cantelope, pineapple, grape, orange, watermelon, rambutan, durian, dragonfruit];

	var currentFruiList = JSON.parse(localStorage.getItem("fruitList"));
	var newFruitList = [];
	for(let fruitOld of baseFruitList){
            for(let fruitNew of currentFruiList){
                if(fruitNew.id === fruitOld.id){
					if(fruitNew.quanity <= fruitOld.quanity){
						newFruitList.push(fruitNew);
					}
					else(newFruitList.push(fruitOld))
                }
            }
        }

	localStorage.setItem("fruitList", JSON.stringify(newFruitList));
	


    const handleWish = (fruit) => {
		// console.log(JSON.parse(localStorage.getItem("fruitList")));		
		// console.log(JSON.parse(sessionStorage.getItem("currentlyLogedIn")));
		var currentProfile = JSON.parse(sessionStorage.getItem("currentlyLogedIn"));
		var localWishList = currentProfile.wishList;

		// for(let item of localWishList){
		// 	if(item.id === fruit.id){
		// 		fruit.quanityWish += 1;
		// 		console.log(fruit.quanityWish);
		// 		console.log(localWishList);
		// 		item.quanityWish = fruit.quanityWish;
		// 		localWishList = localWishList;
		// 		localWishList.push(fruit);
		// 		return;
		// 	}
		// }
		localWishList.push(fruit);
		// console.log(localWishList);
		// console.log(currentProfile.username);
		currentProfile.wishList = localWishList;
		// console.log(currentProfile.wishList);
		window.alert(fruit.name + " added to wishlist");
		sessionStorage.setItem("currentlyLogedIn", JSON.stringify(currentProfile));
	}

	const handleReview = (fruit) => {
		

	}
	
	const handleAddReview = (fruit) =>{
		var localList = JSON.parse(localStorage.getItem("fruitList"));
		for(var i = 0; i < localList.length; i++){
			if(localList[i].id == fruit.id){
				var addedReview = new Review(rating, description,"#", name);
				fruit.reviews.push(addedReview);
				localList[i] = fruit;
			}
		}
		fruitList = localList;
		localStorage.setItem("fruitList", JSON.stringify(localList));
		
	}
</script>

<div id="itemList">
    {#each newFruitList as fruit}
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
			<div id="reviewInfo">
				{#each fruit.reviews as reviews} 
					{reviews.nameOfReviewer}
					{reviews.rating}
					{reviews.description}
				{/each}
			</div>
			<div id="addReview">
				<form id="addReviewForm">
					<label for="name">Name:</label>
					<input type="text" id="name" name="name" bind:value={name}>
					<label for="rating">Rating:</label>
					<input type="text" id="rating" name="rating" bind:value={rating}>
					<label for="description">Description:</label>
					<input type="text" id="description" name="description" bind:value={description}>
					<button class="addReview" on:click={() => handleAddReview(fruit)}>Add Review</button>
				</form>
			</div>
			<div class="itemButton">
				<button class="addWishlist" on:click={() => handleWish(fruit)}>Add to WishList</button>
				<br>
				<button class="viewReview" on:click={() => handleReview(fruit)}>View Reviews</button>
				<button class="addReview" on:click={() => handleAddReview(fruit)}>Add Review</button>
			</div>
		</div>
    {/each}
</div>