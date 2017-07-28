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
    public interface IPerpetualInventoryLogApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for a perpetualInventoryLog
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing perpetualInventoryLog.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to add an audit to</param>
        /// <param name="perpetualInventoryLogAudit">The audit to add</param>
        /// <returns></returns>
        void AddPerpetualInventoryLogAudit (int? perpetualInventoryLogId, string perpetualInventoryLogAudit);
  
        /// <summary>
        /// Add new audit for a perpetualInventoryLog
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing perpetualInventoryLog.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to add an audit to</param>
        /// <param name="perpetualInventoryLogAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddPerpetualInventoryLogAuditWithHttpInfo (int? perpetualInventoryLogId, string perpetualInventoryLogAudit);
        
        /// <summary>
        /// Add new tags for a perpetualInventoryLog.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing perpetualInventoryLog.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to add a tag to</param>
        /// <param name="perpetualInventoryLogTag">The tag to add</param>
        /// <returns></returns>
        void AddPerpetualInventoryLogTag (int? perpetualInventoryLogId, string perpetualInventoryLogTag);
  
        /// <summary>
        /// Add new tags for a perpetualInventoryLog.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing perpetualInventoryLog.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to add a tag to</param>
        /// <param name="perpetualInventoryLogTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddPerpetualInventoryLogTagWithHttpInfo (int? perpetualInventoryLogId, string perpetualInventoryLogTag);
        
        /// <summary>
        /// Delete a tag for a perpetualInventoryLog.
        /// </summary>
        /// <remarks>
        /// Deletes an existing perpetualInventoryLog tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to remove tag from</param>
        /// <param name="perpetualInventoryLogTag">The tag to delete</param>
        /// <returns></returns>
        void DeletePerpetualInventoryLogTag (int? perpetualInventoryLogId, string perpetualInventoryLogTag);
  
        /// <summary>
        /// Delete a tag for a perpetualInventoryLog.
        /// </summary>
        /// <remarks>
        /// Deletes an existing perpetualInventoryLog tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to remove tag from</param>
        /// <param name="perpetualInventoryLogTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePerpetualInventoryLogTagWithHttpInfo (int? perpetualInventoryLogId, string perpetualInventoryLogTag);
        
        /// <summary>
        /// Get a duplicated a perpetualInventoryLog by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated perpetualInventoryLog identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to be duplicated.</param>
        /// <returns>PerpetualInventoryLog</returns>
        PerpetualInventoryLog GetDuplicatePerpetualInventoryLogById (int? perpetualInventoryLogId);
  
        /// <summary>
        /// Get a duplicated a perpetualInventoryLog by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated perpetualInventoryLog identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to be duplicated.</param>
        /// <returns>ApiResponse of PerpetualInventoryLog</returns>
        ApiResponse<PerpetualInventoryLog> GetDuplicatePerpetualInventoryLogByIdWithHttpInfo (int? perpetualInventoryLogId);
        
        /// <summary>
        /// Search perpetualInventoryLogs by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of perpetualInventoryLogs that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;PerpetualInventoryLog&gt;</returns>
        List<PerpetualInventoryLog> GetPerpetualInventoryLogByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search perpetualInventoryLogs by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of perpetualInventoryLogs that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;PerpetualInventoryLog&gt;</returns>
        ApiResponse<List<PerpetualInventoryLog>> GetPerpetualInventoryLogByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a perpetualInventoryLog by id
        /// </summary>
        /// <remarks>
        /// Returns the perpetualInventoryLog identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to be returned.</param>
        /// <returns>PerpetualInventoryLog</returns>
        PerpetualInventoryLog GetPerpetualInventoryLogById (int? perpetualInventoryLogId);
  
        /// <summary>
        /// Get a perpetualInventoryLog by id
        /// </summary>
        /// <remarks>
        /// Returns the perpetualInventoryLog identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to be returned.</param>
        /// <returns>ApiResponse of PerpetualInventoryLog</returns>
        ApiResponse<PerpetualInventoryLog> GetPerpetualInventoryLogByIdWithHttpInfo (int? perpetualInventoryLogId);
        
        /// <summary>
        /// Get the tags for a perpetualInventoryLog.
        /// </summary>
        /// <remarks>
        /// Get all existing perpetualInventoryLog tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to get tags for</param>
        /// <returns></returns>
        void GetPerpetualInventoryLogTags (int? perpetualInventoryLogId);
  
        /// <summary>
        /// Get the tags for a perpetualInventoryLog.
        /// </summary>
        /// <remarks>
        /// Get all existing perpetualInventoryLog tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetPerpetualInventoryLogTagsWithHttpInfo (int? perpetualInventoryLogId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for a perpetualInventoryLog
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing perpetualInventoryLog.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to add an audit to</param>
        /// <param name="perpetualInventoryLogAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddPerpetualInventoryLogAuditAsync (int? perpetualInventoryLogId, string perpetualInventoryLogAudit);

        /// <summary>
        /// Add new audit for a perpetualInventoryLog
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing perpetualInventoryLog.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to add an audit to</param>
        /// <param name="perpetualInventoryLogAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddPerpetualInventoryLogAuditAsyncWithHttpInfo (int? perpetualInventoryLogId, string perpetualInventoryLogAudit);
        
        /// <summary>
        /// Add new tags for a perpetualInventoryLog.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing perpetualInventoryLog.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to add a tag to</param>
        /// <param name="perpetualInventoryLogTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddPerpetualInventoryLogTagAsync (int? perpetualInventoryLogId, string perpetualInventoryLogTag);

        /// <summary>
        /// Add new tags for a perpetualInventoryLog.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing perpetualInventoryLog.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to add a tag to</param>
        /// <param name="perpetualInventoryLogTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddPerpetualInventoryLogTagAsyncWithHttpInfo (int? perpetualInventoryLogId, string perpetualInventoryLogTag);
        
        /// <summary>
        /// Delete a tag for a perpetualInventoryLog.
        /// </summary>
        /// <remarks>
        /// Deletes an existing perpetualInventoryLog tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to remove tag from</param>
        /// <param name="perpetualInventoryLogTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePerpetualInventoryLogTagAsync (int? perpetualInventoryLogId, string perpetualInventoryLogTag);

        /// <summary>
        /// Delete a tag for a perpetualInventoryLog.
        /// </summary>
        /// <remarks>
        /// Deletes an existing perpetualInventoryLog tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to remove tag from</param>
        /// <param name="perpetualInventoryLogTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePerpetualInventoryLogTagAsyncWithHttpInfo (int? perpetualInventoryLogId, string perpetualInventoryLogTag);
        
        /// <summary>
        /// Get a duplicated a perpetualInventoryLog by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated perpetualInventoryLog identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to be duplicated.</param>
        /// <returns>Task of PerpetualInventoryLog</returns>
        System.Threading.Tasks.Task<PerpetualInventoryLog> GetDuplicatePerpetualInventoryLogByIdAsync (int? perpetualInventoryLogId);

        /// <summary>
        /// Get a duplicated a perpetualInventoryLog by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated perpetualInventoryLog identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to be duplicated.</param>
        /// <returns>Task of ApiResponse (PerpetualInventoryLog)</returns>
        System.Threading.Tasks.Task<ApiResponse<PerpetualInventoryLog>> GetDuplicatePerpetualInventoryLogByIdAsyncWithHttpInfo (int? perpetualInventoryLogId);
        
        /// <summary>
        /// Search perpetualInventoryLogs by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of perpetualInventoryLogs that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;PerpetualInventoryLog&gt;</returns>
        System.Threading.Tasks.Task<List<PerpetualInventoryLog>> GetPerpetualInventoryLogByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search perpetualInventoryLogs by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of perpetualInventoryLogs that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;PerpetualInventoryLog&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PerpetualInventoryLog>>> GetPerpetualInventoryLogByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a perpetualInventoryLog by id
        /// </summary>
        /// <remarks>
        /// Returns the perpetualInventoryLog identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to be returned.</param>
        /// <returns>Task of PerpetualInventoryLog</returns>
        System.Threading.Tasks.Task<PerpetualInventoryLog> GetPerpetualInventoryLogByIdAsync (int? perpetualInventoryLogId);

        /// <summary>
        /// Get a perpetualInventoryLog by id
        /// </summary>
        /// <remarks>
        /// Returns the perpetualInventoryLog identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to be returned.</param>
        /// <returns>Task of ApiResponse (PerpetualInventoryLog)</returns>
        System.Threading.Tasks.Task<ApiResponse<PerpetualInventoryLog>> GetPerpetualInventoryLogByIdAsyncWithHttpInfo (int? perpetualInventoryLogId);
        
        /// <summary>
        /// Get the tags for a perpetualInventoryLog.
        /// </summary>
        /// <remarks>
        /// Get all existing perpetualInventoryLog tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetPerpetualInventoryLogTagsAsync (int? perpetualInventoryLogId);

        /// <summary>
        /// Get the tags for a perpetualInventoryLog.
        /// </summary>
        /// <remarks>
        /// Get all existing perpetualInventoryLog tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetPerpetualInventoryLogTagsAsyncWithHttpInfo (int? perpetualInventoryLogId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PerpetualInventoryLogApi : IPerpetualInventoryLogApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerpetualInventoryLogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PerpetualInventoryLogApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PerpetualInventoryLogApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PerpetualInventoryLogApi(Configuration configuration = null)
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
        /// Add new audit for a perpetualInventoryLog Adds an audit to an existing perpetualInventoryLog.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to add an audit to</param> 
        /// <param name="perpetualInventoryLogAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddPerpetualInventoryLogAudit (int? perpetualInventoryLogId, string perpetualInventoryLogAudit)
        {
             AddPerpetualInventoryLogAuditWithHttpInfo(perpetualInventoryLogId, perpetualInventoryLogAudit);
        }

        /// <summary>
        /// Add new audit for a perpetualInventoryLog Adds an audit to an existing perpetualInventoryLog.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to add an audit to</param> 
        /// <param name="perpetualInventoryLogAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddPerpetualInventoryLogAuditWithHttpInfo (int? perpetualInventoryLogId, string perpetualInventoryLogAudit)
        {
            
            // verify the required parameter 'perpetualInventoryLogId' is set
            if (perpetualInventoryLogId == null)
                throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogId' when calling PerpetualInventoryLogApi->AddPerpetualInventoryLogAudit");
            
            // verify the required parameter 'perpetualInventoryLogAudit' is set
            if (perpetualInventoryLogAudit == null)
                throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogAudit' when calling PerpetualInventoryLogApi->AddPerpetualInventoryLogAudit");
            
    
            var localVarPath = "/beta/perpetualInventoryLog/{perpetualInventoryLogId}/audit/{perpetualInventoryLogAudit}";
    
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
            if (perpetualInventoryLogId != null) localVarPathParams.Add("perpetualInventoryLogId", Configuration.ApiClient.ParameterToString(perpetualInventoryLogId)); // path parameter
            if (perpetualInventoryLogAudit != null) localVarPathParams.Add("perpetualInventoryLogAudit", Configuration.ApiClient.ParameterToString(perpetualInventoryLogAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddPerpetualInventoryLogAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddPerpetualInventoryLogAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a perpetualInventoryLog Adds an audit to an existing perpetualInventoryLog.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to add an audit to</param>
        /// <param name="perpetualInventoryLogAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddPerpetualInventoryLogAuditAsync (int? perpetualInventoryLogId, string perpetualInventoryLogAudit)
        {
             await AddPerpetualInventoryLogAuditAsyncWithHttpInfo(perpetualInventoryLogId, perpetualInventoryLogAudit);

        }

        /// <summary>
        /// Add new audit for a perpetualInventoryLog Adds an audit to an existing perpetualInventoryLog.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to add an audit to</param>
        /// <param name="perpetualInventoryLogAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddPerpetualInventoryLogAuditAsyncWithHttpInfo (int? perpetualInventoryLogId, string perpetualInventoryLogAudit)
        {
            // verify the required parameter 'perpetualInventoryLogId' is set
            if (perpetualInventoryLogId == null) throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogId' when calling AddPerpetualInventoryLogAudit");
            // verify the required parameter 'perpetualInventoryLogAudit' is set
            if (perpetualInventoryLogAudit == null) throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogAudit' when calling AddPerpetualInventoryLogAudit");
            
    
            var localVarPath = "/beta/perpetualInventoryLog/{perpetualInventoryLogId}/audit/{perpetualInventoryLogAudit}";
    
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
            if (perpetualInventoryLogId != null) localVarPathParams.Add("perpetualInventoryLogId", Configuration.ApiClient.ParameterToString(perpetualInventoryLogId)); // path parameter
            if (perpetualInventoryLogAudit != null) localVarPathParams.Add("perpetualInventoryLogAudit", Configuration.ApiClient.ParameterToString(perpetualInventoryLogAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddPerpetualInventoryLogAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddPerpetualInventoryLogAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a perpetualInventoryLog. Adds a tag to an existing perpetualInventoryLog.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to add a tag to</param> 
        /// <param name="perpetualInventoryLogTag">The tag to add</param> 
        /// <returns></returns>
        public void AddPerpetualInventoryLogTag (int? perpetualInventoryLogId, string perpetualInventoryLogTag)
        {
             AddPerpetualInventoryLogTagWithHttpInfo(perpetualInventoryLogId, perpetualInventoryLogTag);
        }

        /// <summary>
        /// Add new tags for a perpetualInventoryLog. Adds a tag to an existing perpetualInventoryLog.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to add a tag to</param> 
        /// <param name="perpetualInventoryLogTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddPerpetualInventoryLogTagWithHttpInfo (int? perpetualInventoryLogId, string perpetualInventoryLogTag)
        {
            
            // verify the required parameter 'perpetualInventoryLogId' is set
            if (perpetualInventoryLogId == null)
                throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogId' when calling PerpetualInventoryLogApi->AddPerpetualInventoryLogTag");
            
            // verify the required parameter 'perpetualInventoryLogTag' is set
            if (perpetualInventoryLogTag == null)
                throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogTag' when calling PerpetualInventoryLogApi->AddPerpetualInventoryLogTag");
            
    
            var localVarPath = "/beta/perpetualInventoryLog/{perpetualInventoryLogId}/tag/{perpetualInventoryLogTag}";
    
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
            if (perpetualInventoryLogId != null) localVarPathParams.Add("perpetualInventoryLogId", Configuration.ApiClient.ParameterToString(perpetualInventoryLogId)); // path parameter
            if (perpetualInventoryLogTag != null) localVarPathParams.Add("perpetualInventoryLogTag", Configuration.ApiClient.ParameterToString(perpetualInventoryLogTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddPerpetualInventoryLogTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddPerpetualInventoryLogTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a perpetualInventoryLog. Adds a tag to an existing perpetualInventoryLog.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to add a tag to</param>
        /// <param name="perpetualInventoryLogTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddPerpetualInventoryLogTagAsync (int? perpetualInventoryLogId, string perpetualInventoryLogTag)
        {
             await AddPerpetualInventoryLogTagAsyncWithHttpInfo(perpetualInventoryLogId, perpetualInventoryLogTag);

        }

        /// <summary>
        /// Add new tags for a perpetualInventoryLog. Adds a tag to an existing perpetualInventoryLog.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to add a tag to</param>
        /// <param name="perpetualInventoryLogTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddPerpetualInventoryLogTagAsyncWithHttpInfo (int? perpetualInventoryLogId, string perpetualInventoryLogTag)
        {
            // verify the required parameter 'perpetualInventoryLogId' is set
            if (perpetualInventoryLogId == null) throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogId' when calling AddPerpetualInventoryLogTag");
            // verify the required parameter 'perpetualInventoryLogTag' is set
            if (perpetualInventoryLogTag == null) throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogTag' when calling AddPerpetualInventoryLogTag");
            
    
            var localVarPath = "/beta/perpetualInventoryLog/{perpetualInventoryLogId}/tag/{perpetualInventoryLogTag}";
    
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
            if (perpetualInventoryLogId != null) localVarPathParams.Add("perpetualInventoryLogId", Configuration.ApiClient.ParameterToString(perpetualInventoryLogId)); // path parameter
            if (perpetualInventoryLogTag != null) localVarPathParams.Add("perpetualInventoryLogTag", Configuration.ApiClient.ParameterToString(perpetualInventoryLogTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddPerpetualInventoryLogTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddPerpetualInventoryLogTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a perpetualInventoryLog. Deletes an existing perpetualInventoryLog tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to remove tag from</param> 
        /// <param name="perpetualInventoryLogTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeletePerpetualInventoryLogTag (int? perpetualInventoryLogId, string perpetualInventoryLogTag)
        {
             DeletePerpetualInventoryLogTagWithHttpInfo(perpetualInventoryLogId, perpetualInventoryLogTag);
        }

        /// <summary>
        /// Delete a tag for a perpetualInventoryLog. Deletes an existing perpetualInventoryLog tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to remove tag from</param> 
        /// <param name="perpetualInventoryLogTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePerpetualInventoryLogTagWithHttpInfo (int? perpetualInventoryLogId, string perpetualInventoryLogTag)
        {
            
            // verify the required parameter 'perpetualInventoryLogId' is set
            if (perpetualInventoryLogId == null)
                throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogId' when calling PerpetualInventoryLogApi->DeletePerpetualInventoryLogTag");
            
            // verify the required parameter 'perpetualInventoryLogTag' is set
            if (perpetualInventoryLogTag == null)
                throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogTag' when calling PerpetualInventoryLogApi->DeletePerpetualInventoryLogTag");
            
    
            var localVarPath = "/beta/perpetualInventoryLog/{perpetualInventoryLogId}/tag/{perpetualInventoryLogTag}";
    
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
            if (perpetualInventoryLogId != null) localVarPathParams.Add("perpetualInventoryLogId", Configuration.ApiClient.ParameterToString(perpetualInventoryLogId)); // path parameter
            if (perpetualInventoryLogTag != null) localVarPathParams.Add("perpetualInventoryLogTag", Configuration.ApiClient.ParameterToString(perpetualInventoryLogTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeletePerpetualInventoryLogTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePerpetualInventoryLogTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a perpetualInventoryLog. Deletes an existing perpetualInventoryLog tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to remove tag from</param>
        /// <param name="perpetualInventoryLogTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePerpetualInventoryLogTagAsync (int? perpetualInventoryLogId, string perpetualInventoryLogTag)
        {
             await DeletePerpetualInventoryLogTagAsyncWithHttpInfo(perpetualInventoryLogId, perpetualInventoryLogTag);

        }

        /// <summary>
        /// Delete a tag for a perpetualInventoryLog. Deletes an existing perpetualInventoryLog tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to remove tag from</param>
        /// <param name="perpetualInventoryLogTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePerpetualInventoryLogTagAsyncWithHttpInfo (int? perpetualInventoryLogId, string perpetualInventoryLogTag)
        {
            // verify the required parameter 'perpetualInventoryLogId' is set
            if (perpetualInventoryLogId == null) throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogId' when calling DeletePerpetualInventoryLogTag");
            // verify the required parameter 'perpetualInventoryLogTag' is set
            if (perpetualInventoryLogTag == null) throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogTag' when calling DeletePerpetualInventoryLogTag");
            
    
            var localVarPath = "/beta/perpetualInventoryLog/{perpetualInventoryLogId}/tag/{perpetualInventoryLogTag}";
    
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
            if (perpetualInventoryLogId != null) localVarPathParams.Add("perpetualInventoryLogId", Configuration.ApiClient.ParameterToString(perpetualInventoryLogId)); // path parameter
            if (perpetualInventoryLogTag != null) localVarPathParams.Add("perpetualInventoryLogTag", Configuration.ApiClient.ParameterToString(perpetualInventoryLogTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeletePerpetualInventoryLogTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePerpetualInventoryLogTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a perpetualInventoryLog by id Returns a duplicated perpetualInventoryLog identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to be duplicated.</param> 
        /// <returns>PerpetualInventoryLog</returns>
        public PerpetualInventoryLog GetDuplicatePerpetualInventoryLogById (int? perpetualInventoryLogId)
        {
             ApiResponse<PerpetualInventoryLog> localVarResponse = GetDuplicatePerpetualInventoryLogByIdWithHttpInfo(perpetualInventoryLogId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a perpetualInventoryLog by id Returns a duplicated perpetualInventoryLog identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to be duplicated.</param> 
        /// <returns>ApiResponse of PerpetualInventoryLog</returns>
        public ApiResponse< PerpetualInventoryLog > GetDuplicatePerpetualInventoryLogByIdWithHttpInfo (int? perpetualInventoryLogId)
        {
            
            // verify the required parameter 'perpetualInventoryLogId' is set
            if (perpetualInventoryLogId == null)
                throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogId' when calling PerpetualInventoryLogApi->GetDuplicatePerpetualInventoryLogById");
            
    
            var localVarPath = "/beta/perpetualInventoryLog/duplicate/{perpetualInventoryLogId}";
    
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
            if (perpetualInventoryLogId != null) localVarPathParams.Add("perpetualInventoryLogId", Configuration.ApiClient.ParameterToString(perpetualInventoryLogId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicatePerpetualInventoryLogById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicatePerpetualInventoryLogById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PerpetualInventoryLog>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PerpetualInventoryLog) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerpetualInventoryLog)));
            
        }

        
        /// <summary>
        /// Get a duplicated a perpetualInventoryLog by id Returns a duplicated perpetualInventoryLog identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to be duplicated.</param>
        /// <returns>Task of PerpetualInventoryLog</returns>
        public async System.Threading.Tasks.Task<PerpetualInventoryLog> GetDuplicatePerpetualInventoryLogByIdAsync (int? perpetualInventoryLogId)
        {
             ApiResponse<PerpetualInventoryLog> localVarResponse = await GetDuplicatePerpetualInventoryLogByIdAsyncWithHttpInfo(perpetualInventoryLogId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a perpetualInventoryLog by id Returns a duplicated perpetualInventoryLog identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to be duplicated.</param>
        /// <returns>Task of ApiResponse (PerpetualInventoryLog)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PerpetualInventoryLog>> GetDuplicatePerpetualInventoryLogByIdAsyncWithHttpInfo (int? perpetualInventoryLogId)
        {
            // verify the required parameter 'perpetualInventoryLogId' is set
            if (perpetualInventoryLogId == null) throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogId' when calling GetDuplicatePerpetualInventoryLogById");
            
    
            var localVarPath = "/beta/perpetualInventoryLog/duplicate/{perpetualInventoryLogId}";
    
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
            if (perpetualInventoryLogId != null) localVarPathParams.Add("perpetualInventoryLogId", Configuration.ApiClient.ParameterToString(perpetualInventoryLogId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicatePerpetualInventoryLogById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicatePerpetualInventoryLogById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PerpetualInventoryLog>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PerpetualInventoryLog) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerpetualInventoryLog)));
            
        }
        
        /// <summary>
        /// Search perpetualInventoryLogs by filter Returns the list of perpetualInventoryLogs that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;PerpetualInventoryLog&gt;</returns>
        public List<PerpetualInventoryLog> GetPerpetualInventoryLogByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<PerpetualInventoryLog>> localVarResponse = GetPerpetualInventoryLogByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search perpetualInventoryLogs by filter Returns the list of perpetualInventoryLogs that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;PerpetualInventoryLog&gt;</returns>
        public ApiResponse< List<PerpetualInventoryLog> > GetPerpetualInventoryLogByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/perpetualInventoryLog/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetPerpetualInventoryLogByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPerpetualInventoryLogByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<PerpetualInventoryLog>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PerpetualInventoryLog>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PerpetualInventoryLog>)));
            
        }

        
        /// <summary>
        /// Search perpetualInventoryLogs by filter Returns the list of perpetualInventoryLogs that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;PerpetualInventoryLog&gt;</returns>
        public async System.Threading.Tasks.Task<List<PerpetualInventoryLog>> GetPerpetualInventoryLogByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<PerpetualInventoryLog>> localVarResponse = await GetPerpetualInventoryLogByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search perpetualInventoryLogs by filter Returns the list of perpetualInventoryLogs that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;PerpetualInventoryLog&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<PerpetualInventoryLog>>> GetPerpetualInventoryLogByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/perpetualInventoryLog/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetPerpetualInventoryLogByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPerpetualInventoryLogByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<PerpetualInventoryLog>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<PerpetualInventoryLog>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<PerpetualInventoryLog>)));
            
        }
        
        /// <summary>
        /// Get a perpetualInventoryLog by id Returns the perpetualInventoryLog identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to be returned.</param> 
        /// <returns>PerpetualInventoryLog</returns>
        public PerpetualInventoryLog GetPerpetualInventoryLogById (int? perpetualInventoryLogId)
        {
             ApiResponse<PerpetualInventoryLog> localVarResponse = GetPerpetualInventoryLogByIdWithHttpInfo(perpetualInventoryLogId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a perpetualInventoryLog by id Returns the perpetualInventoryLog identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to be returned.</param> 
        /// <returns>ApiResponse of PerpetualInventoryLog</returns>
        public ApiResponse< PerpetualInventoryLog > GetPerpetualInventoryLogByIdWithHttpInfo (int? perpetualInventoryLogId)
        {
            
            // verify the required parameter 'perpetualInventoryLogId' is set
            if (perpetualInventoryLogId == null)
                throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogId' when calling PerpetualInventoryLogApi->GetPerpetualInventoryLogById");
            
    
            var localVarPath = "/beta/perpetualInventoryLog/{perpetualInventoryLogId}";
    
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
            if (perpetualInventoryLogId != null) localVarPathParams.Add("perpetualInventoryLogId", Configuration.ApiClient.ParameterToString(perpetualInventoryLogId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetPerpetualInventoryLogById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPerpetualInventoryLogById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PerpetualInventoryLog>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PerpetualInventoryLog) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerpetualInventoryLog)));
            
        }

        
        /// <summary>
        /// Get a perpetualInventoryLog by id Returns the perpetualInventoryLog identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to be returned.</param>
        /// <returns>Task of PerpetualInventoryLog</returns>
        public async System.Threading.Tasks.Task<PerpetualInventoryLog> GetPerpetualInventoryLogByIdAsync (int? perpetualInventoryLogId)
        {
             ApiResponse<PerpetualInventoryLog> localVarResponse = await GetPerpetualInventoryLogByIdAsyncWithHttpInfo(perpetualInventoryLogId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a perpetualInventoryLog by id Returns the perpetualInventoryLog identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to be returned.</param>
        /// <returns>Task of ApiResponse (PerpetualInventoryLog)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PerpetualInventoryLog>> GetPerpetualInventoryLogByIdAsyncWithHttpInfo (int? perpetualInventoryLogId)
        {
            // verify the required parameter 'perpetualInventoryLogId' is set
            if (perpetualInventoryLogId == null) throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogId' when calling GetPerpetualInventoryLogById");
            
    
            var localVarPath = "/beta/perpetualInventoryLog/{perpetualInventoryLogId}";
    
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
            if (perpetualInventoryLogId != null) localVarPathParams.Add("perpetualInventoryLogId", Configuration.ApiClient.ParameterToString(perpetualInventoryLogId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetPerpetualInventoryLogById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPerpetualInventoryLogById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PerpetualInventoryLog>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PerpetualInventoryLog) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerpetualInventoryLog)));
            
        }
        
        /// <summary>
        /// Get the tags for a perpetualInventoryLog. Get all existing perpetualInventoryLog tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to get tags for</param> 
        /// <returns></returns>
        public void GetPerpetualInventoryLogTags (int? perpetualInventoryLogId)
        {
             GetPerpetualInventoryLogTagsWithHttpInfo(perpetualInventoryLogId);
        }

        /// <summary>
        /// Get the tags for a perpetualInventoryLog. Get all existing perpetualInventoryLog tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetPerpetualInventoryLogTagsWithHttpInfo (int? perpetualInventoryLogId)
        {
            
            // verify the required parameter 'perpetualInventoryLogId' is set
            if (perpetualInventoryLogId == null)
                throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogId' when calling PerpetualInventoryLogApi->GetPerpetualInventoryLogTags");
            
    
            var localVarPath = "/beta/perpetualInventoryLog/{perpetualInventoryLogId}/tag";
    
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
            if (perpetualInventoryLogId != null) localVarPathParams.Add("perpetualInventoryLogId", Configuration.ApiClient.ParameterToString(perpetualInventoryLogId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetPerpetualInventoryLogTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPerpetualInventoryLogTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a perpetualInventoryLog. Get all existing perpetualInventoryLog tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetPerpetualInventoryLogTagsAsync (int? perpetualInventoryLogId)
        {
             await GetPerpetualInventoryLogTagsAsyncWithHttpInfo(perpetualInventoryLogId);

        }

        /// <summary>
        /// Get the tags for a perpetualInventoryLog. Get all existing perpetualInventoryLog tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="perpetualInventoryLogId">Id of the perpetualInventoryLog to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetPerpetualInventoryLogTagsAsyncWithHttpInfo (int? perpetualInventoryLogId)
        {
            // verify the required parameter 'perpetualInventoryLogId' is set
            if (perpetualInventoryLogId == null) throw new ApiException(400, "Missing required parameter 'perpetualInventoryLogId' when calling GetPerpetualInventoryLogTags");
            
    
            var localVarPath = "/beta/perpetualInventoryLog/{perpetualInventoryLogId}/tag";
    
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
            if (perpetualInventoryLogId != null) localVarPathParams.Add("perpetualInventoryLogId", Configuration.ApiClient.ParameterToString(perpetualInventoryLogId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetPerpetualInventoryLogTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPerpetualInventoryLogTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
