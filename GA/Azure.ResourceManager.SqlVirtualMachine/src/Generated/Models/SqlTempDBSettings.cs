// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> The SqlTempDBSettings. </summary>
    public partial class SqlTempDBSettings
    {
        /// <summary> Initializes a new instance of SqlTempDBSettings. </summary>
        public SqlTempDBSettings()
        {
            LogicalUnitNumbers = new ChangeTrackingList<int>();
        }

        /// <summary> Initializes a new instance of SqlTempDBSettings. </summary>
        /// <param name="dataFileSize"> SQL Server tempdb data file size. </param>
        /// <param name="dataGrowth"> SQL Server tempdb data file autoGrowth size. </param>
        /// <param name="logFileSize"> SQL Server tempdb log file size. </param>
        /// <param name="logGrowth"> SQL Server tempdb log file autoGrowth size. </param>
        /// <param name="dataFileCount"> SQL Server tempdb data file count. </param>
        /// <param name="persistFolder"> SQL Server tempdb persist folder choice. </param>
        /// <param name="persistFolderPath"> SQL Server tempdb persist folder location. </param>
        /// <param name="logicalUnitNumbers"> Logical Unit Numbers for the disks. </param>
        /// <param name="defaultFilePath"> SQL Server default file path. </param>
        internal SqlTempDBSettings(int? dataFileSize, int? dataGrowth, int? logFileSize, int? logGrowth, int? dataFileCount, bool? persistFolder, string persistFolderPath, IList<int> logicalUnitNumbers, string defaultFilePath)
        {
            DataFileSize = dataFileSize;
            DataGrowth = dataGrowth;
            LogFileSize = logFileSize;
            LogGrowth = logGrowth;
            DataFileCount = dataFileCount;
            PersistFolder = persistFolder;
            PersistFolderPath = persistFolderPath;
            LogicalUnitNumbers = logicalUnitNumbers;
            DefaultFilePath = defaultFilePath;
        }

        /// <summary> SQL Server tempdb data file size. </summary>
        public int? DataFileSize { get; set; }
        /// <summary> SQL Server tempdb data file autoGrowth size. </summary>
        public int? DataGrowth { get; set; }
        /// <summary> SQL Server tempdb log file size. </summary>
        public int? LogFileSize { get; set; }
        /// <summary> SQL Server tempdb log file autoGrowth size. </summary>
        public int? LogGrowth { get; set; }
        /// <summary> SQL Server tempdb data file count. </summary>
        public int? DataFileCount { get; set; }
        /// <summary> SQL Server tempdb persist folder choice. </summary>
        public bool? PersistFolder { get; set; }
        /// <summary> SQL Server tempdb persist folder location. </summary>
        public string PersistFolderPath { get; set; }
        /// <summary> Logical Unit Numbers for the disks. </summary>
        public IList<int> LogicalUnitNumbers { get; }
        /// <summary> SQL Server default file path. </summary>
        public string DefaultFilePath { get; set; }
    }
}