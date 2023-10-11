// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The UnknownSerialization. </summary>
    internal partial class UnknownSerialization : StreamAnalyticsDataSerialization
    {
        /// <summary> Initializes a new instance of UnknownSerialization. </summary>
        /// <param name="eventSerializationType"> Indicates the type of serialization that the input or output uses. Required on PUT (CreateOrReplace) requests. </param>
        internal UnknownSerialization(EventSerializationType eventSerializationType) : base(eventSerializationType)
        {
            EventSerializationType = eventSerializationType;
        }
    }
}