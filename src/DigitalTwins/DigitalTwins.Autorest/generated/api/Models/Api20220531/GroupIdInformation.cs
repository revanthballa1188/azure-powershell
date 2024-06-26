// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    /// <summary>The group information for creating a private endpoint on Digital Twin.</summary>
    public partial class GroupIdInformation :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IGroupIdInformation,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IGroupIdInformationInternal
    {

        /// <summary>The group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.FormatTable(Index = 0)]
        public string GroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IGroupIdInformationPropertiesInternal)Property).GroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IGroupIdInformationPropertiesInternal)Property).GroupId = value ?? null; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.DoNotFormat]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IGroupIdInformationInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IGroupIdInformationProperties Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IGroupIdInformationInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.GroupIdInformationProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IGroupIdInformationInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.FormatTable(Index = 1)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IGroupIdInformationProperties _property;

        /// <summary>The group information properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IGroupIdInformationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.GroupIdInformationProperties()); set => this._property = value; }

        /// <summary>The required members for a specific group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.DoNotFormat]
        public string[] RequiredMember { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IGroupIdInformationPropertiesInternal)Property).RequiredMember; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IGroupIdInformationPropertiesInternal)Property).RequiredMember = value ?? null /* arrayOf */; }

        /// <summary>The required DNS zones for a specific group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.DoNotFormat]
        public string[] RequiredZoneName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IGroupIdInformationPropertiesInternal)Property).RequiredZoneName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IGroupIdInformationPropertiesInternal)Property).RequiredZoneName = value ?? null /* arrayOf */; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.FormatTable(Index = 2)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.DoNotFormat]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="GroupIdInformation" /> instance.</summary>
        public GroupIdInformation()
        {

        }
    }
    /// The group information for creating a private endpoint on Digital Twin.
    public partial interface IGroupIdInformation :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable
    {
        /// <summary>The group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The group id.",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get; set; }
        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The required members for a specific group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The required members for a specific group id.",
        SerializedName = @"requiredMembers",
        PossibleTypes = new [] { typeof(string) })]
        string[] RequiredMember { get; set; }
        /// <summary>The required DNS zones for a specific group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The required DNS zones for a specific group id.",
        SerializedName = @"requiredZoneNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] RequiredZoneName { get; set; }
        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// The group information for creating a private endpoint on Digital Twin.
    internal partial interface IGroupIdInformationInternal

    {
        /// <summary>The group id.</summary>
        string GroupId { get; set; }
        /// <summary>The resource identifier.</summary>
        string Id { get; set; }
        /// <summary>The resource name.</summary>
        string Name { get; set; }
        /// <summary>The group information properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.Api20220531.IGroupIdInformationProperties Property { get; set; }
        /// <summary>The required members for a specific group id.</summary>
        string[] RequiredMember { get; set; }
        /// <summary>The required DNS zones for a specific group id.</summary>
        string[] RequiredZoneName { get; set; }
        /// <summary>The resource type.</summary>
        string Type { get; set; }

    }
}