// Main menu class
//
// This class is the main menu of the program, it is the first thing that the user will see when the program is executed.
// It has a method that shows the menu and another one that receives the user input and executes the corresponding method.
// The menu is shown in a loop until the user decides to exit the program.

using RegistrySystem.Controller;
using RegistrySystem.Model;

class Menu
{

    UsersController usersController = new UsersController();

    void showMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Registry System");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Create a new user");
        Console.WriteLine("2. Show all users");
        Console.WriteLine("3. Show all active users");
        Console.WriteLine("4. Show all inactive users");
        Console.WriteLine("5. Show all students");
        Console.WriteLine("6. Show all teachers");
        Console.WriteLine("7. Show all administrators");
        Console.WriteLine("8. Show all users by name");
        Console.WriteLine("9. Show all users by id");
        Console.WriteLine("10. Show all users by state");
        Console.WriteLine("11. Show all users by type");
        Console.WriteLine("12. Update user");
        Console.WriteLine("13. Delete user");
        Console.WriteLine("14. Exit");
    }

    void getUserInput()
    {
        int option = 0;
        do
        {
            showMenu();
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                // Create user
                    Console.Clear();
                    createUser();
                    break;
                case 2:
                    // Show all users
                    Console.Clear();
                    showAllUsers();
                    break;
                case 3:
                    // Show all active users
                    break;
                case 4:
                    // Show all inactive users
                    break;
                case 5:
                    // Show all students
                    break;
                case 6:
                    // Show all teachers
                    break;
                case 7:
                    // Show all administrators
                    break;
                case 8:
                    // Show all users by name
                    break;
                case 9:
                    // Show all users by id
                    break;
                case 10:
                    // Show all users by state
                    break;
                case 11:
                    // Show all users by type
                    break;
                case 12:
                    // Update user
                    break;
                case 13:
                    // Delete user
                    break;
                case 14:
                    // Exit
                    break;
                default:
                    Console.WriteLine("Please select a valid option");
                    break;
            }
        } while (option != 14);
    }

    // This method will ask for the kind of user to create and will call the corresponding method

    public void createUser()
    {

        // Ask for the kind of user to create
        Console.WriteLine("Please select the kind of user to create:");
        Console.WriteLine("1. Student");
        Console.WriteLine("2. Teacher");
        Console.WriteLine("3. Administrator");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                // Create student
                Console.Clear();
                createStudent();
                break;
            case 2:
                // Create teacher
                Console.Clear();
                createTeacher();
                break;
            case 3:
                // Create administrator
                break;
            default:
                Console.WriteLine("Please select a valid option");
                break;
        }
    }


    // This method will ask for the user information and will call the create user method from the controller
    public void createStudent()
    {
        try
        {
            Console.WriteLine("Please put the student name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please put the student id: ");
            string id = Console.ReadLine();

            Console.WriteLine("Please put the student password: ");
            string password = Console.ReadLine();

            bool state = true;

            usersController.createUser(name, id, password, state, "student");

            Console.WriteLine("Student created successfully, please press any key to continue");
            Console.ReadKey();

            Console.Clear();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    public void createTeacher()
    {
        try
        {
            Console.WriteLine("Please put the teacher name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please put the teacher id: ");
            string id = Console.ReadLine();

            Console.WriteLine("Please put the teacher password: ");
            string password = Console.ReadLine();

            bool state = true;

            usersController.createUser(name, id, password, state, "teacher");

            Console.WriteLine("Teacher created successfully, please press any key to continue");
            Console.ReadKey();

            Console.Clear();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    // This method will show all the users
    public void showAllUsers()
    {
        try
        {
            List<User> users = usersController.GetUsers();
            foreach (User user in users)
            {
                Console.WriteLine(user.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
   
    //Main method
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.getUserInput();
    }

}