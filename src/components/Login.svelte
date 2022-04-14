<script>
    let usernameLogin;
    let passwordLogin;
    class profile{
        constructor(username, password){
            this.username;
            this.password;
        }
    }
    var account1 = new profile("marco", "marcopassword");
    var account2 = new profile("ben", "benpassword");
    var localAccounts = [account1, account2];
    localStorage.setItem("Accounts", JSON.stringify(localAccounts));
    function accountConfirm(){
        var accounts = localStorage.getItem("Accounts");
        for(var i = 0; i < accounts.length; i++){
            if(document.forms["loginForm"]["username"].value == accounts[i].username && document.forms["loginForm"]["passowrd"].value == accounts[i].passowrd){
                localStorage.setItem("LoggedInUser", JSON.stringify(accounts[i].username));
            }
        }
        console.log(JSON.parse(localStorage.getItem("LoggedInUser")));
    }

    const handleLogin = () => {
		// {#if }

        // {/if}
	}
</script>

<div id="titleBar">
    <h1>Login to your Nursey Online Account Below</h1>
</div>
<div id="forUserInput">
    <form id="loginForm">
        <label for="username">Username</label>
        <input type="text" id="username" name="username" bind:value={usernameLogin}>
        <label for="password">Password</label>
        <input type="text" id="password" name="password" bind:value={passwordLogin}><br>
    </form>

    <div class="loginButton"
        ><button class="addWishlist" on:click={() => handleLogin()}>Login</button>
    </div>
</div>
