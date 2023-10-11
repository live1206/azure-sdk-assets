// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Volume Export Policy Rule. </summary>
    public partial class NetAppVolumeExportPolicyRule
    {
        /// <summary> Initializes a new instance of NetAppVolumeExportPolicyRule. </summary>
        public NetAppVolumeExportPolicyRule()
        {
        }

        /// <summary> Initializes a new instance of NetAppVolumeExportPolicyRule. </summary>
        /// <param name="ruleIndex"> Order index. </param>
        /// <param name="isUnixReadOnly"> Read only access. </param>
        /// <param name="isUnixReadWrite"> Read and write access. </param>
        /// <param name="isKerberos5ReadOnly"> Kerberos5 Read only access. To be use with swagger version 2020-05-01 or later. </param>
        /// <param name="isKerberos5ReadWrite"> Kerberos5 Read and write access. To be use with swagger version 2020-05-01 or later. </param>
        /// <param name="isKerberos5iReadOnly"> Kerberos5i Read only access. To be use with swagger version 2020-05-01 or later. </param>
        /// <param name="isKerberos5iReadWrite"> Kerberos5i Read and write access. To be use with swagger version 2020-05-01 or later. </param>
        /// <param name="isKerberos5pReadOnly"> Kerberos5p Read only access. To be use with swagger version 2020-05-01 or later. </param>
        /// <param name="isKerberos5pReadWrite"> Kerberos5p Read and write access. To be use with swagger version 2020-05-01 or later. </param>
        /// <param name="allowCifsProtocol"> Allows CIFS protocol. </param>
        /// <param name="allowNfsV3Protocol"> Allows NFSv3 protocol. Enable only for NFSv3 type volumes. </param>
        /// <param name="allowNfsV41Protocol"> Allows NFSv4.1 protocol. Enable only for NFSv4.1 type volumes. </param>
        /// <param name="allowedClients"> Client ingress specification as comma separated string with IPv4 CIDRs, IPv4 host addresses and host names. </param>
        /// <param name="hasRootAccess"> Has root access to volume. </param>
        /// <param name="chownMode"> This parameter specifies who is authorized to change the ownership of a file. restricted - Only root user can change the ownership of the file. unrestricted - Non-root users can change ownership of files that they own. </param>
        internal NetAppVolumeExportPolicyRule(int? ruleIndex, bool? isUnixReadOnly, bool? isUnixReadWrite, bool? isKerberos5ReadOnly, bool? isKerberos5ReadWrite, bool? isKerberos5iReadOnly, bool? isKerberos5iReadWrite, bool? isKerberos5pReadOnly, bool? isKerberos5pReadWrite, bool? allowCifsProtocol, bool? allowNfsV3Protocol, bool? allowNfsV41Protocol, string allowedClients, bool? hasRootAccess, NetAppChownMode? chownMode)
        {
            RuleIndex = ruleIndex;
            IsUnixReadOnly = isUnixReadOnly;
            IsUnixReadWrite = isUnixReadWrite;
            IsKerberos5ReadOnly = isKerberos5ReadOnly;
            IsKerberos5ReadWrite = isKerberos5ReadWrite;
            IsKerberos5iReadOnly = isKerberos5iReadOnly;
            IsKerberos5iReadWrite = isKerberos5iReadWrite;
            IsKerberos5pReadOnly = isKerberos5pReadOnly;
            IsKerberos5pReadWrite = isKerberos5pReadWrite;
            AllowCifsProtocol = allowCifsProtocol;
            AllowNfsV3Protocol = allowNfsV3Protocol;
            AllowNfsV41Protocol = allowNfsV41Protocol;
            AllowedClients = allowedClients;
            HasRootAccess = hasRootAccess;
            ChownMode = chownMode;
        }

        /// <summary> Order index. </summary>
        public int? RuleIndex { get; set; }
        /// <summary> Read only access. </summary>
        public bool? IsUnixReadOnly { get; set; }
        /// <summary> Read and write access. </summary>
        public bool? IsUnixReadWrite { get; set; }
        /// <summary> Kerberos5 Read only access. To be use with swagger version 2020-05-01 or later. </summary>
        public bool? IsKerberos5ReadOnly { get; set; }
        /// <summary> Kerberos5 Read and write access. To be use with swagger version 2020-05-01 or later. </summary>
        public bool? IsKerberos5ReadWrite { get; set; }
        /// <summary> Kerberos5i Read only access. To be use with swagger version 2020-05-01 or later. </summary>
        public bool? IsKerberos5iReadOnly { get; set; }
        /// <summary> Kerberos5i Read and write access. To be use with swagger version 2020-05-01 or later. </summary>
        public bool? IsKerberos5iReadWrite { get; set; }
        /// <summary> Kerberos5p Read only access. To be use with swagger version 2020-05-01 or later. </summary>
        public bool? IsKerberos5pReadOnly { get; set; }
        /// <summary> Kerberos5p Read and write access. To be use with swagger version 2020-05-01 or later. </summary>
        public bool? IsKerberos5pReadWrite { get; set; }
        /// <summary> Allows CIFS protocol. </summary>
        public bool? AllowCifsProtocol { get; set; }
        /// <summary> Allows NFSv3 protocol. Enable only for NFSv3 type volumes. </summary>
        public bool? AllowNfsV3Protocol { get; set; }
        /// <summary> Allows NFSv4.1 protocol. Enable only for NFSv4.1 type volumes. </summary>
        public bool? AllowNfsV41Protocol { get; set; }
        /// <summary> Client ingress specification as comma separated string with IPv4 CIDRs, IPv4 host addresses and host names. </summary>
        public string AllowedClients { get; set; }
        /// <summary> Has root access to volume. </summary>
        public bool? HasRootAccess { get; set; }
        /// <summary> This parameter specifies who is authorized to change the ownership of a file. restricted - Only root user can change the ownership of the file. unrestricted - Non-root users can change ownership of files that they own. </summary>
        public NetAppChownMode? ChownMode { get; set; }
    }
}