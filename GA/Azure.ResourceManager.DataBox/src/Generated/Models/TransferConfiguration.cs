// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Configuration for defining the transfer of data. </summary>
    public partial class TransferConfiguration
    {
        /// <summary> Initializes a new instance of TransferConfiguration. </summary>
        /// <param name="transferConfigurationType"> Type of the configuration for transfer. </param>
        public TransferConfiguration(TransferConfigurationType transferConfigurationType)
        {
            TransferConfigurationType = transferConfigurationType;
        }

        /// <summary> Initializes a new instance of TransferConfiguration. </summary>
        /// <param name="transferConfigurationType"> Type of the configuration for transfer. </param>
        /// <param name="transferFilterDetails"> Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as TransferUsingFilter. </param>
        /// <param name="transferAllDetails"> Map of filter type and the details to transfer all data. This field is required only if the TransferConfigurationType is given as TransferAll. </param>
        internal TransferConfiguration(TransferConfigurationType transferConfigurationType, TransferConfigurationTransferFilterDetails transferFilterDetails, TransferConfigurationTransferAllDetails transferAllDetails)
        {
            TransferConfigurationType = transferConfigurationType;
            TransferFilterDetails = transferFilterDetails;
            TransferAllDetails = transferAllDetails;
        }

        /// <summary> Type of the configuration for transfer. </summary>
        public TransferConfigurationType TransferConfigurationType { get; set; }
        /// <summary> Map of filter type and the details to filter. This field is required only if the TransferConfigurationType is given as TransferUsingFilter. </summary>
        internal TransferConfigurationTransferFilterDetails TransferFilterDetails { get; set; }
        /// <summary> Details of the filtering the transfer of data. </summary>
        public TransferFilterDetails TransferFilterDetailsInclude
        {
            get => TransferFilterDetails is null ? default : TransferFilterDetails.Include;
            set
            {
                if (TransferFilterDetails is null)
                    TransferFilterDetails = new TransferConfigurationTransferFilterDetails();
                TransferFilterDetails.Include = value;
            }
        }

        /// <summary> Map of filter type and the details to transfer all data. This field is required only if the TransferConfigurationType is given as TransferAll. </summary>
        internal TransferConfigurationTransferAllDetails TransferAllDetails { get; set; }
        /// <summary> Details to transfer all data. </summary>
        public TransferAllDetails TransferAllDetailsInclude
        {
            get => TransferAllDetails is null ? default : TransferAllDetails.Include;
            set
            {
                if (TransferAllDetails is null)
                    TransferAllDetails = new TransferConfigurationTransferAllDetails();
                TransferAllDetails.Include = value;
            }
        }
    }
}