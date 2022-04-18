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
        <p class="reviewName">{reviewItem.nameOfReviewer}</p>
        <br>
        <br>
        <div class="reviewContainer">
            <p>{reviewItem.description}</p>
        </div>
        {/each}
    </div>  
{/if}

<style>
    .reviewInfo{
        width: 20%;
        float:right;
        border: solid 5px #333;
        border-radius: 5px;
        background-color: rgb(0, 138, 0);
        font-family: Verdana, Geneva, Tahoma, sans-serif;
        font-weight: bold;
    }

    .reviewRating{
        float: right;
        border: groove;
        background-color: lightsalmon;
        width:10%;
        margin-right: 20px;
        border-radius: 50%;
        height: 10%;
    }
    .reviewContainer{
        padding:1%;
        float: left;
        font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
        text-align: left;
    }
    .reviewName{
        float: left;
        padding: 10px;
        width: auto;
    }
</style>