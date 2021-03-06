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
    public interface ILocationFootprintApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a locationFootprint
        /// </summary>
        /// <remarks>
        /// Inserts a new locationFootprint using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be inserted.</param>
        /// <returns>LocationFootprint</returns>
        LocationFootprint AddLocationFootprint (LocationFootprint body);
  
        /// <summary>
        /// Create a locationFootprint
        /// </summary>
        /// <remarks>
        /// Inserts a new locationFootprint using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be inserted.</param>
        /// <returns>ApiResponse of LocationFootprint</returns>
        ApiResponse<LocationFootprint> AddLocationFootprintWithHttpInfo (LocationFootprint body);
        
        /// <summary>
        /// Add new audit for a locationFootprint
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing locationFootprint.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to add an audit to</param>
        /// <param name="locationFootprintAudit">The audit to add</param>
        /// <returns></returns>
        void AddLocationFootprintAudit (int? locationFootprintId, string locationFootprintAudit);
  
        /// <summary>
        /// Add new audit for a locationFootprint
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing locationFootprint.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to add an audit to</param>
        /// <param name="locationFootprintAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddLocationFootprintAuditWithHttpInfo (int? locationFootprintId, string locationFootprintAudit);
        
        /// <summary>
        /// Add new tags for a locationFootprint.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing locationFootprint.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to add a tag to</param>
        /// <param name="locationFootprintTag">The tag to add</param>
        /// <returns></returns>
        void AddLocationFootprintTag (int? locationFootprintId, string locationFootprintTag);
  
        /// <summary>
        /// Add new tags for a locationFootprint.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing locationFootprint.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to add a tag to</param>
        /// <param name="locationFootprintTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddLocationFootprintTagWithHttpInfo (int? locationFootprintId, string locationFootprintTag);
        
        /// <summary>
        /// Delete a locationFootprint
        /// </summary>
        /// <remarks>
        /// Deletes the locationFootprint identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be deleted.</param>
        /// <returns></returns>
        void DeleteLocationFootprint (int? locationFootprintId);
  
        /// <summary>
        /// Delete a locationFootprint
        /// </summary>
        /// <remarks>
        /// Deletes the locationFootprint identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLocationFootprintWithHttpInfo (int? locationFootprintId);
        
        /// <summary>
        /// Delete a tag for a locationFootprint.
        /// </summary>
        /// <remarks>
        /// Deletes an existing locationFootprint tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to remove tag from</param>
        /// <param name="locationFootprintTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteLocationFootprintTag (int? locationFootprintId, string locationFootprintTag);
  
        /// <summary>
        /// Delete a tag for a locationFootprint.
        /// </summary>
        /// <remarks>
        /// Deletes an existing locationFootprint tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to remove tag from</param>
        /// <param name="locationFootprintTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLocationFootprintTagWithHttpInfo (int? locationFootprintId, string locationFootprintTag);
        
        /// <summary>
        /// Get a duplicated a locationFootprint by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated locationFootprint identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be duplicated.</param>
        /// <returns>LocationFootprint</returns>
        LocationFootprint GetDuplicateLocationFootprintById (int? locationFootprintId);
  
        /// <summary>
        /// Get a duplicated a locationFootprint by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated locationFootprint identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be duplicated.</param>
        /// <returns>ApiResponse of LocationFootprint</returns>
        ApiResponse<LocationFootprint> GetDuplicateLocationFootprintByIdWithHttpInfo (int? locationFootprintId);
        
        /// <summary>
        /// Search locationFootprints by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of locationFootprints that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;LocationFootprint&gt;</returns>
        List<LocationFootprint> GetLocationFootprintByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search locationFootprints by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of locationFootprints that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;LocationFootprint&gt;</returns>
        ApiResponse<List<LocationFootprint>> GetLocationFootprintByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a locationFootprint by id
        /// </summary>
        /// <remarks>
        /// Returns the locationFootprint identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be returned.</param>
        /// <returns>LocationFootprint</returns>
        LocationFootprint GetLocationFootprintById (int? locationFootprintId);
  
        /// <summary>
        /// Get a locationFootprint by id
        /// </summary>
        /// <remarks>
        /// Returns the locationFootprint identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be returned.</param>
        /// <returns>ApiResponse of LocationFootprint</returns>
        ApiResponse<LocationFootprint> GetLocationFootprintByIdWithHttpInfo (int? locationFootprintId);
        
        /// <summary>
        /// Get the tags for a locationFootprint.
        /// </summary>
        /// <remarks>
        /// Get all existing locationFootprint tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to get tags for</param>
        /// <returns></returns>
        void GetLocationFootprintTags (int? locationFootprintId);
  
        /// <summary>
        /// Get the tags for a locationFootprint.
        /// </summary>
        /// <remarks>
        /// Get all existing locationFootprint tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetLocationFootprintTagsWithHttpInfo (int? locationFootprintId);
        
        /// <summary>
        /// Update a locationFootprint
        /// </summary>
        /// <remarks>
        /// Updates an existing locationFootprint using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be updated.</param>
        /// <returns></returns>
        void UpdateLocationFootprint (LocationFootprint body);
  
        /// <summary>
        /// Update a locationFootprint
        /// </summary>
        /// <remarks>
        /// Updates an existing locationFootprint using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateLocationFootprintWithHttpInfo (LocationFootprint body);
        
        /// <summary>
        /// Update a locationFootprint custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing locationFootprint custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be updated.</param>
        /// <returns></returns>
        void UpdateLocationFootprintCustomFields (LocationFootprint body);
  
        /// <summary>
        /// Update a locationFootprint custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing locationFootprint custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateLocationFootprintCustomFieldsWithHttpInfo (LocationFootprint body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a locationFootprint
        /// </summary>
        /// <remarks>
        /// Inserts a new locationFootprint using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be inserted.</param>
        /// <returns>Task of LocationFootprint</returns>
        System.Threading.Tasks.Task<LocationFootprint> AddLocationFootprintAsync (LocationFootprint body);

        /// <summary>
        /// Create a locationFootprint
        /// </summary>
        /// <remarks>
        /// Inserts a new locationFootprint using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be inserted.</param>
        /// <returns>Task of ApiResponse (LocationFootprint)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocationFootprint>> AddLocationFootprintAsyncWithHttpInfo (LocationFootprint body);
        
        /// <summary>
        /// Add new audit for a locationFootprint
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing locationFootprint.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to add an audit to</param>
        /// <param name="locationFootprintAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddLocationFootprintAuditAsync (int? locationFootprintId, string locationFootprintAudit);

        /// <summary>
        /// Add new audit for a locationFootprint
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing locationFootprint.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to add an audit to</param>
        /// <param name="locationFootprintAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddLocationFootprintAuditAsyncWithHttpInfo (int? locationFootprintId, string locationFootprintAudit);
        
        /// <summary>
        /// Add new tags for a locationFootprint.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing locationFootprint.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to add a tag to</param>
        /// <param name="locationFootprintTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddLocationFootprintTagAsync (int? locationFootprintId, string locationFootprintTag);

        /// <summary>
        /// Add new tags for a locationFootprint.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing locationFootprint.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to add a tag to</param>
        /// <param name="locationFootprintTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddLocationFootprintTagAsyncWithHttpInfo (int? locationFootprintId, string locationFootprintTag);
        
        /// <summary>
        /// Delete a locationFootprint
        /// </summary>
        /// <remarks>
        /// Deletes the locationFootprint identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLocationFootprintAsync (int? locationFootprintId);

        /// <summary>
        /// Delete a locationFootprint
        /// </summary>
        /// <remarks>
        /// Deletes the locationFootprint identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLocationFootprintAsyncWithHttpInfo (int? locationFootprintId);
        
        /// <summary>
        /// Delete a tag for a locationFootprint.
        /// </summary>
        /// <remarks>
        /// Deletes an existing locationFootprint tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to remove tag from</param>
        /// <param name="locationFootprintTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLocationFootprintTagAsync (int? locationFootprintId, string locationFootprintTag);

        /// <summary>
        /// Delete a tag for a locationFootprint.
        /// </summary>
        /// <remarks>
        /// Deletes an existing locationFootprint tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to remove tag from</param>
        /// <param name="locationFootprintTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLocationFootprintTagAsyncWithHttpInfo (int? locationFootprintId, string locationFootprintTag);
        
        /// <summary>
        /// Get a duplicated a locationFootprint by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated locationFootprint identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be duplicated.</param>
        /// <returns>Task of LocationFootprint</returns>
        System.Threading.Tasks.Task<LocationFootprint> GetDuplicateLocationFootprintByIdAsync (int? locationFootprintId);

        /// <summary>
        /// Get a duplicated a locationFootprint by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated locationFootprint identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be duplicated.</param>
        /// <returns>Task of ApiResponse (LocationFootprint)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocationFootprint>> GetDuplicateLocationFootprintByIdAsyncWithHttpInfo (int? locationFootprintId);
        
        /// <summary>
        /// Search locationFootprints by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of locationFootprints that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;LocationFootprint&gt;</returns>
        System.Threading.Tasks.Task<List<LocationFootprint>> GetLocationFootprintByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search locationFootprints by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of locationFootprints that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LocationFootprint&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LocationFootprint>>> GetLocationFootprintByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a locationFootprint by id
        /// </summary>
        /// <remarks>
        /// Returns the locationFootprint identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be returned.</param>
        /// <returns>Task of LocationFootprint</returns>
        System.Threading.Tasks.Task<LocationFootprint> GetLocationFootprintByIdAsync (int? locationFootprintId);

        /// <summary>
        /// Get a locationFootprint by id
        /// </summary>
        /// <remarks>
        /// Returns the locationFootprint identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be returned.</param>
        /// <returns>Task of ApiResponse (LocationFootprint)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocationFootprint>> GetLocationFootprintByIdAsyncWithHttpInfo (int? locationFootprintId);
        
        /// <summary>
        /// Get the tags for a locationFootprint.
        /// </summary>
        /// <remarks>
        /// Get all existing locationFootprint tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetLocationFootprintTagsAsync (int? locationFootprintId);

        /// <summary>
        /// Get the tags for a locationFootprint.
        /// </summary>
        /// <remarks>
        /// Get all existing locationFootprint tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetLocationFootprintTagsAsyncWithHttpInfo (int? locationFootprintId);
        
        /// <summary>
        /// Update a locationFootprint
        /// </summary>
        /// <remarks>
        /// Updates an existing locationFootprint using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateLocationFootprintAsync (LocationFootprint body);

        /// <summary>
        /// Update a locationFootprint
        /// </summary>
        /// <remarks>
        /// Updates an existing locationFootprint using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLocationFootprintAsyncWithHttpInfo (LocationFootprint body);
        
        /// <summary>
        /// Update a locationFootprint custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing locationFootprint custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateLocationFootprintCustomFieldsAsync (LocationFootprint body);

        /// <summary>
        /// Update a locationFootprint custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing locationFootprint custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLocationFootprintCustomFieldsAsyncWithHttpInfo (LocationFootprint body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LocationFootprintApi : ILocationFootprintApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationFootprintApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocationFootprintApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationFootprintApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LocationFootprintApi(Configuration configuration = null)
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
        /// Create a locationFootprint Inserts a new locationFootprint using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be inserted.</param> 
        /// <returns>LocationFootprint</returns>
        public LocationFootprint AddLocationFootprint (LocationFootprint body)
        {
             ApiResponse<LocationFootprint> localVarResponse = AddLocationFootprintWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a locationFootprint Inserts a new locationFootprint using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be inserted.</param> 
        /// <returns>ApiResponse of LocationFootprint</returns>
        public ApiResponse< LocationFootprint > AddLocationFootprintWithHttpInfo (LocationFootprint body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LocationFootprintApi->AddLocationFootprint");
            
    
            var localVarPath = "/beta/locationFootprint";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationFootprint: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationFootprint: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LocationFootprint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationFootprint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationFootprint)));
            
        }

        
        /// <summary>
        /// Create a locationFootprint Inserts a new locationFootprint using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be inserted.</param>
        /// <returns>Task of LocationFootprint</returns>
        public async System.Threading.Tasks.Task<LocationFootprint> AddLocationFootprintAsync (LocationFootprint body)
        {
             ApiResponse<LocationFootprint> localVarResponse = await AddLocationFootprintAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a locationFootprint Inserts a new locationFootprint using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be inserted.</param>
        /// <returns>Task of ApiResponse (LocationFootprint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocationFootprint>> AddLocationFootprintAsyncWithHttpInfo (LocationFootprint body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddLocationFootprint");
            
    
            var localVarPath = "/beta/locationFootprint";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationFootprint: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationFootprint: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocationFootprint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationFootprint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationFootprint)));
            
        }
        
        /// <summary>
        /// Add new audit for a locationFootprint Adds an audit to an existing locationFootprint.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to add an audit to</param> 
        /// <param name="locationFootprintAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddLocationFootprintAudit (int? locationFootprintId, string locationFootprintAudit)
        {
             AddLocationFootprintAuditWithHttpInfo(locationFootprintId, locationFootprintAudit);
        }

        /// <summary>
        /// Add new audit for a locationFootprint Adds an audit to an existing locationFootprint.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to add an audit to</param> 
        /// <param name="locationFootprintAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddLocationFootprintAuditWithHttpInfo (int? locationFootprintId, string locationFootprintAudit)
        {
            
            // verify the required parameter 'locationFootprintId' is set
            if (locationFootprintId == null)
                throw new ApiException(400, "Missing required parameter 'locationFootprintId' when calling LocationFootprintApi->AddLocationFootprintAudit");
            
            // verify the required parameter 'locationFootprintAudit' is set
            if (locationFootprintAudit == null)
                throw new ApiException(400, "Missing required parameter 'locationFootprintAudit' when calling LocationFootprintApi->AddLocationFootprintAudit");
            
    
            var localVarPath = "/beta/locationFootprint/{locationFootprintId}/audit/{locationFootprintAudit}";
    
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
            if (locationFootprintId != null) localVarPathParams.Add("locationFootprintId", Configuration.ApiClient.ParameterToString(locationFootprintId)); // path parameter
            if (locationFootprintAudit != null) localVarPathParams.Add("locationFootprintAudit", Configuration.ApiClient.ParameterToString(locationFootprintAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationFootprintAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationFootprintAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a locationFootprint Adds an audit to an existing locationFootprint.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to add an audit to</param>
        /// <param name="locationFootprintAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddLocationFootprintAuditAsync (int? locationFootprintId, string locationFootprintAudit)
        {
             await AddLocationFootprintAuditAsyncWithHttpInfo(locationFootprintId, locationFootprintAudit);

        }

        /// <summary>
        /// Add new audit for a locationFootprint Adds an audit to an existing locationFootprint.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to add an audit to</param>
        /// <param name="locationFootprintAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddLocationFootprintAuditAsyncWithHttpInfo (int? locationFootprintId, string locationFootprintAudit)
        {
            // verify the required parameter 'locationFootprintId' is set
            if (locationFootprintId == null) throw new ApiException(400, "Missing required parameter 'locationFootprintId' when calling AddLocationFootprintAudit");
            // verify the required parameter 'locationFootprintAudit' is set
            if (locationFootprintAudit == null) throw new ApiException(400, "Missing required parameter 'locationFootprintAudit' when calling AddLocationFootprintAudit");
            
    
            var localVarPath = "/beta/locationFootprint/{locationFootprintId}/audit/{locationFootprintAudit}";
    
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
            if (locationFootprintId != null) localVarPathParams.Add("locationFootprintId", Configuration.ApiClient.ParameterToString(locationFootprintId)); // path parameter
            if (locationFootprintAudit != null) localVarPathParams.Add("locationFootprintAudit", Configuration.ApiClient.ParameterToString(locationFootprintAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationFootprintAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationFootprintAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a locationFootprint. Adds a tag to an existing locationFootprint.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to add a tag to</param> 
        /// <param name="locationFootprintTag">The tag to add</param> 
        /// <returns></returns>
        public void AddLocationFootprintTag (int? locationFootprintId, string locationFootprintTag)
        {
             AddLocationFootprintTagWithHttpInfo(locationFootprintId, locationFootprintTag);
        }

        /// <summary>
        /// Add new tags for a locationFootprint. Adds a tag to an existing locationFootprint.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to add a tag to</param> 
        /// <param name="locationFootprintTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddLocationFootprintTagWithHttpInfo (int? locationFootprintId, string locationFootprintTag)
        {
            
            // verify the required parameter 'locationFootprintId' is set
            if (locationFootprintId == null)
                throw new ApiException(400, "Missing required parameter 'locationFootprintId' when calling LocationFootprintApi->AddLocationFootprintTag");
            
            // verify the required parameter 'locationFootprintTag' is set
            if (locationFootprintTag == null)
                throw new ApiException(400, "Missing required parameter 'locationFootprintTag' when calling LocationFootprintApi->AddLocationFootprintTag");
            
    
            var localVarPath = "/beta/locationFootprint/{locationFootprintId}/tag/{locationFootprintTag}";
    
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
            if (locationFootprintId != null) localVarPathParams.Add("locationFootprintId", Configuration.ApiClient.ParameterToString(locationFootprintId)); // path parameter
            if (locationFootprintTag != null) localVarPathParams.Add("locationFootprintTag", Configuration.ApiClient.ParameterToString(locationFootprintTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationFootprintTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationFootprintTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a locationFootprint. Adds a tag to an existing locationFootprint.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to add a tag to</param>
        /// <param name="locationFootprintTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddLocationFootprintTagAsync (int? locationFootprintId, string locationFootprintTag)
        {
             await AddLocationFootprintTagAsyncWithHttpInfo(locationFootprintId, locationFootprintTag);

        }

        /// <summary>
        /// Add new tags for a locationFootprint. Adds a tag to an existing locationFootprint.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to add a tag to</param>
        /// <param name="locationFootprintTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddLocationFootprintTagAsyncWithHttpInfo (int? locationFootprintId, string locationFootprintTag)
        {
            // verify the required parameter 'locationFootprintId' is set
            if (locationFootprintId == null) throw new ApiException(400, "Missing required parameter 'locationFootprintId' when calling AddLocationFootprintTag");
            // verify the required parameter 'locationFootprintTag' is set
            if (locationFootprintTag == null) throw new ApiException(400, "Missing required parameter 'locationFootprintTag' when calling AddLocationFootprintTag");
            
    
            var localVarPath = "/beta/locationFootprint/{locationFootprintId}/tag/{locationFootprintTag}";
    
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
            if (locationFootprintId != null) localVarPathParams.Add("locationFootprintId", Configuration.ApiClient.ParameterToString(locationFootprintId)); // path parameter
            if (locationFootprintTag != null) localVarPathParams.Add("locationFootprintTag", Configuration.ApiClient.ParameterToString(locationFootprintTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationFootprintTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationFootprintTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a locationFootprint Deletes the locationFootprint identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be deleted.</param> 
        /// <returns></returns>
        public void DeleteLocationFootprint (int? locationFootprintId)
        {
             DeleteLocationFootprintWithHttpInfo(locationFootprintId);
        }

        /// <summary>
        /// Delete a locationFootprint Deletes the locationFootprint identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLocationFootprintWithHttpInfo (int? locationFootprintId)
        {
            
            // verify the required parameter 'locationFootprintId' is set
            if (locationFootprintId == null)
                throw new ApiException(400, "Missing required parameter 'locationFootprintId' when calling LocationFootprintApi->DeleteLocationFootprint");
            
    
            var localVarPath = "/beta/locationFootprint/{locationFootprintId}";
    
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
            if (locationFootprintId != null) localVarPathParams.Add("locationFootprintId", Configuration.ApiClient.ParameterToString(locationFootprintId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationFootprint: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationFootprint: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a locationFootprint Deletes the locationFootprint identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLocationFootprintAsync (int? locationFootprintId)
        {
             await DeleteLocationFootprintAsyncWithHttpInfo(locationFootprintId);

        }

        /// <summary>
        /// Delete a locationFootprint Deletes the locationFootprint identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLocationFootprintAsyncWithHttpInfo (int? locationFootprintId)
        {
            // verify the required parameter 'locationFootprintId' is set
            if (locationFootprintId == null) throw new ApiException(400, "Missing required parameter 'locationFootprintId' when calling DeleteLocationFootprint");
            
    
            var localVarPath = "/beta/locationFootprint/{locationFootprintId}";
    
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
            if (locationFootprintId != null) localVarPathParams.Add("locationFootprintId", Configuration.ApiClient.ParameterToString(locationFootprintId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationFootprint: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationFootprint: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a locationFootprint. Deletes an existing locationFootprint tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to remove tag from</param> 
        /// <param name="locationFootprintTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteLocationFootprintTag (int? locationFootprintId, string locationFootprintTag)
        {
             DeleteLocationFootprintTagWithHttpInfo(locationFootprintId, locationFootprintTag);
        }

        /// <summary>
        /// Delete a tag for a locationFootprint. Deletes an existing locationFootprint tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to remove tag from</param> 
        /// <param name="locationFootprintTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLocationFootprintTagWithHttpInfo (int? locationFootprintId, string locationFootprintTag)
        {
            
            // verify the required parameter 'locationFootprintId' is set
            if (locationFootprintId == null)
                throw new ApiException(400, "Missing required parameter 'locationFootprintId' when calling LocationFootprintApi->DeleteLocationFootprintTag");
            
            // verify the required parameter 'locationFootprintTag' is set
            if (locationFootprintTag == null)
                throw new ApiException(400, "Missing required parameter 'locationFootprintTag' when calling LocationFootprintApi->DeleteLocationFootprintTag");
            
    
            var localVarPath = "/beta/locationFootprint/{locationFootprintId}/tag/{locationFootprintTag}";
    
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
            if (locationFootprintId != null) localVarPathParams.Add("locationFootprintId", Configuration.ApiClient.ParameterToString(locationFootprintId)); // path parameter
            if (locationFootprintTag != null) localVarPathParams.Add("locationFootprintTag", Configuration.ApiClient.ParameterToString(locationFootprintTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationFootprintTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationFootprintTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a locationFootprint. Deletes an existing locationFootprint tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to remove tag from</param>
        /// <param name="locationFootprintTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLocationFootprintTagAsync (int? locationFootprintId, string locationFootprintTag)
        {
             await DeleteLocationFootprintTagAsyncWithHttpInfo(locationFootprintId, locationFootprintTag);

        }

        /// <summary>
        /// Delete a tag for a locationFootprint. Deletes an existing locationFootprint tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to remove tag from</param>
        /// <param name="locationFootprintTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLocationFootprintTagAsyncWithHttpInfo (int? locationFootprintId, string locationFootprintTag)
        {
            // verify the required parameter 'locationFootprintId' is set
            if (locationFootprintId == null) throw new ApiException(400, "Missing required parameter 'locationFootprintId' when calling DeleteLocationFootprintTag");
            // verify the required parameter 'locationFootprintTag' is set
            if (locationFootprintTag == null) throw new ApiException(400, "Missing required parameter 'locationFootprintTag' when calling DeleteLocationFootprintTag");
            
    
            var localVarPath = "/beta/locationFootprint/{locationFootprintId}/tag/{locationFootprintTag}";
    
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
            if (locationFootprintId != null) localVarPathParams.Add("locationFootprintId", Configuration.ApiClient.ParameterToString(locationFootprintId)); // path parameter
            if (locationFootprintTag != null) localVarPathParams.Add("locationFootprintTag", Configuration.ApiClient.ParameterToString(locationFootprintTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationFootprintTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationFootprintTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a locationFootprint by id Returns a duplicated locationFootprint identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be duplicated.</param> 
        /// <returns>LocationFootprint</returns>
        public LocationFootprint GetDuplicateLocationFootprintById (int? locationFootprintId)
        {
             ApiResponse<LocationFootprint> localVarResponse = GetDuplicateLocationFootprintByIdWithHttpInfo(locationFootprintId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a locationFootprint by id Returns a duplicated locationFootprint identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be duplicated.</param> 
        /// <returns>ApiResponse of LocationFootprint</returns>
        public ApiResponse< LocationFootprint > GetDuplicateLocationFootprintByIdWithHttpInfo (int? locationFootprintId)
        {
            
            // verify the required parameter 'locationFootprintId' is set
            if (locationFootprintId == null)
                throw new ApiException(400, "Missing required parameter 'locationFootprintId' when calling LocationFootprintApi->GetDuplicateLocationFootprintById");
            
    
            var localVarPath = "/beta/locationFootprint/duplicate/{locationFootprintId}";
    
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
            if (locationFootprintId != null) localVarPathParams.Add("locationFootprintId", Configuration.ApiClient.ParameterToString(locationFootprintId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLocationFootprintById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLocationFootprintById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LocationFootprint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationFootprint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationFootprint)));
            
        }

        
        /// <summary>
        /// Get a duplicated a locationFootprint by id Returns a duplicated locationFootprint identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be duplicated.</param>
        /// <returns>Task of LocationFootprint</returns>
        public async System.Threading.Tasks.Task<LocationFootprint> GetDuplicateLocationFootprintByIdAsync (int? locationFootprintId)
        {
             ApiResponse<LocationFootprint> localVarResponse = await GetDuplicateLocationFootprintByIdAsyncWithHttpInfo(locationFootprintId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a locationFootprint by id Returns a duplicated locationFootprint identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be duplicated.</param>
        /// <returns>Task of ApiResponse (LocationFootprint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocationFootprint>> GetDuplicateLocationFootprintByIdAsyncWithHttpInfo (int? locationFootprintId)
        {
            // verify the required parameter 'locationFootprintId' is set
            if (locationFootprintId == null) throw new ApiException(400, "Missing required parameter 'locationFootprintId' when calling GetDuplicateLocationFootprintById");
            
    
            var localVarPath = "/beta/locationFootprint/duplicate/{locationFootprintId}";
    
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
            if (locationFootprintId != null) localVarPathParams.Add("locationFootprintId", Configuration.ApiClient.ParameterToString(locationFootprintId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLocationFootprintById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLocationFootprintById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocationFootprint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationFootprint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationFootprint)));
            
        }
        
        /// <summary>
        /// Search locationFootprints by filter Returns the list of locationFootprints that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;LocationFootprint&gt;</returns>
        public List<LocationFootprint> GetLocationFootprintByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<LocationFootprint>> localVarResponse = GetLocationFootprintByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search locationFootprints by filter Returns the list of locationFootprints that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;LocationFootprint&gt;</returns>
        public ApiResponse< List<LocationFootprint> > GetLocationFootprintByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/locationFootprint/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationFootprintByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationFootprintByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<LocationFootprint>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LocationFootprint>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LocationFootprint>)));
            
        }

        
        /// <summary>
        /// Search locationFootprints by filter Returns the list of locationFootprints that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;LocationFootprint&gt;</returns>
        public async System.Threading.Tasks.Task<List<LocationFootprint>> GetLocationFootprintByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<LocationFootprint>> localVarResponse = await GetLocationFootprintByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search locationFootprints by filter Returns the list of locationFootprints that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LocationFootprint&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LocationFootprint>>> GetLocationFootprintByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/locationFootprint/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationFootprintByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationFootprintByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<LocationFootprint>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LocationFootprint>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LocationFootprint>)));
            
        }
        
        /// <summary>
        /// Get a locationFootprint by id Returns the locationFootprint identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be returned.</param> 
        /// <returns>LocationFootprint</returns>
        public LocationFootprint GetLocationFootprintById (int? locationFootprintId)
        {
             ApiResponse<LocationFootprint> localVarResponse = GetLocationFootprintByIdWithHttpInfo(locationFootprintId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a locationFootprint by id Returns the locationFootprint identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be returned.</param> 
        /// <returns>ApiResponse of LocationFootprint</returns>
        public ApiResponse< LocationFootprint > GetLocationFootprintByIdWithHttpInfo (int? locationFootprintId)
        {
            
            // verify the required parameter 'locationFootprintId' is set
            if (locationFootprintId == null)
                throw new ApiException(400, "Missing required parameter 'locationFootprintId' when calling LocationFootprintApi->GetLocationFootprintById");
            
    
            var localVarPath = "/beta/locationFootprint/{locationFootprintId}";
    
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
            if (locationFootprintId != null) localVarPathParams.Add("locationFootprintId", Configuration.ApiClient.ParameterToString(locationFootprintId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationFootprintById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationFootprintById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LocationFootprint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationFootprint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationFootprint)));
            
        }

        
        /// <summary>
        /// Get a locationFootprint by id Returns the locationFootprint identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be returned.</param>
        /// <returns>Task of LocationFootprint</returns>
        public async System.Threading.Tasks.Task<LocationFootprint> GetLocationFootprintByIdAsync (int? locationFootprintId)
        {
             ApiResponse<LocationFootprint> localVarResponse = await GetLocationFootprintByIdAsyncWithHttpInfo(locationFootprintId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a locationFootprint by id Returns the locationFootprint identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to be returned.</param>
        /// <returns>Task of ApiResponse (LocationFootprint)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocationFootprint>> GetLocationFootprintByIdAsyncWithHttpInfo (int? locationFootprintId)
        {
            // verify the required parameter 'locationFootprintId' is set
            if (locationFootprintId == null) throw new ApiException(400, "Missing required parameter 'locationFootprintId' when calling GetLocationFootprintById");
            
    
            var localVarPath = "/beta/locationFootprint/{locationFootprintId}";
    
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
            if (locationFootprintId != null) localVarPathParams.Add("locationFootprintId", Configuration.ApiClient.ParameterToString(locationFootprintId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationFootprintById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationFootprintById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocationFootprint>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationFootprint) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationFootprint)));
            
        }
        
        /// <summary>
        /// Get the tags for a locationFootprint. Get all existing locationFootprint tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to get tags for</param> 
        /// <returns></returns>
        public void GetLocationFootprintTags (int? locationFootprintId)
        {
             GetLocationFootprintTagsWithHttpInfo(locationFootprintId);
        }

        /// <summary>
        /// Get the tags for a locationFootprint. Get all existing locationFootprint tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetLocationFootprintTagsWithHttpInfo (int? locationFootprintId)
        {
            
            // verify the required parameter 'locationFootprintId' is set
            if (locationFootprintId == null)
                throw new ApiException(400, "Missing required parameter 'locationFootprintId' when calling LocationFootprintApi->GetLocationFootprintTags");
            
    
            var localVarPath = "/beta/locationFootprint/{locationFootprintId}/tag";
    
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
            if (locationFootprintId != null) localVarPathParams.Add("locationFootprintId", Configuration.ApiClient.ParameterToString(locationFootprintId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationFootprintTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationFootprintTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a locationFootprint. Get all existing locationFootprint tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetLocationFootprintTagsAsync (int? locationFootprintId)
        {
             await GetLocationFootprintTagsAsyncWithHttpInfo(locationFootprintId);

        }

        /// <summary>
        /// Get the tags for a locationFootprint. Get all existing locationFootprint tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationFootprintId">Id of the locationFootprint to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetLocationFootprintTagsAsyncWithHttpInfo (int? locationFootprintId)
        {
            // verify the required parameter 'locationFootprintId' is set
            if (locationFootprintId == null) throw new ApiException(400, "Missing required parameter 'locationFootprintId' when calling GetLocationFootprintTags");
            
    
            var localVarPath = "/beta/locationFootprint/{locationFootprintId}/tag";
    
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
            if (locationFootprintId != null) localVarPathParams.Add("locationFootprintId", Configuration.ApiClient.ParameterToString(locationFootprintId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationFootprintTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationFootprintTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a locationFootprint Updates an existing locationFootprint using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be updated.</param> 
        /// <returns></returns>
        public void UpdateLocationFootprint (LocationFootprint body)
        {
             UpdateLocationFootprintWithHttpInfo(body);
        }

        /// <summary>
        /// Update a locationFootprint Updates an existing locationFootprint using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateLocationFootprintWithHttpInfo (LocationFootprint body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LocationFootprintApi->UpdateLocationFootprint");
            
    
            var localVarPath = "/beta/locationFootprint";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationFootprint: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationFootprint: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a locationFootprint Updates an existing locationFootprint using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateLocationFootprintAsync (LocationFootprint body)
        {
             await UpdateLocationFootprintAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a locationFootprint Updates an existing locationFootprint using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLocationFootprintAsyncWithHttpInfo (LocationFootprint body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateLocationFootprint");
            
    
            var localVarPath = "/beta/locationFootprint";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationFootprint: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationFootprint: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a locationFootprint custom fields Updates an existing locationFootprint custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be updated.</param> 
        /// <returns></returns>
        public void UpdateLocationFootprintCustomFields (LocationFootprint body)
        {
             UpdateLocationFootprintCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a locationFootprint custom fields Updates an existing locationFootprint custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateLocationFootprintCustomFieldsWithHttpInfo (LocationFootprint body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LocationFootprintApi->UpdateLocationFootprintCustomFields");
            
    
            var localVarPath = "/beta/locationFootprint/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationFootprintCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationFootprintCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a locationFootprint custom fields Updates an existing locationFootprint custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateLocationFootprintCustomFieldsAsync (LocationFootprint body)
        {
             await UpdateLocationFootprintCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a locationFootprint custom fields Updates an existing locationFootprint custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationFootprint to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLocationFootprintCustomFieldsAsyncWithHttpInfo (LocationFootprint body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateLocationFootprintCustomFields");
            
    
            var localVarPath = "/beta/locationFootprint/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationFootprintCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationFootprintCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
