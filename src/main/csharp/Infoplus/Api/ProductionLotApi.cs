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
    public interface IProductionLotApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a productionLot
        /// </summary>
        /// <remarks>
        /// Inserts a new productionLot using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be inserted.</param>
        /// <returns>ProductionLot</returns>
        ProductionLot AddProductionLot (ProductionLot body);
  
        /// <summary>
        /// Create a productionLot
        /// </summary>
        /// <remarks>
        /// Inserts a new productionLot using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be inserted.</param>
        /// <returns>ApiResponse of ProductionLot</returns>
        ApiResponse<ProductionLot> AddProductionLotWithHttpInfo (ProductionLot body);
        
        /// <summary>
        /// Add new audit for a productionLot
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing productionLot.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to add an audit to</param>
        /// <param name="productionLotAudit">The audit to add</param>
        /// <returns></returns>
        void AddProductionLotAudit (int? productionLotId, string productionLotAudit);
  
        /// <summary>
        /// Add new audit for a productionLot
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing productionLot.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to add an audit to</param>
        /// <param name="productionLotAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddProductionLotAuditWithHttpInfo (int? productionLotId, string productionLotAudit);
        
        /// <summary>
        /// Add new tags for a productionLot.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing productionLot.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to add a tag to</param>
        /// <param name="productionLotTag">The tag to add</param>
        /// <returns></returns>
        void AddProductionLotTag (int? productionLotId, string productionLotTag);
  
        /// <summary>
        /// Add new tags for a productionLot.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing productionLot.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to add a tag to</param>
        /// <param name="productionLotTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddProductionLotTagWithHttpInfo (int? productionLotId, string productionLotTag);
        
        /// <summary>
        /// Delete a productionLot
        /// </summary>
        /// <remarks>
        /// Deletes the productionLot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be deleted.</param>
        /// <returns></returns>
        void DeleteProductionLot (int? productionLotId);
  
        /// <summary>
        /// Delete a productionLot
        /// </summary>
        /// <remarks>
        /// Deletes the productionLot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteProductionLotWithHttpInfo (int? productionLotId);
        
        /// <summary>
        /// Delete a tag for a productionLot.
        /// </summary>
        /// <remarks>
        /// Deletes an existing productionLot tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to remove tag from</param>
        /// <param name="productionLotTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteProductionLotTag (int? productionLotId, string productionLotTag);
  
        /// <summary>
        /// Delete a tag for a productionLot.
        /// </summary>
        /// <remarks>
        /// Deletes an existing productionLot tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to remove tag from</param>
        /// <param name="productionLotTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteProductionLotTagWithHttpInfo (int? productionLotId, string productionLotTag);
        
        /// <summary>
        /// Get a duplicated a productionLot by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated productionLot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be duplicated.</param>
        /// <returns>ProductionLot</returns>
        ProductionLot GetDuplicateProductionLotById (int? productionLotId);
  
        /// <summary>
        /// Get a duplicated a productionLot by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated productionLot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be duplicated.</param>
        /// <returns>ApiResponse of ProductionLot</returns>
        ApiResponse<ProductionLot> GetDuplicateProductionLotByIdWithHttpInfo (int? productionLotId);
        
        /// <summary>
        /// Search productionLots by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of productionLots that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ProductionLot&gt;</returns>
        List<ProductionLot> GetProductionLotByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search productionLots by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of productionLots that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ProductionLot&gt;</returns>
        ApiResponse<List<ProductionLot>> GetProductionLotByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a productionLot by id
        /// </summary>
        /// <remarks>
        /// Returns the productionLot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be returned.</param>
        /// <returns>ProductionLot</returns>
        ProductionLot GetProductionLotById (int? productionLotId);
  
        /// <summary>
        /// Get a productionLot by id
        /// </summary>
        /// <remarks>
        /// Returns the productionLot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be returned.</param>
        /// <returns>ApiResponse of ProductionLot</returns>
        ApiResponse<ProductionLot> GetProductionLotByIdWithHttpInfo (int? productionLotId);
        
        /// <summary>
        /// Get the tags for a productionLot.
        /// </summary>
        /// <remarks>
        /// Get all existing productionLot tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to get tags for</param>
        /// <returns></returns>
        void GetProductionLotTags (int? productionLotId);
  
        /// <summary>
        /// Get the tags for a productionLot.
        /// </summary>
        /// <remarks>
        /// Get all existing productionLot tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetProductionLotTagsWithHttpInfo (int? productionLotId);
        
        /// <summary>
        /// Update a productionLot
        /// </summary>
        /// <remarks>
        /// Updates an existing productionLot using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be updated.</param>
        /// <returns></returns>
        void UpdateProductionLot (ProductionLot body);
  
        /// <summary>
        /// Update a productionLot
        /// </summary>
        /// <remarks>
        /// Updates an existing productionLot using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateProductionLotWithHttpInfo (ProductionLot body);
        
        /// <summary>
        /// Update a productionLot custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing productionLot custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be updated.</param>
        /// <returns></returns>
        void UpdateProductionLotCustomFields (ProductionLot body);
  
        /// <summary>
        /// Update a productionLot custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing productionLot custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateProductionLotCustomFieldsWithHttpInfo (ProductionLot body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a productionLot
        /// </summary>
        /// <remarks>
        /// Inserts a new productionLot using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be inserted.</param>
        /// <returns>Task of ProductionLot</returns>
        System.Threading.Tasks.Task<ProductionLot> AddProductionLotAsync (ProductionLot body);

        /// <summary>
        /// Create a productionLot
        /// </summary>
        /// <remarks>
        /// Inserts a new productionLot using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be inserted.</param>
        /// <returns>Task of ApiResponse (ProductionLot)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionLot>> AddProductionLotAsyncWithHttpInfo (ProductionLot body);
        
        /// <summary>
        /// Add new audit for a productionLot
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing productionLot.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to add an audit to</param>
        /// <param name="productionLotAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddProductionLotAuditAsync (int? productionLotId, string productionLotAudit);

        /// <summary>
        /// Add new audit for a productionLot
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing productionLot.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to add an audit to</param>
        /// <param name="productionLotAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddProductionLotAuditAsyncWithHttpInfo (int? productionLotId, string productionLotAudit);
        
        /// <summary>
        /// Add new tags for a productionLot.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing productionLot.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to add a tag to</param>
        /// <param name="productionLotTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddProductionLotTagAsync (int? productionLotId, string productionLotTag);

        /// <summary>
        /// Add new tags for a productionLot.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing productionLot.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to add a tag to</param>
        /// <param name="productionLotTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddProductionLotTagAsyncWithHttpInfo (int? productionLotId, string productionLotTag);
        
        /// <summary>
        /// Delete a productionLot
        /// </summary>
        /// <remarks>
        /// Deletes the productionLot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteProductionLotAsync (int? productionLotId);

        /// <summary>
        /// Delete a productionLot
        /// </summary>
        /// <remarks>
        /// Deletes the productionLot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteProductionLotAsyncWithHttpInfo (int? productionLotId);
        
        /// <summary>
        /// Delete a tag for a productionLot.
        /// </summary>
        /// <remarks>
        /// Deletes an existing productionLot tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to remove tag from</param>
        /// <param name="productionLotTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteProductionLotTagAsync (int? productionLotId, string productionLotTag);

        /// <summary>
        /// Delete a tag for a productionLot.
        /// </summary>
        /// <remarks>
        /// Deletes an existing productionLot tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to remove tag from</param>
        /// <param name="productionLotTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteProductionLotTagAsyncWithHttpInfo (int? productionLotId, string productionLotTag);
        
        /// <summary>
        /// Get a duplicated a productionLot by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated productionLot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be duplicated.</param>
        /// <returns>Task of ProductionLot</returns>
        System.Threading.Tasks.Task<ProductionLot> GetDuplicateProductionLotByIdAsync (int? productionLotId);

        /// <summary>
        /// Get a duplicated a productionLot by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated productionLot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be duplicated.</param>
        /// <returns>Task of ApiResponse (ProductionLot)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionLot>> GetDuplicateProductionLotByIdAsyncWithHttpInfo (int? productionLotId);
        
        /// <summary>
        /// Search productionLots by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of productionLots that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ProductionLot&gt;</returns>
        System.Threading.Tasks.Task<List<ProductionLot>> GetProductionLotByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search productionLots by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of productionLots that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ProductionLot&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ProductionLot>>> GetProductionLotByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a productionLot by id
        /// </summary>
        /// <remarks>
        /// Returns the productionLot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be returned.</param>
        /// <returns>Task of ProductionLot</returns>
        System.Threading.Tasks.Task<ProductionLot> GetProductionLotByIdAsync (int? productionLotId);

        /// <summary>
        /// Get a productionLot by id
        /// </summary>
        /// <remarks>
        /// Returns the productionLot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be returned.</param>
        /// <returns>Task of ApiResponse (ProductionLot)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductionLot>> GetProductionLotByIdAsyncWithHttpInfo (int? productionLotId);
        
        /// <summary>
        /// Get the tags for a productionLot.
        /// </summary>
        /// <remarks>
        /// Get all existing productionLot tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetProductionLotTagsAsync (int? productionLotId);

        /// <summary>
        /// Get the tags for a productionLot.
        /// </summary>
        /// <remarks>
        /// Get all existing productionLot tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetProductionLotTagsAsyncWithHttpInfo (int? productionLotId);
        
        /// <summary>
        /// Update a productionLot
        /// </summary>
        /// <remarks>
        /// Updates an existing productionLot using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateProductionLotAsync (ProductionLot body);

        /// <summary>
        /// Update a productionLot
        /// </summary>
        /// <remarks>
        /// Updates an existing productionLot using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateProductionLotAsyncWithHttpInfo (ProductionLot body);
        
        /// <summary>
        /// Update a productionLot custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing productionLot custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateProductionLotCustomFieldsAsync (ProductionLot body);

        /// <summary>
        /// Update a productionLot custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing productionLot custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateProductionLotCustomFieldsAsyncWithHttpInfo (ProductionLot body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProductionLotApi : IProductionLotApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionLotApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductionLotApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductionLotApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductionLotApi(Configuration configuration = null)
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
        /// Create a productionLot Inserts a new productionLot using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be inserted.</param> 
        /// <returns>ProductionLot</returns>
        public ProductionLot AddProductionLot (ProductionLot body)
        {
             ApiResponse<ProductionLot> localVarResponse = AddProductionLotWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a productionLot Inserts a new productionLot using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be inserted.</param> 
        /// <returns>ApiResponse of ProductionLot</returns>
        public ApiResponse< ProductionLot > AddProductionLotWithHttpInfo (ProductionLot body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductionLotApi->AddProductionLot");
            
    
            var localVarPath = "/beta/productionLot";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddProductionLot: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddProductionLot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ProductionLot>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProductionLot) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductionLot)));
            
        }

        
        /// <summary>
        /// Create a productionLot Inserts a new productionLot using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be inserted.</param>
        /// <returns>Task of ProductionLot</returns>
        public async System.Threading.Tasks.Task<ProductionLot> AddProductionLotAsync (ProductionLot body)
        {
             ApiResponse<ProductionLot> localVarResponse = await AddProductionLotAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a productionLot Inserts a new productionLot using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be inserted.</param>
        /// <returns>Task of ApiResponse (ProductionLot)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionLot>> AddProductionLotAsyncWithHttpInfo (ProductionLot body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddProductionLot");
            
    
            var localVarPath = "/beta/productionLot";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddProductionLot: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddProductionLot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProductionLot>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProductionLot) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductionLot)));
            
        }
        
        /// <summary>
        /// Add new audit for a productionLot Adds an audit to an existing productionLot.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to add an audit to</param> 
        /// <param name="productionLotAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddProductionLotAudit (int? productionLotId, string productionLotAudit)
        {
             AddProductionLotAuditWithHttpInfo(productionLotId, productionLotAudit);
        }

        /// <summary>
        /// Add new audit for a productionLot Adds an audit to an existing productionLot.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to add an audit to</param> 
        /// <param name="productionLotAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddProductionLotAuditWithHttpInfo (int? productionLotId, string productionLotAudit)
        {
            
            // verify the required parameter 'productionLotId' is set
            if (productionLotId == null)
                throw new ApiException(400, "Missing required parameter 'productionLotId' when calling ProductionLotApi->AddProductionLotAudit");
            
            // verify the required parameter 'productionLotAudit' is set
            if (productionLotAudit == null)
                throw new ApiException(400, "Missing required parameter 'productionLotAudit' when calling ProductionLotApi->AddProductionLotAudit");
            
    
            var localVarPath = "/beta/productionLot/{productionLotId}/audit/{productionLotAudit}";
    
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
            if (productionLotId != null) localVarPathParams.Add("productionLotId", Configuration.ApiClient.ParameterToString(productionLotId)); // path parameter
            if (productionLotAudit != null) localVarPathParams.Add("productionLotAudit", Configuration.ApiClient.ParameterToString(productionLotAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddProductionLotAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddProductionLotAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a productionLot Adds an audit to an existing productionLot.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to add an audit to</param>
        /// <param name="productionLotAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddProductionLotAuditAsync (int? productionLotId, string productionLotAudit)
        {
             await AddProductionLotAuditAsyncWithHttpInfo(productionLotId, productionLotAudit);

        }

        /// <summary>
        /// Add new audit for a productionLot Adds an audit to an existing productionLot.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to add an audit to</param>
        /// <param name="productionLotAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddProductionLotAuditAsyncWithHttpInfo (int? productionLotId, string productionLotAudit)
        {
            // verify the required parameter 'productionLotId' is set
            if (productionLotId == null) throw new ApiException(400, "Missing required parameter 'productionLotId' when calling AddProductionLotAudit");
            // verify the required parameter 'productionLotAudit' is set
            if (productionLotAudit == null) throw new ApiException(400, "Missing required parameter 'productionLotAudit' when calling AddProductionLotAudit");
            
    
            var localVarPath = "/beta/productionLot/{productionLotId}/audit/{productionLotAudit}";
    
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
            if (productionLotId != null) localVarPathParams.Add("productionLotId", Configuration.ApiClient.ParameterToString(productionLotId)); // path parameter
            if (productionLotAudit != null) localVarPathParams.Add("productionLotAudit", Configuration.ApiClient.ParameterToString(productionLotAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddProductionLotAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddProductionLotAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a productionLot. Adds a tag to an existing productionLot.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to add a tag to</param> 
        /// <param name="productionLotTag">The tag to add</param> 
        /// <returns></returns>
        public void AddProductionLotTag (int? productionLotId, string productionLotTag)
        {
             AddProductionLotTagWithHttpInfo(productionLotId, productionLotTag);
        }

        /// <summary>
        /// Add new tags for a productionLot. Adds a tag to an existing productionLot.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to add a tag to</param> 
        /// <param name="productionLotTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddProductionLotTagWithHttpInfo (int? productionLotId, string productionLotTag)
        {
            
            // verify the required parameter 'productionLotId' is set
            if (productionLotId == null)
                throw new ApiException(400, "Missing required parameter 'productionLotId' when calling ProductionLotApi->AddProductionLotTag");
            
            // verify the required parameter 'productionLotTag' is set
            if (productionLotTag == null)
                throw new ApiException(400, "Missing required parameter 'productionLotTag' when calling ProductionLotApi->AddProductionLotTag");
            
    
            var localVarPath = "/beta/productionLot/{productionLotId}/tag/{productionLotTag}";
    
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
            if (productionLotId != null) localVarPathParams.Add("productionLotId", Configuration.ApiClient.ParameterToString(productionLotId)); // path parameter
            if (productionLotTag != null) localVarPathParams.Add("productionLotTag", Configuration.ApiClient.ParameterToString(productionLotTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddProductionLotTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddProductionLotTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a productionLot. Adds a tag to an existing productionLot.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to add a tag to</param>
        /// <param name="productionLotTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddProductionLotTagAsync (int? productionLotId, string productionLotTag)
        {
             await AddProductionLotTagAsyncWithHttpInfo(productionLotId, productionLotTag);

        }

        /// <summary>
        /// Add new tags for a productionLot. Adds a tag to an existing productionLot.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to add a tag to</param>
        /// <param name="productionLotTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddProductionLotTagAsyncWithHttpInfo (int? productionLotId, string productionLotTag)
        {
            // verify the required parameter 'productionLotId' is set
            if (productionLotId == null) throw new ApiException(400, "Missing required parameter 'productionLotId' when calling AddProductionLotTag");
            // verify the required parameter 'productionLotTag' is set
            if (productionLotTag == null) throw new ApiException(400, "Missing required parameter 'productionLotTag' when calling AddProductionLotTag");
            
    
            var localVarPath = "/beta/productionLot/{productionLotId}/tag/{productionLotTag}";
    
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
            if (productionLotId != null) localVarPathParams.Add("productionLotId", Configuration.ApiClient.ParameterToString(productionLotId)); // path parameter
            if (productionLotTag != null) localVarPathParams.Add("productionLotTag", Configuration.ApiClient.ParameterToString(productionLotTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddProductionLotTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddProductionLotTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a productionLot Deletes the productionLot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be deleted.</param> 
        /// <returns></returns>
        public void DeleteProductionLot (int? productionLotId)
        {
             DeleteProductionLotWithHttpInfo(productionLotId);
        }

        /// <summary>
        /// Delete a productionLot Deletes the productionLot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteProductionLotWithHttpInfo (int? productionLotId)
        {
            
            // verify the required parameter 'productionLotId' is set
            if (productionLotId == null)
                throw new ApiException(400, "Missing required parameter 'productionLotId' when calling ProductionLotApi->DeleteProductionLot");
            
    
            var localVarPath = "/beta/productionLot/{productionLotId}";
    
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
            if (productionLotId != null) localVarPathParams.Add("productionLotId", Configuration.ApiClient.ParameterToString(productionLotId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteProductionLot: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteProductionLot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a productionLot Deletes the productionLot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteProductionLotAsync (int? productionLotId)
        {
             await DeleteProductionLotAsyncWithHttpInfo(productionLotId);

        }

        /// <summary>
        /// Delete a productionLot Deletes the productionLot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteProductionLotAsyncWithHttpInfo (int? productionLotId)
        {
            // verify the required parameter 'productionLotId' is set
            if (productionLotId == null) throw new ApiException(400, "Missing required parameter 'productionLotId' when calling DeleteProductionLot");
            
    
            var localVarPath = "/beta/productionLot/{productionLotId}";
    
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
            if (productionLotId != null) localVarPathParams.Add("productionLotId", Configuration.ApiClient.ParameterToString(productionLotId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteProductionLot: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteProductionLot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a productionLot. Deletes an existing productionLot tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to remove tag from</param> 
        /// <param name="productionLotTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteProductionLotTag (int? productionLotId, string productionLotTag)
        {
             DeleteProductionLotTagWithHttpInfo(productionLotId, productionLotTag);
        }

        /// <summary>
        /// Delete a tag for a productionLot. Deletes an existing productionLot tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to remove tag from</param> 
        /// <param name="productionLotTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteProductionLotTagWithHttpInfo (int? productionLotId, string productionLotTag)
        {
            
            // verify the required parameter 'productionLotId' is set
            if (productionLotId == null)
                throw new ApiException(400, "Missing required parameter 'productionLotId' when calling ProductionLotApi->DeleteProductionLotTag");
            
            // verify the required parameter 'productionLotTag' is set
            if (productionLotTag == null)
                throw new ApiException(400, "Missing required parameter 'productionLotTag' when calling ProductionLotApi->DeleteProductionLotTag");
            
    
            var localVarPath = "/beta/productionLot/{productionLotId}/tag/{productionLotTag}";
    
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
            if (productionLotId != null) localVarPathParams.Add("productionLotId", Configuration.ApiClient.ParameterToString(productionLotId)); // path parameter
            if (productionLotTag != null) localVarPathParams.Add("productionLotTag", Configuration.ApiClient.ParameterToString(productionLotTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteProductionLotTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteProductionLotTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a productionLot. Deletes an existing productionLot tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to remove tag from</param>
        /// <param name="productionLotTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteProductionLotTagAsync (int? productionLotId, string productionLotTag)
        {
             await DeleteProductionLotTagAsyncWithHttpInfo(productionLotId, productionLotTag);

        }

        /// <summary>
        /// Delete a tag for a productionLot. Deletes an existing productionLot tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to remove tag from</param>
        /// <param name="productionLotTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteProductionLotTagAsyncWithHttpInfo (int? productionLotId, string productionLotTag)
        {
            // verify the required parameter 'productionLotId' is set
            if (productionLotId == null) throw new ApiException(400, "Missing required parameter 'productionLotId' when calling DeleteProductionLotTag");
            // verify the required parameter 'productionLotTag' is set
            if (productionLotTag == null) throw new ApiException(400, "Missing required parameter 'productionLotTag' when calling DeleteProductionLotTag");
            
    
            var localVarPath = "/beta/productionLot/{productionLotId}/tag/{productionLotTag}";
    
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
            if (productionLotId != null) localVarPathParams.Add("productionLotId", Configuration.ApiClient.ParameterToString(productionLotId)); // path parameter
            if (productionLotTag != null) localVarPathParams.Add("productionLotTag", Configuration.ApiClient.ParameterToString(productionLotTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteProductionLotTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteProductionLotTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a productionLot by id Returns a duplicated productionLot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be duplicated.</param> 
        /// <returns>ProductionLot</returns>
        public ProductionLot GetDuplicateProductionLotById (int? productionLotId)
        {
             ApiResponse<ProductionLot> localVarResponse = GetDuplicateProductionLotByIdWithHttpInfo(productionLotId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a productionLot by id Returns a duplicated productionLot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be duplicated.</param> 
        /// <returns>ApiResponse of ProductionLot</returns>
        public ApiResponse< ProductionLot > GetDuplicateProductionLotByIdWithHttpInfo (int? productionLotId)
        {
            
            // verify the required parameter 'productionLotId' is set
            if (productionLotId == null)
                throw new ApiException(400, "Missing required parameter 'productionLotId' when calling ProductionLotApi->GetDuplicateProductionLotById");
            
    
            var localVarPath = "/beta/productionLot/duplicate/{productionLotId}";
    
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
            if (productionLotId != null) localVarPathParams.Add("productionLotId", Configuration.ApiClient.ParameterToString(productionLotId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateProductionLotById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateProductionLotById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ProductionLot>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProductionLot) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductionLot)));
            
        }

        
        /// <summary>
        /// Get a duplicated a productionLot by id Returns a duplicated productionLot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be duplicated.</param>
        /// <returns>Task of ProductionLot</returns>
        public async System.Threading.Tasks.Task<ProductionLot> GetDuplicateProductionLotByIdAsync (int? productionLotId)
        {
             ApiResponse<ProductionLot> localVarResponse = await GetDuplicateProductionLotByIdAsyncWithHttpInfo(productionLotId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a productionLot by id Returns a duplicated productionLot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be duplicated.</param>
        /// <returns>Task of ApiResponse (ProductionLot)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionLot>> GetDuplicateProductionLotByIdAsyncWithHttpInfo (int? productionLotId)
        {
            // verify the required parameter 'productionLotId' is set
            if (productionLotId == null) throw new ApiException(400, "Missing required parameter 'productionLotId' when calling GetDuplicateProductionLotById");
            
    
            var localVarPath = "/beta/productionLot/duplicate/{productionLotId}";
    
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
            if (productionLotId != null) localVarPathParams.Add("productionLotId", Configuration.ApiClient.ParameterToString(productionLotId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateProductionLotById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateProductionLotById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProductionLot>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProductionLot) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductionLot)));
            
        }
        
        /// <summary>
        /// Search productionLots by filter Returns the list of productionLots that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ProductionLot&gt;</returns>
        public List<ProductionLot> GetProductionLotByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ProductionLot>> localVarResponse = GetProductionLotByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search productionLots by filter Returns the list of productionLots that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ProductionLot&gt;</returns>
        public ApiResponse< List<ProductionLot> > GetProductionLotByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/productionLot/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProductionLotByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProductionLotByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ProductionLot>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ProductionLot>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ProductionLot>)));
            
        }

        
        /// <summary>
        /// Search productionLots by filter Returns the list of productionLots that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ProductionLot&gt;</returns>
        public async System.Threading.Tasks.Task<List<ProductionLot>> GetProductionLotByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ProductionLot>> localVarResponse = await GetProductionLotByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search productionLots by filter Returns the list of productionLots that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ProductionLot&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ProductionLot>>> GetProductionLotByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/productionLot/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetProductionLotByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProductionLotByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ProductionLot>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ProductionLot>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ProductionLot>)));
            
        }
        
        /// <summary>
        /// Get a productionLot by id Returns the productionLot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be returned.</param> 
        /// <returns>ProductionLot</returns>
        public ProductionLot GetProductionLotById (int? productionLotId)
        {
             ApiResponse<ProductionLot> localVarResponse = GetProductionLotByIdWithHttpInfo(productionLotId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a productionLot by id Returns the productionLot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be returned.</param> 
        /// <returns>ApiResponse of ProductionLot</returns>
        public ApiResponse< ProductionLot > GetProductionLotByIdWithHttpInfo (int? productionLotId)
        {
            
            // verify the required parameter 'productionLotId' is set
            if (productionLotId == null)
                throw new ApiException(400, "Missing required parameter 'productionLotId' when calling ProductionLotApi->GetProductionLotById");
            
    
            var localVarPath = "/beta/productionLot/{productionLotId}";
    
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
            if (productionLotId != null) localVarPathParams.Add("productionLotId", Configuration.ApiClient.ParameterToString(productionLotId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetProductionLotById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProductionLotById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ProductionLot>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProductionLot) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductionLot)));
            
        }

        
        /// <summary>
        /// Get a productionLot by id Returns the productionLot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be returned.</param>
        /// <returns>Task of ProductionLot</returns>
        public async System.Threading.Tasks.Task<ProductionLot> GetProductionLotByIdAsync (int? productionLotId)
        {
             ApiResponse<ProductionLot> localVarResponse = await GetProductionLotByIdAsyncWithHttpInfo(productionLotId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a productionLot by id Returns the productionLot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to be returned.</param>
        /// <returns>Task of ApiResponse (ProductionLot)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductionLot>> GetProductionLotByIdAsyncWithHttpInfo (int? productionLotId)
        {
            // verify the required parameter 'productionLotId' is set
            if (productionLotId == null) throw new ApiException(400, "Missing required parameter 'productionLotId' when calling GetProductionLotById");
            
    
            var localVarPath = "/beta/productionLot/{productionLotId}";
    
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
            if (productionLotId != null) localVarPathParams.Add("productionLotId", Configuration.ApiClient.ParameterToString(productionLotId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetProductionLotById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProductionLotById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ProductionLot>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ProductionLot) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductionLot)));
            
        }
        
        /// <summary>
        /// Get the tags for a productionLot. Get all existing productionLot tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to get tags for</param> 
        /// <returns></returns>
        public void GetProductionLotTags (int? productionLotId)
        {
             GetProductionLotTagsWithHttpInfo(productionLotId);
        }

        /// <summary>
        /// Get the tags for a productionLot. Get all existing productionLot tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetProductionLotTagsWithHttpInfo (int? productionLotId)
        {
            
            // verify the required parameter 'productionLotId' is set
            if (productionLotId == null)
                throw new ApiException(400, "Missing required parameter 'productionLotId' when calling ProductionLotApi->GetProductionLotTags");
            
    
            var localVarPath = "/beta/productionLot/{productionLotId}/tag";
    
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
            if (productionLotId != null) localVarPathParams.Add("productionLotId", Configuration.ApiClient.ParameterToString(productionLotId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetProductionLotTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProductionLotTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a productionLot. Get all existing productionLot tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetProductionLotTagsAsync (int? productionLotId)
        {
             await GetProductionLotTagsAsyncWithHttpInfo(productionLotId);

        }

        /// <summary>
        /// Get the tags for a productionLot. Get all existing productionLot tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productionLotId">Id of the productionLot to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetProductionLotTagsAsyncWithHttpInfo (int? productionLotId)
        {
            // verify the required parameter 'productionLotId' is set
            if (productionLotId == null) throw new ApiException(400, "Missing required parameter 'productionLotId' when calling GetProductionLotTags");
            
    
            var localVarPath = "/beta/productionLot/{productionLotId}/tag";
    
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
            if (productionLotId != null) localVarPathParams.Add("productionLotId", Configuration.ApiClient.ParameterToString(productionLotId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetProductionLotTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetProductionLotTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a productionLot Updates an existing productionLot using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be updated.</param> 
        /// <returns></returns>
        public void UpdateProductionLot (ProductionLot body)
        {
             UpdateProductionLotWithHttpInfo(body);
        }

        /// <summary>
        /// Update a productionLot Updates an existing productionLot using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateProductionLotWithHttpInfo (ProductionLot body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductionLotApi->UpdateProductionLot");
            
    
            var localVarPath = "/beta/productionLot";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateProductionLot: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateProductionLot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a productionLot Updates an existing productionLot using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateProductionLotAsync (ProductionLot body)
        {
             await UpdateProductionLotAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a productionLot Updates an existing productionLot using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateProductionLotAsyncWithHttpInfo (ProductionLot body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateProductionLot");
            
    
            var localVarPath = "/beta/productionLot";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateProductionLot: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateProductionLot: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a productionLot custom fields Updates an existing productionLot custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be updated.</param> 
        /// <returns></returns>
        public void UpdateProductionLotCustomFields (ProductionLot body)
        {
             UpdateProductionLotCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a productionLot custom fields Updates an existing productionLot custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateProductionLotCustomFieldsWithHttpInfo (ProductionLot body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductionLotApi->UpdateProductionLotCustomFields");
            
    
            var localVarPath = "/beta/productionLot/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateProductionLotCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateProductionLotCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a productionLot custom fields Updates an existing productionLot custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateProductionLotCustomFieldsAsync (ProductionLot body)
        {
             await UpdateProductionLotCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a productionLot custom fields Updates an existing productionLot custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ProductionLot to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateProductionLotCustomFieldsAsyncWithHttpInfo (ProductionLot body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateProductionLotCustomFields");
            
    
            var localVarPath = "/beta/productionLot/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateProductionLotCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateProductionLotCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
