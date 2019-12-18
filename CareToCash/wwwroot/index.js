

function LoginUser(email, password) {
    const promise = firebase.auth().signInWithEmailAndPassword(email, password).then(() => {

        alert("Signed-in")
    }).catch(function (error) { alert(error) });

}


function RegisterUser(email, password) {
    
    firebase.auth().createUserWithEmailAndPassword(email, password)
        .then(function (result) {
            alert("User Registered Successfully");
        }).catch(function (error) {
            alert(error);
        });

}

firebase.auth().onAuthStateChanged(user => {

    if (user) {
        alert("logedinnn");

    }
    else { alert("dddddddd") };
});



