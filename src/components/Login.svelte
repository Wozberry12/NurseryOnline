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

</script>

<div id="titleBar">
    <h1>Login to your Nursey Online Account Below</h1>
</div>
<div id="forUserInput">
    <form id="loginForm">
        <label for="username">Username</label>
        <input type="text" id="username" name="username" bind:value={usernameLogin}>
        <label for="password">Password</label>
        <input type="text" id="password" name="password"><br>
        <input type="submit" id="submit" value="Submit" onclick="login();">
    </form>

    <div class="loginButton"
        ><button class="addWishlist" on:click={() => handleLogin()}>Login</button>
    </div>
</div>
