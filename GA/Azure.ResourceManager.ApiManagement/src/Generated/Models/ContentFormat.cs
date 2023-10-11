// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Format of the Content in which the API is getting imported. </summary>
    public readonly partial struct ContentFormat : IEquatable<ContentFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContentFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContentFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WadlXmlValue = "wadl-xml";
        private const string WadlLinkJsonValue = "wadl-link-json";
        private const string SwaggerJsonValue = "swagger-json";
        private const string SwaggerLinkJsonValue = "swagger-link-json";
        private const string WsdlValue = "wsdl";
        private const string WsdlLinkValue = "wsdl-link";
        private const string OpenApiValue = "openapi";
        private const string OpenApiJsonValue = "openapi+json";
        private const string OpenApiLinkValue = "openapi-link";
        private const string OpenApiJsonLinkValue = "openapi+json-link";
        private const string GraphQLLinkValue = "graphql-link";

        /// <summary> The contents are inline and Content type is a WADL document. </summary>
        public static ContentFormat WadlXml { get; } = new ContentFormat(WadlXmlValue);
        /// <summary> The WADL document is hosted on a publicly accessible internet address. </summary>
        public static ContentFormat WadlLinkJson { get; } = new ContentFormat(WadlLinkJsonValue);
        /// <summary> The contents are inline and Content Type is a OpenAPI 2.0 JSON Document. </summary>
        public static ContentFormat SwaggerJson { get; } = new ContentFormat(SwaggerJsonValue);
        /// <summary> The OpenAPI 2.0 JSON document is hosted on a publicly accessible internet address. </summary>
        public static ContentFormat SwaggerLinkJson { get; } = new ContentFormat(SwaggerLinkJsonValue);
        /// <summary> The contents are inline and the document is a WSDL/Soap document. </summary>
        public static ContentFormat Wsdl { get; } = new ContentFormat(WsdlValue);
        /// <summary> The WSDL document is hosted on a publicly accessible internet address. </summary>
        public static ContentFormat WsdlLink { get; } = new ContentFormat(WsdlLinkValue);
        /// <summary> The contents are inline and Content Type is a OpenAPI 3.0 YAML Document. </summary>
        public static ContentFormat OpenApi { get; } = new ContentFormat(OpenApiValue);
        /// <summary> The contents are inline and Content Type is a OpenAPI 3.0 JSON Document. </summary>
        public static ContentFormat OpenApiJson { get; } = new ContentFormat(OpenApiJsonValue);
        /// <summary> The OpenAPI 3.0 YAML document is hosted on a publicly accessible internet address. </summary>
        public static ContentFormat OpenApiLink { get; } = new ContentFormat(OpenApiLinkValue);
        /// <summary> The OpenAPI 3.0 JSON document is hosted on a publicly accessible internet address. </summary>
        public static ContentFormat OpenApiJsonLink { get; } = new ContentFormat(OpenApiJsonLinkValue);
        /// <summary> The GraphQL API endpoint hosted on a publicly accessible internet address. </summary>
        public static ContentFormat GraphQLLink { get; } = new ContentFormat(GraphQLLinkValue);
        /// <summary> Determines if two <see cref="ContentFormat"/> values are the same. </summary>
        public static bool operator ==(ContentFormat left, ContentFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContentFormat"/> values are not the same. </summary>
        public static bool operator !=(ContentFormat left, ContentFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ContentFormat"/>. </summary>
        public static implicit operator ContentFormat(string value) => new ContentFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContentFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContentFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
