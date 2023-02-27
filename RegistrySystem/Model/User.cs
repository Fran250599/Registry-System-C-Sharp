using System;
using Newtonsoft.Json;

namespace RegistrySystem.Model
{
	public abstract class User
	{
        [JsonProperty]
        protected string name;
        [JsonProperty]
        protected string id;
        [JsonProperty]
        protected string password;
        [JsonProperty]
        protected bool state;



		protected User(string name, string id, string password, bool state)
		{
			this.name = name;
			this.id = id;
			this.password = password;
			this.state = state;

		}
		

    }
}

