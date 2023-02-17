using Newtonsoft.Json;
using RegistrySystem.Model;

//Library for general purpose utilities

namespace RegistrySystem
{
    class Utilities
    {
        public static void createJsonFile(List<User> users)
        {
            var jsonString = JsonConvert.SerializeObject(users);
            Console.WriteLine(jsonString);

            File.WriteAllText("../../../file.json", jsonString.ToString());
        }
    }

}


