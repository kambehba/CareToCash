function LoginUser(email,password) {
    alert("email:" + email + " " + "password:" + password);
    firebase.auth().signInWithEmailAndPassword(email, password).then(() => { alert("SSS") });

}


function RegisterUser(email, password) {
    
    firebase.auth().createUserWithEmailAndPassword(email, password)
        .then(function (result) {
            alert("User Registered Successfully");
        }).catch(function (error) {
            alert(error);
        });

}

