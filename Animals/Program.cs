using System;
using System.Collections.Generic;
using AnimalLibrary;

namespace Animals {
    class Program {
       

        static void Main(string[] args) {

            var boxer1 = new Boxer();
            var pug1 = new Pug("The Pug");
            var pug2 = new Pug();
            var gs1 = new GermanShepard("Killer");
            var germanShepard = new GermanShepard();
            var pug = new Dog();

            gs1.Name = null;
            var germanShepard1 = new GermanShepard {
                LongTail = true,
                BarkPitch = BarkPitchEnum.Low,
                Muzzle = MuzzleType.Long,
                ExtremeSenseOfSmell = true,
                BigDog = true,
                //Name = "Fred"
                
            };

            var dogs1 = new Dog {
                LongTail = false,
                BarkPitch = BarkPitchEnum.High,
                Muzzle = MuzzleType.Collapsed,
                ExtremeSenseOfSmell = false,
                
            };

            var dogs = new List<Dog>();
            dogs.Add(pug);
            dogs.Add(germanShepard);
            dogs.Add(gs1);
            dogs.Add(pug2);
            dogs.Add(pug1);
            dogs.Add(boxer1);

            foreach(var dog in dogs) {
                Console.WriteLine(dog.GetTypeOfDog());
            }

        }
    }
}
