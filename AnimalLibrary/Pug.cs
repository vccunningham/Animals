using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class Pug : Dog {

        public bool IsSmall { get; set; }

        public Pug (string name) : base(name) {
            IsSmall = true;
            Muzzle = MuzzleType.Collapsed;
        }

        public Pug() : this("Spot") {

        }

        public override string GetTypeOfDog() {
            return "Pug";
         
        }

    }
}
