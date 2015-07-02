using System;
using Newtonsoft.Json;

namespace Blitline.Net.Request
{
    public class AzureDestination
    {
        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        [JsonProperty("shared_access_signature")]
        public string SharedAccessSignature { get; set; }

        /// <summary>
        ///   If your output key does not contain a file extension(ie. png, jpg, etc), you can force the output file type to be a particular type. (optional: 1 time) Without an extension, default type is JPG.
        /// </summary>
        [JsonProperty("force_type", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ExtensionConverter))]
        public Extension ForceType { get; set; }

     
        public void Validate()
        {
            if(string.IsNullOrEmpty(AccountName)) throw new ArgumentNullException("AccountName", "AccountName is required");
            if (string.IsNullOrEmpty(SharedAccessSignature)) throw new ArgumentNullException("SharedAccessSignature", "SharedAccessSignature is required");
        }
    }
}