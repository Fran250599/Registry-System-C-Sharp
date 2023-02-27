using Newtonsoft.Json;
using RegistrySystem.Model;

//Library for general purpose utilities

namespace RegistrySystem
{
    class Utilities
    {
        public static void createJsonFile(List<User> users, string fileName)
        {
            var jsonString = JsonConvert.SerializeObject(users);
            Console.WriteLine(jsonString);

            File.WriteAllText(string.Format("./{0}.json", fileName), jsonString.ToString());
        }
    }

}


