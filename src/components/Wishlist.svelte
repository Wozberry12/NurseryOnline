<script>
    import Checkout from "./Checkout.svelte"

    var profile = JSON.parse(sessionStorage.getItem("currentlyLogedIn"));
    var itemList = profile.wishList;
    var sum = 0;
    let showCheckout = false;
    
    itemList.forEach(item => {
        console.log(item.price);
        sum += item.price
    });

    const handlePurchase = () => {
        if(showCheckout == true){
            showCheckout = false;
        }
        else if(showCheckout == false){
            showCheckout = true
        }
    }
</script>


<div class="userWishList">

    <div class="purchaseButton">
        <button class="purchaseWishList" on:click={() => handlePurchase()}>Purchase WishList</button>
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
    <div class="totalPrice">
        totalPrice = {sum};
    </div>
    
</div>
{#if {showCheckout}}
    <Checkout showCheckout={showCheckout}/>
{/if}

<style>
    .totalPrice{
        float: right;
        margin-right: 50px;
        border-color: black ;
    }
</style>