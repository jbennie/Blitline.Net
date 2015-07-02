using Newtonsoft.Json;
namespace Blitline.Net.Functions
{
    /// <summary>
    /// Reduces noise in the image
    /// </summary>
      [JsonObject(MemberSerialization.OptIn)]
    public class EnhanceFunction : BlitlineFunction
    {
        public override string Name
        {
            get { return "enhance"; }
        }

        public override dynamic Params
        {
            get { return new { }; }
        }
    }
}