namespace RegistrySystem.Model{

    //Class that represents a teacher
    public class Teacher : User
    {
        public Teacher(string? name, string? id, string? password, bool state) : base(name, id, password, state) {
        }

        public string GetName() => name;
        public string GetId() => id;
        public string GetPassword() => password;
        public bool GetState() => state;
    }
    


}