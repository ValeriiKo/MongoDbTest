using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbTest;

var mongoURL = new MongoUrl("mongodb+srv://valeriikozhevnikov:l6AVsdQAXlfOkK6o@cluster0.minnz6g.mongodb.net/?retryWrites=true&w=majority");
var client = new MongoClient(mongoURL);

var dbList = client.ListDatabases().ToList();

Console.WriteLine("The list of databases on this server is: ");
foreach (var db in dbList)
{
    Console.WriteLine(db);
}
var collections = client.GetDatabase("sample_analytics");
var airnb = collections.GetCollection<Account>("accounts").AsQueryable<Account>().ToList();
Console.WriteLine("\n\nGet data from sample_analytics.accounts collection:");
Console.WriteLine("AccountId: " + airnb.FirstOrDefault().account_id);