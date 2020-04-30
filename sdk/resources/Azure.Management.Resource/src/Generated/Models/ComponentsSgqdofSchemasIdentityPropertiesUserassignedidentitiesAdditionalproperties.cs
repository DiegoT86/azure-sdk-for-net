// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Resource.Models
{
    /// <summary> The ComponentsSgqdofSchemasIdentityPropertiesUserassignedidentitiesAdditionalproperties. </summary>
    public partial class ComponentsSgqdofSchemasIdentityPropertiesUserassignedidentitiesAdditionalproperties
    {
        /// <summary> Initializes a new instance of ComponentsSgqdofSchemasIdentityPropertiesUserassignedidentitiesAdditionalproperties. </summary>
        public ComponentsSgqdofSchemasIdentityPropertiesUserassignedidentitiesAdditionalproperties()
        {
        }

        /// <summary> Initializes a new instance of ComponentsSgqdofSchemasIdentityPropertiesUserassignedidentitiesAdditionalproperties. </summary>
        /// <param name="principalId"> The principal id of user assigned identity. </param>
        /// <param name="clientId"> The client id of user assigned identity. </param>
        internal ComponentsSgqdofSchemasIdentityPropertiesUserassignedidentitiesAdditionalproperties(string principalId, string clientId)
        {
            PrincipalId = principalId;
            ClientId = clientId;
        }

        /// <summary> The principal id of user assigned identity. </summary>
        public string PrincipalId { get; }
        /// <summary> The client id of user assigned identity. </summary>
        public string ClientId { get; }
    }
}