namespace RegistrySystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, this is an example to create a basic Object (Student in this case) dinamically\n");

            Console.WriteLine("Please put the student name: ");
            string? name =  Console.ReadLine();

            Console.WriteLine("Please put the student id: ");
            string? id = Console.ReadLine();

            Console.WriteLine("Please put the student password: ");
            string? password = Console.ReadLine();
           
            bool state = true;

            Student student1 = new Student(name, id, password, state);
            

            Console.WriteLine("Thanks for the information, user created. \n ");

            Console.WriteLine("This is the information provided: \n");
            Console.WriteLine("Student name: " + student1.GetName());
            Console.WriteLine("Student id: " + student1.GetId());
            Console.WriteLine("Student password: " + student1.GetPassword());

            if(student1.GetState() == true)
            {
                Console.WriteLine("Student is active.");
            }
            else
            {
                Console.WriteLine("Student is inactive.");
            }

        }
    }
}   