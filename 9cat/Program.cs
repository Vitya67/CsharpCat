using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public enum Gender
    {
        Male,
        Female
    }

    class Cat
    {
        public string Name { get; }
        public string Gender { get; }
        private double energy;

        private double Energy
        {
            get { return energy; }
            set
            {
                energy = value;
                if (value < MinEnergy)
                {
                    throw new Exception("Not enough energy to jump");
                }
                else if (value > MaxEnergy)
                {
                    energy = MaxEnergy;
                }
                else

                {
                    energy = value;
                }
            }



        }


        public Cat(string name, string gender, double energy)
        {
            Name = name;
            Gender = gender;
            energy = energy;
        }
        public static readonly double MaxEnergy = 20;
        public static readonly double MinEnergy = 0;
        public static readonly double SleepEnergyGain = 10;
        public static readonly double JumpEnergyDrain = 0.5;
        Cat(string name, string gender)
        {
            Name = name;
            Gender = gender;
            Energy = MaxEnergy;
        }

        public void Jump()
        {
            Energy -= JumpEnergyDrain;
        }

        public void Sleep()
        {
            Energy += SleepEnergyGain;

        }
    }
}