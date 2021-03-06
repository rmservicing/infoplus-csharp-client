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
    public interface ICartonActivityApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a cartonActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new cartonActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonActivity to be inserted.</param>
        /// <returns>CartonActivity</returns>
        CartonActivity AddCartonActivity (CartonActivity body);
  
        /// <summary>
        /// Create a cartonActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new cartonActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonActivity to be inserted.</param>
        /// <returns>ApiResponse of CartonActivity</returns>
        ApiResponse<CartonActivity> AddCartonActivityWithHttpInfo (CartonActivity body);
        
        /// <summary>
        /// Add new audit for a cartonActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing cartonActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to add an audit to</param>
        /// <param name="cartonActivityAudit">The audit to add</param>
        /// <returns></returns>
        void AddCartonActivityAudit (int? cartonActivityId, string cartonActivityAudit);
  
        /// <summary>
        /// Add new audit for a cartonActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing cartonActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to add an audit to</param>
        /// <param name="cartonActivityAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddCartonActivityAuditWithHttpInfo (int? cartonActivityId, string cartonActivityAudit);
        
        /// <summary>
        /// Add new tags for a cartonActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing cartonActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to add a tag to</param>
        /// <param name="cartonActivityTag">The tag to add</param>
        /// <returns></returns>
        void AddCartonActivityTag (int? cartonActivityId, string cartonActivityTag);
  
        /// <summary>
        /// Add new tags for a cartonActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing cartonActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to add a tag to</param>
        /// <param name="cartonActivityTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddCartonActivityTagWithHttpInfo (int? cartonActivityId, string cartonActivityTag);
        
        /// <summary>
        /// Delete a cartonActivity
        /// </summary>
        /// <remarks>
        /// Deletes the cartonActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be deleted.</param>
        /// <returns></returns>
        void DeleteCartonActivity (int? cartonActivityId);
  
        /// <summary>
        /// Delete a cartonActivity
        /// </summary>
        /// <remarks>
        /// Deletes the cartonActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCartonActivityWithHttpInfo (int? cartonActivityId);
        
        /// <summary>
        /// Delete a tag for a cartonActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing cartonActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to remove tag from</param>
        /// <param name="cartonActivityTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteCartonActivityTag (int? cartonActivityId, string cartonActivityTag);
  
        /// <summary>
        /// Delete a tag for a cartonActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing cartonActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to remove tag from</param>
        /// <param name="cartonActivityTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCartonActivityTagWithHttpInfo (int? cartonActivityId, string cartonActivityTag);
        
        /// <summary>
        /// Search cartonActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of cartonActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;CartonActivity&gt;</returns>
        List<CartonActivity> GetCartonActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search cartonActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of cartonActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;CartonActivity&gt;</returns>
        ApiResponse<List<CartonActivity>> GetCartonActivityByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a cartonActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the cartonActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be returned.</param>
        /// <returns>CartonActivity</returns>
        CartonActivity GetCartonActivityById (int? cartonActivityId);
  
        /// <summary>
        /// Get a cartonActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the cartonActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be returned.</param>
        /// <returns>ApiResponse of CartonActivity</returns>
        ApiResponse<CartonActivity> GetCartonActivityByIdWithHttpInfo (int? cartonActivityId);
        
        /// <summary>
        /// Get the tags for a cartonActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing cartonActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to get tags for</param>
        /// <returns></returns>
        void GetCartonActivityTags (int? cartonActivityId);
  
        /// <summary>
        /// Get the tags for a cartonActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing cartonActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetCartonActivityTagsWithHttpInfo (int? cartonActivityId);
        
        /// <summary>
        /// Get a duplicated a cartonActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated cartonActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be duplicated.</param>
        /// <returns>CartonActivity</returns>
        CartonActivity GetDuplicateCartonActivityById (int? cartonActivityId);
  
        /// <summary>
        /// Get a duplicated a cartonActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated cartonActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be duplicated.</param>
        /// <returns>ApiResponse of CartonActivity</returns>
        ApiResponse<CartonActivity> GetDuplicateCartonActivityByIdWithHttpInfo (int? cartonActivityId);
        
        /// <summary>
        /// Update a cartonActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing cartonActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonActivity to be updated.</param>
        /// <returns></returns>
        void UpdateCartonActivity (CartonActivity body);
  
        /// <summary>
        /// Update a cartonActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing cartonActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonActivity to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateCartonActivityWithHttpInfo (CartonActivity body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a cartonActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new cartonActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonActivity to be inserted.</param>
        /// <returns>Task of CartonActivity</returns>
        System.Threading.Tasks.Task<CartonActivity> AddCartonActivityAsync (CartonActivity body);

        /// <summary>
        /// Create a cartonActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new cartonActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonActivity to be inserted.</param>
        /// <returns>Task of ApiResponse (CartonActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartonActivity>> AddCartonActivityAsyncWithHttpInfo (CartonActivity body);
        
        /// <summary>
        /// Add new audit for a cartonActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing cartonActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to add an audit to</param>
        /// <param name="cartonActivityAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddCartonActivityAuditAsync (int? cartonActivityId, string cartonActivityAudit);

        /// <summary>
        /// Add new audit for a cartonActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing cartonActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to add an audit to</param>
        /// <param name="cartonActivityAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddCartonActivityAuditAsyncWithHttpInfo (int? cartonActivityId, string cartonActivityAudit);
        
        /// <summary>
        /// Add new tags for a cartonActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing cartonActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to add a tag to</param>
        /// <param name="cartonActivityTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddCartonActivityTagAsync (int? cartonActivityId, string cartonActivityTag);

        /// <summary>
        /// Add new tags for a cartonActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing cartonActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to add a tag to</param>
        /// <param name="cartonActivityTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddCartonActivityTagAsyncWithHttpInfo (int? cartonActivityId, string cartonActivityTag);
        
        /// <summary>
        /// Delete a cartonActivity
        /// </summary>
        /// <remarks>
        /// Deletes the cartonActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCartonActivityAsync (int? cartonActivityId);

        /// <summary>
        /// Delete a cartonActivity
        /// </summary>
        /// <remarks>
        /// Deletes the cartonActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCartonActivityAsyncWithHttpInfo (int? cartonActivityId);
        
        /// <summary>
        /// Delete a tag for a cartonActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing cartonActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to remove tag from</param>
        /// <param name="cartonActivityTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCartonActivityTagAsync (int? cartonActivityId, string cartonActivityTag);

        /// <summary>
        /// Delete a tag for a cartonActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing cartonActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to remove tag from</param>
        /// <param name="cartonActivityTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCartonActivityTagAsyncWithHttpInfo (int? cartonActivityId, string cartonActivityTag);
        
        /// <summary>
        /// Search cartonActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of cartonActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;CartonActivity&gt;</returns>
        System.Threading.Tasks.Task<List<CartonActivity>> GetCartonActivityByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search cartonActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of cartonActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CartonActivity&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CartonActivity>>> GetCartonActivityByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a cartonActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the cartonActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be returned.</param>
        /// <returns>Task of CartonActivity</returns>
        System.Threading.Tasks.Task<CartonActivity> GetCartonActivityByIdAsync (int? cartonActivityId);

        /// <summary>
        /// Get a cartonActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the cartonActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be returned.</param>
        /// <returns>Task of ApiResponse (CartonActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartonActivity>> GetCartonActivityByIdAsyncWithHttpInfo (int? cartonActivityId);
        
        /// <summary>
        /// Get the tags for a cartonActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing cartonActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetCartonActivityTagsAsync (int? cartonActivityId);

        /// <summary>
        /// Get the tags for a cartonActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing cartonActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetCartonActivityTagsAsyncWithHttpInfo (int? cartonActivityId);
        
        /// <summary>
        /// Get a duplicated a cartonActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated cartonActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be duplicated.</param>
        /// <returns>Task of CartonActivity</returns>
        System.Threading.Tasks.Task<CartonActivity> GetDuplicateCartonActivityByIdAsync (int? cartonActivityId);

        /// <summary>
        /// Get a duplicated a cartonActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated cartonActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be duplicated.</param>
        /// <returns>Task of ApiResponse (CartonActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartonActivity>> GetDuplicateCartonActivityByIdAsyncWithHttpInfo (int? cartonActivityId);
        
        /// <summary>
        /// Update a cartonActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing cartonActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonActivity to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateCartonActivityAsync (CartonActivity body);

        /// <summary>
        /// Update a cartonActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing cartonActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonActivity to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCartonActivityAsyncWithHttpInfo (CartonActivity body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CartonActivityApi : ICartonActivityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartonActivityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CartonActivityApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartonActivityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CartonActivityApi(Configuration configuration = null)
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
        /// Create a cartonActivity Inserts a new cartonActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonActivity to be inserted.</param> 
        /// <returns>CartonActivity</returns>
        public CartonActivity AddCartonActivity (CartonActivity body)
        {
             ApiResponse<CartonActivity> localVarResponse = AddCartonActivityWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a cartonActivity Inserts a new cartonActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonActivity to be inserted.</param> 
        /// <returns>ApiResponse of CartonActivity</returns>
        public ApiResponse< CartonActivity > AddCartonActivityWithHttpInfo (CartonActivity body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CartonActivityApi->AddCartonActivity");
            
    
            var localVarPath = "/beta/cartonActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddCartonActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCartonActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartonActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartonActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartonActivity)));
            
        }

        
        /// <summary>
        /// Create a cartonActivity Inserts a new cartonActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonActivity to be inserted.</param>
        /// <returns>Task of CartonActivity</returns>
        public async System.Threading.Tasks.Task<CartonActivity> AddCartonActivityAsync (CartonActivity body)
        {
             ApiResponse<CartonActivity> localVarResponse = await AddCartonActivityAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a cartonActivity Inserts a new cartonActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonActivity to be inserted.</param>
        /// <returns>Task of ApiResponse (CartonActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartonActivity>> AddCartonActivityAsyncWithHttpInfo (CartonActivity body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddCartonActivity");
            
    
            var localVarPath = "/beta/cartonActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddCartonActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCartonActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartonActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartonActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartonActivity)));
            
        }
        
        /// <summary>
        /// Add new audit for a cartonActivity Adds an audit to an existing cartonActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to add an audit to</param> 
        /// <param name="cartonActivityAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddCartonActivityAudit (int? cartonActivityId, string cartonActivityAudit)
        {
             AddCartonActivityAuditWithHttpInfo(cartonActivityId, cartonActivityAudit);
        }

        /// <summary>
        /// Add new audit for a cartonActivity Adds an audit to an existing cartonActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to add an audit to</param> 
        /// <param name="cartonActivityAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddCartonActivityAuditWithHttpInfo (int? cartonActivityId, string cartonActivityAudit)
        {
            
            // verify the required parameter 'cartonActivityId' is set
            if (cartonActivityId == null)
                throw new ApiException(400, "Missing required parameter 'cartonActivityId' when calling CartonActivityApi->AddCartonActivityAudit");
            
            // verify the required parameter 'cartonActivityAudit' is set
            if (cartonActivityAudit == null)
                throw new ApiException(400, "Missing required parameter 'cartonActivityAudit' when calling CartonActivityApi->AddCartonActivityAudit");
            
    
            var localVarPath = "/beta/cartonActivity/{cartonActivityId}/audit/{cartonActivityAudit}";
    
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
            if (cartonActivityId != null) localVarPathParams.Add("cartonActivityId", Configuration.ApiClient.ParameterToString(cartonActivityId)); // path parameter
            if (cartonActivityAudit != null) localVarPathParams.Add("cartonActivityAudit", Configuration.ApiClient.ParameterToString(cartonActivityAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddCartonActivityAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCartonActivityAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a cartonActivity Adds an audit to an existing cartonActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to add an audit to</param>
        /// <param name="cartonActivityAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddCartonActivityAuditAsync (int? cartonActivityId, string cartonActivityAudit)
        {
             await AddCartonActivityAuditAsyncWithHttpInfo(cartonActivityId, cartonActivityAudit);

        }

        /// <summary>
        /// Add new audit for a cartonActivity Adds an audit to an existing cartonActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to add an audit to</param>
        /// <param name="cartonActivityAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddCartonActivityAuditAsyncWithHttpInfo (int? cartonActivityId, string cartonActivityAudit)
        {
            // verify the required parameter 'cartonActivityId' is set
            if (cartonActivityId == null) throw new ApiException(400, "Missing required parameter 'cartonActivityId' when calling AddCartonActivityAudit");
            // verify the required parameter 'cartonActivityAudit' is set
            if (cartonActivityAudit == null) throw new ApiException(400, "Missing required parameter 'cartonActivityAudit' when calling AddCartonActivityAudit");
            
    
            var localVarPath = "/beta/cartonActivity/{cartonActivityId}/audit/{cartonActivityAudit}";
    
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
            if (cartonActivityId != null) localVarPathParams.Add("cartonActivityId", Configuration.ApiClient.ParameterToString(cartonActivityId)); // path parameter
            if (cartonActivityAudit != null) localVarPathParams.Add("cartonActivityAudit", Configuration.ApiClient.ParameterToString(cartonActivityAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddCartonActivityAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCartonActivityAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a cartonActivity. Adds a tag to an existing cartonActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to add a tag to</param> 
        /// <param name="cartonActivityTag">The tag to add</param> 
        /// <returns></returns>
        public void AddCartonActivityTag (int? cartonActivityId, string cartonActivityTag)
        {
             AddCartonActivityTagWithHttpInfo(cartonActivityId, cartonActivityTag);
        }

        /// <summary>
        /// Add new tags for a cartonActivity. Adds a tag to an existing cartonActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to add a tag to</param> 
        /// <param name="cartonActivityTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddCartonActivityTagWithHttpInfo (int? cartonActivityId, string cartonActivityTag)
        {
            
            // verify the required parameter 'cartonActivityId' is set
            if (cartonActivityId == null)
                throw new ApiException(400, "Missing required parameter 'cartonActivityId' when calling CartonActivityApi->AddCartonActivityTag");
            
            // verify the required parameter 'cartonActivityTag' is set
            if (cartonActivityTag == null)
                throw new ApiException(400, "Missing required parameter 'cartonActivityTag' when calling CartonActivityApi->AddCartonActivityTag");
            
    
            var localVarPath = "/beta/cartonActivity/{cartonActivityId}/tag/{cartonActivityTag}";
    
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
            if (cartonActivityId != null) localVarPathParams.Add("cartonActivityId", Configuration.ApiClient.ParameterToString(cartonActivityId)); // path parameter
            if (cartonActivityTag != null) localVarPathParams.Add("cartonActivityTag", Configuration.ApiClient.ParameterToString(cartonActivityTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddCartonActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCartonActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a cartonActivity. Adds a tag to an existing cartonActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to add a tag to</param>
        /// <param name="cartonActivityTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddCartonActivityTagAsync (int? cartonActivityId, string cartonActivityTag)
        {
             await AddCartonActivityTagAsyncWithHttpInfo(cartonActivityId, cartonActivityTag);

        }

        /// <summary>
        /// Add new tags for a cartonActivity. Adds a tag to an existing cartonActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to add a tag to</param>
        /// <param name="cartonActivityTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddCartonActivityTagAsyncWithHttpInfo (int? cartonActivityId, string cartonActivityTag)
        {
            // verify the required parameter 'cartonActivityId' is set
            if (cartonActivityId == null) throw new ApiException(400, "Missing required parameter 'cartonActivityId' when calling AddCartonActivityTag");
            // verify the required parameter 'cartonActivityTag' is set
            if (cartonActivityTag == null) throw new ApiException(400, "Missing required parameter 'cartonActivityTag' when calling AddCartonActivityTag");
            
    
            var localVarPath = "/beta/cartonActivity/{cartonActivityId}/tag/{cartonActivityTag}";
    
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
            if (cartonActivityId != null) localVarPathParams.Add("cartonActivityId", Configuration.ApiClient.ParameterToString(cartonActivityId)); // path parameter
            if (cartonActivityTag != null) localVarPathParams.Add("cartonActivityTag", Configuration.ApiClient.ParameterToString(cartonActivityTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddCartonActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCartonActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a cartonActivity Deletes the cartonActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be deleted.</param> 
        /// <returns></returns>
        public void DeleteCartonActivity (int? cartonActivityId)
        {
             DeleteCartonActivityWithHttpInfo(cartonActivityId);
        }

        /// <summary>
        /// Delete a cartonActivity Deletes the cartonActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCartonActivityWithHttpInfo (int? cartonActivityId)
        {
            
            // verify the required parameter 'cartonActivityId' is set
            if (cartonActivityId == null)
                throw new ApiException(400, "Missing required parameter 'cartonActivityId' when calling CartonActivityApi->DeleteCartonActivity");
            
    
            var localVarPath = "/beta/cartonActivity/{cartonActivityId}";
    
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
            if (cartonActivityId != null) localVarPathParams.Add("cartonActivityId", Configuration.ApiClient.ParameterToString(cartonActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCartonActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCartonActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a cartonActivity Deletes the cartonActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCartonActivityAsync (int? cartonActivityId)
        {
             await DeleteCartonActivityAsyncWithHttpInfo(cartonActivityId);

        }

        /// <summary>
        /// Delete a cartonActivity Deletes the cartonActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCartonActivityAsyncWithHttpInfo (int? cartonActivityId)
        {
            // verify the required parameter 'cartonActivityId' is set
            if (cartonActivityId == null) throw new ApiException(400, "Missing required parameter 'cartonActivityId' when calling DeleteCartonActivity");
            
    
            var localVarPath = "/beta/cartonActivity/{cartonActivityId}";
    
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
            if (cartonActivityId != null) localVarPathParams.Add("cartonActivityId", Configuration.ApiClient.ParameterToString(cartonActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCartonActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCartonActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a cartonActivity. Deletes an existing cartonActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to remove tag from</param> 
        /// <param name="cartonActivityTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteCartonActivityTag (int? cartonActivityId, string cartonActivityTag)
        {
             DeleteCartonActivityTagWithHttpInfo(cartonActivityId, cartonActivityTag);
        }

        /// <summary>
        /// Delete a tag for a cartonActivity. Deletes an existing cartonActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to remove tag from</param> 
        /// <param name="cartonActivityTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCartonActivityTagWithHttpInfo (int? cartonActivityId, string cartonActivityTag)
        {
            
            // verify the required parameter 'cartonActivityId' is set
            if (cartonActivityId == null)
                throw new ApiException(400, "Missing required parameter 'cartonActivityId' when calling CartonActivityApi->DeleteCartonActivityTag");
            
            // verify the required parameter 'cartonActivityTag' is set
            if (cartonActivityTag == null)
                throw new ApiException(400, "Missing required parameter 'cartonActivityTag' when calling CartonActivityApi->DeleteCartonActivityTag");
            
    
            var localVarPath = "/beta/cartonActivity/{cartonActivityId}/tag/{cartonActivityTag}";
    
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
            if (cartonActivityId != null) localVarPathParams.Add("cartonActivityId", Configuration.ApiClient.ParameterToString(cartonActivityId)); // path parameter
            if (cartonActivityTag != null) localVarPathParams.Add("cartonActivityTag", Configuration.ApiClient.ParameterToString(cartonActivityTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCartonActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCartonActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a cartonActivity. Deletes an existing cartonActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to remove tag from</param>
        /// <param name="cartonActivityTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCartonActivityTagAsync (int? cartonActivityId, string cartonActivityTag)
        {
             await DeleteCartonActivityTagAsyncWithHttpInfo(cartonActivityId, cartonActivityTag);

        }

        /// <summary>
        /// Delete a tag for a cartonActivity. Deletes an existing cartonActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to remove tag from</param>
        /// <param name="cartonActivityTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCartonActivityTagAsyncWithHttpInfo (int? cartonActivityId, string cartonActivityTag)
        {
            // verify the required parameter 'cartonActivityId' is set
            if (cartonActivityId == null) throw new ApiException(400, "Missing required parameter 'cartonActivityId' when calling DeleteCartonActivityTag");
            // verify the required parameter 'cartonActivityTag' is set
            if (cartonActivityTag == null) throw new ApiException(400, "Missing required parameter 'cartonActivityTag' when calling DeleteCartonActivityTag");
            
    
            var localVarPath = "/beta/cartonActivity/{cartonActivityId}/tag/{cartonActivityTag}";
    
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
            if (cartonActivityId != null) localVarPathParams.Add("cartonActivityId", Configuration.ApiClient.ParameterToString(cartonActivityId)); // path parameter
            if (cartonActivityTag != null) localVarPathParams.Add("cartonActivityTag", Configuration.ApiClient.ParameterToString(cartonActivityTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCartonActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCartonActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search cartonActivitys by filter Returns the list of cartonActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;CartonActivity&gt;</returns>
        public List<CartonActivity> GetCartonActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<CartonActivity>> localVarResponse = GetCartonActivityByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search cartonActivitys by filter Returns the list of cartonActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;CartonActivity&gt;</returns>
        public ApiResponse< List<CartonActivity> > GetCartonActivityByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/cartonActivity/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetCartonActivityByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCartonActivityByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<CartonActivity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CartonActivity>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CartonActivity>)));
            
        }

        
        /// <summary>
        /// Search cartonActivitys by filter Returns the list of cartonActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;CartonActivity&gt;</returns>
        public async System.Threading.Tasks.Task<List<CartonActivity>> GetCartonActivityByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<CartonActivity>> localVarResponse = await GetCartonActivityByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search cartonActivitys by filter Returns the list of cartonActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CartonActivity&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CartonActivity>>> GetCartonActivityByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/cartonActivity/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetCartonActivityByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCartonActivityByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<CartonActivity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CartonActivity>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CartonActivity>)));
            
        }
        
        /// <summary>
        /// Get a cartonActivity by id Returns the cartonActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be returned.</param> 
        /// <returns>CartonActivity</returns>
        public CartonActivity GetCartonActivityById (int? cartonActivityId)
        {
             ApiResponse<CartonActivity> localVarResponse = GetCartonActivityByIdWithHttpInfo(cartonActivityId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a cartonActivity by id Returns the cartonActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be returned.</param> 
        /// <returns>ApiResponse of CartonActivity</returns>
        public ApiResponse< CartonActivity > GetCartonActivityByIdWithHttpInfo (int? cartonActivityId)
        {
            
            // verify the required parameter 'cartonActivityId' is set
            if (cartonActivityId == null)
                throw new ApiException(400, "Missing required parameter 'cartonActivityId' when calling CartonActivityApi->GetCartonActivityById");
            
    
            var localVarPath = "/beta/cartonActivity/{cartonActivityId}";
    
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
            if (cartonActivityId != null) localVarPathParams.Add("cartonActivityId", Configuration.ApiClient.ParameterToString(cartonActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetCartonActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCartonActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartonActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartonActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartonActivity)));
            
        }

        
        /// <summary>
        /// Get a cartonActivity by id Returns the cartonActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be returned.</param>
        /// <returns>Task of CartonActivity</returns>
        public async System.Threading.Tasks.Task<CartonActivity> GetCartonActivityByIdAsync (int? cartonActivityId)
        {
             ApiResponse<CartonActivity> localVarResponse = await GetCartonActivityByIdAsyncWithHttpInfo(cartonActivityId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a cartonActivity by id Returns the cartonActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be returned.</param>
        /// <returns>Task of ApiResponse (CartonActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartonActivity>> GetCartonActivityByIdAsyncWithHttpInfo (int? cartonActivityId)
        {
            // verify the required parameter 'cartonActivityId' is set
            if (cartonActivityId == null) throw new ApiException(400, "Missing required parameter 'cartonActivityId' when calling GetCartonActivityById");
            
    
            var localVarPath = "/beta/cartonActivity/{cartonActivityId}";
    
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
            if (cartonActivityId != null) localVarPathParams.Add("cartonActivityId", Configuration.ApiClient.ParameterToString(cartonActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetCartonActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCartonActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartonActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartonActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartonActivity)));
            
        }
        
        /// <summary>
        /// Get the tags for a cartonActivity. Get all existing cartonActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to get tags for</param> 
        /// <returns></returns>
        public void GetCartonActivityTags (int? cartonActivityId)
        {
             GetCartonActivityTagsWithHttpInfo(cartonActivityId);
        }

        /// <summary>
        /// Get the tags for a cartonActivity. Get all existing cartonActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetCartonActivityTagsWithHttpInfo (int? cartonActivityId)
        {
            
            // verify the required parameter 'cartonActivityId' is set
            if (cartonActivityId == null)
                throw new ApiException(400, "Missing required parameter 'cartonActivityId' when calling CartonActivityApi->GetCartonActivityTags");
            
    
            var localVarPath = "/beta/cartonActivity/{cartonActivityId}/tag";
    
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
            if (cartonActivityId != null) localVarPathParams.Add("cartonActivityId", Configuration.ApiClient.ParameterToString(cartonActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetCartonActivityTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCartonActivityTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a cartonActivity. Get all existing cartonActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetCartonActivityTagsAsync (int? cartonActivityId)
        {
             await GetCartonActivityTagsAsyncWithHttpInfo(cartonActivityId);

        }

        /// <summary>
        /// Get the tags for a cartonActivity. Get all existing cartonActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetCartonActivityTagsAsyncWithHttpInfo (int? cartonActivityId)
        {
            // verify the required parameter 'cartonActivityId' is set
            if (cartonActivityId == null) throw new ApiException(400, "Missing required parameter 'cartonActivityId' when calling GetCartonActivityTags");
            
    
            var localVarPath = "/beta/cartonActivity/{cartonActivityId}/tag";
    
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
            if (cartonActivityId != null) localVarPathParams.Add("cartonActivityId", Configuration.ApiClient.ParameterToString(cartonActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetCartonActivityTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCartonActivityTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a cartonActivity by id Returns a duplicated cartonActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be duplicated.</param> 
        /// <returns>CartonActivity</returns>
        public CartonActivity GetDuplicateCartonActivityById (int? cartonActivityId)
        {
             ApiResponse<CartonActivity> localVarResponse = GetDuplicateCartonActivityByIdWithHttpInfo(cartonActivityId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a cartonActivity by id Returns a duplicated cartonActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be duplicated.</param> 
        /// <returns>ApiResponse of CartonActivity</returns>
        public ApiResponse< CartonActivity > GetDuplicateCartonActivityByIdWithHttpInfo (int? cartonActivityId)
        {
            
            // verify the required parameter 'cartonActivityId' is set
            if (cartonActivityId == null)
                throw new ApiException(400, "Missing required parameter 'cartonActivityId' when calling CartonActivityApi->GetDuplicateCartonActivityById");
            
    
            var localVarPath = "/beta/cartonActivity/duplicate/{cartonActivityId}";
    
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
            if (cartonActivityId != null) localVarPathParams.Add("cartonActivityId", Configuration.ApiClient.ParameterToString(cartonActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateCartonActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateCartonActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartonActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartonActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartonActivity)));
            
        }

        
        /// <summary>
        /// Get a duplicated a cartonActivity by id Returns a duplicated cartonActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be duplicated.</param>
        /// <returns>Task of CartonActivity</returns>
        public async System.Threading.Tasks.Task<CartonActivity> GetDuplicateCartonActivityByIdAsync (int? cartonActivityId)
        {
             ApiResponse<CartonActivity> localVarResponse = await GetDuplicateCartonActivityByIdAsyncWithHttpInfo(cartonActivityId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a cartonActivity by id Returns a duplicated cartonActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonActivityId">Id of the cartonActivity to be duplicated.</param>
        /// <returns>Task of ApiResponse (CartonActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartonActivity>> GetDuplicateCartonActivityByIdAsyncWithHttpInfo (int? cartonActivityId)
        {
            // verify the required parameter 'cartonActivityId' is set
            if (cartonActivityId == null) throw new ApiException(400, "Missing required parameter 'cartonActivityId' when calling GetDuplicateCartonActivityById");
            
    
            var localVarPath = "/beta/cartonActivity/duplicate/{cartonActivityId}";
    
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
            if (cartonActivityId != null) localVarPathParams.Add("cartonActivityId", Configuration.ApiClient.ParameterToString(cartonActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateCartonActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateCartonActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartonActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartonActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartonActivity)));
            
        }
        
        /// <summary>
        /// Update a cartonActivity Updates an existing cartonActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonActivity to be updated.</param> 
        /// <returns></returns>
        public void UpdateCartonActivity (CartonActivity body)
        {
             UpdateCartonActivityWithHttpInfo(body);
        }

        /// <summary>
        /// Update a cartonActivity Updates an existing cartonActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonActivity to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateCartonActivityWithHttpInfo (CartonActivity body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CartonActivityApi->UpdateCartonActivity");
            
    
            var localVarPath = "/beta/cartonActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCartonActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCartonActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a cartonActivity Updates an existing cartonActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonActivity to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateCartonActivityAsync (CartonActivity body)
        {
             await UpdateCartonActivityAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a cartonActivity Updates an existing cartonActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonActivity to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCartonActivityAsyncWithHttpInfo (CartonActivity body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCartonActivity");
            
    
            var localVarPath = "/beta/cartonActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCartonActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCartonActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
