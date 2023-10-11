// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ResourceGraph.Models
{
    /// <summary>
    /// A facet containing additional statistics on the response of a query. Can be either FacetResult or FacetError.
    /// Please note <see cref="Facet"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FacetError"/> and <see cref="FacetResult"/>.
    /// </summary>
    public abstract partial class Facet
    {
        /// <summary> Initializes a new instance of Facet. </summary>
        /// <param name="expression"> Facet expression, same as in the corresponding facet request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="expression"/> is null. </exception>
        protected Facet(string expression)
        {
            Argument.AssertNotNull(expression, nameof(expression));

            Expression = expression;
        }

        /// <summary> Initializes a new instance of Facet. </summary>
        /// <param name="expression"> Facet expression, same as in the corresponding facet request. </param>
        /// <param name="resultType"> Result type. </param>
        internal Facet(string expression, string resultType)
        {
            Expression = expression;
            ResultType = resultType;
        }

        /// <summary> Facet expression, same as in the corresponding facet request. </summary>
        public string Expression { get; }
        /// <summary> Result type. </summary>
        internal string ResultType { get; set; }
    }
}