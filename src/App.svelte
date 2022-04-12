<script>
	import NavigationBar from './components/NavigationBar.svelte'
	import FeedbackList from './components/FeedbackList.svelte'
	
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
	var fruitList = new fruit(goldenDelicous, grannySmith);
	
</script>

<main>
	<div id="navDiv"><NavigationBar /></div>
		
	
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