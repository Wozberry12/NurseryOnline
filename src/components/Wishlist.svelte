<script>
    import Checkout from "./Checkout.svelte"
    import Login from "./Login.svelte"

    var profile = JSON.parse(sessionStorage.getItem("currentlyLogedIn"));

    var itemList = profile.wishList;
    if (itemList == null) {
        
    }

    var sum = 0;
    let showCheckout = false;
    
    itemList.forEach(item => {
        // console.log(item.price);
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
            <div class="itemImage">
                <img  class="itemImage" src={item.img} alt={item.name}>
			</div>
            <div class="itemDescription">
                Name:{item.name}
                <br>
                Price: {item.price}
                <br>
                Quantity: {item.quanity}
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
    <!-- <Checkout showCheckout={showCheckout} itemList={itemList}/> -->
{/if}

<style>
    .totalPrice{
        float: right;
        margin-right: 50px;
        border-color: black ;
    }
</style>