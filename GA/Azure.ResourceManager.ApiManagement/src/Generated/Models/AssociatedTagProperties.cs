// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Contract defining the Tag property in the Tag Resource Contract. </summary>
    public partial class AssociatedTagProperties
    {
        /// <summary> Initializes a new instance of AssociatedTagProperties. </summary>
        internal AssociatedTagProperties()
        {
        }

        /// <summary> Initializes a new instance of AssociatedTagProperties. </summary>
        /// <param name="id"> Tag identifier. </param>
        /// <param name="name"> Tag Name. </param>
        internal AssociatedTagProperties(string id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary> Tag identifier. </summary>
        public string Id { get; }
        /// <summary> Tag Name. </summary>
        public string Name { get; }
    }
}