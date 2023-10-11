// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Access Control List (ACL) for an iSCSI Target; defines LUN masking policy. </summary>
    public partial class DiskPoolIscsiTargetPortalGroupAcl
    {
        /// <summary> Initializes a new instance of DiskPoolIscsiTargetPortalGroupAcl. </summary>
        /// <param name="initiatorIqn"> iSCSI initiator IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:client". </param>
        /// <param name="mappedLuns"> List of LUN names mapped to the ACL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="initiatorIqn"/> or <paramref name="mappedLuns"/> is null. </exception>
        public DiskPoolIscsiTargetPortalGroupAcl(string initiatorIqn, IEnumerable<string> mappedLuns)
        {
            Argument.AssertNotNull(initiatorIqn, nameof(initiatorIqn));
            Argument.AssertNotNull(mappedLuns, nameof(mappedLuns));

            InitiatorIqn = initiatorIqn;
            MappedLuns = mappedLuns.ToList();
        }

        /// <summary> Initializes a new instance of DiskPoolIscsiTargetPortalGroupAcl. </summary>
        /// <param name="initiatorIqn"> iSCSI initiator IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:client". </param>
        /// <param name="mappedLuns"> List of LUN names mapped to the ACL. </param>
        internal DiskPoolIscsiTargetPortalGroupAcl(string initiatorIqn, IList<string> mappedLuns)
        {
            InitiatorIqn = initiatorIqn;
            MappedLuns = mappedLuns;
        }

        /// <summary> iSCSI initiator IQN (iSCSI Qualified Name); example: "iqn.2005-03.org.iscsi:client". </summary>
        public string InitiatorIqn { get; set; }
        /// <summary> List of LUN names mapped to the ACL. </summary>
        public IList<string> MappedLuns { get; }
    }
}
