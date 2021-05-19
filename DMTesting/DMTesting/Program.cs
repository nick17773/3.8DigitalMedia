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
                { "Groove", new Genre("Groove Metal", BPM.Medium, Tuning.Standard, TimeSignature.Dynamic, SongLength.Long) },
                { "Thrash", new Genre("Thrash Metal", BPM.Fast, Tuning.Standard, TimeSignature.Static, SongLength.Medium) },
                { "Death", new Genre("Death Metal", BPM.Insane, Tuning.Standard, TimeSignature.Static, SongLength.Medium) },
                { "Tech Death", new Genre("Technical Death Metal", BPM.Insane, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium) },
                { "Doom", new Genre("Doom Metal", BPM.Slow, Tuning.Low, TimeSignature.Static, SongLength.Long) },
                { "Death/Doom", new Genre("Death Doom Metal", BPM.Slow, Tuning.Low, TimeSignature.Static, SongLength.Medium) },
                { "Sludge", new Genre("Sludge Metal", BPM.Slow, Tuning.Low, TimeSignature.Dynamic, SongLength.Long) },
                { "Power", new Genre("Power Metal", BPM.Fast, Tuning.Standard, TimeSignature.Static, SongLength.Long) },
                { "Alt", new Genre("Alternative Metal", BPM.Medium, Tuning.Low, TimeSignature.Static, SongLength.Medium)},
                { "Nu", new Genre("Nu Metal", BPM.Medium, Tuning.Low, TimeSignature.Dynamic, SongLength.Medium) },
                { "Djent", new Genre("Djent", BPM.Slow, Tuning.Low, TimeSignature.Dynamic, SongLength.Medium)},
                { "Industrial", new Genre("Industrial Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Short)}
            };
            string genreIndicator = "Your genre is:";
            string genreKey;
            string suggestedBands;
            Console.WriteLine("BPM Input");
            var BPMInput = Console.ReadLine();
            while (string.IsNullOrEmpty(BPMInput))
            {
                Console.WriteLine("BPM value cannot be empty!");
                Console.WriteLine("BPM Input");
                BPMInput = Console.ReadLine();
            }
            Console.WriteLine("Tuning Input");
            var TuningInput = Console.ReadLine();
            while (string.IsNullOrEmpty(TuningInput))
            {
                Console.WriteLine("Tuning value cannot be empty!");
                Console.WriteLine("Tuning Input");
                TuningInput = Console.ReadLine();
            }
            Console.WriteLine("Time Singature Input");
            var TimeSigInput = Console.ReadLine();
            while (string.IsNullOrEmpty(TimeSigInput))
            {
                Console.WriteLine("Time Signature value cannot be empty!");
                Console.WriteLine("Time Signature Input");
                TimeSigInput = Console.ReadLine();
            }
            Console.WriteLine("Song Length Input");
            var SongLengthInput = Console.ReadLine();
            while (string.IsNullOrEmpty(SongLengthInput))
            {
                Console.WriteLine("Song Length value cannot be empty!");
                Console.WriteLine("Song Length Input");
                SongLengthInput = Console.ReadLine();
            }
            if (TuningInput == Convert.ToString(Tuning.Standard))
            {
                if (BPMInput == Convert.ToString(BPM.Fast))
                {
                    if (TimeSigInput == Convert.ToString(TimeSignature.Static))
                    {
                        if (SongLengthInput == Convert.ToString(SongLength.Medium))
                        {
                            genreKey = "Thrash";
                            suggestedBands = "Anthrax, Slayer, Megadeth, Metallica";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator, suggestedBands);
                        }
                        else if (SongLengthInput == Convert.ToString(SongLength.Long))
                        {
                            genreKey = "Power";
                            suggestedBands = "DragonForce, Helloween, Powerwolf, Sabaton";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator, suggestedBands);
                        }
                    }
                }
                else if (BPMInput == Convert.ToString(BPM.Medium))
                {
                    if (TimeSigInput == Convert.ToString(TimeSignature.Static))
                    {
                        
                        if (SongLengthInput == Convert.ToString(SongLength.Short))
                        {
                            genreKey = "Industrial";
                            suggestedBands = "Rammstein, Nine Inch Nails, Ministry, Rob Zombie";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator, suggestedBands);
                        }
                        else if (SongLengthInput == Convert.ToString(SongLength.Medium))
                        {
                            genreKey = "Heavy";
                            suggestedBands = "Black Sabbath, Iron Maiden, Judas Priest, Dio";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator, suggestedBands);
                        }
                    }
                    else if (TimeSigInput == Convert.ToString(TimeSignature.Dynamic))
                    {
                        if(SongLengthInput == Convert.ToString(SongLength.Medium))
                        {
                            genreKey = "Prog";
                            suggestedBands = "Dream Theatre, Opeth, Gojira, Mastodon";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator, suggestedBands);
                        }
                        else if (SongLengthInput == Convert.ToString(SongLength.Long))
                        {
                            genreKey = "Groove";
                            suggestedBands = "Pantera, Damageplan, HellYeah, Lamb of God";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator, suggestedBands);
                        }
                    }
                }
                else if (BPMInput == Convert.ToString(BPM.Insane))
                {
                    if (TimeSigInput == Convert.ToString(TimeSignature.Static))
                    {
                        genreKey = "Death";
                        suggestedBands = "Death, Possessed, Obituary, Carcass";
                        GenreDisplay(genreKey, genreDictionary, genreIndicator, suggestedBands);
                    }
                    else if (TimeSigInput == Convert.ToString(TimeSignature.Dynamic))
                    {
                        genreKey = "Tech Death";
                        suggestedBands = "Death, Pestilence, Atheist, Nocturnus";
                        GenreDisplay(genreKey, genreDictionary, genreIndicator, suggestedBands);
                    }
                }
            }
            else if (TuningInput == Convert.ToString(Tuning.Low))
            {
                if (BPMInput == Convert.ToString(BPM.Slow))
                {
                    if (TimeSigInput == Convert.ToString(TimeSignature.Static))
                    {
                        if(SongLengthInput == Convert.ToString(SongLength.Long))
                        {
                            genreKey = "Doom";
                            suggestedBands = "Pagan Altar, Witchfinder General, Pentagram, Trouble";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator, suggestedBands);
                        }
                        else if(SongLengthInput == Convert.ToString(SongLength.Medium))
                        {
                            genreKey = "Death/Doom";
                            suggestedBands = "Paradise Lost, Anathema, Corrupted, The Eternal";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator, suggestedBands);
                        }
                    }
                    else if (TimeSigInput == Convert.ToString(TimeSignature.Dynamic))
                    {
                        
                        if (SongLengthInput == Convert.ToString(SongLength.Long))
                        {
                            genreKey = "Sludge";
                            suggestedBands = "Eyehategod, Crowbar, Buzzoven, Acid Bath";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator, suggestedBands);
                        }
                        else if (SongLengthInput == Convert.ToString(SongLength.Medium))
                        {
                            genreKey = "Djent";
                            suggestedBands = "Born of Osiris, Meshuggah, Periphery, Animals As Leaders";
                            GenreDisplay(genreKey, genreDictionary, genreIndicator, suggestedBands);
                        }
                    }
                }
                else if(BPMInput == Convert.ToString(BPM.Medium))
                {
                    if(TimeSigInput == Convert.ToString(TimeSignature.Static))
                    {
                        genreKey = "Alt";
                        suggestedBands = "Alice in Chains, Faith No More, Tool, System of a Down";
                        GenreDisplay(genreKey, genreDictionary, genreIndicator, suggestedBands);
                    }
                    else if (TimeSigInput == Convert.ToString(TimeSignature.Dynamic))
                    {
                        genreKey = "Nu";
                        suggestedBands = "Linkin Park, Slipknot, Korn, Disturbed";
                        GenreDisplay(genreKey, genreDictionary, genreIndicator, suggestedBands);
                    }
                }
            }
            



            static void GenreDisplay(string genreKey, Dictionary<string, Genre> genreDictionary, string genreIndicator, string suggestedBands)
            {
                Console.WriteLine("");
                Console.WriteLine(genreIndicator);
                Console.WriteLine(genreDictionary[genreKey].name);
                Console.WriteLine($"BPM: {genreDictionary[genreKey].bpm}");
                Console.WriteLine($"Tuning: {genreDictionary[genreKey].tuning}");
                Console.WriteLine($"Time Signature: {genreDictionary[genreKey].timeSignature}");
                Console.WriteLine($"Song Length: {genreDictionary[genreKey].songLength}");
                Console.WriteLine($"Suggested bands: {suggestedBands}");
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
