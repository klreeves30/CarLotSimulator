using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        public Car()
        {
            

        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        public int Year { get; set; }

        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        public Car(string make, string model, string engineNoise, string honkNoise, bool isDriveable, int year)
        {
           
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            Year = year;       
            
            
        }



        public void  MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);

        }

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }

    }





}
