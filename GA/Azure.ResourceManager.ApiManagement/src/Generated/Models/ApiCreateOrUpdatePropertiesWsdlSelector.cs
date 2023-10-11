// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Criteria to limit import of WSDL to a subset of the document. </summary>
    public partial class ApiCreateOrUpdatePropertiesWsdlSelector
    {
        /// <summary> Initializes a new instance of ApiCreateOrUpdatePropertiesWsdlSelector. </summary>
        public ApiCreateOrUpdatePropertiesWsdlSelector()
        {
        }

        /// <summary> Initializes a new instance of ApiCreateOrUpdatePropertiesWsdlSelector. </summary>
        /// <param name="wsdlServiceName"> Name of service to import from WSDL. </param>
        /// <param name="wsdlEndpointName"> Name of endpoint(port) to import from WSDL. </param>
        internal ApiCreateOrUpdatePropertiesWsdlSelector(string wsdlServiceName, string wsdlEndpointName)
        {
            WsdlServiceName = wsdlServiceName;
            WsdlEndpointName = wsdlEndpointName;
        }

        /// <summary> Name of service to import from WSDL. </summary>
        public string WsdlServiceName { get; set; }
        /// <summary> Name of endpoint(port) to import from WSDL. </summary>
        public string WsdlEndpointName { get; set; }
    }
}