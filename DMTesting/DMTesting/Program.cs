using System;
using System.Collections.Generic;

namespace DMTesting
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Dictionary<string, Genre> genreDictionary = new()
            {
                { "Heavy", new Genre("Heavy Metal", BPM.Medium, "Standard", TimeSignature.Static) },
                { "Thrash", new Genre("Thrash Metal", BPM.Fast, "Standard", TimeSignature.Static) },
                { "Death", new Genre("Death Metal", BPM.Insane, "Standard", TimeSignature.Static)},
                { "Tech Death", new Genre("Technical Death Metal", BPM.Insane, "Standard", TimeSignature.Dynamic)}
            };
            string genreIndicator = "Your genre is:";




            Console.WriteLine("Tuning Input");
            var TuningInput = Console.ReadLine();
            Console.WriteLine("BPM Input");
            var BPMInput = Console.ReadLine();
            Console.WriteLine("Time Singature Input");
            var TimeSigInput = Console.ReadLine();
            if (TuningInput == "Standard")
            {
                

                //Console.WriteLine("BPM Input");
                //var BPMInput = Console.ReadLine();
                if(BPMInput == Convert.ToString(BPM.Fast))
                {
                    //Console.WriteLine(genreIndicator);
                    //Console.WriteLine(genreDictionary["Thrash"].name);
                    //Console.WriteLine($"BPM: {genreDictionary["Thrash"].bpm}");
                    //Console.WriteLine($"Tuning: {genreDictionary["Thrash"].tuning}");
                    //Console.WriteLine($"Time Signature: {genreDictionary["Thrash"].timeSignature}");
                    if (TimeSigInput == Convert.ToString(TimeSignature.Static))
                    {
                        string genreKey = "Thrash";
                        GenreDisplay(genreKey, genreDictionary, genreIndicator);
                        //Console.WriteLine(genreIndicator);
                        //Console.WriteLine(genreDictionary["Thrash"].name);
                        //Console.WriteLine($"BPM: {genreDictionary["Thrash"].bpm}");
                        //Console.WriteLine($"Tuning: {genreDictionary["Thrash"].tuning}");
                        //Console.WriteLine($"Time Signature: {genreDictionary["Thrash"].timeSignature}");
                    }

                }
                else if (BPMInput == Convert.ToString(BPM.Medium))
                {
                    //Console.WriteLine(genreIndicator);
                    //Console.WriteLine(genreDictionary["Heavy"].name);
                    //Console.WriteLine($"BPM: {genreDictionary["Heavy"].bpm}");
                    //Console.WriteLine($"Tuning: {genreDictionary["Heavy"].tuning}");
                    //Console.WriteLine($"Time Signature: {genreDictionary["Heavy"].timeSignature}");
                    
                    if (TimeSigInput == Convert.ToString(TimeSignature.Static))
                    {
                        string genreKey = "Heavy";
                        GenreDisplay(genreKey, genreDictionary, genreIndicator);
                        //Console.WriteLine(genreIndicator);
                        //Console.WriteLine(genreDictionary[genreKey].name);
                        //Console.WriteLine($"BPM: {genreDictionary[genreKey].bpm}");
                        //Console.WriteLine($"Tuning: {genreDictionary[genreKey].tuning}");
                        //Console.WriteLine($"Time Signature: {genreDictionary[genreKey].timeSignature}");
                    }
                }
                else if (BPMInput == Convert.ToString(BPM.Insane))
                {
                    if(TimeSigInput == Convert.ToString(TimeSignature.Static))
                    {
                        string genreKey = "Death";
                        GenreDisplay(genreKey, genreDictionary, genreIndicator);

                    }
                    else if(TimeSigInput == Convert.ToString(TimeSignature.Dynamic))
                    {
                        string genreKey = "Tech Death";
                        GenreDisplay(genreKey, genreDictionary, genreIndicator);
                    }
                }

            }

            //Debug.WriteLine(genreDictionary["Lol"]);
            static void GenreDisplay(string genreKey, Dictionary<string, Genre> genreDictionary, string genreIndicator)
            {
                Console.WriteLine(genreIndicator);
                Console.WriteLine(genreDictionary[genreKey].name);
                Console.WriteLine($"BPM: {genreDictionary[genreKey].bpm}");
                Console.WriteLine($"Tuning: {genreDictionary[genreKey].tuning}");
                Console.WriteLine($"Time Signature: {genreDictionary[genreKey].timeSignature}");
            }

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
