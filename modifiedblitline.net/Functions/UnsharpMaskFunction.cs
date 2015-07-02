﻿using Newtonsoft.Json;
using System;

namespace Blitline.Net.Functions
{
    /// <summary>
    /// Sharpens an image
    /// </summary>
      [JsonObject(MemberSerialization.OptIn)]
    public class UnsharpMaskFunction : BlitlineFunction
    {
        public override string Name
        {
            get { return "unsharp_mask"; }
        }

        public override object Params
        {
            get
            {
                return new
                {
                    sigma = Sigma,
                    radius = Radius,
                    amount = Amount,
                    threshold = Threshold
                };
            }
        }

        public override void Validate()
        {
            if (Amount < 0 || Amount > 1.0m) throw new ArgumentException("Amount cannot be less than 0 and greater than 1.0", "Amount");
            if (Threshold < 0 || Threshold > 1.0m) throw new ArgumentException("Threshold cannot be less than 0 and greater than 1.0", "Threshold");
        }

        /// <summary>
        /// Gaussian operator (defaults to 1.0)
        /// </summary>
        public decimal Sigma { get; set; }

        /// <summary>
        /// Gaussian operator (defaults to 0.0)
        /// </summary>
        public decimal Radius { get; set; }

        /// <summary>
        /// The percentage of the blurred image to be added to the receiver, specified as a fraction between 0 and 1.0 (defaults to 1.0)
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// The threshold needed to apply the amount, specified as a fraction between 0 and 1.0 (defaults to 0.05)
        /// </summary>
        public decimal Threshold { get; set; }

	    public UnsharpMaskFunction()
        {
            Sigma = 1.0m;
            Amount = 1.0m;
            Threshold = 0.05m;
        }
    }
}
