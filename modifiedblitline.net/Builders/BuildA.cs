using System;
using Blitline.Net.Request;
using Blitline.Net.Request.Builders;

namespace Blitline.Net.Builders
{
    public static class BuildA
    {
		public static BlitlineRequest Request(Action<RequestBuilder> action)
		{
            BlitlineRequest r = new BlitlineRequest();    
			var requestBuilder = new RequestBuilder(r);
			action(requestBuilder);
			return requestBuilder.Build();
		}

    }
}