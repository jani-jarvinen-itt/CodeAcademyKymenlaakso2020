using Microsoft.Azure.Cosmos;
using System;
using System.Net;
using System.Threading.Tasks;

namespace AzureCosmosDbDemo
{
    class Program
    {
        /// The Azure Cosmos DB endpoint for running this GetStarted sample.
        private static string EndpointUrl = "https://codeacademykotka.documents.azure.com:443/";

        /// The primary key for the Azure DocumentDB account.
        private static string PrimaryKey = "mLMJAM2azIEf0vPwdxfRQMiX22v8VYQpivqspK4nhKhf9lmGrEOznWu5sr2MNMYXflXspPvuyWQkqMFO6e9ZKA==";

        // The Cosmos client instance
        private static CosmosClient cosmosClient;

        // The database we will create
        private static Database database;

        // The container we will create.
        private static Container container;

        // The name of the database and container we will create
        private static string databaseId = "ToDoList";
        private static string containerId = "Items";

        static async Task Main(string[] args)
        {
            try
            {
                Console.WriteLine("Beginning operations...\n");
                await GetStartedDemoAsync();
            }
            catch (CosmosException de)
            {
                Exception baseException = de.GetBaseException();
                Console.WriteLine("{0} error occurred: {1}", de.StatusCode, de);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
            }
            finally
            {
                Console.WriteLine("End of demo, press any key to exit.");
                Console.ReadKey();
            }
        }

        private async static Task GetStartedDemoAsync()
        {
            cosmosClient = new CosmosClient(EndpointUrl, PrimaryKey);

            database = await cosmosClient.CreateDatabaseIfNotExistsAsync(databaseId);
            Console.WriteLine("Opened Database: {0}\n", database.Id);

            container = await database.CreateContainerIfNotExistsAsync(containerId, "/id");
            Console.WriteLine("Created Container: {0}\n", container.Id);

            // Create a test object
            OmaLuokka testi = new OmaLuokka()
            {
                Id = "1000",
                Nimi = "Teppo Testaaja ÅÄÖ",
                Luku = 123,
                Kellonaika = DateTime.Now
            };

            try
            {
                // Create an item in the container representing the Andersen family. Note we provide the value of the partition key for this item, which is "Andersen".
                ItemResponse<OmaLuokka> response =
                    await container.CreateItemAsync(
                        testi, new PartitionKey(testi.Id));
               
                // Note that after creating the item, we can access the body of the item with the Resource property of the ItemResponse. We can also access the RequestCharge property to see the amount of RUs consumed on this request.
                Console.WriteLine("Created item in database with id: {0} Operation consumed {1} RUs.\n", response.Resource.Id, response.RequestCharge);
            }
            catch (CosmosException ex)
                when (ex.StatusCode == HttpStatusCode.Conflict)
            {
                Console.WriteLine("Item in database with id: {0} already exists\n", testi.Id);
            }
        }
    }
}
