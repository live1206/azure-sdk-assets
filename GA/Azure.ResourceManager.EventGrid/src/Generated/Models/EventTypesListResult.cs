// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Result of the List Event Types operation. </summary>
    internal partial class EventTypesListResult
    {
        /// <summary> Initializes a new instance of EventTypesListResult. </summary>
        internal EventTypesListResult()
        {
            Value = new ChangeTrackingList<EventTypeUnderTopic>();
        }

        /// <summary> Initializes a new instance of EventTypesListResult. </summary>
        /// <param name="value"> A collection of event types. </param>
        internal EventTypesListResult(IReadOnlyList<EventTypeUnderTopic> value)
        {
            Value = value;
        }

        /// <summary> A collection of event types. </summary>
        public IReadOnlyList<EventTypeUnderTopic> Value { get; }
    }
}