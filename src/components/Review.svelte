<script>
    export let viewReview;
    export let reviewOfItems = [];
</script>

{#if viewReview}
    <div class="reviewInfo">
        {#each reviewOfItems as reviewItem} 
        <p class="reviewRating">
            {reviewItem.rating}
        </p>
        <div class="reviewContainer">
            {reviewItem.nameOfReviewer}
            {reviewItem.description}
        </div>
        {/each}
    </div>  
{/if}

<style>
    .reviewInfo{
        width: 22%;
        float:right;
        border: dashed 2px red;
    }

    .reviewRating{
        border: groove;
        background-color: white;
        width:10%;
        height: 10%;
    }
    .reviewContainer{
        border: groove;
        margin: 10px;
    }
</style>