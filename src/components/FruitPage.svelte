<script>
    class fruit{
		constructor(name, fruitType, price, quanity, img){
			this.name =name;
			this.fruitType = fruitType;
			this.price = price;
			this.quanity = quanity;
			this.img = img;
		}
	}
	
	var goldenDelicous = new fruit("Golden Delicous Apple", "Apple", 4.50, 25, "imgString");
	var grannySmith = new fruit("Granny Smith Apple", "Apple", 3.75, 30, "imgString");
	var cantelope = new fruit("Cantelope", "Cantelope", 6.99, 15, "imgString");
	var pineApple = new fruit("Pineapple", "Pineapple", 5.45, 29, "imgString");
	var fruitList = [goldenDelicous, grannySmith, cantelope, pineApple];
    localStorage.setItem("fruitList", JSON.stringify(fruitList));

    
</script>

<div id="fruitList">
    {#each fruitList as fruit}
        {fruit.name}
    {/each}
</div>