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
    public interface IJobTypeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a jobType
        /// </summary>
        /// <remarks>
        /// Inserts a new jobType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be inserted.</param>
        /// <returns>JobType</returns>
        JobType AddJobType (JobType body);
  
        /// <summary>
        /// Create a jobType
        /// </summary>
        /// <remarks>
        /// Inserts a new jobType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be inserted.</param>
        /// <returns>ApiResponse of JobType</returns>
        ApiResponse<JobType> AddJobTypeWithHttpInfo (JobType body);
        
        /// <summary>
        /// Add new audit for a jobType
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing jobType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to add an audit to</param>
        /// <param name="jobTypeAudit">The audit to add</param>
        /// <returns></returns>
        void AddJobTypeAudit (int? jobTypeId, string jobTypeAudit);
  
        /// <summary>
        /// Add new audit for a jobType
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing jobType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to add an audit to</param>
        /// <param name="jobTypeAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddJobTypeAuditWithHttpInfo (int? jobTypeId, string jobTypeAudit);
        
        /// <summary>
        /// Add new tags for a jobType.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing jobType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to add a tag to</param>
        /// <param name="jobTypeTag">The tag to add</param>
        /// <returns></returns>
        void AddJobTypeTag (int? jobTypeId, string jobTypeTag);
  
        /// <summary>
        /// Add new tags for a jobType.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing jobType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to add a tag to</param>
        /// <param name="jobTypeTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddJobTypeTagWithHttpInfo (int? jobTypeId, string jobTypeTag);
        
        /// <summary>
        /// Delete a jobType
        /// </summary>
        /// <remarks>
        /// Deletes the jobType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be deleted.</param>
        /// <returns></returns>
        void DeleteJobType (int? jobTypeId);
  
        /// <summary>
        /// Delete a jobType
        /// </summary>
        /// <remarks>
        /// Deletes the jobType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteJobTypeWithHttpInfo (int? jobTypeId);
        
        /// <summary>
        /// Delete a tag for a jobType.
        /// </summary>
        /// <remarks>
        /// Deletes an existing jobType tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to remove tag from</param>
        /// <param name="jobTypeTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteJobTypeTag (int? jobTypeId, string jobTypeTag);
  
        /// <summary>
        /// Delete a tag for a jobType.
        /// </summary>
        /// <remarks>
        /// Deletes an existing jobType tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to remove tag from</param>
        /// <param name="jobTypeTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteJobTypeTagWithHttpInfo (int? jobTypeId, string jobTypeTag);
        
        /// <summary>
        /// Get a duplicated a jobType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated jobType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be duplicated.</param>
        /// <returns>JobType</returns>
        JobType GetDuplicateJobTypeById (int? jobTypeId);
  
        /// <summary>
        /// Get a duplicated a jobType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated jobType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be duplicated.</param>
        /// <returns>ApiResponse of JobType</returns>
        ApiResponse<JobType> GetDuplicateJobTypeByIdWithHttpInfo (int? jobTypeId);
        
        /// <summary>
        /// Search jobTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of jobTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;JobType&gt;</returns>
        List<JobType> GetJobTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search jobTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of jobTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;JobType&gt;</returns>
        ApiResponse<List<JobType>> GetJobTypeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a jobType by id
        /// </summary>
        /// <remarks>
        /// Returns the jobType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be returned.</param>
        /// <returns>JobType</returns>
        JobType GetJobTypeById (int? jobTypeId);
  
        /// <summary>
        /// Get a jobType by id
        /// </summary>
        /// <remarks>
        /// Returns the jobType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be returned.</param>
        /// <returns>ApiResponse of JobType</returns>
        ApiResponse<JobType> GetJobTypeByIdWithHttpInfo (int? jobTypeId);
        
        /// <summary>
        /// Get the tags for a jobType.
        /// </summary>
        /// <remarks>
        /// Get all existing jobType tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to get tags for</param>
        /// <returns></returns>
        void GetJobTypeTags (int? jobTypeId);
  
        /// <summary>
        /// Get the tags for a jobType.
        /// </summary>
        /// <remarks>
        /// Get all existing jobType tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetJobTypeTagsWithHttpInfo (int? jobTypeId);
        
        /// <summary>
        /// Update a jobType
        /// </summary>
        /// <remarks>
        /// Updates an existing jobType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be updated.</param>
        /// <returns></returns>
        void UpdateJobType (JobType body);
  
        /// <summary>
        /// Update a jobType
        /// </summary>
        /// <remarks>
        /// Updates an existing jobType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateJobTypeWithHttpInfo (JobType body);
        
        /// <summary>
        /// Update a jobType custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing jobType custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be updated.</param>
        /// <returns></returns>
        void UpdateJobTypeCustomFields (JobType body);
  
        /// <summary>
        /// Update a jobType custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing jobType custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateJobTypeCustomFieldsWithHttpInfo (JobType body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a jobType
        /// </summary>
        /// <remarks>
        /// Inserts a new jobType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be inserted.</param>
        /// <returns>Task of JobType</returns>
        System.Threading.Tasks.Task<JobType> AddJobTypeAsync (JobType body);

        /// <summary>
        /// Create a jobType
        /// </summary>
        /// <remarks>
        /// Inserts a new jobType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be inserted.</param>
        /// <returns>Task of ApiResponse (JobType)</returns>
        System.Threading.Tasks.Task<ApiResponse<JobType>> AddJobTypeAsyncWithHttpInfo (JobType body);
        
        /// <summary>
        /// Add new audit for a jobType
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing jobType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to add an audit to</param>
        /// <param name="jobTypeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddJobTypeAuditAsync (int? jobTypeId, string jobTypeAudit);

        /// <summary>
        /// Add new audit for a jobType
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing jobType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to add an audit to</param>
        /// <param name="jobTypeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddJobTypeAuditAsyncWithHttpInfo (int? jobTypeId, string jobTypeAudit);
        
        /// <summary>
        /// Add new tags for a jobType.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing jobType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to add a tag to</param>
        /// <param name="jobTypeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddJobTypeTagAsync (int? jobTypeId, string jobTypeTag);

        /// <summary>
        /// Add new tags for a jobType.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing jobType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to add a tag to</param>
        /// <param name="jobTypeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddJobTypeTagAsyncWithHttpInfo (int? jobTypeId, string jobTypeTag);
        
        /// <summary>
        /// Delete a jobType
        /// </summary>
        /// <remarks>
        /// Deletes the jobType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteJobTypeAsync (int? jobTypeId);

        /// <summary>
        /// Delete a jobType
        /// </summary>
        /// <remarks>
        /// Deletes the jobType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJobTypeAsyncWithHttpInfo (int? jobTypeId);
        
        /// <summary>
        /// Delete a tag for a jobType.
        /// </summary>
        /// <remarks>
        /// Deletes an existing jobType tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to remove tag from</param>
        /// <param name="jobTypeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteJobTypeTagAsync (int? jobTypeId, string jobTypeTag);

        /// <summary>
        /// Delete a tag for a jobType.
        /// </summary>
        /// <remarks>
        /// Deletes an existing jobType tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to remove tag from</param>
        /// <param name="jobTypeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJobTypeTagAsyncWithHttpInfo (int? jobTypeId, string jobTypeTag);
        
        /// <summary>
        /// Get a duplicated a jobType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated jobType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be duplicated.</param>
        /// <returns>Task of JobType</returns>
        System.Threading.Tasks.Task<JobType> GetDuplicateJobTypeByIdAsync (int? jobTypeId);

        /// <summary>
        /// Get a duplicated a jobType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated jobType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be duplicated.</param>
        /// <returns>Task of ApiResponse (JobType)</returns>
        System.Threading.Tasks.Task<ApiResponse<JobType>> GetDuplicateJobTypeByIdAsyncWithHttpInfo (int? jobTypeId);
        
        /// <summary>
        /// Search jobTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of jobTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;JobType&gt;</returns>
        System.Threading.Tasks.Task<List<JobType>> GetJobTypeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search jobTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of jobTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;JobType&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<JobType>>> GetJobTypeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a jobType by id
        /// </summary>
        /// <remarks>
        /// Returns the jobType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be returned.</param>
        /// <returns>Task of JobType</returns>
        System.Threading.Tasks.Task<JobType> GetJobTypeByIdAsync (int? jobTypeId);

        /// <summary>
        /// Get a jobType by id
        /// </summary>
        /// <remarks>
        /// Returns the jobType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be returned.</param>
        /// <returns>Task of ApiResponse (JobType)</returns>
        System.Threading.Tasks.Task<ApiResponse<JobType>> GetJobTypeByIdAsyncWithHttpInfo (int? jobTypeId);
        
        /// <summary>
        /// Get the tags for a jobType.
        /// </summary>
        /// <remarks>
        /// Get all existing jobType tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetJobTypeTagsAsync (int? jobTypeId);

        /// <summary>
        /// Get the tags for a jobType.
        /// </summary>
        /// <remarks>
        /// Get all existing jobType tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetJobTypeTagsAsyncWithHttpInfo (int? jobTypeId);
        
        /// <summary>
        /// Update a jobType
        /// </summary>
        /// <remarks>
        /// Updates an existing jobType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateJobTypeAsync (JobType body);

        /// <summary>
        /// Update a jobType
        /// </summary>
        /// <remarks>
        /// Updates an existing jobType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateJobTypeAsyncWithHttpInfo (JobType body);
        
        /// <summary>
        /// Update a jobType custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing jobType custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateJobTypeCustomFieldsAsync (JobType body);

        /// <summary>
        /// Update a jobType custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing jobType custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateJobTypeCustomFieldsAsyncWithHttpInfo (JobType body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class JobTypeApi : IJobTypeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTypeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public JobTypeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTypeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public JobTypeApi(Configuration configuration = null)
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
        /// Create a jobType Inserts a new jobType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be inserted.</param> 
        /// <returns>JobType</returns>
        public JobType AddJobType (JobType body)
        {
             ApiResponse<JobType> localVarResponse = AddJobTypeWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a jobType Inserts a new jobType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be inserted.</param> 
        /// <returns>ApiResponse of JobType</returns>
        public ApiResponse< JobType > AddJobTypeWithHttpInfo (JobType body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JobTypeApi->AddJobType");
            
    
            var localVarPath = "/beta/jobType";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddJobType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddJobType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<JobType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobType)));
            
        }

        
        /// <summary>
        /// Create a jobType Inserts a new jobType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be inserted.</param>
        /// <returns>Task of JobType</returns>
        public async System.Threading.Tasks.Task<JobType> AddJobTypeAsync (JobType body)
        {
             ApiResponse<JobType> localVarResponse = await AddJobTypeAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a jobType Inserts a new jobType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be inserted.</param>
        /// <returns>Task of ApiResponse (JobType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JobType>> AddJobTypeAsyncWithHttpInfo (JobType body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddJobType");
            
    
            var localVarPath = "/beta/jobType";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddJobType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddJobType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JobType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobType)));
            
        }
        
        /// <summary>
        /// Add new audit for a jobType Adds an audit to an existing jobType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to add an audit to</param> 
        /// <param name="jobTypeAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddJobTypeAudit (int? jobTypeId, string jobTypeAudit)
        {
             AddJobTypeAuditWithHttpInfo(jobTypeId, jobTypeAudit);
        }

        /// <summary>
        /// Add new audit for a jobType Adds an audit to an existing jobType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to add an audit to</param> 
        /// <param name="jobTypeAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddJobTypeAuditWithHttpInfo (int? jobTypeId, string jobTypeAudit)
        {
            
            // verify the required parameter 'jobTypeId' is set
            if (jobTypeId == null)
                throw new ApiException(400, "Missing required parameter 'jobTypeId' when calling JobTypeApi->AddJobTypeAudit");
            
            // verify the required parameter 'jobTypeAudit' is set
            if (jobTypeAudit == null)
                throw new ApiException(400, "Missing required parameter 'jobTypeAudit' when calling JobTypeApi->AddJobTypeAudit");
            
    
            var localVarPath = "/beta/jobType/{jobTypeId}/audit/{jobTypeAudit}";
    
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
            if (jobTypeId != null) localVarPathParams.Add("jobTypeId", Configuration.ApiClient.ParameterToString(jobTypeId)); // path parameter
            if (jobTypeAudit != null) localVarPathParams.Add("jobTypeAudit", Configuration.ApiClient.ParameterToString(jobTypeAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddJobTypeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddJobTypeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a jobType Adds an audit to an existing jobType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to add an audit to</param>
        /// <param name="jobTypeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddJobTypeAuditAsync (int? jobTypeId, string jobTypeAudit)
        {
             await AddJobTypeAuditAsyncWithHttpInfo(jobTypeId, jobTypeAudit);

        }

        /// <summary>
        /// Add new audit for a jobType Adds an audit to an existing jobType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to add an audit to</param>
        /// <param name="jobTypeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddJobTypeAuditAsyncWithHttpInfo (int? jobTypeId, string jobTypeAudit)
        {
            // verify the required parameter 'jobTypeId' is set
            if (jobTypeId == null) throw new ApiException(400, "Missing required parameter 'jobTypeId' when calling AddJobTypeAudit");
            // verify the required parameter 'jobTypeAudit' is set
            if (jobTypeAudit == null) throw new ApiException(400, "Missing required parameter 'jobTypeAudit' when calling AddJobTypeAudit");
            
    
            var localVarPath = "/beta/jobType/{jobTypeId}/audit/{jobTypeAudit}";
    
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
            if (jobTypeId != null) localVarPathParams.Add("jobTypeId", Configuration.ApiClient.ParameterToString(jobTypeId)); // path parameter
            if (jobTypeAudit != null) localVarPathParams.Add("jobTypeAudit", Configuration.ApiClient.ParameterToString(jobTypeAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddJobTypeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddJobTypeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a jobType. Adds a tag to an existing jobType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to add a tag to</param> 
        /// <param name="jobTypeTag">The tag to add</param> 
        /// <returns></returns>
        public void AddJobTypeTag (int? jobTypeId, string jobTypeTag)
        {
             AddJobTypeTagWithHttpInfo(jobTypeId, jobTypeTag);
        }

        /// <summary>
        /// Add new tags for a jobType. Adds a tag to an existing jobType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to add a tag to</param> 
        /// <param name="jobTypeTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddJobTypeTagWithHttpInfo (int? jobTypeId, string jobTypeTag)
        {
            
            // verify the required parameter 'jobTypeId' is set
            if (jobTypeId == null)
                throw new ApiException(400, "Missing required parameter 'jobTypeId' when calling JobTypeApi->AddJobTypeTag");
            
            // verify the required parameter 'jobTypeTag' is set
            if (jobTypeTag == null)
                throw new ApiException(400, "Missing required parameter 'jobTypeTag' when calling JobTypeApi->AddJobTypeTag");
            
    
            var localVarPath = "/beta/jobType/{jobTypeId}/tag/{jobTypeTag}";
    
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
            if (jobTypeId != null) localVarPathParams.Add("jobTypeId", Configuration.ApiClient.ParameterToString(jobTypeId)); // path parameter
            if (jobTypeTag != null) localVarPathParams.Add("jobTypeTag", Configuration.ApiClient.ParameterToString(jobTypeTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddJobTypeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddJobTypeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a jobType. Adds a tag to an existing jobType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to add a tag to</param>
        /// <param name="jobTypeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddJobTypeTagAsync (int? jobTypeId, string jobTypeTag)
        {
             await AddJobTypeTagAsyncWithHttpInfo(jobTypeId, jobTypeTag);

        }

        /// <summary>
        /// Add new tags for a jobType. Adds a tag to an existing jobType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to add a tag to</param>
        /// <param name="jobTypeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddJobTypeTagAsyncWithHttpInfo (int? jobTypeId, string jobTypeTag)
        {
            // verify the required parameter 'jobTypeId' is set
            if (jobTypeId == null) throw new ApiException(400, "Missing required parameter 'jobTypeId' when calling AddJobTypeTag");
            // verify the required parameter 'jobTypeTag' is set
            if (jobTypeTag == null) throw new ApiException(400, "Missing required parameter 'jobTypeTag' when calling AddJobTypeTag");
            
    
            var localVarPath = "/beta/jobType/{jobTypeId}/tag/{jobTypeTag}";
    
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
            if (jobTypeId != null) localVarPathParams.Add("jobTypeId", Configuration.ApiClient.ParameterToString(jobTypeId)); // path parameter
            if (jobTypeTag != null) localVarPathParams.Add("jobTypeTag", Configuration.ApiClient.ParameterToString(jobTypeTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddJobTypeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddJobTypeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a jobType Deletes the jobType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be deleted.</param> 
        /// <returns></returns>
        public void DeleteJobType (int? jobTypeId)
        {
             DeleteJobTypeWithHttpInfo(jobTypeId);
        }

        /// <summary>
        /// Delete a jobType Deletes the jobType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteJobTypeWithHttpInfo (int? jobTypeId)
        {
            
            // verify the required parameter 'jobTypeId' is set
            if (jobTypeId == null)
                throw new ApiException(400, "Missing required parameter 'jobTypeId' when calling JobTypeApi->DeleteJobType");
            
    
            var localVarPath = "/beta/jobType/{jobTypeId}";
    
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
            if (jobTypeId != null) localVarPathParams.Add("jobTypeId", Configuration.ApiClient.ParameterToString(jobTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteJobType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJobType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a jobType Deletes the jobType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteJobTypeAsync (int? jobTypeId)
        {
             await DeleteJobTypeAsyncWithHttpInfo(jobTypeId);

        }

        /// <summary>
        /// Delete a jobType Deletes the jobType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJobTypeAsyncWithHttpInfo (int? jobTypeId)
        {
            // verify the required parameter 'jobTypeId' is set
            if (jobTypeId == null) throw new ApiException(400, "Missing required parameter 'jobTypeId' when calling DeleteJobType");
            
    
            var localVarPath = "/beta/jobType/{jobTypeId}";
    
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
            if (jobTypeId != null) localVarPathParams.Add("jobTypeId", Configuration.ApiClient.ParameterToString(jobTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteJobType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJobType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a jobType. Deletes an existing jobType tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to remove tag from</param> 
        /// <param name="jobTypeTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteJobTypeTag (int? jobTypeId, string jobTypeTag)
        {
             DeleteJobTypeTagWithHttpInfo(jobTypeId, jobTypeTag);
        }

        /// <summary>
        /// Delete a tag for a jobType. Deletes an existing jobType tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to remove tag from</param> 
        /// <param name="jobTypeTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteJobTypeTagWithHttpInfo (int? jobTypeId, string jobTypeTag)
        {
            
            // verify the required parameter 'jobTypeId' is set
            if (jobTypeId == null)
                throw new ApiException(400, "Missing required parameter 'jobTypeId' when calling JobTypeApi->DeleteJobTypeTag");
            
            // verify the required parameter 'jobTypeTag' is set
            if (jobTypeTag == null)
                throw new ApiException(400, "Missing required parameter 'jobTypeTag' when calling JobTypeApi->DeleteJobTypeTag");
            
    
            var localVarPath = "/beta/jobType/{jobTypeId}/tag/{jobTypeTag}";
    
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
            if (jobTypeId != null) localVarPathParams.Add("jobTypeId", Configuration.ApiClient.ParameterToString(jobTypeId)); // path parameter
            if (jobTypeTag != null) localVarPathParams.Add("jobTypeTag", Configuration.ApiClient.ParameterToString(jobTypeTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteJobTypeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJobTypeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a jobType. Deletes an existing jobType tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to remove tag from</param>
        /// <param name="jobTypeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteJobTypeTagAsync (int? jobTypeId, string jobTypeTag)
        {
             await DeleteJobTypeTagAsyncWithHttpInfo(jobTypeId, jobTypeTag);

        }

        /// <summary>
        /// Delete a tag for a jobType. Deletes an existing jobType tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to remove tag from</param>
        /// <param name="jobTypeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteJobTypeTagAsyncWithHttpInfo (int? jobTypeId, string jobTypeTag)
        {
            // verify the required parameter 'jobTypeId' is set
            if (jobTypeId == null) throw new ApiException(400, "Missing required parameter 'jobTypeId' when calling DeleteJobTypeTag");
            // verify the required parameter 'jobTypeTag' is set
            if (jobTypeTag == null) throw new ApiException(400, "Missing required parameter 'jobTypeTag' when calling DeleteJobTypeTag");
            
    
            var localVarPath = "/beta/jobType/{jobTypeId}/tag/{jobTypeTag}";
    
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
            if (jobTypeId != null) localVarPathParams.Add("jobTypeId", Configuration.ApiClient.ParameterToString(jobTypeId)); // path parameter
            if (jobTypeTag != null) localVarPathParams.Add("jobTypeTag", Configuration.ApiClient.ParameterToString(jobTypeTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteJobTypeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteJobTypeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a jobType by id Returns a duplicated jobType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be duplicated.</param> 
        /// <returns>JobType</returns>
        public JobType GetDuplicateJobTypeById (int? jobTypeId)
        {
             ApiResponse<JobType> localVarResponse = GetDuplicateJobTypeByIdWithHttpInfo(jobTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a jobType by id Returns a duplicated jobType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be duplicated.</param> 
        /// <returns>ApiResponse of JobType</returns>
        public ApiResponse< JobType > GetDuplicateJobTypeByIdWithHttpInfo (int? jobTypeId)
        {
            
            // verify the required parameter 'jobTypeId' is set
            if (jobTypeId == null)
                throw new ApiException(400, "Missing required parameter 'jobTypeId' when calling JobTypeApi->GetDuplicateJobTypeById");
            
    
            var localVarPath = "/beta/jobType/duplicate/{jobTypeId}";
    
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
            if (jobTypeId != null) localVarPathParams.Add("jobTypeId", Configuration.ApiClient.ParameterToString(jobTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateJobTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateJobTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<JobType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobType)));
            
        }

        
        /// <summary>
        /// Get a duplicated a jobType by id Returns a duplicated jobType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be duplicated.</param>
        /// <returns>Task of JobType</returns>
        public async System.Threading.Tasks.Task<JobType> GetDuplicateJobTypeByIdAsync (int? jobTypeId)
        {
             ApiResponse<JobType> localVarResponse = await GetDuplicateJobTypeByIdAsyncWithHttpInfo(jobTypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a jobType by id Returns a duplicated jobType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be duplicated.</param>
        /// <returns>Task of ApiResponse (JobType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JobType>> GetDuplicateJobTypeByIdAsyncWithHttpInfo (int? jobTypeId)
        {
            // verify the required parameter 'jobTypeId' is set
            if (jobTypeId == null) throw new ApiException(400, "Missing required parameter 'jobTypeId' when calling GetDuplicateJobTypeById");
            
    
            var localVarPath = "/beta/jobType/duplicate/{jobTypeId}";
    
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
            if (jobTypeId != null) localVarPathParams.Add("jobTypeId", Configuration.ApiClient.ParameterToString(jobTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateJobTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateJobTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JobType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobType)));
            
        }
        
        /// <summary>
        /// Search jobTypes by filter Returns the list of jobTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;JobType&gt;</returns>
        public List<JobType> GetJobTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<JobType>> localVarResponse = GetJobTypeByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search jobTypes by filter Returns the list of jobTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;JobType&gt;</returns>
        public ApiResponse< List<JobType> > GetJobTypeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/jobType/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetJobTypeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJobTypeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<JobType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<JobType>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<JobType>)));
            
        }

        
        /// <summary>
        /// Search jobTypes by filter Returns the list of jobTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;JobType&gt;</returns>
        public async System.Threading.Tasks.Task<List<JobType>> GetJobTypeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<JobType>> localVarResponse = await GetJobTypeByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search jobTypes by filter Returns the list of jobTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;JobType&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<JobType>>> GetJobTypeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/jobType/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetJobTypeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJobTypeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<JobType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<JobType>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<JobType>)));
            
        }
        
        /// <summary>
        /// Get a jobType by id Returns the jobType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be returned.</param> 
        /// <returns>JobType</returns>
        public JobType GetJobTypeById (int? jobTypeId)
        {
             ApiResponse<JobType> localVarResponse = GetJobTypeByIdWithHttpInfo(jobTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a jobType by id Returns the jobType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be returned.</param> 
        /// <returns>ApiResponse of JobType</returns>
        public ApiResponse< JobType > GetJobTypeByIdWithHttpInfo (int? jobTypeId)
        {
            
            // verify the required parameter 'jobTypeId' is set
            if (jobTypeId == null)
                throw new ApiException(400, "Missing required parameter 'jobTypeId' when calling JobTypeApi->GetJobTypeById");
            
    
            var localVarPath = "/beta/jobType/{jobTypeId}";
    
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
            if (jobTypeId != null) localVarPathParams.Add("jobTypeId", Configuration.ApiClient.ParameterToString(jobTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetJobTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJobTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<JobType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobType)));
            
        }

        
        /// <summary>
        /// Get a jobType by id Returns the jobType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be returned.</param>
        /// <returns>Task of JobType</returns>
        public async System.Threading.Tasks.Task<JobType> GetJobTypeByIdAsync (int? jobTypeId)
        {
             ApiResponse<JobType> localVarResponse = await GetJobTypeByIdAsyncWithHttpInfo(jobTypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a jobType by id Returns the jobType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to be returned.</param>
        /// <returns>Task of ApiResponse (JobType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JobType>> GetJobTypeByIdAsyncWithHttpInfo (int? jobTypeId)
        {
            // verify the required parameter 'jobTypeId' is set
            if (jobTypeId == null) throw new ApiException(400, "Missing required parameter 'jobTypeId' when calling GetJobTypeById");
            
    
            var localVarPath = "/beta/jobType/{jobTypeId}";
    
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
            if (jobTypeId != null) localVarPathParams.Add("jobTypeId", Configuration.ApiClient.ParameterToString(jobTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetJobTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJobTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<JobType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(JobType)));
            
        }
        
        /// <summary>
        /// Get the tags for a jobType. Get all existing jobType tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to get tags for</param> 
        /// <returns></returns>
        public void GetJobTypeTags (int? jobTypeId)
        {
             GetJobTypeTagsWithHttpInfo(jobTypeId);
        }

        /// <summary>
        /// Get the tags for a jobType. Get all existing jobType tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetJobTypeTagsWithHttpInfo (int? jobTypeId)
        {
            
            // verify the required parameter 'jobTypeId' is set
            if (jobTypeId == null)
                throw new ApiException(400, "Missing required parameter 'jobTypeId' when calling JobTypeApi->GetJobTypeTags");
            
    
            var localVarPath = "/beta/jobType/{jobTypeId}/tag";
    
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
            if (jobTypeId != null) localVarPathParams.Add("jobTypeId", Configuration.ApiClient.ParameterToString(jobTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetJobTypeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJobTypeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a jobType. Get all existing jobType tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetJobTypeTagsAsync (int? jobTypeId)
        {
             await GetJobTypeTagsAsyncWithHttpInfo(jobTypeId);

        }

        /// <summary>
        /// Get the tags for a jobType. Get all existing jobType tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobTypeId">Id of the jobType to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetJobTypeTagsAsyncWithHttpInfo (int? jobTypeId)
        {
            // verify the required parameter 'jobTypeId' is set
            if (jobTypeId == null) throw new ApiException(400, "Missing required parameter 'jobTypeId' when calling GetJobTypeTags");
            
    
            var localVarPath = "/beta/jobType/{jobTypeId}/tag";
    
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
            if (jobTypeId != null) localVarPathParams.Add("jobTypeId", Configuration.ApiClient.ParameterToString(jobTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetJobTypeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetJobTypeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a jobType Updates an existing jobType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be updated.</param> 
        /// <returns></returns>
        public void UpdateJobType (JobType body)
        {
             UpdateJobTypeWithHttpInfo(body);
        }

        /// <summary>
        /// Update a jobType Updates an existing jobType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateJobTypeWithHttpInfo (JobType body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JobTypeApi->UpdateJobType");
            
    
            var localVarPath = "/beta/jobType";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateJobType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateJobType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a jobType Updates an existing jobType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateJobTypeAsync (JobType body)
        {
             await UpdateJobTypeAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a jobType Updates an existing jobType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateJobTypeAsyncWithHttpInfo (JobType body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateJobType");
            
    
            var localVarPath = "/beta/jobType";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateJobType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateJobType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a jobType custom fields Updates an existing jobType custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be updated.</param> 
        /// <returns></returns>
        public void UpdateJobTypeCustomFields (JobType body)
        {
             UpdateJobTypeCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a jobType custom fields Updates an existing jobType custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateJobTypeCustomFieldsWithHttpInfo (JobType body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling JobTypeApi->UpdateJobTypeCustomFields");
            
    
            var localVarPath = "/beta/jobType/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateJobTypeCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateJobTypeCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a jobType custom fields Updates an existing jobType custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateJobTypeCustomFieldsAsync (JobType body)
        {
             await UpdateJobTypeCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a jobType custom fields Updates an existing jobType custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">JobType to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateJobTypeCustomFieldsAsyncWithHttpInfo (JobType body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateJobTypeCustomFields");
            
    
            var localVarPath = "/beta/jobType/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateJobTypeCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateJobTypeCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
