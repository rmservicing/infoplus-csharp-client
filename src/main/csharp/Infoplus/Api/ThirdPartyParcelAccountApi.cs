using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Infoplus.Client;
using Infoplus.Model;

namespace Infoplus.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IThirdPartyParcelAccountApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Inserts a new thirdPartyParcelAccount using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be inserted.</param>
        /// <returns>ThirdPartyParcelAccount</returns>
        ThirdPartyParcelAccount AddThirdPartyParcelAccount (ThirdPartyParcelAccount body);
  
        /// <summary>
        /// Create a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Inserts a new thirdPartyParcelAccount using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be inserted.</param>
        /// <returns>ApiResponse of ThirdPartyParcelAccount</returns>
        ApiResponse<ThirdPartyParcelAccount> AddThirdPartyParcelAccountWithHttpInfo (ThirdPartyParcelAccount body);
        
        /// <summary>
        /// Add new audit for a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing thirdPartyParcelAccount.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to add an audit to</param>
        /// <param name="thirdPartyParcelAccountAudit">The audit to add</param>
        /// <returns></returns>
        void AddThirdPartyParcelAccountAudit (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountAudit);
  
        /// <summary>
        /// Add new audit for a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing thirdPartyParcelAccount.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to add an audit to</param>
        /// <param name="thirdPartyParcelAccountAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddThirdPartyParcelAccountAuditWithHttpInfo (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountAudit);
        
        /// <summary>
        /// Add new tags for a thirdPartyParcelAccount.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing thirdPartyParcelAccount.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to add a tag to</param>
        /// <param name="thirdPartyParcelAccountTag">The tag to add</param>
        /// <returns></returns>
        void AddThirdPartyParcelAccountTag (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountTag);
  
        /// <summary>
        /// Add new tags for a thirdPartyParcelAccount.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing thirdPartyParcelAccount.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to add a tag to</param>
        /// <param name="thirdPartyParcelAccountTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddThirdPartyParcelAccountTagWithHttpInfo (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountTag);
        
        /// <summary>
        /// Delete a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Deletes the thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be deleted.</param>
        /// <returns></returns>
        void DeleteThirdPartyParcelAccount (int? thirdPartyParcelAccountId);
  
        /// <summary>
        /// Delete a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Deletes the thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteThirdPartyParcelAccountWithHttpInfo (int? thirdPartyParcelAccountId);
        
        /// <summary>
        /// Delete a tag for a thirdPartyParcelAccount.
        /// </summary>
        /// <remarks>
        /// Deletes an existing thirdPartyParcelAccount tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to remove tag from</param>
        /// <param name="thirdPartyParcelAccountTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteThirdPartyParcelAccountTag (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountTag);
  
        /// <summary>
        /// Delete a tag for a thirdPartyParcelAccount.
        /// </summary>
        /// <remarks>
        /// Deletes an existing thirdPartyParcelAccount tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to remove tag from</param>
        /// <param name="thirdPartyParcelAccountTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteThirdPartyParcelAccountTagWithHttpInfo (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountTag);
        
        /// <summary>
        /// Get a duplicated a thirdPartyParcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be duplicated.</param>
        /// <returns>ThirdPartyParcelAccount</returns>
        ThirdPartyParcelAccount GetDuplicateThirdPartyParcelAccountById (int? thirdPartyParcelAccountId);
  
        /// <summary>
        /// Get a duplicated a thirdPartyParcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be duplicated.</param>
        /// <returns>ApiResponse of ThirdPartyParcelAccount</returns>
        ApiResponse<ThirdPartyParcelAccount> GetDuplicateThirdPartyParcelAccountByIdWithHttpInfo (int? thirdPartyParcelAccountId);
        
        /// <summary>
        /// Search thirdPartyParcelAccounts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of thirdPartyParcelAccounts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ThirdPartyParcelAccount&gt;</returns>
        List<ThirdPartyParcelAccount> GetThirdPartyParcelAccountByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search thirdPartyParcelAccounts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of thirdPartyParcelAccounts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ThirdPartyParcelAccount&gt;</returns>
        ApiResponse<List<ThirdPartyParcelAccount>> GetThirdPartyParcelAccountByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a thirdPartyParcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns the thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be returned.</param>
        /// <returns>ThirdPartyParcelAccount</returns>
        ThirdPartyParcelAccount GetThirdPartyParcelAccountById (int? thirdPartyParcelAccountId);
  
        /// <summary>
        /// Get a thirdPartyParcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns the thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be returned.</param>
        /// <returns>ApiResponse of ThirdPartyParcelAccount</returns>
        ApiResponse<ThirdPartyParcelAccount> GetThirdPartyParcelAccountByIdWithHttpInfo (int? thirdPartyParcelAccountId);
        
        /// <summary>
        /// Get the tags for a thirdPartyParcelAccount.
        /// </summary>
        /// <remarks>
        /// Get all existing thirdPartyParcelAccount tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to get tags for</param>
        /// <returns></returns>
        void GetThirdPartyParcelAccountTags (int? thirdPartyParcelAccountId);
  
        /// <summary>
        /// Get the tags for a thirdPartyParcelAccount.
        /// </summary>
        /// <remarks>
        /// Get all existing thirdPartyParcelAccount tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetThirdPartyParcelAccountTagsWithHttpInfo (int? thirdPartyParcelAccountId);
        
        /// <summary>
        /// Update a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Updates an existing thirdPartyParcelAccount using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns></returns>
        void UpdateThirdPartyParcelAccount (ThirdPartyParcelAccount body);
  
        /// <summary>
        /// Update a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Updates an existing thirdPartyParcelAccount using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateThirdPartyParcelAccountWithHttpInfo (ThirdPartyParcelAccount body);
        
        /// <summary>
        /// Update a thirdPartyParcelAccount custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing thirdPartyParcelAccount custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns></returns>
        void UpdateThirdPartyParcelAccountCustomFields (ThirdPartyParcelAccount body);
  
        /// <summary>
        /// Update a thirdPartyParcelAccount custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing thirdPartyParcelAccount custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateThirdPartyParcelAccountCustomFieldsWithHttpInfo (ThirdPartyParcelAccount body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Inserts a new thirdPartyParcelAccount using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be inserted.</param>
        /// <returns>Task of ThirdPartyParcelAccount</returns>
        System.Threading.Tasks.Task<ThirdPartyParcelAccount> AddThirdPartyParcelAccountAsync (ThirdPartyParcelAccount body);

        /// <summary>
        /// Create a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Inserts a new thirdPartyParcelAccount using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be inserted.</param>
        /// <returns>Task of ApiResponse (ThirdPartyParcelAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<ThirdPartyParcelAccount>> AddThirdPartyParcelAccountAsyncWithHttpInfo (ThirdPartyParcelAccount body);
        
        /// <summary>
        /// Add new audit for a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing thirdPartyParcelAccount.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to add an audit to</param>
        /// <param name="thirdPartyParcelAccountAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddThirdPartyParcelAccountAuditAsync (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountAudit);

        /// <summary>
        /// Add new audit for a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing thirdPartyParcelAccount.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to add an audit to</param>
        /// <param name="thirdPartyParcelAccountAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddThirdPartyParcelAccountAuditAsyncWithHttpInfo (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountAudit);
        
        /// <summary>
        /// Add new tags for a thirdPartyParcelAccount.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing thirdPartyParcelAccount.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to add a tag to</param>
        /// <param name="thirdPartyParcelAccountTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddThirdPartyParcelAccountTagAsync (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountTag);

        /// <summary>
        /// Add new tags for a thirdPartyParcelAccount.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing thirdPartyParcelAccount.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to add a tag to</param>
        /// <param name="thirdPartyParcelAccountTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddThirdPartyParcelAccountTagAsyncWithHttpInfo (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountTag);
        
        /// <summary>
        /// Delete a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Deletes the thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteThirdPartyParcelAccountAsync (int? thirdPartyParcelAccountId);

        /// <summary>
        /// Delete a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Deletes the thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteThirdPartyParcelAccountAsyncWithHttpInfo (int? thirdPartyParcelAccountId);
        
        /// <summary>
        /// Delete a tag for a thirdPartyParcelAccount.
        /// </summary>
        /// <remarks>
        /// Deletes an existing thirdPartyParcelAccount tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to remove tag from</param>
        /// <param name="thirdPartyParcelAccountTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteThirdPartyParcelAccountTagAsync (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountTag);

        /// <summary>
        /// Delete a tag for a thirdPartyParcelAccount.
        /// </summary>
        /// <remarks>
        /// Deletes an existing thirdPartyParcelAccount tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to remove tag from</param>
        /// <param name="thirdPartyParcelAccountTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteThirdPartyParcelAccountTagAsyncWithHttpInfo (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountTag);
        
        /// <summary>
        /// Get a duplicated a thirdPartyParcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be duplicated.</param>
        /// <returns>Task of ThirdPartyParcelAccount</returns>
        System.Threading.Tasks.Task<ThirdPartyParcelAccount> GetDuplicateThirdPartyParcelAccountByIdAsync (int? thirdPartyParcelAccountId);

        /// <summary>
        /// Get a duplicated a thirdPartyParcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be duplicated.</param>
        /// <returns>Task of ApiResponse (ThirdPartyParcelAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<ThirdPartyParcelAccount>> GetDuplicateThirdPartyParcelAccountByIdAsyncWithHttpInfo (int? thirdPartyParcelAccountId);
        
        /// <summary>
        /// Search thirdPartyParcelAccounts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of thirdPartyParcelAccounts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ThirdPartyParcelAccount&gt;</returns>
        System.Threading.Tasks.Task<List<ThirdPartyParcelAccount>> GetThirdPartyParcelAccountByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search thirdPartyParcelAccounts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of thirdPartyParcelAccounts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ThirdPartyParcelAccount&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ThirdPartyParcelAccount>>> GetThirdPartyParcelAccountByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a thirdPartyParcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns the thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be returned.</param>
        /// <returns>Task of ThirdPartyParcelAccount</returns>
        System.Threading.Tasks.Task<ThirdPartyParcelAccount> GetThirdPartyParcelAccountByIdAsync (int? thirdPartyParcelAccountId);

        /// <summary>
        /// Get a thirdPartyParcelAccount by id
        /// </summary>
        /// <remarks>
        /// Returns the thirdPartyParcelAccount identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be returned.</param>
        /// <returns>Task of ApiResponse (ThirdPartyParcelAccount)</returns>
        System.Threading.Tasks.Task<ApiResponse<ThirdPartyParcelAccount>> GetThirdPartyParcelAccountByIdAsyncWithHttpInfo (int? thirdPartyParcelAccountId);
        
        /// <summary>
        /// Get the tags for a thirdPartyParcelAccount.
        /// </summary>
        /// <remarks>
        /// Get all existing thirdPartyParcelAccount tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetThirdPartyParcelAccountTagsAsync (int? thirdPartyParcelAccountId);

        /// <summary>
        /// Get the tags for a thirdPartyParcelAccount.
        /// </summary>
        /// <remarks>
        /// Get all existing thirdPartyParcelAccount tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetThirdPartyParcelAccountTagsAsyncWithHttpInfo (int? thirdPartyParcelAccountId);
        
        /// <summary>
        /// Update a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Updates an existing thirdPartyParcelAccount using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateThirdPartyParcelAccountAsync (ThirdPartyParcelAccount body);

        /// <summary>
        /// Update a thirdPartyParcelAccount
        /// </summary>
        /// <remarks>
        /// Updates an existing thirdPartyParcelAccount using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateThirdPartyParcelAccountAsyncWithHttpInfo (ThirdPartyParcelAccount body);
        
        /// <summary>
        /// Update a thirdPartyParcelAccount custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing thirdPartyParcelAccount custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateThirdPartyParcelAccountCustomFieldsAsync (ThirdPartyParcelAccount body);

        /// <summary>
        /// Update a thirdPartyParcelAccount custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing thirdPartyParcelAccount custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateThirdPartyParcelAccountCustomFieldsAsyncWithHttpInfo (ThirdPartyParcelAccount body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ThirdPartyParcelAccountApi : IThirdPartyParcelAccountApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyParcelAccountApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ThirdPartyParcelAccountApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyParcelAccountApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ThirdPartyParcelAccountApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Create a thirdPartyParcelAccount Inserts a new thirdPartyParcelAccount using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be inserted.</param> 
        /// <returns>ThirdPartyParcelAccount</returns>
        public ThirdPartyParcelAccount AddThirdPartyParcelAccount (ThirdPartyParcelAccount body)
        {
             ApiResponse<ThirdPartyParcelAccount> localVarResponse = AddThirdPartyParcelAccountWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a thirdPartyParcelAccount Inserts a new thirdPartyParcelAccount using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be inserted.</param> 
        /// <returns>ApiResponse of ThirdPartyParcelAccount</returns>
        public ApiResponse< ThirdPartyParcelAccount > AddThirdPartyParcelAccountWithHttpInfo (ThirdPartyParcelAccount body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThirdPartyParcelAccountApi->AddThirdPartyParcelAccount");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddThirdPartyParcelAccount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddThirdPartyParcelAccount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ThirdPartyParcelAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ThirdPartyParcelAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ThirdPartyParcelAccount)));
            
        }

        
        /// <summary>
        /// Create a thirdPartyParcelAccount Inserts a new thirdPartyParcelAccount using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be inserted.</param>
        /// <returns>Task of ThirdPartyParcelAccount</returns>
        public async System.Threading.Tasks.Task<ThirdPartyParcelAccount> AddThirdPartyParcelAccountAsync (ThirdPartyParcelAccount body)
        {
             ApiResponse<ThirdPartyParcelAccount> localVarResponse = await AddThirdPartyParcelAccountAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a thirdPartyParcelAccount Inserts a new thirdPartyParcelAccount using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be inserted.</param>
        /// <returns>Task of ApiResponse (ThirdPartyParcelAccount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ThirdPartyParcelAccount>> AddThirdPartyParcelAccountAsyncWithHttpInfo (ThirdPartyParcelAccount body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddThirdPartyParcelAccount");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddThirdPartyParcelAccount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddThirdPartyParcelAccount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ThirdPartyParcelAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ThirdPartyParcelAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ThirdPartyParcelAccount)));
            
        }
        
        /// <summary>
        /// Add new audit for a thirdPartyParcelAccount Adds an audit to an existing thirdPartyParcelAccount.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to add an audit to</param> 
        /// <param name="thirdPartyParcelAccountAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddThirdPartyParcelAccountAudit (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountAudit)
        {
             AddThirdPartyParcelAccountAuditWithHttpInfo(thirdPartyParcelAccountId, thirdPartyParcelAccountAudit);
        }

        /// <summary>
        /// Add new audit for a thirdPartyParcelAccount Adds an audit to an existing thirdPartyParcelAccount.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to add an audit to</param> 
        /// <param name="thirdPartyParcelAccountAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddThirdPartyParcelAccountAuditWithHttpInfo (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountAudit)
        {
            
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null)
                throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling ThirdPartyParcelAccountApi->AddThirdPartyParcelAccountAudit");
            
            // verify the required parameter 'thirdPartyParcelAccountAudit' is set
            if (thirdPartyParcelAccountAudit == null)
                throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountAudit' when calling ThirdPartyParcelAccountApi->AddThirdPartyParcelAccountAudit");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/{thirdPartyParcelAccountId}/audit/{thirdPartyParcelAccountAudit}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            if (thirdPartyParcelAccountAudit != null) localVarPathParams.Add("thirdPartyParcelAccountAudit", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountAudit)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddThirdPartyParcelAccountAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddThirdPartyParcelAccountAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a thirdPartyParcelAccount Adds an audit to an existing thirdPartyParcelAccount.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to add an audit to</param>
        /// <param name="thirdPartyParcelAccountAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddThirdPartyParcelAccountAuditAsync (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountAudit)
        {
             await AddThirdPartyParcelAccountAuditAsyncWithHttpInfo(thirdPartyParcelAccountId, thirdPartyParcelAccountAudit);

        }

        /// <summary>
        /// Add new audit for a thirdPartyParcelAccount Adds an audit to an existing thirdPartyParcelAccount.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to add an audit to</param>
        /// <param name="thirdPartyParcelAccountAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddThirdPartyParcelAccountAuditAsyncWithHttpInfo (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountAudit)
        {
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null) throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling AddThirdPartyParcelAccountAudit");
            // verify the required parameter 'thirdPartyParcelAccountAudit' is set
            if (thirdPartyParcelAccountAudit == null) throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountAudit' when calling AddThirdPartyParcelAccountAudit");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/{thirdPartyParcelAccountId}/audit/{thirdPartyParcelAccountAudit}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            if (thirdPartyParcelAccountAudit != null) localVarPathParams.Add("thirdPartyParcelAccountAudit", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountAudit)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddThirdPartyParcelAccountAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddThirdPartyParcelAccountAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a thirdPartyParcelAccount. Adds a tag to an existing thirdPartyParcelAccount.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to add a tag to</param> 
        /// <param name="thirdPartyParcelAccountTag">The tag to add</param> 
        /// <returns></returns>
        public void AddThirdPartyParcelAccountTag (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountTag)
        {
             AddThirdPartyParcelAccountTagWithHttpInfo(thirdPartyParcelAccountId, thirdPartyParcelAccountTag);
        }

        /// <summary>
        /// Add new tags for a thirdPartyParcelAccount. Adds a tag to an existing thirdPartyParcelAccount.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to add a tag to</param> 
        /// <param name="thirdPartyParcelAccountTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddThirdPartyParcelAccountTagWithHttpInfo (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountTag)
        {
            
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null)
                throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling ThirdPartyParcelAccountApi->AddThirdPartyParcelAccountTag");
            
            // verify the required parameter 'thirdPartyParcelAccountTag' is set
            if (thirdPartyParcelAccountTag == null)
                throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountTag' when calling ThirdPartyParcelAccountApi->AddThirdPartyParcelAccountTag");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/{thirdPartyParcelAccountId}/tag/{thirdPartyParcelAccountTag}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            if (thirdPartyParcelAccountTag != null) localVarPathParams.Add("thirdPartyParcelAccountTag", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountTag)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddThirdPartyParcelAccountTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddThirdPartyParcelAccountTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a thirdPartyParcelAccount. Adds a tag to an existing thirdPartyParcelAccount.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to add a tag to</param>
        /// <param name="thirdPartyParcelAccountTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddThirdPartyParcelAccountTagAsync (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountTag)
        {
             await AddThirdPartyParcelAccountTagAsyncWithHttpInfo(thirdPartyParcelAccountId, thirdPartyParcelAccountTag);

        }

        /// <summary>
        /// Add new tags for a thirdPartyParcelAccount. Adds a tag to an existing thirdPartyParcelAccount.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to add a tag to</param>
        /// <param name="thirdPartyParcelAccountTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddThirdPartyParcelAccountTagAsyncWithHttpInfo (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountTag)
        {
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null) throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling AddThirdPartyParcelAccountTag");
            // verify the required parameter 'thirdPartyParcelAccountTag' is set
            if (thirdPartyParcelAccountTag == null) throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountTag' when calling AddThirdPartyParcelAccountTag");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/{thirdPartyParcelAccountId}/tag/{thirdPartyParcelAccountTag}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            if (thirdPartyParcelAccountTag != null) localVarPathParams.Add("thirdPartyParcelAccountTag", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountTag)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddThirdPartyParcelAccountTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddThirdPartyParcelAccountTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a thirdPartyParcelAccount Deletes the thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be deleted.</param> 
        /// <returns></returns>
        public void DeleteThirdPartyParcelAccount (int? thirdPartyParcelAccountId)
        {
             DeleteThirdPartyParcelAccountWithHttpInfo(thirdPartyParcelAccountId);
        }

        /// <summary>
        /// Delete a thirdPartyParcelAccount Deletes the thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteThirdPartyParcelAccountWithHttpInfo (int? thirdPartyParcelAccountId)
        {
            
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null)
                throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling ThirdPartyParcelAccountApi->DeleteThirdPartyParcelAccount");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/{thirdPartyParcelAccountId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteThirdPartyParcelAccount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteThirdPartyParcelAccount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a thirdPartyParcelAccount Deletes the thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteThirdPartyParcelAccountAsync (int? thirdPartyParcelAccountId)
        {
             await DeleteThirdPartyParcelAccountAsyncWithHttpInfo(thirdPartyParcelAccountId);

        }

        /// <summary>
        /// Delete a thirdPartyParcelAccount Deletes the thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteThirdPartyParcelAccountAsyncWithHttpInfo (int? thirdPartyParcelAccountId)
        {
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null) throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling DeleteThirdPartyParcelAccount");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/{thirdPartyParcelAccountId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteThirdPartyParcelAccount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteThirdPartyParcelAccount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a thirdPartyParcelAccount. Deletes an existing thirdPartyParcelAccount tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to remove tag from</param> 
        /// <param name="thirdPartyParcelAccountTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteThirdPartyParcelAccountTag (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountTag)
        {
             DeleteThirdPartyParcelAccountTagWithHttpInfo(thirdPartyParcelAccountId, thirdPartyParcelAccountTag);
        }

        /// <summary>
        /// Delete a tag for a thirdPartyParcelAccount. Deletes an existing thirdPartyParcelAccount tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to remove tag from</param> 
        /// <param name="thirdPartyParcelAccountTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteThirdPartyParcelAccountTagWithHttpInfo (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountTag)
        {
            
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null)
                throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling ThirdPartyParcelAccountApi->DeleteThirdPartyParcelAccountTag");
            
            // verify the required parameter 'thirdPartyParcelAccountTag' is set
            if (thirdPartyParcelAccountTag == null)
                throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountTag' when calling ThirdPartyParcelAccountApi->DeleteThirdPartyParcelAccountTag");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/{thirdPartyParcelAccountId}/tag/{thirdPartyParcelAccountTag}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            if (thirdPartyParcelAccountTag != null) localVarPathParams.Add("thirdPartyParcelAccountTag", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountTag)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteThirdPartyParcelAccountTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteThirdPartyParcelAccountTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a thirdPartyParcelAccount. Deletes an existing thirdPartyParcelAccount tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to remove tag from</param>
        /// <param name="thirdPartyParcelAccountTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteThirdPartyParcelAccountTagAsync (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountTag)
        {
             await DeleteThirdPartyParcelAccountTagAsyncWithHttpInfo(thirdPartyParcelAccountId, thirdPartyParcelAccountTag);

        }

        /// <summary>
        /// Delete a tag for a thirdPartyParcelAccount. Deletes an existing thirdPartyParcelAccount tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to remove tag from</param>
        /// <param name="thirdPartyParcelAccountTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteThirdPartyParcelAccountTagAsyncWithHttpInfo (int? thirdPartyParcelAccountId, string thirdPartyParcelAccountTag)
        {
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null) throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling DeleteThirdPartyParcelAccountTag");
            // verify the required parameter 'thirdPartyParcelAccountTag' is set
            if (thirdPartyParcelAccountTag == null) throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountTag' when calling DeleteThirdPartyParcelAccountTag");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/{thirdPartyParcelAccountId}/tag/{thirdPartyParcelAccountTag}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            if (thirdPartyParcelAccountTag != null) localVarPathParams.Add("thirdPartyParcelAccountTag", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountTag)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteThirdPartyParcelAccountTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteThirdPartyParcelAccountTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a thirdPartyParcelAccount by id Returns a duplicated thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be duplicated.</param> 
        /// <returns>ThirdPartyParcelAccount</returns>
        public ThirdPartyParcelAccount GetDuplicateThirdPartyParcelAccountById (int? thirdPartyParcelAccountId)
        {
             ApiResponse<ThirdPartyParcelAccount> localVarResponse = GetDuplicateThirdPartyParcelAccountByIdWithHttpInfo(thirdPartyParcelAccountId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a thirdPartyParcelAccount by id Returns a duplicated thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be duplicated.</param> 
        /// <returns>ApiResponse of ThirdPartyParcelAccount</returns>
        public ApiResponse< ThirdPartyParcelAccount > GetDuplicateThirdPartyParcelAccountByIdWithHttpInfo (int? thirdPartyParcelAccountId)
        {
            
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null)
                throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling ThirdPartyParcelAccountApi->GetDuplicateThirdPartyParcelAccountById");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/duplicate/{thirdPartyParcelAccountId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateThirdPartyParcelAccountById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateThirdPartyParcelAccountById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ThirdPartyParcelAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ThirdPartyParcelAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ThirdPartyParcelAccount)));
            
        }

        
        /// <summary>
        /// Get a duplicated a thirdPartyParcelAccount by id Returns a duplicated thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be duplicated.</param>
        /// <returns>Task of ThirdPartyParcelAccount</returns>
        public async System.Threading.Tasks.Task<ThirdPartyParcelAccount> GetDuplicateThirdPartyParcelAccountByIdAsync (int? thirdPartyParcelAccountId)
        {
             ApiResponse<ThirdPartyParcelAccount> localVarResponse = await GetDuplicateThirdPartyParcelAccountByIdAsyncWithHttpInfo(thirdPartyParcelAccountId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a thirdPartyParcelAccount by id Returns a duplicated thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be duplicated.</param>
        /// <returns>Task of ApiResponse (ThirdPartyParcelAccount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ThirdPartyParcelAccount>> GetDuplicateThirdPartyParcelAccountByIdAsyncWithHttpInfo (int? thirdPartyParcelAccountId)
        {
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null) throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling GetDuplicateThirdPartyParcelAccountById");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/duplicate/{thirdPartyParcelAccountId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateThirdPartyParcelAccountById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateThirdPartyParcelAccountById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ThirdPartyParcelAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ThirdPartyParcelAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ThirdPartyParcelAccount)));
            
        }
        
        /// <summary>
        /// Search thirdPartyParcelAccounts by filter Returns the list of thirdPartyParcelAccounts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ThirdPartyParcelAccount&gt;</returns>
        public List<ThirdPartyParcelAccount> GetThirdPartyParcelAccountByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ThirdPartyParcelAccount>> localVarResponse = GetThirdPartyParcelAccountByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search thirdPartyParcelAccounts by filter Returns the list of thirdPartyParcelAccounts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ThirdPartyParcelAccount&gt;</returns>
        public ApiResponse< List<ThirdPartyParcelAccount> > GetThirdPartyParcelAccountByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/search";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ThirdPartyParcelAccount>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ThirdPartyParcelAccount>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ThirdPartyParcelAccount>)));
            
        }

        
        /// <summary>
        /// Search thirdPartyParcelAccounts by filter Returns the list of thirdPartyParcelAccounts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ThirdPartyParcelAccount&gt;</returns>
        public async System.Threading.Tasks.Task<List<ThirdPartyParcelAccount>> GetThirdPartyParcelAccountByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ThirdPartyParcelAccount>> localVarResponse = await GetThirdPartyParcelAccountByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search thirdPartyParcelAccounts by filter Returns the list of thirdPartyParcelAccounts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ThirdPartyParcelAccount&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ThirdPartyParcelAccount>>> GetThirdPartyParcelAccountByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/search";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ThirdPartyParcelAccount>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ThirdPartyParcelAccount>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ThirdPartyParcelAccount>)));
            
        }
        
        /// <summary>
        /// Get a thirdPartyParcelAccount by id Returns the thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be returned.</param> 
        /// <returns>ThirdPartyParcelAccount</returns>
        public ThirdPartyParcelAccount GetThirdPartyParcelAccountById (int? thirdPartyParcelAccountId)
        {
             ApiResponse<ThirdPartyParcelAccount> localVarResponse = GetThirdPartyParcelAccountByIdWithHttpInfo(thirdPartyParcelAccountId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a thirdPartyParcelAccount by id Returns the thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be returned.</param> 
        /// <returns>ApiResponse of ThirdPartyParcelAccount</returns>
        public ApiResponse< ThirdPartyParcelAccount > GetThirdPartyParcelAccountByIdWithHttpInfo (int? thirdPartyParcelAccountId)
        {
            
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null)
                throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling ThirdPartyParcelAccountApi->GetThirdPartyParcelAccountById");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/{thirdPartyParcelAccountId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ThirdPartyParcelAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ThirdPartyParcelAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ThirdPartyParcelAccount)));
            
        }

        
        /// <summary>
        /// Get a thirdPartyParcelAccount by id Returns the thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be returned.</param>
        /// <returns>Task of ThirdPartyParcelAccount</returns>
        public async System.Threading.Tasks.Task<ThirdPartyParcelAccount> GetThirdPartyParcelAccountByIdAsync (int? thirdPartyParcelAccountId)
        {
             ApiResponse<ThirdPartyParcelAccount> localVarResponse = await GetThirdPartyParcelAccountByIdAsyncWithHttpInfo(thirdPartyParcelAccountId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a thirdPartyParcelAccount by id Returns the thirdPartyParcelAccount identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to be returned.</param>
        /// <returns>Task of ApiResponse (ThirdPartyParcelAccount)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ThirdPartyParcelAccount>> GetThirdPartyParcelAccountByIdAsyncWithHttpInfo (int? thirdPartyParcelAccountId)
        {
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null) throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling GetThirdPartyParcelAccountById");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/{thirdPartyParcelAccountId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ThirdPartyParcelAccount>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ThirdPartyParcelAccount) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ThirdPartyParcelAccount)));
            
        }
        
        /// <summary>
        /// Get the tags for a thirdPartyParcelAccount. Get all existing thirdPartyParcelAccount tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to get tags for</param> 
        /// <returns></returns>
        public void GetThirdPartyParcelAccountTags (int? thirdPartyParcelAccountId)
        {
             GetThirdPartyParcelAccountTagsWithHttpInfo(thirdPartyParcelAccountId);
        }

        /// <summary>
        /// Get the tags for a thirdPartyParcelAccount. Get all existing thirdPartyParcelAccount tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetThirdPartyParcelAccountTagsWithHttpInfo (int? thirdPartyParcelAccountId)
        {
            
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null)
                throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling ThirdPartyParcelAccountApi->GetThirdPartyParcelAccountTags");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/{thirdPartyParcelAccountId}/tag";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a thirdPartyParcelAccount. Get all existing thirdPartyParcelAccount tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetThirdPartyParcelAccountTagsAsync (int? thirdPartyParcelAccountId)
        {
             await GetThirdPartyParcelAccountTagsAsyncWithHttpInfo(thirdPartyParcelAccountId);

        }

        /// <summary>
        /// Get the tags for a thirdPartyParcelAccount. Get all existing thirdPartyParcelAccount tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="thirdPartyParcelAccountId">Id of the thirdPartyParcelAccount to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetThirdPartyParcelAccountTagsAsyncWithHttpInfo (int? thirdPartyParcelAccountId)
        {
            // verify the required parameter 'thirdPartyParcelAccountId' is set
            if (thirdPartyParcelAccountId == null) throw new ApiException(400, "Missing required parameter 'thirdPartyParcelAccountId' when calling GetThirdPartyParcelAccountTags");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/{thirdPartyParcelAccountId}/tag";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (thirdPartyParcelAccountId != null) localVarPathParams.Add("thirdPartyParcelAccountId", Configuration.ApiClient.ParameterToString(thirdPartyParcelAccountId)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetThirdPartyParcelAccountTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a thirdPartyParcelAccount Updates an existing thirdPartyParcelAccount using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param> 
        /// <returns></returns>
        public void UpdateThirdPartyParcelAccount (ThirdPartyParcelAccount body)
        {
             UpdateThirdPartyParcelAccountWithHttpInfo(body);
        }

        /// <summary>
        /// Update a thirdPartyParcelAccount Updates an existing thirdPartyParcelAccount using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateThirdPartyParcelAccountWithHttpInfo (ThirdPartyParcelAccount body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThirdPartyParcelAccountApi->UpdateThirdPartyParcelAccount");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateThirdPartyParcelAccount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateThirdPartyParcelAccount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a thirdPartyParcelAccount Updates an existing thirdPartyParcelAccount using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateThirdPartyParcelAccountAsync (ThirdPartyParcelAccount body)
        {
             await UpdateThirdPartyParcelAccountAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a thirdPartyParcelAccount Updates an existing thirdPartyParcelAccount using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateThirdPartyParcelAccountAsyncWithHttpInfo (ThirdPartyParcelAccount body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateThirdPartyParcelAccount");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateThirdPartyParcelAccount: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateThirdPartyParcelAccount: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a thirdPartyParcelAccount custom fields Updates an existing thirdPartyParcelAccount custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param> 
        /// <returns></returns>
        public void UpdateThirdPartyParcelAccountCustomFields (ThirdPartyParcelAccount body)
        {
             UpdateThirdPartyParcelAccountCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a thirdPartyParcelAccount custom fields Updates an existing thirdPartyParcelAccount custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateThirdPartyParcelAccountCustomFieldsWithHttpInfo (ThirdPartyParcelAccount body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ThirdPartyParcelAccountApi->UpdateThirdPartyParcelAccountCustomFields");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/customFields";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateThirdPartyParcelAccountCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateThirdPartyParcelAccountCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a thirdPartyParcelAccount custom fields Updates an existing thirdPartyParcelAccount custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateThirdPartyParcelAccountCustomFieldsAsync (ThirdPartyParcelAccount body)
        {
             await UpdateThirdPartyParcelAccountCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a thirdPartyParcelAccount custom fields Updates an existing thirdPartyParcelAccount custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ThirdPartyParcelAccount to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateThirdPartyParcelAccountCustomFieldsAsyncWithHttpInfo (ThirdPartyParcelAccount body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateThirdPartyParcelAccountCustomFields");
            
    
            var localVarPath = "/beta/thirdPartyParcelAccount/customFields";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateThirdPartyParcelAccountCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateThirdPartyParcelAccountCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
