using System.ComponentModel.DataAnnotations;

namespace iStock.Models
{
    public class Fournisseur
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        

        public string QTT_Entre { get; set; }
        public string Prix_Achat { get; set; }



        

    



    }
}
