using System;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Twilio.Jwt.AccessToken;

namespace EbossTwilio.Controllers;

public class TokenController : Controller
{
    private readonly IConfiguration configuration;
    public TokenController(IConfiguration configuration)
    {
        this.configuration = configuration;
    }


    // GET: Token/Generate
    public string Generate(string page)
    {
        string twilioAccountSid = configuration["TWILIO_ACCOUNT_SID"];
        string twilioApiKey = configuration["TWILIO_API_KEY_SID"];
        string twilioApiSecret = configuration["TWILIO_API_KEY_SECRET"];
        string twiMLApplicationSid = configuration["TWIML_APP_SID"];

        var grants = new HashSet<IGrant>();
        // Create a Voice grant for this token
        grants.Add(new VoiceGrant
        {
            OutgoingApplicationSid = twiMLApplicationSid,
            IncomingAllow = true
        });

        // Create an Access Token generator
        var token = new Token(
            twilioAccountSid,
            twilioApiKey,
            twilioApiSecret,
            // identity will be used as the client name for incoming dials
            identity: "blazor_client",
            grants: grants
        );

        return token.ToJwt();
    }


}

