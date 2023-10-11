// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.DataShare;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> List response for get triggers. </summary>
    internal partial class TriggerList
    {
        /// <summary> Initializes a new instance of TriggerList. </summary>
        /// <param name="value">
        /// Collection of items of type DataTransferObjects.
        /// Please note <see cref="DataShareTriggerData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ScheduledTrigger"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal TriggerList(IEnumerable<DataShareTriggerData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of TriggerList. </summary>
        /// <param name="nextLink"> The Url of next result page. </param>
        /// <param name="value">
        /// Collection of items of type DataTransferObjects.
        /// Please note <see cref="DataShareTriggerData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ScheduledTrigger"/>.
        /// </param>
        internal TriggerList(string nextLink, IReadOnlyList<DataShareTriggerData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The Url of next result page. </summary>
        public string NextLink { get; }
        /// <summary>
        /// Collection of items of type DataTransferObjects.
        /// Please note <see cref="DataShareTriggerData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ScheduledTrigger"/>.
        /// </summary>
        public IReadOnlyList<DataShareTriggerData> Value { get; }
    }
}