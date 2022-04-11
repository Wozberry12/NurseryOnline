<script>
	import NavigationBar from './components/NavigationBar.svelte'
	
</script>

<main>
	<div id="navDiv"><NavigationBar /></div>
	<div class="titleDiv"><h1>Welcome to the Online</h1></div>
	
	
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