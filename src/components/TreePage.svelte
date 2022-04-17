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
	
	var bonsai = new Item(2001, "Bonsai Tree", "Bonsai", 999.99, 2, "https://m.media-amazon.com/images/I/716E7FNKtFL._AC_SX569_.jpg");
	var dragon = new Item(2002, "Dragon Tree", "Caesalpinia", 3.75, 30, "https://i5.walmartimages.com/asr/0149db71-df23-4dc8-9995-205fb5acfbd2.284e3ef8e9998c0dfc4330141cf5f0ee.jpeg");
	var palm = new Item(2003, "Parlor Palm", "Chamaedora elegans", 6.99, 15, "https://images.thdstatic.com/productImages/9fcb04c0-aff8-406c-afbe-ce886879ce58/svn/indoor-plants-4-palm-parlor-64_1000.jpg");
	var candelabra = new Item(2004, "African Candelabra", "Pineapple", 5.45, 29, "https://i.etsystatic.com/20034067/r/il/ff969a/1852472466/il_fullxfull.1852472466_m4eb.jpg");
	var olive = new Item(2005, "European Olive", "Olive", 99.99, 19, "https://target.scene7.com/is/image/Target/GUEST_733d8ce6-a9fe-4e7b-bda2-c9c34ac2357d?wid=488&hei=488&fmt=pjpeg");
	var item6 = new Item(2006, "", "", 87,99, 3, "");
	var item7 = new Item(2007, "", "", 27.99, 10, "");
	var item8 = new Item(2008, "", "", 29.99, 8, "");
	var item9 = new Item(2009, "", "", 33.99, 14, "");
	var item10 = new Item(2010, "", "", 49.99, 17, "");
	
	var treeListOld = [bonsai, dragon, palm, candelabra, olive];
    // localStorage.setItem("treeList", JSON.stringify(treeList));

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

	const handleReview = (tree) => {

	}

</script>

<div id="itemList">
    {#each treeListNew as tree}
        <div class="container">
			<img  class="itemImage" src={tree.img} alt={tree.name}>
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
		</div>
    {/each}
</div>