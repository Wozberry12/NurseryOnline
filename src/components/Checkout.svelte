<script>
    export let showCheckout = false;
    let profile = JSON.parse(sessionStorage.getItem("currentlyLogedIn"));
    let itemList = profile.wishList;
    //export let itemList;

    let fruitList = JSON.parse(localStorage.getItem("fruitList"));
    let treeList = JSON.parse(localStorage.getItem("treeList"));

    const handleConfirm = () =>{
        for(let item of itemList){
            for(let fruit of fruitList){
                if(item.id === fruit.id){
                    fruit.quanity -= 1;
                    console.log(fruit);
                }
            }
        }
    localStorage.setItem("fruitList", JSON.stringify(fruitList));

        for(let item of itemList){
                for(let tree of treeList){
                    if(item.id === tree.id){
                        console.log(item.id)
                        console.log(tree.id)
                        tree.quanity -= 1;
                        console.log(tree.quanity);
                    }
                }
            }
    localStorage.setItem("treeList", JSON.stringify(treeList));

    while(itemList.length > 0) {
        itemList.pop();
        console.log(itemList);
        }
    
    profile.wishList = itemList;
    console.log(profile);
    sessionStorage.setItem("currentlyLogedIn", JSON.stringify(profile));
    window.alert("You Have Purchased the WishList");
    }
</script>

{#if showCheckout}
    <div class="checkoutDiv">
        <form id="informationForm">
            <label for="fullName">Enter your Full Name</label>
            <input type="text" id="fullName" name="fullName">
            <label for="address">Enter Your Address</label>
            <input type="text" id="address" name="address"><br>
            <label for="cardInfo">Enter your Card Number</label>
            <input type="text" id="cardInfo" name="cardInfo">
        </form>
    </div>
    <div class="confirm">
        <button class="addWishlist" on:click={() => handleConfirm()}>Place Order</button>
    </div>
{/if}

<style>
    .checkoutDiv{
        clear: both;
        text-align: left;
        margin: 25px;
    }
</style>