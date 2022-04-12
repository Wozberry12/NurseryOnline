<script>
	import NavigationBar from './components/NavigationBar.svelte'
	import FruitPage from './components/FruitPage.svelte'
	import {writable} from "svelte/store";
	
	let feedback = [
		{
			id: 1,
			rating: 10,
			name: 'rose',
			description: 'this is a rose',
		},
		{
			id: 2,
			rating: 10,
			name: 'daisy',
			description: 'this is a daisy',
		},
		{
			id: 1,
			rating: 10,
			name: 'tulip',
			description: 'this is a tulip',
		}
	]
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

	// const stored = localStorage.content

	
	// export const content = writable<Fruit>(JSON.parse(localStorage.getItem('fruit')))
	// content.subscribe((value) => localStorage.fruit = JSON.stringify(value))
</script>

<main>
	
	<div id="navDiv"><NavigationBar /></div>

	<footer>
		<p>this is a footer</p>
	</footer>

		
	
	<!-- <div class="plantlist">
		<FeedbackList {feedback}/>
	</div> -->
	
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
	
	@media (min-width: 640px) {
		main {
			max-width: none;
		}
	}
</style>