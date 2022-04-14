<script>
    let usernameLogin;
    let passwordLogin;
    
    class profile{
        constructor(username, password, wishList){
            this.username = username;
            this.password = password;
            this.wishList = wishList;
        }
        getWishList(){
            return wishList;
        }
    }
    var wishList = [];
    var account1 = new profile("marco", "marcopassword", wishList);
    var account2 = new profile("ben", "benpassword", wishList);
    var localAccounts = [];
    var loggedInProfile = [];
    localAccounts = [account1, account2];
    localStorage.setItem("Accounts", JSON.stringify(localAccounts));

    const handleLogin = (usernameLogin, passwordLogin) => {
        var loggedIn = false;
		var accountsList = JSON.parse(localStorage.getItem("Accounts"));
        for(var i = 0; i < accountsList.length; i++){
            if(accountsList[i].username == usernameLogin && accountsList[i].password == passwordLogin){
                
                sessionStorage.setItem("currentlyLogedIn", JSON.stringify(accountsList[i]));
                
                loggedIn = true;
            }
        }
        if(loggedIn === true){
            window.alert("You are Logged in");
        }
        else if(loggedIn == false){
            window.alert("Account " + usernameLogin + " is not found");
        }
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
        <!-- <input type="submit" id="submit" value="Submit" onclick="login();"> -->
    </form>

    <div class="loginButton"
        ><button class="addWishlist" on:click={() => handleLogin(usernameLogin, passwordLogin)}>Login</button>
    </div>
</div>
