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
    /// The response for the get collection operation.
    /// </summary>
    public partial class Collection : Resource
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
        /// The collection provisioning state. Possible values for this
        /// property include: 'Failed', 'Succeeded', 'Cancelled',
        /// 'InProgress'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; set; }

        /// <summary>
        /// The collection name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string CollectionName { get; set; }

        /// <summary>
        /// The description of the collection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// The name of the gold image associated with this collection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.goldImageName")]
        public string GoldImageName { get; set; }

        /// <summary>
        /// The collection status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// The last operation error code on this collection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastErrorCode")]
        public string LastErrorCode { get; set; }

        /// <summary>
        /// The VNet name associated with this collection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetName")]
        public string VnetName { get; set; }

        /// <summary>
        /// The domain join details for this collection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.adInfo")]
        public ActiveDirectoryConfig AdInfo { get; set; }

        /// <summary>
        /// The plan name associated with this collection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.planName")]
        public string PlanName { get; set; }

        /// <summary>
        /// Optional customer defined RDP properties of the collection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customRdpProperty")]
        public string CustomRdpProperty { get; set; }

        /// <summary>
        /// A flag denoting if this collection is ready for publishing
        /// operations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.readyForPublishing")]
        public bool? ReadyForPublishing { get; set; }

        /// <summary>
        /// UTC Date time of the last modification of this collection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTimeUtc")]
        public DateTime? LastModifiedTimeUtc { get; set; }

        /// <summary>
        /// The collection mode. Possible values for this property include:
        /// 'Unassigned', 'Apps', 'Desktop'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.mode")]
        public CollectionMode? Mode { get; set; }

        /// <summary>
        /// The maximum number of concurrent users allowed for this collection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxSessions")]
        public int? MaxSessions { get; set; }

        /// <summary>
        /// The end-user session limit warning threshold.  Reaching or
        /// crossing this threshold will cause a capacity warning message to
        /// be shown in the management portal.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sessionWarningThreshold")]
        public int? SessionWarningThreshold { get; set; }

        /// <summary>
        /// If the template image for this collection includes Office this
        /// will specify the type. Possible values for this property include:
        /// 'None', 'OfficeSAL', 'Office365', 'Unknown'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.officeType")]
        public OfficeType? OfficeType { get; set; }

        /// <summary>
        /// Trial-only collections can be used only during the trial period of
        /// your subscription. When the trial expires or you activate your
        /// subscription, these collections will be permanently disabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trialOnly")]
        public bool? TrialOnly { get; set; }

        /// <summary>
        /// List of the DNS Servers.
        /// </summary>
        [JsonProperty(PropertyName = "properties.DnsServers")]
        public IList<string> DnsServers { get; set; }

        /// <summary>
        /// The subnet name of the customer created Azure VNet.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnetName")]
        public string SubnetName { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
