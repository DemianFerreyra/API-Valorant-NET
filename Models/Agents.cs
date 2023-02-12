using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Valorant_NET.Models
{
    public class Agents
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string png { get; set; }
        public string description { get; set; }
        public string country { get; set; }

        [Column(TypeName = "jsonb")]
        public Ability[] abilities { get; set; }

        public class Ability
        {
            public string name { get; set; }
            public string description { get; set; }
            public int buyCost { get; set; }
        }

    }
    
}

