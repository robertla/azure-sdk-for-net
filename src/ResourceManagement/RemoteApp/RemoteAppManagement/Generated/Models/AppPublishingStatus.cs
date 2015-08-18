// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RemoteApp.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AppPublishingStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AppPublishingStatus
    {
        [EnumMember(Value = "Publishing")]
        Publishing,
        [EnumMember(Value = "Published")]
        Published,
        [EnumMember(Value = "Unpublishing")]
        Unpublishing,
        [EnumMember(Value = "Modifying")]
        Modifying,
        [EnumMember(Value = "Invalid")]
        Invalid
    }
}
