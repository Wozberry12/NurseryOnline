<script>
    import Login from "./Login.svelte";
    import Wishlist from "./Wishlist.svelte";
    import About from "./About.svelte";
    import FruitList from "./FruitPage.svelte";
    import TreeList from "./TreePage.svelte";
    import AddFruit from "./AddFruit.svelte";
    import AddTree from "./AddTree.svelte";
    export let menu = 1;

</script>
<!--Markup is here-->
<nav>
    <div id="navContainer">
        <ul id ="navList">
            <li><a href="/" on:click|preventDefault={() => (menu = 1)}>Login</a></li>
            <li><a href="/" on:click|preventDefault={() => (menu = 2)}>WishList</a></li>
            <li><a href="/" on:click|preventDefault={() => (menu = 3)}>Fruit For Sale</a></li>
            <li><a href="/" on:click|preventDefault={() => (menu = 4)}>Tree For Sale</a></li>
            <li><a href="/" on:click|preventDefault={() => (menu = 5)}>Add Fruit</a></li>
            <li><a href="/" on:click|preventDefault={() => (menu = 6)}>Add Tree</a></li>
            <li><a href="/" on:click|preventDefault={() => (menu = 7)}>About</a></li>

        </ul>
    </div>
</nav>

{#if menu === 1}
    <Login />
{:else if menu === 2}
    <Wishlist />
{:else if menu === 3}
    <FruitList />
{:else if menu === 4}
    <TreeList />
{:else if menu === 5}
    <AddFruit />
{:else if menu === 6}
    <AddTree />
{:else if menu === 7}
    <About />
{:else}
    <h1>Page not Found</h1>
{/if}
<style>
    nav{
        font-family:-apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;
        height: 50px;       
    }
    
    ul{
    list-style-type: none;
    margin:0;
    padding:0;
    overflow: hidden;
    background-color: #333;
    }

    li{
        float:right;
	    color:white;
    }

    li a{
        display: block;
        color:white;
        text-align: center;
        padding: 14px 16px;
        text-decoration: none;
	    color:white;
    }

    li a:hover{
        background-color: #111;
    }
</style>