using System;
namespace E_Commerce_Api.Model
{
	public class Sepet
	{
		public int Sepetid { get; set; }


		public int UserIdenty { get; set; }
		public virtual User User { get; set; }

		public int UrunIdenty { get; set; }
		public virtual Urun Urun { get; set; }

	}
}

