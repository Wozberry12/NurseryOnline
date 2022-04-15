<script>
    export let showCheckout = false;

    let profileName = "";
    let profileAddress = "";
    let profileCardNumber = "";

    const handleConfirm = (profileName, profileAddress, profileCardNumber) =>{

    }
</script>

{#if showCheckout}
    <div class="checkoutDiv">
        <form id="informationForm">
            <label for="fullName">Enter your Full Name</label>
            <input type="text" id="fullName" name="fullName" bind:value={profileName}>
            <label for="address">Enter Your Address</label>
            <input type="text" id="address" name="address" bind:value={profileAddress}><br>
            <label for="cardInfo">Enter your Card Number</label>
            <input type="text" id="cardInfo" name="cardInfo" bind:value={profileCardNumber}>
        </form>
    </div>
    <div class="confirm">
        <button class="addWishlist" on:click={() => handleConfirm(profileName, profileAddress, profileCardNumber)}>Login</button>
    </div>
{/if}

<style>
    .checkoutDiv{
        clear: both;
        text-align: left;
        margin: 25px;
    }
</style>