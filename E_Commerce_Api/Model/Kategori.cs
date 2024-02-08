using System;
namespace E_Commerce_Api.Model
{
	public class Kategori
	{
		public int Kategoriid { get; set; }

		public string KategoriName { get; set; }

		//Lazy loading

		public virtual ICollection<AltKategori> AltKategoris { get; set; }



	}
}

