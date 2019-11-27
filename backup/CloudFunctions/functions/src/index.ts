import * as functions from 'firebase-functions';
import * as admin from 'firebase-admin';
import * as express from 'express';
import { db } from './init';

const cors = require('cors');

const app = express();

app.use(cors({ origine: true }))

app.get('/getUsers', (request, response) => {

    const snaps = await db.col
   
    const ref = db.collection() .ref('/CareToCash/Users/');

    ref.on("value", function (snapshot) {
        if (snapshot != null) {response.send(snapshot.val()); }
    }, function (errorObject: { code: string }) {
        console.log("The read failed: " + errorObject.code);
    });
});

export const appFunctions = functions.https.onRequest(app);






//admin.initializeApp(functions.config().firebase);

export const getUsers = functions.https.onRequest((request, response) => {

    const ref = admin.database().ref('/CareToCash/Users/');

    // Attach an asynchronous callback to read the data at our posts reference
    ref.on("value", function (snapshot) {
        if (snapshot != null) { response.set('Access-Control-Allow-Origin', '*'); response.send(snapshot.val()); }
    }, function (errorObject: {code:string}) {
        console.log("The read failed: " + errorObject.code);
    });

});


export const AddUser = functions.https.onRequest((request, response) => {

    var g = JSON.stringify(request.param);

    const ref = admin.database().ref('/CareToCash/Users/');
    ref.set(g);
    response.set('Access-Control-Allow-Origin', '*');
    response.send("ddd");
    // Attach an asynchronous callback to read the data at our posts reference
    return ref.set(g);


});

