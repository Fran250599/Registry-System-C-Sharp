using Newtonsoft.Json;
using RegistrySystem.Model;

//Library for general purpose utilities

namespace RegistrySystem
{
    class Utilities
    {
        public static void addUserJson(User user)
        {
            var jsonString = JsonConvert.SerializeObject(user);
            Console.WriteLine(jsonString);

            File.WriteAllText("../../../file.json", jsonString.ToString());
        }
    }

}


