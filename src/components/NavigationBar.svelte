<script>
    
	export const linkList = [
		
		{	label: "Logo",
			href:"#"
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
    .navContainer{
        padding-left: 20px;
        padding-right: 20px;
        margin:auto;
        box-sizing: border-box;
        align-items: center;
        height:100%;
        text-decoration: none;
    }
    .navList{
        text-decoration: none;
    }
    .navList li{
        width: 100%;
        justify-content: space-between;
        margin: 0;
        padding: 0 40px;
        text-decoration: none;
        list-style: none;
    }




</style>