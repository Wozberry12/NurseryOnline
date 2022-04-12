<script>
	import NavigationBar from './components/NavigationBar.svelte'
	

	
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

	
	

</script>

<main>
	<h1>Test</h1>
	<div id="navDiv"><NavigationBar /></div>
	<!--<FruitPage /> -->
	
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