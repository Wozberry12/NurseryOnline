<script>
    var profile = JSON.parse(sessionStorage.getItem("currentlyLogedIn"));
    var itemList = profile.wishList;

</script>

<div class="userWishList">
    {#each itemList as item}
        <h1>{item.name}</h1>
    {/each}
</div>