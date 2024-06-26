// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// A list of integration runtime status.
    /// </summary>
    public partial class IntegrationRuntimeStatusListResponse
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeStatusListResponse class.
        /// </summary>
        public IntegrationRuntimeStatusListResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationRuntimeStatusListResponse class.
        /// </summary>

        /// <param name="value">List of integration runtime status.
        /// </param>

        /// <param name="nextLink">The link to the next page of results, if any remaining results exist.
        /// </param>
        public IntegrationRuntimeStatusListResponse(System.Collections.Generic.IList<IntegrationRuntimeStatusResponse> value, string nextLink = default(string))

        {
            this.Value = value;
            this.NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets list of integration runtime status.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<IntegrationRuntimeStatusResponse> Value {get; set; }

        /// <summary>
        /// Gets or sets the link to the next page of results, if any remaining results
        /// exist.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Value == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Value");
            }
            if (this.Value != null)
            {
                foreach (var element in this.Value)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }

        }
    }
}