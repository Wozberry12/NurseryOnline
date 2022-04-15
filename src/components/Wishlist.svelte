<script>
    var profile = JSON.parse(sessionStorage.getItem("currentlyLogedIn"));
    var itemList = profile.wishList;

    const handlePurchase = (itemList) => {
	
    }
</script>

<div class="userWishList">
    <div class="purchaseButton">
        <button class="purchaseWishList" on:click={() => handlePurchase(itemList)}>Purchase WishList</button>
    </div>
    {#each itemList as item}
    <div class="container">
        <img  class="itemImage" src={item.img} alt={item.name}>
        <div class="itemDescription">
            Name:{item.name}
            <br>
            Price: {item.price}
            <br>
            Quantity {item.quantity}
            <br>
        </div>
    </div>
    {/each}
</div>