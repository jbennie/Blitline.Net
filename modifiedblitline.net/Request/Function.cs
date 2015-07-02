using System.Collections.Generic;
using Blitline.Net.Functions;
using Newtonsoft.Json;

namespace Blitline.Net.Request
{
    public class Function
    {
        [JsonProperty("functions", NullValueHandling=NullValueHandling.Ignore)]
        public List<BlitlineFunction> Functions { get; set; }

        /// <summary>
        /// allows the function list assigned to the object to be set to nul if not in use - this prevents empty function array in the json output. 
        /// </summary>
        public void WithEndFunctionChain(){

            if (Functions.Count>0){
                Functions = null; 
            }
        }

        public Function()
        {
            Functions = new List<BlitlineFunction>();
        }
    }
}