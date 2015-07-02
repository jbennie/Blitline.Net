using System;
using Newtonsoft.Json;

namespace Blitline.Net.Request
{

    public class Save
    {
        [JsonProperty("image_identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageIdentifier { get; set; }
        
        /// <summary>
        /// Quality for jpg compression(0-100)(optional: defaults to 75)
        /// </summary>
        [JsonProperty("quality", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quality { get; set; }
        
        [JsonProperty("s3_destination", NullValueHandling = NullValueHandling.Ignore)]
        public S3Destination S3Destination { get; set; }
        
        [JsonProperty("azure_destination", NullValueHandling = NullValueHandling.Ignore)]
        public AzureDestination AzureDestination { get; set; }
        
        [JsonProperty("ftp_destination", NullValueHandling = NullValueHandling.Ignore)]
        public FtpDestination FtpDestination { get; set; }
        
        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ExtensionConverter))]
        public Extension Extension { get; set; }

        [JsonProperty("interlace", NullValueHandling = NullValueHandling.Ignore)]
        public string Interlace { get; set; }
        
        [JsonProperty("png_quantize", NullValueHandling = NullValueHandling.Ignore)]
       // public int? PngQuantize { get; set; }
        public bool? PngQuantize { get; set; }
       
        /// <summary>
        /// This causes all metadata stored in the original image to be saved in the outputted image.(optional: defaults to false, so all metadata is removed by default)
        /// </summary>
        [JsonProperty("save_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public bool Save_metadata { get; set; }

 
       /// <summary>
        /// Keep any color profile associated with image.(optional: defaults to false for 'v' < 1.20)
        /// </summary>
        [JsonProperty("save_profiles", NullValueHandling = NullValueHandling.Ignore)]
        public bool Save_profiles{ get; set; }  // 

        public Save()
        {
           // Quality = 75;
        }

        public void Validate()
        {
            if(string.IsNullOrEmpty(ImageIdentifier)) throw new ArgumentNullException("ImageIdentifier", "Image identifier is required");

            if(GetCurrentSaveDestinationCounts() > 1) throw new NotSupportedException("Only one save destination is currently supported");

        }

        private int GetCurrentSaveDestinationCounts()
        {
            var count = 0;

            if (S3Destination != null) count++;
            if (AzureDestination != null) count++;
            if (FtpDestination != null) count++;

            return count;
        }
    }
}