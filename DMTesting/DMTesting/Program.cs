using System;
using System.Collections.Generic;

namespace DMTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Genre> genreDictionary = new Dictionary<string, Genre>
            {
                { "Heavy", new Genre("Heavy Metal", BPM.Medium, "Standard", TimeSignature.Static) },
                { "Thrash", new Genre("Thrash Metal", BPM.Fast, "Standard", TimeSignature.Static) }
            };

            var genreIndicator = "Your genre is:";
            Console.WriteLine("Tuning Input");
            var TuningInput = Console.ReadLine();
            
            if(TuningInput == "Standard")
            {
                

                Console.WriteLine("BPM Input");
                var BPMInput = Console.ReadLine();
                if(BPMInput == "Fast")
                {
                    Console.WriteLine(genreIndicator);
                    Console.WriteLine(genreDictionary["Thrash"].name);
                    Console.WriteLine($"BPM: {genreDictionary["Thrash"].bpm}");
                    Console.WriteLine($"Tuning: {genreDictionary["Thrash"].tuning}");
                    Console.WriteLine($"Time Signature: {genreDictionary["Thrash"].timeSignature}");
                }
                else if (BPMInput == "Medium")
                {
                    Console.WriteLine(genreIndicator);
                    Console.WriteLine(genreDictionary["Heavy"].name);
                    Console.WriteLine($"BPM: {genreDictionary["Heavy"].bpm}");
                    Console.WriteLine($"Tuning: {genreDictionary["Heavy"].tuning}");
                    Console.WriteLine($"Time Signature: {genreDictionary["Heavy"].timeSignature}");
                }
            }

            //Debug.WriteLine(genreDictionary["Lol"]);

        }
    }
    public enum BPM
    {
        Slow,
        Medium,
        Fast,
        Insane
    }

    public enum TimeSignature
    {
        Dynamic,
        Static,
        Weird
    }

    public class Genre
    {
        public string name;
        public BPM bpm;
        public string tuning;
        //public (int, int) timeSignature;
        public TimeSignature timeSignature;

        public Genre(string name, BPM bpm, string tuning, /*(int, int) timeSignature*/ TimeSignature timeSignature)
        {
            this.name = name;
            this.bpm = bpm;
            this.tuning = tuning;
            this.timeSignature = timeSignature;
        }
    }
}
