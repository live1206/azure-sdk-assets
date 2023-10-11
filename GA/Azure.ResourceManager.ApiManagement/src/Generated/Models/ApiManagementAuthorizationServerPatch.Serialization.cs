// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementAuthorizationServerPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(AuthorizationMethods))
            {
                writer.WritePropertyName("authorizationMethods"u8);
                writer.WriteStartArray();
                foreach (var item in AuthorizationMethods)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ClientAuthenticationMethods))
            {
                writer.WritePropertyName("clientAuthenticationMethod"u8);
                writer.WriteStartArray();
                foreach (var item in ClientAuthenticationMethods)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TokenBodyParameters))
            {
                writer.WritePropertyName("tokenBodyParameters"u8);
                writer.WriteStartArray();
                foreach (var item in TokenBodyParameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TokenEndpoint))
            {
                writer.WritePropertyName("tokenEndpoint"u8);
                writer.WriteStringValue(TokenEndpoint);
            }
            if (Optional.IsDefined(DoesSupportState))
            {
                writer.WritePropertyName("supportState"u8);
                writer.WriteBooleanValue(DoesSupportState.Value);
            }
            if (Optional.IsDefined(DefaultScope))
            {
                writer.WritePropertyName("defaultScope"u8);
                writer.WriteStringValue(DefaultScope);
            }
            if (Optional.IsCollectionDefined(BearerTokenSendingMethods))
            {
                writer.WritePropertyName("bearerTokenSendingMethods"u8);
                writer.WriteStartArray();
                foreach (var item in BearerTokenSendingMethods)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ResourceOwnerUsername))
            {
                writer.WritePropertyName("resourceOwnerUsername"u8);
                writer.WriteStringValue(ResourceOwnerUsername);
            }
            if (Optional.IsDefined(ResourceOwnerPassword))
            {
                writer.WritePropertyName("resourceOwnerPassword"u8);
                writer.WriteStringValue(ResourceOwnerPassword);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(ClientRegistrationEndpoint))
            {
                writer.WritePropertyName("clientRegistrationEndpoint"u8);
                writer.WriteStringValue(ClientRegistrationEndpoint);
            }
            if (Optional.IsDefined(AuthorizationEndpoint))
            {
                writer.WritePropertyName("authorizationEndpoint"u8);
                writer.WriteStringValue(AuthorizationEndpoint);
            }
            if (Optional.IsCollectionDefined(GrantTypes))
            {
                writer.WritePropertyName("grantTypes"u8);
                writer.WriteStartArray();
                foreach (var item in GrantTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret"u8);
                writer.WriteStringValue(ClientSecret);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApiManagementAuthorizationServerPatch DeserializeApiManagementAuthorizationServerPatch(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            Optional<IList<AuthorizationMethod>> authorizationMethods = default;
            Optional<IList<ClientAuthenticationMethod>> clientAuthenticationMethod = default;
            Optional<IList<TokenBodyParameterContract>> tokenBodyParameters = default;
            Optional<string> tokenEndpoint = default;
            Optional<bool> supportState = default;
            Optional<string> defaultScope = default;
            Optional<IList<BearerTokenSendingMethod>> bearerTokenSendingMethods = default;
            Optional<string> resourceOwnerUsername = default;
            Optional<string> resourceOwnerPassword = default;
            Optional<string> displayName = default;
            Optional<string> clientRegistrationEndpoint = default;
            Optional<string> authorizationEndpoint = default;
            Optional<IList<GrantType>> grantTypes = default;
            Optional<string> clientId = default;
            Optional<string> clientSecret = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authorizationMethods"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AuthorizationMethod> array = new List<AuthorizationMethod>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString().ToAuthorizationMethod());
                            }
                            authorizationMethods = array;
                            continue;
                        }
                        if (property0.NameEquals("clientAuthenticationMethod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClientAuthenticationMethod> array = new List<ClientAuthenticationMethod>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new ClientAuthenticationMethod(item.GetString()));
                            }
                            clientAuthenticationMethod = array;
                            continue;
                        }
                        if (property0.NameEquals("tokenBodyParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<TokenBodyParameterContract> array = new List<TokenBodyParameterContract>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TokenBodyParameterContract.DeserializeTokenBodyParameterContract(item));
                            }
                            tokenBodyParameters = array;
                            continue;
                        }
                        if (property0.NameEquals("tokenEndpoint"u8))
                        {
                            tokenEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("supportState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportState = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultScope"u8))
                        {
                            defaultScope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bearerTokenSendingMethods"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BearerTokenSendingMethod> array = new List<BearerTokenSendingMethod>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new BearerTokenSendingMethod(item.GetString()));
                            }
                            bearerTokenSendingMethods = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceOwnerUsername"u8))
                        {
                            resourceOwnerUsername = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceOwnerPassword"u8))
                        {
                            resourceOwnerPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientRegistrationEndpoint"u8))
                        {
                            clientRegistrationEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authorizationEndpoint"u8))
                        {
                            authorizationEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("grantTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<GrantType> array = new List<GrantType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new GrantType(item.GetString()));
                            }
                            grantTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("clientId"u8))
                        {
                            clientId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientSecret"u8))
                        {
                            clientSecret = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApiManagementAuthorizationServerPatch(id, name, type, systemData.Value, description.Value, Optional.ToList(authorizationMethods), Optional.ToList(clientAuthenticationMethod), Optional.ToList(tokenBodyParameters), tokenEndpoint.Value, Optional.ToNullable(supportState), defaultScope.Value, Optional.ToList(bearerTokenSendingMethods), resourceOwnerUsername.Value, resourceOwnerPassword.Value, displayName.Value, clientRegistrationEndpoint.Value, authorizationEndpoint.Value, Optional.ToList(grantTypes), clientId.Value, clientSecret.Value);
        }
    }
}