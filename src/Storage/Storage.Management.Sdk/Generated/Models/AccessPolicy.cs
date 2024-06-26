// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using System.Linq;

    public partial class AccessPolicy
    {
        /// <summary>
        /// Initializes a new instance of the AccessPolicy class.
        /// </summary>
        public AccessPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccessPolicy class.
        /// </summary>

        /// <param name="startTime">Start time of the access policy
        /// </param>

        /// <param name="expiryTime">Expiry time of the access policy
        /// </param>

        /// <param name="permission">List of abbreviated permissions.
        /// </param>
        public AccessPolicy(System.DateTime? startTime = default(System.DateTime?), System.DateTime? expiryTime = default(System.DateTime?), string permission = default(string))

        {
            this.StartTime = startTime;
            this.ExpiryTime = expiryTime;
            this.Permission = permission;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets start time of the access policy
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime {get; set; }

        /// <summary>
        /// Gets or sets expiry time of the access policy
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "expiryTime")]
        public System.DateTime? ExpiryTime {get; set; }

        /// <summary>
        /// Gets or sets list of abbreviated permissions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "permission")]
        public string Permission {get; set; }
    }
}