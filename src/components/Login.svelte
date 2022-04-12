
<script>
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
    }
</script>

<div id="titleBar">
    <h1>Login to your Nursey Online Account Below</h1>
</div>
<div id="forUserInput">
    <form id="loginForm">
        <label for="username">Username</label>
        <input type="text" id="username" name="username">
        <label for="password">Password</label>
        <input type="text" id="password" name="password"><br>
        <input type="submit" id="submit" value="Submit" onclick="accountConfirm();">
    </form>
</div>
