<script>
    import Card from './Card.svelte'
    export let item 
</script>

<Card>
    <p class="plant_display">
        {item.name}
    </p>
    <p class="description_display">
        {item.description}
    </p>
    <p class="plant-rating">
        {item.rating}
    </p>

</Card>