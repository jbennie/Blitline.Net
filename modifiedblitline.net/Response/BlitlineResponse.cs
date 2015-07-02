using System;
using System.Collections.Generic;

namespace Blitline.Net.Response
{
    public class BlitlineResponse
    {
        protected const string NewAmazonUri = "{0}://{1}.s3.amazonaws.com/{2}";
        public Results Results { get; set; }

        public virtual bool Failed { get { return !string.IsNullOrEmpty(Results.Error); } }

        public virtual void FixS3Urls(Dictionary<string, string> imageKeyBucketList)
        {
            foreach (var image in Results.Images)
            {
                var uri = new Uri(image.S3Url);
                var imageName = uri.Segments[uri.Segments.Length - 1];
                
                if (imageKeyBucketList.ContainsKey(imageName))
                {
                    var bucketName = imageKeyBucketList[imageName];
                    image.S3Url = string.Format(NewAmazonUri, uri.Scheme, bucketName, imageName);
                }
            }
        }
    }
}