using System;
namespace E_Commerce_Api.Model
{
	public class Urun
	{
		public int Urunid { get; set; }

		public string UrunAdi { get; set; }

		public string UrunAciklama { get; set; }

		public decimal Fiyat { get; set; }


		
		public int AltKategoriID { get; set; }

		public virtual AltKategori AltKategori { get; set; }



		public virtual ICollection<Sepet> Sepets { get; set; }


	}
}

