<script>
	import NavigationBar from './components/NavigationBar.svelte'
	
</script>
<div id="pageContent">
	<main>
		<div id="navDiv"><NavigationBar /></div>
	</main>
	<footer id="footer">
		<p>Authors: 
			Benjamin Kamish, Marco Kosasih, William Oswald</p>
	</footer>
</div>


<style>
	
	main {
		padding: 1em;
		max-width: 240px;
		margin: 0 auto;
		text-align: center;
		padding:0;
		padding-bottom: 2.5rem;  
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