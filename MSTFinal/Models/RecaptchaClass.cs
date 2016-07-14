using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace MSTFinal.Models
{
    public class RecaptchaClass
    {
        public static string Validate(string EncodedResponse)
        {
            var client = new System.Net.WebClient();

            string PrivateKey = "6Lee9SQTAAAAAMmGf-GQ_nX7GMelSepH__x4sSa8";

            var GoogleReply =
                client.DownloadString(
                    string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", PrivateKey,
                        EncodedResponse));

            var captchaResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<RecaptchaClass>(GoogleReply);

            return captchaResponse.Success;
        }

        [JsonProperty]
        private string Success
        {
            get { return m_Success; }
            set { m_Success = value; }
        }

        private string m_Success;

        [JsonProperty("error-codes")]
        public List<string> ErrorCodes { get; set; }
    }
}