using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreProject {
    public interface IPetAnimal {
        public int Inventory { get; set; }
        public string Sound { get; set; }
        public decimal Price { get; set; }
    } 
}
