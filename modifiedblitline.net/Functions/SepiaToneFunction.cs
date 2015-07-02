using Newtonsoft.Json;
namespace Blitline.Net.Functions
{
    /// <summary>
    /// Applies sepia filter
    /// </summary>
      [JsonObject(MemberSerialization.OptIn)]
    public class SepiaToneFunction : BlitlineFunction
    {
        public override string Name
        {
            get { return "sepia_tone"; }
        }

        public override object Params
        {
            get
            {
                return new
                {
                    threshold = Threshold
                };
            }
        }

        public int Threshold { get; set; }
    }
}
