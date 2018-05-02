using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace invisible_recaptcha_webforms
{
    public class Utils
    {
        // Test keys -> https://developers.google.com/recaptcha/docs/faq
        public const string secretKey = "6LeIxAcTAAAAAGG-vFI1TnRWxMZNFuojJ4WifJWe";
        public static bool ValidateRecaptcha(string recaptchaUserResponse)
        {
            var result = false;
            if (!string.IsNullOrWhiteSpace(recaptchaUserResponse))
            {
                var userIpAddress = HttpContext.Current.Request.UserHostAddress;
                var url = string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}&remoteip={2}", secretKey, recaptchaUserResponse, userIpAddress);
                var client = new RestClient(url);
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var responseContent = response.Content;
                var recaptchaResponse = JsonConvert.DeserializeObject<RecaptchaResponse>(responseContent);
                if (recaptchaResponse.success)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}