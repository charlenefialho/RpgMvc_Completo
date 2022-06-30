using System.Collections.Generic;

namespace RpgMvc.Models
{
    public class HabilidadeViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Dano { get; set; }
        public List<PersonagemHabilidadeViewModel> PersonagemHabilidades { get; set; }
    }
}

