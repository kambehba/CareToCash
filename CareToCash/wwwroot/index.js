

function LoginUser(email, password,dotNetReference) {
    const promise = firebase.auth().signInWithEmailAndPassword(email, password).then(() => {

        alert("You Successfully Signed-in!");
        dotNetReference.invokeMethod('NavigateToMainPage');
       
    }).catch(function (error) { alert("2222" + error) });

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
        

    }
    else { };
});



