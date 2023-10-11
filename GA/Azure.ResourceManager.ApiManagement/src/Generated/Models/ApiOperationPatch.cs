// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> API Operation Update Contract details. </summary>
    public partial class ApiOperationPatch
    {
        /// <summary> Initializes a new instance of ApiOperationPatch. </summary>
        public ApiOperationPatch()
        {
            TemplateParameters = new ChangeTrackingList<ParameterContract>();
            Responses = new ChangeTrackingList<ResponseContract>();
        }

        /// <summary> Collection of URL template parameters. </summary>
        public IList<ParameterContract> TemplateParameters { get; }
        /// <summary> Description of the operation. May include HTML formatting tags. </summary>
        public string Description { get; set; }
        /// <summary> An entity containing request details. </summary>
        public RequestContract Request { get; set; }
        /// <summary> Array of Operation responses. </summary>
        public IList<ResponseContract> Responses { get; }
        /// <summary> Operation Policies. </summary>
        public string Policies { get; set; }
        /// <summary> Operation Name. </summary>
        public string DisplayName { get; set; }
        /// <summary> A Valid HTTP Operation Method. Typical Http Methods like GET, PUT, POST but not limited by only them. </summary>
        public string Method { get; set; }
        /// <summary> Relative URL template identifying the target resource for this operation. May include parameters. Example: /customers/{cid}/orders/{oid}/?date={date}. </summary>
        public string UriTemplate { get; set; }
    }
}