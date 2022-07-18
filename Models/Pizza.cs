using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza{

        public int Id { get; set; }
        public string Nome { get; set; }

        [Column(TypeName = "Text")]
        public string Descrizione { get; set; }
        public string Immagine { get; set; }
        public double Prezzo { get; set; }

        public Pizza(string nome, string descrizione, string immagine, double prezzo){
            Nome = nome;
            Descrizione = descrizione;
            Immagine = immagine;
            Prezzo = prezzo;
        }

        public Pizza(){

        }
    }
}