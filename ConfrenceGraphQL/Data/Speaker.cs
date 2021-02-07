using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConfrenceGraphQL.Data
{
    public class Speaker
    {
        [Required]
        [StringLength(200)]
        public int Id { get; set; }
        public string? Name { get; set; }

        [StringLength(4000)]
        public string? Bio { get; set; }

        [StringLength(1000)]
        public string? Website { get; set; }

        public ICollection<SessionSpeaker> SessionSpeakers { get; set; } =
        new List<SessionSpeaker>();
    }
}