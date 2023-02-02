using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

// Authentication Settings For SMS //
var accountSid = "AC3c5629d0e8bf423468b6f16213c27de7";
var authToken = "16e8ba47b31755d4b275e0f735080729";
TwilioClient.Init(accountSid, authToken);
// Create a message here in the body 
var message = MessageResource.Create(
new PhoneNumber("+917019294131"), // to 
from: new PhoneNumber("+16072846210"), // from
body: "Hello World!" // message content
);
Console.WriteLine(message.Sid);



