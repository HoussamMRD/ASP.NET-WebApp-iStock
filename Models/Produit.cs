using System.ComponentModel.DataAnnotations;

namespace iStock.Models
{
	public class Produit
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string NameP { get; set; }
		public string Reference { get; set; }
		public string QTT { get; set; }
		public string Prix { get; set; }

		public string Warehouse_Name { get; set; }

		public string Fournisseur_Name { get; set; }


	}
}
