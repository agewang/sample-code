// Download the helper library from https://www.twilio.com/docs/node/install
// Your Account Sid and Auth Token from twilio.com/console
// DANGER! This is insecure. See http://twil.io/secure
const accountSid = 'ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX';
const authToken = 'your_auth_token';
const client = require('twilio')(accountSid, authToken);

client.incomingPhoneNumbers('PNXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX')
      .assignedAddOns
      .create({installedAddOnSid: 'XEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX'})
      .then(assigned_add_on => console.log(assigned_add_on.sid));
