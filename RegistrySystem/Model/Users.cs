using System;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace RegistrySystem.Model
{
	public class Users
	{
		private List<User> users;


		public Users(List<User> u)
		{
			this.users = u;
		}


		public void addUser(User user)
		{
			users.Add(user);
		}

		
	}
}

