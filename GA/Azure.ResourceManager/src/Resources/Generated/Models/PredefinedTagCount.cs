// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Tag count. </summary>
    public partial class PredefinedTagCount
    {
        /// <summary> Initializes a new instance of PredefinedTagCount. </summary>
        internal PredefinedTagCount()
        {
        }

        /// <summary> Initializes a new instance of PredefinedTagCount. </summary>
        /// <param name="predefinedTagCountType"> Type of count. </param>
        /// <param name="value"> Value of count. </param>
        internal PredefinedTagCount(string predefinedTagCountType, int? value)
        {
            PredefinedTagCountType = predefinedTagCountType;
            Value = value;
        }

        /// <summary> Type of count. </summary>
        public string PredefinedTagCountType { get; }
        /// <summary> Value of count. </summary>
        public int? Value { get; }
    }
}