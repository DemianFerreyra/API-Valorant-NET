using API_Valorant_NET.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Valorant_NET.Data
{
    //DB context es una representacion de la base de datos
    public class ValorantDB : DbContext
    {
        //Aca configuramos las opciones para nuestro DbContext
        public ValorantDB(DbContextOptions<ValorantDB> options) : base(options) { 

        }
        //y aqui creamos el agente (modelo que creamos previamente)
        public DbSet<Agents> Agents => Set<Agents>();
    }
}
