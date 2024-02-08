using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_Api.Model
{
	public class AltKategori
	{
		public int AltKategoriID { get; set; }

		public string AltKategoriName { get; set; }




		//Kategori tablosuyla ilişki kuruldu
		
		public int Kategoriid { get; set; }

		public Kategori Kategori { get; set; }


		/*
		[ForeignKey(name:"Kategori")]
        public int KategoriIdenty { get; set; }

        public Kategori Kategori { get; set; }

		*/


    }
}

