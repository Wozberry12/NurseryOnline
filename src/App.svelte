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
</script>

<main>
	<div id="navDiv"><NavigationBar /></div>
<<<<<<< HEAD

	<footer>
		<p>this is a footer</p>
	</footer>
=======
		
	
	<!-- <div class="plantlist">
		<FeedbackList {feedback}/>
	</div> -->
	
>>>>>>> 92b973b2e872561c59b47a95fd463816f577423b
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