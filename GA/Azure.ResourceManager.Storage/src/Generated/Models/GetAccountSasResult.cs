// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The List SAS credentials operation response. </summary>
    public partial class GetAccountSasResult
    {
        /// <summary> Initializes a new instance of GetAccountSasResult. </summary>
        internal GetAccountSasResult()
        {
        }

        /// <summary> Initializes a new instance of GetAccountSasResult. </summary>
        /// <param name="accountSasToken"> List SAS credentials of storage account. </param>
        internal GetAccountSasResult(string accountSasToken)
        {
            AccountSasToken = accountSasToken;
        }

        /// <summary> List SAS credentials of storage account. </summary>
        public string AccountSasToken { get; }
    }
}