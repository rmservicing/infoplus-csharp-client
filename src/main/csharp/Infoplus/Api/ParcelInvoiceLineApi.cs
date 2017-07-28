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
    public interface IParcelInvoiceLineApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for a parcelInvoiceLine
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing parcelInvoiceLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to add an audit to</param>
        /// <param name="parcelInvoiceLineAudit">The audit to add</param>
        /// <returns></returns>
        void AddParcelInvoiceLineAudit (int? parcelInvoiceLineId, string parcelInvoiceLineAudit);
  
        /// <summary>
        /// Add new audit for a parcelInvoiceLine
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing parcelInvoiceLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to add an audit to</param>
        /// <param name="parcelInvoiceLineAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddParcelInvoiceLineAuditWithHttpInfo (int? parcelInvoiceLineId, string parcelInvoiceLineAudit);
        
        /// <summary>
        /// Add new tags for a parcelInvoiceLine.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing parcelInvoiceLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to add a tag to</param>
        /// <param name="parcelInvoiceLineTag">The tag to add</param>
        /// <returns></returns>
        void AddParcelInvoiceLineTag (int? parcelInvoiceLineId, string parcelInvoiceLineTag);
  
        /// <summary>
        /// Add new tags for a parcelInvoiceLine.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing parcelInvoiceLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to add a tag to</param>
        /// <param name="parcelInvoiceLineTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddParcelInvoiceLineTagWithHttpInfo (int? parcelInvoiceLineId, string parcelInvoiceLineTag);
        
        /// <summary>
        /// Delete a tag for a parcelInvoiceLine.
        /// </summary>
        /// <remarks>
        /// Deletes an existing parcelInvoiceLine tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to remove tag from</param>
        /// <param name="parcelInvoiceLineTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteParcelInvoiceLineTag (int? parcelInvoiceLineId, string parcelInvoiceLineTag);
  
        /// <summary>
        /// Delete a tag for a parcelInvoiceLine.
        /// </summary>
        /// <remarks>
        /// Deletes an existing parcelInvoiceLine tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to remove tag from</param>
        /// <param name="parcelInvoiceLineTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteParcelInvoiceLineTagWithHttpInfo (int? parcelInvoiceLineId, string parcelInvoiceLineTag);
        
        /// <summary>
        /// Get a duplicated a parcelInvoiceLine by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated parcelInvoiceLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to be duplicated.</param>
        /// <returns>ParcelInvoiceLine</returns>
        ParcelInvoiceLine GetDuplicateParcelInvoiceLineById (int? parcelInvoiceLineId);
  
        /// <summary>
        /// Get a duplicated a parcelInvoiceLine by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated parcelInvoiceLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to be duplicated.</param>
        /// <returns>ApiResponse of ParcelInvoiceLine</returns>
        ApiResponse<ParcelInvoiceLine> GetDuplicateParcelInvoiceLineByIdWithHttpInfo (int? parcelInvoiceLineId);
        
        /// <summary>
        /// Search parcelInvoiceLines by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of parcelInvoiceLines that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ParcelInvoiceLine&gt;</returns>
        List<ParcelInvoiceLine> GetParcelInvoiceLineByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search parcelInvoiceLines by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of parcelInvoiceLines that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ParcelInvoiceLine&gt;</returns>
        ApiResponse<List<ParcelInvoiceLine>> GetParcelInvoiceLineByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a parcelInvoiceLine by id
        /// </summary>
        /// <remarks>
        /// Returns the parcelInvoiceLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to be returned.</param>
        /// <returns>ParcelInvoiceLine</returns>
        ParcelInvoiceLine GetParcelInvoiceLineById (int? parcelInvoiceLineId);
  
        /// <summary>
        /// Get a parcelInvoiceLine by id
        /// </summary>
        /// <remarks>
        /// Returns the parcelInvoiceLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to be returned.</param>
        /// <returns>ApiResponse of ParcelInvoiceLine</returns>
        ApiResponse<ParcelInvoiceLine> GetParcelInvoiceLineByIdWithHttpInfo (int? parcelInvoiceLineId);
        
        /// <summary>
        /// Get the tags for a parcelInvoiceLine.
        /// </summary>
        /// <remarks>
        /// Get all existing parcelInvoiceLine tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to get tags for</param>
        /// <returns></returns>
        void GetParcelInvoiceLineTags (int? parcelInvoiceLineId);
  
        /// <summary>
        /// Get the tags for a parcelInvoiceLine.
        /// </summary>
        /// <remarks>
        /// Get all existing parcelInvoiceLine tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetParcelInvoiceLineTagsWithHttpInfo (int? parcelInvoiceLineId);
        
        /// <summary>
        /// Update a parcelInvoiceLine
        /// </summary>
        /// <remarks>
        /// Updates an existing parcelInvoiceLine using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ParcelInvoiceLine to be updated.</param>
        /// <returns></returns>
        void UpdateParcelInvoiceLine (ParcelInvoiceLine body);
  
        /// <summary>
        /// Update a parcelInvoiceLine
        /// </summary>
        /// <remarks>
        /// Updates an existing parcelInvoiceLine using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ParcelInvoiceLine to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateParcelInvoiceLineWithHttpInfo (ParcelInvoiceLine body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for a parcelInvoiceLine
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing parcelInvoiceLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to add an audit to</param>
        /// <param name="parcelInvoiceLineAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddParcelInvoiceLineAuditAsync (int? parcelInvoiceLineId, string parcelInvoiceLineAudit);

        /// <summary>
        /// Add new audit for a parcelInvoiceLine
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing parcelInvoiceLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to add an audit to</param>
        /// <param name="parcelInvoiceLineAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddParcelInvoiceLineAuditAsyncWithHttpInfo (int? parcelInvoiceLineId, string parcelInvoiceLineAudit);
        
        /// <summary>
        /// Add new tags for a parcelInvoiceLine.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing parcelInvoiceLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to add a tag to</param>
        /// <param name="parcelInvoiceLineTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddParcelInvoiceLineTagAsync (int? parcelInvoiceLineId, string parcelInvoiceLineTag);

        /// <summary>
        /// Add new tags for a parcelInvoiceLine.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing parcelInvoiceLine.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to add a tag to</param>
        /// <param name="parcelInvoiceLineTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddParcelInvoiceLineTagAsyncWithHttpInfo (int? parcelInvoiceLineId, string parcelInvoiceLineTag);
        
        /// <summary>
        /// Delete a tag for a parcelInvoiceLine.
        /// </summary>
        /// <remarks>
        /// Deletes an existing parcelInvoiceLine tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to remove tag from</param>
        /// <param name="parcelInvoiceLineTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteParcelInvoiceLineTagAsync (int? parcelInvoiceLineId, string parcelInvoiceLineTag);

        /// <summary>
        /// Delete a tag for a parcelInvoiceLine.
        /// </summary>
        /// <remarks>
        /// Deletes an existing parcelInvoiceLine tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to remove tag from</param>
        /// <param name="parcelInvoiceLineTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteParcelInvoiceLineTagAsyncWithHttpInfo (int? parcelInvoiceLineId, string parcelInvoiceLineTag);
        
        /// <summary>
        /// Get a duplicated a parcelInvoiceLine by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated parcelInvoiceLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to be duplicated.</param>
        /// <returns>Task of ParcelInvoiceLine</returns>
        System.Threading.Tasks.Task<ParcelInvoiceLine> GetDuplicateParcelInvoiceLineByIdAsync (int? parcelInvoiceLineId);

        /// <summary>
        /// Get a duplicated a parcelInvoiceLine by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated parcelInvoiceLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to be duplicated.</param>
        /// <returns>Task of ApiResponse (ParcelInvoiceLine)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParcelInvoiceLine>> GetDuplicateParcelInvoiceLineByIdAsyncWithHttpInfo (int? parcelInvoiceLineId);
        
        /// <summary>
        /// Search parcelInvoiceLines by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of parcelInvoiceLines that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ParcelInvoiceLine&gt;</returns>
        System.Threading.Tasks.Task<List<ParcelInvoiceLine>> GetParcelInvoiceLineByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search parcelInvoiceLines by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of parcelInvoiceLines that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ParcelInvoiceLine&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ParcelInvoiceLine>>> GetParcelInvoiceLineByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a parcelInvoiceLine by id
        /// </summary>
        /// <remarks>
        /// Returns the parcelInvoiceLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to be returned.</param>
        /// <returns>Task of ParcelInvoiceLine</returns>
        System.Threading.Tasks.Task<ParcelInvoiceLine> GetParcelInvoiceLineByIdAsync (int? parcelInvoiceLineId);

        /// <summary>
        /// Get a parcelInvoiceLine by id
        /// </summary>
        /// <remarks>
        /// Returns the parcelInvoiceLine identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to be returned.</param>
        /// <returns>Task of ApiResponse (ParcelInvoiceLine)</returns>
        System.Threading.Tasks.Task<ApiResponse<ParcelInvoiceLine>> GetParcelInvoiceLineByIdAsyncWithHttpInfo (int? parcelInvoiceLineId);
        
        /// <summary>
        /// Get the tags for a parcelInvoiceLine.
        /// </summary>
        /// <remarks>
        /// Get all existing parcelInvoiceLine tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetParcelInvoiceLineTagsAsync (int? parcelInvoiceLineId);

        /// <summary>
        /// Get the tags for a parcelInvoiceLine.
        /// </summary>
        /// <remarks>
        /// Get all existing parcelInvoiceLine tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetParcelInvoiceLineTagsAsyncWithHttpInfo (int? parcelInvoiceLineId);
        
        /// <summary>
        /// Update a parcelInvoiceLine
        /// </summary>
        /// <remarks>
        /// Updates an existing parcelInvoiceLine using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ParcelInvoiceLine to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateParcelInvoiceLineAsync (ParcelInvoiceLine body);

        /// <summary>
        /// Update a parcelInvoiceLine
        /// </summary>
        /// <remarks>
        /// Updates an existing parcelInvoiceLine using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ParcelInvoiceLine to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateParcelInvoiceLineAsyncWithHttpInfo (ParcelInvoiceLine body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ParcelInvoiceLineApi : IParcelInvoiceLineApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelInvoiceLineApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ParcelInvoiceLineApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelInvoiceLineApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ParcelInvoiceLineApi(Configuration configuration = null)
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
        /// Add new audit for a parcelInvoiceLine Adds an audit to an existing parcelInvoiceLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to add an audit to</param> 
        /// <param name="parcelInvoiceLineAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddParcelInvoiceLineAudit (int? parcelInvoiceLineId, string parcelInvoiceLineAudit)
        {
             AddParcelInvoiceLineAuditWithHttpInfo(parcelInvoiceLineId, parcelInvoiceLineAudit);
        }

        /// <summary>
        /// Add new audit for a parcelInvoiceLine Adds an audit to an existing parcelInvoiceLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to add an audit to</param> 
        /// <param name="parcelInvoiceLineAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddParcelInvoiceLineAuditWithHttpInfo (int? parcelInvoiceLineId, string parcelInvoiceLineAudit)
        {
            
            // verify the required parameter 'parcelInvoiceLineId' is set
            if (parcelInvoiceLineId == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineId' when calling ParcelInvoiceLineApi->AddParcelInvoiceLineAudit");
            
            // verify the required parameter 'parcelInvoiceLineAudit' is set
            if (parcelInvoiceLineAudit == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineAudit' when calling ParcelInvoiceLineApi->AddParcelInvoiceLineAudit");
            
    
            var localVarPath = "/beta/parcelInvoiceLine/{parcelInvoiceLineId}/audit/{parcelInvoiceLineAudit}";
    
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
            if (parcelInvoiceLineId != null) localVarPathParams.Add("parcelInvoiceLineId", Configuration.ApiClient.ParameterToString(parcelInvoiceLineId)); // path parameter
            if (parcelInvoiceLineAudit != null) localVarPathParams.Add("parcelInvoiceLineAudit", Configuration.ApiClient.ParameterToString(parcelInvoiceLineAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddParcelInvoiceLineAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddParcelInvoiceLineAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a parcelInvoiceLine Adds an audit to an existing parcelInvoiceLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to add an audit to</param>
        /// <param name="parcelInvoiceLineAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddParcelInvoiceLineAuditAsync (int? parcelInvoiceLineId, string parcelInvoiceLineAudit)
        {
             await AddParcelInvoiceLineAuditAsyncWithHttpInfo(parcelInvoiceLineId, parcelInvoiceLineAudit);

        }

        /// <summary>
        /// Add new audit for a parcelInvoiceLine Adds an audit to an existing parcelInvoiceLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to add an audit to</param>
        /// <param name="parcelInvoiceLineAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddParcelInvoiceLineAuditAsyncWithHttpInfo (int? parcelInvoiceLineId, string parcelInvoiceLineAudit)
        {
            // verify the required parameter 'parcelInvoiceLineId' is set
            if (parcelInvoiceLineId == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineId' when calling AddParcelInvoiceLineAudit");
            // verify the required parameter 'parcelInvoiceLineAudit' is set
            if (parcelInvoiceLineAudit == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineAudit' when calling AddParcelInvoiceLineAudit");
            
    
            var localVarPath = "/beta/parcelInvoiceLine/{parcelInvoiceLineId}/audit/{parcelInvoiceLineAudit}";
    
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
            if (parcelInvoiceLineId != null) localVarPathParams.Add("parcelInvoiceLineId", Configuration.ApiClient.ParameterToString(parcelInvoiceLineId)); // path parameter
            if (parcelInvoiceLineAudit != null) localVarPathParams.Add("parcelInvoiceLineAudit", Configuration.ApiClient.ParameterToString(parcelInvoiceLineAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddParcelInvoiceLineAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddParcelInvoiceLineAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a parcelInvoiceLine. Adds a tag to an existing parcelInvoiceLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to add a tag to</param> 
        /// <param name="parcelInvoiceLineTag">The tag to add</param> 
        /// <returns></returns>
        public void AddParcelInvoiceLineTag (int? parcelInvoiceLineId, string parcelInvoiceLineTag)
        {
             AddParcelInvoiceLineTagWithHttpInfo(parcelInvoiceLineId, parcelInvoiceLineTag);
        }

        /// <summary>
        /// Add new tags for a parcelInvoiceLine. Adds a tag to an existing parcelInvoiceLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to add a tag to</param> 
        /// <param name="parcelInvoiceLineTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddParcelInvoiceLineTagWithHttpInfo (int? parcelInvoiceLineId, string parcelInvoiceLineTag)
        {
            
            // verify the required parameter 'parcelInvoiceLineId' is set
            if (parcelInvoiceLineId == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineId' when calling ParcelInvoiceLineApi->AddParcelInvoiceLineTag");
            
            // verify the required parameter 'parcelInvoiceLineTag' is set
            if (parcelInvoiceLineTag == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineTag' when calling ParcelInvoiceLineApi->AddParcelInvoiceLineTag");
            
    
            var localVarPath = "/beta/parcelInvoiceLine/{parcelInvoiceLineId}/tag/{parcelInvoiceLineTag}";
    
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
            if (parcelInvoiceLineId != null) localVarPathParams.Add("parcelInvoiceLineId", Configuration.ApiClient.ParameterToString(parcelInvoiceLineId)); // path parameter
            if (parcelInvoiceLineTag != null) localVarPathParams.Add("parcelInvoiceLineTag", Configuration.ApiClient.ParameterToString(parcelInvoiceLineTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddParcelInvoiceLineTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddParcelInvoiceLineTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a parcelInvoiceLine. Adds a tag to an existing parcelInvoiceLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to add a tag to</param>
        /// <param name="parcelInvoiceLineTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddParcelInvoiceLineTagAsync (int? parcelInvoiceLineId, string parcelInvoiceLineTag)
        {
             await AddParcelInvoiceLineTagAsyncWithHttpInfo(parcelInvoiceLineId, parcelInvoiceLineTag);

        }

        /// <summary>
        /// Add new tags for a parcelInvoiceLine. Adds a tag to an existing parcelInvoiceLine.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to add a tag to</param>
        /// <param name="parcelInvoiceLineTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddParcelInvoiceLineTagAsyncWithHttpInfo (int? parcelInvoiceLineId, string parcelInvoiceLineTag)
        {
            // verify the required parameter 'parcelInvoiceLineId' is set
            if (parcelInvoiceLineId == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineId' when calling AddParcelInvoiceLineTag");
            // verify the required parameter 'parcelInvoiceLineTag' is set
            if (parcelInvoiceLineTag == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineTag' when calling AddParcelInvoiceLineTag");
            
    
            var localVarPath = "/beta/parcelInvoiceLine/{parcelInvoiceLineId}/tag/{parcelInvoiceLineTag}";
    
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
            if (parcelInvoiceLineId != null) localVarPathParams.Add("parcelInvoiceLineId", Configuration.ApiClient.ParameterToString(parcelInvoiceLineId)); // path parameter
            if (parcelInvoiceLineTag != null) localVarPathParams.Add("parcelInvoiceLineTag", Configuration.ApiClient.ParameterToString(parcelInvoiceLineTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddParcelInvoiceLineTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddParcelInvoiceLineTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a parcelInvoiceLine. Deletes an existing parcelInvoiceLine tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to remove tag from</param> 
        /// <param name="parcelInvoiceLineTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteParcelInvoiceLineTag (int? parcelInvoiceLineId, string parcelInvoiceLineTag)
        {
             DeleteParcelInvoiceLineTagWithHttpInfo(parcelInvoiceLineId, parcelInvoiceLineTag);
        }

        /// <summary>
        /// Delete a tag for a parcelInvoiceLine. Deletes an existing parcelInvoiceLine tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to remove tag from</param> 
        /// <param name="parcelInvoiceLineTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteParcelInvoiceLineTagWithHttpInfo (int? parcelInvoiceLineId, string parcelInvoiceLineTag)
        {
            
            // verify the required parameter 'parcelInvoiceLineId' is set
            if (parcelInvoiceLineId == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineId' when calling ParcelInvoiceLineApi->DeleteParcelInvoiceLineTag");
            
            // verify the required parameter 'parcelInvoiceLineTag' is set
            if (parcelInvoiceLineTag == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineTag' when calling ParcelInvoiceLineApi->DeleteParcelInvoiceLineTag");
            
    
            var localVarPath = "/beta/parcelInvoiceLine/{parcelInvoiceLineId}/tag/{parcelInvoiceLineTag}";
    
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
            if (parcelInvoiceLineId != null) localVarPathParams.Add("parcelInvoiceLineId", Configuration.ApiClient.ParameterToString(parcelInvoiceLineId)); // path parameter
            if (parcelInvoiceLineTag != null) localVarPathParams.Add("parcelInvoiceLineTag", Configuration.ApiClient.ParameterToString(parcelInvoiceLineTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteParcelInvoiceLineTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteParcelInvoiceLineTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a parcelInvoiceLine. Deletes an existing parcelInvoiceLine tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to remove tag from</param>
        /// <param name="parcelInvoiceLineTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteParcelInvoiceLineTagAsync (int? parcelInvoiceLineId, string parcelInvoiceLineTag)
        {
             await DeleteParcelInvoiceLineTagAsyncWithHttpInfo(parcelInvoiceLineId, parcelInvoiceLineTag);

        }

        /// <summary>
        /// Delete a tag for a parcelInvoiceLine. Deletes an existing parcelInvoiceLine tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to remove tag from</param>
        /// <param name="parcelInvoiceLineTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteParcelInvoiceLineTagAsyncWithHttpInfo (int? parcelInvoiceLineId, string parcelInvoiceLineTag)
        {
            // verify the required parameter 'parcelInvoiceLineId' is set
            if (parcelInvoiceLineId == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineId' when calling DeleteParcelInvoiceLineTag");
            // verify the required parameter 'parcelInvoiceLineTag' is set
            if (parcelInvoiceLineTag == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineTag' when calling DeleteParcelInvoiceLineTag");
            
    
            var localVarPath = "/beta/parcelInvoiceLine/{parcelInvoiceLineId}/tag/{parcelInvoiceLineTag}";
    
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
            if (parcelInvoiceLineId != null) localVarPathParams.Add("parcelInvoiceLineId", Configuration.ApiClient.ParameterToString(parcelInvoiceLineId)); // path parameter
            if (parcelInvoiceLineTag != null) localVarPathParams.Add("parcelInvoiceLineTag", Configuration.ApiClient.ParameterToString(parcelInvoiceLineTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteParcelInvoiceLineTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteParcelInvoiceLineTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a parcelInvoiceLine by id Returns a duplicated parcelInvoiceLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to be duplicated.</param> 
        /// <returns>ParcelInvoiceLine</returns>
        public ParcelInvoiceLine GetDuplicateParcelInvoiceLineById (int? parcelInvoiceLineId)
        {
             ApiResponse<ParcelInvoiceLine> localVarResponse = GetDuplicateParcelInvoiceLineByIdWithHttpInfo(parcelInvoiceLineId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a parcelInvoiceLine by id Returns a duplicated parcelInvoiceLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to be duplicated.</param> 
        /// <returns>ApiResponse of ParcelInvoiceLine</returns>
        public ApiResponse< ParcelInvoiceLine > GetDuplicateParcelInvoiceLineByIdWithHttpInfo (int? parcelInvoiceLineId)
        {
            
            // verify the required parameter 'parcelInvoiceLineId' is set
            if (parcelInvoiceLineId == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineId' when calling ParcelInvoiceLineApi->GetDuplicateParcelInvoiceLineById");
            
    
            var localVarPath = "/beta/parcelInvoiceLine/duplicate/{parcelInvoiceLineId}";
    
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
            if (parcelInvoiceLineId != null) localVarPathParams.Add("parcelInvoiceLineId", Configuration.ApiClient.ParameterToString(parcelInvoiceLineId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateParcelInvoiceLineById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateParcelInvoiceLineById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParcelInvoiceLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelInvoiceLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelInvoiceLine)));
            
        }

        
        /// <summary>
        /// Get a duplicated a parcelInvoiceLine by id Returns a duplicated parcelInvoiceLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to be duplicated.</param>
        /// <returns>Task of ParcelInvoiceLine</returns>
        public async System.Threading.Tasks.Task<ParcelInvoiceLine> GetDuplicateParcelInvoiceLineByIdAsync (int? parcelInvoiceLineId)
        {
             ApiResponse<ParcelInvoiceLine> localVarResponse = await GetDuplicateParcelInvoiceLineByIdAsyncWithHttpInfo(parcelInvoiceLineId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a parcelInvoiceLine by id Returns a duplicated parcelInvoiceLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to be duplicated.</param>
        /// <returns>Task of ApiResponse (ParcelInvoiceLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParcelInvoiceLine>> GetDuplicateParcelInvoiceLineByIdAsyncWithHttpInfo (int? parcelInvoiceLineId)
        {
            // verify the required parameter 'parcelInvoiceLineId' is set
            if (parcelInvoiceLineId == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineId' when calling GetDuplicateParcelInvoiceLineById");
            
    
            var localVarPath = "/beta/parcelInvoiceLine/duplicate/{parcelInvoiceLineId}";
    
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
            if (parcelInvoiceLineId != null) localVarPathParams.Add("parcelInvoiceLineId", Configuration.ApiClient.ParameterToString(parcelInvoiceLineId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateParcelInvoiceLineById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateParcelInvoiceLineById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParcelInvoiceLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelInvoiceLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelInvoiceLine)));
            
        }
        
        /// <summary>
        /// Search parcelInvoiceLines by filter Returns the list of parcelInvoiceLines that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ParcelInvoiceLine&gt;</returns>
        public List<ParcelInvoiceLine> GetParcelInvoiceLineByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ParcelInvoiceLine>> localVarResponse = GetParcelInvoiceLineByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search parcelInvoiceLines by filter Returns the list of parcelInvoiceLines that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ParcelInvoiceLine&gt;</returns>
        public ApiResponse< List<ParcelInvoiceLine> > GetParcelInvoiceLineByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/parcelInvoiceLine/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceLineByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceLineByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ParcelInvoiceLine>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ParcelInvoiceLine>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ParcelInvoiceLine>)));
            
        }

        
        /// <summary>
        /// Search parcelInvoiceLines by filter Returns the list of parcelInvoiceLines that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ParcelInvoiceLine&gt;</returns>
        public async System.Threading.Tasks.Task<List<ParcelInvoiceLine>> GetParcelInvoiceLineByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ParcelInvoiceLine>> localVarResponse = await GetParcelInvoiceLineByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search parcelInvoiceLines by filter Returns the list of parcelInvoiceLines that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ParcelInvoiceLine&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ParcelInvoiceLine>>> GetParcelInvoiceLineByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/parcelInvoiceLine/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceLineByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceLineByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ParcelInvoiceLine>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ParcelInvoiceLine>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ParcelInvoiceLine>)));
            
        }
        
        /// <summary>
        /// Get a parcelInvoiceLine by id Returns the parcelInvoiceLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to be returned.</param> 
        /// <returns>ParcelInvoiceLine</returns>
        public ParcelInvoiceLine GetParcelInvoiceLineById (int? parcelInvoiceLineId)
        {
             ApiResponse<ParcelInvoiceLine> localVarResponse = GetParcelInvoiceLineByIdWithHttpInfo(parcelInvoiceLineId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a parcelInvoiceLine by id Returns the parcelInvoiceLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to be returned.</param> 
        /// <returns>ApiResponse of ParcelInvoiceLine</returns>
        public ApiResponse< ParcelInvoiceLine > GetParcelInvoiceLineByIdWithHttpInfo (int? parcelInvoiceLineId)
        {
            
            // verify the required parameter 'parcelInvoiceLineId' is set
            if (parcelInvoiceLineId == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineId' when calling ParcelInvoiceLineApi->GetParcelInvoiceLineById");
            
    
            var localVarPath = "/beta/parcelInvoiceLine/{parcelInvoiceLineId}";
    
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
            if (parcelInvoiceLineId != null) localVarPathParams.Add("parcelInvoiceLineId", Configuration.ApiClient.ParameterToString(parcelInvoiceLineId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceLineById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceLineById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ParcelInvoiceLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelInvoiceLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelInvoiceLine)));
            
        }

        
        /// <summary>
        /// Get a parcelInvoiceLine by id Returns the parcelInvoiceLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to be returned.</param>
        /// <returns>Task of ParcelInvoiceLine</returns>
        public async System.Threading.Tasks.Task<ParcelInvoiceLine> GetParcelInvoiceLineByIdAsync (int? parcelInvoiceLineId)
        {
             ApiResponse<ParcelInvoiceLine> localVarResponse = await GetParcelInvoiceLineByIdAsyncWithHttpInfo(parcelInvoiceLineId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a parcelInvoiceLine by id Returns the parcelInvoiceLine identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to be returned.</param>
        /// <returns>Task of ApiResponse (ParcelInvoiceLine)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ParcelInvoiceLine>> GetParcelInvoiceLineByIdAsyncWithHttpInfo (int? parcelInvoiceLineId)
        {
            // verify the required parameter 'parcelInvoiceLineId' is set
            if (parcelInvoiceLineId == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineId' when calling GetParcelInvoiceLineById");
            
    
            var localVarPath = "/beta/parcelInvoiceLine/{parcelInvoiceLineId}";
    
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
            if (parcelInvoiceLineId != null) localVarPathParams.Add("parcelInvoiceLineId", Configuration.ApiClient.ParameterToString(parcelInvoiceLineId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceLineById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceLineById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ParcelInvoiceLine>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ParcelInvoiceLine) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ParcelInvoiceLine)));
            
        }
        
        /// <summary>
        /// Get the tags for a parcelInvoiceLine. Get all existing parcelInvoiceLine tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to get tags for</param> 
        /// <returns></returns>
        public void GetParcelInvoiceLineTags (int? parcelInvoiceLineId)
        {
             GetParcelInvoiceLineTagsWithHttpInfo(parcelInvoiceLineId);
        }

        /// <summary>
        /// Get the tags for a parcelInvoiceLine. Get all existing parcelInvoiceLine tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetParcelInvoiceLineTagsWithHttpInfo (int? parcelInvoiceLineId)
        {
            
            // verify the required parameter 'parcelInvoiceLineId' is set
            if (parcelInvoiceLineId == null)
                throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineId' when calling ParcelInvoiceLineApi->GetParcelInvoiceLineTags");
            
    
            var localVarPath = "/beta/parcelInvoiceLine/{parcelInvoiceLineId}/tag";
    
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
            if (parcelInvoiceLineId != null) localVarPathParams.Add("parcelInvoiceLineId", Configuration.ApiClient.ParameterToString(parcelInvoiceLineId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceLineTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceLineTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a parcelInvoiceLine. Get all existing parcelInvoiceLine tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetParcelInvoiceLineTagsAsync (int? parcelInvoiceLineId)
        {
             await GetParcelInvoiceLineTagsAsyncWithHttpInfo(parcelInvoiceLineId);

        }

        /// <summary>
        /// Get the tags for a parcelInvoiceLine. Get all existing parcelInvoiceLine tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="parcelInvoiceLineId">Id of the parcelInvoiceLine to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetParcelInvoiceLineTagsAsyncWithHttpInfo (int? parcelInvoiceLineId)
        {
            // verify the required parameter 'parcelInvoiceLineId' is set
            if (parcelInvoiceLineId == null) throw new ApiException(400, "Missing required parameter 'parcelInvoiceLineId' when calling GetParcelInvoiceLineTags");
            
    
            var localVarPath = "/beta/parcelInvoiceLine/{parcelInvoiceLineId}/tag";
    
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
            if (parcelInvoiceLineId != null) localVarPathParams.Add("parcelInvoiceLineId", Configuration.ApiClient.ParameterToString(parcelInvoiceLineId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceLineTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParcelInvoiceLineTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a parcelInvoiceLine Updates an existing parcelInvoiceLine using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ParcelInvoiceLine to be updated.</param> 
        /// <returns></returns>
        public void UpdateParcelInvoiceLine (ParcelInvoiceLine body)
        {
             UpdateParcelInvoiceLineWithHttpInfo(body);
        }

        /// <summary>
        /// Update a parcelInvoiceLine Updates an existing parcelInvoiceLine using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ParcelInvoiceLine to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateParcelInvoiceLineWithHttpInfo (ParcelInvoiceLine body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ParcelInvoiceLineApi->UpdateParcelInvoiceLine");
            
    
            var localVarPath = "/beta/parcelInvoiceLine";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateParcelInvoiceLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateParcelInvoiceLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a parcelInvoiceLine Updates an existing parcelInvoiceLine using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ParcelInvoiceLine to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateParcelInvoiceLineAsync (ParcelInvoiceLine body)
        {
             await UpdateParcelInvoiceLineAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a parcelInvoiceLine Updates an existing parcelInvoiceLine using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ParcelInvoiceLine to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateParcelInvoiceLineAsyncWithHttpInfo (ParcelInvoiceLine body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateParcelInvoiceLine");
            
    
            var localVarPath = "/beta/parcelInvoiceLine";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateParcelInvoiceLine: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateParcelInvoiceLine: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
