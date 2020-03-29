using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheetMaterialDataBaseApp
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public List<Tail> Tails { get; set; }
    }
}
