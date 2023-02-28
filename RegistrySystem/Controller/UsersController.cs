// User controller:

using RegistrySystem;
using RegistrySystem.Model;

namespace RegistrySystem.Controller;

class UsersController
{

    private List<User> users = new List<User>();
    private List<Student> students = new List<Student>();
    List<Teacher> teachers = new List<Teacher>();
    //List<Administrator> administrators = new List<Administrator>();
    public List<User> GetUsers() => users;


    // Initialize the list of users, students, teachers and administrators from the json files
    public UsersController()
    {
        //Try to read the json file with the list of students, teachers and administrators
        try
        {
            //Verify if the retrieved list is not empty
            students = JsonController.readJsonFileStudents("students");
            teachers = JsonController.readJsonFileTeachers("teachers");
            //administrators = Utilities.readJsonFileAdministrators("administrators");

            if (students.Any())
            {
                if (teachers.Any())
                {
                    //Finally, add all the users to the list of users
                    users.AddRange(students);
                    users.AddRange(teachers);
                    //users.AddRange(administrators);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error reading the json file: " + e.Message);
        }
    }

    public void createUser(string name, string id, string password, bool state, string type)
    {
        // Create user
        // Depending on the type of user, create a new instance of the corresponding class
        // and add it to the list of users

        if (type == "student")
        {
            Student student = new Student(name, id, password, state);
            users.Add(student);
            students.Add(student);

            //Add the new student to the json file
            JsonController.createJsonFile(users, "users");
            JsonController.createJsonFileStudents(students, "students");
        }
        else if (type == "teacher")
        {
            Teacher teacher = new Teacher(name, id, password, state);
            users.Add(teacher);
            teachers.Add(teacher);

            //Add the new teacher to the json file
            JsonController.createJsonFile(users, "users");
            JsonController.createJsonFileTeachers(teachers, "teachers");
        }
        /*else if (type == "administrator")
        {
            Administrator administrator = new Administrator(name, id, password, state);
            users.Add(administrator);
        }*/
        else
        {
            Console.WriteLine("Please select a valid type of user");
        }

    }


    // Read the json file and return a list of users
    public List<User> readUsers()
    {
        users = JsonController.readJsonFile("users");
        return users;
    }

    // Read the json file and return a list of students
    public List<Student> readStudents()
    {
        students = JsonController.readJsonFileStudents("users");
        return students;
    }


    // Return the list of users
    public List<User> getUsers()
    {
        return users;
    }




}