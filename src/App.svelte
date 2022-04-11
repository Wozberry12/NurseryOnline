<script>
	import NavigationBar from 'NavigationBar.svelte'

</script>
<main>
	<h1>Will!</h1>
	<NavigationBar />

</main>

<style>
	main {
		padding: 1em;
		max-width: 240px;
		margin: 0 auto;
		text-align: center;
	}

	h1 {
		color: #ff3e00;
		text-transform: uppercase;
		font-size: 3em;
		font-weight: 100;
	}
	
	@media (min-width: 640px) {
		main {
			max-width: none;
		}
	}
</style>