using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {

            const string accountSid = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            const string authToken = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

            TwilioClient.Init(accountSid, authToken);

            string[] phoneNumbers = new string[] { "+1973XXXXXXX" };
            int arrayLength = phoneNumbers.Length;


            try
            {
                for (int i = 0; i <= arrayLength; i++)
                {
                    var message = MessageResource.Create
                    (
                        body: ("The SMS bot is now out of Beta!" +
                        "\nThis message has been sent to " + arrayLength + " people.\n" +
                        "Please save this phone number in your phone.🥳"),
                        from: new Twilio.Types.PhoneNumber("+1973XXXXXXX"),
                        to: new Twilio.Types.PhoneNumber(phoneNumbers[i])
                    );
                }

                Console.WriteLine("All Text Messages have been sent!");

            }

            catch (Exception e)
            {
                Console.WriteLine("\nThere was an error");
                Console.WriteLine("But all texts have been sent out to: ");
                foreach (var item in phoneNumbers)
                {
                    Console.WriteLine(item.ToString());
                }

            }
        }
    }
}
