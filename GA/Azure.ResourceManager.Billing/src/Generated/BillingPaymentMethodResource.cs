// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A Class representing a BillingPaymentMethod along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="BillingPaymentMethodResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetBillingPaymentMethodResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetBillingPaymentMethod method.
    /// </summary>
    public partial class BillingPaymentMethodResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BillingPaymentMethodResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string paymentMethodName)
        {
            var resourceId = $"/providers/Microsoft.Billing/paymentMethods/{paymentMethodName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _billingPaymentMethodPaymentMethodsClientDiagnostics;
        private readonly PaymentMethodsRestOperations _billingPaymentMethodPaymentMethodsRestClient;
        private readonly BillingPaymentMethodData _data;

        /// <summary> Initializes a new instance of the <see cref="BillingPaymentMethodResource"/> class for mocking. </summary>
        protected BillingPaymentMethodResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BillingPaymentMethodResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BillingPaymentMethodResource(ArmClient client, BillingPaymentMethodData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BillingPaymentMethodResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BillingPaymentMethodResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingPaymentMethodPaymentMethodsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string billingPaymentMethodPaymentMethodsApiVersion);
            _billingPaymentMethodPaymentMethodsRestClient = new PaymentMethodsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingPaymentMethodPaymentMethodsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/paymentMethods";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BillingPaymentMethodData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a payment method owned by the caller.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByUser</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BillingPaymentMethodResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _billingPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingPaymentMethodResource.Get");
            scope.Start();
            try
            {
                var response = await _billingPaymentMethodPaymentMethodsRestClient.GetByUserAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingPaymentMethodResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a payment method owned by the caller.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByUser</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BillingPaymentMethodResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _billingPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingPaymentMethodResource.Get");
            scope.Start();
            try
            {
                var response = _billingPaymentMethodPaymentMethodsRestClient.GetByUser(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingPaymentMethodResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a payment method owned by the caller.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_DeleteByUser</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _billingPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingPaymentMethodResource.Delete");
            scope.Start();
            try
            {
                var response = await _billingPaymentMethodPaymentMethodsRestClient.DeleteByUserAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new BillingArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a payment method owned by the caller.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_DeleteByUser</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _billingPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingPaymentMethodResource.Delete");
            scope.Start();
            try
            {
                var response = _billingPaymentMethodPaymentMethodsRestClient.DeleteByUser(Id.Name, cancellationToken);
                var operation = new BillingArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}