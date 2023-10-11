// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageFabric switch provider blocking error details. </summary>
    public partial class InMageFabricSwitchProviderBlockingErrorDetails
    {
        /// <summary> Initializes a new instance of InMageFabricSwitchProviderBlockingErrorDetails. </summary>
        internal InMageFabricSwitchProviderBlockingErrorDetails()
        {
            ErrorMessageParameters = new ChangeTrackingDictionary<string, string>();
            ErrorTags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of InMageFabricSwitchProviderBlockingErrorDetails. </summary>
        /// <param name="errorCode"> The error code. </param>
        /// <param name="errorMessage"> The error message. </param>
        /// <param name="possibleCauses"> The possible causes. </param>
        /// <param name="recommendedAction"> The recommended action. </param>
        /// <param name="errorMessageParameters"> The error message parameters. </param>
        /// <param name="errorTags"> The error tags. </param>
        internal InMageFabricSwitchProviderBlockingErrorDetails(string errorCode, string errorMessage, string possibleCauses, string recommendedAction, IReadOnlyDictionary<string, string> errorMessageParameters, IReadOnlyDictionary<string, string> errorTags)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            PossibleCauses = possibleCauses;
            RecommendedAction = recommendedAction;
            ErrorMessageParameters = errorMessageParameters;
            ErrorTags = errorTags;
        }

        /// <summary> The error code. </summary>
        public string ErrorCode { get; }
        /// <summary> The error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> The possible causes. </summary>
        public string PossibleCauses { get; }
        /// <summary> The recommended action. </summary>
        public string RecommendedAction { get; }
        /// <summary> The error message parameters. </summary>
        public IReadOnlyDictionary<string, string> ErrorMessageParameters { get; }
        /// <summary> The error tags. </summary>
        public IReadOnlyDictionary<string, string> ErrorTags { get; }
    }
}
