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
    public interface IJobTimeActivityApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a jobTimeActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new jobTimeActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobTimeActivity to be inserted.</param>
        /// <returns>JobTimeActivity</returns>
        JobTimeActivity AddJobTimeActivity (JobTimeActivity body);
  
        /// <summary>
        /// Create a jobTimeActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new jobTimeActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobTimeActivity to be inserted.</param>
        /// <returns>ApiResponse of JobTimeActivity</returns>
        ApiResponse<JobTimeActivity> AddJobTimeActivityWithHttpInfo (JobTimeActivity body);
        
        /// <summary>
        /// Add new audit for a jobTimeActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing jobTimeActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to add an audit to</param>
        /// <param name="jobTimeActivityAudit">The audit to add</param>
        /// <returns></returns>
        void AddJobTimeActivityAudit (int? jobTimeActivityId, string jobTimeActivityAudit);
  
        /// <summary>
        /// Add new audit for a jobTimeActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing jobTimeActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to add an audit to</param>
        /// <param name="jobTimeActivityAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddJobTimeActivityAuditWithHttpInfo (int? jobTimeActivityId, string jobTimeActivityAudit);
        
        /// <summary>
        /// Add new tags for a jobTimeActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing jobTimeActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to add a tag to</param>
        /// <param name="jobTimeActivityTag">The tag to add</param>
        /// <returns></returns>
        void AddJobTimeActivityTag (int? jobTimeActivityId, string jobTimeActivityTag);
  
        /// <summary>
        /// Add new tags for a jobTimeActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing jobTimeActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to add a tag to</param>
        /// <param name="jobTimeActivityTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddJobTimeActivityTagWithHttpInfo (int? jobTimeActivityId, string jobTimeActivityTag);
        
        /// <summary>
        /// Delete a jobTimeActivity
        /// </summary>
        /// <remarks>
        /// Deletes the jobTimeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be deleted.</param>
        /// <returns></returns>
        void DeleteJobTimeActivity (int? jobTimeActivityId);
  
        /// <summary>
        /// Delete a jobTimeActivity
        /// </summary>
        /// <remarks>
        /// Deletes the jobTimeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteJobTimeActivityWithHttpInfo (int? jobTimeActivityId);
        
        /// <summary>
        /// Delete a tag for a jobTimeActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing jobTimeActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to remove tag from</param>
        /// <param name="jobTimeActivityTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteJobTimeActivityTag (int? jobTimeActivityId, string jobTimeActivityTag);
  
        /// <summary>
        /// Delete a tag for a jobTimeActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing jobTimeActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to remove tag from</param>
        /// <param name="jobTimeActivityTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteJobTimeActivityTagWithHttpInfo (int? jobTimeActivityId, string jobTimeActivityTag);
        
        /// <summary>
        /// Get a duplicated a jobTimeActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated jobTimeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be duplicated.</param>
        /// <returns>JobTimeActivity</returns>
        JobTimeActivity GetDuplicateJobTimeActivityById (int? jobTimeActivityId);
  
        /// <summary>
        /// Get a duplicated a jobTimeActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated jobTimeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be duplicated.</param>
        /// <returns>ApiResponse of JobTimeActivity</returns>
        ApiResponse<JobTimeActivity> GetDuplicateJobTimeActivityByIdWithHttpInfo (int? jobTimeActivityId);
        
        /// <summary>
        /// Search jobTimeActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of jobTimeActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;JobTimeActivity&gt;</returns>
        List<JobTimeActivity> GetJobTimeActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search jobTimeActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of jobTimeActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;JobTimeActivity&gt;</returns>
        ApiResponse<List<JobTimeActivity>> GetJobTimeActivityByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a jobTimeActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the jobTimeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be returned.</param>
        /// <returns>JobTimeActivity</returns>
        JobTimeActivity GetJobTimeActivityById (int? jobTimeActivityId);
  
        /// <summary>
        /// Get a jobTimeActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the jobTimeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be returned.</param>
        /// <returns>ApiResponse of JobTimeActivity</returns>
        ApiResponse<JobTimeActivity> GetJobTimeActivityByIdWithHttpInfo (int? jobTimeActivityId);
        
        /// <summary>
        /// Get the tags for a jobTimeActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing jobTimeActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to get tags for</param>
        /// <returns></returns>
        void GetJobTimeActivityTags (int? jobTimeActivityId);
  
        /// <summary>
        /// Get the tags for a jobTimeActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing jobTimeActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetJobTimeActivityTagsWithHttpInfo (int? jobTimeActivityId);
        
        /// <summary>
        /// Update a jobTimeActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing jobTimeActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobTimeActivity to be updated.</param>
        /// <returns></returns>
        void UpdateJobTimeActivity (JobTimeActivity body);
  
        /// <summary>
        /// Update a jobTimeActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing jobTimeActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobTimeActivity to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateJobTimeActivityWithHttpInfo (JobTimeActivity body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a jobTimeActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new jobTimeActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobTimeActivity to be inserted.</param>
        /// <returns>Task of JobTimeActivity</returns>
        System.Threading.Tasks.Task<JobTimeActivity> AddJobTimeActivityAsync (JobTimeActivity body);

        /// <summary>
        /// Create a jobTimeActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new jobTimeActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobTimeActivity to be inserted.</param>
        /// <returns>Task of ApiResponse (JobTimeActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<JobTimeActivity>> AddJobTimeActivityAsyncWithHttpInfo (JobTimeActivity body);
        
        /// <summary>
        /// Add new audit for a jobTimeActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing jobTimeActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to add an audit to</param>
        /// <param name="jobTimeActivityAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddJobTimeActivityAuditAsync (int? jobTimeActivityId, string jobTimeActivityAudit);

        /// <summary>
        /// Add new audit for a jobTimeActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing jobTimeActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to add an audit to</param>
        /// <param name="jobTimeActivityAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddJobTimeActivityAuditAsyncWithHttpInfo (int? jobTimeActivityId, string jobTimeActivityAudit);
        
        /// <summary>
        /// Add new tags for a jobTimeActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing jobTimeActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to add a tag to</param>
        /// <param name="jobTimeActivityTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddJobTimeActivityTagAsync (int? jobTimeActivityId, string jobTimeActivityTag);

        /// <summary>
        /// Add new tags for a jobTimeActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing jobTimeActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to add a tag to</param>
        /// <param name="jobTimeActivityTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddJobTimeActivityTagAsyncWithHttpInfo (int? jobTimeActivityId, string jobTimeActivityTag);
        
        /// <summary>
        /// Delete a jobTimeActivity
        /// </summary>
        /// <remarks>
        /// Deletes the jobTimeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteJobTimeActivityAsync (int? jobTimeActivityId);

        /// <summary>
        /// Delete a jobTimeActivity
        /// </summary>
        /// <remarks>
        /// Deletes the jobTimeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJobTimeActivityAsyncWithHttpInfo (int? jobTimeActivityId);
        
        /// <summary>
        /// Delete a tag for a jobTimeActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing jobTimeActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to remove tag from</param>
        /// <param name="jobTimeActivityTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteJobTimeActivityTagAsync (int? jobTimeActivityId, string jobTimeActivityTag);

        /// <summary>
        /// Delete a tag for a jobTimeActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing jobTimeActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to remove tag from</param>
        /// <param name="jobTimeActivityTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJobTimeActivityTagAsyncWithHttpInfo (int? jobTimeActivityId, string jobTimeActivityTag);
        
        /// <summary>
        /// Get a duplicated a jobTimeActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated jobTimeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be duplicated.</param>
        /// <returns>Task of JobTimeActivity</returns>
        System.Threading.Tasks.Task<JobTimeActivity> GetDuplicateJobTimeActivityByIdAsync (int? jobTimeActivityId);

        /// <summary>
        /// Get a duplicated a jobTimeActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated jobTimeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be duplicated.</param>
        /// <returns>Task of ApiResponse (JobTimeActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<JobTimeActivity>> GetDuplicateJobTimeActivityByIdAsyncWithHttpInfo (int? jobTimeActivityId);
        
        /// <summary>
        /// Search jobTimeActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of jobTimeActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;JobTimeActivity&gt;</returns>
        System.Threading.Tasks.Task<List<JobTimeActivity>> GetJobTimeActivityByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search jobTimeActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of jobTimeActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;JobTimeActivity&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<JobTimeActivity>>> GetJobTimeActivityByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a jobTimeActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the jobTimeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be returned.</param>
        /// <returns>Task of JobTimeActivity</returns>
        System.Threading.Tasks.Task<JobTimeActivity> GetJobTimeActivityByIdAsync (int? jobTimeActivityId);

        /// <summary>
        /// Get a jobTimeActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the jobTimeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be returned.</param>
        /// <returns>Task of ApiResponse (JobTimeActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<JobTimeActivity>> GetJobTimeActivityByIdAsyncWithHttpInfo (int? jobTimeActivityId);
        
        /// <summary>
        /// Get the tags for a jobTimeActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing jobTimeActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetJobTimeActivityTagsAsync (int? jobTimeActivityId);

        /// <summary>
        /// Get the tags for a jobTimeActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing jobTimeActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetJobTimeActivityTagsAsyncWithHttpInfo (int? jobTimeActivityId);
        
        /// <summary>
        /// Update a jobTimeActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing jobTimeActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobTimeActivity to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateJobTimeActivityAsync (JobTimeActivity body);

        /// <summary>
        /// Update a jobTimeActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing jobTimeActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobTimeActivity to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateJobTimeActivityAsyncWithHttpInfo (JobTimeActivity body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class JobTimeActivityApi : IJobTimeActivityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTimeActivityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public JobTimeActivityApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTimeActivityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public JobTimeActivityApi(Configuration configuration = null)
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
        /// Create a jobTimeActivity Inserts a new jobTimeActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobTimeActivity to be inserted.</param> 
        /// <returns>JobTimeActivity</returns>
        public JobTimeActivity AddJobTimeActivity (JobTimeActivity body)
        {
             ApiResponse<JobTimeActivity> localVarResponse = AddJobTimeActivityWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a jobTimeActivity Inserts a new jobTimeActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobTimeActivity to be inserted.</param> 
        /// <returns>ApiResponse of JobTimeActivity</returns>
        public ApiResponse< JobTimeActivity > AddJobTimeActivityWithHttpInfo (JobTimeActivity body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JobTimeActivityApi->AddJobTimeActivity");
            
    
            var localVarPath = "/beta/jobTimeActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddJobTimeActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddJobTimeActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<JobTimeActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobTimeActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobTimeActivity)));
            
        }

        
        /// <summary>
        /// Create a jobTimeActivity Inserts a new jobTimeActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobTimeActivity to be inserted.</param>
        /// <returns>Task of JobTimeActivity</returns>
        public async System.Threading.Tasks.Task<JobTimeActivity> AddJobTimeActivityAsync (JobTimeActivity body)
        {
             ApiResponse<JobTimeActivity> localVarResponse = await AddJobTimeActivityAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a jobTimeActivity Inserts a new jobTimeActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobTimeActivity to be inserted.</param>
        /// <returns>Task of ApiResponse (JobTimeActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JobTimeActivity>> AddJobTimeActivityAsyncWithHttpInfo (JobTimeActivity body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddJobTimeActivity");
            
    
            var localVarPath = "/beta/jobTimeActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddJobTimeActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddJobTimeActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JobTimeActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobTimeActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobTimeActivity)));
            
        }
        
        /// <summary>
        /// Add new audit for a jobTimeActivity Adds an audit to an existing jobTimeActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to add an audit to</param> 
        /// <param name="jobTimeActivityAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddJobTimeActivityAudit (int? jobTimeActivityId, string jobTimeActivityAudit)
        {
             AddJobTimeActivityAuditWithHttpInfo(jobTimeActivityId, jobTimeActivityAudit);
        }

        /// <summary>
        /// Add new audit for a jobTimeActivity Adds an audit to an existing jobTimeActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to add an audit to</param> 
        /// <param name="jobTimeActivityAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddJobTimeActivityAuditWithHttpInfo (int? jobTimeActivityId, string jobTimeActivityAudit)
        {
            
            // verify the required parameter 'jobTimeActivityId' is set
            if (jobTimeActivityId == null)
                throw new ApiException(400, "Missing required parameter 'jobTimeActivityId' when calling JobTimeActivityApi->AddJobTimeActivityAudit");
            
            // verify the required parameter 'jobTimeActivityAudit' is set
            if (jobTimeActivityAudit == null)
                throw new ApiException(400, "Missing required parameter 'jobTimeActivityAudit' when calling JobTimeActivityApi->AddJobTimeActivityAudit");
            
    
            var localVarPath = "/beta/jobTimeActivity/{jobTimeActivityId}/audit/{jobTimeActivityAudit}";
    
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
            if (jobTimeActivityId != null) localVarPathParams.Add("jobTimeActivityId", Configuration.ApiClient.ParameterToString(jobTimeActivityId)); // path parameter
            if (jobTimeActivityAudit != null) localVarPathParams.Add("jobTimeActivityAudit", Configuration.ApiClient.ParameterToString(jobTimeActivityAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddJobTimeActivityAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddJobTimeActivityAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a jobTimeActivity Adds an audit to an existing jobTimeActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to add an audit to</param>
        /// <param name="jobTimeActivityAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddJobTimeActivityAuditAsync (int? jobTimeActivityId, string jobTimeActivityAudit)
        {
             await AddJobTimeActivityAuditAsyncWithHttpInfo(jobTimeActivityId, jobTimeActivityAudit);

        }

        /// <summary>
        /// Add new audit for a jobTimeActivity Adds an audit to an existing jobTimeActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to add an audit to</param>
        /// <param name="jobTimeActivityAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddJobTimeActivityAuditAsyncWithHttpInfo (int? jobTimeActivityId, string jobTimeActivityAudit)
        {
            // verify the required parameter 'jobTimeActivityId' is set
            if (jobTimeActivityId == null) throw new ApiException(400, "Missing required parameter 'jobTimeActivityId' when calling AddJobTimeActivityAudit");
            // verify the required parameter 'jobTimeActivityAudit' is set
            if (jobTimeActivityAudit == null) throw new ApiException(400, "Missing required parameter 'jobTimeActivityAudit' when calling AddJobTimeActivityAudit");
            
    
            var localVarPath = "/beta/jobTimeActivity/{jobTimeActivityId}/audit/{jobTimeActivityAudit}";
    
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
            if (jobTimeActivityId != null) localVarPathParams.Add("jobTimeActivityId", Configuration.ApiClient.ParameterToString(jobTimeActivityId)); // path parameter
            if (jobTimeActivityAudit != null) localVarPathParams.Add("jobTimeActivityAudit", Configuration.ApiClient.ParameterToString(jobTimeActivityAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddJobTimeActivityAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddJobTimeActivityAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a jobTimeActivity. Adds a tag to an existing jobTimeActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to add a tag to</param> 
        /// <param name="jobTimeActivityTag">The tag to add</param> 
        /// <returns></returns>
        public void AddJobTimeActivityTag (int? jobTimeActivityId, string jobTimeActivityTag)
        {
             AddJobTimeActivityTagWithHttpInfo(jobTimeActivityId, jobTimeActivityTag);
        }

        /// <summary>
        /// Add new tags for a jobTimeActivity. Adds a tag to an existing jobTimeActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to add a tag to</param> 
        /// <param name="jobTimeActivityTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddJobTimeActivityTagWithHttpInfo (int? jobTimeActivityId, string jobTimeActivityTag)
        {
            
            // verify the required parameter 'jobTimeActivityId' is set
            if (jobTimeActivityId == null)
                throw new ApiException(400, "Missing required parameter 'jobTimeActivityId' when calling JobTimeActivityApi->AddJobTimeActivityTag");
            
            // verify the required parameter 'jobTimeActivityTag' is set
            if (jobTimeActivityTag == null)
                throw new ApiException(400, "Missing required parameter 'jobTimeActivityTag' when calling JobTimeActivityApi->AddJobTimeActivityTag");
            
    
            var localVarPath = "/beta/jobTimeActivity/{jobTimeActivityId}/tag/{jobTimeActivityTag}";
    
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
            if (jobTimeActivityId != null) localVarPathParams.Add("jobTimeActivityId", Configuration.ApiClient.ParameterToString(jobTimeActivityId)); // path parameter
            if (jobTimeActivityTag != null) localVarPathParams.Add("jobTimeActivityTag", Configuration.ApiClient.ParameterToString(jobTimeActivityTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddJobTimeActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddJobTimeActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a jobTimeActivity. Adds a tag to an existing jobTimeActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to add a tag to</param>
        /// <param name="jobTimeActivityTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddJobTimeActivityTagAsync (int? jobTimeActivityId, string jobTimeActivityTag)
        {
             await AddJobTimeActivityTagAsyncWithHttpInfo(jobTimeActivityId, jobTimeActivityTag);

        }

        /// <summary>
        /// Add new tags for a jobTimeActivity. Adds a tag to an existing jobTimeActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to add a tag to</param>
        /// <param name="jobTimeActivityTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddJobTimeActivityTagAsyncWithHttpInfo (int? jobTimeActivityId, string jobTimeActivityTag)
        {
            // verify the required parameter 'jobTimeActivityId' is set
            if (jobTimeActivityId == null) throw new ApiException(400, "Missing required parameter 'jobTimeActivityId' when calling AddJobTimeActivityTag");
            // verify the required parameter 'jobTimeActivityTag' is set
            if (jobTimeActivityTag == null) throw new ApiException(400, "Missing required parameter 'jobTimeActivityTag' when calling AddJobTimeActivityTag");
            
    
            var localVarPath = "/beta/jobTimeActivity/{jobTimeActivityId}/tag/{jobTimeActivityTag}";
    
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
            if (jobTimeActivityId != null) localVarPathParams.Add("jobTimeActivityId", Configuration.ApiClient.ParameterToString(jobTimeActivityId)); // path parameter
            if (jobTimeActivityTag != null) localVarPathParams.Add("jobTimeActivityTag", Configuration.ApiClient.ParameterToString(jobTimeActivityTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddJobTimeActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddJobTimeActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a jobTimeActivity Deletes the jobTimeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be deleted.</param> 
        /// <returns></returns>
        public void DeleteJobTimeActivity (int? jobTimeActivityId)
        {
             DeleteJobTimeActivityWithHttpInfo(jobTimeActivityId);
        }

        /// <summary>
        /// Delete a jobTimeActivity Deletes the jobTimeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteJobTimeActivityWithHttpInfo (int? jobTimeActivityId)
        {
            
            // verify the required parameter 'jobTimeActivityId' is set
            if (jobTimeActivityId == null)
                throw new ApiException(400, "Missing required parameter 'jobTimeActivityId' when calling JobTimeActivityApi->DeleteJobTimeActivity");
            
    
            var localVarPath = "/beta/jobTimeActivity/{jobTimeActivityId}";
    
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
            if (jobTimeActivityId != null) localVarPathParams.Add("jobTimeActivityId", Configuration.ApiClient.ParameterToString(jobTimeActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteJobTimeActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJobTimeActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a jobTimeActivity Deletes the jobTimeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteJobTimeActivityAsync (int? jobTimeActivityId)
        {
             await DeleteJobTimeActivityAsyncWithHttpInfo(jobTimeActivityId);

        }

        /// <summary>
        /// Delete a jobTimeActivity Deletes the jobTimeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJobTimeActivityAsyncWithHttpInfo (int? jobTimeActivityId)
        {
            // verify the required parameter 'jobTimeActivityId' is set
            if (jobTimeActivityId == null) throw new ApiException(400, "Missing required parameter 'jobTimeActivityId' when calling DeleteJobTimeActivity");
            
    
            var localVarPath = "/beta/jobTimeActivity/{jobTimeActivityId}";
    
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
            if (jobTimeActivityId != null) localVarPathParams.Add("jobTimeActivityId", Configuration.ApiClient.ParameterToString(jobTimeActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteJobTimeActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJobTimeActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a jobTimeActivity. Deletes an existing jobTimeActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to remove tag from</param> 
        /// <param name="jobTimeActivityTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteJobTimeActivityTag (int? jobTimeActivityId, string jobTimeActivityTag)
        {
             DeleteJobTimeActivityTagWithHttpInfo(jobTimeActivityId, jobTimeActivityTag);
        }

        /// <summary>
        /// Delete a tag for a jobTimeActivity. Deletes an existing jobTimeActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to remove tag from</param> 
        /// <param name="jobTimeActivityTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteJobTimeActivityTagWithHttpInfo (int? jobTimeActivityId, string jobTimeActivityTag)
        {
            
            // verify the required parameter 'jobTimeActivityId' is set
            if (jobTimeActivityId == null)
                throw new ApiException(400, "Missing required parameter 'jobTimeActivityId' when calling JobTimeActivityApi->DeleteJobTimeActivityTag");
            
            // verify the required parameter 'jobTimeActivityTag' is set
            if (jobTimeActivityTag == null)
                throw new ApiException(400, "Missing required parameter 'jobTimeActivityTag' when calling JobTimeActivityApi->DeleteJobTimeActivityTag");
            
    
            var localVarPath = "/beta/jobTimeActivity/{jobTimeActivityId}/tag/{jobTimeActivityTag}";
    
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
            if (jobTimeActivityId != null) localVarPathParams.Add("jobTimeActivityId", Configuration.ApiClient.ParameterToString(jobTimeActivityId)); // path parameter
            if (jobTimeActivityTag != null) localVarPathParams.Add("jobTimeActivityTag", Configuration.ApiClient.ParameterToString(jobTimeActivityTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteJobTimeActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJobTimeActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a jobTimeActivity. Deletes an existing jobTimeActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to remove tag from</param>
        /// <param name="jobTimeActivityTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteJobTimeActivityTagAsync (int? jobTimeActivityId, string jobTimeActivityTag)
        {
             await DeleteJobTimeActivityTagAsyncWithHttpInfo(jobTimeActivityId, jobTimeActivityTag);

        }

        /// <summary>
        /// Delete a tag for a jobTimeActivity. Deletes an existing jobTimeActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to remove tag from</param>
        /// <param name="jobTimeActivityTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJobTimeActivityTagAsyncWithHttpInfo (int? jobTimeActivityId, string jobTimeActivityTag)
        {
            // verify the required parameter 'jobTimeActivityId' is set
            if (jobTimeActivityId == null) throw new ApiException(400, "Missing required parameter 'jobTimeActivityId' when calling DeleteJobTimeActivityTag");
            // verify the required parameter 'jobTimeActivityTag' is set
            if (jobTimeActivityTag == null) throw new ApiException(400, "Missing required parameter 'jobTimeActivityTag' when calling DeleteJobTimeActivityTag");
            
    
            var localVarPath = "/beta/jobTimeActivity/{jobTimeActivityId}/tag/{jobTimeActivityTag}";
    
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
            if (jobTimeActivityId != null) localVarPathParams.Add("jobTimeActivityId", Configuration.ApiClient.ParameterToString(jobTimeActivityId)); // path parameter
            if (jobTimeActivityTag != null) localVarPathParams.Add("jobTimeActivityTag", Configuration.ApiClient.ParameterToString(jobTimeActivityTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteJobTimeActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJobTimeActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a jobTimeActivity by id Returns a duplicated jobTimeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be duplicated.</param> 
        /// <returns>JobTimeActivity</returns>
        public JobTimeActivity GetDuplicateJobTimeActivityById (int? jobTimeActivityId)
        {
             ApiResponse<JobTimeActivity> localVarResponse = GetDuplicateJobTimeActivityByIdWithHttpInfo(jobTimeActivityId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a jobTimeActivity by id Returns a duplicated jobTimeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be duplicated.</param> 
        /// <returns>ApiResponse of JobTimeActivity</returns>
        public ApiResponse< JobTimeActivity > GetDuplicateJobTimeActivityByIdWithHttpInfo (int? jobTimeActivityId)
        {
            
            // verify the required parameter 'jobTimeActivityId' is set
            if (jobTimeActivityId == null)
                throw new ApiException(400, "Missing required parameter 'jobTimeActivityId' when calling JobTimeActivityApi->GetDuplicateJobTimeActivityById");
            
    
            var localVarPath = "/beta/jobTimeActivity/duplicate/{jobTimeActivityId}";
    
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
            if (jobTimeActivityId != null) localVarPathParams.Add("jobTimeActivityId", Configuration.ApiClient.ParameterToString(jobTimeActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateJobTimeActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateJobTimeActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<JobTimeActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobTimeActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobTimeActivity)));
            
        }

        
        /// <summary>
        /// Get a duplicated a jobTimeActivity by id Returns a duplicated jobTimeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be duplicated.</param>
        /// <returns>Task of JobTimeActivity</returns>
        public async System.Threading.Tasks.Task<JobTimeActivity> GetDuplicateJobTimeActivityByIdAsync (int? jobTimeActivityId)
        {
             ApiResponse<JobTimeActivity> localVarResponse = await GetDuplicateJobTimeActivityByIdAsyncWithHttpInfo(jobTimeActivityId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a jobTimeActivity by id Returns a duplicated jobTimeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be duplicated.</param>
        /// <returns>Task of ApiResponse (JobTimeActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JobTimeActivity>> GetDuplicateJobTimeActivityByIdAsyncWithHttpInfo (int? jobTimeActivityId)
        {
            // verify the required parameter 'jobTimeActivityId' is set
            if (jobTimeActivityId == null) throw new ApiException(400, "Missing required parameter 'jobTimeActivityId' when calling GetDuplicateJobTimeActivityById");
            
    
            var localVarPath = "/beta/jobTimeActivity/duplicate/{jobTimeActivityId}";
    
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
            if (jobTimeActivityId != null) localVarPathParams.Add("jobTimeActivityId", Configuration.ApiClient.ParameterToString(jobTimeActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateJobTimeActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateJobTimeActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JobTimeActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobTimeActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobTimeActivity)));
            
        }
        
        /// <summary>
        /// Search jobTimeActivitys by filter Returns the list of jobTimeActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;JobTimeActivity&gt;</returns>
        public List<JobTimeActivity> GetJobTimeActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<JobTimeActivity>> localVarResponse = GetJobTimeActivityByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search jobTimeActivitys by filter Returns the list of jobTimeActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;JobTimeActivity&gt;</returns>
        public ApiResponse< List<JobTimeActivity> > GetJobTimeActivityByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/jobTimeActivity/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetJobTimeActivityByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJobTimeActivityByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<JobTimeActivity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<JobTimeActivity>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<JobTimeActivity>)));
            
        }

        
        /// <summary>
        /// Search jobTimeActivitys by filter Returns the list of jobTimeActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;JobTimeActivity&gt;</returns>
        public async System.Threading.Tasks.Task<List<JobTimeActivity>> GetJobTimeActivityByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<JobTimeActivity>> localVarResponse = await GetJobTimeActivityByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search jobTimeActivitys by filter Returns the list of jobTimeActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;JobTimeActivity&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<JobTimeActivity>>> GetJobTimeActivityByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/jobTimeActivity/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetJobTimeActivityByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJobTimeActivityByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<JobTimeActivity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<JobTimeActivity>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<JobTimeActivity>)));
            
        }
        
        /// <summary>
        /// Get a jobTimeActivity by id Returns the jobTimeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be returned.</param> 
        /// <returns>JobTimeActivity</returns>
        public JobTimeActivity GetJobTimeActivityById (int? jobTimeActivityId)
        {
             ApiResponse<JobTimeActivity> localVarResponse = GetJobTimeActivityByIdWithHttpInfo(jobTimeActivityId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a jobTimeActivity by id Returns the jobTimeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be returned.</param> 
        /// <returns>ApiResponse of JobTimeActivity</returns>
        public ApiResponse< JobTimeActivity > GetJobTimeActivityByIdWithHttpInfo (int? jobTimeActivityId)
        {
            
            // verify the required parameter 'jobTimeActivityId' is set
            if (jobTimeActivityId == null)
                throw new ApiException(400, "Missing required parameter 'jobTimeActivityId' when calling JobTimeActivityApi->GetJobTimeActivityById");
            
    
            var localVarPath = "/beta/jobTimeActivity/{jobTimeActivityId}";
    
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
            if (jobTimeActivityId != null) localVarPathParams.Add("jobTimeActivityId", Configuration.ApiClient.ParameterToString(jobTimeActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetJobTimeActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJobTimeActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<JobTimeActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobTimeActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobTimeActivity)));
            
        }

        
        /// <summary>
        /// Get a jobTimeActivity by id Returns the jobTimeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be returned.</param>
        /// <returns>Task of JobTimeActivity</returns>
        public async System.Threading.Tasks.Task<JobTimeActivity> GetJobTimeActivityByIdAsync (int? jobTimeActivityId)
        {
             ApiResponse<JobTimeActivity> localVarResponse = await GetJobTimeActivityByIdAsyncWithHttpInfo(jobTimeActivityId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a jobTimeActivity by id Returns the jobTimeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to be returned.</param>
        /// <returns>Task of ApiResponse (JobTimeActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JobTimeActivity>> GetJobTimeActivityByIdAsyncWithHttpInfo (int? jobTimeActivityId)
        {
            // verify the required parameter 'jobTimeActivityId' is set
            if (jobTimeActivityId == null) throw new ApiException(400, "Missing required parameter 'jobTimeActivityId' when calling GetJobTimeActivityById");
            
    
            var localVarPath = "/beta/jobTimeActivity/{jobTimeActivityId}";
    
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
            if (jobTimeActivityId != null) localVarPathParams.Add("jobTimeActivityId", Configuration.ApiClient.ParameterToString(jobTimeActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetJobTimeActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJobTimeActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JobTimeActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobTimeActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobTimeActivity)));
            
        }
        
        /// <summary>
        /// Get the tags for a jobTimeActivity. Get all existing jobTimeActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to get tags for</param> 
        /// <returns></returns>
        public void GetJobTimeActivityTags (int? jobTimeActivityId)
        {
             GetJobTimeActivityTagsWithHttpInfo(jobTimeActivityId);
        }

        /// <summary>
        /// Get the tags for a jobTimeActivity. Get all existing jobTimeActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetJobTimeActivityTagsWithHttpInfo (int? jobTimeActivityId)
        {
            
            // verify the required parameter 'jobTimeActivityId' is set
            if (jobTimeActivityId == null)
                throw new ApiException(400, "Missing required parameter 'jobTimeActivityId' when calling JobTimeActivityApi->GetJobTimeActivityTags");
            
    
            var localVarPath = "/beta/jobTimeActivity/{jobTimeActivityId}/tag";
    
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
            if (jobTimeActivityId != null) localVarPathParams.Add("jobTimeActivityId", Configuration.ApiClient.ParameterToString(jobTimeActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetJobTimeActivityTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJobTimeActivityTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a jobTimeActivity. Get all existing jobTimeActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetJobTimeActivityTagsAsync (int? jobTimeActivityId)
        {
             await GetJobTimeActivityTagsAsyncWithHttpInfo(jobTimeActivityId);

        }

        /// <summary>
        /// Get the tags for a jobTimeActivity. Get all existing jobTimeActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTimeActivityId">Id of the jobTimeActivity to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetJobTimeActivityTagsAsyncWithHttpInfo (int? jobTimeActivityId)
        {
            // verify the required parameter 'jobTimeActivityId' is set
            if (jobTimeActivityId == null) throw new ApiException(400, "Missing required parameter 'jobTimeActivityId' when calling GetJobTimeActivityTags");
            
    
            var localVarPath = "/beta/jobTimeActivity/{jobTimeActivityId}/tag";
    
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
            if (jobTimeActivityId != null) localVarPathParams.Add("jobTimeActivityId", Configuration.ApiClient.ParameterToString(jobTimeActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetJobTimeActivityTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJobTimeActivityTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a jobTimeActivity Updates an existing jobTimeActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobTimeActivity to be updated.</param> 
        /// <returns></returns>
        public void UpdateJobTimeActivity (JobTimeActivity body)
        {
             UpdateJobTimeActivityWithHttpInfo(body);
        }

        /// <summary>
        /// Update a jobTimeActivity Updates an existing jobTimeActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobTimeActivity to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateJobTimeActivityWithHttpInfo (JobTimeActivity body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JobTimeActivityApi->UpdateJobTimeActivity");
            
    
            var localVarPath = "/beta/jobTimeActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateJobTimeActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateJobTimeActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a jobTimeActivity Updates an existing jobTimeActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobTimeActivity to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateJobTimeActivityAsync (JobTimeActivity body)
        {
             await UpdateJobTimeActivityAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a jobTimeActivity Updates an existing jobTimeActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobTimeActivity to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateJobTimeActivityAsyncWithHttpInfo (JobTimeActivity body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateJobTimeActivity");
            
    
            var localVarPath = "/beta/jobTimeActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateJobTimeActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateJobTimeActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
