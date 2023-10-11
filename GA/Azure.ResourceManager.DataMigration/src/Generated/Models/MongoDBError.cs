// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes an error or warning that occurred during a MongoDB migration. </summary>
    public partial class MongoDBError
    {
        /// <summary> Initializes a new instance of MongoDBError. </summary>
        internal MongoDBError()
        {
        }

        /// <summary> Initializes a new instance of MongoDBError. </summary>
        /// <param name="code"> The non-localized, machine-readable code that describes the error or warning. </param>
        /// <param name="count"> The number of times the error or warning has occurred. </param>
        /// <param name="message"> The localized, human-readable message that describes the error or warning. </param>
        /// <param name="errorType"> The type of error or warning. </param>
        internal MongoDBError(string code, int? count, string message, MongoDBErrorType? errorType)
        {
            Code = code;
            Count = count;
            Message = message;
            ErrorType = errorType;
        }

        /// <summary> The non-localized, machine-readable code that describes the error or warning. </summary>
        public string Code { get; }
        /// <summary> The number of times the error or warning has occurred. </summary>
        public int? Count { get; }
        /// <summary> The localized, human-readable message that describes the error or warning. </summary>
        public string Message { get; }
        /// <summary> The type of error or warning. </summary>
        public MongoDBErrorType? ErrorType { get; }
    }
}