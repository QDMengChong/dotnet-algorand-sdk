/* 
 * Algod REST API.
 *
 * API Endpoint for AlgoD Operations.
 *
 * OpenAPI spec version: 0.0.1
 * Contact: contact@algorand.com
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

using Algorand.Algod.Client;
using Algorand.Algod.Client.Api;
using Algorand.Algod.Client.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DefaultApiTests
    {
        private DefaultApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DefaultApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DefaultApi
            //Assert.IsInstanceOfType(typeof(DefaultApi), instance, "instance is a DefaultApi");
        }

        /// <summary>
        /// Test AccountInformation
        /// </summary>
        [Test]
        public void AccountInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //var response = instance.AccountInformation(address);
            //Assert.IsInstanceOf<Account> (response, "response is Account");
        }
        /// <summary>
        /// Test AssetInformation
        /// </summary>
        [Test]
        public void AssetInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? index = null;
            //var response = instance.AssetInformation(index);
            //Assert.IsInstanceOf<AssetParams> (response, "response is AssetParams");
        }
        /// <summary>
        /// Test Assets
        /// </summary>
        [Test]
        public void AssetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? assetIdx = null;
            //long? max = null;
            //var response = instance.Assets(assetIdx, max);
            //Assert.IsInstanceOf<AssetList> (response, "response is AssetList");
        }
        /// <summary>
        /// Test GetBlock
        /// </summary>
        [Test]
        public void GetBlockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? round = null;
            //var response = instance.GetBlock(round);
            //Assert.IsInstanceOf<Block> (response, "response is Block");
        }
        /// <summary>
        /// Test GetPendingTransactions
        /// </summary>
        [Test]
        public void GetPendingTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? max = null;
            //var response = instance.GetPendingTransactions(max);
            //Assert.IsInstanceOf<PendingTransactions> (response, "response is PendingTransactions");
        }
        /// <summary>
        /// Test GetPendingTransactionsByAddress
        /// </summary>
        [Test]
        public void GetPendingTransactionsByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string addr = null;
            //long? max = null;
            //var response = instance.GetPendingTransactionsByAddress(addr, max);
            //Assert.IsInstanceOf<PendingTransactions> (response, "response is PendingTransactions");
        }
        /// <summary>
        /// Test GetStatus
        /// </summary>
        [Test]
        public void GetStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetStatus();
            //Assert.IsInstanceOf<NodeStatus> (response, "response is NodeStatus");
        }
        /// <summary>
        /// Test GetSupply
        /// </summary>
        [Test]
        public void GetSupplyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSupply();
            //Assert.IsInstanceOf<Supply> (response, "response is Supply");
        }
        /// <summary>
        /// Test GetVersion
        /// </summary>
        [Test]
        public void GetVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetVersion();
            //Assert.IsInstanceOf<Version> (response, "response is Version");
        }
        /// <summary>
        /// Test HealthCheck
        /// </summary>
        [Test]
        public void HealthCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.HealthCheck();
            
        }
        /// <summary>
        /// Test Metrics
        /// </summary>
        [Test]
        public void MetricsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.Metrics();
            
        }
        /// <summary>
        /// Test PendingTransactionInformation
        /// </summary>
        [Test]
        public void PendingTransactionInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string txid = null;
            //var response = instance.PendingTransactionInformation(txid);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        /// <summary>
        /// Test RawTransaction
        /// </summary>
        [Test]
        public void RawTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string body = null;
            //var response = instance.RawTransaction(body);
            //Assert.IsInstanceOf<TransactionID> (response, "response is TransactionID");
        }
        /// <summary>
        /// Test SuggestedFee
        /// </summary>
        [Test]
        public void SuggestedFeeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SuggestedFee();
            //Assert.IsInstanceOf<TransactionFee> (response, "response is TransactionFee");
        }
        /// <summary>
        /// Test SwaggerJSON
        /// </summary>
        [Test]
        public void SwaggerJSONTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SwaggerJSON();
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        /// <summary>
        /// Test Transaction
        /// </summary>
        [Test]
        public void TransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string txid = null;
            //var response = instance.Transaction(txid);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        /// <summary>
        /// Test TransactionInformation
        /// </summary>
        [Test]
        public void TransactionInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string txid = null;
            //var response = instance.TransactionInformation(address, txid);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        /// <summary>
        /// Test TransactionParams
        /// </summary>
        [Test]
        public void TransactionParamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.TransactionParams();
            //Assert.IsInstanceOf<TransactionParams> (response, "response is TransactionParams");
        }
        /// <summary>
        /// Test Transactions
        /// </summary>
        [Test]
        public void TransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //long? firstRound = null;
            //long? lastRound = null;
            //DateTime? fromDate = null;
            //DateTime? toDate = null;
            //long? max = null;
            //var response = instance.Transactions(address, firstRound, lastRound, fromDate, toDate, max);
            //Assert.IsInstanceOf<TransactionList> (response, "response is TransactionList");
        }
        /// <summary>
        /// Test WaitForBlock
        /// </summary>
        [Test]
        public void WaitForBlockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? round = null;
            //var response = instance.WaitForBlock(round);
            //Assert.IsInstanceOf<NodeStatus> (response, "response is NodeStatus");
        }
    }

}