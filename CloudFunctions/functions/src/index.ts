import * as functions from 'firebase-functions';
import * as admin from 'firebase-admin';
import * as express from 'express';
import { db } from './init';

const cors = require('cors');

const app = express();

app.use(cors({ origine: true }))

app.get('/getUsers', async (request, response) => {
   
   // const snaps = await db.collection('CareToCash-Users').doc('0').collection('Cares').get();

    const snaps = await db.collection('CareToCash-Users').get();
    
    const users: any[] = [];

    snaps.forEach(snap => users.push(snap.data()));


    response.status(200).json(users);
});

app.get('/getChargesById', async (request, response) => {

    // const snaps = await db.collection('CareToCash-Users').doc('0').collection('Cares').get();

    const snaps = await db.collection('Charges').where("id", "==" ,"request.params)").get();

    const charges: any[] = [];

    snaps.forEach(snap => charges.push(snap.data()));


    response.status(200).json(charges);
});

export const appFunctions = functions.https.onRequest(app);


export const getUsers = functions.https.onRequest((request, response) => {

    const ref = admin.database().ref('/CareToCash/Users/');

    // Attach an asynchronous callback to read the data at our posts reference
    ref.on("value", function (snapshot) {
        if (snapshot != null) { response.set('Access-Control-Allow-Origin', '*'); response.send(snapshot.val()); }
    }, function (errorObject: { code: string }) {
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

