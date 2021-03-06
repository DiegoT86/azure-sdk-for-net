// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProvidersOperations.
    /// </summary>
    public static partial class ProvidersOperationsExtensions
    {
            /// <summary>
            /// Unregisters a subscription from a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider to unregister.
            /// </param>
            public static Provider Unregister(this IProvidersOperations operations, string resourceProviderNamespace)
            {
                return operations.UnregisterAsync(resourceProviderNamespace).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Unregisters a subscription from a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider to unregister.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Provider> UnregisterAsync(this IProvidersOperations operations, string resourceProviderNamespace, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UnregisterWithHttpMessagesAsync(resourceProviderNamespace, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Registers a management group with a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider to register.
            /// </param>
            /// <param name='groupId'>
            /// The management group ID.
            /// </param>
            public static void RegisterAtManagementGroupScope(this IProvidersOperations operations, string resourceProviderNamespace, string groupId)
            {
                operations.RegisterAtManagementGroupScopeAsync(resourceProviderNamespace, groupId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Registers a management group with a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider to register.
            /// </param>
            /// <param name='groupId'>
            /// The management group ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RegisterAtManagementGroupScopeAsync(this IProvidersOperations operations, string resourceProviderNamespace, string groupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RegisterAtManagementGroupScopeWithHttpMessagesAsync(resourceProviderNamespace, groupId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Registers a subscription with a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider to register.
            /// </param>
            public static Provider Register(this IProvidersOperations operations, string resourceProviderNamespace)
            {
                return operations.RegisterAsync(resourceProviderNamespace).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Registers a subscription with a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider to register.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Provider> RegisterAsync(this IProvidersOperations operations, string resourceProviderNamespace, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegisterWithHttpMessagesAsync(resourceProviderNamespace, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all resource providers for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The number of results to return. If null is passed returns all deployments.
            /// </param>
            /// <param name='expand'>
            /// The properties to include in the results. For example, use
            /// &amp;$expand=metadata in the query string to retrieve resource provider
            /// metadata. To include property aliases in response, use
            /// $expand=resourceTypes/aliases.
            /// </param>
            public static IPage<Provider> List(this IProvidersOperations operations, int? top = default(int?), string expand = default(string))
            {
                return operations.ListAsync(top, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all resource providers for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The number of results to return. If null is passed returns all deployments.
            /// </param>
            /// <param name='expand'>
            /// The properties to include in the results. For example, use
            /// &amp;$expand=metadata in the query string to retrieve resource provider
            /// metadata. To include property aliases in response, use
            /// $expand=resourceTypes/aliases.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Provider>> ListAsync(this IProvidersOperations operations, int? top = default(int?), string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(top, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all resource providers for the tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The number of results to return. If null is passed returns all providers.
            /// </param>
            /// <param name='expand'>
            /// The properties to include in the results. For example, use
            /// &amp;$expand=metadata in the query string to retrieve resource provider
            /// metadata. To include property aliases in response, use
            /// $expand=resourceTypes/aliases.
            /// </param>
            public static IPage<Provider> ListAtTenantScope(this IProvidersOperations operations, int? top = default(int?), string expand = default(string))
            {
                return operations.ListAtTenantScopeAsync(top, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all resource providers for the tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The number of results to return. If null is passed returns all providers.
            /// </param>
            /// <param name='expand'>
            /// The properties to include in the results. For example, use
            /// &amp;$expand=metadata in the query string to retrieve resource provider
            /// metadata. To include property aliases in response, use
            /// $expand=resourceTypes/aliases.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Provider>> ListAtTenantScopeAsync(this IProvidersOperations operations, int? top = default(int?), string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAtTenantScopeWithHttpMessagesAsync(top, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='expand'>
            /// The $expand query parameter. For example, to include property aliases in
            /// response, use $expand=resourceTypes/aliases.
            /// </param>
            public static Provider Get(this IProvidersOperations operations, string resourceProviderNamespace, string expand = default(string))
            {
                return operations.GetAsync(resourceProviderNamespace, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='expand'>
            /// The $expand query parameter. For example, to include property aliases in
            /// response, use $expand=resourceTypes/aliases.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Provider> GetAsync(this IProvidersOperations operations, string resourceProviderNamespace, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceProviderNamespace, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified resource provider at the tenant level.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='expand'>
            /// The $expand query parameter. For example, to include property aliases in
            /// response, use $expand=resourceTypes/aliases.
            /// </param>
            public static Provider GetAtTenantScope(this IProvidersOperations operations, string resourceProviderNamespace, string expand = default(string))
            {
                return operations.GetAtTenantScopeAsync(resourceProviderNamespace, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified resource provider at the tenant level.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='expand'>
            /// The $expand query parameter. For example, to include property aliases in
            /// response, use $expand=resourceTypes/aliases.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Provider> GetAtTenantScopeAsync(this IProvidersOperations operations, string resourceProviderNamespace, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAtTenantScopeWithHttpMessagesAsync(resourceProviderNamespace, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all resource providers for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Provider> ListNext(this IProvidersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all resource providers for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Provider>> ListNextAsync(this IProvidersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all resource providers for the tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Provider> ListAtTenantScopeNext(this IProvidersOperations operations, string nextPageLink)
            {
                return operations.ListAtTenantScopeNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all resource providers for the tenant.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Provider>> ListAtTenantScopeNextAsync(this IProvidersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAtTenantScopeNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
