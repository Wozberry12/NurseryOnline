<script>
	import NavigationBar from './components/NavigationBar.svelte'
</script>
<main>
	<NavigationBar />
	
	
	

</main>

<style>
	main {
		padding: 1em;
		max-width: 240px;
		margin: 0 auto;
		text-align: center;
	}

	
	
	@media (min-width: 640px) {
		main {
			max-width: none;
		}
	}
</style>