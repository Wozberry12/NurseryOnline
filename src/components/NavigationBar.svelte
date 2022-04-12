<script>
    import Login from "./Login.svelte";
    import Wishlist from "./Wishlist.svelte";
    import FeedbackList from "./FeedbackList.svelte";
    export let menu = 1;

	// export const linkList = [
	// 	{	label: "Login",
	// 		href:"#"
	// 	},
	// 	{	label: "Home",
	// 		href:"./index.html"
	// 	},
    //     {
	// 		label: "Buy Fruit",
	// 		href:"#"
	// 	},
    //     {
	// 		label: "Trees",
	// 		href:"#"
	// 	}
		
	// ]

</script>
<!--Markup is here-->
<nav>
    <div id="navContainer">
        <ul id ="navList">
            <li><a href="/" on:click|preventDefault={() => (menu = 1)}>Login</a></li>
            <li><a href="/" on:click|preventDefault={() => (menu = 2)}>WishList</a></li>
            <li><a href="/" on:click|preventDefault={() => (menu = 3)}>Feedback List</a></li>

            <!-- {#each linkList as link}
                <li> <a href={link.href}>{link.label}</a></li>
            {/each} -->
        </ul>
    </div>
</nav>

{#if menu === 1}
    <Login />
{:else if menu === 2}
    <Wishlist />
{:else if menu === 3}
    <FeedbackList />
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