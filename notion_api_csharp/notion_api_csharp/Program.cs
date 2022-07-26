using notion_api_csharp.Databases;
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
            string token = "secret_hWfBfqtjf5KalIYQaZ6FmaS6jjlphm0viAMO2RQlTtx";
            DatabaseRetrieve databaseRetrieve = new DatabaseRetrieve(id, type, token);
            databaseRetrieve.Get();
            Console.ReadKey();
        }
    }
}
