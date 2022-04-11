<script>
    
	export const linkList = [
		
		{	label: "Home",
			href:"./index.html"
		},
        {	label: "Login",
			href:"./loginPage.html"
		},
        {
			label: "Buy Fruit",
			href:"#"
		},
        {
			label: "Trees",
			href:"#"
		}
		
	]

</script>
<!--Markup is here-->
<nav>
    <div class ="navContainer">
        <ul class ="navList">
            {#each linkList as link}
                <li>
                    <a href={link.href}>{link.label}</a>
                </li>
            {/each}
        </ul>
    </div>
</nav>
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