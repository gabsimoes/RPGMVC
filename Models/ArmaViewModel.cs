using RpgMvc.Models;
using RpgMvc.Models.Enums;

namespace RpgApi.Models
{
    public class Arma
    {
        public int Id { get; set; }
        public string Nome { get; set; } 
        public int Dano { get; set; } 

        public ClasseEnum Personagem { get; set; } 
        public PersonagemViewModel Personagens { get; set; }
        public int PersonagemId { get; set; }
    }
}