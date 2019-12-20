

function LoginUser(email, password) {
    const promise = firebase.auth().signInWithEmailAndPassword(email, password).then(() => {

        alert("Signed-in");
        NavigateToMainPageFromJS();
       
    }).catch(function (error) { alert(error) });

}

//This Calls .Net Method in Login Component.
NavigateToMainPageFromJS = callBackReceiver => {
    callBackReceiver.invokeMethod('NavigateToMainPage');
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



