// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.TrafficManager.Models
{
    /// <summary> Class containing DNS settings in a Traffic Manager profile. </summary>
    public partial class TrafficManagerDnsConfig
    {
        /// <summary> Initializes a new instance of TrafficManagerDnsConfig. </summary>
        public TrafficManagerDnsConfig()
        {
        }

        /// <summary> Initializes a new instance of TrafficManagerDnsConfig. </summary>
        /// <param name="relativeName"> The relative DNS name provided by this Traffic Manager profile. This value is combined with the DNS domain name used by Azure Traffic Manager to form the fully-qualified domain name (FQDN) of the profile. </param>
        /// <param name="fqdn"> The fully-qualified domain name (FQDN) of the Traffic Manager profile. This is formed from the concatenation of the RelativeName with the DNS domain used by Azure Traffic Manager. </param>
        /// <param name="ttl"> The DNS Time-To-Live (TTL), in seconds. This informs the local DNS resolvers and DNS clients how long to cache DNS responses provided by this Traffic Manager profile. </param>
        internal TrafficManagerDnsConfig(string relativeName, string fqdn, long? ttl)
        {
            RelativeName = relativeName;
            Fqdn = fqdn;
            Ttl = ttl;
        }

        /// <summary> The relative DNS name provided by this Traffic Manager profile. This value is combined with the DNS domain name used by Azure Traffic Manager to form the fully-qualified domain name (FQDN) of the profile. </summary>
        public string RelativeName { get; set; }
        /// <summary> The fully-qualified domain name (FQDN) of the Traffic Manager profile. This is formed from the concatenation of the RelativeName with the DNS domain used by Azure Traffic Manager. </summary>
        public string Fqdn { get; }
        /// <summary> The DNS Time-To-Live (TTL), in seconds. This informs the local DNS resolvers and DNS clients how long to cache DNS responses provided by this Traffic Manager profile. </summary>
        public long? Ttl { get; set; }
    }
}