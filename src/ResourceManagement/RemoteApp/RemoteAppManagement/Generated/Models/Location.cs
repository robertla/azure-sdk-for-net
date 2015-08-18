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
    /// The location a resource can be in.
    /// </summary>
    public partial class Location
    {
        /// <summary>
        /// The name of the location
        /// </summary>
        [JsonProperty(PropertyName = "locationName")]
        public string LocationName { get; set; }

        /// <summary>
        /// The display name of the location
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

    }
}
