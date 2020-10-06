using System;
using System.Collections.Generic;

namespace tamagotchi
{
    public class tamagotchi
    {
        private int hunger = 0;

        private int boredome = 0;

        private List<string> words = new List<string>() {""}; 

        private bool isAlive = true;

        Random generator = new Random();

        public string name;

        public void Tick()
        {
            if(hunger < 10){
                hunger++;
            }
            else if(hunger == 10){
                isAlive = false;
            }
            
            if(boredome < 10){
                boredome++;
            }
            else if(boredome == 10){
                isAlive=false;
            }
        }

        public void Feed()
        {
            hunger =- 5;
        }

        public void Hi()
        {

        }

        public void Teach(string words)
        {

        }

        public void PrintStats()
        {

        }

        public bool GetAlive()
        {
            return;
        }

        private void ReduceBoredom()
        {

        }
    }
}
