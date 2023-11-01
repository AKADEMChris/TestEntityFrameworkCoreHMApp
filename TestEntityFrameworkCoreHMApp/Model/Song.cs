using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntityFrameworkCoreHMApp.Model
{
    internal class Song
    {
        public int Id { get; set; }
        public string? Artist { get; set; }
        public string? Title { get; set; }
        public long Year { get; set; }
        public override string ToString()
        {
            return $"{Id} : {Artist} - {Title} ({Year})";
        }
    }
    
}
