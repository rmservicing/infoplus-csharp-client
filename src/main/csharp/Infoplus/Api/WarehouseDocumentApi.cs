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
    public interface IWarehouseDocumentApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for a warehouseDocument
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing warehouseDocument.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to add an audit to</param>
        /// <param name="warehouseDocumentAudit">The audit to add</param>
        /// <returns></returns>
        void AddWarehouseDocumentAudit (int? warehouseDocumentId, string warehouseDocumentAudit);
  
        /// <summary>
        /// Add new audit for a warehouseDocument
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing warehouseDocument.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to add an audit to</param>
        /// <param name="warehouseDocumentAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddWarehouseDocumentAuditWithHttpInfo (int? warehouseDocumentId, string warehouseDocumentAudit);
        
        /// <summary>
        /// Add new tags for a warehouseDocument.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing warehouseDocument.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to add a tag to</param>
        /// <param name="warehouseDocumentTag">The tag to add</param>
        /// <returns></returns>
        void AddWarehouseDocumentTag (int? warehouseDocumentId, string warehouseDocumentTag);
  
        /// <summary>
        /// Add new tags for a warehouseDocument.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing warehouseDocument.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to add a tag to</param>
        /// <param name="warehouseDocumentTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddWarehouseDocumentTagWithHttpInfo (int? warehouseDocumentId, string warehouseDocumentTag);
        
        /// <summary>
        /// Delete a tag for a warehouseDocument.
        /// </summary>
        /// <remarks>
        /// Deletes an existing warehouseDocument tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to remove tag from</param>
        /// <param name="warehouseDocumentTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteWarehouseDocumentTag (int? warehouseDocumentId, string warehouseDocumentTag);
  
        /// <summary>
        /// Delete a tag for a warehouseDocument.
        /// </summary>
        /// <remarks>
        /// Deletes an existing warehouseDocument tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to remove tag from</param>
        /// <param name="warehouseDocumentTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWarehouseDocumentTagWithHttpInfo (int? warehouseDocumentId, string warehouseDocumentTag);
        
        /// <summary>
        /// Get a duplicated a warehouseDocument by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated warehouseDocument identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be duplicated.</param>
        /// <returns>WarehouseDocument</returns>
        WarehouseDocument GetDuplicateWarehouseDocumentById (int? warehouseDocumentId);
  
        /// <summary>
        /// Get a duplicated a warehouseDocument by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated warehouseDocument identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be duplicated.</param>
        /// <returns>ApiResponse of WarehouseDocument</returns>
        ApiResponse<WarehouseDocument> GetDuplicateWarehouseDocumentByIdWithHttpInfo (int? warehouseDocumentId);
        
        /// <summary>
        /// Search warehouseDocuments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of warehouseDocuments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;WarehouseDocument&gt;</returns>
        List<WarehouseDocument> GetWarehouseDocumentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search warehouseDocuments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of warehouseDocuments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;WarehouseDocument&gt;</returns>
        ApiResponse<List<WarehouseDocument>> GetWarehouseDocumentByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a warehouseDocument by id
        /// </summary>
        /// <remarks>
        /// Returns the warehouseDocument identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be returned.</param>
        /// <returns>WarehouseDocument</returns>
        WarehouseDocument GetWarehouseDocumentById (int? warehouseDocumentId);
  
        /// <summary>
        /// Get a warehouseDocument by id
        /// </summary>
        /// <remarks>
        /// Returns the warehouseDocument identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be returned.</param>
        /// <returns>ApiResponse of WarehouseDocument</returns>
        ApiResponse<WarehouseDocument> GetWarehouseDocumentByIdWithHttpInfo (int? warehouseDocumentId);
        
        /// <summary>
        /// Get the tags for a warehouseDocument.
        /// </summary>
        /// <remarks>
        /// Get all existing warehouseDocument tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to get tags for</param>
        /// <returns></returns>
        void GetWarehouseDocumentTags (int? warehouseDocumentId);
  
        /// <summary>
        /// Get the tags for a warehouseDocument.
        /// </summary>
        /// <remarks>
        /// Get all existing warehouseDocument tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetWarehouseDocumentTagsWithHttpInfo (int? warehouseDocumentId);
        
        /// <summary>
        /// Update a warehouseDocument custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing warehouseDocument custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WarehouseDocument to be updated.</param>
        /// <returns></returns>
        void UpdateWarehouseDocumentCustomFields (WarehouseDocument body);
  
        /// <summary>
        /// Update a warehouseDocument custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing warehouseDocument custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WarehouseDocument to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateWarehouseDocumentCustomFieldsWithHttpInfo (WarehouseDocument body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for a warehouseDocument
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing warehouseDocument.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to add an audit to</param>
        /// <param name="warehouseDocumentAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddWarehouseDocumentAuditAsync (int? warehouseDocumentId, string warehouseDocumentAudit);

        /// <summary>
        /// Add new audit for a warehouseDocument
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing warehouseDocument.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to add an audit to</param>
        /// <param name="warehouseDocumentAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddWarehouseDocumentAuditAsyncWithHttpInfo (int? warehouseDocumentId, string warehouseDocumentAudit);
        
        /// <summary>
        /// Add new tags for a warehouseDocument.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing warehouseDocument.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to add a tag to</param>
        /// <param name="warehouseDocumentTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddWarehouseDocumentTagAsync (int? warehouseDocumentId, string warehouseDocumentTag);

        /// <summary>
        /// Add new tags for a warehouseDocument.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing warehouseDocument.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to add a tag to</param>
        /// <param name="warehouseDocumentTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddWarehouseDocumentTagAsyncWithHttpInfo (int? warehouseDocumentId, string warehouseDocumentTag);
        
        /// <summary>
        /// Delete a tag for a warehouseDocument.
        /// </summary>
        /// <remarks>
        /// Deletes an existing warehouseDocument tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to remove tag from</param>
        /// <param name="warehouseDocumentTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteWarehouseDocumentTagAsync (int? warehouseDocumentId, string warehouseDocumentTag);

        /// <summary>
        /// Delete a tag for a warehouseDocument.
        /// </summary>
        /// <remarks>
        /// Deletes an existing warehouseDocument tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to remove tag from</param>
        /// <param name="warehouseDocumentTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWarehouseDocumentTagAsyncWithHttpInfo (int? warehouseDocumentId, string warehouseDocumentTag);
        
        /// <summary>
        /// Get a duplicated a warehouseDocument by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated warehouseDocument identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be duplicated.</param>
        /// <returns>Task of WarehouseDocument</returns>
        System.Threading.Tasks.Task<WarehouseDocument> GetDuplicateWarehouseDocumentByIdAsync (int? warehouseDocumentId);

        /// <summary>
        /// Get a duplicated a warehouseDocument by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated warehouseDocument identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be duplicated.</param>
        /// <returns>Task of ApiResponse (WarehouseDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<WarehouseDocument>> GetDuplicateWarehouseDocumentByIdAsyncWithHttpInfo (int? warehouseDocumentId);
        
        /// <summary>
        /// Search warehouseDocuments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of warehouseDocuments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;WarehouseDocument&gt;</returns>
        System.Threading.Tasks.Task<List<WarehouseDocument>> GetWarehouseDocumentByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search warehouseDocuments by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of warehouseDocuments that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WarehouseDocument&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<WarehouseDocument>>> GetWarehouseDocumentByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a warehouseDocument by id
        /// </summary>
        /// <remarks>
        /// Returns the warehouseDocument identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be returned.</param>
        /// <returns>Task of WarehouseDocument</returns>
        System.Threading.Tasks.Task<WarehouseDocument> GetWarehouseDocumentByIdAsync (int? warehouseDocumentId);

        /// <summary>
        /// Get a warehouseDocument by id
        /// </summary>
        /// <remarks>
        /// Returns the warehouseDocument identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be returned.</param>
        /// <returns>Task of ApiResponse (WarehouseDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<WarehouseDocument>> GetWarehouseDocumentByIdAsyncWithHttpInfo (int? warehouseDocumentId);
        
        /// <summary>
        /// Get the tags for a warehouseDocument.
        /// </summary>
        /// <remarks>
        /// Get all existing warehouseDocument tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetWarehouseDocumentTagsAsync (int? warehouseDocumentId);

        /// <summary>
        /// Get the tags for a warehouseDocument.
        /// </summary>
        /// <remarks>
        /// Get all existing warehouseDocument tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetWarehouseDocumentTagsAsyncWithHttpInfo (int? warehouseDocumentId);
        
        /// <summary>
        /// Update a warehouseDocument custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing warehouseDocument custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WarehouseDocument to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateWarehouseDocumentCustomFieldsAsync (WarehouseDocument body);

        /// <summary>
        /// Update a warehouseDocument custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing warehouseDocument custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WarehouseDocument to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateWarehouseDocumentCustomFieldsAsyncWithHttpInfo (WarehouseDocument body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WarehouseDocumentApi : IWarehouseDocumentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseDocumentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WarehouseDocumentApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WarehouseDocumentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WarehouseDocumentApi(Configuration configuration = null)
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
        /// Add new audit for a warehouseDocument Adds an audit to an existing warehouseDocument.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to add an audit to</param> 
        /// <param name="warehouseDocumentAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddWarehouseDocumentAudit (int? warehouseDocumentId, string warehouseDocumentAudit)
        {
             AddWarehouseDocumentAuditWithHttpInfo(warehouseDocumentId, warehouseDocumentAudit);
        }

        /// <summary>
        /// Add new audit for a warehouseDocument Adds an audit to an existing warehouseDocument.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to add an audit to</param> 
        /// <param name="warehouseDocumentAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddWarehouseDocumentAuditWithHttpInfo (int? warehouseDocumentId, string warehouseDocumentAudit)
        {
            
            // verify the required parameter 'warehouseDocumentId' is set
            if (warehouseDocumentId == null)
                throw new ApiException(400, "Missing required parameter 'warehouseDocumentId' when calling WarehouseDocumentApi->AddWarehouseDocumentAudit");
            
            // verify the required parameter 'warehouseDocumentAudit' is set
            if (warehouseDocumentAudit == null)
                throw new ApiException(400, "Missing required parameter 'warehouseDocumentAudit' when calling WarehouseDocumentApi->AddWarehouseDocumentAudit");
            
    
            var localVarPath = "/beta/warehouseDocument/{warehouseDocumentId}/audit/{warehouseDocumentAudit}";
    
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
            if (warehouseDocumentId != null) localVarPathParams.Add("warehouseDocumentId", Configuration.ApiClient.ParameterToString(warehouseDocumentId)); // path parameter
            if (warehouseDocumentAudit != null) localVarPathParams.Add("warehouseDocumentAudit", Configuration.ApiClient.ParameterToString(warehouseDocumentAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddWarehouseDocumentAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddWarehouseDocumentAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a warehouseDocument Adds an audit to an existing warehouseDocument.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to add an audit to</param>
        /// <param name="warehouseDocumentAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddWarehouseDocumentAuditAsync (int? warehouseDocumentId, string warehouseDocumentAudit)
        {
             await AddWarehouseDocumentAuditAsyncWithHttpInfo(warehouseDocumentId, warehouseDocumentAudit);

        }

        /// <summary>
        /// Add new audit for a warehouseDocument Adds an audit to an existing warehouseDocument.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to add an audit to</param>
        /// <param name="warehouseDocumentAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddWarehouseDocumentAuditAsyncWithHttpInfo (int? warehouseDocumentId, string warehouseDocumentAudit)
        {
            // verify the required parameter 'warehouseDocumentId' is set
            if (warehouseDocumentId == null) throw new ApiException(400, "Missing required parameter 'warehouseDocumentId' when calling AddWarehouseDocumentAudit");
            // verify the required parameter 'warehouseDocumentAudit' is set
            if (warehouseDocumentAudit == null) throw new ApiException(400, "Missing required parameter 'warehouseDocumentAudit' when calling AddWarehouseDocumentAudit");
            
    
            var localVarPath = "/beta/warehouseDocument/{warehouseDocumentId}/audit/{warehouseDocumentAudit}";
    
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
            if (warehouseDocumentId != null) localVarPathParams.Add("warehouseDocumentId", Configuration.ApiClient.ParameterToString(warehouseDocumentId)); // path parameter
            if (warehouseDocumentAudit != null) localVarPathParams.Add("warehouseDocumentAudit", Configuration.ApiClient.ParameterToString(warehouseDocumentAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddWarehouseDocumentAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddWarehouseDocumentAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a warehouseDocument. Adds a tag to an existing warehouseDocument.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to add a tag to</param> 
        /// <param name="warehouseDocumentTag">The tag to add</param> 
        /// <returns></returns>
        public void AddWarehouseDocumentTag (int? warehouseDocumentId, string warehouseDocumentTag)
        {
             AddWarehouseDocumentTagWithHttpInfo(warehouseDocumentId, warehouseDocumentTag);
        }

        /// <summary>
        /// Add new tags for a warehouseDocument. Adds a tag to an existing warehouseDocument.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to add a tag to</param> 
        /// <param name="warehouseDocumentTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddWarehouseDocumentTagWithHttpInfo (int? warehouseDocumentId, string warehouseDocumentTag)
        {
            
            // verify the required parameter 'warehouseDocumentId' is set
            if (warehouseDocumentId == null)
                throw new ApiException(400, "Missing required parameter 'warehouseDocumentId' when calling WarehouseDocumentApi->AddWarehouseDocumentTag");
            
            // verify the required parameter 'warehouseDocumentTag' is set
            if (warehouseDocumentTag == null)
                throw new ApiException(400, "Missing required parameter 'warehouseDocumentTag' when calling WarehouseDocumentApi->AddWarehouseDocumentTag");
            
    
            var localVarPath = "/beta/warehouseDocument/{warehouseDocumentId}/tag/{warehouseDocumentTag}";
    
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
            if (warehouseDocumentId != null) localVarPathParams.Add("warehouseDocumentId", Configuration.ApiClient.ParameterToString(warehouseDocumentId)); // path parameter
            if (warehouseDocumentTag != null) localVarPathParams.Add("warehouseDocumentTag", Configuration.ApiClient.ParameterToString(warehouseDocumentTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddWarehouseDocumentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddWarehouseDocumentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a warehouseDocument. Adds a tag to an existing warehouseDocument.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to add a tag to</param>
        /// <param name="warehouseDocumentTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddWarehouseDocumentTagAsync (int? warehouseDocumentId, string warehouseDocumentTag)
        {
             await AddWarehouseDocumentTagAsyncWithHttpInfo(warehouseDocumentId, warehouseDocumentTag);

        }

        /// <summary>
        /// Add new tags for a warehouseDocument. Adds a tag to an existing warehouseDocument.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to add a tag to</param>
        /// <param name="warehouseDocumentTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddWarehouseDocumentTagAsyncWithHttpInfo (int? warehouseDocumentId, string warehouseDocumentTag)
        {
            // verify the required parameter 'warehouseDocumentId' is set
            if (warehouseDocumentId == null) throw new ApiException(400, "Missing required parameter 'warehouseDocumentId' when calling AddWarehouseDocumentTag");
            // verify the required parameter 'warehouseDocumentTag' is set
            if (warehouseDocumentTag == null) throw new ApiException(400, "Missing required parameter 'warehouseDocumentTag' when calling AddWarehouseDocumentTag");
            
    
            var localVarPath = "/beta/warehouseDocument/{warehouseDocumentId}/tag/{warehouseDocumentTag}";
    
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
            if (warehouseDocumentId != null) localVarPathParams.Add("warehouseDocumentId", Configuration.ApiClient.ParameterToString(warehouseDocumentId)); // path parameter
            if (warehouseDocumentTag != null) localVarPathParams.Add("warehouseDocumentTag", Configuration.ApiClient.ParameterToString(warehouseDocumentTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddWarehouseDocumentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddWarehouseDocumentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a warehouseDocument. Deletes an existing warehouseDocument tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to remove tag from</param> 
        /// <param name="warehouseDocumentTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteWarehouseDocumentTag (int? warehouseDocumentId, string warehouseDocumentTag)
        {
             DeleteWarehouseDocumentTagWithHttpInfo(warehouseDocumentId, warehouseDocumentTag);
        }

        /// <summary>
        /// Delete a tag for a warehouseDocument. Deletes an existing warehouseDocument tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to remove tag from</param> 
        /// <param name="warehouseDocumentTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWarehouseDocumentTagWithHttpInfo (int? warehouseDocumentId, string warehouseDocumentTag)
        {
            
            // verify the required parameter 'warehouseDocumentId' is set
            if (warehouseDocumentId == null)
                throw new ApiException(400, "Missing required parameter 'warehouseDocumentId' when calling WarehouseDocumentApi->DeleteWarehouseDocumentTag");
            
            // verify the required parameter 'warehouseDocumentTag' is set
            if (warehouseDocumentTag == null)
                throw new ApiException(400, "Missing required parameter 'warehouseDocumentTag' when calling WarehouseDocumentApi->DeleteWarehouseDocumentTag");
            
    
            var localVarPath = "/beta/warehouseDocument/{warehouseDocumentId}/tag/{warehouseDocumentTag}";
    
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
            if (warehouseDocumentId != null) localVarPathParams.Add("warehouseDocumentId", Configuration.ApiClient.ParameterToString(warehouseDocumentId)); // path parameter
            if (warehouseDocumentTag != null) localVarPathParams.Add("warehouseDocumentTag", Configuration.ApiClient.ParameterToString(warehouseDocumentTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteWarehouseDocumentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWarehouseDocumentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a warehouseDocument. Deletes an existing warehouseDocument tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to remove tag from</param>
        /// <param name="warehouseDocumentTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteWarehouseDocumentTagAsync (int? warehouseDocumentId, string warehouseDocumentTag)
        {
             await DeleteWarehouseDocumentTagAsyncWithHttpInfo(warehouseDocumentId, warehouseDocumentTag);

        }

        /// <summary>
        /// Delete a tag for a warehouseDocument. Deletes an existing warehouseDocument tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to remove tag from</param>
        /// <param name="warehouseDocumentTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWarehouseDocumentTagAsyncWithHttpInfo (int? warehouseDocumentId, string warehouseDocumentTag)
        {
            // verify the required parameter 'warehouseDocumentId' is set
            if (warehouseDocumentId == null) throw new ApiException(400, "Missing required parameter 'warehouseDocumentId' when calling DeleteWarehouseDocumentTag");
            // verify the required parameter 'warehouseDocumentTag' is set
            if (warehouseDocumentTag == null) throw new ApiException(400, "Missing required parameter 'warehouseDocumentTag' when calling DeleteWarehouseDocumentTag");
            
    
            var localVarPath = "/beta/warehouseDocument/{warehouseDocumentId}/tag/{warehouseDocumentTag}";
    
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
            if (warehouseDocumentId != null) localVarPathParams.Add("warehouseDocumentId", Configuration.ApiClient.ParameterToString(warehouseDocumentId)); // path parameter
            if (warehouseDocumentTag != null) localVarPathParams.Add("warehouseDocumentTag", Configuration.ApiClient.ParameterToString(warehouseDocumentTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteWarehouseDocumentTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteWarehouseDocumentTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a warehouseDocument by id Returns a duplicated warehouseDocument identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be duplicated.</param> 
        /// <returns>WarehouseDocument</returns>
        public WarehouseDocument GetDuplicateWarehouseDocumentById (int? warehouseDocumentId)
        {
             ApiResponse<WarehouseDocument> localVarResponse = GetDuplicateWarehouseDocumentByIdWithHttpInfo(warehouseDocumentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a warehouseDocument by id Returns a duplicated warehouseDocument identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be duplicated.</param> 
        /// <returns>ApiResponse of WarehouseDocument</returns>
        public ApiResponse< WarehouseDocument > GetDuplicateWarehouseDocumentByIdWithHttpInfo (int? warehouseDocumentId)
        {
            
            // verify the required parameter 'warehouseDocumentId' is set
            if (warehouseDocumentId == null)
                throw new ApiException(400, "Missing required parameter 'warehouseDocumentId' when calling WarehouseDocumentApi->GetDuplicateWarehouseDocumentById");
            
    
            var localVarPath = "/beta/warehouseDocument/duplicate/{warehouseDocumentId}";
    
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
            if (warehouseDocumentId != null) localVarPathParams.Add("warehouseDocumentId", Configuration.ApiClient.ParameterToString(warehouseDocumentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateWarehouseDocumentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateWarehouseDocumentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WarehouseDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WarehouseDocument) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WarehouseDocument)));
            
        }

        
        /// <summary>
        /// Get a duplicated a warehouseDocument by id Returns a duplicated warehouseDocument identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be duplicated.</param>
        /// <returns>Task of WarehouseDocument</returns>
        public async System.Threading.Tasks.Task<WarehouseDocument> GetDuplicateWarehouseDocumentByIdAsync (int? warehouseDocumentId)
        {
             ApiResponse<WarehouseDocument> localVarResponse = await GetDuplicateWarehouseDocumentByIdAsyncWithHttpInfo(warehouseDocumentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a warehouseDocument by id Returns a duplicated warehouseDocument identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be duplicated.</param>
        /// <returns>Task of ApiResponse (WarehouseDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WarehouseDocument>> GetDuplicateWarehouseDocumentByIdAsyncWithHttpInfo (int? warehouseDocumentId)
        {
            // verify the required parameter 'warehouseDocumentId' is set
            if (warehouseDocumentId == null) throw new ApiException(400, "Missing required parameter 'warehouseDocumentId' when calling GetDuplicateWarehouseDocumentById");
            
    
            var localVarPath = "/beta/warehouseDocument/duplicate/{warehouseDocumentId}";
    
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
            if (warehouseDocumentId != null) localVarPathParams.Add("warehouseDocumentId", Configuration.ApiClient.ParameterToString(warehouseDocumentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateWarehouseDocumentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateWarehouseDocumentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WarehouseDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WarehouseDocument) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WarehouseDocument)));
            
        }
        
        /// <summary>
        /// Search warehouseDocuments by filter Returns the list of warehouseDocuments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;WarehouseDocument&gt;</returns>
        public List<WarehouseDocument> GetWarehouseDocumentByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<WarehouseDocument>> localVarResponse = GetWarehouseDocumentByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search warehouseDocuments by filter Returns the list of warehouseDocuments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;WarehouseDocument&gt;</returns>
        public ApiResponse< List<WarehouseDocument> > GetWarehouseDocumentByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/warehouseDocument/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<WarehouseDocument>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WarehouseDocument>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WarehouseDocument>)));
            
        }

        
        /// <summary>
        /// Search warehouseDocuments by filter Returns the list of warehouseDocuments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;WarehouseDocument&gt;</returns>
        public async System.Threading.Tasks.Task<List<WarehouseDocument>> GetWarehouseDocumentByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<WarehouseDocument>> localVarResponse = await GetWarehouseDocumentByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search warehouseDocuments by filter Returns the list of warehouseDocuments that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;WarehouseDocument&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<WarehouseDocument>>> GetWarehouseDocumentByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/warehouseDocument/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<WarehouseDocument>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<WarehouseDocument>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<WarehouseDocument>)));
            
        }
        
        /// <summary>
        /// Get a warehouseDocument by id Returns the warehouseDocument identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be returned.</param> 
        /// <returns>WarehouseDocument</returns>
        public WarehouseDocument GetWarehouseDocumentById (int? warehouseDocumentId)
        {
             ApiResponse<WarehouseDocument> localVarResponse = GetWarehouseDocumentByIdWithHttpInfo(warehouseDocumentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a warehouseDocument by id Returns the warehouseDocument identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be returned.</param> 
        /// <returns>ApiResponse of WarehouseDocument</returns>
        public ApiResponse< WarehouseDocument > GetWarehouseDocumentByIdWithHttpInfo (int? warehouseDocumentId)
        {
            
            // verify the required parameter 'warehouseDocumentId' is set
            if (warehouseDocumentId == null)
                throw new ApiException(400, "Missing required parameter 'warehouseDocumentId' when calling WarehouseDocumentApi->GetWarehouseDocumentById");
            
    
            var localVarPath = "/beta/warehouseDocument/{warehouseDocumentId}";
    
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
            if (warehouseDocumentId != null) localVarPathParams.Add("warehouseDocumentId", Configuration.ApiClient.ParameterToString(warehouseDocumentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<WarehouseDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WarehouseDocument) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WarehouseDocument)));
            
        }

        
        /// <summary>
        /// Get a warehouseDocument by id Returns the warehouseDocument identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be returned.</param>
        /// <returns>Task of WarehouseDocument</returns>
        public async System.Threading.Tasks.Task<WarehouseDocument> GetWarehouseDocumentByIdAsync (int? warehouseDocumentId)
        {
             ApiResponse<WarehouseDocument> localVarResponse = await GetWarehouseDocumentByIdAsyncWithHttpInfo(warehouseDocumentId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a warehouseDocument by id Returns the warehouseDocument identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to be returned.</param>
        /// <returns>Task of ApiResponse (WarehouseDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WarehouseDocument>> GetWarehouseDocumentByIdAsyncWithHttpInfo (int? warehouseDocumentId)
        {
            // verify the required parameter 'warehouseDocumentId' is set
            if (warehouseDocumentId == null) throw new ApiException(400, "Missing required parameter 'warehouseDocumentId' when calling GetWarehouseDocumentById");
            
    
            var localVarPath = "/beta/warehouseDocument/{warehouseDocumentId}";
    
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
            if (warehouseDocumentId != null) localVarPathParams.Add("warehouseDocumentId", Configuration.ApiClient.ParameterToString(warehouseDocumentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<WarehouseDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WarehouseDocument) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WarehouseDocument)));
            
        }
        
        /// <summary>
        /// Get the tags for a warehouseDocument. Get all existing warehouseDocument tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to get tags for</param> 
        /// <returns></returns>
        public void GetWarehouseDocumentTags (int? warehouseDocumentId)
        {
             GetWarehouseDocumentTagsWithHttpInfo(warehouseDocumentId);
        }

        /// <summary>
        /// Get the tags for a warehouseDocument. Get all existing warehouseDocument tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetWarehouseDocumentTagsWithHttpInfo (int? warehouseDocumentId)
        {
            
            // verify the required parameter 'warehouseDocumentId' is set
            if (warehouseDocumentId == null)
                throw new ApiException(400, "Missing required parameter 'warehouseDocumentId' when calling WarehouseDocumentApi->GetWarehouseDocumentTags");
            
    
            var localVarPath = "/beta/warehouseDocument/{warehouseDocumentId}/tag";
    
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
            if (warehouseDocumentId != null) localVarPathParams.Add("warehouseDocumentId", Configuration.ApiClient.ParameterToString(warehouseDocumentId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a warehouseDocument. Get all existing warehouseDocument tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetWarehouseDocumentTagsAsync (int? warehouseDocumentId)
        {
             await GetWarehouseDocumentTagsAsyncWithHttpInfo(warehouseDocumentId);

        }

        /// <summary>
        /// Get the tags for a warehouseDocument. Get all existing warehouseDocument tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseDocumentId">Id of the warehouseDocument to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetWarehouseDocumentTagsAsyncWithHttpInfo (int? warehouseDocumentId)
        {
            // verify the required parameter 'warehouseDocumentId' is set
            if (warehouseDocumentId == null) throw new ApiException(400, "Missing required parameter 'warehouseDocumentId' when calling GetWarehouseDocumentTags");
            
    
            var localVarPath = "/beta/warehouseDocument/{warehouseDocumentId}/tag";
    
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
            if (warehouseDocumentId != null) localVarPathParams.Add("warehouseDocumentId", Configuration.ApiClient.ParameterToString(warehouseDocumentId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetWarehouseDocumentTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a warehouseDocument custom fields Updates an existing warehouseDocument custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WarehouseDocument to be updated.</param> 
        /// <returns></returns>
        public void UpdateWarehouseDocumentCustomFields (WarehouseDocument body)
        {
             UpdateWarehouseDocumentCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a warehouseDocument custom fields Updates an existing warehouseDocument custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WarehouseDocument to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateWarehouseDocumentCustomFieldsWithHttpInfo (WarehouseDocument body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling WarehouseDocumentApi->UpdateWarehouseDocumentCustomFields");
            
    
            var localVarPath = "/beta/warehouseDocument/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateWarehouseDocumentCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateWarehouseDocumentCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a warehouseDocument custom fields Updates an existing warehouseDocument custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WarehouseDocument to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateWarehouseDocumentCustomFieldsAsync (WarehouseDocument body)
        {
             await UpdateWarehouseDocumentCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a warehouseDocument custom fields Updates an existing warehouseDocument custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">WarehouseDocument to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateWarehouseDocumentCustomFieldsAsyncWithHttpInfo (WarehouseDocument body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateWarehouseDocumentCustomFields");
            
    
            var localVarPath = "/beta/warehouseDocument/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateWarehouseDocumentCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateWarehouseDocumentCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
