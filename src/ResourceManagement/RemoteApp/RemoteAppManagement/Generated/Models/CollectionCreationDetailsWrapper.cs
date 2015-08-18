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
    /// Details of collection creation operation results.
    /// </summary>
    public partial class CollectionCreationDetailsWrapper : Resource
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
        /// The collection's name
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string CollectionCreationDetailsWrapperName { get; set; }

        /// <summary>
        /// A description for the collection
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// The name of the template image for the collection
        /// </summary>
        [JsonProperty(PropertyName = "properties.templateImageName")]
        public string TemplateImageName { get; set; }

        /// <summary>
        /// The name of the Vnet for the collection
        /// </summary>
        [JsonProperty(PropertyName = "properties.vnetName")]
        public string VnetName { get; set; }

        /// <summary>
        /// The ID of the Vnet for the collection
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkId")]
        public string VirtualNetworkId { get; set; }

        /// <summary>
        /// The account subscriptionId
        /// </summary>
        [JsonProperty(PropertyName = "properties.adInfo")]
        public ActiveDirectoryConfig AdInfo { get; set; }

        /// <summary>
        /// The plan name associated with this collection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingPlanName")]
        public string BillingPlanName { get; set; }

        /// <summary>
        /// Optional customer-defined RDP properties of the collection.
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
        /// The collection mode. Possible values for this property include:
        /// 'Unassigned', 'Apps', 'Desktop'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.mode")]
        public CollectionMode? Mode { get; set; }

        /// <summary>
        /// The amount of time to wait, in minutes, before forcing logoff.
        /// </summary>
        [JsonProperty(PropertyName = "properties.waitBeforeShutdownInMinutes")]
        public int? WaitBeforeShutdownInMinutes { get; set; }

        /// <summary>
        /// The home region for the account
        /// </summary>
        [JsonProperty(PropertyName = "properties.region")]
        public string Region { get; set; }

        /// <summary>
        /// A list of details of the published applications
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishedApplications")]
        public ApplicationDetailsList PublishedApplications { get; set; }

        /// <summary>
        /// A list of allowed security principals
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowedPrincipals")]
        public SecurityPrincipalList AllowedPrincipals { get; set; }

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
        /// True if the collection is domain joined, false otherwise
        /// </summary>
        [JsonProperty(PropertyName = "properties.notDomainJoined")]
        public bool? NotDomainJoined { get; set; }

        /// <summary>
        /// The name of the resource group the collection is in
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGroupName")]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// A GUID for the response
        /// </summary>
        [JsonProperty(PropertyName = "properties.eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
