<script>
	import NavigationBar from './components/NavigationBar.svelte'
	class Fruit{
		constructor(name, fruitType, price, quanity, img){
			this.name =name;
			this.fruitType = fruitType;
			this.price = price;
			this.quanity = quanity;
			this.img = img;
		}
	}
	
	let goldenDelicous = new Fruit("Golden Delicous Apple", "Apple", 4.50, 25, "imgString");
	let grannySmith = new Fruit("Granny Smith Apple", "Apple", 3.75, 30, "imgString");
	let cantelope = new Fruit("Cantelope", "Cantelope", 6.99, 15, "imgString");
	let pineApple = new Fruit("Pineapple", "Pineapple", 5.45, 29, "imgString");
	var fruitList = new Fruit(goldenDelicous, grannySmith, cantelope, pineApple);
</script>

<main>
	
	<div id="navDiv"><NavigationBar /></div>

	<footer>
		<p>this is a footer</p>
	</footer>
	
</main>


<style>
	
	main {
		padding: 1em;
		max-width: 240px;
		margin: 0 auto;
		text-align: center;
		padding:0;
	}
	
	#navDiv{
		margin:auto;
	}
	
	@media(min-width: 640px) {
		main {
			max-width: none;
		}
	}
</style>