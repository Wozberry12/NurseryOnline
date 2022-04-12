<script>
    class Tree{
		constructor(id, name, treeType, price, quantity, img){
			this.id = id;
			this.name =name;
			this.treeType = treeType;
			this.price = price;
			this.quantity = quantity;
			this.img = img;
		}
	}
	
	var goldenDelicous = new Tree(2001, "Golden Delicous Apple", "Apple", 4.50, 25, "https://www.applesfromny.com/wp-content/uploads/2020/06/Golden-DeliciousNEW.png");
	var grannySmith = new Tree(2002, "Granny Smith Apple", "Apple", 3.75, 30, "#");
	var cantelope = new Tree(2003, "Cantelope", "Cantelope", 6.99, 15, "#");
	var pineApple = new Tree(2004, "Pineapple", "Pineapple", 5.45, 29, "#");
	var treeList = [goldenDelicous, grannySmith, cantelope, pineApple];
    localStorage.setItem("treeList", JSON.stringify(treeList));

    const handleWish = (treeID) => {
		console.log(treeID)
	}
</script>

<div id="itemList">
    {#each treeList as tree}
        <div class="container">
			<img  class="itemImage" src={tree.img} alt={tree.name}>
			<div class="itemDescription">
				Name:{tree.name}
				<br>
				Price: {tree.price}
				<br>
				Quantity {tree.quantity}
				<br>
			</div>
			<button class="addWishlist" on:click={() => handleWish(tree.id)}>Add to WishList</button>
		</div>
    {/each}
</div>