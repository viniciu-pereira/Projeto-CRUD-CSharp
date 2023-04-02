using System.ComponentModel.DataAnnotations;

namespace CRUDBlazor.Models
{
    public class Empresa
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Site { get; set; }

        public string Segmento { get; set; } //relacionamento com a tabela de segmento

        //Criar novo id
        public void GenerateNewId()
        {
            Id = Guid.NewGuid();
        }

    }
}
