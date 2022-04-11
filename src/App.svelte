<script>
	import NavigationBar from './components/NavigationBar.svelte'
	import Login from './components/Login.svelte'
</script>

<main>
	<div><NavigationBar /></div>
	<div><Login/></div>
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