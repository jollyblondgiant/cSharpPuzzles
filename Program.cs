using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int[] RandomArray(){
            Random rand = new Random();
            int[] randArr = new int[10];
            int min = randArr[0];
            int max = randArr[0];
            int avg = 0;
            for(var idx = 0; idx < randArr.Length; idx++){
                randArr[idx] = rand.Next(5, 26);
            }
            for(var idx = 0; idx < randArr.Length; idx++){
                avg += randArr[idx];
                if(randArr[idx]>max){max = randArr[idx];}
                if(randArr[idx]<min){min = randArr[idx];}
            }
            avg /= randArr.Length;
            Console.WriteLine($"Min: {min}; Max: {max}; Avg: {avg}");
            return randArr;
        }
        public static string TossCoin(){
            string result = " ";
            Random rand = new Random();
            Console.WriteLine("Toss a coin, coward!");
            int flip = rand.Next(0,2);
            if(flip == 0){ result = "Heads!";}
            else if (flip == 1){result = "Tails!";}
            Console.WriteLine(result);
            return result;
        }
        public static double TossCoins(int num){
            double result = 0;
            
            Random rand = new Random();
            for(var idx = 0; idx < num; idx++){
                if(TossCoin() == "Tails!"){
                    result ++;
                }
                
            }
            return result/num;
        }
        public static List<string> Names(){
            List<string> names = new List<string>{
                "Todd",
                "Tiffany",
                "Charlie",
                "Geneva",
                "Sydney"
            };
            Random rand = new Random();
            for(int t = 0; t < names.Count; t++){
                string temp = names[t];
                int r = rand.Next(t,names.Count);
                names[t] = names[r];
                names[r] = temp;
            }
            Console.WriteLine(names);
            List<string> bigNames = new List<string>();
            foreach(string name in names){
                if(name.Length > 5){
                    bigNames.Add(name);
                }
            }
            return bigNames;
        }
    }
}
