// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The configuration for nodes in a pool based on the Azure Cloud Services platform. </summary>
    public partial class BatchCloudServiceConfiguration
    {
        /// <summary> Initializes a new instance of BatchCloudServiceConfiguration. </summary>
        /// <param name="osFamily"> Possible values are: 2 - OS Family 2, equivalent to Windows Server 2008 R2 SP1. 3 - OS Family 3, equivalent to Windows Server 2012. 4 - OS Family 4, equivalent to Windows Server 2012 R2. 5 - OS Family 5, equivalent to Windows Server 2016. 6 - OS Family 6, equivalent to Windows Server 2019. For more information, see Azure Guest OS Releases (https://azure.microsoft.com/documentation/articles/cloud-services-guestos-update-matrix/#releases). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="osFamily"/> is null. </exception>
        public BatchCloudServiceConfiguration(string osFamily)
        {
            Argument.AssertNotNull(osFamily, nameof(osFamily));

            OSFamily = osFamily;
        }

        /// <summary> Initializes a new instance of BatchCloudServiceConfiguration. </summary>
        /// <param name="osFamily"> Possible values are: 2 - OS Family 2, equivalent to Windows Server 2008 R2 SP1. 3 - OS Family 3, equivalent to Windows Server 2012. 4 - OS Family 4, equivalent to Windows Server 2012 R2. 5 - OS Family 5, equivalent to Windows Server 2016. 6 - OS Family 6, equivalent to Windows Server 2019. For more information, see Azure Guest OS Releases (https://azure.microsoft.com/documentation/articles/cloud-services-guestos-update-matrix/#releases). </param>
        /// <param name="osVersion"> The default value is * which specifies the latest operating system version for the specified OS family. </param>
        internal BatchCloudServiceConfiguration(string osFamily, string osVersion)
        {
            OSFamily = osFamily;
            OSVersion = osVersion;
        }

        /// <summary> Possible values are: 2 - OS Family 2, equivalent to Windows Server 2008 R2 SP1. 3 - OS Family 3, equivalent to Windows Server 2012. 4 - OS Family 4, equivalent to Windows Server 2012 R2. 5 - OS Family 5, equivalent to Windows Server 2016. 6 - OS Family 6, equivalent to Windows Server 2019. For more information, see Azure Guest OS Releases (https://azure.microsoft.com/documentation/articles/cloud-services-guestos-update-matrix/#releases). </summary>
        public string OSFamily { get; set; }
        /// <summary> The default value is * which specifies the latest operating system version for the specified OS family. </summary>
        public string OSVersion { get; set; }
    }
}