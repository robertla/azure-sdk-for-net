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
    /// The application details.
    /// </summary>
    public partial class ApplicationDetails
    {
        /// <summary>
        /// The application name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Path to the application.  The path should reference default
        /// operating system environment variables such as %ProgramFiles%,
        /// %ProgramFiles(x86)%, %SystemRoot%, etc. where possible.  For
        /// example, use '%SystemRoot%\\\\notepad.exe' rather than
        /// 'C:\\\\Windows\\\\notepad.exe'.
        /// </summary>
        [JsonProperty(PropertyName = "virtualPath")]
        public string VirtualPath { get; set; }

        /// <summary>
        /// A short unique name for the application.
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        public string Alias { get; set; }

        /// <summary>
        /// A flag to denote if the application will be available to end users.
        /// </summary>
        [JsonProperty(PropertyName = "availableToUsers")]
        public bool? AvailableToUsers { get; set; }

        /// <summary>
        /// Optional command-line arguments to pass to the application.
        /// </summary>
        [JsonProperty(PropertyName = "commandLineArguments")]
        public string CommandLineArguments { get; set; }

        /// <summary>
        /// The URI for the application's default icon PNG file.
        /// </summary>
        [JsonProperty(PropertyName = "iconUri")]
        public string IconUri { get; set; }

        /// <summary>
        /// The application status. Possible values for this property include:
        /// 'Publishing', 'Published', 'Unpublishing', 'Modifying', 'Invalid'.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public AppPublishingStatus? Status { get; set; }

        /// <summary>
        /// The available map of icon PNG file URIs for different resolutions
        /// (e.g. 16x16, 32x32, 64x64). The key of the map is the first
        /// dimension of the PNG resolution.
        /// </summary>
        [JsonProperty(PropertyName = "iconPngUris")]
        public IDictionary<string, string> IconPngUris { get; set; }

    }
}
