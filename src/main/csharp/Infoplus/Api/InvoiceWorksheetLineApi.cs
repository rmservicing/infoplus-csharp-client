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
    public interface IInvoiceWorksheetLineApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an invoiceWorksheetLine
        /// </summary>
        /// <remarks>
        /// Inserts a new invoiceWorksheetLine using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheetLine to be inserted.</param>
        /// <returns>InvoiceWorksheetLine</returns>
        InvoiceWorksheetLine AddInvoiceWorksheetLine (InvoiceWorksheetLine body);
  
        /// <summary>
        /// Create an invoiceWorksheetLine
        /// </summary>
        /// <remarks>
        /// Inserts a new invoiceWorksheetLine using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheetLine to be inserted.</param>
        /// <returns>ApiResponse of InvoiceWorksheetLine</returns>
        ApiResponse<InvoiceWorksheetLine> AddInvoiceWorksheetLineWithHttpInfo (InvoiceWorksheetLine body);
        
        /// <summary>
        /// Add new audit for an invoiceWorksheetLine
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing invoiceWorksheetLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to add an audit to</param>
        /// <param name="invoiceWorksheetLineAudit">The audit to add</param>
        /// <returns></returns>
        void AddInvoiceWorksheetLineAudit (int? invoiceWorksheetLineId, string invoiceWorksheetLineAudit);
  
        /// <summary>
        /// Add new audit for an invoiceWorksheetLine
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing invoiceWorksheetLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to add an audit to</param>
        /// <param name="invoiceWorksheetLineAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddInvoiceWorksheetLineAuditWithHttpInfo (int? invoiceWorksheetLineId, string invoiceWorksheetLineAudit);
        
        /// <summary>
        /// Add new tags for an invoiceWorksheetLine.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing invoiceWorksheetLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to add a tag to</param>
        /// <param name="invoiceWorksheetLineTag">The tag to add</param>
        /// <returns></returns>
        void AddInvoiceWorksheetLineTag (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag);
  
        /// <summary>
        /// Add new tags for an invoiceWorksheetLine.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing invoiceWorksheetLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to add a tag to</param>
        /// <param name="invoiceWorksheetLineTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddInvoiceWorksheetLineTagWithHttpInfo (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag);
        
        /// <summary>
        /// Delete an invoiceWorksheetLine
        /// </summary>
        /// <remarks>
        /// Deletes the invoiceWorksheetLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be deleted.</param>
        /// <returns></returns>
        void DeleteInvoiceWorksheetLine (int? invoiceWorksheetLineId);
  
        /// <summary>
        /// Delete an invoiceWorksheetLine
        /// </summary>
        /// <remarks>
        /// Deletes the invoiceWorksheetLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteInvoiceWorksheetLineWithHttpInfo (int? invoiceWorksheetLineId);
        
        /// <summary>
        /// Delete a tag for an invoiceWorksheetLine.
        /// </summary>
        /// <remarks>
        /// Deletes an existing invoiceWorksheetLine tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to remove tag from</param>
        /// <param name="invoiceWorksheetLineTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteInvoiceWorksheetLineTag (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag);
  
        /// <summary>
        /// Delete a tag for an invoiceWorksheetLine.
        /// </summary>
        /// <remarks>
        /// Deletes an existing invoiceWorksheetLine tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to remove tag from</param>
        /// <param name="invoiceWorksheetLineTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteInvoiceWorksheetLineTagWithHttpInfo (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag);
        
        /// <summary>
        /// Get a duplicated an invoiceWorksheetLine by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated invoiceWorksheetLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be duplicated.</param>
        /// <returns>InvoiceWorksheetLine</returns>
        InvoiceWorksheetLine GetDuplicateInvoiceWorksheetLineById (int? invoiceWorksheetLineId);
  
        /// <summary>
        /// Get a duplicated an invoiceWorksheetLine by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated invoiceWorksheetLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be duplicated.</param>
        /// <returns>ApiResponse of InvoiceWorksheetLine</returns>
        ApiResponse<InvoiceWorksheetLine> GetDuplicateInvoiceWorksheetLineByIdWithHttpInfo (int? invoiceWorksheetLineId);
        
        /// <summary>
        /// Search invoiceWorksheetLines by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of invoiceWorksheetLines that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;InvoiceWorksheetLine&gt;</returns>
        List<InvoiceWorksheetLine> GetInvoiceWorksheetLineByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search invoiceWorksheetLines by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of invoiceWorksheetLines that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;InvoiceWorksheetLine&gt;</returns>
        ApiResponse<List<InvoiceWorksheetLine>> GetInvoiceWorksheetLineByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an invoiceWorksheetLine by id
        /// </summary>
        /// <remarks>
        /// Returns the invoiceWorksheetLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be returned.</param>
        /// <returns>InvoiceWorksheetLine</returns>
        InvoiceWorksheetLine GetInvoiceWorksheetLineById (int? invoiceWorksheetLineId);
  
        /// <summary>
        /// Get an invoiceWorksheetLine by id
        /// </summary>
        /// <remarks>
        /// Returns the invoiceWorksheetLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be returned.</param>
        /// <returns>ApiResponse of InvoiceWorksheetLine</returns>
        ApiResponse<InvoiceWorksheetLine> GetInvoiceWorksheetLineByIdWithHttpInfo (int? invoiceWorksheetLineId);
        
        /// <summary>
        /// Get the tags for an invoiceWorksheetLine.
        /// </summary>
        /// <remarks>
        /// Get all existing invoiceWorksheetLine tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to get tags for</param>
        /// <returns></returns>
        void GetInvoiceWorksheetLineTags (int? invoiceWorksheetLineId);
  
        /// <summary>
        /// Get the tags for an invoiceWorksheetLine.
        /// </summary>
        /// <remarks>
        /// Get all existing invoiceWorksheetLine tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetInvoiceWorksheetLineTagsWithHttpInfo (int? invoiceWorksheetLineId);
        
        /// <summary>
        /// Update an invoiceWorksheetLine
        /// </summary>
        /// <remarks>
        /// Updates an existing invoiceWorksheetLine using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheetLine to be updated.</param>
        /// <returns></returns>
        void UpdateInvoiceWorksheetLine (InvoiceWorksheetLine body);
  
        /// <summary>
        /// Update an invoiceWorksheetLine
        /// </summary>
        /// <remarks>
        /// Updates an existing invoiceWorksheetLine using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheetLine to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateInvoiceWorksheetLineWithHttpInfo (InvoiceWorksheetLine body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an invoiceWorksheetLine
        /// </summary>
        /// <remarks>
        /// Inserts a new invoiceWorksheetLine using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheetLine to be inserted.</param>
        /// <returns>Task of InvoiceWorksheetLine</returns>
        System.Threading.Tasks.Task<InvoiceWorksheetLine> AddInvoiceWorksheetLineAsync (InvoiceWorksheetLine body);

        /// <summary>
        /// Create an invoiceWorksheetLine
        /// </summary>
        /// <remarks>
        /// Inserts a new invoiceWorksheetLine using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheetLine to be inserted.</param>
        /// <returns>Task of ApiResponse (InvoiceWorksheetLine)</returns>
        System.Threading.Tasks.Task<ApiResponse<InvoiceWorksheetLine>> AddInvoiceWorksheetLineAsyncWithHttpInfo (InvoiceWorksheetLine body);
        
        /// <summary>
        /// Add new audit for an invoiceWorksheetLine
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing invoiceWorksheetLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to add an audit to</param>
        /// <param name="invoiceWorksheetLineAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddInvoiceWorksheetLineAuditAsync (int? invoiceWorksheetLineId, string invoiceWorksheetLineAudit);

        /// <summary>
        /// Add new audit for an invoiceWorksheetLine
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing invoiceWorksheetLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to add an audit to</param>
        /// <param name="invoiceWorksheetLineAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddInvoiceWorksheetLineAuditAsyncWithHttpInfo (int? invoiceWorksheetLineId, string invoiceWorksheetLineAudit);
        
        /// <summary>
        /// Add new tags for an invoiceWorksheetLine.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing invoiceWorksheetLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to add a tag to</param>
        /// <param name="invoiceWorksheetLineTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddInvoiceWorksheetLineTagAsync (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag);

        /// <summary>
        /// Add new tags for an invoiceWorksheetLine.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing invoiceWorksheetLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to add a tag to</param>
        /// <param name="invoiceWorksheetLineTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddInvoiceWorksheetLineTagAsyncWithHttpInfo (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag);
        
        /// <summary>
        /// Delete an invoiceWorksheetLine
        /// </summary>
        /// <remarks>
        /// Deletes the invoiceWorksheetLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteInvoiceWorksheetLineAsync (int? invoiceWorksheetLineId);

        /// <summary>
        /// Delete an invoiceWorksheetLine
        /// </summary>
        /// <remarks>
        /// Deletes the invoiceWorksheetLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInvoiceWorksheetLineAsyncWithHttpInfo (int? invoiceWorksheetLineId);
        
        /// <summary>
        /// Delete a tag for an invoiceWorksheetLine.
        /// </summary>
        /// <remarks>
        /// Deletes an existing invoiceWorksheetLine tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to remove tag from</param>
        /// <param name="invoiceWorksheetLineTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteInvoiceWorksheetLineTagAsync (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag);

        /// <summary>
        /// Delete a tag for an invoiceWorksheetLine.
        /// </summary>
        /// <remarks>
        /// Deletes an existing invoiceWorksheetLine tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to remove tag from</param>
        /// <param name="invoiceWorksheetLineTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInvoiceWorksheetLineTagAsyncWithHttpInfo (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag);
        
        /// <summary>
        /// Get a duplicated an invoiceWorksheetLine by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated invoiceWorksheetLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be duplicated.</param>
        /// <returns>Task of InvoiceWorksheetLine</returns>
        System.Threading.Tasks.Task<InvoiceWorksheetLine> GetDuplicateInvoiceWorksheetLineByIdAsync (int? invoiceWorksheetLineId);

        /// <summary>
        /// Get a duplicated an invoiceWorksheetLine by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated invoiceWorksheetLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be duplicated.</param>
        /// <returns>Task of ApiResponse (InvoiceWorksheetLine)</returns>
        System.Threading.Tasks.Task<ApiResponse<InvoiceWorksheetLine>> GetDuplicateInvoiceWorksheetLineByIdAsyncWithHttpInfo (int? invoiceWorksheetLineId);
        
        /// <summary>
        /// Search invoiceWorksheetLines by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of invoiceWorksheetLines that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;InvoiceWorksheetLine&gt;</returns>
        System.Threading.Tasks.Task<List<InvoiceWorksheetLine>> GetInvoiceWorksheetLineByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search invoiceWorksheetLines by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of invoiceWorksheetLines that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;InvoiceWorksheetLine&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InvoiceWorksheetLine>>> GetInvoiceWorksheetLineByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an invoiceWorksheetLine by id
        /// </summary>
        /// <remarks>
        /// Returns the invoiceWorksheetLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be returned.</param>
        /// <returns>Task of InvoiceWorksheetLine</returns>
        System.Threading.Tasks.Task<InvoiceWorksheetLine> GetInvoiceWorksheetLineByIdAsync (int? invoiceWorksheetLineId);

        /// <summary>
        /// Get an invoiceWorksheetLine by id
        /// </summary>
        /// <remarks>
        /// Returns the invoiceWorksheetLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be returned.</param>
        /// <returns>Task of ApiResponse (InvoiceWorksheetLine)</returns>
        System.Threading.Tasks.Task<ApiResponse<InvoiceWorksheetLine>> GetInvoiceWorksheetLineByIdAsyncWithHttpInfo (int? invoiceWorksheetLineId);
        
        /// <summary>
        /// Get the tags for an invoiceWorksheetLine.
        /// </summary>
        /// <remarks>
        /// Get all existing invoiceWorksheetLine tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetInvoiceWorksheetLineTagsAsync (int? invoiceWorksheetLineId);

        /// <summary>
        /// Get the tags for an invoiceWorksheetLine.
        /// </summary>
        /// <remarks>
        /// Get all existing invoiceWorksheetLine tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetInvoiceWorksheetLineTagsAsyncWithHttpInfo (int? invoiceWorksheetLineId);
        
        /// <summary>
        /// Update an invoiceWorksheetLine
        /// </summary>
        /// <remarks>
        /// Updates an existing invoiceWorksheetLine using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheetLine to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateInvoiceWorksheetLineAsync (InvoiceWorksheetLine body);

        /// <summary>
        /// Update an invoiceWorksheetLine
        /// </summary>
        /// <remarks>
        /// Updates an existing invoiceWorksheetLine using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheetLine to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateInvoiceWorksheetLineAsyncWithHttpInfo (InvoiceWorksheetLine body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InvoiceWorksheetLineApi : IInvoiceWorksheetLineApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceWorksheetLineApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InvoiceWorksheetLineApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceWorksheetLineApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InvoiceWorksheetLineApi(Configuration configuration = null)
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
        /// Create an invoiceWorksheetLine Inserts a new invoiceWorksheetLine using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheetLine to be inserted.</param> 
        /// <returns>InvoiceWorksheetLine</returns>
        public InvoiceWorksheetLine AddInvoiceWorksheetLine (InvoiceWorksheetLine body)
        {
             ApiResponse<InvoiceWorksheetLine> localVarResponse = AddInvoiceWorksheetLineWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an invoiceWorksheetLine Inserts a new invoiceWorksheetLine using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheetLine to be inserted.</param> 
        /// <returns>ApiResponse of InvoiceWorksheetLine</returns>
        public ApiResponse< InvoiceWorksheetLine > AddInvoiceWorksheetLineWithHttpInfo (InvoiceWorksheetLine body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling InvoiceWorksheetLineApi->AddInvoiceWorksheetLine");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InvoiceWorksheetLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvoiceWorksheetLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceWorksheetLine)));
            
        }

        
        /// <summary>
        /// Create an invoiceWorksheetLine Inserts a new invoiceWorksheetLine using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheetLine to be inserted.</param>
        /// <returns>Task of InvoiceWorksheetLine</returns>
        public async System.Threading.Tasks.Task<InvoiceWorksheetLine> AddInvoiceWorksheetLineAsync (InvoiceWorksheetLine body)
        {
             ApiResponse<InvoiceWorksheetLine> localVarResponse = await AddInvoiceWorksheetLineAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an invoiceWorksheetLine Inserts a new invoiceWorksheetLine using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheetLine to be inserted.</param>
        /// <returns>Task of ApiResponse (InvoiceWorksheetLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InvoiceWorksheetLine>> AddInvoiceWorksheetLineAsyncWithHttpInfo (InvoiceWorksheetLine body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddInvoiceWorksheetLine");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InvoiceWorksheetLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvoiceWorksheetLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceWorksheetLine)));
            
        }
        
        /// <summary>
        /// Add new audit for an invoiceWorksheetLine Adds an audit to an existing invoiceWorksheetLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to add an audit to</param> 
        /// <param name="invoiceWorksheetLineAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddInvoiceWorksheetLineAudit (int? invoiceWorksheetLineId, string invoiceWorksheetLineAudit)
        {
             AddInvoiceWorksheetLineAuditWithHttpInfo(invoiceWorksheetLineId, invoiceWorksheetLineAudit);
        }

        /// <summary>
        /// Add new audit for an invoiceWorksheetLine Adds an audit to an existing invoiceWorksheetLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to add an audit to</param> 
        /// <param name="invoiceWorksheetLineAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddInvoiceWorksheetLineAuditWithHttpInfo (int? invoiceWorksheetLineId, string invoiceWorksheetLineAudit)
        {
            
            // verify the required parameter 'invoiceWorksheetLineId' is set
            if (invoiceWorksheetLineId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineId' when calling InvoiceWorksheetLineApi->AddInvoiceWorksheetLineAudit");
            
            // verify the required parameter 'invoiceWorksheetLineAudit' is set
            if (invoiceWorksheetLineAudit == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineAudit' when calling InvoiceWorksheetLineApi->AddInvoiceWorksheetLineAudit");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine/{invoiceWorksheetLineId}/audit/{invoiceWorksheetLineAudit}";
    
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
            if (invoiceWorksheetLineId != null) localVarPathParams.Add("invoiceWorksheetLineId", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineId)); // path parameter
            if (invoiceWorksheetLineAudit != null) localVarPathParams.Add("invoiceWorksheetLineAudit", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetLineAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetLineAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an invoiceWorksheetLine Adds an audit to an existing invoiceWorksheetLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to add an audit to</param>
        /// <param name="invoiceWorksheetLineAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddInvoiceWorksheetLineAuditAsync (int? invoiceWorksheetLineId, string invoiceWorksheetLineAudit)
        {
             await AddInvoiceWorksheetLineAuditAsyncWithHttpInfo(invoiceWorksheetLineId, invoiceWorksheetLineAudit);

        }

        /// <summary>
        /// Add new audit for an invoiceWorksheetLine Adds an audit to an existing invoiceWorksheetLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to add an audit to</param>
        /// <param name="invoiceWorksheetLineAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddInvoiceWorksheetLineAuditAsyncWithHttpInfo (int? invoiceWorksheetLineId, string invoiceWorksheetLineAudit)
        {
            // verify the required parameter 'invoiceWorksheetLineId' is set
            if (invoiceWorksheetLineId == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineId' when calling AddInvoiceWorksheetLineAudit");
            // verify the required parameter 'invoiceWorksheetLineAudit' is set
            if (invoiceWorksheetLineAudit == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineAudit' when calling AddInvoiceWorksheetLineAudit");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine/{invoiceWorksheetLineId}/audit/{invoiceWorksheetLineAudit}";
    
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
            if (invoiceWorksheetLineId != null) localVarPathParams.Add("invoiceWorksheetLineId", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineId)); // path parameter
            if (invoiceWorksheetLineAudit != null) localVarPathParams.Add("invoiceWorksheetLineAudit", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetLineAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetLineAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an invoiceWorksheetLine. Adds a tag to an existing invoiceWorksheetLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to add a tag to</param> 
        /// <param name="invoiceWorksheetLineTag">The tag to add</param> 
        /// <returns></returns>
        public void AddInvoiceWorksheetLineTag (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag)
        {
             AddInvoiceWorksheetLineTagWithHttpInfo(invoiceWorksheetLineId, invoiceWorksheetLineTag);
        }

        /// <summary>
        /// Add new tags for an invoiceWorksheetLine. Adds a tag to an existing invoiceWorksheetLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to add a tag to</param> 
        /// <param name="invoiceWorksheetLineTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddInvoiceWorksheetLineTagWithHttpInfo (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag)
        {
            
            // verify the required parameter 'invoiceWorksheetLineId' is set
            if (invoiceWorksheetLineId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineId' when calling InvoiceWorksheetLineApi->AddInvoiceWorksheetLineTag");
            
            // verify the required parameter 'invoiceWorksheetLineTag' is set
            if (invoiceWorksheetLineTag == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineTag' when calling InvoiceWorksheetLineApi->AddInvoiceWorksheetLineTag");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine/{invoiceWorksheetLineId}/tag/{invoiceWorksheetLineTag}";
    
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
            if (invoiceWorksheetLineId != null) localVarPathParams.Add("invoiceWorksheetLineId", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineId)); // path parameter
            if (invoiceWorksheetLineTag != null) localVarPathParams.Add("invoiceWorksheetLineTag", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetLineTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetLineTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an invoiceWorksheetLine. Adds a tag to an existing invoiceWorksheetLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to add a tag to</param>
        /// <param name="invoiceWorksheetLineTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddInvoiceWorksheetLineTagAsync (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag)
        {
             await AddInvoiceWorksheetLineTagAsyncWithHttpInfo(invoiceWorksheetLineId, invoiceWorksheetLineTag);

        }

        /// <summary>
        /// Add new tags for an invoiceWorksheetLine. Adds a tag to an existing invoiceWorksheetLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to add a tag to</param>
        /// <param name="invoiceWorksheetLineTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddInvoiceWorksheetLineTagAsyncWithHttpInfo (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag)
        {
            // verify the required parameter 'invoiceWorksheetLineId' is set
            if (invoiceWorksheetLineId == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineId' when calling AddInvoiceWorksheetLineTag");
            // verify the required parameter 'invoiceWorksheetLineTag' is set
            if (invoiceWorksheetLineTag == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineTag' when calling AddInvoiceWorksheetLineTag");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine/{invoiceWorksheetLineId}/tag/{invoiceWorksheetLineTag}";
    
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
            if (invoiceWorksheetLineId != null) localVarPathParams.Add("invoiceWorksheetLineId", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineId)); // path parameter
            if (invoiceWorksheetLineTag != null) localVarPathParams.Add("invoiceWorksheetLineTag", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetLineTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInvoiceWorksheetLineTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an invoiceWorksheetLine Deletes the invoiceWorksheetLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be deleted.</param> 
        /// <returns></returns>
        public void DeleteInvoiceWorksheetLine (int? invoiceWorksheetLineId)
        {
             DeleteInvoiceWorksheetLineWithHttpInfo(invoiceWorksheetLineId);
        }

        /// <summary>
        /// Delete an invoiceWorksheetLine Deletes the invoiceWorksheetLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteInvoiceWorksheetLineWithHttpInfo (int? invoiceWorksheetLineId)
        {
            
            // verify the required parameter 'invoiceWorksheetLineId' is set
            if (invoiceWorksheetLineId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineId' when calling InvoiceWorksheetLineApi->DeleteInvoiceWorksheetLine");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine/{invoiceWorksheetLineId}";
    
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
            if (invoiceWorksheetLineId != null) localVarPathParams.Add("invoiceWorksheetLineId", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvoiceWorksheetLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvoiceWorksheetLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an invoiceWorksheetLine Deletes the invoiceWorksheetLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteInvoiceWorksheetLineAsync (int? invoiceWorksheetLineId)
        {
             await DeleteInvoiceWorksheetLineAsyncWithHttpInfo(invoiceWorksheetLineId);

        }

        /// <summary>
        /// Delete an invoiceWorksheetLine Deletes the invoiceWorksheetLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInvoiceWorksheetLineAsyncWithHttpInfo (int? invoiceWorksheetLineId)
        {
            // verify the required parameter 'invoiceWorksheetLineId' is set
            if (invoiceWorksheetLineId == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineId' when calling DeleteInvoiceWorksheetLine");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine/{invoiceWorksheetLineId}";
    
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
            if (invoiceWorksheetLineId != null) localVarPathParams.Add("invoiceWorksheetLineId", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvoiceWorksheetLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvoiceWorksheetLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an invoiceWorksheetLine. Deletes an existing invoiceWorksheetLine tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to remove tag from</param> 
        /// <param name="invoiceWorksheetLineTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteInvoiceWorksheetLineTag (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag)
        {
             DeleteInvoiceWorksheetLineTagWithHttpInfo(invoiceWorksheetLineId, invoiceWorksheetLineTag);
        }

        /// <summary>
        /// Delete a tag for an invoiceWorksheetLine. Deletes an existing invoiceWorksheetLine tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to remove tag from</param> 
        /// <param name="invoiceWorksheetLineTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteInvoiceWorksheetLineTagWithHttpInfo (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag)
        {
            
            // verify the required parameter 'invoiceWorksheetLineId' is set
            if (invoiceWorksheetLineId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineId' when calling InvoiceWorksheetLineApi->DeleteInvoiceWorksheetLineTag");
            
            // verify the required parameter 'invoiceWorksheetLineTag' is set
            if (invoiceWorksheetLineTag == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineTag' when calling InvoiceWorksheetLineApi->DeleteInvoiceWorksheetLineTag");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine/{invoiceWorksheetLineId}/tag/{invoiceWorksheetLineTag}";
    
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
            if (invoiceWorksheetLineId != null) localVarPathParams.Add("invoiceWorksheetLineId", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineId)); // path parameter
            if (invoiceWorksheetLineTag != null) localVarPathParams.Add("invoiceWorksheetLineTag", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvoiceWorksheetLineTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvoiceWorksheetLineTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an invoiceWorksheetLine. Deletes an existing invoiceWorksheetLine tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to remove tag from</param>
        /// <param name="invoiceWorksheetLineTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteInvoiceWorksheetLineTagAsync (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag)
        {
             await DeleteInvoiceWorksheetLineTagAsyncWithHttpInfo(invoiceWorksheetLineId, invoiceWorksheetLineTag);

        }

        /// <summary>
        /// Delete a tag for an invoiceWorksheetLine. Deletes an existing invoiceWorksheetLine tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to remove tag from</param>
        /// <param name="invoiceWorksheetLineTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInvoiceWorksheetLineTagAsyncWithHttpInfo (int? invoiceWorksheetLineId, string invoiceWorksheetLineTag)
        {
            // verify the required parameter 'invoiceWorksheetLineId' is set
            if (invoiceWorksheetLineId == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineId' when calling DeleteInvoiceWorksheetLineTag");
            // verify the required parameter 'invoiceWorksheetLineTag' is set
            if (invoiceWorksheetLineTag == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineTag' when calling DeleteInvoiceWorksheetLineTag");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine/{invoiceWorksheetLineId}/tag/{invoiceWorksheetLineTag}";
    
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
            if (invoiceWorksheetLineId != null) localVarPathParams.Add("invoiceWorksheetLineId", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineId)); // path parameter
            if (invoiceWorksheetLineTag != null) localVarPathParams.Add("invoiceWorksheetLineTag", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvoiceWorksheetLineTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInvoiceWorksheetLineTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an invoiceWorksheetLine by id Returns a duplicated invoiceWorksheetLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be duplicated.</param> 
        /// <returns>InvoiceWorksheetLine</returns>
        public InvoiceWorksheetLine GetDuplicateInvoiceWorksheetLineById (int? invoiceWorksheetLineId)
        {
             ApiResponse<InvoiceWorksheetLine> localVarResponse = GetDuplicateInvoiceWorksheetLineByIdWithHttpInfo(invoiceWorksheetLineId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an invoiceWorksheetLine by id Returns a duplicated invoiceWorksheetLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be duplicated.</param> 
        /// <returns>ApiResponse of InvoiceWorksheetLine</returns>
        public ApiResponse< InvoiceWorksheetLine > GetDuplicateInvoiceWorksheetLineByIdWithHttpInfo (int? invoiceWorksheetLineId)
        {
            
            // verify the required parameter 'invoiceWorksheetLineId' is set
            if (invoiceWorksheetLineId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineId' when calling InvoiceWorksheetLineApi->GetDuplicateInvoiceWorksheetLineById");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine/duplicate/{invoiceWorksheetLineId}";
    
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
            if (invoiceWorksheetLineId != null) localVarPathParams.Add("invoiceWorksheetLineId", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInvoiceWorksheetLineById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInvoiceWorksheetLineById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InvoiceWorksheetLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvoiceWorksheetLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceWorksheetLine)));
            
        }

        
        /// <summary>
        /// Get a duplicated an invoiceWorksheetLine by id Returns a duplicated invoiceWorksheetLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be duplicated.</param>
        /// <returns>Task of InvoiceWorksheetLine</returns>
        public async System.Threading.Tasks.Task<InvoiceWorksheetLine> GetDuplicateInvoiceWorksheetLineByIdAsync (int? invoiceWorksheetLineId)
        {
             ApiResponse<InvoiceWorksheetLine> localVarResponse = await GetDuplicateInvoiceWorksheetLineByIdAsyncWithHttpInfo(invoiceWorksheetLineId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an invoiceWorksheetLine by id Returns a duplicated invoiceWorksheetLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be duplicated.</param>
        /// <returns>Task of ApiResponse (InvoiceWorksheetLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InvoiceWorksheetLine>> GetDuplicateInvoiceWorksheetLineByIdAsyncWithHttpInfo (int? invoiceWorksheetLineId)
        {
            // verify the required parameter 'invoiceWorksheetLineId' is set
            if (invoiceWorksheetLineId == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineId' when calling GetDuplicateInvoiceWorksheetLineById");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine/duplicate/{invoiceWorksheetLineId}";
    
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
            if (invoiceWorksheetLineId != null) localVarPathParams.Add("invoiceWorksheetLineId", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInvoiceWorksheetLineById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInvoiceWorksheetLineById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InvoiceWorksheetLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvoiceWorksheetLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceWorksheetLine)));
            
        }
        
        /// <summary>
        /// Search invoiceWorksheetLines by filter Returns the list of invoiceWorksheetLines that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;InvoiceWorksheetLine&gt;</returns>
        public List<InvoiceWorksheetLine> GetInvoiceWorksheetLineByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<InvoiceWorksheetLine>> localVarResponse = GetInvoiceWorksheetLineByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search invoiceWorksheetLines by filter Returns the list of invoiceWorksheetLines that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;InvoiceWorksheetLine&gt;</returns>
        public ApiResponse< List<InvoiceWorksheetLine> > GetInvoiceWorksheetLineByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/invoiceWorksheetLine/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetLineByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetLineByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<InvoiceWorksheetLine>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InvoiceWorksheetLine>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InvoiceWorksheetLine>)));
            
        }

        
        /// <summary>
        /// Search invoiceWorksheetLines by filter Returns the list of invoiceWorksheetLines that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;InvoiceWorksheetLine&gt;</returns>
        public async System.Threading.Tasks.Task<List<InvoiceWorksheetLine>> GetInvoiceWorksheetLineByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<InvoiceWorksheetLine>> localVarResponse = await GetInvoiceWorksheetLineByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search invoiceWorksheetLines by filter Returns the list of invoiceWorksheetLines that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;InvoiceWorksheetLine&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InvoiceWorksheetLine>>> GetInvoiceWorksheetLineByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/invoiceWorksheetLine/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetLineByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetLineByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<InvoiceWorksheetLine>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InvoiceWorksheetLine>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InvoiceWorksheetLine>)));
            
        }
        
        /// <summary>
        /// Get an invoiceWorksheetLine by id Returns the invoiceWorksheetLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be returned.</param> 
        /// <returns>InvoiceWorksheetLine</returns>
        public InvoiceWorksheetLine GetInvoiceWorksheetLineById (int? invoiceWorksheetLineId)
        {
             ApiResponse<InvoiceWorksheetLine> localVarResponse = GetInvoiceWorksheetLineByIdWithHttpInfo(invoiceWorksheetLineId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an invoiceWorksheetLine by id Returns the invoiceWorksheetLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be returned.</param> 
        /// <returns>ApiResponse of InvoiceWorksheetLine</returns>
        public ApiResponse< InvoiceWorksheetLine > GetInvoiceWorksheetLineByIdWithHttpInfo (int? invoiceWorksheetLineId)
        {
            
            // verify the required parameter 'invoiceWorksheetLineId' is set
            if (invoiceWorksheetLineId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineId' when calling InvoiceWorksheetLineApi->GetInvoiceWorksheetLineById");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine/{invoiceWorksheetLineId}";
    
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
            if (invoiceWorksheetLineId != null) localVarPathParams.Add("invoiceWorksheetLineId", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetLineById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetLineById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InvoiceWorksheetLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvoiceWorksheetLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceWorksheetLine)));
            
        }

        
        /// <summary>
        /// Get an invoiceWorksheetLine by id Returns the invoiceWorksheetLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be returned.</param>
        /// <returns>Task of InvoiceWorksheetLine</returns>
        public async System.Threading.Tasks.Task<InvoiceWorksheetLine> GetInvoiceWorksheetLineByIdAsync (int? invoiceWorksheetLineId)
        {
             ApiResponse<InvoiceWorksheetLine> localVarResponse = await GetInvoiceWorksheetLineByIdAsyncWithHttpInfo(invoiceWorksheetLineId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an invoiceWorksheetLine by id Returns the invoiceWorksheetLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to be returned.</param>
        /// <returns>Task of ApiResponse (InvoiceWorksheetLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InvoiceWorksheetLine>> GetInvoiceWorksheetLineByIdAsyncWithHttpInfo (int? invoiceWorksheetLineId)
        {
            // verify the required parameter 'invoiceWorksheetLineId' is set
            if (invoiceWorksheetLineId == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineId' when calling GetInvoiceWorksheetLineById");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine/{invoiceWorksheetLineId}";
    
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
            if (invoiceWorksheetLineId != null) localVarPathParams.Add("invoiceWorksheetLineId", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetLineById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetLineById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InvoiceWorksheetLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InvoiceWorksheetLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InvoiceWorksheetLine)));
            
        }
        
        /// <summary>
        /// Get the tags for an invoiceWorksheetLine. Get all existing invoiceWorksheetLine tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to get tags for</param> 
        /// <returns></returns>
        public void GetInvoiceWorksheetLineTags (int? invoiceWorksheetLineId)
        {
             GetInvoiceWorksheetLineTagsWithHttpInfo(invoiceWorksheetLineId);
        }

        /// <summary>
        /// Get the tags for an invoiceWorksheetLine. Get all existing invoiceWorksheetLine tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetInvoiceWorksheetLineTagsWithHttpInfo (int? invoiceWorksheetLineId)
        {
            
            // verify the required parameter 'invoiceWorksheetLineId' is set
            if (invoiceWorksheetLineId == null)
                throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineId' when calling InvoiceWorksheetLineApi->GetInvoiceWorksheetLineTags");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine/{invoiceWorksheetLineId}/tag";
    
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
            if (invoiceWorksheetLineId != null) localVarPathParams.Add("invoiceWorksheetLineId", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetLineTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetLineTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an invoiceWorksheetLine. Get all existing invoiceWorksheetLine tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetInvoiceWorksheetLineTagsAsync (int? invoiceWorksheetLineId)
        {
             await GetInvoiceWorksheetLineTagsAsyncWithHttpInfo(invoiceWorksheetLineId);

        }

        /// <summary>
        /// Get the tags for an invoiceWorksheetLine. Get all existing invoiceWorksheetLine tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="invoiceWorksheetLineId">Id of the invoiceWorksheetLine to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetInvoiceWorksheetLineTagsAsyncWithHttpInfo (int? invoiceWorksheetLineId)
        {
            // verify the required parameter 'invoiceWorksheetLineId' is set
            if (invoiceWorksheetLineId == null) throw new ApiException(400, "Missing required parameter 'invoiceWorksheetLineId' when calling GetInvoiceWorksheetLineTags");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine/{invoiceWorksheetLineId}/tag";
    
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
            if (invoiceWorksheetLineId != null) localVarPathParams.Add("invoiceWorksheetLineId", Configuration.ApiClient.ParameterToString(invoiceWorksheetLineId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetLineTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInvoiceWorksheetLineTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an invoiceWorksheetLine Updates an existing invoiceWorksheetLine using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheetLine to be updated.</param> 
        /// <returns></returns>
        public void UpdateInvoiceWorksheetLine (InvoiceWorksheetLine body)
        {
             UpdateInvoiceWorksheetLineWithHttpInfo(body);
        }

        /// <summary>
        /// Update an invoiceWorksheetLine Updates an existing invoiceWorksheetLine using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheetLine to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateInvoiceWorksheetLineWithHttpInfo (InvoiceWorksheetLine body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling InvoiceWorksheetLineApi->UpdateInvoiceWorksheetLine");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateInvoiceWorksheetLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateInvoiceWorksheetLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an invoiceWorksheetLine Updates an existing invoiceWorksheetLine using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheetLine to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateInvoiceWorksheetLineAsync (InvoiceWorksheetLine body)
        {
             await UpdateInvoiceWorksheetLineAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an invoiceWorksheetLine Updates an existing invoiceWorksheetLine using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">InvoiceWorksheetLine to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateInvoiceWorksheetLineAsyncWithHttpInfo (InvoiceWorksheetLine body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateInvoiceWorksheetLine");
            
    
            var localVarPath = "/beta/invoiceWorksheetLine";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateInvoiceWorksheetLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateInvoiceWorksheetLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
