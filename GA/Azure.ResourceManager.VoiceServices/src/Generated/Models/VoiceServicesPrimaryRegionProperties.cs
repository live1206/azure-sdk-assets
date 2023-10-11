// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.VoiceServices.Models
{
    /// <summary> The configuration used in this region as primary, and other regions as backup. </summary>
    public partial class VoiceServicesPrimaryRegionProperties
    {
        /// <summary> Initializes a new instance of VoiceServicesPrimaryRegionProperties. </summary>
        /// <param name="operatorAddresses"> IP address to use to contact the operator network from this region. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operatorAddresses"/> is null. </exception>
        public VoiceServicesPrimaryRegionProperties(IEnumerable<string> operatorAddresses)
        {
            Argument.AssertNotNull(operatorAddresses, nameof(operatorAddresses));

            OperatorAddresses = operatorAddresses.ToList();
            EsrpAddresses = new ChangeTrackingList<string>();
            AllowedSignalingSourceAddressPrefixes = new ChangeTrackingList<string>();
            AllowedMediaSourceAddressPrefixes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VoiceServicesPrimaryRegionProperties. </summary>
        /// <param name="operatorAddresses"> IP address to use to contact the operator network from this region. </param>
        /// <param name="esrpAddresses"> IP address to use to contact the ESRP from this region. </param>
        /// <param name="allowedSignalingSourceAddressPrefixes"> The allowed source IP address or CIDR ranges for signaling. </param>
        /// <param name="allowedMediaSourceAddressPrefixes"> The allowed source IP address or CIDR ranges for media. </param>
        internal VoiceServicesPrimaryRegionProperties(IList<string> operatorAddresses, IList<string> esrpAddresses, IList<string> allowedSignalingSourceAddressPrefixes, IList<string> allowedMediaSourceAddressPrefixes)
        {
            OperatorAddresses = operatorAddresses;
            EsrpAddresses = esrpAddresses;
            AllowedSignalingSourceAddressPrefixes = allowedSignalingSourceAddressPrefixes;
            AllowedMediaSourceAddressPrefixes = allowedMediaSourceAddressPrefixes;
        }

        /// <summary> IP address to use to contact the operator network from this region. </summary>
        public IList<string> OperatorAddresses { get; }
        /// <summary> IP address to use to contact the ESRP from this region. </summary>
        public IList<string> EsrpAddresses { get; }
        /// <summary> The allowed source IP address or CIDR ranges for signaling. </summary>
        public IList<string> AllowedSignalingSourceAddressPrefixes { get; }
        /// <summary> The allowed source IP address or CIDR ranges for media. </summary>
        public IList<string> AllowedMediaSourceAddressPrefixes { get; }
    }
}