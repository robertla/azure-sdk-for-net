// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.RemoteApp.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Contains details of a billing plan.
    /// </summary>
    public partial class BillingPlan
    {
        /// <summary>
        /// Unique identifier of billing plan.
        /// </summary>
        [JsonProperty(PropertyName = "planId")]
        public string PlanId { get; set; }

        /// <summary>
        /// Short name of billing plan.
        /// </summary>
        [JsonProperty(PropertyName = "planName")]
        public string PlanName { get; set; }

        /// <summary>
        /// Associated add-ons.
        /// </summary>
        [JsonProperty(PropertyName = "addOns")]
        public string AddOns { get; set; }

        /// <summary>
        /// Computing cores per user.
        /// </summary>
        [JsonProperty(PropertyName = "coresPerUser")]
        public double? CoresPerUser { get; set; }

        /// <summary>
        /// Minimum number of user to bill.
        /// </summary>
        [JsonProperty(PropertyName = "minimumBilledUserCount")]
        public int? MinimumBilledUserCount { get; set; }

    }
}
