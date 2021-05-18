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
                { "Heavy", new Genre("Heavy Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static) },
                { "Prog", new Genre("Progressive Metal", BPM.Medium, Tuning.Standard, TimeSignature.Dynamic)},
                { "Thrash", new Genre("Thrash Metal", BPM.Fast, Tuning.Standard, TimeSignature.Static) },
                { "Death", new Genre("Death Metal", BPM.Insane, Tuning.Standard, TimeSignature.Static)},
                { "Tech Death", new Genre("Technical Death Metal", BPM.Insane, Tuning.Standard, TimeSignature.Dynamic)},
                { "Doom", new Genre("Doom Metal", BPM.Slow, Tuning.Low, TimeSignature.Static)},
                { "Sludge", new Genre("Sludge Metal", BPM.Slow, Tuning.Low, TimeSignature.Dynamic) }
            };
            string genreIndicator = "Your genre is:";


           
                Console.WriteLine("Tuning Input");
                var TuningInput = Console.ReadLine();
                Console.WriteLine("BPM Input");
                var BPMInput = Console.ReadLine();
                Console.WriteLine("Time Singature Input");
                var TimeSigInput = Console.ReadLine();
                if (TuningInput == Convert.ToString(Tuning.Standard))
                {
                

               
                    if(BPMInput == Convert.ToString(BPM.Fast))
                    {
                    
                        if (TimeSigInput == Convert.ToString(TimeSignature.Static))
                        {
                            string genreKey = "Thrash";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator);
                        
                        }

                    }
                    else if (BPMInput == Convert.ToString(BPM.Medium))
                    {
                    
                    
                        if (TimeSigInput == Convert.ToString(TimeSignature.Static))
                        {
                            string genreKey = "Heavy";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator);
                        
                        }
                        else if (TimeSigInput == Convert.ToString(TimeSignature.Dynamic))
                        {
                            string genreKey = "Prog";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator);
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
                    //else if (BPMInput == Convert.ToString(BPM.Slow))
                    //{
                    //    if(TimeSigInput == Convert.ToString(TimeSignature.Static))
                    //    {
                    //        string genreKey = "Sludge";
                    //    }
                    //}
                    

                }
                else if (TuningInput == Convert.ToString(Tuning.Low))
                {
                    if(BPMInput == Convert.ToString(BPM.Slow)) 
                    {
                        if(TimeSigInput == Convert.ToString(TimeSignature.Static))
                        {
                            string genreKey = "Doom";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator);
                        }
                        else if(TimeSigInput == Convert.ToString(TimeSignature.Dynamic))
                        {
                            string genreKey = "Sludge";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator);
                        }
                    }
                }


          
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
    public enum Tuning
    {
        Standard,
        Drop,
        Low,
        Special
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
        //public string tuning;
        public Tuning tuning;
        //public (int, int) timeSignature;
        public TimeSignature timeSignature;

        public Genre(string name, BPM bpm, Tuning tuning, /*(int, int) timeSignature*/ TimeSignature timeSignature)
        {
            this.name = name;
            this.bpm = bpm;
            this.tuning = tuning;
            this.timeSignature = timeSignature;
        }
    }
}
