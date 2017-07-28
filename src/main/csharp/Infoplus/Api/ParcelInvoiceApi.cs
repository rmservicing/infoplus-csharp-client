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
    public interface IParcelInvoiceApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for a parcelInvoice
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing parcelInvoice.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to add an audit to</param>
        /// <param name="parcelInvoiceAudit">The audit to add</param>
        /// <returns></returns>
        void AddParcelInvoiceAudit (int? parcelInvoiceId, string parcelInvoiceAudit);
  
        /// <summary>
        /// Add new audit for a parcelInvoice
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing parcelInvoice.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to add an audit to</param>
        /// <param name="parcelInvoiceAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddParcelInvoiceAuditWithHttpInfo (int? parcelInvoiceId, string parcelInvoiceAudit);
        
        /// <summary>
        /// Add new tags for a parcelInvoice.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing parcelInvoice.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to add a tag to</param>
        /// <param name="parcelInvoiceTag">The tag to add</param>
        /// <returns></returns>
        void AddParcelInvoiceTag (int? parcelInvoiceId, string parcelInvoiceTag);
  
        /// <summary>
        /// Add new tags for a parcelInvoice.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing parcelInvoice.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to add a tag to</param>
        /// <param name="parcelInvoiceTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddParcelInvoiceTagWithHttpInfo (int? parcelInvoiceId, string parcelInvoiceTag);
        
        /// <summary>
        /// Delete a parcelInvoice
        /// </summary>
        /// <remarks>
        /// Deletes the parcelInvoice identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be deleted.</param>
        /// <returns></returns>
        void DeleteParcelInvoice (int? parcelInvoiceId);
  
        /// <summary>
        /// Delete a parcelInvoice
        /// </summary>
        /// <remarks>
        /// Deletes the parcelInvoice identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteParcelInvoiceWithHttpInfo (int? parcelInvoiceId);
        
        /// <summary>
        /// Delete a tag for a parcelInvoice.
        /// </summary>
        /// <remarks>
        /// Deletes an existing parcelInvoice tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to remove tag from</param>
        /// <param name="parcelInvoiceTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteParcelInvoiceTag (int? parcelInvoiceId, string parcelInvoiceTag);
  
        /// <summary>
        /// Delete a tag for a parcelInvoice.
        /// </summary>
        /// <remarks>
        /// Deletes an existing parcelInvoice tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to remove tag from</param>
        /// <param name="parcelInvoiceTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteParcelInvoiceTagWithHttpInfo (int? parcelInvoiceId, string parcelInvoiceTag);
        
        /// <summary>
        /// Get a duplicated a parcelInvoice by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated parcelInvoice identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be duplicated.</param>
        /// <returns>ParcelInvoice</returns>
        ParcelInvoice GetDuplicateParcelInvoiceById (int? parcelInvoiceId);
  
        /// <summary>
        /// Get a duplicated a parcelInvoice by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated parcelInvoice identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be duplicated.</param>
        /// <returns>ApiResponse of ParcelInvoice</returns>
        ApiResponse<ParcelInvoice> GetDuplicateParcelInvoiceByIdWithHttpInfo (int? parcelInvoiceId);
        
        /// <summary>
        /// Search parcelInvoices by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of parcelInvoices that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ParcelInvoice&gt;</returns>
        List<ParcelInvoice> GetParcelInvoiceByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search parcelInvoices by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of parcelInvoices that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ParcelInvoice&gt;</returns>
        ApiResponse<List<ParcelInvoice>> GetParcelInvoiceByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a parcelInvoice by id
        /// </summary>
        /// <remarks>
        /// Returns the parcelInvoice identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be returned.</param>
        /// <returns>ParcelInvoice</returns>
        ParcelInvoice GetParcelInvoiceById (int? parcelInvoiceId);
  
        /// <summary>
        /// Get a parcelInvoice by id
        /// </summary>
        /// <remarks>
        /// Returns the parcelInvoice identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be returned.</param>
        /// <returns>ApiResponse of ParcelInvoice</returns>
        ApiResponse<ParcelInvoice> GetParcelInvoiceByIdWithHttpInfo (int? parcelInvoiceId);
        
        /// <summary>
        /// Get the tags for a parcelInvoice.
        /// </summary>
        /// <remarks>
        /// Get all existing parcelInvoice tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to get tags for</param>
        /// <returns></returns>
        void GetParcelInvoiceTags (int? parcelInvoiceId);
  
        /// <summary>
        /// Get the tags for a parcelInvoice.
        /// </summary>
        /// <remarks>
        /// Get all existing parcelInvoice tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetParcelInvoiceTagsWithHttpInfo (int? parcelInvoiceId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for a parcelInvoice
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing parcelInvoice.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to add an audit to</param>
        /// <param name="parcelInvoiceAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddParcelInvoiceAuditAsync (int? parcelInvoiceId, string parcelInvoiceAudit);

        /// <summary>
        /// Add new audit for a parcelInvoice
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing parcelInvoice.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to add an audit to</param>
        /// <param name="parcelInvoiceAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddParcelInvoiceAuditAsyncWithHttpInfo (int? parcelInvoiceId, string parcelInvoiceAudit);
        
        /// <summary>
        /// Add new tags for a parcelInvoice.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing parcelInvoice.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to add a tag to</param>
        /// <param name="parcelInvoiceTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddParcelInvoiceTagAsync (int? parcelInvoiceId, string parcelInvoiceTag);

        /// <summary>
        /// Add new tags for a parcelInvoice.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing parcelInvoice.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to add a tag to</param>
        /// <param name="parcelInvoiceTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddParcelInvoiceTagAsyncWithHttpInfo (int? parcelInvoiceId, string parcelInvoiceTag);
        
        /// <summary>
        /// Delete a parcelInvoice
        /// </summary>
        /// <remarks>
        /// Deletes the parcelInvoice identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteParcelInvoiceAsync (int? parcelInvoiceId);

        /// <summary>
        /// Delete a parcelInvoice
        /// </summary>
        /// <remarks>
        /// Deletes the parcelInvoice identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteParcelInvoiceAsyncWithHttpInfo (int? parcelInvoiceId);
        
        /// <summary>
        /// Delete a tag for a parcelInvoice.
        /// </summary>
        /// <remarks>
        /// Deletes an existing parcelInvoice tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to remove tag from</param>
        /// <param name="parcelInvoiceTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteParcelInvoiceTagAsync (int? parcelInvoiceId, string parcelInvoiceTag);

        /// <summary>
        /// Delete a tag for a parcelInvoice.
        /// </summary>
        /// <remarks>
        /// Deletes an existing parcelInvoice tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to remove tag from</param>
        /// <param name="parcelInvoiceTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteParcelInvoiceTagAsyncWithHttpInfo (int? parcelInvoiceId, string parcelInvoiceTag);
        
        /// <summary>
        /// Get a duplicated a parcelInvoice by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated parcelInvoice identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be duplicated.</param>
        /// <returns>Task of ParcelInvoice</returns>
        System.Threading.Tasks.Task<ParcelInvoice> GetDuplicateParcelInvoiceByIdAsync (int? parcelInvoiceId);

        /// <summary>
        /// Get a duplicated a parcelInvoice by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated parcelInvoice identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be duplicated.</param>
        /// <returns>Task of ApiResponse (ParcelInvoice)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParcelInvoice>> GetDuplicateParcelInvoiceByIdAsyncWithHttpInfo (int? parcelInvoiceId);
        
        /// <summary>
        /// Search parcelInvoices by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of parcelInvoices that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ParcelInvoice&gt;</returns>
        System.Threading.Tasks.Task<List<ParcelInvoice>> GetParcelInvoiceByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search parcelInvoices by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of parcelInvoices that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ParcelInvoice&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ParcelInvoice>>> GetParcelInvoiceByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a parcelInvoice by id
        /// </summary>
        /// <remarks>
        /// Returns the parcelInvoice identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be returned.</param>
        /// <returns>Task of ParcelInvoice</returns>
        System.Threading.Tasks.Task<ParcelInvoice> GetParcelInvoiceByIdAsync (int? parcelInvoiceId);

        /// <summary>
        /// Get a parcelInvoice by id
        /// </summary>
        /// <remarks>
        /// Returns the parcelInvoice identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be returned.</param>
        /// <returns>Task of ApiResponse (ParcelInvoice)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParcelInvoice>> GetParcelInvoiceByIdAsyncWithHttpInfo (int? parcelInvoiceId);
        
        /// <summary>
        /// Get the tags for a parcelInvoice.
        /// </summary>
        /// <remarks>
        /// Get all existing parcelInvoice tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetParcelInvoiceTagsAsync (int? parcelInvoiceId);

        /// <summary>
        /// Get the tags for a parcelInvoice.
        /// </summary>
        /// <remarks>
        /// Get all existing parcelInvoice tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetParcelInvoiceTagsAsyncWithHttpInfo (int? parcelInvoiceId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ParcelInvoiceApi : IParcelInvoiceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelInvoiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ParcelInvoiceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelInvoiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ParcelInvoiceApi(Configuration configuration = null)
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
        /// Add new audit for a parcelInvoice Adds an audit to an existing parcelInvoice.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to add an audit to</param> 
        /// <param name="parcelInvoiceAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddParcelInvoiceAudit (int? parcelInvoiceId, string parcelInvoiceAudit)
        {
             AddParcelInvoiceAuditWithHttpInfo(parcelInvoiceId, parcelInvoiceAudit);
        }

        /// <summary>
        /// Add new audit for a parcelInvoice Adds an audit to an existing parcelInvoice.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to add an audit to</param> 
        /// <param name="parcelInvoiceAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddParcelInvoiceAuditWithHttpInfo (int? parcelInvoiceId, string parcelInvoiceAudit)
        {
            
            // verify the required parameter 'parcelInvoiceId' is set
            if (parcelInvoiceId == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceId' when calling ParcelInvoiceApi->AddParcelInvoiceAudit");
            
            // verify the required parameter 'parcelInvoiceAudit' is set
            if (parcelInvoiceAudit == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceAudit' when calling ParcelInvoiceApi->AddParcelInvoiceAudit");
            
    
            var localVarPath = "/beta/parcelInvoice/{parcelInvoiceId}/audit/{parcelInvoiceAudit}";
    
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
            if (parcelInvoiceId != null) localVarPathParams.Add("parcelInvoiceId", Configuration.ApiClient.ParameterToString(parcelInvoiceId)); // path parameter
            if (parcelInvoiceAudit != null) localVarPathParams.Add("parcelInvoiceAudit", Configuration.ApiClient.ParameterToString(parcelInvoiceAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddParcelInvoiceAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddParcelInvoiceAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a parcelInvoice Adds an audit to an existing parcelInvoice.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to add an audit to</param>
        /// <param name="parcelInvoiceAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddParcelInvoiceAuditAsync (int? parcelInvoiceId, string parcelInvoiceAudit)
        {
             await AddParcelInvoiceAuditAsyncWithHttpInfo(parcelInvoiceId, parcelInvoiceAudit);

        }

        /// <summary>
        /// Add new audit for a parcelInvoice Adds an audit to an existing parcelInvoice.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to add an audit to</param>
        /// <param name="parcelInvoiceAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddParcelInvoiceAuditAsyncWithHttpInfo (int? parcelInvoiceId, string parcelInvoiceAudit)
        {
            // verify the required parameter 'parcelInvoiceId' is set
            if (parcelInvoiceId == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceId' when calling AddParcelInvoiceAudit");
            // verify the required parameter 'parcelInvoiceAudit' is set
            if (parcelInvoiceAudit == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceAudit' when calling AddParcelInvoiceAudit");
            
    
            var localVarPath = "/beta/parcelInvoice/{parcelInvoiceId}/audit/{parcelInvoiceAudit}";
    
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
            if (parcelInvoiceId != null) localVarPathParams.Add("parcelInvoiceId", Configuration.ApiClient.ParameterToString(parcelInvoiceId)); // path parameter
            if (parcelInvoiceAudit != null) localVarPathParams.Add("parcelInvoiceAudit", Configuration.ApiClient.ParameterToString(parcelInvoiceAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddParcelInvoiceAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddParcelInvoiceAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a parcelInvoice. Adds a tag to an existing parcelInvoice.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to add a tag to</param> 
        /// <param name="parcelInvoiceTag">The tag to add</param> 
        /// <returns></returns>
        public void AddParcelInvoiceTag (int? parcelInvoiceId, string parcelInvoiceTag)
        {
             AddParcelInvoiceTagWithHttpInfo(parcelInvoiceId, parcelInvoiceTag);
        }

        /// <summary>
        /// Add new tags for a parcelInvoice. Adds a tag to an existing parcelInvoice.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to add a tag to</param> 
        /// <param name="parcelInvoiceTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddParcelInvoiceTagWithHttpInfo (int? parcelInvoiceId, string parcelInvoiceTag)
        {
            
            // verify the required parameter 'parcelInvoiceId' is set
            if (parcelInvoiceId == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceId' when calling ParcelInvoiceApi->AddParcelInvoiceTag");
            
            // verify the required parameter 'parcelInvoiceTag' is set
            if (parcelInvoiceTag == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceTag' when calling ParcelInvoiceApi->AddParcelInvoiceTag");
            
    
            var localVarPath = "/beta/parcelInvoice/{parcelInvoiceId}/tag/{parcelInvoiceTag}";
    
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
            if (parcelInvoiceId != null) localVarPathParams.Add("parcelInvoiceId", Configuration.ApiClient.ParameterToString(parcelInvoiceId)); // path parameter
            if (parcelInvoiceTag != null) localVarPathParams.Add("parcelInvoiceTag", Configuration.ApiClient.ParameterToString(parcelInvoiceTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddParcelInvoiceTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddParcelInvoiceTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a parcelInvoice. Adds a tag to an existing parcelInvoice.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to add a tag to</param>
        /// <param name="parcelInvoiceTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddParcelInvoiceTagAsync (int? parcelInvoiceId, string parcelInvoiceTag)
        {
             await AddParcelInvoiceTagAsyncWithHttpInfo(parcelInvoiceId, parcelInvoiceTag);

        }

        /// <summary>
        /// Add new tags for a parcelInvoice. Adds a tag to an existing parcelInvoice.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to add a tag to</param>
        /// <param name="parcelInvoiceTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddParcelInvoiceTagAsyncWithHttpInfo (int? parcelInvoiceId, string parcelInvoiceTag)
        {
            // verify the required parameter 'parcelInvoiceId' is set
            if (parcelInvoiceId == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceId' when calling AddParcelInvoiceTag");
            // verify the required parameter 'parcelInvoiceTag' is set
            if (parcelInvoiceTag == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceTag' when calling AddParcelInvoiceTag");
            
    
            var localVarPath = "/beta/parcelInvoice/{parcelInvoiceId}/tag/{parcelInvoiceTag}";
    
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
            if (parcelInvoiceId != null) localVarPathParams.Add("parcelInvoiceId", Configuration.ApiClient.ParameterToString(parcelInvoiceId)); // path parameter
            if (parcelInvoiceTag != null) localVarPathParams.Add("parcelInvoiceTag", Configuration.ApiClient.ParameterToString(parcelInvoiceTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddParcelInvoiceTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddParcelInvoiceTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a parcelInvoice Deletes the parcelInvoice identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be deleted.</param> 
        /// <returns></returns>
        public void DeleteParcelInvoice (int? parcelInvoiceId)
        {
             DeleteParcelInvoiceWithHttpInfo(parcelInvoiceId);
        }

        /// <summary>
        /// Delete a parcelInvoice Deletes the parcelInvoice identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteParcelInvoiceWithHttpInfo (int? parcelInvoiceId)
        {
            
            // verify the required parameter 'parcelInvoiceId' is set
            if (parcelInvoiceId == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceId' when calling ParcelInvoiceApi->DeleteParcelInvoice");
            
    
            var localVarPath = "/beta/parcelInvoice/{parcelInvoiceId}";
    
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
            if (parcelInvoiceId != null) localVarPathParams.Add("parcelInvoiceId", Configuration.ApiClient.ParameterToString(parcelInvoiceId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteParcelInvoice: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteParcelInvoice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a parcelInvoice Deletes the parcelInvoice identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteParcelInvoiceAsync (int? parcelInvoiceId)
        {
             await DeleteParcelInvoiceAsyncWithHttpInfo(parcelInvoiceId);

        }

        /// <summary>
        /// Delete a parcelInvoice Deletes the parcelInvoice identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteParcelInvoiceAsyncWithHttpInfo (int? parcelInvoiceId)
        {
            // verify the required parameter 'parcelInvoiceId' is set
            if (parcelInvoiceId == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceId' when calling DeleteParcelInvoice");
            
    
            var localVarPath = "/beta/parcelInvoice/{parcelInvoiceId}";
    
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
            if (parcelInvoiceId != null) localVarPathParams.Add("parcelInvoiceId", Configuration.ApiClient.ParameterToString(parcelInvoiceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteParcelInvoice: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteParcelInvoice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a parcelInvoice. Deletes an existing parcelInvoice tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to remove tag from</param> 
        /// <param name="parcelInvoiceTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteParcelInvoiceTag (int? parcelInvoiceId, string parcelInvoiceTag)
        {
             DeleteParcelInvoiceTagWithHttpInfo(parcelInvoiceId, parcelInvoiceTag);
        }

        /// <summary>
        /// Delete a tag for a parcelInvoice. Deletes an existing parcelInvoice tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to remove tag from</param> 
        /// <param name="parcelInvoiceTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteParcelInvoiceTagWithHttpInfo (int? parcelInvoiceId, string parcelInvoiceTag)
        {
            
            // verify the required parameter 'parcelInvoiceId' is set
            if (parcelInvoiceId == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceId' when calling ParcelInvoiceApi->DeleteParcelInvoiceTag");
            
            // verify the required parameter 'parcelInvoiceTag' is set
            if (parcelInvoiceTag == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceTag' when calling ParcelInvoiceApi->DeleteParcelInvoiceTag");
            
    
            var localVarPath = "/beta/parcelInvoice/{parcelInvoiceId}/tag/{parcelInvoiceTag}";
    
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
            if (parcelInvoiceId != null) localVarPathParams.Add("parcelInvoiceId", Configuration.ApiClient.ParameterToString(parcelInvoiceId)); // path parameter
            if (parcelInvoiceTag != null) localVarPathParams.Add("parcelInvoiceTag", Configuration.ApiClient.ParameterToString(parcelInvoiceTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteParcelInvoiceTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteParcelInvoiceTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a parcelInvoice. Deletes an existing parcelInvoice tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to remove tag from</param>
        /// <param name="parcelInvoiceTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteParcelInvoiceTagAsync (int? parcelInvoiceId, string parcelInvoiceTag)
        {
             await DeleteParcelInvoiceTagAsyncWithHttpInfo(parcelInvoiceId, parcelInvoiceTag);

        }

        /// <summary>
        /// Delete a tag for a parcelInvoice. Deletes an existing parcelInvoice tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to remove tag from</param>
        /// <param name="parcelInvoiceTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteParcelInvoiceTagAsyncWithHttpInfo (int? parcelInvoiceId, string parcelInvoiceTag)
        {
            // verify the required parameter 'parcelInvoiceId' is set
            if (parcelInvoiceId == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceId' when calling DeleteParcelInvoiceTag");
            // verify the required parameter 'parcelInvoiceTag' is set
            if (parcelInvoiceTag == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceTag' when calling DeleteParcelInvoiceTag");
            
    
            var localVarPath = "/beta/parcelInvoice/{parcelInvoiceId}/tag/{parcelInvoiceTag}";
    
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
            if (parcelInvoiceId != null) localVarPathParams.Add("parcelInvoiceId", Configuration.ApiClient.ParameterToString(parcelInvoiceId)); // path parameter
            if (parcelInvoiceTag != null) localVarPathParams.Add("parcelInvoiceTag", Configuration.ApiClient.ParameterToString(parcelInvoiceTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteParcelInvoiceTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteParcelInvoiceTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a parcelInvoice by id Returns a duplicated parcelInvoice identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be duplicated.</param> 
        /// <returns>ParcelInvoice</returns>
        public ParcelInvoice GetDuplicateParcelInvoiceById (int? parcelInvoiceId)
        {
             ApiResponse<ParcelInvoice> localVarResponse = GetDuplicateParcelInvoiceByIdWithHttpInfo(parcelInvoiceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a parcelInvoice by id Returns a duplicated parcelInvoice identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be duplicated.</param> 
        /// <returns>ApiResponse of ParcelInvoice</returns>
        public ApiResponse< ParcelInvoice > GetDuplicateParcelInvoiceByIdWithHttpInfo (int? parcelInvoiceId)
        {
            
            // verify the required parameter 'parcelInvoiceId' is set
            if (parcelInvoiceId == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceId' when calling ParcelInvoiceApi->GetDuplicateParcelInvoiceById");
            
    
            var localVarPath = "/beta/parcelInvoice/duplicate/{parcelInvoiceId}";
    
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
            if (parcelInvoiceId != null) localVarPathParams.Add("parcelInvoiceId", Configuration.ApiClient.ParameterToString(parcelInvoiceId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateParcelInvoiceById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateParcelInvoiceById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParcelInvoice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelInvoice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelInvoice)));
            
        }

        
        /// <summary>
        /// Get a duplicated a parcelInvoice by id Returns a duplicated parcelInvoice identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be duplicated.</param>
        /// <returns>Task of ParcelInvoice</returns>
        public async System.Threading.Tasks.Task<ParcelInvoice> GetDuplicateParcelInvoiceByIdAsync (int? parcelInvoiceId)
        {
             ApiResponse<ParcelInvoice> localVarResponse = await GetDuplicateParcelInvoiceByIdAsyncWithHttpInfo(parcelInvoiceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a parcelInvoice by id Returns a duplicated parcelInvoice identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be duplicated.</param>
        /// <returns>Task of ApiResponse (ParcelInvoice)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParcelInvoice>> GetDuplicateParcelInvoiceByIdAsyncWithHttpInfo (int? parcelInvoiceId)
        {
            // verify the required parameter 'parcelInvoiceId' is set
            if (parcelInvoiceId == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceId' when calling GetDuplicateParcelInvoiceById");
            
    
            var localVarPath = "/beta/parcelInvoice/duplicate/{parcelInvoiceId}";
    
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
            if (parcelInvoiceId != null) localVarPathParams.Add("parcelInvoiceId", Configuration.ApiClient.ParameterToString(parcelInvoiceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateParcelInvoiceById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateParcelInvoiceById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParcelInvoice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelInvoice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelInvoice)));
            
        }
        
        /// <summary>
        /// Search parcelInvoices by filter Returns the list of parcelInvoices that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ParcelInvoice&gt;</returns>
        public List<ParcelInvoice> GetParcelInvoiceByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ParcelInvoice>> localVarResponse = GetParcelInvoiceByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search parcelInvoices by filter Returns the list of parcelInvoices that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ParcelInvoice&gt;</returns>
        public ApiResponse< List<ParcelInvoice> > GetParcelInvoiceByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/parcelInvoice/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ParcelInvoice>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ParcelInvoice>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ParcelInvoice>)));
            
        }

        
        /// <summary>
        /// Search parcelInvoices by filter Returns the list of parcelInvoices that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ParcelInvoice&gt;</returns>
        public async System.Threading.Tasks.Task<List<ParcelInvoice>> GetParcelInvoiceByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ParcelInvoice>> localVarResponse = await GetParcelInvoiceByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search parcelInvoices by filter Returns the list of parcelInvoices that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ParcelInvoice&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ParcelInvoice>>> GetParcelInvoiceByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/parcelInvoice/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ParcelInvoice>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ParcelInvoice>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ParcelInvoice>)));
            
        }
        
        /// <summary>
        /// Get a parcelInvoice by id Returns the parcelInvoice identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be returned.</param> 
        /// <returns>ParcelInvoice</returns>
        public ParcelInvoice GetParcelInvoiceById (int? parcelInvoiceId)
        {
             ApiResponse<ParcelInvoice> localVarResponse = GetParcelInvoiceByIdWithHttpInfo(parcelInvoiceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a parcelInvoice by id Returns the parcelInvoice identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be returned.</param> 
        /// <returns>ApiResponse of ParcelInvoice</returns>
        public ApiResponse< ParcelInvoice > GetParcelInvoiceByIdWithHttpInfo (int? parcelInvoiceId)
        {
            
            // verify the required parameter 'parcelInvoiceId' is set
            if (parcelInvoiceId == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceId' when calling ParcelInvoiceApi->GetParcelInvoiceById");
            
    
            var localVarPath = "/beta/parcelInvoice/{parcelInvoiceId}";
    
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
            if (parcelInvoiceId != null) localVarPathParams.Add("parcelInvoiceId", Configuration.ApiClient.ParameterToString(parcelInvoiceId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParcelInvoice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelInvoice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelInvoice)));
            
        }

        
        /// <summary>
        /// Get a parcelInvoice by id Returns the parcelInvoice identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be returned.</param>
        /// <returns>Task of ParcelInvoice</returns>
        public async System.Threading.Tasks.Task<ParcelInvoice> GetParcelInvoiceByIdAsync (int? parcelInvoiceId)
        {
             ApiResponse<ParcelInvoice> localVarResponse = await GetParcelInvoiceByIdAsyncWithHttpInfo(parcelInvoiceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a parcelInvoice by id Returns the parcelInvoice identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to be returned.</param>
        /// <returns>Task of ApiResponse (ParcelInvoice)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParcelInvoice>> GetParcelInvoiceByIdAsyncWithHttpInfo (int? parcelInvoiceId)
        {
            // verify the required parameter 'parcelInvoiceId' is set
            if (parcelInvoiceId == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceId' when calling GetParcelInvoiceById");
            
    
            var localVarPath = "/beta/parcelInvoice/{parcelInvoiceId}";
    
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
            if (parcelInvoiceId != null) localVarPathParams.Add("parcelInvoiceId", Configuration.ApiClient.ParameterToString(parcelInvoiceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParcelInvoice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelInvoice) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelInvoice)));
            
        }
        
        /// <summary>
        /// Get the tags for a parcelInvoice. Get all existing parcelInvoice tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to get tags for</param> 
        /// <returns></returns>
        public void GetParcelInvoiceTags (int? parcelInvoiceId)
        {
             GetParcelInvoiceTagsWithHttpInfo(parcelInvoiceId);
        }

        /// <summary>
        /// Get the tags for a parcelInvoice. Get all existing parcelInvoice tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetParcelInvoiceTagsWithHttpInfo (int? parcelInvoiceId)
        {
            
            // verify the required parameter 'parcelInvoiceId' is set
            if (parcelInvoiceId == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceId' when calling ParcelInvoiceApi->GetParcelInvoiceTags");
            
    
            var localVarPath = "/beta/parcelInvoice/{parcelInvoiceId}/tag";
    
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
            if (parcelInvoiceId != null) localVarPathParams.Add("parcelInvoiceId", Configuration.ApiClient.ParameterToString(parcelInvoiceId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a parcelInvoice. Get all existing parcelInvoice tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetParcelInvoiceTagsAsync (int? parcelInvoiceId)
        {
             await GetParcelInvoiceTagsAsyncWithHttpInfo(parcelInvoiceId);

        }

        /// <summary>
        /// Get the tags for a parcelInvoice. Get all existing parcelInvoice tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceId">Id of the parcelInvoice to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetParcelInvoiceTagsAsyncWithHttpInfo (int? parcelInvoiceId)
        {
            // verify the required parameter 'parcelInvoiceId' is set
            if (parcelInvoiceId == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceId' when calling GetParcelInvoiceTags");
            
    
            var localVarPath = "/beta/parcelInvoice/{parcelInvoiceId}/tag";
    
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
            if (parcelInvoiceId != null) localVarPathParams.Add("parcelInvoiceId", Configuration.ApiClient.ParameterToString(parcelInvoiceId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
