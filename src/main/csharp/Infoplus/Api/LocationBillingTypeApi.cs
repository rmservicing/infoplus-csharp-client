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
    public interface ILocationBillingTypeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a locationBillingType
        /// </summary>
        /// <remarks>
        /// Inserts a new locationBillingType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be inserted.</param>
        /// <returns>LocationBillingType</returns>
        LocationBillingType AddLocationBillingType (LocationBillingType body);
  
        /// <summary>
        /// Create a locationBillingType
        /// </summary>
        /// <remarks>
        /// Inserts a new locationBillingType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be inserted.</param>
        /// <returns>ApiResponse of LocationBillingType</returns>
        ApiResponse<LocationBillingType> AddLocationBillingTypeWithHttpInfo (LocationBillingType body);
        
        /// <summary>
        /// Add new audit for a locationBillingType
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing locationBillingType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to add an audit to</param>
        /// <param name="locationBillingTypeAudit">The audit to add</param>
        /// <returns></returns>
        void AddLocationBillingTypeAudit (int? locationBillingTypeId, string locationBillingTypeAudit);
  
        /// <summary>
        /// Add new audit for a locationBillingType
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing locationBillingType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to add an audit to</param>
        /// <param name="locationBillingTypeAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddLocationBillingTypeAuditWithHttpInfo (int? locationBillingTypeId, string locationBillingTypeAudit);
        
        /// <summary>
        /// Add new tags for a locationBillingType.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing locationBillingType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to add a tag to</param>
        /// <param name="locationBillingTypeTag">The tag to add</param>
        /// <returns></returns>
        void AddLocationBillingTypeTag (int? locationBillingTypeId, string locationBillingTypeTag);
  
        /// <summary>
        /// Add new tags for a locationBillingType.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing locationBillingType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to add a tag to</param>
        /// <param name="locationBillingTypeTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddLocationBillingTypeTagWithHttpInfo (int? locationBillingTypeId, string locationBillingTypeTag);
        
        /// <summary>
        /// Delete a locationBillingType
        /// </summary>
        /// <remarks>
        /// Deletes the locationBillingType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be deleted.</param>
        /// <returns></returns>
        void DeleteLocationBillingType (int? locationBillingTypeId);
  
        /// <summary>
        /// Delete a locationBillingType
        /// </summary>
        /// <remarks>
        /// Deletes the locationBillingType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLocationBillingTypeWithHttpInfo (int? locationBillingTypeId);
        
        /// <summary>
        /// Delete a tag for a locationBillingType.
        /// </summary>
        /// <remarks>
        /// Deletes an existing locationBillingType tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to remove tag from</param>
        /// <param name="locationBillingTypeTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteLocationBillingTypeTag (int? locationBillingTypeId, string locationBillingTypeTag);
  
        /// <summary>
        /// Delete a tag for a locationBillingType.
        /// </summary>
        /// <remarks>
        /// Deletes an existing locationBillingType tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to remove tag from</param>
        /// <param name="locationBillingTypeTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLocationBillingTypeTagWithHttpInfo (int? locationBillingTypeId, string locationBillingTypeTag);
        
        /// <summary>
        /// Get a duplicated a locationBillingType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated locationBillingType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be duplicated.</param>
        /// <returns>LocationBillingType</returns>
        LocationBillingType GetDuplicateLocationBillingTypeById (int? locationBillingTypeId);
  
        /// <summary>
        /// Get a duplicated a locationBillingType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated locationBillingType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be duplicated.</param>
        /// <returns>ApiResponse of LocationBillingType</returns>
        ApiResponse<LocationBillingType> GetDuplicateLocationBillingTypeByIdWithHttpInfo (int? locationBillingTypeId);
        
        /// <summary>
        /// Search locationBillingTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of locationBillingTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;LocationBillingType&gt;</returns>
        List<LocationBillingType> GetLocationBillingTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search locationBillingTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of locationBillingTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;LocationBillingType&gt;</returns>
        ApiResponse<List<LocationBillingType>> GetLocationBillingTypeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a locationBillingType by id
        /// </summary>
        /// <remarks>
        /// Returns the locationBillingType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be returned.</param>
        /// <returns>LocationBillingType</returns>
        LocationBillingType GetLocationBillingTypeById (int? locationBillingTypeId);
  
        /// <summary>
        /// Get a locationBillingType by id
        /// </summary>
        /// <remarks>
        /// Returns the locationBillingType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be returned.</param>
        /// <returns>ApiResponse of LocationBillingType</returns>
        ApiResponse<LocationBillingType> GetLocationBillingTypeByIdWithHttpInfo (int? locationBillingTypeId);
        
        /// <summary>
        /// Get the tags for a locationBillingType.
        /// </summary>
        /// <remarks>
        /// Get all existing locationBillingType tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to get tags for</param>
        /// <returns></returns>
        void GetLocationBillingTypeTags (int? locationBillingTypeId);
  
        /// <summary>
        /// Get the tags for a locationBillingType.
        /// </summary>
        /// <remarks>
        /// Get all existing locationBillingType tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetLocationBillingTypeTagsWithHttpInfo (int? locationBillingTypeId);
        
        /// <summary>
        /// Update a locationBillingType
        /// </summary>
        /// <remarks>
        /// Updates an existing locationBillingType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be updated.</param>
        /// <returns></returns>
        void UpdateLocationBillingType (LocationBillingType body);
  
        /// <summary>
        /// Update a locationBillingType
        /// </summary>
        /// <remarks>
        /// Updates an existing locationBillingType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateLocationBillingTypeWithHttpInfo (LocationBillingType body);
        
        /// <summary>
        /// Update a locationBillingType custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing locationBillingType custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be updated.</param>
        /// <returns></returns>
        void UpdateLocationBillingTypeCustomFields (LocationBillingType body);
  
        /// <summary>
        /// Update a locationBillingType custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing locationBillingType custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateLocationBillingTypeCustomFieldsWithHttpInfo (LocationBillingType body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a locationBillingType
        /// </summary>
        /// <remarks>
        /// Inserts a new locationBillingType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be inserted.</param>
        /// <returns>Task of LocationBillingType</returns>
        System.Threading.Tasks.Task<LocationBillingType> AddLocationBillingTypeAsync (LocationBillingType body);

        /// <summary>
        /// Create a locationBillingType
        /// </summary>
        /// <remarks>
        /// Inserts a new locationBillingType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be inserted.</param>
        /// <returns>Task of ApiResponse (LocationBillingType)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocationBillingType>> AddLocationBillingTypeAsyncWithHttpInfo (LocationBillingType body);
        
        /// <summary>
        /// Add new audit for a locationBillingType
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing locationBillingType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to add an audit to</param>
        /// <param name="locationBillingTypeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddLocationBillingTypeAuditAsync (int? locationBillingTypeId, string locationBillingTypeAudit);

        /// <summary>
        /// Add new audit for a locationBillingType
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing locationBillingType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to add an audit to</param>
        /// <param name="locationBillingTypeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddLocationBillingTypeAuditAsyncWithHttpInfo (int? locationBillingTypeId, string locationBillingTypeAudit);
        
        /// <summary>
        /// Add new tags for a locationBillingType.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing locationBillingType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to add a tag to</param>
        /// <param name="locationBillingTypeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddLocationBillingTypeTagAsync (int? locationBillingTypeId, string locationBillingTypeTag);

        /// <summary>
        /// Add new tags for a locationBillingType.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing locationBillingType.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to add a tag to</param>
        /// <param name="locationBillingTypeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddLocationBillingTypeTagAsyncWithHttpInfo (int? locationBillingTypeId, string locationBillingTypeTag);
        
        /// <summary>
        /// Delete a locationBillingType
        /// </summary>
        /// <remarks>
        /// Deletes the locationBillingType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLocationBillingTypeAsync (int? locationBillingTypeId);

        /// <summary>
        /// Delete a locationBillingType
        /// </summary>
        /// <remarks>
        /// Deletes the locationBillingType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLocationBillingTypeAsyncWithHttpInfo (int? locationBillingTypeId);
        
        /// <summary>
        /// Delete a tag for a locationBillingType.
        /// </summary>
        /// <remarks>
        /// Deletes an existing locationBillingType tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to remove tag from</param>
        /// <param name="locationBillingTypeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLocationBillingTypeTagAsync (int? locationBillingTypeId, string locationBillingTypeTag);

        /// <summary>
        /// Delete a tag for a locationBillingType.
        /// </summary>
        /// <remarks>
        /// Deletes an existing locationBillingType tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to remove tag from</param>
        /// <param name="locationBillingTypeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLocationBillingTypeTagAsyncWithHttpInfo (int? locationBillingTypeId, string locationBillingTypeTag);
        
        /// <summary>
        /// Get a duplicated a locationBillingType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated locationBillingType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be duplicated.</param>
        /// <returns>Task of LocationBillingType</returns>
        System.Threading.Tasks.Task<LocationBillingType> GetDuplicateLocationBillingTypeByIdAsync (int? locationBillingTypeId);

        /// <summary>
        /// Get a duplicated a locationBillingType by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated locationBillingType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be duplicated.</param>
        /// <returns>Task of ApiResponse (LocationBillingType)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocationBillingType>> GetDuplicateLocationBillingTypeByIdAsyncWithHttpInfo (int? locationBillingTypeId);
        
        /// <summary>
        /// Search locationBillingTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of locationBillingTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;LocationBillingType&gt;</returns>
        System.Threading.Tasks.Task<List<LocationBillingType>> GetLocationBillingTypeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search locationBillingTypes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of locationBillingTypes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LocationBillingType&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LocationBillingType>>> GetLocationBillingTypeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a locationBillingType by id
        /// </summary>
        /// <remarks>
        /// Returns the locationBillingType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be returned.</param>
        /// <returns>Task of LocationBillingType</returns>
        System.Threading.Tasks.Task<LocationBillingType> GetLocationBillingTypeByIdAsync (int? locationBillingTypeId);

        /// <summary>
        /// Get a locationBillingType by id
        /// </summary>
        /// <remarks>
        /// Returns the locationBillingType identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be returned.</param>
        /// <returns>Task of ApiResponse (LocationBillingType)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocationBillingType>> GetLocationBillingTypeByIdAsyncWithHttpInfo (int? locationBillingTypeId);
        
        /// <summary>
        /// Get the tags for a locationBillingType.
        /// </summary>
        /// <remarks>
        /// Get all existing locationBillingType tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetLocationBillingTypeTagsAsync (int? locationBillingTypeId);

        /// <summary>
        /// Get the tags for a locationBillingType.
        /// </summary>
        /// <remarks>
        /// Get all existing locationBillingType tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetLocationBillingTypeTagsAsyncWithHttpInfo (int? locationBillingTypeId);
        
        /// <summary>
        /// Update a locationBillingType
        /// </summary>
        /// <remarks>
        /// Updates an existing locationBillingType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateLocationBillingTypeAsync (LocationBillingType body);

        /// <summary>
        /// Update a locationBillingType
        /// </summary>
        /// <remarks>
        /// Updates an existing locationBillingType using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLocationBillingTypeAsyncWithHttpInfo (LocationBillingType body);
        
        /// <summary>
        /// Update a locationBillingType custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing locationBillingType custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateLocationBillingTypeCustomFieldsAsync (LocationBillingType body);

        /// <summary>
        /// Update a locationBillingType custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing locationBillingType custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLocationBillingTypeCustomFieldsAsyncWithHttpInfo (LocationBillingType body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LocationBillingTypeApi : ILocationBillingTypeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationBillingTypeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocationBillingTypeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationBillingTypeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LocationBillingTypeApi(Configuration configuration = null)
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
        /// Create a locationBillingType Inserts a new locationBillingType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be inserted.</param> 
        /// <returns>LocationBillingType</returns>
        public LocationBillingType AddLocationBillingType (LocationBillingType body)
        {
             ApiResponse<LocationBillingType> localVarResponse = AddLocationBillingTypeWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a locationBillingType Inserts a new locationBillingType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be inserted.</param> 
        /// <returns>ApiResponse of LocationBillingType</returns>
        public ApiResponse< LocationBillingType > AddLocationBillingTypeWithHttpInfo (LocationBillingType body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LocationBillingTypeApi->AddLocationBillingType");
            
    
            var localVarPath = "/beta/locationBillingType";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationBillingType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationBillingType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LocationBillingType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationBillingType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationBillingType)));
            
        }

        
        /// <summary>
        /// Create a locationBillingType Inserts a new locationBillingType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be inserted.</param>
        /// <returns>Task of LocationBillingType</returns>
        public async System.Threading.Tasks.Task<LocationBillingType> AddLocationBillingTypeAsync (LocationBillingType body)
        {
             ApiResponse<LocationBillingType> localVarResponse = await AddLocationBillingTypeAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a locationBillingType Inserts a new locationBillingType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be inserted.</param>
        /// <returns>Task of ApiResponse (LocationBillingType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocationBillingType>> AddLocationBillingTypeAsyncWithHttpInfo (LocationBillingType body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddLocationBillingType");
            
    
            var localVarPath = "/beta/locationBillingType";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationBillingType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationBillingType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocationBillingType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationBillingType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationBillingType)));
            
        }
        
        /// <summary>
        /// Add new audit for a locationBillingType Adds an audit to an existing locationBillingType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to add an audit to</param> 
        /// <param name="locationBillingTypeAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddLocationBillingTypeAudit (int? locationBillingTypeId, string locationBillingTypeAudit)
        {
             AddLocationBillingTypeAuditWithHttpInfo(locationBillingTypeId, locationBillingTypeAudit);
        }

        /// <summary>
        /// Add new audit for a locationBillingType Adds an audit to an existing locationBillingType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to add an audit to</param> 
        /// <param name="locationBillingTypeAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddLocationBillingTypeAuditWithHttpInfo (int? locationBillingTypeId, string locationBillingTypeAudit)
        {
            
            // verify the required parameter 'locationBillingTypeId' is set
            if (locationBillingTypeId == null)
                throw new ApiException(400, "Missing required parameter 'locationBillingTypeId' when calling LocationBillingTypeApi->AddLocationBillingTypeAudit");
            
            // verify the required parameter 'locationBillingTypeAudit' is set
            if (locationBillingTypeAudit == null)
                throw new ApiException(400, "Missing required parameter 'locationBillingTypeAudit' when calling LocationBillingTypeApi->AddLocationBillingTypeAudit");
            
    
            var localVarPath = "/beta/locationBillingType/{locationBillingTypeId}/audit/{locationBillingTypeAudit}";
    
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
            if (locationBillingTypeId != null) localVarPathParams.Add("locationBillingTypeId", Configuration.ApiClient.ParameterToString(locationBillingTypeId)); // path parameter
            if (locationBillingTypeAudit != null) localVarPathParams.Add("locationBillingTypeAudit", Configuration.ApiClient.ParameterToString(locationBillingTypeAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationBillingTypeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationBillingTypeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a locationBillingType Adds an audit to an existing locationBillingType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to add an audit to</param>
        /// <param name="locationBillingTypeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddLocationBillingTypeAuditAsync (int? locationBillingTypeId, string locationBillingTypeAudit)
        {
             await AddLocationBillingTypeAuditAsyncWithHttpInfo(locationBillingTypeId, locationBillingTypeAudit);

        }

        /// <summary>
        /// Add new audit for a locationBillingType Adds an audit to an existing locationBillingType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to add an audit to</param>
        /// <param name="locationBillingTypeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddLocationBillingTypeAuditAsyncWithHttpInfo (int? locationBillingTypeId, string locationBillingTypeAudit)
        {
            // verify the required parameter 'locationBillingTypeId' is set
            if (locationBillingTypeId == null) throw new ApiException(400, "Missing required parameter 'locationBillingTypeId' when calling AddLocationBillingTypeAudit");
            // verify the required parameter 'locationBillingTypeAudit' is set
            if (locationBillingTypeAudit == null) throw new ApiException(400, "Missing required parameter 'locationBillingTypeAudit' when calling AddLocationBillingTypeAudit");
            
    
            var localVarPath = "/beta/locationBillingType/{locationBillingTypeId}/audit/{locationBillingTypeAudit}";
    
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
            if (locationBillingTypeId != null) localVarPathParams.Add("locationBillingTypeId", Configuration.ApiClient.ParameterToString(locationBillingTypeId)); // path parameter
            if (locationBillingTypeAudit != null) localVarPathParams.Add("locationBillingTypeAudit", Configuration.ApiClient.ParameterToString(locationBillingTypeAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationBillingTypeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationBillingTypeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a locationBillingType. Adds a tag to an existing locationBillingType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to add a tag to</param> 
        /// <param name="locationBillingTypeTag">The tag to add</param> 
        /// <returns></returns>
        public void AddLocationBillingTypeTag (int? locationBillingTypeId, string locationBillingTypeTag)
        {
             AddLocationBillingTypeTagWithHttpInfo(locationBillingTypeId, locationBillingTypeTag);
        }

        /// <summary>
        /// Add new tags for a locationBillingType. Adds a tag to an existing locationBillingType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to add a tag to</param> 
        /// <param name="locationBillingTypeTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddLocationBillingTypeTagWithHttpInfo (int? locationBillingTypeId, string locationBillingTypeTag)
        {
            
            // verify the required parameter 'locationBillingTypeId' is set
            if (locationBillingTypeId == null)
                throw new ApiException(400, "Missing required parameter 'locationBillingTypeId' when calling LocationBillingTypeApi->AddLocationBillingTypeTag");
            
            // verify the required parameter 'locationBillingTypeTag' is set
            if (locationBillingTypeTag == null)
                throw new ApiException(400, "Missing required parameter 'locationBillingTypeTag' when calling LocationBillingTypeApi->AddLocationBillingTypeTag");
            
    
            var localVarPath = "/beta/locationBillingType/{locationBillingTypeId}/tag/{locationBillingTypeTag}";
    
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
            if (locationBillingTypeId != null) localVarPathParams.Add("locationBillingTypeId", Configuration.ApiClient.ParameterToString(locationBillingTypeId)); // path parameter
            if (locationBillingTypeTag != null) localVarPathParams.Add("locationBillingTypeTag", Configuration.ApiClient.ParameterToString(locationBillingTypeTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationBillingTypeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationBillingTypeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a locationBillingType. Adds a tag to an existing locationBillingType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to add a tag to</param>
        /// <param name="locationBillingTypeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddLocationBillingTypeTagAsync (int? locationBillingTypeId, string locationBillingTypeTag)
        {
             await AddLocationBillingTypeTagAsyncWithHttpInfo(locationBillingTypeId, locationBillingTypeTag);

        }

        /// <summary>
        /// Add new tags for a locationBillingType. Adds a tag to an existing locationBillingType.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to add a tag to</param>
        /// <param name="locationBillingTypeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddLocationBillingTypeTagAsyncWithHttpInfo (int? locationBillingTypeId, string locationBillingTypeTag)
        {
            // verify the required parameter 'locationBillingTypeId' is set
            if (locationBillingTypeId == null) throw new ApiException(400, "Missing required parameter 'locationBillingTypeId' when calling AddLocationBillingTypeTag");
            // verify the required parameter 'locationBillingTypeTag' is set
            if (locationBillingTypeTag == null) throw new ApiException(400, "Missing required parameter 'locationBillingTypeTag' when calling AddLocationBillingTypeTag");
            
    
            var localVarPath = "/beta/locationBillingType/{locationBillingTypeId}/tag/{locationBillingTypeTag}";
    
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
            if (locationBillingTypeId != null) localVarPathParams.Add("locationBillingTypeId", Configuration.ApiClient.ParameterToString(locationBillingTypeId)); // path parameter
            if (locationBillingTypeTag != null) localVarPathParams.Add("locationBillingTypeTag", Configuration.ApiClient.ParameterToString(locationBillingTypeTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationBillingTypeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationBillingTypeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a locationBillingType Deletes the locationBillingType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be deleted.</param> 
        /// <returns></returns>
        public void DeleteLocationBillingType (int? locationBillingTypeId)
        {
             DeleteLocationBillingTypeWithHttpInfo(locationBillingTypeId);
        }

        /// <summary>
        /// Delete a locationBillingType Deletes the locationBillingType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLocationBillingTypeWithHttpInfo (int? locationBillingTypeId)
        {
            
            // verify the required parameter 'locationBillingTypeId' is set
            if (locationBillingTypeId == null)
                throw new ApiException(400, "Missing required parameter 'locationBillingTypeId' when calling LocationBillingTypeApi->DeleteLocationBillingType");
            
    
            var localVarPath = "/beta/locationBillingType/{locationBillingTypeId}";
    
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
            if (locationBillingTypeId != null) localVarPathParams.Add("locationBillingTypeId", Configuration.ApiClient.ParameterToString(locationBillingTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationBillingType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationBillingType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a locationBillingType Deletes the locationBillingType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLocationBillingTypeAsync (int? locationBillingTypeId)
        {
             await DeleteLocationBillingTypeAsyncWithHttpInfo(locationBillingTypeId);

        }

        /// <summary>
        /// Delete a locationBillingType Deletes the locationBillingType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLocationBillingTypeAsyncWithHttpInfo (int? locationBillingTypeId)
        {
            // verify the required parameter 'locationBillingTypeId' is set
            if (locationBillingTypeId == null) throw new ApiException(400, "Missing required parameter 'locationBillingTypeId' when calling DeleteLocationBillingType");
            
    
            var localVarPath = "/beta/locationBillingType/{locationBillingTypeId}";
    
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
            if (locationBillingTypeId != null) localVarPathParams.Add("locationBillingTypeId", Configuration.ApiClient.ParameterToString(locationBillingTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationBillingType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationBillingType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a locationBillingType. Deletes an existing locationBillingType tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to remove tag from</param> 
        /// <param name="locationBillingTypeTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteLocationBillingTypeTag (int? locationBillingTypeId, string locationBillingTypeTag)
        {
             DeleteLocationBillingTypeTagWithHttpInfo(locationBillingTypeId, locationBillingTypeTag);
        }

        /// <summary>
        /// Delete a tag for a locationBillingType. Deletes an existing locationBillingType tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to remove tag from</param> 
        /// <param name="locationBillingTypeTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLocationBillingTypeTagWithHttpInfo (int? locationBillingTypeId, string locationBillingTypeTag)
        {
            
            // verify the required parameter 'locationBillingTypeId' is set
            if (locationBillingTypeId == null)
                throw new ApiException(400, "Missing required parameter 'locationBillingTypeId' when calling LocationBillingTypeApi->DeleteLocationBillingTypeTag");
            
            // verify the required parameter 'locationBillingTypeTag' is set
            if (locationBillingTypeTag == null)
                throw new ApiException(400, "Missing required parameter 'locationBillingTypeTag' when calling LocationBillingTypeApi->DeleteLocationBillingTypeTag");
            
    
            var localVarPath = "/beta/locationBillingType/{locationBillingTypeId}/tag/{locationBillingTypeTag}";
    
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
            if (locationBillingTypeId != null) localVarPathParams.Add("locationBillingTypeId", Configuration.ApiClient.ParameterToString(locationBillingTypeId)); // path parameter
            if (locationBillingTypeTag != null) localVarPathParams.Add("locationBillingTypeTag", Configuration.ApiClient.ParameterToString(locationBillingTypeTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationBillingTypeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationBillingTypeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a locationBillingType. Deletes an existing locationBillingType tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to remove tag from</param>
        /// <param name="locationBillingTypeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLocationBillingTypeTagAsync (int? locationBillingTypeId, string locationBillingTypeTag)
        {
             await DeleteLocationBillingTypeTagAsyncWithHttpInfo(locationBillingTypeId, locationBillingTypeTag);

        }

        /// <summary>
        /// Delete a tag for a locationBillingType. Deletes an existing locationBillingType tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to remove tag from</param>
        /// <param name="locationBillingTypeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLocationBillingTypeTagAsyncWithHttpInfo (int? locationBillingTypeId, string locationBillingTypeTag)
        {
            // verify the required parameter 'locationBillingTypeId' is set
            if (locationBillingTypeId == null) throw new ApiException(400, "Missing required parameter 'locationBillingTypeId' when calling DeleteLocationBillingTypeTag");
            // verify the required parameter 'locationBillingTypeTag' is set
            if (locationBillingTypeTag == null) throw new ApiException(400, "Missing required parameter 'locationBillingTypeTag' when calling DeleteLocationBillingTypeTag");
            
    
            var localVarPath = "/beta/locationBillingType/{locationBillingTypeId}/tag/{locationBillingTypeTag}";
    
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
            if (locationBillingTypeId != null) localVarPathParams.Add("locationBillingTypeId", Configuration.ApiClient.ParameterToString(locationBillingTypeId)); // path parameter
            if (locationBillingTypeTag != null) localVarPathParams.Add("locationBillingTypeTag", Configuration.ApiClient.ParameterToString(locationBillingTypeTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationBillingTypeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationBillingTypeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a locationBillingType by id Returns a duplicated locationBillingType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be duplicated.</param> 
        /// <returns>LocationBillingType</returns>
        public LocationBillingType GetDuplicateLocationBillingTypeById (int? locationBillingTypeId)
        {
             ApiResponse<LocationBillingType> localVarResponse = GetDuplicateLocationBillingTypeByIdWithHttpInfo(locationBillingTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a locationBillingType by id Returns a duplicated locationBillingType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be duplicated.</param> 
        /// <returns>ApiResponse of LocationBillingType</returns>
        public ApiResponse< LocationBillingType > GetDuplicateLocationBillingTypeByIdWithHttpInfo (int? locationBillingTypeId)
        {
            
            // verify the required parameter 'locationBillingTypeId' is set
            if (locationBillingTypeId == null)
                throw new ApiException(400, "Missing required parameter 'locationBillingTypeId' when calling LocationBillingTypeApi->GetDuplicateLocationBillingTypeById");
            
    
            var localVarPath = "/beta/locationBillingType/duplicate/{locationBillingTypeId}";
    
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
            if (locationBillingTypeId != null) localVarPathParams.Add("locationBillingTypeId", Configuration.ApiClient.ParameterToString(locationBillingTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLocationBillingTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLocationBillingTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LocationBillingType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationBillingType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationBillingType)));
            
        }

        
        /// <summary>
        /// Get a duplicated a locationBillingType by id Returns a duplicated locationBillingType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be duplicated.</param>
        /// <returns>Task of LocationBillingType</returns>
        public async System.Threading.Tasks.Task<LocationBillingType> GetDuplicateLocationBillingTypeByIdAsync (int? locationBillingTypeId)
        {
             ApiResponse<LocationBillingType> localVarResponse = await GetDuplicateLocationBillingTypeByIdAsyncWithHttpInfo(locationBillingTypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a locationBillingType by id Returns a duplicated locationBillingType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be duplicated.</param>
        /// <returns>Task of ApiResponse (LocationBillingType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocationBillingType>> GetDuplicateLocationBillingTypeByIdAsyncWithHttpInfo (int? locationBillingTypeId)
        {
            // verify the required parameter 'locationBillingTypeId' is set
            if (locationBillingTypeId == null) throw new ApiException(400, "Missing required parameter 'locationBillingTypeId' when calling GetDuplicateLocationBillingTypeById");
            
    
            var localVarPath = "/beta/locationBillingType/duplicate/{locationBillingTypeId}";
    
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
            if (locationBillingTypeId != null) localVarPathParams.Add("locationBillingTypeId", Configuration.ApiClient.ParameterToString(locationBillingTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLocationBillingTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLocationBillingTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocationBillingType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationBillingType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationBillingType)));
            
        }
        
        /// <summary>
        /// Search locationBillingTypes by filter Returns the list of locationBillingTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;LocationBillingType&gt;</returns>
        public List<LocationBillingType> GetLocationBillingTypeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<LocationBillingType>> localVarResponse = GetLocationBillingTypeByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search locationBillingTypes by filter Returns the list of locationBillingTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;LocationBillingType&gt;</returns>
        public ApiResponse< List<LocationBillingType> > GetLocationBillingTypeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/locationBillingType/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationBillingTypeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationBillingTypeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<LocationBillingType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LocationBillingType>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LocationBillingType>)));
            
        }

        
        /// <summary>
        /// Search locationBillingTypes by filter Returns the list of locationBillingTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;LocationBillingType&gt;</returns>
        public async System.Threading.Tasks.Task<List<LocationBillingType>> GetLocationBillingTypeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<LocationBillingType>> localVarResponse = await GetLocationBillingTypeByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search locationBillingTypes by filter Returns the list of locationBillingTypes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LocationBillingType&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LocationBillingType>>> GetLocationBillingTypeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/locationBillingType/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationBillingTypeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationBillingTypeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<LocationBillingType>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LocationBillingType>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LocationBillingType>)));
            
        }
        
        /// <summary>
        /// Get a locationBillingType by id Returns the locationBillingType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be returned.</param> 
        /// <returns>LocationBillingType</returns>
        public LocationBillingType GetLocationBillingTypeById (int? locationBillingTypeId)
        {
             ApiResponse<LocationBillingType> localVarResponse = GetLocationBillingTypeByIdWithHttpInfo(locationBillingTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a locationBillingType by id Returns the locationBillingType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be returned.</param> 
        /// <returns>ApiResponse of LocationBillingType</returns>
        public ApiResponse< LocationBillingType > GetLocationBillingTypeByIdWithHttpInfo (int? locationBillingTypeId)
        {
            
            // verify the required parameter 'locationBillingTypeId' is set
            if (locationBillingTypeId == null)
                throw new ApiException(400, "Missing required parameter 'locationBillingTypeId' when calling LocationBillingTypeApi->GetLocationBillingTypeById");
            
    
            var localVarPath = "/beta/locationBillingType/{locationBillingTypeId}";
    
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
            if (locationBillingTypeId != null) localVarPathParams.Add("locationBillingTypeId", Configuration.ApiClient.ParameterToString(locationBillingTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationBillingTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationBillingTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LocationBillingType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationBillingType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationBillingType)));
            
        }

        
        /// <summary>
        /// Get a locationBillingType by id Returns the locationBillingType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be returned.</param>
        /// <returns>Task of LocationBillingType</returns>
        public async System.Threading.Tasks.Task<LocationBillingType> GetLocationBillingTypeByIdAsync (int? locationBillingTypeId)
        {
             ApiResponse<LocationBillingType> localVarResponse = await GetLocationBillingTypeByIdAsyncWithHttpInfo(locationBillingTypeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a locationBillingType by id Returns the locationBillingType identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to be returned.</param>
        /// <returns>Task of ApiResponse (LocationBillingType)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocationBillingType>> GetLocationBillingTypeByIdAsyncWithHttpInfo (int? locationBillingTypeId)
        {
            // verify the required parameter 'locationBillingTypeId' is set
            if (locationBillingTypeId == null) throw new ApiException(400, "Missing required parameter 'locationBillingTypeId' when calling GetLocationBillingTypeById");
            
    
            var localVarPath = "/beta/locationBillingType/{locationBillingTypeId}";
    
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
            if (locationBillingTypeId != null) localVarPathParams.Add("locationBillingTypeId", Configuration.ApiClient.ParameterToString(locationBillingTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationBillingTypeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationBillingTypeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocationBillingType>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationBillingType) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationBillingType)));
            
        }
        
        /// <summary>
        /// Get the tags for a locationBillingType. Get all existing locationBillingType tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to get tags for</param> 
        /// <returns></returns>
        public void GetLocationBillingTypeTags (int? locationBillingTypeId)
        {
             GetLocationBillingTypeTagsWithHttpInfo(locationBillingTypeId);
        }

        /// <summary>
        /// Get the tags for a locationBillingType. Get all existing locationBillingType tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetLocationBillingTypeTagsWithHttpInfo (int? locationBillingTypeId)
        {
            
            // verify the required parameter 'locationBillingTypeId' is set
            if (locationBillingTypeId == null)
                throw new ApiException(400, "Missing required parameter 'locationBillingTypeId' when calling LocationBillingTypeApi->GetLocationBillingTypeTags");
            
    
            var localVarPath = "/beta/locationBillingType/{locationBillingTypeId}/tag";
    
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
            if (locationBillingTypeId != null) localVarPathParams.Add("locationBillingTypeId", Configuration.ApiClient.ParameterToString(locationBillingTypeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationBillingTypeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationBillingTypeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a locationBillingType. Get all existing locationBillingType tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetLocationBillingTypeTagsAsync (int? locationBillingTypeId)
        {
             await GetLocationBillingTypeTagsAsyncWithHttpInfo(locationBillingTypeId);

        }

        /// <summary>
        /// Get the tags for a locationBillingType. Get all existing locationBillingType tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationBillingTypeId">Id of the locationBillingType to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetLocationBillingTypeTagsAsyncWithHttpInfo (int? locationBillingTypeId)
        {
            // verify the required parameter 'locationBillingTypeId' is set
            if (locationBillingTypeId == null) throw new ApiException(400, "Missing required parameter 'locationBillingTypeId' when calling GetLocationBillingTypeTags");
            
    
            var localVarPath = "/beta/locationBillingType/{locationBillingTypeId}/tag";
    
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
            if (locationBillingTypeId != null) localVarPathParams.Add("locationBillingTypeId", Configuration.ApiClient.ParameterToString(locationBillingTypeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationBillingTypeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationBillingTypeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a locationBillingType Updates an existing locationBillingType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be updated.</param> 
        /// <returns></returns>
        public void UpdateLocationBillingType (LocationBillingType body)
        {
             UpdateLocationBillingTypeWithHttpInfo(body);
        }

        /// <summary>
        /// Update a locationBillingType Updates an existing locationBillingType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateLocationBillingTypeWithHttpInfo (LocationBillingType body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LocationBillingTypeApi->UpdateLocationBillingType");
            
    
            var localVarPath = "/beta/locationBillingType";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationBillingType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationBillingType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a locationBillingType Updates an existing locationBillingType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateLocationBillingTypeAsync (LocationBillingType body)
        {
             await UpdateLocationBillingTypeAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a locationBillingType Updates an existing locationBillingType using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLocationBillingTypeAsyncWithHttpInfo (LocationBillingType body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateLocationBillingType");
            
    
            var localVarPath = "/beta/locationBillingType";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationBillingType: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationBillingType: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a locationBillingType custom fields Updates an existing locationBillingType custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be updated.</param> 
        /// <returns></returns>
        public void UpdateLocationBillingTypeCustomFields (LocationBillingType body)
        {
             UpdateLocationBillingTypeCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a locationBillingType custom fields Updates an existing locationBillingType custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateLocationBillingTypeCustomFieldsWithHttpInfo (LocationBillingType body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LocationBillingTypeApi->UpdateLocationBillingTypeCustomFields");
            
    
            var localVarPath = "/beta/locationBillingType/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationBillingTypeCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationBillingTypeCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a locationBillingType custom fields Updates an existing locationBillingType custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateLocationBillingTypeCustomFieldsAsync (LocationBillingType body)
        {
             await UpdateLocationBillingTypeCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a locationBillingType custom fields Updates an existing locationBillingType custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationBillingType to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLocationBillingTypeCustomFieldsAsyncWithHttpInfo (LocationBillingType body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateLocationBillingTypeCustomFields");
            
    
            var localVarPath = "/beta/locationBillingType/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationBillingTypeCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationBillingTypeCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
