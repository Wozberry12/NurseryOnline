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
            {reviewItem.nameOfReviewer}
            {reviewItem.description}
        {/each}
    </div>  
{/if}

<style>
    .reviewInfo{
        border:groove;
        width: 22%;
        float:right;
    }

    .reviewRating{
        border: groove;
        background-color: white;
        width:10%;
        height: 10%;
    }
</style>