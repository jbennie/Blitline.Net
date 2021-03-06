Blitline.Net
============

A simple .net wrapper for the [Blitline API](http://www.blitline.com)

Usage - Simple
------------

```
using Blitline.Net.Builders;
using Blitline.Net.Request;

namespace Blitline.Net.Test
{
    public class Test
    {
        public void BuildRequest()
        {
            var response = BuildA.Request(r => r
                .WithApplicationId("123")
                .WithSourceImageUri(new Uri("http://foo.bar.gif"))
                .Crop(f => 
					f.WithDimensions(1,2,3,4)
					.WithGravity(Gravity.NorthEastGravity)
					.PreserveAspectIfSmaller()
				))
                .Send();
        }
        
        public async void BuildRequestAsync()
        {
            var response = BuildA.Request(r => r
                .WithApplicationId("123")
                .WithSourceImageUri(new Uri("http://foo.bar.gif"))
                .Crop(f => 
					f.WithDimensions(1,2,3,4)
					.WithGravity(Gravity.NorthEastGravity)
					.PreserveAspectIfSmaller()
				))
                .SendAsync();
        }
    }
}
```

Usage - Multiple Functions
-------------
```
using Blitline.Net.Builders;
using Blitline.Net.Request;

namespace Blitline.Net.Test
{
    public class Test
    {
        public void BuildRequest()
        {
            var response = BuildA.Request(r => 
				r.WithApplicationId("123")
				.WithSourceImageUri(new Uri("http://foo.bar.gif"))
				.Crop(c => 
				    c.WithDimensions(1, 2, 3, 4)
				    .WithGravity(Gravity.NorthEastGravity))
				.Watermark(w => 
				    w.WithText("Watermarked")))
				.Send ();
        }
        
        public aysnc void BuildRequestAsync()
        {
            var response = BuildA.Request(r => 
				r.WithApplicationId("123")
				.WithSourceImageUri(new Uri("http://foo.bar.gif"))
				.Crop(c => 
				    c.WithDimensions(1, 2, 3, 4)
				    .WithGravity(Gravity.NorthEastGravity))
				.Watermark(w => 
				    w.WithText("Watermarked")))
				.SendAsync();
        }
    }
}
```

Released under the Simple Public License (SimPL 2.0): http://opensource.org/licenses/SimPL-2.0
