using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApplication
{
    [EnumGeneration]
    public partial class ProductCategory
    {
        public static readonly ProductCategory Fruits = new("Fruits");
        public static readonly ProductCategory Dairy = new("Dairy");

        public string Name { get; }

        private ProductCategory(string name)
        {
            Name = name;
        }
    }
}
