using System;
namespace RegistrySystem.Model
{
	public abstract class User
	{
		public string name;
		public string id;
		public string password;
		public bool state;

		protected User(string name, string id, string password, bool state)
		{
			this.name = name;
			this.id = id;
			this.password = password;
			this.state = state;

		}
		

    }
}

