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
    public interface IOrderSourceReservationApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an orderSourceReservation
        /// </summary>
        /// <remarks>
        /// Inserts a new orderSourceReservation using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be inserted.</param>
        /// <returns>OrderSourceReservation</returns>
        OrderSourceReservation AddOrderSourceReservation (OrderSourceReservation body);
  
        /// <summary>
        /// Create an orderSourceReservation
        /// </summary>
        /// <remarks>
        /// Inserts a new orderSourceReservation using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be inserted.</param>
        /// <returns>ApiResponse of OrderSourceReservation</returns>
        ApiResponse<OrderSourceReservation> AddOrderSourceReservationWithHttpInfo (OrderSourceReservation body);
        
        /// <summary>
        /// Add new audit for an orderSourceReservation
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing orderSourceReservation.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to add an audit to</param>
        /// <param name="orderSourceReservationAudit">The audit to add</param>
        /// <returns></returns>
        void AddOrderSourceReservationAudit (int? orderSourceReservationId, string orderSourceReservationAudit);
  
        /// <summary>
        /// Add new audit for an orderSourceReservation
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing orderSourceReservation.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to add an audit to</param>
        /// <param name="orderSourceReservationAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddOrderSourceReservationAuditWithHttpInfo (int? orderSourceReservationId, string orderSourceReservationAudit);
        
        /// <summary>
        /// Add new tags for an orderSourceReservation.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing orderSourceReservation.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to add a tag to</param>
        /// <param name="orderSourceReservationTag">The tag to add</param>
        /// <returns></returns>
        void AddOrderSourceReservationTag (int? orderSourceReservationId, string orderSourceReservationTag);
  
        /// <summary>
        /// Add new tags for an orderSourceReservation.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing orderSourceReservation.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to add a tag to</param>
        /// <param name="orderSourceReservationTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddOrderSourceReservationTagWithHttpInfo (int? orderSourceReservationId, string orderSourceReservationTag);
        
        /// <summary>
        /// Delete an orderSourceReservation
        /// </summary>
        /// <remarks>
        /// Deletes the orderSourceReservation identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be deleted.</param>
        /// <returns></returns>
        void DeleteOrderSourceReservation (int? orderSourceReservationId);
  
        /// <summary>
        /// Delete an orderSourceReservation
        /// </summary>
        /// <remarks>
        /// Deletes the orderSourceReservation identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOrderSourceReservationWithHttpInfo (int? orderSourceReservationId);
        
        /// <summary>
        /// Delete a tag for an orderSourceReservation.
        /// </summary>
        /// <remarks>
        /// Deletes an existing orderSourceReservation tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to remove tag from</param>
        /// <param name="orderSourceReservationTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteOrderSourceReservationTag (int? orderSourceReservationId, string orderSourceReservationTag);
  
        /// <summary>
        /// Delete a tag for an orderSourceReservation.
        /// </summary>
        /// <remarks>
        /// Deletes an existing orderSourceReservation tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to remove tag from</param>
        /// <param name="orderSourceReservationTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOrderSourceReservationTagWithHttpInfo (int? orderSourceReservationId, string orderSourceReservationTag);
        
        /// <summary>
        /// Get a duplicated an orderSourceReservation by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated orderSourceReservation identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be duplicated.</param>
        /// <returns>OrderSourceReservation</returns>
        OrderSourceReservation GetDuplicateOrderSourceReservationById (int? orderSourceReservationId);
  
        /// <summary>
        /// Get a duplicated an orderSourceReservation by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated orderSourceReservation identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be duplicated.</param>
        /// <returns>ApiResponse of OrderSourceReservation</returns>
        ApiResponse<OrderSourceReservation> GetDuplicateOrderSourceReservationByIdWithHttpInfo (int? orderSourceReservationId);
        
        /// <summary>
        /// Search orderSourceReservations by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of orderSourceReservations that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;OrderSourceReservation&gt;</returns>
        List<OrderSourceReservation> GetOrderSourceReservationByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search orderSourceReservations by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of orderSourceReservations that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;OrderSourceReservation&gt;</returns>
        ApiResponse<List<OrderSourceReservation>> GetOrderSourceReservationByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an orderSourceReservation by id
        /// </summary>
        /// <remarks>
        /// Returns the orderSourceReservation identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be returned.</param>
        /// <returns>OrderSourceReservation</returns>
        OrderSourceReservation GetOrderSourceReservationById (int? orderSourceReservationId);
  
        /// <summary>
        /// Get an orderSourceReservation by id
        /// </summary>
        /// <remarks>
        /// Returns the orderSourceReservation identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be returned.</param>
        /// <returns>ApiResponse of OrderSourceReservation</returns>
        ApiResponse<OrderSourceReservation> GetOrderSourceReservationByIdWithHttpInfo (int? orderSourceReservationId);
        
        /// <summary>
        /// Get the tags for an orderSourceReservation.
        /// </summary>
        /// <remarks>
        /// Get all existing orderSourceReservation tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to get tags for</param>
        /// <returns></returns>
        void GetOrderSourceReservationTags (int? orderSourceReservationId);
  
        /// <summary>
        /// Get the tags for an orderSourceReservation.
        /// </summary>
        /// <remarks>
        /// Get all existing orderSourceReservation tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetOrderSourceReservationTagsWithHttpInfo (int? orderSourceReservationId);
        
        /// <summary>
        /// Update an orderSourceReservation
        /// </summary>
        /// <remarks>
        /// Updates an existing orderSourceReservation using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be updated.</param>
        /// <returns></returns>
        void UpdateOrderSourceReservation (OrderSourceReservation body);
  
        /// <summary>
        /// Update an orderSourceReservation
        /// </summary>
        /// <remarks>
        /// Updates an existing orderSourceReservation using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateOrderSourceReservationWithHttpInfo (OrderSourceReservation body);
        
        /// <summary>
        /// Update an orderSourceReservation custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing orderSourceReservation custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be updated.</param>
        /// <returns></returns>
        void UpdateOrderSourceReservationCustomFields (OrderSourceReservation body);
  
        /// <summary>
        /// Update an orderSourceReservation custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing orderSourceReservation custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateOrderSourceReservationCustomFieldsWithHttpInfo (OrderSourceReservation body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an orderSourceReservation
        /// </summary>
        /// <remarks>
        /// Inserts a new orderSourceReservation using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be inserted.</param>
        /// <returns>Task of OrderSourceReservation</returns>
        System.Threading.Tasks.Task<OrderSourceReservation> AddOrderSourceReservationAsync (OrderSourceReservation body);

        /// <summary>
        /// Create an orderSourceReservation
        /// </summary>
        /// <remarks>
        /// Inserts a new orderSourceReservation using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be inserted.</param>
        /// <returns>Task of ApiResponse (OrderSourceReservation)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderSourceReservation>> AddOrderSourceReservationAsyncWithHttpInfo (OrderSourceReservation body);
        
        /// <summary>
        /// Add new audit for an orderSourceReservation
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing orderSourceReservation.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to add an audit to</param>
        /// <param name="orderSourceReservationAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddOrderSourceReservationAuditAsync (int? orderSourceReservationId, string orderSourceReservationAudit);

        /// <summary>
        /// Add new audit for an orderSourceReservation
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing orderSourceReservation.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to add an audit to</param>
        /// <param name="orderSourceReservationAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddOrderSourceReservationAuditAsyncWithHttpInfo (int? orderSourceReservationId, string orderSourceReservationAudit);
        
        /// <summary>
        /// Add new tags for an orderSourceReservation.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing orderSourceReservation.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to add a tag to</param>
        /// <param name="orderSourceReservationTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddOrderSourceReservationTagAsync (int? orderSourceReservationId, string orderSourceReservationTag);

        /// <summary>
        /// Add new tags for an orderSourceReservation.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing orderSourceReservation.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to add a tag to</param>
        /// <param name="orderSourceReservationTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddOrderSourceReservationTagAsyncWithHttpInfo (int? orderSourceReservationId, string orderSourceReservationTag);
        
        /// <summary>
        /// Delete an orderSourceReservation
        /// </summary>
        /// <remarks>
        /// Deletes the orderSourceReservation identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOrderSourceReservationAsync (int? orderSourceReservationId);

        /// <summary>
        /// Delete an orderSourceReservation
        /// </summary>
        /// <remarks>
        /// Deletes the orderSourceReservation identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrderSourceReservationAsyncWithHttpInfo (int? orderSourceReservationId);
        
        /// <summary>
        /// Delete a tag for an orderSourceReservation.
        /// </summary>
        /// <remarks>
        /// Deletes an existing orderSourceReservation tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to remove tag from</param>
        /// <param name="orderSourceReservationTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOrderSourceReservationTagAsync (int? orderSourceReservationId, string orderSourceReservationTag);

        /// <summary>
        /// Delete a tag for an orderSourceReservation.
        /// </summary>
        /// <remarks>
        /// Deletes an existing orderSourceReservation tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to remove tag from</param>
        /// <param name="orderSourceReservationTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrderSourceReservationTagAsyncWithHttpInfo (int? orderSourceReservationId, string orderSourceReservationTag);
        
        /// <summary>
        /// Get a duplicated an orderSourceReservation by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated orderSourceReservation identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be duplicated.</param>
        /// <returns>Task of OrderSourceReservation</returns>
        System.Threading.Tasks.Task<OrderSourceReservation> GetDuplicateOrderSourceReservationByIdAsync (int? orderSourceReservationId);

        /// <summary>
        /// Get a duplicated an orderSourceReservation by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated orderSourceReservation identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be duplicated.</param>
        /// <returns>Task of ApiResponse (OrderSourceReservation)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderSourceReservation>> GetDuplicateOrderSourceReservationByIdAsyncWithHttpInfo (int? orderSourceReservationId);
        
        /// <summary>
        /// Search orderSourceReservations by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of orderSourceReservations that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;OrderSourceReservation&gt;</returns>
        System.Threading.Tasks.Task<List<OrderSourceReservation>> GetOrderSourceReservationByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search orderSourceReservations by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of orderSourceReservations that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;OrderSourceReservation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<OrderSourceReservation>>> GetOrderSourceReservationByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an orderSourceReservation by id
        /// </summary>
        /// <remarks>
        /// Returns the orderSourceReservation identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be returned.</param>
        /// <returns>Task of OrderSourceReservation</returns>
        System.Threading.Tasks.Task<OrderSourceReservation> GetOrderSourceReservationByIdAsync (int? orderSourceReservationId);

        /// <summary>
        /// Get an orderSourceReservation by id
        /// </summary>
        /// <remarks>
        /// Returns the orderSourceReservation identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be returned.</param>
        /// <returns>Task of ApiResponse (OrderSourceReservation)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderSourceReservation>> GetOrderSourceReservationByIdAsyncWithHttpInfo (int? orderSourceReservationId);
        
        /// <summary>
        /// Get the tags for an orderSourceReservation.
        /// </summary>
        /// <remarks>
        /// Get all existing orderSourceReservation tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetOrderSourceReservationTagsAsync (int? orderSourceReservationId);

        /// <summary>
        /// Get the tags for an orderSourceReservation.
        /// </summary>
        /// <remarks>
        /// Get all existing orderSourceReservation tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetOrderSourceReservationTagsAsyncWithHttpInfo (int? orderSourceReservationId);
        
        /// <summary>
        /// Update an orderSourceReservation
        /// </summary>
        /// <remarks>
        /// Updates an existing orderSourceReservation using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateOrderSourceReservationAsync (OrderSourceReservation body);

        /// <summary>
        /// Update an orderSourceReservation
        /// </summary>
        /// <remarks>
        /// Updates an existing orderSourceReservation using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateOrderSourceReservationAsyncWithHttpInfo (OrderSourceReservation body);
        
        /// <summary>
        /// Update an orderSourceReservation custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing orderSourceReservation custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateOrderSourceReservationCustomFieldsAsync (OrderSourceReservation body);

        /// <summary>
        /// Update an orderSourceReservation custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing orderSourceReservation custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateOrderSourceReservationCustomFieldsAsyncWithHttpInfo (OrderSourceReservation body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrderSourceReservationApi : IOrderSourceReservationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSourceReservationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderSourceReservationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderSourceReservationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrderSourceReservationApi(Configuration configuration = null)
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
        /// Create an orderSourceReservation Inserts a new orderSourceReservation using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be inserted.</param> 
        /// <returns>OrderSourceReservation</returns>
        public OrderSourceReservation AddOrderSourceReservation (OrderSourceReservation body)
        {
             ApiResponse<OrderSourceReservation> localVarResponse = AddOrderSourceReservationWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an orderSourceReservation Inserts a new orderSourceReservation using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be inserted.</param> 
        /// <returns>ApiResponse of OrderSourceReservation</returns>
        public ApiResponse< OrderSourceReservation > AddOrderSourceReservationWithHttpInfo (OrderSourceReservation body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrderSourceReservationApi->AddOrderSourceReservation");
            
    
            var localVarPath = "/beta/orderSourceReservation";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderSourceReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderSourceReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrderSourceReservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderSourceReservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderSourceReservation)));
            
        }

        
        /// <summary>
        /// Create an orderSourceReservation Inserts a new orderSourceReservation using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be inserted.</param>
        /// <returns>Task of OrderSourceReservation</returns>
        public async System.Threading.Tasks.Task<OrderSourceReservation> AddOrderSourceReservationAsync (OrderSourceReservation body)
        {
             ApiResponse<OrderSourceReservation> localVarResponse = await AddOrderSourceReservationAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an orderSourceReservation Inserts a new orderSourceReservation using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be inserted.</param>
        /// <returns>Task of ApiResponse (OrderSourceReservation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrderSourceReservation>> AddOrderSourceReservationAsyncWithHttpInfo (OrderSourceReservation body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddOrderSourceReservation");
            
    
            var localVarPath = "/beta/orderSourceReservation";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderSourceReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderSourceReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrderSourceReservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderSourceReservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderSourceReservation)));
            
        }
        
        /// <summary>
        /// Add new audit for an orderSourceReservation Adds an audit to an existing orderSourceReservation.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to add an audit to</param> 
        /// <param name="orderSourceReservationAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddOrderSourceReservationAudit (int? orderSourceReservationId, string orderSourceReservationAudit)
        {
             AddOrderSourceReservationAuditWithHttpInfo(orderSourceReservationId, orderSourceReservationAudit);
        }

        /// <summary>
        /// Add new audit for an orderSourceReservation Adds an audit to an existing orderSourceReservation.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to add an audit to</param> 
        /// <param name="orderSourceReservationAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddOrderSourceReservationAuditWithHttpInfo (int? orderSourceReservationId, string orderSourceReservationAudit)
        {
            
            // verify the required parameter 'orderSourceReservationId' is set
            if (orderSourceReservationId == null)
                throw new ApiException(400, "Missing required parameter 'orderSourceReservationId' when calling OrderSourceReservationApi->AddOrderSourceReservationAudit");
            
            // verify the required parameter 'orderSourceReservationAudit' is set
            if (orderSourceReservationAudit == null)
                throw new ApiException(400, "Missing required parameter 'orderSourceReservationAudit' when calling OrderSourceReservationApi->AddOrderSourceReservationAudit");
            
    
            var localVarPath = "/beta/orderSourceReservation/{orderSourceReservationId}/audit/{orderSourceReservationAudit}";
    
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
            if (orderSourceReservationId != null) localVarPathParams.Add("orderSourceReservationId", Configuration.ApiClient.ParameterToString(orderSourceReservationId)); // path parameter
            if (orderSourceReservationAudit != null) localVarPathParams.Add("orderSourceReservationAudit", Configuration.ApiClient.ParameterToString(orderSourceReservationAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderSourceReservationAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderSourceReservationAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an orderSourceReservation Adds an audit to an existing orderSourceReservation.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to add an audit to</param>
        /// <param name="orderSourceReservationAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddOrderSourceReservationAuditAsync (int? orderSourceReservationId, string orderSourceReservationAudit)
        {
             await AddOrderSourceReservationAuditAsyncWithHttpInfo(orderSourceReservationId, orderSourceReservationAudit);

        }

        /// <summary>
        /// Add new audit for an orderSourceReservation Adds an audit to an existing orderSourceReservation.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to add an audit to</param>
        /// <param name="orderSourceReservationAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddOrderSourceReservationAuditAsyncWithHttpInfo (int? orderSourceReservationId, string orderSourceReservationAudit)
        {
            // verify the required parameter 'orderSourceReservationId' is set
            if (orderSourceReservationId == null) throw new ApiException(400, "Missing required parameter 'orderSourceReservationId' when calling AddOrderSourceReservationAudit");
            // verify the required parameter 'orderSourceReservationAudit' is set
            if (orderSourceReservationAudit == null) throw new ApiException(400, "Missing required parameter 'orderSourceReservationAudit' when calling AddOrderSourceReservationAudit");
            
    
            var localVarPath = "/beta/orderSourceReservation/{orderSourceReservationId}/audit/{orderSourceReservationAudit}";
    
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
            if (orderSourceReservationId != null) localVarPathParams.Add("orderSourceReservationId", Configuration.ApiClient.ParameterToString(orderSourceReservationId)); // path parameter
            if (orderSourceReservationAudit != null) localVarPathParams.Add("orderSourceReservationAudit", Configuration.ApiClient.ParameterToString(orderSourceReservationAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderSourceReservationAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderSourceReservationAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an orderSourceReservation. Adds a tag to an existing orderSourceReservation.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to add a tag to</param> 
        /// <param name="orderSourceReservationTag">The tag to add</param> 
        /// <returns></returns>
        public void AddOrderSourceReservationTag (int? orderSourceReservationId, string orderSourceReservationTag)
        {
             AddOrderSourceReservationTagWithHttpInfo(orderSourceReservationId, orderSourceReservationTag);
        }

        /// <summary>
        /// Add new tags for an orderSourceReservation. Adds a tag to an existing orderSourceReservation.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to add a tag to</param> 
        /// <param name="orderSourceReservationTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddOrderSourceReservationTagWithHttpInfo (int? orderSourceReservationId, string orderSourceReservationTag)
        {
            
            // verify the required parameter 'orderSourceReservationId' is set
            if (orderSourceReservationId == null)
                throw new ApiException(400, "Missing required parameter 'orderSourceReservationId' when calling OrderSourceReservationApi->AddOrderSourceReservationTag");
            
            // verify the required parameter 'orderSourceReservationTag' is set
            if (orderSourceReservationTag == null)
                throw new ApiException(400, "Missing required parameter 'orderSourceReservationTag' when calling OrderSourceReservationApi->AddOrderSourceReservationTag");
            
    
            var localVarPath = "/beta/orderSourceReservation/{orderSourceReservationId}/tag/{orderSourceReservationTag}";
    
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
            if (orderSourceReservationId != null) localVarPathParams.Add("orderSourceReservationId", Configuration.ApiClient.ParameterToString(orderSourceReservationId)); // path parameter
            if (orderSourceReservationTag != null) localVarPathParams.Add("orderSourceReservationTag", Configuration.ApiClient.ParameterToString(orderSourceReservationTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderSourceReservationTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderSourceReservationTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an orderSourceReservation. Adds a tag to an existing orderSourceReservation.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to add a tag to</param>
        /// <param name="orderSourceReservationTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddOrderSourceReservationTagAsync (int? orderSourceReservationId, string orderSourceReservationTag)
        {
             await AddOrderSourceReservationTagAsyncWithHttpInfo(orderSourceReservationId, orderSourceReservationTag);

        }

        /// <summary>
        /// Add new tags for an orderSourceReservation. Adds a tag to an existing orderSourceReservation.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to add a tag to</param>
        /// <param name="orderSourceReservationTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddOrderSourceReservationTagAsyncWithHttpInfo (int? orderSourceReservationId, string orderSourceReservationTag)
        {
            // verify the required parameter 'orderSourceReservationId' is set
            if (orderSourceReservationId == null) throw new ApiException(400, "Missing required parameter 'orderSourceReservationId' when calling AddOrderSourceReservationTag");
            // verify the required parameter 'orderSourceReservationTag' is set
            if (orderSourceReservationTag == null) throw new ApiException(400, "Missing required parameter 'orderSourceReservationTag' when calling AddOrderSourceReservationTag");
            
    
            var localVarPath = "/beta/orderSourceReservation/{orderSourceReservationId}/tag/{orderSourceReservationTag}";
    
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
            if (orderSourceReservationId != null) localVarPathParams.Add("orderSourceReservationId", Configuration.ApiClient.ParameterToString(orderSourceReservationId)); // path parameter
            if (orderSourceReservationTag != null) localVarPathParams.Add("orderSourceReservationTag", Configuration.ApiClient.ParameterToString(orderSourceReservationTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddOrderSourceReservationTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddOrderSourceReservationTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an orderSourceReservation Deletes the orderSourceReservation identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be deleted.</param> 
        /// <returns></returns>
        public void DeleteOrderSourceReservation (int? orderSourceReservationId)
        {
             DeleteOrderSourceReservationWithHttpInfo(orderSourceReservationId);
        }

        /// <summary>
        /// Delete an orderSourceReservation Deletes the orderSourceReservation identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOrderSourceReservationWithHttpInfo (int? orderSourceReservationId)
        {
            
            // verify the required parameter 'orderSourceReservationId' is set
            if (orderSourceReservationId == null)
                throw new ApiException(400, "Missing required parameter 'orderSourceReservationId' when calling OrderSourceReservationApi->DeleteOrderSourceReservation");
            
    
            var localVarPath = "/beta/orderSourceReservation/{orderSourceReservationId}";
    
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
            if (orderSourceReservationId != null) localVarPathParams.Add("orderSourceReservationId", Configuration.ApiClient.ParameterToString(orderSourceReservationId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderSourceReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderSourceReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an orderSourceReservation Deletes the orderSourceReservation identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOrderSourceReservationAsync (int? orderSourceReservationId)
        {
             await DeleteOrderSourceReservationAsyncWithHttpInfo(orderSourceReservationId);

        }

        /// <summary>
        /// Delete an orderSourceReservation Deletes the orderSourceReservation identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrderSourceReservationAsyncWithHttpInfo (int? orderSourceReservationId)
        {
            // verify the required parameter 'orderSourceReservationId' is set
            if (orderSourceReservationId == null) throw new ApiException(400, "Missing required parameter 'orderSourceReservationId' when calling DeleteOrderSourceReservation");
            
    
            var localVarPath = "/beta/orderSourceReservation/{orderSourceReservationId}";
    
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
            if (orderSourceReservationId != null) localVarPathParams.Add("orderSourceReservationId", Configuration.ApiClient.ParameterToString(orderSourceReservationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderSourceReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderSourceReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an orderSourceReservation. Deletes an existing orderSourceReservation tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to remove tag from</param> 
        /// <param name="orderSourceReservationTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteOrderSourceReservationTag (int? orderSourceReservationId, string orderSourceReservationTag)
        {
             DeleteOrderSourceReservationTagWithHttpInfo(orderSourceReservationId, orderSourceReservationTag);
        }

        /// <summary>
        /// Delete a tag for an orderSourceReservation. Deletes an existing orderSourceReservation tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to remove tag from</param> 
        /// <param name="orderSourceReservationTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOrderSourceReservationTagWithHttpInfo (int? orderSourceReservationId, string orderSourceReservationTag)
        {
            
            // verify the required parameter 'orderSourceReservationId' is set
            if (orderSourceReservationId == null)
                throw new ApiException(400, "Missing required parameter 'orderSourceReservationId' when calling OrderSourceReservationApi->DeleteOrderSourceReservationTag");
            
            // verify the required parameter 'orderSourceReservationTag' is set
            if (orderSourceReservationTag == null)
                throw new ApiException(400, "Missing required parameter 'orderSourceReservationTag' when calling OrderSourceReservationApi->DeleteOrderSourceReservationTag");
            
    
            var localVarPath = "/beta/orderSourceReservation/{orderSourceReservationId}/tag/{orderSourceReservationTag}";
    
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
            if (orderSourceReservationId != null) localVarPathParams.Add("orderSourceReservationId", Configuration.ApiClient.ParameterToString(orderSourceReservationId)); // path parameter
            if (orderSourceReservationTag != null) localVarPathParams.Add("orderSourceReservationTag", Configuration.ApiClient.ParameterToString(orderSourceReservationTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderSourceReservationTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderSourceReservationTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an orderSourceReservation. Deletes an existing orderSourceReservation tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to remove tag from</param>
        /// <param name="orderSourceReservationTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOrderSourceReservationTagAsync (int? orderSourceReservationId, string orderSourceReservationTag)
        {
             await DeleteOrderSourceReservationTagAsyncWithHttpInfo(orderSourceReservationId, orderSourceReservationTag);

        }

        /// <summary>
        /// Delete a tag for an orderSourceReservation. Deletes an existing orderSourceReservation tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to remove tag from</param>
        /// <param name="orderSourceReservationTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrderSourceReservationTagAsyncWithHttpInfo (int? orderSourceReservationId, string orderSourceReservationTag)
        {
            // verify the required parameter 'orderSourceReservationId' is set
            if (orderSourceReservationId == null) throw new ApiException(400, "Missing required parameter 'orderSourceReservationId' when calling DeleteOrderSourceReservationTag");
            // verify the required parameter 'orderSourceReservationTag' is set
            if (orderSourceReservationTag == null) throw new ApiException(400, "Missing required parameter 'orderSourceReservationTag' when calling DeleteOrderSourceReservationTag");
            
    
            var localVarPath = "/beta/orderSourceReservation/{orderSourceReservationId}/tag/{orderSourceReservationTag}";
    
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
            if (orderSourceReservationId != null) localVarPathParams.Add("orderSourceReservationId", Configuration.ApiClient.ParameterToString(orderSourceReservationId)); // path parameter
            if (orderSourceReservationTag != null) localVarPathParams.Add("orderSourceReservationTag", Configuration.ApiClient.ParameterToString(orderSourceReservationTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderSourceReservationTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrderSourceReservationTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an orderSourceReservation by id Returns a duplicated orderSourceReservation identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be duplicated.</param> 
        /// <returns>OrderSourceReservation</returns>
        public OrderSourceReservation GetDuplicateOrderSourceReservationById (int? orderSourceReservationId)
        {
             ApiResponse<OrderSourceReservation> localVarResponse = GetDuplicateOrderSourceReservationByIdWithHttpInfo(orderSourceReservationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an orderSourceReservation by id Returns a duplicated orderSourceReservation identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be duplicated.</param> 
        /// <returns>ApiResponse of OrderSourceReservation</returns>
        public ApiResponse< OrderSourceReservation > GetDuplicateOrderSourceReservationByIdWithHttpInfo (int? orderSourceReservationId)
        {
            
            // verify the required parameter 'orderSourceReservationId' is set
            if (orderSourceReservationId == null)
                throw new ApiException(400, "Missing required parameter 'orderSourceReservationId' when calling OrderSourceReservationApi->GetDuplicateOrderSourceReservationById");
            
    
            var localVarPath = "/beta/orderSourceReservation/duplicate/{orderSourceReservationId}";
    
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
            if (orderSourceReservationId != null) localVarPathParams.Add("orderSourceReservationId", Configuration.ApiClient.ParameterToString(orderSourceReservationId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateOrderSourceReservationById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateOrderSourceReservationById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrderSourceReservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderSourceReservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderSourceReservation)));
            
        }

        
        /// <summary>
        /// Get a duplicated an orderSourceReservation by id Returns a duplicated orderSourceReservation identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be duplicated.</param>
        /// <returns>Task of OrderSourceReservation</returns>
        public async System.Threading.Tasks.Task<OrderSourceReservation> GetDuplicateOrderSourceReservationByIdAsync (int? orderSourceReservationId)
        {
             ApiResponse<OrderSourceReservation> localVarResponse = await GetDuplicateOrderSourceReservationByIdAsyncWithHttpInfo(orderSourceReservationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an orderSourceReservation by id Returns a duplicated orderSourceReservation identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be duplicated.</param>
        /// <returns>Task of ApiResponse (OrderSourceReservation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrderSourceReservation>> GetDuplicateOrderSourceReservationByIdAsyncWithHttpInfo (int? orderSourceReservationId)
        {
            // verify the required parameter 'orderSourceReservationId' is set
            if (orderSourceReservationId == null) throw new ApiException(400, "Missing required parameter 'orderSourceReservationId' when calling GetDuplicateOrderSourceReservationById");
            
    
            var localVarPath = "/beta/orderSourceReservation/duplicate/{orderSourceReservationId}";
    
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
            if (orderSourceReservationId != null) localVarPathParams.Add("orderSourceReservationId", Configuration.ApiClient.ParameterToString(orderSourceReservationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateOrderSourceReservationById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateOrderSourceReservationById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrderSourceReservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderSourceReservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderSourceReservation)));
            
        }
        
        /// <summary>
        /// Search orderSourceReservations by filter Returns the list of orderSourceReservations that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;OrderSourceReservation&gt;</returns>
        public List<OrderSourceReservation> GetOrderSourceReservationByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<OrderSourceReservation>> localVarResponse = GetOrderSourceReservationByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search orderSourceReservations by filter Returns the list of orderSourceReservations that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;OrderSourceReservation&gt;</returns>
        public ApiResponse< List<OrderSourceReservation> > GetOrderSourceReservationByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/orderSourceReservation/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderSourceReservationByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderSourceReservationByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<OrderSourceReservation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OrderSourceReservation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OrderSourceReservation>)));
            
        }

        
        /// <summary>
        /// Search orderSourceReservations by filter Returns the list of orderSourceReservations that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;OrderSourceReservation&gt;</returns>
        public async System.Threading.Tasks.Task<List<OrderSourceReservation>> GetOrderSourceReservationByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<OrderSourceReservation>> localVarResponse = await GetOrderSourceReservationByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search orderSourceReservations by filter Returns the list of orderSourceReservations that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;OrderSourceReservation&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<OrderSourceReservation>>> GetOrderSourceReservationByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/orderSourceReservation/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderSourceReservationByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderSourceReservationByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<OrderSourceReservation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<OrderSourceReservation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<OrderSourceReservation>)));
            
        }
        
        /// <summary>
        /// Get an orderSourceReservation by id Returns the orderSourceReservation identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be returned.</param> 
        /// <returns>OrderSourceReservation</returns>
        public OrderSourceReservation GetOrderSourceReservationById (int? orderSourceReservationId)
        {
             ApiResponse<OrderSourceReservation> localVarResponse = GetOrderSourceReservationByIdWithHttpInfo(orderSourceReservationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an orderSourceReservation by id Returns the orderSourceReservation identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be returned.</param> 
        /// <returns>ApiResponse of OrderSourceReservation</returns>
        public ApiResponse< OrderSourceReservation > GetOrderSourceReservationByIdWithHttpInfo (int? orderSourceReservationId)
        {
            
            // verify the required parameter 'orderSourceReservationId' is set
            if (orderSourceReservationId == null)
                throw new ApiException(400, "Missing required parameter 'orderSourceReservationId' when calling OrderSourceReservationApi->GetOrderSourceReservationById");
            
    
            var localVarPath = "/beta/orderSourceReservation/{orderSourceReservationId}";
    
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
            if (orderSourceReservationId != null) localVarPathParams.Add("orderSourceReservationId", Configuration.ApiClient.ParameterToString(orderSourceReservationId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderSourceReservationById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderSourceReservationById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrderSourceReservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderSourceReservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderSourceReservation)));
            
        }

        
        /// <summary>
        /// Get an orderSourceReservation by id Returns the orderSourceReservation identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be returned.</param>
        /// <returns>Task of OrderSourceReservation</returns>
        public async System.Threading.Tasks.Task<OrderSourceReservation> GetOrderSourceReservationByIdAsync (int? orderSourceReservationId)
        {
             ApiResponse<OrderSourceReservation> localVarResponse = await GetOrderSourceReservationByIdAsyncWithHttpInfo(orderSourceReservationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an orderSourceReservation by id Returns the orderSourceReservation identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to be returned.</param>
        /// <returns>Task of ApiResponse (OrderSourceReservation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrderSourceReservation>> GetOrderSourceReservationByIdAsyncWithHttpInfo (int? orderSourceReservationId)
        {
            // verify the required parameter 'orderSourceReservationId' is set
            if (orderSourceReservationId == null) throw new ApiException(400, "Missing required parameter 'orderSourceReservationId' when calling GetOrderSourceReservationById");
            
    
            var localVarPath = "/beta/orderSourceReservation/{orderSourceReservationId}";
    
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
            if (orderSourceReservationId != null) localVarPathParams.Add("orderSourceReservationId", Configuration.ApiClient.ParameterToString(orderSourceReservationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderSourceReservationById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderSourceReservationById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrderSourceReservation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderSourceReservation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderSourceReservation)));
            
        }
        
        /// <summary>
        /// Get the tags for an orderSourceReservation. Get all existing orderSourceReservation tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to get tags for</param> 
        /// <returns></returns>
        public void GetOrderSourceReservationTags (int? orderSourceReservationId)
        {
             GetOrderSourceReservationTagsWithHttpInfo(orderSourceReservationId);
        }

        /// <summary>
        /// Get the tags for an orderSourceReservation. Get all existing orderSourceReservation tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetOrderSourceReservationTagsWithHttpInfo (int? orderSourceReservationId)
        {
            
            // verify the required parameter 'orderSourceReservationId' is set
            if (orderSourceReservationId == null)
                throw new ApiException(400, "Missing required parameter 'orderSourceReservationId' when calling OrderSourceReservationApi->GetOrderSourceReservationTags");
            
    
            var localVarPath = "/beta/orderSourceReservation/{orderSourceReservationId}/tag";
    
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
            if (orderSourceReservationId != null) localVarPathParams.Add("orderSourceReservationId", Configuration.ApiClient.ParameterToString(orderSourceReservationId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderSourceReservationTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderSourceReservationTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an orderSourceReservation. Get all existing orderSourceReservation tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetOrderSourceReservationTagsAsync (int? orderSourceReservationId)
        {
             await GetOrderSourceReservationTagsAsyncWithHttpInfo(orderSourceReservationId);

        }

        /// <summary>
        /// Get the tags for an orderSourceReservation. Get all existing orderSourceReservation tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderSourceReservationId">Id of the orderSourceReservation to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetOrderSourceReservationTagsAsyncWithHttpInfo (int? orderSourceReservationId)
        {
            // verify the required parameter 'orderSourceReservationId' is set
            if (orderSourceReservationId == null) throw new ApiException(400, "Missing required parameter 'orderSourceReservationId' when calling GetOrderSourceReservationTags");
            
    
            var localVarPath = "/beta/orderSourceReservation/{orderSourceReservationId}/tag";
    
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
            if (orderSourceReservationId != null) localVarPathParams.Add("orderSourceReservationId", Configuration.ApiClient.ParameterToString(orderSourceReservationId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrderSourceReservationTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrderSourceReservationTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an orderSourceReservation Updates an existing orderSourceReservation using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be updated.</param> 
        /// <returns></returns>
        public void UpdateOrderSourceReservation (OrderSourceReservation body)
        {
             UpdateOrderSourceReservationWithHttpInfo(body);
        }

        /// <summary>
        /// Update an orderSourceReservation Updates an existing orderSourceReservation using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateOrderSourceReservationWithHttpInfo (OrderSourceReservation body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrderSourceReservationApi->UpdateOrderSourceReservation");
            
    
            var localVarPath = "/beta/orderSourceReservation";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrderSourceReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrderSourceReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an orderSourceReservation Updates an existing orderSourceReservation using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateOrderSourceReservationAsync (OrderSourceReservation body)
        {
             await UpdateOrderSourceReservationAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an orderSourceReservation Updates an existing orderSourceReservation using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateOrderSourceReservationAsyncWithHttpInfo (OrderSourceReservation body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrderSourceReservation");
            
    
            var localVarPath = "/beta/orderSourceReservation";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrderSourceReservation: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrderSourceReservation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an orderSourceReservation custom fields Updates an existing orderSourceReservation custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be updated.</param> 
        /// <returns></returns>
        public void UpdateOrderSourceReservationCustomFields (OrderSourceReservation body)
        {
             UpdateOrderSourceReservationCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update an orderSourceReservation custom fields Updates an existing orderSourceReservation custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateOrderSourceReservationCustomFieldsWithHttpInfo (OrderSourceReservation body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling OrderSourceReservationApi->UpdateOrderSourceReservationCustomFields");
            
    
            var localVarPath = "/beta/orderSourceReservation/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrderSourceReservationCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrderSourceReservationCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an orderSourceReservation custom fields Updates an existing orderSourceReservation custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateOrderSourceReservationCustomFieldsAsync (OrderSourceReservation body)
        {
             await UpdateOrderSourceReservationCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an orderSourceReservation custom fields Updates an existing orderSourceReservation custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">OrderSourceReservation to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateOrderSourceReservationCustomFieldsAsyncWithHttpInfo (OrderSourceReservation body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrderSourceReservationCustomFields");
            
    
            var localVarPath = "/beta/orderSourceReservation/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrderSourceReservationCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrderSourceReservationCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
