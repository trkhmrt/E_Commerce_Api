using System;
namespace E_Commerce_Api.Model
{
	public class Sepet
	{
		public int Sepetid { get; set; }


		public int Userid { get; set; }
		public virtual User User { get; set; }

		public int Urunid { get; set; }
		public virtual Urun Urun { get; set; }

	}
}

