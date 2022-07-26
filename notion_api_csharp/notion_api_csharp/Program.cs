using notion_api_csharp.Databases;
using notion_api_csharp.JsonParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notion_api_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string id = "e6ef6bd0ad4f4b288caef6a6992411b5";
            string type = "databases";
            string token = "";

            DatabaseRetrieve databaseRetrieve = new DatabaseRetrieve(id, type, token);
            string databaseRetrieve_get_result =  databaseRetrieve.Get();

            DatabasesJsonParser databasesJsonParser = new DatabasesJsonParser();

            string databases_created_time = databasesJsonParser.Get_Database_created_time(databaseRetrieve_get_result);
            //Console.WriteLine(databases_created_time);

            Console.ReadKey();
        }
    }
}
