namespace RpgMvc.Models
{
    public class PersonagemHabilidadesViewModel
    {
        public int PersonagemId { get; set; }
        public string PersonagemNome { get; set; }
        public PersonagemViewModel Personagem { get; set; }
        public int HabilidadeId { get; set; }
        public string HabilidadeNome { get; set; }
        public int HabilidadeDano { get; set; }
        public HabilidadeViewModel Habilidade { get; set; }
    }
}