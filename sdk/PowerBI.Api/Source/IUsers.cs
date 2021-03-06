// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Users operations.
    /// </summary>
    public partial interface IUsers
    {
        /// <summary>
        /// Refreshes user permissions in Power BI.
        /// </summary>
        /// <remarks>
        /// When a user is granted permissions to a workspace, app, or
        /// artifact, it might not be immediately available through API
        /// calls.&lt;br/&gt;This operation refreshes user permissions and
        /// makes sure the user permissions are fully
        /// updated.&lt;br/&gt;&lt;br/&gt;**Important:** Make the *refresh user
        /// permissions* call, before any other API
        /// calls.&lt;br/&gt;&lt;br/&gt;**Required scope:** Workspace.Read.All
        /// or Workspace.ReadWrite.All&lt;br/&gt;To set the permissions scope,
        /// see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// &lt;h2&gt;Restrictions&lt;/h2&gt; User can call this API once per
        /// hour.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> RefreshUserPermissionsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
