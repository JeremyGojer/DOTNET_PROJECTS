using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio;
using SAL;

public class TwilioServices
{
    private string classotp;
    public bool VerifyOTP(string otp)
    {
        return otp.Equals("");
    }
    public string SendOTP(string contactnumber)
    {
        string str = "";
        Random rnd = new Random();
        int otp = rnd.Next(100000,1000000);
        // Authentication Settings For SMS //
        var accountSid = "AC3c5629d0e8bf423468b6f16213c27de7";
        var authToken = "16e8ba47b31755d4b275e0f735080729";
        TwilioClient.Init(accountSid, authToken);
        // Create a message here in the body 
        var message = MessageResource.Create(
        new PhoneNumber(contactnumber), // to 
        from: new PhoneNumber("+16072846210"), // from
        body: "Your OTP is "+otp // message content
        );
        Console.WriteLine(message.Sid);
        if(message.Sid != null){
            Console.WriteLine(otp);
            return otp+"";
        }
        return str;
    }
}