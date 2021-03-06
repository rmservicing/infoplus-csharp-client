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
    public interface ILocationAddressSchemeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a locationAddressScheme
        /// </summary>
        /// <remarks>
        /// Inserts a new locationAddressScheme using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be inserted.</param>
        /// <returns>LocationAddressScheme</returns>
        LocationAddressScheme AddLocationAddressScheme (LocationAddressScheme body);
  
        /// <summary>
        /// Create a locationAddressScheme
        /// </summary>
        /// <remarks>
        /// Inserts a new locationAddressScheme using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be inserted.</param>
        /// <returns>ApiResponse of LocationAddressScheme</returns>
        ApiResponse<LocationAddressScheme> AddLocationAddressSchemeWithHttpInfo (LocationAddressScheme body);
        
        /// <summary>
        /// Add new audit for a locationAddressScheme
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing locationAddressScheme.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to add an audit to</param>
        /// <param name="locationAddressSchemeAudit">The audit to add</param>
        /// <returns></returns>
        void AddLocationAddressSchemeAudit (int? locationAddressSchemeId, string locationAddressSchemeAudit);
  
        /// <summary>
        /// Add new audit for a locationAddressScheme
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing locationAddressScheme.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to add an audit to</param>
        /// <param name="locationAddressSchemeAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddLocationAddressSchemeAuditWithHttpInfo (int? locationAddressSchemeId, string locationAddressSchemeAudit);
        
        /// <summary>
        /// Add new tags for a locationAddressScheme.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing locationAddressScheme.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to add a tag to</param>
        /// <param name="locationAddressSchemeTag">The tag to add</param>
        /// <returns></returns>
        void AddLocationAddressSchemeTag (int? locationAddressSchemeId, string locationAddressSchemeTag);
  
        /// <summary>
        /// Add new tags for a locationAddressScheme.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing locationAddressScheme.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to add a tag to</param>
        /// <param name="locationAddressSchemeTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddLocationAddressSchemeTagWithHttpInfo (int? locationAddressSchemeId, string locationAddressSchemeTag);
        
        /// <summary>
        /// Delete a locationAddressScheme
        /// </summary>
        /// <remarks>
        /// Deletes the locationAddressScheme identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be deleted.</param>
        /// <returns></returns>
        void DeleteLocationAddressScheme (int? locationAddressSchemeId);
  
        /// <summary>
        /// Delete a locationAddressScheme
        /// </summary>
        /// <remarks>
        /// Deletes the locationAddressScheme identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLocationAddressSchemeWithHttpInfo (int? locationAddressSchemeId);
        
        /// <summary>
        /// Delete a tag for a locationAddressScheme.
        /// </summary>
        /// <remarks>
        /// Deletes an existing locationAddressScheme tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to remove tag from</param>
        /// <param name="locationAddressSchemeTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteLocationAddressSchemeTag (int? locationAddressSchemeId, string locationAddressSchemeTag);
  
        /// <summary>
        /// Delete a tag for a locationAddressScheme.
        /// </summary>
        /// <remarks>
        /// Deletes an existing locationAddressScheme tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to remove tag from</param>
        /// <param name="locationAddressSchemeTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLocationAddressSchemeTagWithHttpInfo (int? locationAddressSchemeId, string locationAddressSchemeTag);
        
        /// <summary>
        /// Get a duplicated a locationAddressScheme by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated locationAddressScheme identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be duplicated.</param>
        /// <returns>LocationAddressScheme</returns>
        LocationAddressScheme GetDuplicateLocationAddressSchemeById (int? locationAddressSchemeId);
  
        /// <summary>
        /// Get a duplicated a locationAddressScheme by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated locationAddressScheme identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be duplicated.</param>
        /// <returns>ApiResponse of LocationAddressScheme</returns>
        ApiResponse<LocationAddressScheme> GetDuplicateLocationAddressSchemeByIdWithHttpInfo (int? locationAddressSchemeId);
        
        /// <summary>
        /// Search locationAddressSchemes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of locationAddressSchemes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;LocationAddressScheme&gt;</returns>
        List<LocationAddressScheme> GetLocationAddressSchemeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search locationAddressSchemes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of locationAddressSchemes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;LocationAddressScheme&gt;</returns>
        ApiResponse<List<LocationAddressScheme>> GetLocationAddressSchemeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a locationAddressScheme by id
        /// </summary>
        /// <remarks>
        /// Returns the locationAddressScheme identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be returned.</param>
        /// <returns>LocationAddressScheme</returns>
        LocationAddressScheme GetLocationAddressSchemeById (int? locationAddressSchemeId);
  
        /// <summary>
        /// Get a locationAddressScheme by id
        /// </summary>
        /// <remarks>
        /// Returns the locationAddressScheme identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be returned.</param>
        /// <returns>ApiResponse of LocationAddressScheme</returns>
        ApiResponse<LocationAddressScheme> GetLocationAddressSchemeByIdWithHttpInfo (int? locationAddressSchemeId);
        
        /// <summary>
        /// Get the tags for a locationAddressScheme.
        /// </summary>
        /// <remarks>
        /// Get all existing locationAddressScheme tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to get tags for</param>
        /// <returns></returns>
        void GetLocationAddressSchemeTags (int? locationAddressSchemeId);
  
        /// <summary>
        /// Get the tags for a locationAddressScheme.
        /// </summary>
        /// <remarks>
        /// Get all existing locationAddressScheme tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetLocationAddressSchemeTagsWithHttpInfo (int? locationAddressSchemeId);
        
        /// <summary>
        /// Update a locationAddressScheme
        /// </summary>
        /// <remarks>
        /// Updates an existing locationAddressScheme using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be updated.</param>
        /// <returns></returns>
        void UpdateLocationAddressScheme (LocationAddressScheme body);
  
        /// <summary>
        /// Update a locationAddressScheme
        /// </summary>
        /// <remarks>
        /// Updates an existing locationAddressScheme using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateLocationAddressSchemeWithHttpInfo (LocationAddressScheme body);
        
        /// <summary>
        /// Update a locationAddressScheme custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing locationAddressScheme custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be updated.</param>
        /// <returns></returns>
        void UpdateLocationAddressSchemeCustomFields (LocationAddressScheme body);
  
        /// <summary>
        /// Update a locationAddressScheme custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing locationAddressScheme custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateLocationAddressSchemeCustomFieldsWithHttpInfo (LocationAddressScheme body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a locationAddressScheme
        /// </summary>
        /// <remarks>
        /// Inserts a new locationAddressScheme using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be inserted.</param>
        /// <returns>Task of LocationAddressScheme</returns>
        System.Threading.Tasks.Task<LocationAddressScheme> AddLocationAddressSchemeAsync (LocationAddressScheme body);

        /// <summary>
        /// Create a locationAddressScheme
        /// </summary>
        /// <remarks>
        /// Inserts a new locationAddressScheme using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be inserted.</param>
        /// <returns>Task of ApiResponse (LocationAddressScheme)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocationAddressScheme>> AddLocationAddressSchemeAsyncWithHttpInfo (LocationAddressScheme body);
        
        /// <summary>
        /// Add new audit for a locationAddressScheme
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing locationAddressScheme.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to add an audit to</param>
        /// <param name="locationAddressSchemeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddLocationAddressSchemeAuditAsync (int? locationAddressSchemeId, string locationAddressSchemeAudit);

        /// <summary>
        /// Add new audit for a locationAddressScheme
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing locationAddressScheme.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to add an audit to</param>
        /// <param name="locationAddressSchemeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddLocationAddressSchemeAuditAsyncWithHttpInfo (int? locationAddressSchemeId, string locationAddressSchemeAudit);
        
        /// <summary>
        /// Add new tags for a locationAddressScheme.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing locationAddressScheme.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to add a tag to</param>
        /// <param name="locationAddressSchemeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddLocationAddressSchemeTagAsync (int? locationAddressSchemeId, string locationAddressSchemeTag);

        /// <summary>
        /// Add new tags for a locationAddressScheme.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing locationAddressScheme.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to add a tag to</param>
        /// <param name="locationAddressSchemeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddLocationAddressSchemeTagAsyncWithHttpInfo (int? locationAddressSchemeId, string locationAddressSchemeTag);
        
        /// <summary>
        /// Delete a locationAddressScheme
        /// </summary>
        /// <remarks>
        /// Deletes the locationAddressScheme identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLocationAddressSchemeAsync (int? locationAddressSchemeId);

        /// <summary>
        /// Delete a locationAddressScheme
        /// </summary>
        /// <remarks>
        /// Deletes the locationAddressScheme identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLocationAddressSchemeAsyncWithHttpInfo (int? locationAddressSchemeId);
        
        /// <summary>
        /// Delete a tag for a locationAddressScheme.
        /// </summary>
        /// <remarks>
        /// Deletes an existing locationAddressScheme tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to remove tag from</param>
        /// <param name="locationAddressSchemeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLocationAddressSchemeTagAsync (int? locationAddressSchemeId, string locationAddressSchemeTag);

        /// <summary>
        /// Delete a tag for a locationAddressScheme.
        /// </summary>
        /// <remarks>
        /// Deletes an existing locationAddressScheme tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to remove tag from</param>
        /// <param name="locationAddressSchemeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLocationAddressSchemeTagAsyncWithHttpInfo (int? locationAddressSchemeId, string locationAddressSchemeTag);
        
        /// <summary>
        /// Get a duplicated a locationAddressScheme by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated locationAddressScheme identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be duplicated.</param>
        /// <returns>Task of LocationAddressScheme</returns>
        System.Threading.Tasks.Task<LocationAddressScheme> GetDuplicateLocationAddressSchemeByIdAsync (int? locationAddressSchemeId);

        /// <summary>
        /// Get a duplicated a locationAddressScheme by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated locationAddressScheme identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be duplicated.</param>
        /// <returns>Task of ApiResponse (LocationAddressScheme)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocationAddressScheme>> GetDuplicateLocationAddressSchemeByIdAsyncWithHttpInfo (int? locationAddressSchemeId);
        
        /// <summary>
        /// Search locationAddressSchemes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of locationAddressSchemes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;LocationAddressScheme&gt;</returns>
        System.Threading.Tasks.Task<List<LocationAddressScheme>> GetLocationAddressSchemeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search locationAddressSchemes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of locationAddressSchemes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LocationAddressScheme&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LocationAddressScheme>>> GetLocationAddressSchemeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a locationAddressScheme by id
        /// </summary>
        /// <remarks>
        /// Returns the locationAddressScheme identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be returned.</param>
        /// <returns>Task of LocationAddressScheme</returns>
        System.Threading.Tasks.Task<LocationAddressScheme> GetLocationAddressSchemeByIdAsync (int? locationAddressSchemeId);

        /// <summary>
        /// Get a locationAddressScheme by id
        /// </summary>
        /// <remarks>
        /// Returns the locationAddressScheme identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be returned.</param>
        /// <returns>Task of ApiResponse (LocationAddressScheme)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocationAddressScheme>> GetLocationAddressSchemeByIdAsyncWithHttpInfo (int? locationAddressSchemeId);
        
        /// <summary>
        /// Get the tags for a locationAddressScheme.
        /// </summary>
        /// <remarks>
        /// Get all existing locationAddressScheme tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetLocationAddressSchemeTagsAsync (int? locationAddressSchemeId);

        /// <summary>
        /// Get the tags for a locationAddressScheme.
        /// </summary>
        /// <remarks>
        /// Get all existing locationAddressScheme tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetLocationAddressSchemeTagsAsyncWithHttpInfo (int? locationAddressSchemeId);
        
        /// <summary>
        /// Update a locationAddressScheme
        /// </summary>
        /// <remarks>
        /// Updates an existing locationAddressScheme using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateLocationAddressSchemeAsync (LocationAddressScheme body);

        /// <summary>
        /// Update a locationAddressScheme
        /// </summary>
        /// <remarks>
        /// Updates an existing locationAddressScheme using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLocationAddressSchemeAsyncWithHttpInfo (LocationAddressScheme body);
        
        /// <summary>
        /// Update a locationAddressScheme custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing locationAddressScheme custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateLocationAddressSchemeCustomFieldsAsync (LocationAddressScheme body);

        /// <summary>
        /// Update a locationAddressScheme custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing locationAddressScheme custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLocationAddressSchemeCustomFieldsAsyncWithHttpInfo (LocationAddressScheme body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LocationAddressSchemeApi : ILocationAddressSchemeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationAddressSchemeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocationAddressSchemeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationAddressSchemeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LocationAddressSchemeApi(Configuration configuration = null)
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
        /// Create a locationAddressScheme Inserts a new locationAddressScheme using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be inserted.</param> 
        /// <returns>LocationAddressScheme</returns>
        public LocationAddressScheme AddLocationAddressScheme (LocationAddressScheme body)
        {
             ApiResponse<LocationAddressScheme> localVarResponse = AddLocationAddressSchemeWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a locationAddressScheme Inserts a new locationAddressScheme using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be inserted.</param> 
        /// <returns>ApiResponse of LocationAddressScheme</returns>
        public ApiResponse< LocationAddressScheme > AddLocationAddressSchemeWithHttpInfo (LocationAddressScheme body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LocationAddressSchemeApi->AddLocationAddressScheme");
            
    
            var localVarPath = "/beta/locationAddressScheme";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationAddressScheme: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationAddressScheme: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LocationAddressScheme>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationAddressScheme) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationAddressScheme)));
            
        }

        
        /// <summary>
        /// Create a locationAddressScheme Inserts a new locationAddressScheme using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be inserted.</param>
        /// <returns>Task of LocationAddressScheme</returns>
        public async System.Threading.Tasks.Task<LocationAddressScheme> AddLocationAddressSchemeAsync (LocationAddressScheme body)
        {
             ApiResponse<LocationAddressScheme> localVarResponse = await AddLocationAddressSchemeAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a locationAddressScheme Inserts a new locationAddressScheme using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be inserted.</param>
        /// <returns>Task of ApiResponse (LocationAddressScheme)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocationAddressScheme>> AddLocationAddressSchemeAsyncWithHttpInfo (LocationAddressScheme body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddLocationAddressScheme");
            
    
            var localVarPath = "/beta/locationAddressScheme";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationAddressScheme: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationAddressScheme: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocationAddressScheme>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationAddressScheme) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationAddressScheme)));
            
        }
        
        /// <summary>
        /// Add new audit for a locationAddressScheme Adds an audit to an existing locationAddressScheme.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to add an audit to</param> 
        /// <param name="locationAddressSchemeAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddLocationAddressSchemeAudit (int? locationAddressSchemeId, string locationAddressSchemeAudit)
        {
             AddLocationAddressSchemeAuditWithHttpInfo(locationAddressSchemeId, locationAddressSchemeAudit);
        }

        /// <summary>
        /// Add new audit for a locationAddressScheme Adds an audit to an existing locationAddressScheme.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to add an audit to</param> 
        /// <param name="locationAddressSchemeAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddLocationAddressSchemeAuditWithHttpInfo (int? locationAddressSchemeId, string locationAddressSchemeAudit)
        {
            
            // verify the required parameter 'locationAddressSchemeId' is set
            if (locationAddressSchemeId == null)
                throw new ApiException(400, "Missing required parameter 'locationAddressSchemeId' when calling LocationAddressSchemeApi->AddLocationAddressSchemeAudit");
            
            // verify the required parameter 'locationAddressSchemeAudit' is set
            if (locationAddressSchemeAudit == null)
                throw new ApiException(400, "Missing required parameter 'locationAddressSchemeAudit' when calling LocationAddressSchemeApi->AddLocationAddressSchemeAudit");
            
    
            var localVarPath = "/beta/locationAddressScheme/{locationAddressSchemeId}/audit/{locationAddressSchemeAudit}";
    
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
            if (locationAddressSchemeId != null) localVarPathParams.Add("locationAddressSchemeId", Configuration.ApiClient.ParameterToString(locationAddressSchemeId)); // path parameter
            if (locationAddressSchemeAudit != null) localVarPathParams.Add("locationAddressSchemeAudit", Configuration.ApiClient.ParameterToString(locationAddressSchemeAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationAddressSchemeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationAddressSchemeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a locationAddressScheme Adds an audit to an existing locationAddressScheme.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to add an audit to</param>
        /// <param name="locationAddressSchemeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddLocationAddressSchemeAuditAsync (int? locationAddressSchemeId, string locationAddressSchemeAudit)
        {
             await AddLocationAddressSchemeAuditAsyncWithHttpInfo(locationAddressSchemeId, locationAddressSchemeAudit);

        }

        /// <summary>
        /// Add new audit for a locationAddressScheme Adds an audit to an existing locationAddressScheme.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to add an audit to</param>
        /// <param name="locationAddressSchemeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddLocationAddressSchemeAuditAsyncWithHttpInfo (int? locationAddressSchemeId, string locationAddressSchemeAudit)
        {
            // verify the required parameter 'locationAddressSchemeId' is set
            if (locationAddressSchemeId == null) throw new ApiException(400, "Missing required parameter 'locationAddressSchemeId' when calling AddLocationAddressSchemeAudit");
            // verify the required parameter 'locationAddressSchemeAudit' is set
            if (locationAddressSchemeAudit == null) throw new ApiException(400, "Missing required parameter 'locationAddressSchemeAudit' when calling AddLocationAddressSchemeAudit");
            
    
            var localVarPath = "/beta/locationAddressScheme/{locationAddressSchemeId}/audit/{locationAddressSchemeAudit}";
    
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
            if (locationAddressSchemeId != null) localVarPathParams.Add("locationAddressSchemeId", Configuration.ApiClient.ParameterToString(locationAddressSchemeId)); // path parameter
            if (locationAddressSchemeAudit != null) localVarPathParams.Add("locationAddressSchemeAudit", Configuration.ApiClient.ParameterToString(locationAddressSchemeAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationAddressSchemeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationAddressSchemeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a locationAddressScheme. Adds a tag to an existing locationAddressScheme.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to add a tag to</param> 
        /// <param name="locationAddressSchemeTag">The tag to add</param> 
        /// <returns></returns>
        public void AddLocationAddressSchemeTag (int? locationAddressSchemeId, string locationAddressSchemeTag)
        {
             AddLocationAddressSchemeTagWithHttpInfo(locationAddressSchemeId, locationAddressSchemeTag);
        }

        /// <summary>
        /// Add new tags for a locationAddressScheme. Adds a tag to an existing locationAddressScheme.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to add a tag to</param> 
        /// <param name="locationAddressSchemeTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddLocationAddressSchemeTagWithHttpInfo (int? locationAddressSchemeId, string locationAddressSchemeTag)
        {
            
            // verify the required parameter 'locationAddressSchemeId' is set
            if (locationAddressSchemeId == null)
                throw new ApiException(400, "Missing required parameter 'locationAddressSchemeId' when calling LocationAddressSchemeApi->AddLocationAddressSchemeTag");
            
            // verify the required parameter 'locationAddressSchemeTag' is set
            if (locationAddressSchemeTag == null)
                throw new ApiException(400, "Missing required parameter 'locationAddressSchemeTag' when calling LocationAddressSchemeApi->AddLocationAddressSchemeTag");
            
    
            var localVarPath = "/beta/locationAddressScheme/{locationAddressSchemeId}/tag/{locationAddressSchemeTag}";
    
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
            if (locationAddressSchemeId != null) localVarPathParams.Add("locationAddressSchemeId", Configuration.ApiClient.ParameterToString(locationAddressSchemeId)); // path parameter
            if (locationAddressSchemeTag != null) localVarPathParams.Add("locationAddressSchemeTag", Configuration.ApiClient.ParameterToString(locationAddressSchemeTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationAddressSchemeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationAddressSchemeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a locationAddressScheme. Adds a tag to an existing locationAddressScheme.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to add a tag to</param>
        /// <param name="locationAddressSchemeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddLocationAddressSchemeTagAsync (int? locationAddressSchemeId, string locationAddressSchemeTag)
        {
             await AddLocationAddressSchemeTagAsyncWithHttpInfo(locationAddressSchemeId, locationAddressSchemeTag);

        }

        /// <summary>
        /// Add new tags for a locationAddressScheme. Adds a tag to an existing locationAddressScheme.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to add a tag to</param>
        /// <param name="locationAddressSchemeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddLocationAddressSchemeTagAsyncWithHttpInfo (int? locationAddressSchemeId, string locationAddressSchemeTag)
        {
            // verify the required parameter 'locationAddressSchemeId' is set
            if (locationAddressSchemeId == null) throw new ApiException(400, "Missing required parameter 'locationAddressSchemeId' when calling AddLocationAddressSchemeTag");
            // verify the required parameter 'locationAddressSchemeTag' is set
            if (locationAddressSchemeTag == null) throw new ApiException(400, "Missing required parameter 'locationAddressSchemeTag' when calling AddLocationAddressSchemeTag");
            
    
            var localVarPath = "/beta/locationAddressScheme/{locationAddressSchemeId}/tag/{locationAddressSchemeTag}";
    
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
            if (locationAddressSchemeId != null) localVarPathParams.Add("locationAddressSchemeId", Configuration.ApiClient.ParameterToString(locationAddressSchemeId)); // path parameter
            if (locationAddressSchemeTag != null) localVarPathParams.Add("locationAddressSchemeTag", Configuration.ApiClient.ParameterToString(locationAddressSchemeTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddLocationAddressSchemeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddLocationAddressSchemeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a locationAddressScheme Deletes the locationAddressScheme identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be deleted.</param> 
        /// <returns></returns>
        public void DeleteLocationAddressScheme (int? locationAddressSchemeId)
        {
             DeleteLocationAddressSchemeWithHttpInfo(locationAddressSchemeId);
        }

        /// <summary>
        /// Delete a locationAddressScheme Deletes the locationAddressScheme identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLocationAddressSchemeWithHttpInfo (int? locationAddressSchemeId)
        {
            
            // verify the required parameter 'locationAddressSchemeId' is set
            if (locationAddressSchemeId == null)
                throw new ApiException(400, "Missing required parameter 'locationAddressSchemeId' when calling LocationAddressSchemeApi->DeleteLocationAddressScheme");
            
    
            var localVarPath = "/beta/locationAddressScheme/{locationAddressSchemeId}";
    
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
            if (locationAddressSchemeId != null) localVarPathParams.Add("locationAddressSchemeId", Configuration.ApiClient.ParameterToString(locationAddressSchemeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationAddressScheme: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationAddressScheme: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a locationAddressScheme Deletes the locationAddressScheme identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLocationAddressSchemeAsync (int? locationAddressSchemeId)
        {
             await DeleteLocationAddressSchemeAsyncWithHttpInfo(locationAddressSchemeId);

        }

        /// <summary>
        /// Delete a locationAddressScheme Deletes the locationAddressScheme identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLocationAddressSchemeAsyncWithHttpInfo (int? locationAddressSchemeId)
        {
            // verify the required parameter 'locationAddressSchemeId' is set
            if (locationAddressSchemeId == null) throw new ApiException(400, "Missing required parameter 'locationAddressSchemeId' when calling DeleteLocationAddressScheme");
            
    
            var localVarPath = "/beta/locationAddressScheme/{locationAddressSchemeId}";
    
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
            if (locationAddressSchemeId != null) localVarPathParams.Add("locationAddressSchemeId", Configuration.ApiClient.ParameterToString(locationAddressSchemeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationAddressScheme: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationAddressScheme: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a locationAddressScheme. Deletes an existing locationAddressScheme tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to remove tag from</param> 
        /// <param name="locationAddressSchemeTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteLocationAddressSchemeTag (int? locationAddressSchemeId, string locationAddressSchemeTag)
        {
             DeleteLocationAddressSchemeTagWithHttpInfo(locationAddressSchemeId, locationAddressSchemeTag);
        }

        /// <summary>
        /// Delete a tag for a locationAddressScheme. Deletes an existing locationAddressScheme tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to remove tag from</param> 
        /// <param name="locationAddressSchemeTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLocationAddressSchemeTagWithHttpInfo (int? locationAddressSchemeId, string locationAddressSchemeTag)
        {
            
            // verify the required parameter 'locationAddressSchemeId' is set
            if (locationAddressSchemeId == null)
                throw new ApiException(400, "Missing required parameter 'locationAddressSchemeId' when calling LocationAddressSchemeApi->DeleteLocationAddressSchemeTag");
            
            // verify the required parameter 'locationAddressSchemeTag' is set
            if (locationAddressSchemeTag == null)
                throw new ApiException(400, "Missing required parameter 'locationAddressSchemeTag' when calling LocationAddressSchemeApi->DeleteLocationAddressSchemeTag");
            
    
            var localVarPath = "/beta/locationAddressScheme/{locationAddressSchemeId}/tag/{locationAddressSchemeTag}";
    
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
            if (locationAddressSchemeId != null) localVarPathParams.Add("locationAddressSchemeId", Configuration.ApiClient.ParameterToString(locationAddressSchemeId)); // path parameter
            if (locationAddressSchemeTag != null) localVarPathParams.Add("locationAddressSchemeTag", Configuration.ApiClient.ParameterToString(locationAddressSchemeTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationAddressSchemeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationAddressSchemeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a locationAddressScheme. Deletes an existing locationAddressScheme tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to remove tag from</param>
        /// <param name="locationAddressSchemeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLocationAddressSchemeTagAsync (int? locationAddressSchemeId, string locationAddressSchemeTag)
        {
             await DeleteLocationAddressSchemeTagAsyncWithHttpInfo(locationAddressSchemeId, locationAddressSchemeTag);

        }

        /// <summary>
        /// Delete a tag for a locationAddressScheme. Deletes an existing locationAddressScheme tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to remove tag from</param>
        /// <param name="locationAddressSchemeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLocationAddressSchemeTagAsyncWithHttpInfo (int? locationAddressSchemeId, string locationAddressSchemeTag)
        {
            // verify the required parameter 'locationAddressSchemeId' is set
            if (locationAddressSchemeId == null) throw new ApiException(400, "Missing required parameter 'locationAddressSchemeId' when calling DeleteLocationAddressSchemeTag");
            // verify the required parameter 'locationAddressSchemeTag' is set
            if (locationAddressSchemeTag == null) throw new ApiException(400, "Missing required parameter 'locationAddressSchemeTag' when calling DeleteLocationAddressSchemeTag");
            
    
            var localVarPath = "/beta/locationAddressScheme/{locationAddressSchemeId}/tag/{locationAddressSchemeTag}";
    
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
            if (locationAddressSchemeId != null) localVarPathParams.Add("locationAddressSchemeId", Configuration.ApiClient.ParameterToString(locationAddressSchemeId)); // path parameter
            if (locationAddressSchemeTag != null) localVarPathParams.Add("locationAddressSchemeTag", Configuration.ApiClient.ParameterToString(locationAddressSchemeTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationAddressSchemeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLocationAddressSchemeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a locationAddressScheme by id Returns a duplicated locationAddressScheme identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be duplicated.</param> 
        /// <returns>LocationAddressScheme</returns>
        public LocationAddressScheme GetDuplicateLocationAddressSchemeById (int? locationAddressSchemeId)
        {
             ApiResponse<LocationAddressScheme> localVarResponse = GetDuplicateLocationAddressSchemeByIdWithHttpInfo(locationAddressSchemeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a locationAddressScheme by id Returns a duplicated locationAddressScheme identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be duplicated.</param> 
        /// <returns>ApiResponse of LocationAddressScheme</returns>
        public ApiResponse< LocationAddressScheme > GetDuplicateLocationAddressSchemeByIdWithHttpInfo (int? locationAddressSchemeId)
        {
            
            // verify the required parameter 'locationAddressSchemeId' is set
            if (locationAddressSchemeId == null)
                throw new ApiException(400, "Missing required parameter 'locationAddressSchemeId' when calling LocationAddressSchemeApi->GetDuplicateLocationAddressSchemeById");
            
    
            var localVarPath = "/beta/locationAddressScheme/duplicate/{locationAddressSchemeId}";
    
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
            if (locationAddressSchemeId != null) localVarPathParams.Add("locationAddressSchemeId", Configuration.ApiClient.ParameterToString(locationAddressSchemeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLocationAddressSchemeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLocationAddressSchemeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LocationAddressScheme>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationAddressScheme) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationAddressScheme)));
            
        }

        
        /// <summary>
        /// Get a duplicated a locationAddressScheme by id Returns a duplicated locationAddressScheme identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be duplicated.</param>
        /// <returns>Task of LocationAddressScheme</returns>
        public async System.Threading.Tasks.Task<LocationAddressScheme> GetDuplicateLocationAddressSchemeByIdAsync (int? locationAddressSchemeId)
        {
             ApiResponse<LocationAddressScheme> localVarResponse = await GetDuplicateLocationAddressSchemeByIdAsyncWithHttpInfo(locationAddressSchemeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a locationAddressScheme by id Returns a duplicated locationAddressScheme identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be duplicated.</param>
        /// <returns>Task of ApiResponse (LocationAddressScheme)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocationAddressScheme>> GetDuplicateLocationAddressSchemeByIdAsyncWithHttpInfo (int? locationAddressSchemeId)
        {
            // verify the required parameter 'locationAddressSchemeId' is set
            if (locationAddressSchemeId == null) throw new ApiException(400, "Missing required parameter 'locationAddressSchemeId' when calling GetDuplicateLocationAddressSchemeById");
            
    
            var localVarPath = "/beta/locationAddressScheme/duplicate/{locationAddressSchemeId}";
    
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
            if (locationAddressSchemeId != null) localVarPathParams.Add("locationAddressSchemeId", Configuration.ApiClient.ParameterToString(locationAddressSchemeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLocationAddressSchemeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateLocationAddressSchemeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocationAddressScheme>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationAddressScheme) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationAddressScheme)));
            
        }
        
        /// <summary>
        /// Search locationAddressSchemes by filter Returns the list of locationAddressSchemes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;LocationAddressScheme&gt;</returns>
        public List<LocationAddressScheme> GetLocationAddressSchemeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<LocationAddressScheme>> localVarResponse = GetLocationAddressSchemeByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search locationAddressSchemes by filter Returns the list of locationAddressSchemes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;LocationAddressScheme&gt;</returns>
        public ApiResponse< List<LocationAddressScheme> > GetLocationAddressSchemeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/locationAddressScheme/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationAddressSchemeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationAddressSchemeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<LocationAddressScheme>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LocationAddressScheme>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LocationAddressScheme>)));
            
        }

        
        /// <summary>
        /// Search locationAddressSchemes by filter Returns the list of locationAddressSchemes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;LocationAddressScheme&gt;</returns>
        public async System.Threading.Tasks.Task<List<LocationAddressScheme>> GetLocationAddressSchemeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<LocationAddressScheme>> localVarResponse = await GetLocationAddressSchemeByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search locationAddressSchemes by filter Returns the list of locationAddressSchemes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LocationAddressScheme&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LocationAddressScheme>>> GetLocationAddressSchemeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/locationAddressScheme/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationAddressSchemeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationAddressSchemeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<LocationAddressScheme>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LocationAddressScheme>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LocationAddressScheme>)));
            
        }
        
        /// <summary>
        /// Get a locationAddressScheme by id Returns the locationAddressScheme identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be returned.</param> 
        /// <returns>LocationAddressScheme</returns>
        public LocationAddressScheme GetLocationAddressSchemeById (int? locationAddressSchemeId)
        {
             ApiResponse<LocationAddressScheme> localVarResponse = GetLocationAddressSchemeByIdWithHttpInfo(locationAddressSchemeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a locationAddressScheme by id Returns the locationAddressScheme identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be returned.</param> 
        /// <returns>ApiResponse of LocationAddressScheme</returns>
        public ApiResponse< LocationAddressScheme > GetLocationAddressSchemeByIdWithHttpInfo (int? locationAddressSchemeId)
        {
            
            // verify the required parameter 'locationAddressSchemeId' is set
            if (locationAddressSchemeId == null)
                throw new ApiException(400, "Missing required parameter 'locationAddressSchemeId' when calling LocationAddressSchemeApi->GetLocationAddressSchemeById");
            
    
            var localVarPath = "/beta/locationAddressScheme/{locationAddressSchemeId}";
    
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
            if (locationAddressSchemeId != null) localVarPathParams.Add("locationAddressSchemeId", Configuration.ApiClient.ParameterToString(locationAddressSchemeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationAddressSchemeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationAddressSchemeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LocationAddressScheme>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationAddressScheme) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationAddressScheme)));
            
        }

        
        /// <summary>
        /// Get a locationAddressScheme by id Returns the locationAddressScheme identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be returned.</param>
        /// <returns>Task of LocationAddressScheme</returns>
        public async System.Threading.Tasks.Task<LocationAddressScheme> GetLocationAddressSchemeByIdAsync (int? locationAddressSchemeId)
        {
             ApiResponse<LocationAddressScheme> localVarResponse = await GetLocationAddressSchemeByIdAsyncWithHttpInfo(locationAddressSchemeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a locationAddressScheme by id Returns the locationAddressScheme identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to be returned.</param>
        /// <returns>Task of ApiResponse (LocationAddressScheme)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocationAddressScheme>> GetLocationAddressSchemeByIdAsyncWithHttpInfo (int? locationAddressSchemeId)
        {
            // verify the required parameter 'locationAddressSchemeId' is set
            if (locationAddressSchemeId == null) throw new ApiException(400, "Missing required parameter 'locationAddressSchemeId' when calling GetLocationAddressSchemeById");
            
    
            var localVarPath = "/beta/locationAddressScheme/{locationAddressSchemeId}";
    
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
            if (locationAddressSchemeId != null) localVarPathParams.Add("locationAddressSchemeId", Configuration.ApiClient.ParameterToString(locationAddressSchemeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationAddressSchemeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationAddressSchemeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocationAddressScheme>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocationAddressScheme) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocationAddressScheme)));
            
        }
        
        /// <summary>
        /// Get the tags for a locationAddressScheme. Get all existing locationAddressScheme tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to get tags for</param> 
        /// <returns></returns>
        public void GetLocationAddressSchemeTags (int? locationAddressSchemeId)
        {
             GetLocationAddressSchemeTagsWithHttpInfo(locationAddressSchemeId);
        }

        /// <summary>
        /// Get the tags for a locationAddressScheme. Get all existing locationAddressScheme tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetLocationAddressSchemeTagsWithHttpInfo (int? locationAddressSchemeId)
        {
            
            // verify the required parameter 'locationAddressSchemeId' is set
            if (locationAddressSchemeId == null)
                throw new ApiException(400, "Missing required parameter 'locationAddressSchemeId' when calling LocationAddressSchemeApi->GetLocationAddressSchemeTags");
            
    
            var localVarPath = "/beta/locationAddressScheme/{locationAddressSchemeId}/tag";
    
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
            if (locationAddressSchemeId != null) localVarPathParams.Add("locationAddressSchemeId", Configuration.ApiClient.ParameterToString(locationAddressSchemeId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationAddressSchemeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationAddressSchemeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a locationAddressScheme. Get all existing locationAddressScheme tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetLocationAddressSchemeTagsAsync (int? locationAddressSchemeId)
        {
             await GetLocationAddressSchemeTagsAsyncWithHttpInfo(locationAddressSchemeId);

        }

        /// <summary>
        /// Get the tags for a locationAddressScheme. Get all existing locationAddressScheme tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationAddressSchemeId">Id of the locationAddressScheme to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetLocationAddressSchemeTagsAsyncWithHttpInfo (int? locationAddressSchemeId)
        {
            // verify the required parameter 'locationAddressSchemeId' is set
            if (locationAddressSchemeId == null) throw new ApiException(400, "Missing required parameter 'locationAddressSchemeId' when calling GetLocationAddressSchemeTags");
            
    
            var localVarPath = "/beta/locationAddressScheme/{locationAddressSchemeId}/tag";
    
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
            if (locationAddressSchemeId != null) localVarPathParams.Add("locationAddressSchemeId", Configuration.ApiClient.ParameterToString(locationAddressSchemeId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetLocationAddressSchemeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocationAddressSchemeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a locationAddressScheme Updates an existing locationAddressScheme using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be updated.</param> 
        /// <returns></returns>
        public void UpdateLocationAddressScheme (LocationAddressScheme body)
        {
             UpdateLocationAddressSchemeWithHttpInfo(body);
        }

        /// <summary>
        /// Update a locationAddressScheme Updates an existing locationAddressScheme using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateLocationAddressSchemeWithHttpInfo (LocationAddressScheme body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LocationAddressSchemeApi->UpdateLocationAddressScheme");
            
    
            var localVarPath = "/beta/locationAddressScheme";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationAddressScheme: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationAddressScheme: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a locationAddressScheme Updates an existing locationAddressScheme using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateLocationAddressSchemeAsync (LocationAddressScheme body)
        {
             await UpdateLocationAddressSchemeAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a locationAddressScheme Updates an existing locationAddressScheme using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLocationAddressSchemeAsyncWithHttpInfo (LocationAddressScheme body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateLocationAddressScheme");
            
    
            var localVarPath = "/beta/locationAddressScheme";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationAddressScheme: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationAddressScheme: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a locationAddressScheme custom fields Updates an existing locationAddressScheme custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be updated.</param> 
        /// <returns></returns>
        public void UpdateLocationAddressSchemeCustomFields (LocationAddressScheme body)
        {
             UpdateLocationAddressSchemeCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a locationAddressScheme custom fields Updates an existing locationAddressScheme custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateLocationAddressSchemeCustomFieldsWithHttpInfo (LocationAddressScheme body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling LocationAddressSchemeApi->UpdateLocationAddressSchemeCustomFields");
            
    
            var localVarPath = "/beta/locationAddressScheme/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationAddressSchemeCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationAddressSchemeCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a locationAddressScheme custom fields Updates an existing locationAddressScheme custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateLocationAddressSchemeCustomFieldsAsync (LocationAddressScheme body)
        {
             await UpdateLocationAddressSchemeCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a locationAddressScheme custom fields Updates an existing locationAddressScheme custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">LocationAddressScheme to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLocationAddressSchemeCustomFieldsAsyncWithHttpInfo (LocationAddressScheme body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateLocationAddressSchemeCustomFields");
            
    
            var localVarPath = "/beta/locationAddressScheme/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationAddressSchemeCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLocationAddressSchemeCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
