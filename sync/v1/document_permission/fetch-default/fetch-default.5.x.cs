// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Rest.Sync.V1.Service.Document;


class Program 
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        // DANGER! This is insecure. See http://twil.io/secure
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";

        TwilioClient.Init(accountSid, authToken);

        var documentPermission = DocumentPermissionResource.Fetch(
            pathServiceSid: "ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
            pathDocumentSid: "ETXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
            pathIdentity: "pathIdentity"
        );

        Console.WriteLine(documentPermission.ServiceSid);
    }
}
