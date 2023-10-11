// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ManagedServices
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ManagedServices. </summary>
    public static partial class ManagedServicesExtensions
    {
        private static ArmResourceExtensionClient GetArmResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ArmResourceExtensionClient(client, resource.Id);
            });
        }

        private static ArmResourceExtensionClient GetArmResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ArmResourceExtensionClient(client, scope);
            });
        }
        #region ManagedServicesRegistrationResource
        /// <summary>
        /// Gets an object representing a <see cref="ManagedServicesRegistrationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedServicesRegistrationResource.CreateResourceIdentifier" /> to create a <see cref="ManagedServicesRegistrationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedServicesRegistrationResource" /> object. </returns>
        public static ManagedServicesRegistrationResource GetManagedServicesRegistrationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ManagedServicesRegistrationResource.ValidateResourceId(id);
                return new ManagedServicesRegistrationResource(client, id);
            }
            );
        }
        #endregion

        #region ManagedServicesRegistrationAssignmentResource
        /// <summary>
        /// Gets an object representing a <see cref="ManagedServicesRegistrationAssignmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedServicesRegistrationAssignmentResource.CreateResourceIdentifier" /> to create a <see cref="ManagedServicesRegistrationAssignmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedServicesRegistrationAssignmentResource" /> object. </returns>
        public static ManagedServicesRegistrationAssignmentResource GetManagedServicesRegistrationAssignmentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ManagedServicesRegistrationAssignmentResource.ValidateResourceId(id);
                return new ManagedServicesRegistrationAssignmentResource(client, id);
            }
            );
        }
        #endregion

        #region ManagedServicesMarketplaceRegistrationResource
        /// <summary>
        /// Gets an object representing a <see cref="ManagedServicesMarketplaceRegistrationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedServicesMarketplaceRegistrationResource.CreateResourceIdentifier" /> to create a <see cref="ManagedServicesMarketplaceRegistrationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedServicesMarketplaceRegistrationResource" /> object. </returns>
        public static ManagedServicesMarketplaceRegistrationResource GetManagedServicesMarketplaceRegistrationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ManagedServicesMarketplaceRegistrationResource.ValidateResourceId(id);
                return new ManagedServicesMarketplaceRegistrationResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of ManagedServicesRegistrationResources in the ArmResource. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of ManagedServicesRegistrationResources and their operations over a ManagedServicesRegistrationResource. </returns>
        public static ManagedServicesRegistrationCollection GetManagedServicesRegistrations(this ArmClient client, ResourceIdentifier scope)
        {
            return GetArmResourceExtensionClient(client, scope).GetManagedServicesRegistrations();
        }

        /// <summary>
        /// Gets the registration definition details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationDefinitions/{registrationDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="registrationId"> The GUID of the registration definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registrationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registrationId"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ManagedServicesRegistrationResource>> GetManagedServicesRegistrationAsync(this ArmClient client, ResourceIdentifier scope, string registrationId, CancellationToken cancellationToken = default)
        {
            return await client.GetManagedServicesRegistrations(scope).GetAsync(registrationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the registration definition details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationDefinitions/{registrationDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="registrationId"> The GUID of the registration definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registrationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registrationId"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ManagedServicesRegistrationResource> GetManagedServicesRegistration(this ArmClient client, ResourceIdentifier scope, string registrationId, CancellationToken cancellationToken = default)
        {
            return client.GetManagedServicesRegistrations(scope).Get(registrationId, cancellationToken);
        }

        /// <summary> Gets a collection of ManagedServicesRegistrationAssignmentResources in the ArmResource. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of ManagedServicesRegistrationAssignmentResources and their operations over a ManagedServicesRegistrationAssignmentResource. </returns>
        public static ManagedServicesRegistrationAssignmentCollection GetManagedServicesRegistrationAssignments(this ArmClient client, ResourceIdentifier scope)
        {
            return GetArmResourceExtensionClient(client, scope).GetManagedServicesRegistrationAssignments();
        }

        /// <summary>
        /// Gets the details of the specified registration assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationAssignments/{registrationAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="registrationAssignmentId"> The GUID of the registration assignment. </param>
        /// <param name="expandRegistrationDefinition"> The flag indicating whether to return the registration definition details along with the registration assignment details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registrationAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registrationAssignmentId"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ManagedServicesRegistrationAssignmentResource>> GetManagedServicesRegistrationAssignmentAsync(this ArmClient client, ResourceIdentifier scope, string registrationAssignmentId, bool? expandRegistrationDefinition = null, CancellationToken cancellationToken = default)
        {
            return await client.GetManagedServicesRegistrationAssignments(scope).GetAsync(registrationAssignmentId, expandRegistrationDefinition, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of the specified registration assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/registrationAssignments/{registrationAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RegistrationAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="registrationAssignmentId"> The GUID of the registration assignment. </param>
        /// <param name="expandRegistrationDefinition"> The flag indicating whether to return the registration definition details along with the registration assignment details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="registrationAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="registrationAssignmentId"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ManagedServicesRegistrationAssignmentResource> GetManagedServicesRegistrationAssignment(this ArmClient client, ResourceIdentifier scope, string registrationAssignmentId, bool? expandRegistrationDefinition = null, CancellationToken cancellationToken = default)
        {
            return client.GetManagedServicesRegistrationAssignments(scope).Get(registrationAssignmentId, expandRegistrationDefinition, cancellationToken);
        }

        /// <summary> Gets a collection of ManagedServicesMarketplaceRegistrationResources in the ArmResource. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of ManagedServicesMarketplaceRegistrationResources and their operations over a ManagedServicesMarketplaceRegistrationResource. </returns>
        public static ManagedServicesMarketplaceRegistrationCollection GetManagedServicesMarketplaceRegistrations(this ArmClient client, ResourceIdentifier scope)
        {
            return GetArmResourceExtensionClient(client, scope).GetManagedServicesMarketplaceRegistrations();
        }

        /// <summary>
        /// Get the marketplace registration definition for the marketplace identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions/{marketplaceIdentifier}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceRegistrationDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="marketplaceIdentifier"> The Azure Marketplace identifier. Expected formats: {publisher}.{product[-preview]}.{planName}.{version} or {publisher}.{product[-preview]}.{planName} or {publisher}.{product[-preview]} or {publisher}). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceIdentifier"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceIdentifier"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ManagedServicesMarketplaceRegistrationResource>> GetManagedServicesMarketplaceRegistrationAsync(this ArmClient client, ResourceIdentifier scope, string marketplaceIdentifier, CancellationToken cancellationToken = default)
        {
            return await client.GetManagedServicesMarketplaceRegistrations(scope).GetAsync(marketplaceIdentifier, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the marketplace registration definition for the marketplace identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedServices/marketplaceRegistrationDefinitions/{marketplaceIdentifier}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MarketplaceRegistrationDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="marketplaceIdentifier"> The Azure Marketplace identifier. Expected formats: {publisher}.{product[-preview]}.{planName}.{version} or {publisher}.{product[-preview]}.{planName} or {publisher}.{product[-preview]} or {publisher}). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="marketplaceIdentifier"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceIdentifier"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ManagedServicesMarketplaceRegistrationResource> GetManagedServicesMarketplaceRegistration(this ArmClient client, ResourceIdentifier scope, string marketplaceIdentifier, CancellationToken cancellationToken = default)
        {
            return client.GetManagedServicesMarketplaceRegistrations(scope).Get(marketplaceIdentifier, cancellationToken);
        }
    }
}