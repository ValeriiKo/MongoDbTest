using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdParty.Json.LitJson;

namespace MongoDbTest
{
    public class Account
    {
        public ObjectId _id { get; set; }
        public int account_id { get; set; }
        public int limit { get; set; }
        public List<string> products { get; set; }
    }
}
