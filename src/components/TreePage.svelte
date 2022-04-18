<script>
	import ReviewTree from "./Review.svelte"

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
		constructor(rating, description, nameOfReviewer){
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

	var bonsai = new Item(2001, "Bonsai Tree", "Bonsai", 999.99, 2, "https://m.media-amazon.com/images/I/716E7FNKtFL._AC_SX569_.jpg", review1);
	var dragon = new Item(2002, "Dragon Tree", "Caesalpinia", 3.75, 30, "https://i5.walmartimages.com/asr/0149db71-df23-4dc8-9995-205fb5acfbd2.284e3ef8e9998c0dfc4330141cf5f0ee.jpeg", review2);
	var palm = new Item(2003, "Parlor Palm", "Chamaedora elegans", 6.99, 15, "https://images.thdstatic.com/productImages/9fcb04c0-aff8-406c-afbe-ce886879ce58/svn/indoor-plants-4-palm-parlor-64_1000.jpg", review3);
	var candelabra = new Item(2004, "African Candelabra", "Candelabra", 5.45, 29, "https://i.etsystatic.com/20034067/r/il/ff969a/1852472466/il_fullxfull.1852472466_m4eb.jpg", review4);
	var olive = new Item(2005, "European Olive", "Olive", 99.99, 19, "https://target.scene7.com/is/image/Target/GUEST_733d8ce6-a9fe-4e7b-bda2-c9c34ac2357d?wid=488&hei=488&fmt=pjpeg", review5);
	var citrus = new Item(2006, "Citrus Tree", "Citrus", 29.99, 99, "https://www.botanicly.com/media/93/23/2b/1614610453/3f6638de76cb4357913475c9807b8bb5.png", review6);
	var fig = new Item(2007, "Weepign Fig", "ficus benjamina", 27.99, 10, "https://images.thdstatic.com/productImages/85c7391e-bff2-43cf-ab08-878e2c81f50a/svn/brighter-blooms-indoor-plants-fic-ben-34-3-brd-64_600.jpg", review7);
	var money = new Item(2008, "Money Tree", "pachira aquatica", 29.99, 8, "https://www.ikea.com/nl/en/images/products/pachira-aquatica-potted-plant-guinea-chestnut__0653983_pe708212_s5.jpg", review8);
	var corn = new Item(2009, "Corn Plant", "dracaena fragrans", 33.99, 14, "https://cdn.atwilltech.com/flowerdatabase/b/basket-of-corn-plants-dracaena-fragrans-massangeana-PL01601.425.jpg", review9);
	var umbrella = new Item(2010, "Umbrella Plant", "", 49.99, 17, "https://cdn.shoplightspeed.com/shops/611765/files/29754218/schefflera-arboricola-35.jpg", review10);

	var newReview0 = new Review(9, "I love chopping this everything", "Marco")
	var newReview1 = new Review(9, "Great Taste", "Ben");
	var newReview2 = new Review(6, "Average Taste", "Will");
	var newReview3 = new Review(4, "Could've been better", "Marco");
	var newReview4 = new Review(1, "Would Not Buy Again", "Ben");
	var newReview5 = new Review(9, "Amazing Product!", "Will");
	var newReview6 = new Review(10, "Pretty great quality", "Ben");
	var newReview7 = new Review(5, "Average quality", "Marco");
	var newReview8 = new Review(2, "Bad Taste", "Ben");
	var newReview9 = new Review(1, "Rotting", "Will");
	var newReview10 = new Review(10, "Would buy 50 more!", "Marco");
	
	bonsai.reviews.push(newReview1);
	dragon.reviews.push(newReview2);
	palm.reviews.push(newReview3);
	candelabra.reviews.push(newReview4);
	olive.reviews.push(newReview5);
	citrus.reviews.push(newReview6);
	fig.reviews.push(newReview7);
	money.reviews.push(newReview8);
	corn.reviews.push(newReview9);
	umbrella.reviews.push(newReview10);

	var treeListOld = [bonsai, dragon, palm, candelabra, olive, citrus, fig, money, corn, umbrella];
	

	var treeListCurrent = JSON.parse(localStorage.getItem("treeList"));
	var treeListNew = [];
	
	if(treeListCurrent !== null){
		for(let treeOld of treeListOld){
            for(let treeNew of treeListCurrent){
                if(treeNew.id === treeOld.id){
					if(treeNew.quanity <= treeOld.quanity){
						treeListNew.push(treeNew);
					}
					else(treeListNew.push(treeOld))
                }
            }
        }
	}else if(treeListCurrent == null){
		for(let tree of treeListOld){
			treeListNew.push(tree);
		}
	}

	localStorage.setItem("treeList", JSON.stringify(treeListNew));

    const handleWish = (tree) => {
		console.log(JSON.parse(localStorage.getItem("treeList")));		
		console.log(JSON.parse(sessionStorage.getItem("currentlyLogedIn")));
		var currentProfile = JSON.parse(sessionStorage.getItem("currentlyLogedIn"));
		var localWishList = currentProfile.wishList;
		localWishList.push(tree);
		console.log(localWishList);
		console.log(currentProfile.username);
		currentProfile.wishList = localWishList;
		console.log(currentProfile.wishList);
		window.alert(tree.name + " added to wishlist");
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
	
	const handleAddReview = (tree) =>{
		let localFruitList = JSON.parse(localStorage.getItem("treeList"));
		let addRating = document.getElementById("ratingInput").value;
		let addeDescription = document.getElementById("descriptionInput").value;

		let currentProfile = JSON.parse(sessionStorage.getItem("currentlyLogedIn"));
			let currentProfileUsername = currentProfile.username;
			for (var item = 0; item < localFruitList.length; item++) {
				if(localFruitList[item].id == tree.id){
					var addedReview = new Review(addRating, addeDescription,"#", currentProfileUsername);
					console.log(addedReview);
					localFruitList[item].reviews.push(addedReview);
					console.log(item);
				}
			}
		localStorage.setItem("treeList", JSON.stringify(localFruitList));
		
	}
</script>

<div id="itemList">
    {#each treeListNew as tree}
        <div class="container">
			<div class="itemImage">
				<img src={tree.img} alt={tree.name}>
			</div>
			<div class="itemDescription">
				Name: {tree.name}
				<br>
				Price: {tree.price}
				<br>
				Quantity: {tree.quanity}
				<br>
			</div>
			<div class="itemButton">
				<button class="addWishlist" on:click={() => handleWish(tree)}>Add to WishList</button>
				<br>
				<button class="viewReview" on:click={() => handleReview(tree)}>View Reviews</button>
				
			</div>
			{#if {showReview}}
				<ReviewTree viewReview={showReview} reviewOfItems={tree.reviews}/>
			{/if}
			<div id="addReview">	
				<form id="addReviewForm">
					<br>
					<label for="title">Enter Your Review of This Item:</label>
				
					<label for="rating">Rating:</label>
					<input type="text" id="ratingInput" name="rating">
					<label for="description">Description:</label>
					<input type="text" id="descriptionInput" name="description">
					<button class="addReview" on:click={() => handleAddReview(tree)}>Add Review</button>
				
			</div>
		</div>
    {/each}
</div>