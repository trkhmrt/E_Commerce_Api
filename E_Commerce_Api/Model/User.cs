using System;
namespace E_Commerce_Api.Model
{
	public class User
	{
		public int Userid { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public string Gender { get; set; }

		public virtual ICollection<Sepet> Sepets { get; set; }

	}
}

