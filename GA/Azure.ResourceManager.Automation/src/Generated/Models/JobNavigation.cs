// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Software update configuration machine run job navigation properties. </summary>
    internal partial class JobNavigation
    {
        /// <summary> Initializes a new instance of JobNavigation. </summary>
        internal JobNavigation()
        {
        }

        /// <summary> Initializes a new instance of JobNavigation. </summary>
        /// <param name="id"> Id of the job associated with the software update configuration run. </param>
        internal JobNavigation(Guid? id)
        {
            Id = id;
        }

        /// <summary> Id of the job associated with the software update configuration run. </summary>
        public Guid? Id { get; }
    }
}