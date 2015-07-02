using System;
using System.Collections.Generic;
using Blitline.Net.Builders;

namespace Blitline.Net.Request.Builders
{
    public class RequestBuilder : Builder<BlitlineRequest>
    {
        readonly BlitlineRequest _request;

        public RequestBuilder(BlitlineRequest request)
        {
            _request = request; 
        }

        public RequestBuilder WithApplicationId(string id)
        {
            _request.ApplicationId = id;
            return this;
        }

        /// <summary>
        /// the api version - defaults to 1.22 if not provided. 
        /// </summary>
        /// <param name="apiv"></param>
        /// <returns></returns>
        public RequestBuilder WithVersionApi(decimal apiv = Blitline.Net.BlitlineApi.api_version)
        {
            _request.ApiVersion = apiv;
            return this;
        }

        public RequestBuilder WithSourceImageUri(Uri uri)
        {
            _request.SourceImage = uri.AbsoluteUri;
            return this;
        }

        public RequestBuilder FixS3ImageUrl(bool yn = false)  // false because we are using azure. 
        {
            _request.FixS3ImageUrl = yn;
            return this;
        }

        public RequestBuilder WaitForS3(bool? yn = false)
        {
            _request.WaitForS3 = yn;
            return this;
        }

        public RequestBuilder ContentTypeAsJson(bool? yn = true)
        {
            _request.ContentTypeJson = yn;
            return this;
        }

        //public RequestBuilder ContentJsonKVHeader(List<KeyValuePair<string, string>> headerkvpairs)
        //{

        //    string jsoncontent = "";

        //    foreach (KeyValuePair<string, string> i in headerkvpairs) {

        //        jsoncontent += '"' + i.Key + '"' + ":" + '"' + i.Value + '"';             
        //    }
        //    string json = "{" + jsoncontent +"}"; 
        //    this wont wok as is - the object sent back need to be correctly serialisable, a string will be quoted. and a list will be an array - an object is expected.  
        //    _request.ContentHeaders = json;
        //    return this;
        //}

        public RequestBuilder WithPostbackUri(Uri posbackUri)
        {
            _request.PostbackUrl = posbackUri.AbsoluteUri;
            return this;
        }

        public RequestBuilder WithExtendedMetaData(bool? yn = true)
        {
            _request.ExtendedMetaData = yn;
            return this;
        }

        public RequestBuilder SuppressAutoOrientation(bool? yn = true)
        {
            _request.SuppressAutoOrient = yn;
            return this;
        }

        public RequestBuilder WithHash(Hash hash)
        {
            _request.Hash = hash;
            return this;
        }


        public RequestBuilder WithIsLongRunning(bool? yn = null)
        {
            _request.LongRunning = yn;
            return this;
        }

        public RequestBuilder WithSRGBColourspace()
        {
            _request.SourceData = new {colorspace = "srgb"};
            return this;
        }

        public RequestBuilder WithRGBColourspace()
        {
            _request.SourceData = new { colorspace = "rgb" };
            return this;
        }
        public RequestBuilder WithCYMKColourspace()
        {
            _request.SourceData = new { colorspace = "cymk" };
            return this;
        }


        public RequestBuilder SourceIsImage()
        {
            _request.SourceType = "image";
            return this;
        }


        public RequestBuilder SourceIsScreenshot()
        {
            _request.SourceType = "screen_shot_url";
            return this;
        }

        public RequestBuilder SourceIsMultipageDocument()
        {
            _request.SourceType = "multi_page";
            return this;
        }

        public RequestBuilder SourceIsMultipageDocument(IList<int> pages)
        {
            _request.SourceType = new MultiPageSourceType {Pages = pages};
            return this;
        }

        protected override BlitlineRequest BuildImp
        {
            get { return _request; }
        }

        internal override BlitlineRequest Build()
        {
            BlitlineRequest o = base.Build();
            o.Validate();
            return o;
        }

        
    }
}