/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: beta
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Infoplus.Client;
using Infoplus.Api;
using Infoplus.Model;

namespace Infoplus.Test
{
    /// <summary>
    ///  Class for testing JobApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class JobApiTests
    {
        private JobApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new JobApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of JobApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' JobApi
            //Assert.IsInstanceOfType(typeof(JobApi), instance, "instance is a JobApi");
        }

        
        /// <summary>
        /// Test AddJob
        /// </summary>
        [Test]
        public void AddJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Job body = null;
            //var response = instance.AddJob(body);
            //Assert.IsInstanceOf<Job> (response, "response is Job");
        }
        
        /// <summary>
        /// Test AddJobAudit
        /// </summary>
        [Test]
        public void AddJobAuditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? jobId = null;
            //string jobAudit = null;
            //instance.AddJobAudit(jobId, jobAudit);
            
        }
        
        /// <summary>
        /// Test AddJobTag
        /// </summary>
        [Test]
        public void AddJobTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? jobId = null;
            //string jobTag = null;
            //instance.AddJobTag(jobId, jobTag);
            
        }
        
        /// <summary>
        /// Test DeleteJob
        /// </summary>
        [Test]
        public void DeleteJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? jobId = null;
            //instance.DeleteJob(jobId);
            
        }
        
        /// <summary>
        /// Test DeleteJobTag
        /// </summary>
        [Test]
        public void DeleteJobTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? jobId = null;
            //string jobTag = null;
            //instance.DeleteJobTag(jobId, jobTag);
            
        }
        
        /// <summary>
        /// Test ExecuteJob
        /// </summary>
        [Test]
        public void ExecuteJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ExecuteJobInputAPIModel body = null;
            //var response = instance.ExecuteJob(body);
            //Assert.IsInstanceOf<List<ProcessOutputAPIModel>> (response, "response is List<ProcessOutputAPIModel>");
        }
        
        /// <summary>
        /// Test GetDuplicateJobById
        /// </summary>
        [Test]
        public void GetDuplicateJobByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? jobId = null;
            //var response = instance.GetDuplicateJobById(jobId);
            //Assert.IsInstanceOf<Job> (response, "response is Job");
        }
        
        /// <summary>
        /// Test GetJobByFilter
        /// </summary>
        [Test]
        public void GetJobByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //int? page = null;
            //int? limit = null;
            //string sort = null;
            //var response = instance.GetJobByFilter(filter, page, limit, sort);
            //Assert.IsInstanceOf<List<Job>> (response, "response is List<Job>");
        }
        
        /// <summary>
        /// Test GetJobById
        /// </summary>
        [Test]
        public void GetJobByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? jobId = null;
            //var response = instance.GetJobById(jobId);
            //Assert.IsInstanceOf<Job> (response, "response is Job");
        }
        
        /// <summary>
        /// Test GetJobTags
        /// </summary>
        [Test]
        public void GetJobTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? jobId = null;
            //instance.GetJobTags(jobId);
            
        }
        
        /// <summary>
        /// Test UpdateJob
        /// </summary>
        [Test]
        public void UpdateJobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Job body = null;
            //instance.UpdateJob(body);
            
        }
        
    }

}
