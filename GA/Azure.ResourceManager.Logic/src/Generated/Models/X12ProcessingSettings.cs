// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The X12 processing settings. </summary>
    public partial class X12ProcessingSettings
    {
        /// <summary> Initializes a new instance of X12ProcessingSettings. </summary>
        /// <param name="maskSecurityInfo"> The value indicating whether to mask security information. </param>
        /// <param name="convertImpliedDecimal"> The value indicating whether to convert numerical type to implied decimal. </param>
        /// <param name="preserveInterchange"> The value indicating whether to preserve interchange. </param>
        /// <param name="suspendInterchangeOnError"> The value indicating whether to suspend interchange on error. </param>
        /// <param name="createEmptyXmlTagsForTrailingSeparators"> The value indicating whether to create empty xml tags for trailing separators. </param>
        /// <param name="useDotAsDecimalSeparator"> The value indicating whether to use dot as decimal separator. </param>
        public X12ProcessingSettings(bool maskSecurityInfo, bool convertImpliedDecimal, bool preserveInterchange, bool suspendInterchangeOnError, bool createEmptyXmlTagsForTrailingSeparators, bool useDotAsDecimalSeparator)
        {
            MaskSecurityInfo = maskSecurityInfo;
            ConvertImpliedDecimal = convertImpliedDecimal;
            PreserveInterchange = preserveInterchange;
            SuspendInterchangeOnError = suspendInterchangeOnError;
            CreateEmptyXmlTagsForTrailingSeparators = createEmptyXmlTagsForTrailingSeparators;
            UseDotAsDecimalSeparator = useDotAsDecimalSeparator;
        }

        /// <summary> The value indicating whether to mask security information. </summary>
        public bool MaskSecurityInfo { get; set; }
        /// <summary> The value indicating whether to convert numerical type to implied decimal. </summary>
        public bool ConvertImpliedDecimal { get; set; }
        /// <summary> The value indicating whether to preserve interchange. </summary>
        public bool PreserveInterchange { get; set; }
        /// <summary> The value indicating whether to suspend interchange on error. </summary>
        public bool SuspendInterchangeOnError { get; set; }
        /// <summary> The value indicating whether to create empty xml tags for trailing separators. </summary>
        public bool CreateEmptyXmlTagsForTrailingSeparators { get; set; }
        /// <summary> The value indicating whether to use dot as decimal separator. </summary>
        public bool UseDotAsDecimalSeparator { get; set; }
    }
}