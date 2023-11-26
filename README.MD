# Twilio Voice Integration in ASP.NET Application

## Overview

This ASP.NET application demonstrates the integration of Twilio for handling voice calls. The application includes controllers for managing calls, a homepage, and generating Twilio access tokens.

### Controllers

1. **CallController.cs**
    - Handles Twilio calls and connections.
    - Includes a method to connect to a specified phone number or a predefined support agent.

2. **HomeController.cs**
    - The default controller managing the main views of the application.

3. **TokenController.cs**
    - Generates Twilio access tokens with the necessary grants for voice capabilities.

## Configuration

Ensure that your `appsettings.json` file includes the necessary Twilio configuration settings:

```json
{
   "Logging": {
      "LogLevel": {
         "Default": "Information",
         "Microsoft.AspNetCore": "Warning"
      }
   },
   "TWIML_APP_SID": "your_twiml_app_sid",
   "TWILIO_ACCOUNT_SID": "your_twilio_account_sid",
   "TEST_TWILIO_ACCOUNT_SID": "your_test_twilio_account_sid",
   "TEST_TWILIO_AUTH_TOKEN": "your_test_twilio_auth_token",
   "TWILIO_API_KEY_SID": "your_twilio_api_key_sid",
   "TWILIO_API_KEY_SECRET": "your_twilio_api_key_secret",
   "TWILIO_PHONE_NO": "your_twilio_phone_number"
}
```
# Client-Side Script: browser-calls.js

The script handles Twilio Client configuration and provides functions for initiating, answering, and ending calls.

## Usage

1. Include the Twilio JavaScript library in your HTML file.
2. Ensure the server-side token generation endpoint is correctly configured.
3. Include the `browser-calls.js` script in your HTML file.
4. Call functions like `callCustomer(phoneNumber)`, `callSupport()`, and `hangUp()` based on your application's logic.

## Dependencies

- Twilio.AspNet.Core
- Twilio.TwiML
- Twilio.Jwt.AccessToken
- Twilio JavaScript library

## Getting Started

1. Clone the repository.
2. Update the `appsettings.json` file with your Twilio credentials.
3. Build and run the project.
4. Feel free to customize this application based on your specific requirements or integrate it into your ASP.NET project for Twilio-powered voice communication.
