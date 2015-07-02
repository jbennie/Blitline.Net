using Newtonsoft.Json;
namespace Blitline.Net.Functions
{
    /// <summary>
    /// Simple noop. No function performed on image.
    /// </summary>
      [JsonObject(MemberSerialization.OptIn)]
    public class NoOpFunction : BlitlineFunction
    {
        public override string Name
        {
            get { return "no_op"; }
        }

        public override object Params { get { return new {}; } }
    }
}
