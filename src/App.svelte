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
</script>

<main>
	
	<div id="navDiv"><NavigationBar /></div>


</main>
<footer>
	<p>Authors: <br>
		Benjamin Kamish, Marco Kosasih, William</p>
  </footer>

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