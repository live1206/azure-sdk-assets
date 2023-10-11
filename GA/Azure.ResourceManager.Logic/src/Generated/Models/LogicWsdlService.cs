// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The WSDL service. </summary>
    public partial class LogicWsdlService
    {
        /// <summary> Initializes a new instance of LogicWsdlService. </summary>
        internal LogicWsdlService()
        {
            EndpointQualifiedNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of LogicWsdlService. </summary>
        /// <param name="qualifiedName"> The qualified name. </param>
        /// <param name="endpointQualifiedNames"> The list of endpoints' qualified names. </param>
        internal LogicWsdlService(string qualifiedName, IReadOnlyList<string> endpointQualifiedNames)
        {
            QualifiedName = qualifiedName;
            EndpointQualifiedNames = endpointQualifiedNames;
        }

        /// <summary> The qualified name. </summary>
        public string QualifiedName { get; }
        /// <summary> The list of endpoints' qualified names. </summary>
        public IReadOnlyList<string> EndpointQualifiedNames { get; }
    }
}