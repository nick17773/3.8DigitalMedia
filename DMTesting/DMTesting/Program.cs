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
                { "Heavy", new Genre("Heavy Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Medium) },
                { "Prog", new Genre("Progressive Metal", BPM.Medium, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium) },
                { "Thrash", new Genre("Thrash Metal", BPM.Fast, Tuning.Standard, TimeSignature.Static, SongLength.Medium) },
                { "Death", new Genre("Death Metal", BPM.Insane, Tuning.Standard, TimeSignature.Static, SongLength.Medium) },
                { "Tech Death", new Genre("Technical Death Metal", BPM.Insane, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium) },
                { "Doom", new Genre("Doom Metal", BPM.Slow, Tuning.Low, TimeSignature.Static, SongLength.Long) },
                { "Sludge", new Genre("Sludge Metal", BPM.Slow, Tuning.Low, TimeSignature.Dynamic, SongLength.Long) },
                { "Power", new Genre("Power Metal", BPM.Fast, Tuning.Standard, TimeSignature.Static, SongLength.Long) },
                { "Alt", new Genre("Alternative Metal", BPM.Medium, Tuning.Low, TimeSignature.Static, SongLength.Medium)},
                { "Nu", new Genre("Nu Metal", BPM.Medium, Tuning.Low, TimeSignature.Dynamic, SongLength.Medium) }
            };
            string genreIndicator = "Your genre is:";
            Console.WriteLine("Tuning Input");
            var TuningInput = Console.ReadLine();
            Console.WriteLine("BPM Input");
            var BPMInput = Console.ReadLine();
            Console.WriteLine("Time Singature Input");
            var TimeSigInput = Console.ReadLine();
            Console.WriteLine("Song Length Input");
            var SongLengthInput = Console.ReadLine();
            if (TuningInput == Convert.ToString(Tuning.Standard))
            {
                if (BPMInput == Convert.ToString(BPM.Fast))
                {
                    if (TimeSigInput == Convert.ToString(TimeSignature.Static))
                    {
                        if (SongLengthInput == Convert.ToString(SongLength.Medium))
                        {
                            string genreKey = "Thrash";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator);
                        }
                        else if (SongLengthInput == Convert.ToString(SongLength.Long))
                        {
                            string genreKey = "Power";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator);
                        }
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
                    if (TimeSigInput == Convert.ToString(TimeSignature.Static))
                    {
                        string genreKey = "Death";
                        GenreDisplay(genreKey, genreDictionary, genreIndicator);
                    }
                    else if (TimeSigInput == Convert.ToString(TimeSignature.Dynamic))
                    {
                        string genreKey = "Tech Death";
                        GenreDisplay(genreKey, genreDictionary, genreIndicator);
                    }
                }
            }
            else if (TuningInput == Convert.ToString(Tuning.Low))
            {
                if (BPMInput == Convert.ToString(BPM.Slow))
                {
                    if (TimeSigInput == Convert.ToString(TimeSignature.Static))
                    {
                        string genreKey = "Doom";
                        GenreDisplay(genreKey, genreDictionary, genreIndicator);
                    }
                    else if (TimeSigInput == Convert.ToString(TimeSignature.Dynamic))
                    {
                        string genreKey = "Sludge";
                        GenreDisplay(genreKey, genreDictionary, genreIndicator);
                    }
                }
                else if(BPMInput == Convert.ToString(BPM.Medium))
                {
                    if(TimeSigInput == Convert.ToString(TimeSignature.Static))
                    {
                        string genreKey = "Alt";
                        GenreDisplay(genreKey, genreDictionary, genreIndicator);
                    }
                    else if (TimeSigInput == Convert.ToString(TimeSignature.Dynamic))
                    {
                        string genreKey = "Nu";
                        GenreDisplay(genreKey, genreDictionary, genreIndicator);
                    }
                }
            }
            



            static void GenreDisplay(string genreKey, Dictionary<string, Genre> genreDictionary, string genreIndicator)
            {
                Console.WriteLine("");
                Console.WriteLine(genreIndicator);
                Console.WriteLine(genreDictionary[genreKey].name);
                Console.WriteLine($"BPM: {genreDictionary[genreKey].bpm}");
                Console.WriteLine($"Tuning: {genreDictionary[genreKey].tuning}");
                Console.WriteLine($"Time Signature: {genreDictionary[genreKey].timeSignature}");
                Console.WriteLine($"Song Length {genreDictionary[genreKey].songLength}");

            }

        }
    }

    public enum SongLength
    {
        Short,
        Medium,
        Long,
        Extreme
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
        public Tuning tuning;
        public TimeSignature timeSignature;
        public SongLength songLength;

        public Genre(string name, BPM bpm, Tuning tuning, TimeSignature timeSignature, SongLength songLength)
        {
            this.name = name;
            this.bpm = bpm;
            this.tuning = tuning;
            this.timeSignature = timeSignature;
            this.songLength = songLength;
        }
    }
}
