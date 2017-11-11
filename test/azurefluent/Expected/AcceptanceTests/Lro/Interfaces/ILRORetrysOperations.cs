// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AcceptanceTestsLro
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// LRORetrysOperations operations.
    /// </summary>
    public partial interface ILRORetrysOperations
    {
        ILRORetrysOperationsWithHttpMessages WithHttpMessages();

        /// <summary>
        /// Long running put request, service returns a 500, then a 201 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’.  Polls return this value until the last poll returns a ‘200’ with
        /// ProvisioningState=’Succeeded’
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        ProductInner Put201CreatingSucceeded200(ProductInner product = default(ProductInner));

        /// <summary>
        /// Long running put request, service returns a 500, then a 201 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’.  Polls return this value until the last poll returns a ‘200’ with
        /// ProvisioningState=’Succeeded’
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<ProductInner> Put201CreatingSucceeded200Async(ProductInner product = default(ProductInner), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Long running put request, service returns a 500, then a 200 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        ProductInner PutAsyncRelativeRetrySucceeded(ProductInner product = default(ProductInner));

        /// <summary>
        /// Long running put request, service returns a 500, then a 200 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<ProductInner> PutAsyncRelativeRetrySucceededAsync(ProductInner product = default(ProductInner), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Long running delete request, service returns a 500, then a  202 to the initial request, with an entity that
        /// contains ProvisioningState=’Accepted’.  Polls return this value until the last poll returns a ‘200’ with
        /// ProvisioningState=’Succeeded’
        /// </summary>
        ProductInner DeleteProvisioning202Accepted200Succeeded();

        /// <summary>
        /// Long running delete request, service returns a 500, then a  202 to the initial request, with an entity that
        /// contains ProvisioningState=’Accepted’.  Polls return this value until the last poll returns a ‘200’ with
        /// ProvisioningState=’Succeeded’
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<ProductInner> DeleteProvisioning202Accepted200SucceededAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Long running delete request, service returns a 500, then a 202 to the initial request. Polls return this value
        /// until the last poll returns a ‘200’ with ProvisioningState=’Succeeded’
        /// </summary>
        LRORetrysDelete202Retry200HeadersInner Delete202Retry200();

        /// <summary>
        /// Long running delete request, service returns a 500, then a 202 to the initial request. Polls return this value
        /// until the last poll returns a ‘200’ with ProvisioningState=’Succeeded’
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<LRORetrysDelete202Retry200HeadersInner> Delete202Retry200Async(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Long running delete request, service returns a 500, then a 202 to the initial request. Poll the endpoint indicated
        /// in the Azure-AsyncOperation header for operation status
        /// </summary>
        LRORetrysDeleteAsyncRelativeRetrySucceededHeadersInner DeleteAsyncRelativeRetrySucceeded();

        /// <summary>
        /// Long running delete request, service returns a 500, then a 202 to the initial request. Poll the endpoint indicated
        /// in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<LRORetrysDeleteAsyncRelativeRetrySucceededHeadersInner> DeleteAsyncRelativeRetrySucceededAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Long running post request, service returns a 500, then a 202 to the initial request, with 'Location' and
        /// 'Retry-After' headers, Polls return a 200 with a response body after success
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        LRORetrysPost202Retry200HeadersInner Post202Retry200(ProductInner product = default(ProductInner));

        /// <summary>
        /// Long running post request, service returns a 500, then a 202 to the initial request, with 'Location' and
        /// 'Retry-After' headers, Polls return a 200 with a response body after success
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<LRORetrysPost202Retry200HeadersInner> Post202Retry200Async(ProductInner product = default(ProductInner), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Long running post request, service returns a 500, then a 202 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        LRORetrysPostAsyncRelativeRetrySucceededHeadersInner PostAsyncRelativeRetrySucceeded(ProductInner product = default(ProductInner));

        /// <summary>
        /// Long running post request, service returns a 500, then a 202 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<LRORetrysPostAsyncRelativeRetrySucceededHeadersInner> PostAsyncRelativeRetrySucceededAsync(ProductInner product = default(ProductInner), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Long running put request, service returns a 500, then a 201 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’.  Polls return this value until the last poll returns a ‘200’ with
        /// ProvisioningState=’Succeeded’
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        ProductInner BeginPut201CreatingSucceeded200(ProductInner product = default(ProductInner));

        /// <summary>
        /// Long running put request, service returns a 500, then a 201 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’.  Polls return this value until the last poll returns a ‘200’ with
        /// ProvisioningState=’Succeeded’
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<ProductInner> BeginPut201CreatingSucceeded200Async(ProductInner product = default(ProductInner), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Long running put request, service returns a 500, then a 200 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        ProductInner BeginPutAsyncRelativeRetrySucceeded(ProductInner product = default(ProductInner));

        /// <summary>
        /// Long running put request, service returns a 500, then a 200 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<ProductInner> BeginPutAsyncRelativeRetrySucceededAsync(ProductInner product = default(ProductInner), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Long running delete request, service returns a 500, then a  202 to the initial request, with an entity that
        /// contains ProvisioningState=’Accepted’.  Polls return this value until the last poll returns a ‘200’ with
        /// ProvisioningState=’Succeeded’
        /// </summary>
        ProductInner BeginDeleteProvisioning202Accepted200Succeeded();

        /// <summary>
        /// Long running delete request, service returns a 500, then a  202 to the initial request, with an entity that
        /// contains ProvisioningState=’Accepted’.  Polls return this value until the last poll returns a ‘200’ with
        /// ProvisioningState=’Succeeded’
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<ProductInner> BeginDeleteProvisioning202Accepted200SucceededAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Long running delete request, service returns a 500, then a 202 to the initial request. Polls return this value
        /// until the last poll returns a ‘200’ with ProvisioningState=’Succeeded’
        /// </summary>
        LRORetrysDelete202Retry200HeadersInner BeginDelete202Retry200();

        /// <summary>
        /// Long running delete request, service returns a 500, then a 202 to the initial request. Polls return this value
        /// until the last poll returns a ‘200’ with ProvisioningState=’Succeeded’
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<LRORetrysDelete202Retry200HeadersInner> BeginDelete202Retry200Async(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Long running delete request, service returns a 500, then a 202 to the initial request. Poll the endpoint indicated
        /// in the Azure-AsyncOperation header for operation status
        /// </summary>
        LRORetrysDeleteAsyncRelativeRetrySucceededHeadersInner BeginDeleteAsyncRelativeRetrySucceeded();

        /// <summary>
        /// Long running delete request, service returns a 500, then a 202 to the initial request. Poll the endpoint indicated
        /// in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<LRORetrysDeleteAsyncRelativeRetrySucceededHeadersInner> BeginDeleteAsyncRelativeRetrySucceededAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Long running post request, service returns a 500, then a 202 to the initial request, with 'Location' and
        /// 'Retry-After' headers, Polls return a 200 with a response body after success
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        LRORetrysPost202Retry200HeadersInner BeginPost202Retry200(ProductInner product = default(ProductInner));

        /// <summary>
        /// Long running post request, service returns a 500, then a 202 to the initial request, with 'Location' and
        /// 'Retry-After' headers, Polls return a 200 with a response body after success
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<LRORetrysPost202Retry200HeadersInner> BeginPost202Retry200Async(ProductInner product = default(ProductInner), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Long running post request, service returns a 500, then a 202 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        LRORetrysPostAsyncRelativeRetrySucceededHeadersInner BeginPostAsyncRelativeRetrySucceeded(ProductInner product = default(ProductInner));

        /// <summary>
        /// Long running post request, service returns a 500, then a 202 to the initial request, with an entity that contains
        /// ProvisioningState=’Creating’. Poll the endpoint indicated in the Azure-AsyncOperation header for operation status
        /// </summary>
        /// <param name='product'>
        /// Product to put
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<LRORetrysPostAsyncRelativeRetrySucceededHeadersInner> BeginPostAsyncRelativeRetrySucceededAsync(ProductInner product = default(ProductInner), CancellationToken cancellationToken = default(CancellationToken));
    }
}