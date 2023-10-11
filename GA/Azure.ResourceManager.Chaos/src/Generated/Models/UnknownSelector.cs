// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> The UnknownSelector. </summary>
    internal partial class UnknownSelector : Selector
    {
        /// <summary> Initializes a new instance of UnknownSelector. </summary>
        /// <param name="selectorType"> Enum of the selector type. </param>
        /// <param name="id"> String of the selector ID. </param>
        /// <param name="filter">
        /// Model that represents available filter types that can be applied to a targets list.
        /// Please note <see cref="Filter"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SimpleFilter"/>.
        /// </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownSelector(SelectorType selectorType, string id, Filter filter, IDictionary<string, BinaryData> additionalProperties) : base(selectorType, id, filter, additionalProperties)
        {
            SelectorType = selectorType;
        }
    }
}