<script>
    // import {item} from './Item.svelte'
	// export const item = new item();
	import ReviewFruit from "./Review.svelte"
	
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
		constructor(rating, description,nameOfReviewer){
			this.rating = rating;
			this.description = description;
			this.nameOfReviewer = nameOfReviewer;
		}
	}
	
	var review1 = [];
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
	var grannySmith = new Item(1002, "Granny Smith Apple", "Apple", 3.75, 30, "https://i5.walmartimages.com/asr/bf2ec88a-2f36-41f2-93d3-c3161772733d_1.cdc913433c6acc6bf9201dc1fa86bac9.jpeg", review1);
	var cantelope = new Item(1003, "Cantelope", "Cantelope", 6.99, 15, "https://images.heb.com/is/image/HEBGrocery/000325202?fit=constrain,1&wid=800&hei=800&fmt=jpg&qlt=85,0&resMode=sharp2&op_usm=1.75,0.3,2,0", review3);
	var pineapple = new Item(1004, "Pineapple", "Pineapple", 5.45, 29, "https://m.media-amazon.com/images/I/71+qAJehpkL._SL1500_.jpg", review4);
	var grape = new Item(1005, "Concord Grape", "Grape", 15.99, 30, "https://cdn.shopify.com/s/files/1/0004/4426/8609/products/Concord-Grapes_v2_400x400.jpg?v=1537881231", review5);
	var orange = new Item(1006, "Blood Orange", "Orange", 39.99, 48, "https://images.heb.com/is/image/HEBGrocery/000377507", review6);
	var watermelon = new Item(1007, "Square Watermelon", "Watermelon", 27.99, 30, "https://atlas-content1-cdn.pixelsquid.com/assets_v2/242/2421099256203974413/jpeg-600/G03.jpg", review7);
	var rambutan = new Item(1008, "Rambutan", "Rambutan", 9.99, 8, "https://produits.bienmanger.com/38127-0w600h600_Rambutan.jpg", review8);
	var durian = new Item(1009, "Durian", "Durian", 33.99, 14, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT-2_6SRJK2viP847Hy6Vcq2SUj7UkuHVZ_6k94SEB26nj01zSKrepPpqc-ylMzYXbkX7o&usqp=CAU", review9);
	var dragonfruit = new Item(1010, "DragonFruit", "DragonFruit", 49.99, 17, "https://cdn.shopify.com/s/files/1/0336/7167/5948/products/3-count-image-of-dragon-fruit-white-fruit-29921760706604_600x600.jpg?v=1648081574", review10);
	
	var newReview1 = new Review(9,"This is one of the best apples that I have tasted. My entire family loves this!", "Ben");
	var newReview2 = new Review(3, "Average Taste. Would not but again OwO", "Marco");
	var newReview3 = new Review(2, "It is sweet, but it could've been better. Some orders that arrived are also rotten. >:[", "Marco");
	var newReview4 = new Review(9, "I mised the fruit to make my specialty and it tasted the best! You gained a new customer",  "Ben");
	var newReview5 = new Review(8, "Amazing Product! Very Sweet and makes me feel like Ceasar when being fed by my wife.",  "Will");
	var newReview6 = new Review(6, "Pretty decent quality. But I ordered regular oranges, not blood orange",  "Ben");
	var newReview7 = new Review(10, "Order this from a challenge by some flat friends. Ended up knocking out one of us for several days. 10/10 would recommend", "Will");
	var newReview8 = new Review(2, "Bad Taste; very hairy, very ew ew",  "Marco");
	var newReview9 = new Review(1, "[CAUTION] DO NOT BUY, THE SPIKES CAN HURT YOU!!!!!!!", "Ben");
	var newReview10 = new Review(5, "dargon", "Marco");
	
	goldenDelicous.reviews.push(newReview1);
	grannySmith.reviews.push(newReview2);
	cantelope.reviews.push(newReview3);
	pineapple.reviews.push(newReview4);
	grape.reviews.push(newReview5);
	orange.reviews.push(newReview6);
	watermelon.reviews.push(newReview7);
	rambutan.reviews.push(newReview8);
	durian.reviews.push(newReview9);
	dragonfruit.reviews.push(newReview10);

	//base data for all fruits
	var baseFruitList = [goldenDelicous, grannySmith, cantelope, pineapple, grape, orange, watermelon, rambutan, durian, dragonfruit];

	//current fruit lists that are in localstorage
	var currentFruitList = JSON.parse(localStorage.getItem("fruitList"));
	var newFruitList = [];

	//updates fruit quantity data after purchase in checkout
	if(currentFruitList != null){
		for(let fruitOld of baseFruitList){
            for(let fruitNew of currentFruitList){
                if(fruitNew.id === fruitOld.id){
					if(fruitNew.quanity <= fruitOld.quanity){
						newFruitList.push(fruitNew);
					}
					else(newFruitList.push(fruitOld))
                }
            }
        }
		if(currentFruitList.length > baseFruitList.length){
			for(let i = baseFruitList.length; i < currentFruitList.length; i++){
				newFruitList.push(currentFruitList[i]);
			}
		}
	}else if(currentFruitList == null){
		for(let fruit of baseFruitList){
			newFruitList.push(fruit);
		}
	}
	
	localStorage.setItem("fruitList", JSON.stringify(newFruitList));


    const handleWish = (fruit) => {
		var currentProfile = JSON.parse(sessionStorage.getItem("currentlyLogedIn"));
		var localWishList = currentProfile.wishList;

		localWishList.push(fruit);
		currentProfile.wishList = localWishList;
		window.alert(fruit.name + " added to wishlist");
		sessionStorage.setItem("currentlyLogedIn", JSON.stringify(currentProfile));
	}

	let showReview = false;
	const handleReview = () => {
        if(showReview == true){
            showReview = false;
        }
        else if(showReview == false){
            showReview = true
        }
	}
	
	const handleAddReview = (fruit) =>{
		let localFruitList = JSON.parse(localStorage.getItem("fruitList"));
		let addRating = document.getElementById("ratingInputFruit").value;
		let addeDescription = document.getElementById("descriptionInputFruit").value;

		let currentProfile = JSON.parse(sessionStorage.getItem("currentlyLogedIn"));
			let currentProfileUsername = currentProfile.username;
			for (var item = 0; item < localFruitList.length; item++) {
				if(localFruitList[item].id == fruit.id){
					var addedReview = new Review(addRating, addeDescription, currentProfileUsername);
					console.log(addedReview);
					localFruitList[item].reviews.push(addedReview);
					console.log(item);
				}
			}
		localStorage.setItem("fruitList", JSON.stringify(localFruitList));
		
	}
	const handlePassFruit = (fruit) =>{
		let fruitInStorage = JSON.parse(localStorage.getItem("fruitList"));
		for(var item = 0; item <fruitInStorage.length; item++){
			if(fruitInStorage[item].id == fruit.id){
				fruitInStorage.splice(item, 1);
			}
		}
		// let itemDiv = document.getElementsById("itemImage");
		// itemDiv.innerHTML = "";

		// let descriptionDiv = document.getElementById("itemDescription");
		// descriptionDiv.innerHTML = "";	

		localStorage.setItem("fruitList", JSON.stringify(fruitInStorage));
		
	}
</script>

<div id="itemList">
    {#each newFruitList as fruit}
	{#if fruit.quanity> 0}
	<div class="container">
			<div class="itemImage">
				<img src={fruit.img} alt={fruit.name}>
			</div>
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
				<button id="notInterest" on:click={() => handlePassFruit(fruit)}>Not Interested</button>
				<br>
				<button id="viewReview" on:click={() => handleReview(fruit)}>View Reviews</button>

			</div>
			{#if {showReview}}
				<ReviewFruit viewReview={showReview} reviewOfItems={fruit.reviews}/>
			{/if}
			<div id="addReview">		
					<br>
					<label for="title">Enter Your Review of This Item:</label>

					<label for="rating">Rating:</label>
					<input type="text" id="ratingInputFruit" name="rating">
					<label for="description">Description:</label>
					<input type="text" id="descriptionInputFruit" name="description">
					<br>
					<button class="addReview" on:click={() => handleAddReview(fruit)}>Add Review</button>
				
			</div>
			
		</div>
		{/if}
    {/each}
</div>