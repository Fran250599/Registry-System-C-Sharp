using Newtonsoft.Json;
using RegistrySystem.Model;

//Library for general purpose utilities

namespace RegistrySystem
{
    class JsonController
    {
        // USERS JSON MANAGEMENT
        // Create a json file with the list of users
        public static void createJsonFile(List<User> users, string fileName)
        {
            try{
                var jsonString = JsonConvert.SerializeObject(users, Formatting.Indented);
                Console.WriteLine(jsonString);
                File.WriteAllText(string.Format("./{0}.json", fileName), jsonString);
            }catch(Exception e){
                Console.WriteLine("Error creating the json file: " + e.Message);
            }
        }

        //Read the json file and return a list of users
        public static List<User> readJsonFile(string fileName)
        {
            try{
                var jsonString = File.ReadAllText(string.Format("./{0}.json", fileName));
                var users = JsonConvert.DeserializeObject<List<User>>(jsonString);
                return users;

            }catch(Exception e){
                Console.WriteLine("Error reading the json file: " + e.Message);
                return new List<User>();
            }
        }

        // STUDENTS JSON MANAGEMENT
        // Create a json file with the list of students
        public static void createJsonFileStudents(List<Student> students, string fileName)
        {
            var jsonString = JsonConvert.SerializeObject(students, Formatting.Indented);
            Console.WriteLine(jsonString);

            File.WriteAllText(string.Format("./{0}.json", fileName), jsonString.ToString());
        }

        // Read the json file and return a list of students
        public static List<Student> readJsonFileStudents(string fileName)
        {
            try{
                var jsonString = File.ReadAllText(string.Format("./{0}.json", fileName));
                var students = JsonConvert.DeserializeObject<List<Student>>(jsonString);
                return students;
            }catch(Exception e){
                Console.WriteLine("Error reading the json file: " + e.Message);
                return new List<Student>();
            }
         
        }

        // TEACHERS JSON MANAGEMENT
        // Create a json file with the list of teachers
        public static void createJsonFileTeachers(List<Teacher> teachers, string fileName)
        {
            var jsonString = JsonConvert.SerializeObject(teachers, Formatting.Indented);
            Console.WriteLine(jsonString);
            File.WriteAllText(string.Format("./{0}.json", fileName), jsonString);
        }

        // Read the json file and return a list of teachers
        public static List<Teacher> readJsonFileTeachers(string fileName)
        {
            var jsonString = File.ReadAllText(string.Format("./{0}.json", fileName));
            var teachers = JsonConvert.DeserializeObject<List<Teacher>>(jsonString);
            return teachers;
        }
    }

}


