// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// The information of an AutoApprovedPrivateLinkService.
    /// </summary>
    public partial class AutoApprovedPrivateLinkService
    {
        /// <summary>
        /// Initializes a new instance of the AutoApprovedPrivateLinkService class.
        /// </summary>
        public AutoApprovedPrivateLinkService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoApprovedPrivateLinkService class.
        /// </summary>

        /// <param name="privateLinkService">The id of the private link service resource.
        /// </param>
        public AutoApprovedPrivateLinkService(string privateLinkService = default(string))

        {
            this.PrivateLinkService = privateLinkService;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the id of the private link service resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "privateLinkService")]
        public string PrivateLinkService {get; set; }
    }
}