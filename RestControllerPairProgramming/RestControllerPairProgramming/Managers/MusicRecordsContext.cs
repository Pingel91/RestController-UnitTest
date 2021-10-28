using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelLib.Model;

namespace RestControllerPairProgramming.Managers
{
    public class MusicRecordsContext : DbContext
    {
        public MusicRecordsContext(DbContextOptions<MusicRecordsContext> options): base(options)
        {
            
        }

        public DbSet<MusicRecords> MusicRecords { get; set; }
    }
}
