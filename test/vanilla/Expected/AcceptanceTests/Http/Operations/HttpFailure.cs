// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsHttp
{
    using Microsoft.Rest;
    using Models;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// HttpFailure operations.
    /// </summary>
    public partial class HttpFailure : IHttpFailure
    {
        /// <summary>
        /// Initializes a new instance of the HttpFailure class.
        /// </summary>
        /// <param name='operationsWithHttpMessages'>
        /// Reference to the low level operations
        /// </param>
        /// <exception cref='System.ArgumentNullException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        public HttpFailure(IHttpFailureWithHttpMessages operationsWithHttpMessages)
        {
            if (operationsWithHttpMessages == null)
            {
                throw new System.ArgumentNullException(nameof(operationsWithHttpMessages));
            }
            OperationsWithHttpMessages = operationsWithHttpMessages;
        }

        private IHttpFailureWithHttpMessages OperationsWithHttpMessages { get; set; }

        public IHttpFailureWithHttpMessages WithHttpMessages()
        {
            return OperationsWithHttpMessages;
        }

        /// <summary>
        /// Get empty error form server
        /// </summary>
        public bool? GetEmptyError()
        {
            return GetEmptyErrorAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get empty error form server
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<bool?> GetEmptyErrorAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetEmptyErrorAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Get empty error form server
        /// </summary>
        public bool? GetNoModelError()
        {
            return GetNoModelErrorAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get empty error form server
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<bool?> GetNoModelErrorAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetNoModelErrorAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Get empty response from server
        /// </summary>
        public bool? GetNoModelEmpty()
        {
            return GetNoModelEmptyAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get empty response from server
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<bool?> GetNoModelEmptyAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetNoModelEmptyAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}