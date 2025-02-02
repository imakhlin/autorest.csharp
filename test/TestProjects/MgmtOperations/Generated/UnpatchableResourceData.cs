// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtOperations
{
    /// <summary> A class representing the UnpatchableResource data model. </summary>
    public partial class UnpatchableResourceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of UnpatchableResourceData. </summary>
        /// <param name="location"> The location. </param>
        public UnpatchableResourceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of UnpatchableResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="foo"> specifies the foo. </param>
        internal UnpatchableResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string foo) : base(id, name, resourceType, systemData, tags, location)
        {
            Foo = foo;
        }

        /// <summary> specifies the foo. </summary>
        public string Foo { get; set; }
    }
}
