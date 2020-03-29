using System.Collections.Generic;
using System.Linq;

namespace SheetMaterialDataBaseApp
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        int totalCount;
        public int TotalCount 
        { 
            get 
            { 
                return totalCount;
            } 
            set 
            {
                if(Materials != null)
                {
                    value = Materials.Select(m => m.Count).Sum();
                }
            }
        }
        public List<Material> Materials { get; set; }
    }
}
