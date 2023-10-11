// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Exception object for all custom exceptions. </summary>
    public partial class ReportableException
    {
        /// <summary> Initializes a new instance of ReportableException. </summary>
        internal ReportableException()
        {
        }

        /// <summary> Initializes a new instance of ReportableException. </summary>
        /// <param name="message"> Error message. </param>
        /// <param name="actionableMessage"> Actionable steps for this exception. </param>
        /// <param name="filePath"> The path to the file where exception occurred. </param>
        /// <param name="lineNumber"> The line number where exception occurred. </param>
        /// <param name="hResult"> Coded numerical value that is assigned to a specific exception. </param>
        /// <param name="stackTrace"> Stack trace. </param>
        internal ReportableException(string message, string actionableMessage, string filePath, string lineNumber, int? hResult, string stackTrace)
        {
            Message = message;
            ActionableMessage = actionableMessage;
            FilePath = filePath;
            LineNumber = lineNumber;
            HResult = hResult;
            StackTrace = stackTrace;
        }

        /// <summary> Error message. </summary>
        public string Message { get; }
        /// <summary> Actionable steps for this exception. </summary>
        public string ActionableMessage { get; }
        /// <summary> The path to the file where exception occurred. </summary>
        public string FilePath { get; }
        /// <summary> The line number where exception occurred. </summary>
        public string LineNumber { get; }
        /// <summary> Coded numerical value that is assigned to a specific exception. </summary>
        public int? HResult { get; }
        /// <summary> Stack trace. </summary>
        public string StackTrace { get; }
    }
}