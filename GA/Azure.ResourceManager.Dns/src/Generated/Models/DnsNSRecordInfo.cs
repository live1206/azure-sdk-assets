// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Dns.Models
{
    /// <summary> An NS record. </summary>
    public partial class DnsNSRecordInfo
    {
        /// <summary> Initializes a new instance of DnsNSRecordInfo. </summary>
        public DnsNSRecordInfo()
        {
        }

        /// <summary> Initializes a new instance of DnsNSRecordInfo. </summary>
        /// <param name="dnsNSDomainName"> The name server name for this NS record. </param>
        internal DnsNSRecordInfo(string dnsNSDomainName)
        {
            DnsNSDomainName = dnsNSDomainName;
        }

        /// <summary> The name server name for this NS record. </summary>
        public string DnsNSDomainName { get; set; }
    }
}
