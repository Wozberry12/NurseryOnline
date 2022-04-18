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
    var wishList2 = [];
    var wishList3 = [];
    var wishList4 = [];
    var account1 = new profile("marco", "marcopassword", wishList);
    var account2 = new profile("ben", "benpassword", wishList2);
    var account3 = new profile("will", "willpassword", wishList3);
    var account4 = new profile("pascucci", "giveusagoodscoreplz", wishList4);
    var localAccounts = [];
    //var loggedInProfile = [];
   var oldlocalAccounts = [account1, account2, account3, account4];
    var currentAccounts = JSON.parse(localStorage.getItem("Accounts"));
    var newAccountList = [];
    if(currentAccounts != null){
        for(let j = 0; j < currentAccounts.length; j++){
            newAccountList.push(currentAccounts[j]);
        }
    }
    else{
        newAccountList = oldlocalAccounts;
    }
    localStorage.setItem("Accounts", JSON.stringify(newAccountList));
    
    const handleLogin = (usernameLogin, passwordLogin) => {
        var loggedIn = false;
		var accountsList = JSON.parse(localStorage.getItem("Accounts"));
        for(let i = 0; i < accountsList.length; i++){
            if(accountsList[i].username == usernameLogin && accountsList[i].password == passwordLogin){
                
                sessionStorage.setItem("currentlyLogedIn", JSON.stringify(accountsList[i]));
                
                loggedIn = true;
            }
        }
        if(loggedIn === true){
            window.alert("You are Logged into " + usernameLogin);
        }
        else if(loggedIn == false){
            window.alert("Account " + usernameLogin + " is not found");
        }
	}
    const handleCreateAccount = (usernameLogin, passwordLogin) => {
        let storageAccounts = JSON.parse(localStorage.getItem("Accounts"));
        let profileWishList = [];
        let newProfile = new profile(usernameLogin, passwordLogin, profileWishList);
        storageAccounts.push(newProfile);
        localStorage.setItem("Accounts", JSON.stringify(storageAccounts));

    }
    const handleDeleteAccount = (usernameLogin, passwordLogin) => {
        let storageAccounts = JSON.parse(localStorage.getItem("Accounts"));
        for(let i = 0; i < storageAccounts.length; i++){
            if(storageAccounts[i].username == usernameLogin && storageAccounts[i].password == passwordLogin){
                storageAccounts.splice(i, 1);
            }
        }
        localStorage.setItem("Accounts", JSON.stringify(storageAccounts));
    }
    
</script>
<div class="titleImage">
    <img src="https://www.kindpng.com/picc/m/210-2105466_bonsai-drawing-transparent-bonsai-tree-png-png-download.png" alt="">
</div>
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

    <div class="loginButton">
        <button class="addWishList" on:click={() => handleCreateAccount(usernameLogin, passwordLogin)}>Create Account</button> 
        <button class="addWishlist" on:click={() => handleLogin(usernameLogin, passwordLogin)}>Login</button>
        <button class="addWishlist" on:click={() => handleDeleteAccount(usernameLogin, passwordLogin)}>Delete Account</button>
    </div>
</div>
<style>
    .titleImage{
        float: right;
        width: 30%;
        height: 30%;
    }
    .titleImage > img{
        width: 100%;
        height: 100%;
    }
</style>