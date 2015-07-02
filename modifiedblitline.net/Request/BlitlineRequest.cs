using System;
using Blitline.Net.Functions;
using Newtonsoft.Json;

namespace Blitline.Net.Request
{
    [JsonObject(MemberSerialization.OptIn)]
    public class BlitlineRequest : Function
    {
        [JsonProperty("application_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }
  
        [JsonProperty("src", NullValueHandling = NullValueHandling.Ignore)]        
        public string SourceImage { get; set; }

        [JsonProperty("v", NullValueHandling = NullValueHandling.Ignore)]        
        public Decimal ApiVersion { get; set; }

        [JsonProperty("postback_url", NullValueHandling = NullValueHandling.Ignore)]        
        public string PostbackUrl { get; set; }
        
        [JsonProperty("hash", NullValueHandling = NullValueHandling.Ignore)]
        public Hash? Hash { get; set; }

        [JsonProperty("suppress_auto_orient", NullValueHandling = NullValueHandling.Ignore)]        
        public bool? SuppressAutoOrient { get; set; }

      
        [JsonProperty("wait_for_s3", NullValueHandling = NullValueHandling.Ignore)]        
        public bool? WaitForS3 { get; set; }

        [JsonProperty("content_type_json", NullValueHandling = NullValueHandling.Ignore)]        
        public bool? ContentTypeJson { get; set; }

        [JsonProperty("postback_headers", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic ContentHeaders { get; set; }

        [JsonProperty("extended_metadata", NullValueHandling = NullValueHandling.Ignore)]        
        public bool? ExtendedMetaData { get; set; }

        [JsonProperty("src_type", NullValueHandling = NullValueHandling.Ignore)]        
        public dynamic SourceType { get; set; }

        [JsonProperty("src_data", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic SourceData { get; set; }

        [JsonProperty("long_running", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LongRunning { get; set; }

        /// <summary>
        /// Blitline returns an image url such as http://s3.amazonaws.com/gdoubleu-test-photos/annotate-default.png
        /// This generally throws an error when accessing the image, with a PermanentRedirect error stating
        /// that the endpoint is incorrect and should be gdoubleu-test-photos.s3.amazonaws.com resulting in an image url of
        /// http://gdoubleu-test-photos.s3.amazonaws.com/annotate-default.png (this is http://bucketname/s3key.xxx)
        /// Enabling this will automatically convert all response urls to the above format
        /// </summary>
        public bool FixS3ImageUrl { get; set; }
        
        public void AddFunction(BlitlineFunction function)
        {
            Functions.Add(function);
        }


        //public BlitlineRequest(string applicationId, string sourceUrl, Decimal version = Blitline.Net.BlitlineApi.api_version)
        //{
        //    ApplicationId = applicationId;
        //    SourceImage = sourceUrl;
        //    ApiVersion = version; 
        //}

        public void Validate()
        {
            if(string.IsNullOrEmpty(ApplicationId)) throw new ArgumentNullException("ApplicationId is required", "ApplicationId");
            if(string.IsNullOrEmpty(SourceImage)) throw new ArgumentNullException("SourceImage is required", "SourceImage");
            if (Functions.Count == 0) throw new ArgumentException("1 or more function required", "Functions");
        }
    }
}