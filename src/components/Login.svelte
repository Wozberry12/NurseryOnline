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
    var localAccounts = [account1, account2];
    localStorage.setItem("Accounts", JSON.stringify(localAccounts));
    
    var submitBTN = document.getElementById("submit");
    var loginFrom = document.getElementById("loginForm");
    function login(){
        var username = loginForm.username.value;
        var password = loginForm.username.value;
        for(var i = 0; i < localAccounts.length; i++){
            if(localAccounts[i].username == username && localAccounts[i].passowrd == password){
                localStorage.setItem("LoggedInUser", JSON.stringify(username));
            }
        }
        console.log(JSON.parse(localStorage.getItem("LoggedInUser")));   
    }
    const handleLogin = (usernameLogin, passwordLogin) => {
		var accountsList = localStorage.getItem("Accounts");
        sessionStorage.setItem("currentlyLogedIn", usernameLogin);
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
