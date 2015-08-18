// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RemoteApp.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Definition containing details of Start Menu applications.
    /// </summary>
    public partial class StartMenuApplication : Resource
    {
        /// <summary>
        /// The etag of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// The URL for requesting next page of resources.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// The command line arguments to launch the application.
        /// </summary>
        [JsonProperty(PropertyName = "properties.commandLineArguments")]
        public string CommandLineArguments { get; set; }

        /// <summary>
        /// The available map of icon PNG file URIs for different resolutions
        /// (e.g. 16x16, 32x32, 64x64). The key of the map is the first
        /// dimension of the PNG resolution.
        /// </summary>
        [JsonProperty(PropertyName = "properties.iconPngUris")]
        public IDictionary<string, string> IconPngUris { get; set; }

        /// <summary>
        /// The default URI to the application icon png file.
        /// </summary>
        [JsonProperty(PropertyName = "properties.iconUri")]
        public string IconUri { get; set; }

        /// <summary>
        /// The application name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string StartMenuApplicationName { get; set; }

        /// <summary>
        /// The start menu application id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.id")]
        public string StartMenuApplicationId { get; set; }

        /// <summary>
        /// The application image path on the destination machine specified
        /// with environment variables for the drive and known system path.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualPath")]
        public string VirtualPath { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
