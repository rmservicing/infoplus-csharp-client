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
    public interface ICartonTypeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a cartonType
        /// </summary>
        /// <remarks>
        /// Inserts a new cartonType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be inserted.</param>
        /// <returns>CartonType</returns>
        CartonType AddCartonType (CartonType body);
  
        /// <summary>
        /// Create a cartonType
        /// </summary>
        /// <remarks>
        /// Inserts a new cartonType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be inserted.</param>
        /// <returns>ApiResponse of CartonType</returns>
        ApiResponse<CartonType> AddCartonTypeWithHttpInfo (CartonType body);
        
        /// <summary>
        /// Add new audit for a cartonType
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing cartonType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to add an audit to</param>
        /// <param name="cartonTypeAudit">The audit to add</param>
        /// <returns></returns>
        void AddCartonTypeAudit (int? cartonTypeId, string cartonTypeAudit);
  
        /// <summary>
        /// Add new audit for a cartonType
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing cartonType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to add an audit to</param>
        /// <param name="cartonTypeAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddCartonTypeAuditWithHttpInfo (int? cartonTypeId, string cartonTypeAudit);
        
        /// <summary>
        /// Add new tags for a cartonType.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing cartonType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to add a tag to</param>
        /// <param name="cartonTypeTag">The tag to add</param>
        /// <returns></returns>
        void AddCartonTypeTag (int? cartonTypeId, string cartonTypeTag);
  
        /// <summary>
        /// Add new tags for a cartonType.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing cartonType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to add a tag to</param>
        /// <param name="cartonTypeTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddCartonTypeTagWithHttpInfo (int? cartonTypeId, string cartonTypeTag);
        
        /// <summary>
        /// Delete a cartonType
        /// </summary>
        /// <remarks>
        /// Deletes the cartonType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be deleted.</param>
        /// <returns></returns>
        void DeleteCartonType (int? cartonTypeId);
  
        /// <summary>
        /// Delete a cartonType
        /// </summary>
        /// <remarks>
        /// Deletes the cartonType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCartonTypeWithHttpInfo (int? cartonTypeId);
        
        /// <summary>
        /// Delete a tag for a cartonType.
        /// </summary>
        /// <remarks>
        /// Deletes an existing cartonType tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to remove tag from</param>
        /// <param name="cartonTypeTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteCartonTypeTag (int? cartonTypeId, string cartonTypeTag);
  
        /// <summary>
        /// Delete a tag for a cartonType.
        /// </summary>
        /// <remarks>
        /// Deletes an existing cartonType tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to remove tag from</param>
        /// <param name="cartonTypeTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCartonTypeTagWithHttpInfo (int? cartonTypeId, string cartonTypeTag);
        
        /// <summary>
        /// Search cartonTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of cartonTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;CartonType&gt;</returns>
        List<CartonType> GetCartonTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search cartonTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of cartonTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;CartonType&gt;</returns>
        ApiResponse<List<CartonType>> GetCartonTypeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a cartonType by id
        /// </summary>
        /// <remarks>
        /// Returns the cartonType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be returned.</param>
        /// <returns>CartonType</returns>
        CartonType GetCartonTypeById (int? cartonTypeId);
  
        /// <summary>
        /// Get a cartonType by id
        /// </summary>
        /// <remarks>
        /// Returns the cartonType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be returned.</param>
        /// <returns>ApiResponse of CartonType</returns>
        ApiResponse<CartonType> GetCartonTypeByIdWithHttpInfo (int? cartonTypeId);
        
        /// <summary>
        /// Get the tags for a cartonType.
        /// </summary>
        /// <remarks>
        /// Get all existing cartonType tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to get tags for</param>
        /// <returns></returns>
        void GetCartonTypeTags (int? cartonTypeId);
  
        /// <summary>
        /// Get the tags for a cartonType.
        /// </summary>
        /// <remarks>
        /// Get all existing cartonType tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetCartonTypeTagsWithHttpInfo (int? cartonTypeId);
        
        /// <summary>
        /// Get a duplicated a cartonType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated cartonType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be duplicated.</param>
        /// <returns>CartonType</returns>
        CartonType GetDuplicateCartonTypeById (int? cartonTypeId);
  
        /// <summary>
        /// Get a duplicated a cartonType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated cartonType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be duplicated.</param>
        /// <returns>ApiResponse of CartonType</returns>
        ApiResponse<CartonType> GetDuplicateCartonTypeByIdWithHttpInfo (int? cartonTypeId);
        
        /// <summary>
        /// Update a cartonType
        /// </summary>
        /// <remarks>
        /// Updates an existing cartonType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be updated.</param>
        /// <returns></returns>
        void UpdateCartonType (CartonType body);
  
        /// <summary>
        /// Update a cartonType
        /// </summary>
        /// <remarks>
        /// Updates an existing cartonType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateCartonTypeWithHttpInfo (CartonType body);
        
        /// <summary>
        /// Update a cartonType custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing cartonType custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be updated.</param>
        /// <returns></returns>
        void UpdateCartonTypeCustomFields (CartonType body);
  
        /// <summary>
        /// Update a cartonType custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing cartonType custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateCartonTypeCustomFieldsWithHttpInfo (CartonType body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a cartonType
        /// </summary>
        /// <remarks>
        /// Inserts a new cartonType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be inserted.</param>
        /// <returns>Task of CartonType</returns>
        System.Threading.Tasks.Task<CartonType> AddCartonTypeAsync (CartonType body);

        /// <summary>
        /// Create a cartonType
        /// </summary>
        /// <remarks>
        /// Inserts a new cartonType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be inserted.</param>
        /// <returns>Task of ApiResponse (CartonType)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartonType>> AddCartonTypeAsyncWithHttpInfo (CartonType body);
        
        /// <summary>
        /// Add new audit for a cartonType
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing cartonType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to add an audit to</param>
        /// <param name="cartonTypeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddCartonTypeAuditAsync (int? cartonTypeId, string cartonTypeAudit);

        /// <summary>
        /// Add new audit for a cartonType
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing cartonType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to add an audit to</param>
        /// <param name="cartonTypeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddCartonTypeAuditAsyncWithHttpInfo (int? cartonTypeId, string cartonTypeAudit);
        
        /// <summary>
        /// Add new tags for a cartonType.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing cartonType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to add a tag to</param>
        /// <param name="cartonTypeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddCartonTypeTagAsync (int? cartonTypeId, string cartonTypeTag);

        /// <summary>
        /// Add new tags for a cartonType.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing cartonType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to add a tag to</param>
        /// <param name="cartonTypeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddCartonTypeTagAsyncWithHttpInfo (int? cartonTypeId, string cartonTypeTag);
        
        /// <summary>
        /// Delete a cartonType
        /// </summary>
        /// <remarks>
        /// Deletes the cartonType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCartonTypeAsync (int? cartonTypeId);

        /// <summary>
        /// Delete a cartonType
        /// </summary>
        /// <remarks>
        /// Deletes the cartonType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCartonTypeAsyncWithHttpInfo (int? cartonTypeId);
        
        /// <summary>
        /// Delete a tag for a cartonType.
        /// </summary>
        /// <remarks>
        /// Deletes an existing cartonType tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to remove tag from</param>
        /// <param name="cartonTypeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCartonTypeTagAsync (int? cartonTypeId, string cartonTypeTag);

        /// <summary>
        /// Delete a tag for a cartonType.
        /// </summary>
        /// <remarks>
        /// Deletes an existing cartonType tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to remove tag from</param>
        /// <param name="cartonTypeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCartonTypeTagAsyncWithHttpInfo (int? cartonTypeId, string cartonTypeTag);
        
        /// <summary>
        /// Search cartonTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of cartonTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;CartonType&gt;</returns>
        System.Threading.Tasks.Task<List<CartonType>> GetCartonTypeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search cartonTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of cartonTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CartonType&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CartonType>>> GetCartonTypeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a cartonType by id
        /// </summary>
        /// <remarks>
        /// Returns the cartonType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be returned.</param>
        /// <returns>Task of CartonType</returns>
        System.Threading.Tasks.Task<CartonType> GetCartonTypeByIdAsync (int? cartonTypeId);

        /// <summary>
        /// Get a cartonType by id
        /// </summary>
        /// <remarks>
        /// Returns the cartonType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be returned.</param>
        /// <returns>Task of ApiResponse (CartonType)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartonType>> GetCartonTypeByIdAsyncWithHttpInfo (int? cartonTypeId);
        
        /// <summary>
        /// Get the tags for a cartonType.
        /// </summary>
        /// <remarks>
        /// Get all existing cartonType tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetCartonTypeTagsAsync (int? cartonTypeId);

        /// <summary>
        /// Get the tags for a cartonType.
        /// </summary>
        /// <remarks>
        /// Get all existing cartonType tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetCartonTypeTagsAsyncWithHttpInfo (int? cartonTypeId);
        
        /// <summary>
        /// Get a duplicated a cartonType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated cartonType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be duplicated.</param>
        /// <returns>Task of CartonType</returns>
        System.Threading.Tasks.Task<CartonType> GetDuplicateCartonTypeByIdAsync (int? cartonTypeId);

        /// <summary>
        /// Get a duplicated a cartonType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated cartonType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be duplicated.</param>
        /// <returns>Task of ApiResponse (CartonType)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartonType>> GetDuplicateCartonTypeByIdAsyncWithHttpInfo (int? cartonTypeId);
        
        /// <summary>
        /// Update a cartonType
        /// </summary>
        /// <remarks>
        /// Updates an existing cartonType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateCartonTypeAsync (CartonType body);

        /// <summary>
        /// Update a cartonType
        /// </summary>
        /// <remarks>
        /// Updates an existing cartonType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCartonTypeAsyncWithHttpInfo (CartonType body);
        
        /// <summary>
        /// Update a cartonType custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing cartonType custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateCartonTypeCustomFieldsAsync (CartonType body);

        /// <summary>
        /// Update a cartonType custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing cartonType custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCartonTypeCustomFieldsAsyncWithHttpInfo (CartonType body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CartonTypeApi : ICartonTypeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartonTypeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CartonTypeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CartonTypeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CartonTypeApi(Configuration configuration = null)
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
        /// Create a cartonType Inserts a new cartonType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be inserted.</param> 
        /// <returns>CartonType</returns>
        public CartonType AddCartonType (CartonType body)
        {
             ApiResponse<CartonType> localVarResponse = AddCartonTypeWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a cartonType Inserts a new cartonType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be inserted.</param> 
        /// <returns>ApiResponse of CartonType</returns>
        public ApiResponse< CartonType > AddCartonTypeWithHttpInfo (CartonType body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CartonTypeApi->AddCartonType");
            
    
            var localVarPath = "/beta/cartonType";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddCartonType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCartonType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartonType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartonType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartonType)));
            
        }

        
        /// <summary>
        /// Create a cartonType Inserts a new cartonType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be inserted.</param>
        /// <returns>Task of CartonType</returns>
        public async System.Threading.Tasks.Task<CartonType> AddCartonTypeAsync (CartonType body)
        {
             ApiResponse<CartonType> localVarResponse = await AddCartonTypeAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a cartonType Inserts a new cartonType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be inserted.</param>
        /// <returns>Task of ApiResponse (CartonType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartonType>> AddCartonTypeAsyncWithHttpInfo (CartonType body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddCartonType");
            
    
            var localVarPath = "/beta/cartonType";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddCartonType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCartonType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartonType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartonType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartonType)));
            
        }
        
        /// <summary>
        /// Add new audit for a cartonType Adds an audit to an existing cartonType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to add an audit to</param> 
        /// <param name="cartonTypeAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddCartonTypeAudit (int? cartonTypeId, string cartonTypeAudit)
        {
             AddCartonTypeAuditWithHttpInfo(cartonTypeId, cartonTypeAudit);
        }

        /// <summary>
        /// Add new audit for a cartonType Adds an audit to an existing cartonType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to add an audit to</param> 
        /// <param name="cartonTypeAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddCartonTypeAuditWithHttpInfo (int? cartonTypeId, string cartonTypeAudit)
        {
            
            // verify the required parameter 'cartonTypeId' is set
            if (cartonTypeId == null)
                throw new ApiException(400, "Missing required parameter 'cartonTypeId' when calling CartonTypeApi->AddCartonTypeAudit");
            
            // verify the required parameter 'cartonTypeAudit' is set
            if (cartonTypeAudit == null)
                throw new ApiException(400, "Missing required parameter 'cartonTypeAudit' when calling CartonTypeApi->AddCartonTypeAudit");
            
    
            var localVarPath = "/beta/cartonType/{cartonTypeId}/audit/{cartonTypeAudit}";
    
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
            if (cartonTypeId != null) localVarPathParams.Add("cartonTypeId", Configuration.ApiClient.ParameterToString(cartonTypeId)); // path parameter
            if (cartonTypeAudit != null) localVarPathParams.Add("cartonTypeAudit", Configuration.ApiClient.ParameterToString(cartonTypeAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddCartonTypeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCartonTypeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a cartonType Adds an audit to an existing cartonType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to add an audit to</param>
        /// <param name="cartonTypeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddCartonTypeAuditAsync (int? cartonTypeId, string cartonTypeAudit)
        {
             await AddCartonTypeAuditAsyncWithHttpInfo(cartonTypeId, cartonTypeAudit);

        }

        /// <summary>
        /// Add new audit for a cartonType Adds an audit to an existing cartonType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to add an audit to</param>
        /// <param name="cartonTypeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddCartonTypeAuditAsyncWithHttpInfo (int? cartonTypeId, string cartonTypeAudit)
        {
            // verify the required parameter 'cartonTypeId' is set
            if (cartonTypeId == null) throw new ApiException(400, "Missing required parameter 'cartonTypeId' when calling AddCartonTypeAudit");
            // verify the required parameter 'cartonTypeAudit' is set
            if (cartonTypeAudit == null) throw new ApiException(400, "Missing required parameter 'cartonTypeAudit' when calling AddCartonTypeAudit");
            
    
            var localVarPath = "/beta/cartonType/{cartonTypeId}/audit/{cartonTypeAudit}";
    
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
            if (cartonTypeId != null) localVarPathParams.Add("cartonTypeId", Configuration.ApiClient.ParameterToString(cartonTypeId)); // path parameter
            if (cartonTypeAudit != null) localVarPathParams.Add("cartonTypeAudit", Configuration.ApiClient.ParameterToString(cartonTypeAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddCartonTypeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCartonTypeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a cartonType. Adds a tag to an existing cartonType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to add a tag to</param> 
        /// <param name="cartonTypeTag">The tag to add</param> 
        /// <returns></returns>
        public void AddCartonTypeTag (int? cartonTypeId, string cartonTypeTag)
        {
             AddCartonTypeTagWithHttpInfo(cartonTypeId, cartonTypeTag);
        }

        /// <summary>
        /// Add new tags for a cartonType. Adds a tag to an existing cartonType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to add a tag to</param> 
        /// <param name="cartonTypeTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddCartonTypeTagWithHttpInfo (int? cartonTypeId, string cartonTypeTag)
        {
            
            // verify the required parameter 'cartonTypeId' is set
            if (cartonTypeId == null)
                throw new ApiException(400, "Missing required parameter 'cartonTypeId' when calling CartonTypeApi->AddCartonTypeTag");
            
            // verify the required parameter 'cartonTypeTag' is set
            if (cartonTypeTag == null)
                throw new ApiException(400, "Missing required parameter 'cartonTypeTag' when calling CartonTypeApi->AddCartonTypeTag");
            
    
            var localVarPath = "/beta/cartonType/{cartonTypeId}/tag/{cartonTypeTag}";
    
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
            if (cartonTypeId != null) localVarPathParams.Add("cartonTypeId", Configuration.ApiClient.ParameterToString(cartonTypeId)); // path parameter
            if (cartonTypeTag != null) localVarPathParams.Add("cartonTypeTag", Configuration.ApiClient.ParameterToString(cartonTypeTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddCartonTypeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCartonTypeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a cartonType. Adds a tag to an existing cartonType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to add a tag to</param>
        /// <param name="cartonTypeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddCartonTypeTagAsync (int? cartonTypeId, string cartonTypeTag)
        {
             await AddCartonTypeTagAsyncWithHttpInfo(cartonTypeId, cartonTypeTag);

        }

        /// <summary>
        /// Add new tags for a cartonType. Adds a tag to an existing cartonType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to add a tag to</param>
        /// <param name="cartonTypeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddCartonTypeTagAsyncWithHttpInfo (int? cartonTypeId, string cartonTypeTag)
        {
            // verify the required parameter 'cartonTypeId' is set
            if (cartonTypeId == null) throw new ApiException(400, "Missing required parameter 'cartonTypeId' when calling AddCartonTypeTag");
            // verify the required parameter 'cartonTypeTag' is set
            if (cartonTypeTag == null) throw new ApiException(400, "Missing required parameter 'cartonTypeTag' when calling AddCartonTypeTag");
            
    
            var localVarPath = "/beta/cartonType/{cartonTypeId}/tag/{cartonTypeTag}";
    
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
            if (cartonTypeId != null) localVarPathParams.Add("cartonTypeId", Configuration.ApiClient.ParameterToString(cartonTypeId)); // path parameter
            if (cartonTypeTag != null) localVarPathParams.Add("cartonTypeTag", Configuration.ApiClient.ParameterToString(cartonTypeTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddCartonTypeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddCartonTypeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a cartonType Deletes the cartonType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be deleted.</param> 
        /// <returns></returns>
        public void DeleteCartonType (int? cartonTypeId)
        {
             DeleteCartonTypeWithHttpInfo(cartonTypeId);
        }

        /// <summary>
        /// Delete a cartonType Deletes the cartonType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCartonTypeWithHttpInfo (int? cartonTypeId)
        {
            
            // verify the required parameter 'cartonTypeId' is set
            if (cartonTypeId == null)
                throw new ApiException(400, "Missing required parameter 'cartonTypeId' when calling CartonTypeApi->DeleteCartonType");
            
    
            var localVarPath = "/beta/cartonType/{cartonTypeId}";
    
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
            if (cartonTypeId != null) localVarPathParams.Add("cartonTypeId", Configuration.ApiClient.ParameterToString(cartonTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCartonType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCartonType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a cartonType Deletes the cartonType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCartonTypeAsync (int? cartonTypeId)
        {
             await DeleteCartonTypeAsyncWithHttpInfo(cartonTypeId);

        }

        /// <summary>
        /// Delete a cartonType Deletes the cartonType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCartonTypeAsyncWithHttpInfo (int? cartonTypeId)
        {
            // verify the required parameter 'cartonTypeId' is set
            if (cartonTypeId == null) throw new ApiException(400, "Missing required parameter 'cartonTypeId' when calling DeleteCartonType");
            
    
            var localVarPath = "/beta/cartonType/{cartonTypeId}";
    
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
            if (cartonTypeId != null) localVarPathParams.Add("cartonTypeId", Configuration.ApiClient.ParameterToString(cartonTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCartonType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCartonType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a cartonType. Deletes an existing cartonType tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to remove tag from</param> 
        /// <param name="cartonTypeTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteCartonTypeTag (int? cartonTypeId, string cartonTypeTag)
        {
             DeleteCartonTypeTagWithHttpInfo(cartonTypeId, cartonTypeTag);
        }

        /// <summary>
        /// Delete a tag for a cartonType. Deletes an existing cartonType tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to remove tag from</param> 
        /// <param name="cartonTypeTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCartonTypeTagWithHttpInfo (int? cartonTypeId, string cartonTypeTag)
        {
            
            // verify the required parameter 'cartonTypeId' is set
            if (cartonTypeId == null)
                throw new ApiException(400, "Missing required parameter 'cartonTypeId' when calling CartonTypeApi->DeleteCartonTypeTag");
            
            // verify the required parameter 'cartonTypeTag' is set
            if (cartonTypeTag == null)
                throw new ApiException(400, "Missing required parameter 'cartonTypeTag' when calling CartonTypeApi->DeleteCartonTypeTag");
            
    
            var localVarPath = "/beta/cartonType/{cartonTypeId}/tag/{cartonTypeTag}";
    
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
            if (cartonTypeId != null) localVarPathParams.Add("cartonTypeId", Configuration.ApiClient.ParameterToString(cartonTypeId)); // path parameter
            if (cartonTypeTag != null) localVarPathParams.Add("cartonTypeTag", Configuration.ApiClient.ParameterToString(cartonTypeTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCartonTypeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCartonTypeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a cartonType. Deletes an existing cartonType tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to remove tag from</param>
        /// <param name="cartonTypeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCartonTypeTagAsync (int? cartonTypeId, string cartonTypeTag)
        {
             await DeleteCartonTypeTagAsyncWithHttpInfo(cartonTypeId, cartonTypeTag);

        }

        /// <summary>
        /// Delete a tag for a cartonType. Deletes an existing cartonType tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to remove tag from</param>
        /// <param name="cartonTypeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCartonTypeTagAsyncWithHttpInfo (int? cartonTypeId, string cartonTypeTag)
        {
            // verify the required parameter 'cartonTypeId' is set
            if (cartonTypeId == null) throw new ApiException(400, "Missing required parameter 'cartonTypeId' when calling DeleteCartonTypeTag");
            // verify the required parameter 'cartonTypeTag' is set
            if (cartonTypeTag == null) throw new ApiException(400, "Missing required parameter 'cartonTypeTag' when calling DeleteCartonTypeTag");
            
    
            var localVarPath = "/beta/cartonType/{cartonTypeId}/tag/{cartonTypeTag}";
    
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
            if (cartonTypeId != null) localVarPathParams.Add("cartonTypeId", Configuration.ApiClient.ParameterToString(cartonTypeId)); // path parameter
            if (cartonTypeTag != null) localVarPathParams.Add("cartonTypeTag", Configuration.ApiClient.ParameterToString(cartonTypeTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteCartonTypeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCartonTypeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search cartonTypes by filter Returns the list of cartonTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;CartonType&gt;</returns>
        public List<CartonType> GetCartonTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<CartonType>> localVarResponse = GetCartonTypeByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search cartonTypes by filter Returns the list of cartonTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;CartonType&gt;</returns>
        public ApiResponse< List<CartonType> > GetCartonTypeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/cartonType/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetCartonTypeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCartonTypeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<CartonType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CartonType>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CartonType>)));
            
        }

        
        /// <summary>
        /// Search cartonTypes by filter Returns the list of cartonTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;CartonType&gt;</returns>
        public async System.Threading.Tasks.Task<List<CartonType>> GetCartonTypeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<CartonType>> localVarResponse = await GetCartonTypeByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search cartonTypes by filter Returns the list of cartonTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;CartonType&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CartonType>>> GetCartonTypeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/cartonType/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetCartonTypeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCartonTypeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<CartonType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CartonType>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CartonType>)));
            
        }
        
        /// <summary>
        /// Get a cartonType by id Returns the cartonType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be returned.</param> 
        /// <returns>CartonType</returns>
        public CartonType GetCartonTypeById (int? cartonTypeId)
        {
             ApiResponse<CartonType> localVarResponse = GetCartonTypeByIdWithHttpInfo(cartonTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a cartonType by id Returns the cartonType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be returned.</param> 
        /// <returns>ApiResponse of CartonType</returns>
        public ApiResponse< CartonType > GetCartonTypeByIdWithHttpInfo (int? cartonTypeId)
        {
            
            // verify the required parameter 'cartonTypeId' is set
            if (cartonTypeId == null)
                throw new ApiException(400, "Missing required parameter 'cartonTypeId' when calling CartonTypeApi->GetCartonTypeById");
            
    
            var localVarPath = "/beta/cartonType/{cartonTypeId}";
    
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
            if (cartonTypeId != null) localVarPathParams.Add("cartonTypeId", Configuration.ApiClient.ParameterToString(cartonTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetCartonTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCartonTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartonType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartonType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartonType)));
            
        }

        
        /// <summary>
        /// Get a cartonType by id Returns the cartonType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be returned.</param>
        /// <returns>Task of CartonType</returns>
        public async System.Threading.Tasks.Task<CartonType> GetCartonTypeByIdAsync (int? cartonTypeId)
        {
             ApiResponse<CartonType> localVarResponse = await GetCartonTypeByIdAsyncWithHttpInfo(cartonTypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a cartonType by id Returns the cartonType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be returned.</param>
        /// <returns>Task of ApiResponse (CartonType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartonType>> GetCartonTypeByIdAsyncWithHttpInfo (int? cartonTypeId)
        {
            // verify the required parameter 'cartonTypeId' is set
            if (cartonTypeId == null) throw new ApiException(400, "Missing required parameter 'cartonTypeId' when calling GetCartonTypeById");
            
    
            var localVarPath = "/beta/cartonType/{cartonTypeId}";
    
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
            if (cartonTypeId != null) localVarPathParams.Add("cartonTypeId", Configuration.ApiClient.ParameterToString(cartonTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetCartonTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCartonTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartonType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartonType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartonType)));
            
        }
        
        /// <summary>
        /// Get the tags for a cartonType. Get all existing cartonType tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to get tags for</param> 
        /// <returns></returns>
        public void GetCartonTypeTags (int? cartonTypeId)
        {
             GetCartonTypeTagsWithHttpInfo(cartonTypeId);
        }

        /// <summary>
        /// Get the tags for a cartonType. Get all existing cartonType tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetCartonTypeTagsWithHttpInfo (int? cartonTypeId)
        {
            
            // verify the required parameter 'cartonTypeId' is set
            if (cartonTypeId == null)
                throw new ApiException(400, "Missing required parameter 'cartonTypeId' when calling CartonTypeApi->GetCartonTypeTags");
            
    
            var localVarPath = "/beta/cartonType/{cartonTypeId}/tag";
    
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
            if (cartonTypeId != null) localVarPathParams.Add("cartonTypeId", Configuration.ApiClient.ParameterToString(cartonTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetCartonTypeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCartonTypeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a cartonType. Get all existing cartonType tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetCartonTypeTagsAsync (int? cartonTypeId)
        {
             await GetCartonTypeTagsAsyncWithHttpInfo(cartonTypeId);

        }

        /// <summary>
        /// Get the tags for a cartonType. Get all existing cartonType tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetCartonTypeTagsAsyncWithHttpInfo (int? cartonTypeId)
        {
            // verify the required parameter 'cartonTypeId' is set
            if (cartonTypeId == null) throw new ApiException(400, "Missing required parameter 'cartonTypeId' when calling GetCartonTypeTags");
            
    
            var localVarPath = "/beta/cartonType/{cartonTypeId}/tag";
    
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
            if (cartonTypeId != null) localVarPathParams.Add("cartonTypeId", Configuration.ApiClient.ParameterToString(cartonTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetCartonTypeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCartonTypeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a cartonType by id Returns a duplicated cartonType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be duplicated.</param> 
        /// <returns>CartonType</returns>
        public CartonType GetDuplicateCartonTypeById (int? cartonTypeId)
        {
             ApiResponse<CartonType> localVarResponse = GetDuplicateCartonTypeByIdWithHttpInfo(cartonTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a cartonType by id Returns a duplicated cartonType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be duplicated.</param> 
        /// <returns>ApiResponse of CartonType</returns>
        public ApiResponse< CartonType > GetDuplicateCartonTypeByIdWithHttpInfo (int? cartonTypeId)
        {
            
            // verify the required parameter 'cartonTypeId' is set
            if (cartonTypeId == null)
                throw new ApiException(400, "Missing required parameter 'cartonTypeId' when calling CartonTypeApi->GetDuplicateCartonTypeById");
            
    
            var localVarPath = "/beta/cartonType/duplicate/{cartonTypeId}";
    
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
            if (cartonTypeId != null) localVarPathParams.Add("cartonTypeId", Configuration.ApiClient.ParameterToString(cartonTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateCartonTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateCartonTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CartonType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartonType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartonType)));
            
        }

        
        /// <summary>
        /// Get a duplicated a cartonType by id Returns a duplicated cartonType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be duplicated.</param>
        /// <returns>Task of CartonType</returns>
        public async System.Threading.Tasks.Task<CartonType> GetDuplicateCartonTypeByIdAsync (int? cartonTypeId)
        {
             ApiResponse<CartonType> localVarResponse = await GetDuplicateCartonTypeByIdAsyncWithHttpInfo(cartonTypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a cartonType by id Returns a duplicated cartonType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cartonTypeId">Id of the cartonType to be duplicated.</param>
        /// <returns>Task of ApiResponse (CartonType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CartonType>> GetDuplicateCartonTypeByIdAsyncWithHttpInfo (int? cartonTypeId)
        {
            // verify the required parameter 'cartonTypeId' is set
            if (cartonTypeId == null) throw new ApiException(400, "Missing required parameter 'cartonTypeId' when calling GetDuplicateCartonTypeById");
            
    
            var localVarPath = "/beta/cartonType/duplicate/{cartonTypeId}";
    
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
            if (cartonTypeId != null) localVarPathParams.Add("cartonTypeId", Configuration.ApiClient.ParameterToString(cartonTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateCartonTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateCartonTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CartonType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CartonType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CartonType)));
            
        }
        
        /// <summary>
        /// Update a cartonType Updates an existing cartonType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be updated.</param> 
        /// <returns></returns>
        public void UpdateCartonType (CartonType body)
        {
             UpdateCartonTypeWithHttpInfo(body);
        }

        /// <summary>
        /// Update a cartonType Updates an existing cartonType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateCartonTypeWithHttpInfo (CartonType body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CartonTypeApi->UpdateCartonType");
            
    
            var localVarPath = "/beta/cartonType";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCartonType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCartonType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a cartonType Updates an existing cartonType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateCartonTypeAsync (CartonType body)
        {
             await UpdateCartonTypeAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a cartonType Updates an existing cartonType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCartonTypeAsyncWithHttpInfo (CartonType body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCartonType");
            
    
            var localVarPath = "/beta/cartonType";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCartonType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCartonType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a cartonType custom fields Updates an existing cartonType custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be updated.</param> 
        /// <returns></returns>
        public void UpdateCartonTypeCustomFields (CartonType body)
        {
             UpdateCartonTypeCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a cartonType custom fields Updates an existing cartonType custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateCartonTypeCustomFieldsWithHttpInfo (CartonType body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CartonTypeApi->UpdateCartonTypeCustomFields");
            
    
            var localVarPath = "/beta/cartonType/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCartonTypeCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCartonTypeCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a cartonType custom fields Updates an existing cartonType custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateCartonTypeCustomFieldsAsync (CartonType body)
        {
             await UpdateCartonTypeCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a cartonType custom fields Updates an existing cartonType custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">CartonType to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateCartonTypeCustomFieldsAsyncWithHttpInfo (CartonType body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCartonTypeCustomFields");
            
    
            var localVarPath = "/beta/cartonType/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateCartonTypeCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateCartonTypeCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
