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
                { "Heavy Metal", new Genre("Heavy Metal", BPM.Medium, "Standard", (4, 4)) },
                { "Thrash Metal", new Genre("Thrash Metal", BPM.Fast, "Standard", (4, 4)) }
            };



            //Debug.WriteLine(genreDictionary["Lol"]);

        }
    }
    public enum BPM
    {
        Slow,
        Medium,
        Fast
    }

    public class Genre
    {
        public string name;
        public BPM bpm;
        public string tuning;
        public (int, int) timeSignature;

        public Genre(string name, BPM bpm, string tuning, (int, int) timeSignature)
        {
            this.name = name;
            this.bpm = bpm;
            this.tuning = tuning;
            this.timeSignature = timeSignature;
        }
    }
}
