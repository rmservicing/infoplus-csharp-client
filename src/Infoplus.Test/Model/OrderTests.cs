/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: v1.0
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Infoplus.Api;
using Infoplus.Model;
using Infoplus.Client;
using System.Reflection;

namespace Infoplus.Test
{
    /// <summary>
    ///  Class for testing Order
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class OrderTests
    {
        // TODO uncomment below to declare an instance variable for Order
        //private Order instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Order
            //instance = new Order();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Order
        /// </summary>
        [Test]
        public void OrderInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Order
            //Assert.IsInstanceOfType<Order> (instance, "variable 'instance' is a Order");
        }

        /// <summary>
        /// Test the property 'OrderNo'
        /// </summary>
        [Test]
        public void OrderNoTest()
        {
            // TODO unit test for the property 'OrderNo'
        }
        /// <summary>
        /// Test the property 'CustomerOrderNo'
        /// </summary>
        [Test]
        public void CustomerOrderNoTest()
        {
            // TODO unit test for the property 'CustomerOrderNo'
        }
        /// <summary>
        /// Test the property 'LobId'
        /// </summary>
        [Test]
        public void LobIdTest()
        {
            // TODO unit test for the property 'LobId'
        }
        /// <summary>
        /// Test the property 'WarehouseId'
        /// </summary>
        [Test]
        public void WarehouseIdTest()
        {
            // TODO unit test for the property 'WarehouseId'
        }
        /// <summary>
        /// Test the property 'OrderDate'
        /// </summary>
        [Test]
        public void OrderDateTest()
        {
            // TODO unit test for the property 'OrderDate'
        }
        /// <summary>
        /// Test the property 'CustomerNo'
        /// </summary>
        [Test]
        public void CustomerNoTest()
        {
            // TODO unit test for the property 'CustomerNo'
        }
        /// <summary>
        /// Test the property 'FirstShipDate'
        /// </summary>
        [Test]
        public void FirstShipDateTest()
        {
            // TODO unit test for the property 'FirstShipDate'
        }
        /// <summary>
        /// Test the property 'LastShipDate'
        /// </summary>
        [Test]
        public void LastShipDateTest()
        {
            // TODO unit test for the property 'LastShipDate'
        }
        /// <summary>
        /// Test the property 'DeliverOnDate'
        /// </summary>
        [Test]
        public void DeliverOnDateTest()
        {
            // TODO unit test for the property 'DeliverOnDate'
        }
        /// <summary>
        /// Test the property 'NeedByDate'
        /// </summary>
        [Test]
        public void NeedByDateTest()
        {
            // TODO unit test for the property 'NeedByDate'
        }
        /// <summary>
        /// Test the property 'CarrierId'
        /// </summary>
        [Test]
        public void CarrierIdTest()
        {
            // TODO unit test for the property 'CarrierId'
        }
        /// <summary>
        /// Test the property 'ServiceTypeId'
        /// </summary>
        [Test]
        public void ServiceTypeIdTest()
        {
            // TODO unit test for the property 'ServiceTypeId'
        }
        /// <summary>
        /// Test the property 'ShipVia'
        /// </summary>
        [Test]
        public void ShipViaTest()
        {
            // TODO unit test for the property 'ShipVia'
        }
        /// <summary>
        /// Test the property 'MediaCode'
        /// </summary>
        [Test]
        public void MediaCodeTest()
        {
            // TODO unit test for the property 'MediaCode'
        }
        /// <summary>
        /// Test the property 'LegacyRestrictionType'
        /// </summary>
        [Test]
        public void LegacyRestrictionTypeTest()
        {
            // TODO unit test for the property 'LegacyRestrictionType'
        }
        /// <summary>
        /// Test the property 'AlcoholOrderType'
        /// </summary>
        [Test]
        public void AlcoholOrderTypeTest()
        {
            // TODO unit test for the property 'AlcoholOrderType'
        }
        /// <summary>
        /// Test the property 'AlternateUsage'
        /// </summary>
        [Test]
        public void AlternateUsageTest()
        {
            // TODO unit test for the property 'AlternateUsage'
        }
        /// <summary>
        /// Test the property 'AuthorizationAmount'
        /// </summary>
        [Test]
        public void AuthorizationAmountTest()
        {
            // TODO unit test for the property 'AuthorizationAmount'
        }
        /// <summary>
        /// Test the property 'AuthorizedBy'
        /// </summary>
        [Test]
        public void AuthorizedByTest()
        {
            // TODO unit test for the property 'AuthorizedBy'
        }
        /// <summary>
        /// Test the property 'BalanceDue'
        /// </summary>
        [Test]
        public void BalanceDueTest()
        {
            // TODO unit test for the property 'BalanceDue'
        }
        /// <summary>
        /// Test the property 'BatchNo'
        /// </summary>
        [Test]
        public void BatchNoTest()
        {
            // TODO unit test for the property 'BatchNo'
        }
        /// <summary>
        /// Test the property 'BillToAttention'
        /// </summary>
        [Test]
        public void BillToAttentionTest()
        {
            // TODO unit test for the property 'BillToAttention'
        }
        /// <summary>
        /// Test the property 'BillToCompany'
        /// </summary>
        [Test]
        public void BillToCompanyTest()
        {
            // TODO unit test for the property 'BillToCompany'
        }
        /// <summary>
        /// Test the property 'BillToStreet'
        /// </summary>
        [Test]
        public void BillToStreetTest()
        {
            // TODO unit test for the property 'BillToStreet'
        }
        /// <summary>
        /// Test the property 'BillToStreet2'
        /// </summary>
        [Test]
        public void BillToStreet2Test()
        {
            // TODO unit test for the property 'BillToStreet2'
        }
        /// <summary>
        /// Test the property 'BillToStreet3'
        /// </summary>
        [Test]
        public void BillToStreet3Test()
        {
            // TODO unit test for the property 'BillToStreet3'
        }
        /// <summary>
        /// Test the property 'BillToCity'
        /// </summary>
        [Test]
        public void BillToCityTest()
        {
            // TODO unit test for the property 'BillToCity'
        }
        /// <summary>
        /// Test the property 'BillToState'
        /// </summary>
        [Test]
        public void BillToStateTest()
        {
            // TODO unit test for the property 'BillToState'
        }
        /// <summary>
        /// Test the property 'BillToZip'
        /// </summary>
        [Test]
        public void BillToZipTest()
        {
            // TODO unit test for the property 'BillToZip'
        }
        /// <summary>
        /// Test the property 'BillToCountry'
        /// </summary>
        [Test]
        public void BillToCountryTest()
        {
            // TODO unit test for the property 'BillToCountry'
        }
        /// <summary>
        /// Test the property 'BillToPhone'
        /// </summary>
        [Test]
        public void BillToPhoneTest()
        {
            // TODO unit test for the property 'BillToPhone'
        }
        /// <summary>
        /// Test the property 'BillToEmail'
        /// </summary>
        [Test]
        public void BillToEmailTest()
        {
            // TODO unit test for the property 'BillToEmail'
        }
        /// <summary>
        /// Test the property 'NumberOfCartons'
        /// </summary>
        [Test]
        public void NumberOfCartonsTest()
        {
            // TODO unit test for the property 'NumberOfCartons'
        }
        /// <summary>
        /// Test the property 'NumberOfPallets'
        /// </summary>
        [Test]
        public void NumberOfPalletsTest()
        {
            // TODO unit test for the property 'NumberOfPallets'
        }
        /// <summary>
        /// Test the property 'CompletionStatus'
        /// </summary>
        [Test]
        public void CompletionStatusTest()
        {
            // TODO unit test for the property 'CompletionStatus'
        }
        /// <summary>
        /// Test the property 'ParcelAccountId'
        /// </summary>
        [Test]
        public void ParcelAccountIdTest()
        {
            // TODO unit test for the property 'ParcelAccountId'
        }
        /// <summary>
        /// Test the property 'CostCenter'
        /// </summary>
        [Test]
        public void CostCenterTest()
        {
            // TODO unit test for the property 'CostCenter'
        }
        /// <summary>
        /// Test the property 'CreateDate'
        /// </summary>
        [Test]
        public void CreateDateTest()
        {
            // TODO unit test for the property 'CreateDate'
        }
        /// <summary>
        /// Test the property 'CustomerPONo'
        /// </summary>
        [Test]
        public void CustomerPONoTest()
        {
            // TODO unit test for the property 'CustomerPONo'
        }
        /// <summary>
        /// Test the property 'DistributionChannel'
        /// </summary>
        [Test]
        public void DistributionChannelTest()
        {
            // TODO unit test for the property 'DistributionChannel'
        }
        /// <summary>
        /// Test the property 'DistributionCharges'
        /// </summary>
        [Test]
        public void DistributionChargesTest()
        {
            // TODO unit test for the property 'DistributionCharges'
        }
        /// <summary>
        /// Test the property 'Division'
        /// </summary>
        [Test]
        public void DivisionTest()
        {
            // TODO unit test for the property 'Division'
        }
        /// <summary>
        /// Test the property 'EnteredBy'
        /// </summary>
        [Test]
        public void EnteredByTest()
        {
            // TODO unit test for the property 'EnteredBy'
        }
        /// <summary>
        /// Test the property 'EstimatedWeightLbs'
        /// </summary>
        [Test]
        public void EstimatedWeightLbsTest()
        {
            // TODO unit test for the property 'EstimatedWeightLbs'
        }
        /// <summary>
        /// Test the property 'Freight'
        /// </summary>
        [Test]
        public void FreightTest()
        {
            // TODO unit test for the property 'Freight'
        }
        /// <summary>
        /// Test the property 'GiftMessage'
        /// </summary>
        [Test]
        public void GiftMessageTest()
        {
            // TODO unit test for the property 'GiftMessage'
        }
        /// <summary>
        /// Test the property 'GroupOrderId'
        /// </summary>
        [Test]
        public void GroupOrderIdTest()
        {
            // TODO unit test for the property 'GroupOrderId'
        }
        /// <summary>
        /// Test the property 'HoldCode'
        /// </summary>
        [Test]
        public void HoldCodeTest()
        {
            // TODO unit test for the property 'HoldCode'
        }
        /// <summary>
        /// Test the property 'IntegrationPartnerId'
        /// </summary>
        [Test]
        public void IntegrationPartnerIdTest()
        {
            // TODO unit test for the property 'IntegrationPartnerId'
        }
        /// <summary>
        /// Test the property 'NumberOfLineItems'
        /// </summary>
        [Test]
        public void NumberOfLineItemsTest()
        {
            // TODO unit test for the property 'NumberOfLineItems'
        }
        /// <summary>
        /// Test the property 'ModifyDate'
        /// </summary>
        [Test]
        public void ModifyDateTest()
        {
            // TODO unit test for the property 'ModifyDate'
        }
        /// <summary>
        /// Test the property 'OmsOrderId'
        /// </summary>
        [Test]
        public void OmsOrderIdTest()
        {
            // TODO unit test for the property 'OmsOrderId'
        }
        /// <summary>
        /// Test the property 'OmsOrderNo'
        /// </summary>
        [Test]
        public void OmsOrderNoTest()
        {
            // TODO unit test for the property 'OmsOrderNo'
        }
        /// <summary>
        /// Test the property 'OrderLoadProgramId'
        /// </summary>
        [Test]
        public void OrderLoadProgramIdTest()
        {
            // TODO unit test for the property 'OrderLoadProgramId'
        }
        /// <summary>
        /// Test the property 'OrderMessage'
        /// </summary>
        [Test]
        public void OrderMessageTest()
        {
            // TODO unit test for the property 'OrderMessage'
        }
        /// <summary>
        /// Test the property 'OrderReason'
        /// </summary>
        [Test]
        public void OrderReasonTest()
        {
            // TODO unit test for the property 'OrderReason'
        }
        /// <summary>
        /// Test the property 'OrderSourceId'
        /// </summary>
        [Test]
        public void OrderSourceIdTest()
        {
            // TODO unit test for the property 'OrderSourceId'
        }
        /// <summary>
        /// Test the property 'PackingSlipTemplateId'
        /// </summary>
        [Test]
        public void PackingSlipTemplateIdTest()
        {
            // TODO unit test for the property 'PackingSlipTemplateId'
        }
        /// <summary>
        /// Test the property 'OrderConfirmationEmailTemplateId'
        /// </summary>
        [Test]
        public void OrderConfirmationEmailTemplateIdTest()
        {
            // TODO unit test for the property 'OrderConfirmationEmailTemplateId'
        }
        /// <summary>
        /// Test the property 'ShipmentConfirmationEmailTemplateId'
        /// </summary>
        [Test]
        public void ShipmentConfirmationEmailTemplateIdTest()
        {
            // TODO unit test for the property 'ShipmentConfirmationEmailTemplateId'
        }
        /// <summary>
        /// Test the property 'PriceLevel'
        /// </summary>
        [Test]
        public void PriceLevelTest()
        {
            // TODO unit test for the property 'PriceLevel'
        }
        /// <summary>
        /// Test the property 'PriorityCode'
        /// </summary>
        [Test]
        public void PriorityCodeTest()
        {
            // TODO unit test for the property 'PriorityCode'
        }
        /// <summary>
        /// Test the property 'FulfillmentProcessId'
        /// </summary>
        [Test]
        public void FulfillmentProcessIdTest()
        {
            // TODO unit test for the property 'FulfillmentProcessId'
        }
        /// <summary>
        /// Test the property 'ShipBy'
        /// </summary>
        [Test]
        public void ShipByTest()
        {
            // TODO unit test for the property 'ShipBy'
        }
        /// <summary>
        /// Test the property 'ShipCode'
        /// </summary>
        [Test]
        public void ShipCodeTest()
        {
            // TODO unit test for the property 'ShipCode'
        }
        /// <summary>
        /// Test the property 'ShipDate'
        /// </summary>
        [Test]
        public void ShipDateTest()
        {
            // TODO unit test for the property 'ShipDate'
        }
        /// <summary>
        /// Test the property 'ShipToAttention'
        /// </summary>
        [Test]
        public void ShipToAttentionTest()
        {
            // TODO unit test for the property 'ShipToAttention'
        }
        /// <summary>
        /// Test the property 'ShipToCompany'
        /// </summary>
        [Test]
        public void ShipToCompanyTest()
        {
            // TODO unit test for the property 'ShipToCompany'
        }
        /// <summary>
        /// Test the property 'ShipToStreet'
        /// </summary>
        [Test]
        public void ShipToStreetTest()
        {
            // TODO unit test for the property 'ShipToStreet'
        }
        /// <summary>
        /// Test the property 'ShipToStreet2'
        /// </summary>
        [Test]
        public void ShipToStreet2Test()
        {
            // TODO unit test for the property 'ShipToStreet2'
        }
        /// <summary>
        /// Test the property 'ShipToStreet3'
        /// </summary>
        [Test]
        public void ShipToStreet3Test()
        {
            // TODO unit test for the property 'ShipToStreet3'
        }
        /// <summary>
        /// Test the property 'ShipToCity'
        /// </summary>
        [Test]
        public void ShipToCityTest()
        {
            // TODO unit test for the property 'ShipToCity'
        }
        /// <summary>
        /// Test the property 'ShipToState'
        /// </summary>
        [Test]
        public void ShipToStateTest()
        {
            // TODO unit test for the property 'ShipToState'
        }
        /// <summary>
        /// Test the property 'ShipToZip'
        /// </summary>
        [Test]
        public void ShipToZipTest()
        {
            // TODO unit test for the property 'ShipToZip'
        }
        /// <summary>
        /// Test the property 'ShipToCountry'
        /// </summary>
        [Test]
        public void ShipToCountryTest()
        {
            // TODO unit test for the property 'ShipToCountry'
        }
        /// <summary>
        /// Test the property 'ShipToPhone'
        /// </summary>
        [Test]
        public void ShipToPhoneTest()
        {
            // TODO unit test for the property 'ShipToPhone'
        }
        /// <summary>
        /// Test the property 'ShipToEmail'
        /// </summary>
        [Test]
        public void ShipToEmailTest()
        {
            // TODO unit test for the property 'ShipToEmail'
        }
        /// <summary>
        /// Test the property 'ShippingCharge'
        /// </summary>
        [Test]
        public void ShippingChargeTest()
        {
            // TODO unit test for the property 'ShippingCharge'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'StopBackOrders'
        /// </summary>
        [Test]
        public void StopBackOrdersTest()
        {
            // TODO unit test for the property 'StopBackOrders'
        }
        /// <summary>
        /// Test the property 'Subtotal'
        /// </summary>
        [Test]
        public void SubtotalTest()
        {
            // TODO unit test for the property 'Subtotal'
        }
        /// <summary>
        /// Test the property 'Tax'
        /// </summary>
        [Test]
        public void TaxTest()
        {
            // TODO unit test for the property 'Tax'
        }
        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Test]
        public void TotalTest()
        {
            // TODO unit test for the property 'Total'
        }
        /// <summary>
        /// Test the property 'TotalPaid'
        /// </summary>
        [Test]
        public void TotalPaidTest()
        {
            // TODO unit test for the property 'TotalPaid'
        }
        /// <summary>
        /// Test the property 'TotalQty'
        /// </summary>
        [Test]
        public void TotalQtyTest()
        {
            // TODO unit test for the property 'TotalQty'
        }
        /// <summary>
        /// Test the property 'WeightLbs'
        /// </summary>
        [Test]
        public void WeightLbsTest()
        {
            // TODO unit test for the property 'WeightLbs'
        }
        /// <summary>
        /// Test the property 'LineItems'
        /// </summary>
        [Test]
        public void LineItemsTest()
        {
            // TODO unit test for the property 'LineItems'
        }

    }

}
