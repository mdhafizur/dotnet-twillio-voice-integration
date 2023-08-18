

using Twilio.AspNet.Core; // or .Mvc for .NET Framework
using Twilio.TwiML;
using Twilio.TwiML.Voice;
using Microsoft.Extensions.Configuration;


namespace EbossTwilio.Controllers;

public class CallController : TwilioController
{

    private readonly IConfiguration configuration;
    public CallController(IConfiguration configuration)
    {
        this.configuration = configuration;
    }


    // POST Call/Connect
    public TwiMLResult Connect(string phoneNumber)
    {
        string twiMLApplicationSid = configuration["TWIML_APP_SID"];
        var response = new VoiceResponse();

        var dial = new Dial(callerId: configuration["TWILIO_PHONE_NO"]);
        if (phoneNumber != null)
        {
            dial.Number(phoneNumber);
        }
        else
        {
            dial.Client("support_agent");
        }
        response.Append(dial);

        return TwiML(response);
    }
}
