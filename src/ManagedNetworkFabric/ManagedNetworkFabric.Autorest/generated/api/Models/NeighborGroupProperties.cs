// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Extensions;

    /// <summary>Neighbor Group Properties defines the properties of the resource.</summary>
    public partial class NeighborGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResource __annotationResource = new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.AnnotationResource();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPatchableProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPatchableProperties __neighborGroupPatchableProperties = new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.NeighborGroupPatchableProperties();

        /// <summary>Switch configuration description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public string Annotation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)__annotationResource).Annotation; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)__annotationResource).Annotation = value ?? null; }

        /// <summary>An array of destination IPv4 Addresses or IPv6 Addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupDestination Destination { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPatchablePropertiesInternal)__neighborGroupPatchableProperties).Destination; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPatchablePropertiesInternal)__neighborGroupPatchableProperties).Destination = value ?? null /* model class */; }

        /// <summary>Internal Acessors for NetworkTapId</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPropertiesInternal.NetworkTapId { get => this._networkTapId; set { {_networkTapId = value;} } }

        /// <summary>Internal Acessors for NetworkTapRuleId</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPropertiesInternal.NetworkTapRuleId { get => this._networkTapRuleId; set { {_networkTapRuleId = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="NetworkTapId" /> property.</summary>
        private System.Collections.Generic.List<string> _networkTapId;

        /// <summary>List of NetworkTap IDs where neighbor group is associated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> NetworkTapId { get => this._networkTapId; }

        /// <summary>Backing field for <see cref="NetworkTapRuleId" /> property.</summary>
        private System.Collections.Generic.List<string> _networkTapRuleId;

        /// <summary>List of Network Tap Rule IDs where neighbor group is associated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> NetworkTapRuleId { get => this._networkTapRuleId; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="NeighborGroupProperties" /> instance.</summary>
        public NeighborGroupProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__annotationResource), __annotationResource);
            await eventListener.AssertObjectIsValid(nameof(__annotationResource), __annotationResource);
            await eventListener.AssertNotNull(nameof(__neighborGroupPatchableProperties), __neighborGroupPatchableProperties);
            await eventListener.AssertObjectIsValid(nameof(__neighborGroupPatchableProperties), __neighborGroupPatchableProperties);
        }
    }
    /// Neighbor Group Properties defines the properties of the resource.
    public partial interface INeighborGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResource,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPatchableProperties
    {
        /// <summary>List of NetworkTap IDs where neighbor group is associated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of NetworkTap IDs where neighbor group is associated.",
        SerializedName = @"networkTapIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> NetworkTapId { get;  }
        /// <summary>List of Network Tap Rule IDs where neighbor group is associated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of Network Tap Rule IDs where neighbor group is associated.",
        SerializedName = @"networkTapRuleIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> NetworkTapRuleId { get;  }
        /// <summary>The provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("Accepted", "Succeeded", "Updating", "Deleting", "Failed", "Canceled")]
        string ProvisioningState { get;  }

    }
    /// Neighbor Group Properties defines the properties of the resource.
    internal partial interface INeighborGroupPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INeighborGroupPatchablePropertiesInternal
    {
        /// <summary>List of NetworkTap IDs where neighbor group is associated.</summary>
        System.Collections.Generic.List<string> NetworkTapId { get; set; }
        /// <summary>List of Network Tap Rule IDs where neighbor group is associated.</summary>
        System.Collections.Generic.List<string> NetworkTapRuleId { get; set; }
        /// <summary>The provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("Accepted", "Succeeded", "Updating", "Deleting", "Failed", "Canceled")]
        string ProvisioningState { get; set; }

    }
}