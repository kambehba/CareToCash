function LoginUser(email,password) {
    alert("email:" + email + " " + "password:" + password);
    firebase.auth().signInWithEmailAndPassword(email, password).then(() => { alert("SSS") });

}


function RegisterUser(email, password) {
    //alert("email:" + email + " " + "password:" + password);
    //firebase.auth().createUserWithEmailAndPassword(email, password).catch (function(error) {
    //    // Handle Errors here.
    //   // var errorCode = error.code;
    //  //  var errorMessage = error.message;
    //    alert(error.message)
    //});



    firebase.auth().createUserWithEmailAndPassword(email, password)
        .then(function (result) {
            alert(result);
        }).catch(function (error) {
            alert(error);
        });

}

