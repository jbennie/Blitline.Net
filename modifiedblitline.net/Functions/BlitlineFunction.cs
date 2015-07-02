using Blitline.Net.Request;
using Newtonsoft.Json;

namespace Blitline.Net.Functions
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class BlitlineFunction : Function
    {
        [JsonProperty("name")]
        public abstract string Name { get; }
        [JsonProperty("params")]
        public abstract dynamic @Params { get; }

        [JsonProperty("save", NullValueHandling = NullValueHandling.Ignore)]
        public Save Save { get; set; }

	    public virtual void Validate()
	    {
	    }
        
        public void AddFunction(BlitlineFunction function)
        {
            Functions.Add(function);
        }
    }
}