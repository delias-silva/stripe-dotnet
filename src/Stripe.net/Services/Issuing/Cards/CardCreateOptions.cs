namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Spending rules that give you some control over how your cards can
        /// be used.
        /// </summary>
        [JsonProperty("authorization_controls")]
        public AuthorizationControlsOptions AuthorizationControls { get; set; }

        [Obsolete("This parameter does not exist and was added to the library incorrectly.")]
        [JsonProperty("billing")]
        public BillingOptions Billing { get; set; }

        /// <summary>
        /// The Cardholder object with which the card will be associated.
        /// </summary>
        [JsonProperty("cardholder")]
        public string Cardholder { get; set; }

        /// <summary>
        /// The currency for the card. This currently must be <c>usd</c>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A set of key-value pairs that you can attach to an object. It
        /// can be useful for storing additional information about the object
        /// in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The card this is meant to be a replacement for (if any).
        /// </summary>
        [JsonProperty("replacement_for")]
        public string ReplacementFor { get; set; }

        /// <summary>
        /// If <see cref="ReplacementFor"/> is specified, this should indicate why
        /// that card is being replaced.
        /// </summary>
        [JsonProperty("replacement_reason")]
        public string ReplacementReason { get; set; }

        /// <summary>
        /// The address where the card will be shipped.
        /// </summary>
        [JsonProperty("shipping")]
        public CardShippingOptions Shipping { get; set; }

        /// <summary>
        /// Whether authorizations can be approved on this card. Defaults to <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The type of card to issue. Possible values are <c>physical</c> or <c>virtual</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
