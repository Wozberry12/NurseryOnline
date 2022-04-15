<script>
    export let showCheckout = false;
    var profile = JSON.parse(sessionStorage.getItem("currentlyLogedIn"));
    var itemList = profile.wishList;


</script>

{#if showCheckout}
    <div class="checkoutDiv">
hi
    </div>
{/if}

<style>
    .checkoutDiv{
        clear: both;
    }
</style>