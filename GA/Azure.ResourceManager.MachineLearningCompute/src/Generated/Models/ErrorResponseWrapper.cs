// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Wrapper for error response to follow ARM guidelines. </summary>
    public partial class ErrorResponseWrapper
    {
        /// <summary> Initializes a new instance of ErrorResponseWrapper. </summary>
        internal ErrorResponseWrapper()
        {
        }

        /// <summary> Initializes a new instance of ErrorResponseWrapper. </summary>
        /// <param name="error"> The error response. </param>
        internal ErrorResponseWrapper(ErrorResponse error)
        {
            Error = error;
        }

        /// <summary> The error response. </summary>
        public ErrorResponse Error { get; }
    }
}