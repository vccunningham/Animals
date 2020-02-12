using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class GermanShepard : Dog {

        public bool BigDog { get; set; } = true;

        public GermanShepard () {
            this.LongTail = true;
        }
 

        public GermanShepard (string Name) : base(Name) {
            this.LongTail = true;
            this.Muzzle = MuzzleType.Long;
        }
        public override string GetTypeOfDog() {
            return "German Shepard";
        }

    }
}

