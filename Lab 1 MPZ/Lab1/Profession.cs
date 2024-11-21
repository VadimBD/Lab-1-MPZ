using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_MPZ.Lab1
{
    internal class Profession
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty ;
        public Level Level { get; set; }
    }
    internal enum Level
    {
        none,
        Senior, 
        Middle ,
        Junior
    }
}
