// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Summary result after scanning the firmware. </summary>
    public partial class FirmwareSummary
    {
        /// <summary> Initializes a new instance of FirmwareSummary. </summary>
        internal FirmwareSummary()
        {
        }

        /// <summary> Initializes a new instance of FirmwareSummary. </summary>
        /// <param name="extractedSize"> Total extracted size of the firmware in bytes. </param>
        /// <param name="fileSize"> Firmware file size in bytes. </param>
        /// <param name="extractedFileCount"> Extracted file count. </param>
        /// <param name="componentCount"> Components count. </param>
        /// <param name="binaryCount"> Binary count. </param>
        /// <param name="analysisTimeSeconds"> Time used for analysis. </param>
        /// <param name="rootFileSystems"> The number of root file systems found. </param>
        internal FirmwareSummary(long? extractedSize, long? fileSize, long? extractedFileCount, long? componentCount, long? binaryCount, long? analysisTimeSeconds, long? rootFileSystems)
        {
            ExtractedSize = extractedSize;
            FileSize = fileSize;
            ExtractedFileCount = extractedFileCount;
            ComponentCount = componentCount;
            BinaryCount = binaryCount;
            AnalysisTimeSeconds = analysisTimeSeconds;
            RootFileSystems = rootFileSystems;
        }

        /// <summary> Total extracted size of the firmware in bytes. </summary>
        public long? ExtractedSize { get; }
        /// <summary> Firmware file size in bytes. </summary>
        public long? FileSize { get; }
        /// <summary> Extracted file count. </summary>
        public long? ExtractedFileCount { get; }
        /// <summary> Components count. </summary>
        public long? ComponentCount { get; }
        /// <summary> Binary count. </summary>
        public long? BinaryCount { get; }
        /// <summary> Time used for analysis. </summary>
        public long? AnalysisTimeSeconds { get; }
        /// <summary> The number of root file systems found. </summary>
        public long? RootFileSystems { get; }
    }
}