
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace _3._8DigitalMedia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string genreKey;
        public string suggestedBands;

        public string Slow = Convert.ToString(BPM.Slow);
        public string MediumBPMS = Convert.ToString(BPM.Medium);
        public string Fast = Convert.ToString(BPM.Fast);
        public string Insane = Convert.ToString(BPM.Insane);

        public string Standard = Convert.ToString(Tuning.Standard);
        public string Low = Convert.ToString(Tuning.Low);
        

        public string Static = Convert.ToString(TimeSignature.Static);
        public string Dynamic = Convert.ToString(TimeSignature.Dynamic);
        

        public string Short = Convert.ToString(SongLength.Short);
        public string MediumLength = Convert.ToString(SongLength.Medium);
        public string Long = Convert.ToString(SongLength.Long);
        public string Extreme = Convert.ToString(SongLength.Extreme);

        public string ClassicI = Convert.ToString(Instrumentation.Classic);
        public string OrchestralI = Convert.ToString(Instrumentation.Orchestral);
        public string TradFolk = Convert.ToString(Instrumentation.Folk);
        public string MongolFolk = Convert.ToString(Instrumentation.Mongolian);
        public string VikingrFolk = Convert.ToString(Instrumentation.Nordic);

        public Dictionary<string, Genre> genreDictionary = new Dictionary<string, Genre>()
            {
                { "Heavy", new Genre("Heavy Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Classic) },
                { "Prog", new Genre("Progressive Metal", BPM.Medium, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium, Instrumentation.Classic) },
                { "Groove", new Genre("Groove Metal", BPM.Medium, Tuning.Standard, TimeSignature.Dynamic, SongLength.Long, Instrumentation.Classic) },
                { "Thrash", new Genre("Thrash Metal", BPM.Fast, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Classic) },
                { "Black", new Genre("Black Metal", BPM.Fast, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium, Instrumentation.Classic) },
                { "Death", new Genre("Death Metal", BPM.Insane, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Classic) },
                { "Tech Death", new Genre("Technical Death Metal", BPM.Insane, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium, Instrumentation.Classic) },
                { "Doom", new Genre("Doom Metal", BPM.Slow, Tuning.Low, TimeSignature.Static, SongLength.Long, Instrumentation.Classic) },
                { "Death/Doom", new Genre("Death Doom Metal", BPM.Slow, Tuning.Low, TimeSignature.Static, SongLength.Medium, Instrumentation.Classic) },
                { "Sludge", new Genre("Sludge Metal", BPM.Slow, Tuning.Low, TimeSignature.Dynamic, SongLength.Long, Instrumentation.Classic) },
                { "Power", new Genre("Power Metal", BPM.Fast, Tuning.Standard, TimeSignature.Static, SongLength.Long, Instrumentation.Classic) },
                { "Alt", new Genre("Alternative Metal", BPM.Medium, Tuning.Low, TimeSignature.Static, SongLength.Medium, Instrumentation.Classic) },
                { "Nu", new Genre("Nu Metal", BPM.Medium, Tuning.Low, TimeSignature.Dynamic, SongLength.Medium, Instrumentation.Classic) },
                { "Djent", new Genre("Djent", BPM.Slow, Tuning.Low, TimeSignature.Dynamic, SongLength.Medium, Instrumentation.Classic) },
                { "Industrial", new Genre("Industrial Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Techno) },
                { "Folk", new Genre("Folk Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Folk) },
                { "Viking", new Genre("Viking Metal", BPM.Slow, Tuning.Low, TimeSignature.Static, SongLength.Medium, Instrumentation.Nordic) },
                { "Pagan", new Genre("Pagan Metal", BPM.Slow, Tuning.Low, TimeSignature.Static, SongLength.Long, Instrumentation.Nordic) },
                { "Mongol", new Genre("Mongolian Folk Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Mongolian) },
                { "SymphonicBlack", new Genre("Symphonic Black Metal", BPM.Fast, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium, Instrumentation.Orchestral) },
                { "Symphonic", new Genre("Symphonic Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Orchestral) },
                { "SymphonicDeath", new Genre("Symphonic Death Metal", BPM.Insane, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Orchestral) },
                { "SymphonicPower", new Genre("Power Metal", BPM.Fast, Tuning.Standard, TimeSignature.Static, SongLength.Long, Instrumentation.Orchestral) }
            };

        public MainWindow()
        {
            
            InitializeComponent();
            
            SlowBPM.Content = BPM.Slow;
            MediumBPM.Content = BPM.Medium;
            FastBPM.Content = BPM.Fast;
            InsaneBPM.Content = BPM.Insane;

            StandardTuning.Content = Tuning.Standard;
            LowTuning.Content = Tuning.Low;
            

            StaticTimeSig.Content = TimeSignature.Static;
            DynamicTimeSig.Content = TimeSignature.Dynamic;
            

            //ShortSongLength.Content = SongLength.Short;
            MediumSongLength.Content = SongLength.Medium;
            LongSongLength.Content = SongLength.Long;
            //ExtremeSongLength.Content = SongLength.Extreme;

            Classic.Content = Instrumentation.Classic;
            Orchestral.Content = Instrumentation.Orchestral;
            TraditionalFolk.Content = Instrumentation.Folk;
            MongolianFolk.Content = Instrumentation.Mongolian;
            NorseFolk.Content = Instrumentation.Nordic;

            

            TotalChecker();
            TuningBox.IsEnabled = false;
            TimeSigBox.IsEnabled = false;
            

            


        }

        public void TotalChecker()
        {
            var GroupedValues = genreDictionary.GroupBy(x => x.Value.bpm);
            List<string> AllTuningStandardValues = new List<string>();
            List<string> AllTuningLowValues = new List<string>();
            List<string> AllBPMSlowValues = new List<string>();
            List<string> AllBPMMediumValues = new List<string>();
            List<string> AllBPMFastValues = new List<string>();
            List<string> AllBPMInsaneValues = new List<string>();
            List<string> AllTimeSigStaticValues = new List<string>();
            List<string> AllTimeSigDynamicValues = new List<string>();
            List<string> AllSongLenShortValues = new List<string>();
            List<string> AllSongLenMediumValues = new List<string>();
            List<string> AllSongLenLongValues = new List<string>();
            List<string> AllSongLenExtremeValues = new List<string>();
            List<string> AllInstClassicValues = new List<string>();
            List<string> AllInstOrchestralValues = new List<string>();
            List<string> AllInstFolkValues = new List<string>();
            List<string> AllInstMongolValues = new List<string>();
            List<string> AllInstNorseValues = new List<string>();
            List<string> AllInstTechnoValues = new List<string>();

            

            foreach (var agv in GroupedValues)
            {
                var allTuningLookup = agv.ToLookup(e => e.Value.tuning);
                var allBPMLookup = agv.ToLookup(e => e.Value.bpm);
                var allTimeSigLookup = agv.ToLookup(e => e.Value.timeSignature);
                var allSongLenLookup = agv.ToLookup(e => e.Value.songLength);
                var allInstLookup = agv.ToLookup(e => e.Value.instrumentation);

                var StandardTuningCheck = allTuningLookup[Tuning.Standard];
                var LowTuningCheck = allTuningLookup[Tuning.Low];

                var SlowBPMCheck = allBPMLookup[BPM.Slow];
                var MediumBPMCheck = allBPMLookup[BPM.Medium];
                var FastBPMCheck = allBPMLookup[BPM.Fast];
                var InsaneBPMCheck = allBPMLookup[BPM.Insane];

                var StaticTimeSigCheck = allTimeSigLookup[TimeSignature.Static];
                var DynamicTimeSigCheck = allTimeSigLookup[TimeSignature.Dynamic];

                var ShortSongLengthCheck = allSongLenLookup[SongLength.Short];
                var MediumSongLengthCheck = allSongLenLookup[SongLength.Medium];
                var LongSongLengthCheck = allSongLenLookup[SongLength.Long];
                var ExtremeSongLengthCheck = allSongLenLookup[SongLength.Extreme];

                var ClassicInstCheck = allInstLookup[Instrumentation.Classic];
                var OrchestralInstCheck = allInstLookup[Instrumentation.Orchestral];
                var FolkInstCheck = allInstLookup[Instrumentation.Folk];
                var MongolInstCheck = allInstLookup[Instrumentation.Mongolian];
                var NorseInstCheck = allInstLookup[Instrumentation.Nordic];
                var TechnoInstCheck = allInstLookup[Instrumentation.Techno];

                foreach (var CheckStr in StandardTuningCheck)
                    {
                        string selectedTuning = CheckStr.Key;
                        AllTuningStandardValues.Add(selectedTuning);
                        int StdrdCheck = AllTuningStandardValues.Count();
                        StandardTuning.Content = Tuning.Standard + $" ({StdrdCheck} Genres)";
                    }
                foreach (var CheckStr in LowTuningCheck)
                    {
                        string selectedTuning = CheckStr.Key;
                        AllTuningLowValues.Add(selectedTuning);
                        int LowCheck = AllTuningLowValues.Count();
                        LowTuning.Content = Tuning.Low + $" ({LowCheck} Genres)";
                    }
                foreach (var CheckStr in SlowBPMCheck)
                {
                    string selectedBPM = CheckStr.Key;
                    AllBPMSlowValues.Add(selectedBPM);
                    int SlowCheck = AllBPMSlowValues.Count();
                    SlowBPM.Content = BPM.Slow + $" ({SlowCheck} Genres)";
                }
                foreach (var CheckStr in MediumBPMCheck)
                {
                    string selectedTuning = CheckStr.Key;
                    AllBPMMediumValues.Add(selectedTuning);
                    int BPMMediumCheck = AllBPMMediumValues.Count();
                    MediumBPM.Content = BPM.Medium + $" ({BPMMediumCheck} Genres)";
                }
                foreach (var CheckStr in FastBPMCheck)
                {
                    string selectedBPM = CheckStr.Key;
                    AllBPMFastValues.Add(selectedBPM);
                    int FastCheck = AllBPMFastValues.Count();
                    FastBPM.Content = BPM.Fast + $" ({FastCheck} Genres)";
                }
                foreach (var CheckStr in InsaneBPMCheck)
                {
                    string selectedBPM = CheckStr.Key;
                    AllBPMInsaneValues.Add(selectedBPM);
                    int InsaneCheck = AllBPMInsaneValues.Count();
                    InsaneBPM.Content = BPM.Insane + $" ({InsaneCheck} Genres)";
                }
                foreach (var CheckStr in StaticTimeSigCheck)
                {
                    string selectedTimeSig = CheckStr.Key;
                    AllTimeSigStaticValues.Add(selectedTimeSig);
                    int StaticCheck = AllTimeSigStaticValues.Count();
                    StaticTimeSig.Content = TimeSignature.Static + $" ({StaticCheck} Genres)";
                }
                foreach (var CheckStr in DynamicTimeSigCheck)
                {
                    string selectedTimeSig = CheckStr.Key;
                    AllTimeSigDynamicValues.Add(selectedTimeSig);
                    int DynamicCheck = AllTimeSigDynamicValues.Count();
                    DynamicTimeSig.Content = TimeSignature.Dynamic + $" ({DynamicCheck} Genres)";
                }
                //foreach (var CheckStr in ShortSongLengthCheck)
                //{
                //    string selectedSongLength = CheckStr.Key;
                //    AllSongLenShortValues.Add(selectedSongLength);
                //    int ShortCheck = AllSongLenShortValues.Count();
                //    ShortSongLength.Content = SongLength.Short + $" ({ShortCheck})";
                //}
                foreach (var CheckStr in MediumSongLengthCheck)
                {
                    string selectedSongLength = CheckStr.Key;
                    AllSongLenMediumValues.Add(selectedSongLength);
                    int SongLenMediumCheck = AllSongLenMediumValues.Count();
                    MediumSongLength.Content = SongLength.Medium + $" ({SongLenMediumCheck} Genres)";
                }
                foreach (var CheckStr in LongSongLengthCheck)
                {
                    string selectedSongLength = CheckStr.Key;
                    AllSongLenLongValues.Add(selectedSongLength);
                    int LongCheck = AllSongLenLongValues.Count();
                    LongSongLength.Content = SongLength.Long + $" ({LongCheck} Genres)";
                }
                //foreach (var CheckStr in ExtremeSongLengthCheck)
                //{
                //    string selectedSongLength = CheckStr.Key;
                //    AllSongLenExtremeValues.Add(selectedSongLength);
                //    int ExtremeCheck = AllSongLenExtremeValues.Count();
                //    ExtremeSongLength.Content = SongLength.Extreme + $" ({ExtremeCheck})";
                //}
                foreach (var CheckStr in ClassicInstCheck)
                {
                    string selectedInstrumentation = CheckStr.Key;
                    AllInstClassicValues.Add(selectedInstrumentation);
                    int ClassicCheck = AllInstClassicValues.Count();
                    Classic.Content = Instrumentation.Classic + $" ({ClassicCheck} Genres)";
                }
                foreach (var CheckStr in OrchestralInstCheck)
                {
                    string selectedInstrumentation = CheckStr.Key;
                    AllInstOrchestralValues.Add(selectedInstrumentation);
                    int OrchestralCheck = AllInstOrchestralValues.Count();
                    Orchestral.Content = Instrumentation.Orchestral + $" ({OrchestralCheck} Genres)";
                }
                foreach (var CheckStr in FolkInstCheck)
                {
                    string selectedInstrumentation = CheckStr.Key;
                    AllInstFolkValues.Add(selectedInstrumentation);
                    int FolkCheck = AllInstFolkValues.Count();
                    TraditionalFolk.Content = Instrumentation.Folk + $" ({FolkCheck} Genres)";
                }
                foreach (var CheckStr in MongolInstCheck)
                {
                    string selectedInstrumentation = CheckStr.Key;
                    AllInstMongolValues.Add(selectedInstrumentation);
                    int MongolCheck = AllInstMongolValues.Count();
                    MongolianFolk.Content = Instrumentation.Mongolian + $" ({MongolCheck} Genres)";
                }
                foreach (var CheckStr in NorseInstCheck)
                {
                    string selectedInstrumentation = CheckStr.Key;
                    AllInstNorseValues.Add(selectedInstrumentation);
                    int NorseCheck = AllInstNorseValues.Count();
                    NorseFolk.Content = Instrumentation.Nordic + $" ({NorseCheck} Genres)";
                }
                foreach (var CheckStr in TechnoInstCheck)
                {
                    string selectedInstrumentation = CheckStr.Key;
                    AllInstTechnoValues.Add(selectedInstrumentation);
                    int TechnoCheck = AllInstTechnoValues.Count();
                    Techno.Content = Instrumentation.Techno + $" ({TechnoCheck} Genres)";
                }


            }
            
        }
        public void Check()
        {
            string TuningInput = Convert.ToString(TuningLabel.Tag);
            string BPMInput = Convert.ToString(BPMLabel.Tag);
            string TimeSigInput = Convert.ToString(TimeSigLabel.Tag);
            string SongLengthInput = Convert.ToString(SongLengthLabel.Tag);
            string InstrumentationInput = Convert.ToString(InstrumentationLabel.Tag);

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic
                )
            {
                genreKey = "Heavy";
                suggestedBands = "Black Sabbath, Iron Maiden, Judas Priest, Dio";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic
                )
            {
                genreKey = "Prog";
                suggestedBands = "Dream Theatre, Opeth, Gojira, Mastodon";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Groove";
                suggestedBands = "Pantera, Damageplan, Alien Weaponry, Lamb of God";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == FastBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Thrash";
                suggestedBands = "Anthrax, Slayer, Megadeth, Metallica";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == FastBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Black";
                suggestedBands = "Mayhem, Darkthrone, Venom, Paracoccidioidomicosisproctitissarcomucosis";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == InsaneBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Death";
                suggestedBands = "Death, Possessed, Feared, XavlegbmaofffassssitimiwoamndutroabcwapwaeiippohfffX";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == InsaneBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Tech Death";
                suggestedBands = "Death, Pestilence, Atheist, Nocturnus";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == SlowBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Doom";
                suggestedBands = "Pagan Altar, Witchfinder General, Pentagram, Trouble";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == SlowBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Death/Doom";
                suggestedBands = "Paradise Lost, Anathema, Mournful Congregation, The Eternal";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == SlowBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Sludge";
                suggestedBands = "Eyehategod, Crowbar, Buzzoven, Acid Bath";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == FastBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Power";
                suggestedBands = "DragonForce, Helloween, Powerwolf, Sabaton";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Alt";
                suggestedBands = "Alice in Chains, Faith No More, Tool, System of a Down";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Nu";
                suggestedBands = "Linkin Park, Slipknot, Korn, Disturbed";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == SlowBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Djent";
                suggestedBands = "Born of Osiris, Meshuggah, Periphery, Animals As Leaders";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Techno)
            {
                genreKey = "Industrial";
                suggestedBands = "Rammstein, Nine Inch Nails, Ministry, Rob Zombie";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == TraditionalFolk)
            {
                genreKey = "Folk";
                suggestedBands = "Alestorm, Korpiklaani, Tyr, Wintersun";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }
            
            if (BPMBox.SelectedItem == SlowBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == NorseFolk)
            {
                genreKey = "Viking";
                suggestedBands = "Amon Amarth, Burzum, Satyricon, Tyr";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }
            
            if (BPMBox.SelectedItem == SlowBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == NorseFolk)
            {
                genreKey = "Pagan";
                suggestedBands = "Moonsorrow, Korpiklaani, Kampfar, Amon Amarth";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }
            
            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == MongolianFolk)
            {
                genreKey = "Mongol";
                suggestedBands = "The HU, Tengger Cavalry, Growl of Clown, Hurd";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
                
            }
            
            if (BPMBox.SelectedItem == FastBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Orchestral)
            {
                genreKey = "SymphonicBlack";
                suggestedBands = "Dimmu Borgir, Emperor, Carach Angren, Cradle of Filth";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Orchestral) 
            {
                genreKey = "Symphonic";
                suggestedBands = "Therion, Nightwish, Rhapsody of Fire, Within Temptation";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == InsaneBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Orchestral)
            {
                genreKey = "SymphonicDeath";
                suggestedBands = "Children of Bodom, Fleshgod Apocalypse, Make them Suffer, Betraying the Martyrs";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == FastBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Orchestral)
            {
                genreKey = "SymphonicPower";
                suggestedBands = "Twilight Force, Kamelot, Rhapsody of Fire, Nightwish";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMInput == "" &&
            TuningInput == "" &&
            TimeSigInput == "" &&
            SongLengthInput == "" &&
            InstrumentationInput == "")
            {
                GenreLabel.Content = "PLEASE SELECT SOME VALUES BEFORE PRESSING CALCULATE";
                SuggestedBandsLabel.Content = "NO SUGGESTED BANDS FOR UNKNOWN GENRE";

            }

        }
        public void SuggestedBPMCheck()
        {
            var BPMInput = BPMBox.SelectedItem;
            var GroupedValues = genreDictionary.GroupBy(x => x.Value.bpm);
            List<string> BPMValues = new List<string>();
            foreach (var gv in GroupedValues)
            {
                var BPMlookup = gv.ToLookup(e => e.Value.bpm);
                if (BPMInput == SlowBPM)
                {
                    var selectedBPM = BPMlookup[BPM.Slow];
                    foreach (var str in selectedBPM)
                    {
                        string selectedGenre = str.Key;
                        BPMValues.Add(selectedGenre);
                        string combinedBPMValues = String.Join(", ", BPMValues);
                        SuggestedByBPM.Text = combinedBPMValues;
                    }
                }
                else if (BPMInput == MediumBPM)
                {
                    var selectedBPM = BPMlookup[BPM.Medium];
                    foreach (var str in selectedBPM)
                    {
                        string selectedGenre = str.Key;
                        BPMValues.Add(selectedGenre);
                        string combinedBPMValues = String.Join(", ", BPMValues);
                        SuggestedByBPM.Text = combinedBPMValues;
                    }
                }
                else if (BPMInput == FastBPM)
                {
                    var selectedBPM = BPMlookup[BPM.Fast];
                    foreach (var str in selectedBPM)
                    {
                        string selectedGenre = str.Key;
                        BPMValues.Add(selectedGenre);
                        string combinedBPMValues = String.Join(", ", BPMValues);
                        SuggestedByBPM.Text = combinedBPMValues;
                    }
                }
                else if (BPMInput == InsaneBPM)
                {
                    var selectedBPM = BPMlookup[BPM.Insane];
                    foreach (var str in selectedBPM)
                    {
                        string selectedGenre = str.Key;
                        BPMValues.Add(selectedGenre);
                        string combinedBPMValues = String.Join(", ", BPMValues);
                        SuggestedByBPM.Text = combinedBPMValues;
                    }
                }
            }
        }
        public void SuggestedTuningCheck()
        {
            var TuningInput = TuningBox.SelectedItem;
            var GroupedValues = genreDictionary.GroupBy(x => x.Value.bpm);
            List<string> TuningValues = new List<string>();
            foreach (var gv in GroupedValues)
            {
                var Tuninglookup = gv.ToLookup(e => e.Value.tuning);
                if (TuningInput == StandardTuning)
                {
                    var selectedTuning = Tuninglookup[Tuning.Standard];
                    foreach (var str in selectedTuning)
                    {
                        string selectedGenre = str.Key;
                        TuningValues.Add(selectedGenre);
                        string combinedTuningValues = String.Join(", ", TuningValues);
                        SuggestedByTuning.Text = combinedTuningValues;
                        
                    }
                }
                else if (TuningInput == LowTuning)
                {
                    var selectedTuning = Tuninglookup[Tuning.Low];
                    foreach (var str in selectedTuning)
                    {
                        string selectedGenre = str.Key;
                        TuningValues.Add(selectedGenre);
                        string combinedTuningValues = String.Join(", ", TuningValues);
                        SuggestedByTuning.Text = combinedTuningValues;
                    }
                }
            }
        }
        public void SuggestedTimeSigCheck()
        {
            var TimeSigInput = TimeSigBox.SelectedItem;
            var GroupedValues = genreDictionary.GroupBy(x => x.Value.bpm);
            List<string> TimeSigValues = new List<string>();
            foreach (var gv in GroupedValues)
            {
                var TimeSiglookup = gv.ToLookup(e => e.Value.timeSignature);
                if (TimeSigInput == StaticTimeSig)
                {
                    var selectedTimeSig = TimeSiglookup[TimeSignature.Static];
                    foreach (var str in selectedTimeSig)
                    {
                        string selectedGenre = str.Key;
                        TimeSigValues.Add(selectedGenre);
                        string combinedTimeSigValues = String.Join(", ", TimeSigValues);
                        SuggestedByTimeSig.Text = combinedTimeSigValues;
                    }
                }
                else if (TimeSigInput == DynamicTimeSig)
                {
                    var selectedTimeSig = TimeSiglookup[TimeSignature.Dynamic];
                    foreach (var str in selectedTimeSig)
                    {
                        string selectedGenre = str.Key;
                        TimeSigValues.Add(selectedGenre);
                        string combinedTimeSigValues = String.Join(", ", TimeSigValues);
                        SuggestedByTimeSig.Text = combinedTimeSigValues;
                    }
                }
            }
        }
        public void SuggestedSongLengthCheck()
        {
            var SongLengthInput = SongLengthBox.SelectedItem;
            var GroupedValues = genreDictionary.GroupBy(x => x.Value.bpm);
            List<string> SongLengthValues = new List<string>();
            foreach (var gv in GroupedValues)
            {
                var SongLengthlookup = gv.ToLookup(e => e.Value.songLength);
                //if (SongLengthInput == ShortSongLength)
                //{
                //    var selectedSongLength = SongLengthlookup[SongLength.Short];
                //    foreach (var str in selectedSongLength)
                //    {
                //        string selectedGenre = str.Key;
                //        SongLengthValues.Add(selectedGenre);
                //        string combinedSongLengthValues = String.Join(", ", SongLengthValues);
                //        SuggestedBySongLength.Text = combinedSongLengthValues;
                //    }
                //}
                if (SongLengthInput == MediumSongLength)
                {
                    var selectedSongLength = SongLengthlookup[SongLength.Medium];
                    foreach (var str in selectedSongLength)
                    {
                        string selectedGenre = str.Key;
                        SongLengthValues.Add(selectedGenre);
                        string combinedSongLengthValues = String.Join(", ", SongLengthValues);
                        SuggestedBySongLength.Text = combinedSongLengthValues;
                    }
                }
                else if (SongLengthInput == LongSongLength)
                {
                    var selectedSongLength = SongLengthlookup[SongLength.Long];
                    foreach (var str in selectedSongLength)
                    {
                        string selectedGenre = str.Key;
                        SongLengthValues.Add(selectedGenre);
                        string combinedSongLengthValues = String.Join(", ", SongLengthValues);
                        SuggestedBySongLength.Text = combinedSongLengthValues;
                    }
                }
                //else if (SongLengthInput == ExtremeSongLength)
                //{
                //    var selectedSongLength = SongLengthlookup[SongLength.Extreme];
                //    foreach (var str in selectedSongLength)
                //    {
                //        string selectedGenre = str.Key;
                //        SongLengthValues.Add(selectedGenre);
                //        string combinedSongLengthValues = String.Join(", ", SongLengthValues);
                //        SuggestedBySongLength.Text = combinedSongLengthValues;
                //    }
                //}
            }
        }
        public void SuggestedInstrumentationCheck()
        {
            var InstrumentationInput = InstrumentBox.SelectedItem;
            var GroupedValues = genreDictionary.GroupBy(x => x.Value.bpm);
            List<string> InstrumentValues = new List<string>();
            foreach (var gv in GroupedValues)
            {
                var InstrumentLookup = gv.ToLookup(e => e.Value.instrumentation);
                if (InstrumentationInput == Classic)
                {
                    var selectedInstrumentation = InstrumentLookup[Instrumentation.Classic];
                    foreach (var str in selectedInstrumentation)
                    {
                        string selectedGenre = str.Key;
                        InstrumentValues.Add(selectedGenre);
                        string combinedInstrumentationValues = String.Join(", ", InstrumentValues);
                        SuggestedByInstrumentation.Text = combinedInstrumentationValues;
                    }
                }
                else if (InstrumentationInput == Orchestral)
                {
                    var selectedInstrumentation = InstrumentLookup[Instrumentation.Orchestral];
                    foreach (var str in selectedInstrumentation)
                    {
                        string selectedGenre = str.Key;
                        InstrumentValues.Add(selectedGenre);
                        string combinedInstrumentationValues = String.Join(", ", InstrumentValues);
                        SuggestedByInstrumentation.Text = combinedInstrumentationValues;
                    }
                }
                else if (InstrumentationInput == TraditionalFolk)
                {
                    var selectedInstrumentation = InstrumentLookup[Instrumentation.Folk];
                    foreach (var str in selectedInstrumentation)
                    {
                        string selectedGenre = str.Key;
                        InstrumentValues.Add(selectedGenre);
                        string combinedInstrumentationValues = String.Join(", ", InstrumentValues);
                        SuggestedByInstrumentation.Text = combinedInstrumentationValues;
                    }
                }
                else if (InstrumentationInput == MongolianFolk)
                {
                    var selectedInstrumentation = InstrumentLookup[Instrumentation.Mongolian];
                    foreach (var str in selectedInstrumentation)
                    {
                        string selectedGenre = str.Key;
                        InstrumentValues.Add(selectedGenre);
                        string combinedInstrumentationValues = String.Join(", ", InstrumentValues);
                        SuggestedByInstrumentation.Text = combinedInstrumentationValues;
                    }
                }
                else if (InstrumentationInput == NorseFolk)
                {
                    var selectedInstrumentation = InstrumentLookup[Instrumentation.Nordic];
                    foreach (var str in selectedInstrumentation)
                    {
                        string selectedGenre = str.Key;
                        InstrumentValues.Add(selectedGenre);
                        string combinedInstrumentationValues = String.Join(", ", InstrumentValues);
                        SuggestedByInstrumentation.Text = combinedInstrumentationValues;
                    }
                }
                else if (InstrumentationInput == Techno)
                {
                    var selectedInstrumentation = InstrumentLookup[Instrumentation.Techno];
                    foreach (var str in selectedInstrumentation)
                    {
                        string selectedGenre = str.Key;
                        InstrumentValues.Add(selectedGenre);
                        string combinedInstrumentationValues = String.Join(", ", InstrumentValues);
                        SuggestedByInstrumentation.Text = combinedInstrumentationValues;
                    }
                }
            }
        }
        public void GenreSuggestions()
        {
            string TuningInput = Convert.ToString(TuningLabel.Tag);
            string BPMInput = Convert.ToString(BPMLabel.Tag);
            string TimeSigInput = Convert.ToString(TimeSigLabel.Tag);
            string SongLengthInput = Convert.ToString(SongLengthLabel.Tag);
            string InstrumentationInput = Convert.ToString(InstrumentationLabel.Tag);
            SuggestedBPMCheck();
            SuggestedTuningCheck();
            SuggestedTimeSigCheck();
            SuggestedSongLengthCheck();
            SuggestedInstrumentationCheck();

            if (TuningInput == ""
                && BPMInput == ""
                && TimeSigInput == ""
                && SongLengthInput == ""
                && InstrumentationInput == "")
            {
                SuggestedByBPM.Text = "Error";
                SuggestedBySongLength.Text = "Error";
                SuggestedByTimeSig.Text = "Error";
                SuggestedByTuning.Text = "Error";
                SuggestedByInstrumentation.Text = "Error";
            }

        }

        public void GenreDisplay(string genreKey, Dictionary<string, Genre> genreDictionary, string suggestedBands)
        {

            GenreLabel.Content = genreDictionary[genreKey].name;
            SuggestedBandsLabel.Content = suggestedBands;

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
            
        }

        public enum TimeSignature
        {
            Dynamic,
            Static,
            
        }
        public enum Instrumentation
        {
            Classic,
            Orchestral,
            Folk,
            Mongolian,
            Nordic,
            Techno
        }
        public class Genre
        {
            public string name;
            public BPM bpm;
            public Tuning tuning;
            public TimeSignature timeSignature;
            public SongLength songLength;
            public Instrumentation instrumentation;

            public Genre(string name, BPM bpm, Tuning tuning, TimeSignature timeSignature, SongLength songLength, Instrumentation instrumentation)
            {
                this.name = name;
                this.bpm = bpm;
                this.tuning = tuning;
                this.timeSignature = timeSignature;
                this.songLength = songLength;
                this.instrumentation = instrumentation;
            }
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Check();
            GenreSuggestions();
            //TotalChecker();
            if (TimeSigBox.IsEnabled == false)
            {
                BasicCheck();
                GenreSuggestions();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Window1 genreWindow = new Window1();
            //genreWindow.Show();
            DataGridWindow newGenreWindow = new DataGridWindow();
            newGenreWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string ShutdownTitle = "Application Shutting down";
            string ShutdownMessage = "Application is shutting down. All windows will close momentarily";
            MessageBox.Show(ShutdownMessage, ShutdownTitle, MessageBoxButton.OK, MessageBoxImage.Information);
            Application.Current.Shutdown();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Show help window
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SpotifyWindow spotifyWindow = new SpotifyWindow();
            spotifyWindow.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ThemeSetter themeSetter = new ThemeSetter();
            themeSetter.Show();
        }

        private void BasicSet(object sender, RoutedEventArgs e)
        {
            TuningBox.IsEnabled = false;
            TimeSigBox.IsEnabled = false;
            
            TimeSigTitleLabel.Content = @"Time Signature
  (DISABLED)";
            TuningTitleLabel.Content = @"Tuning
(DISABLED)";
        }

        private void AdvancedSet(object sender, RoutedEventArgs e)
        {
            TuningBox.IsEnabled = true;
            TimeSigBox.IsEnabled = true;
            
            TimeSigTitleLabel.Content = "Time Signature";
            TuningTitleLabel.Content = "Tuning";
        }

        private void BasicCheck()
        {
            string TuningInput = Convert.ToString(TuningLabel.Tag);
            string BPMInput = Convert.ToString(BPMLabel.Tag);
            string TimeSigInput = Convert.ToString(TimeSigLabel.Tag);
            string SongLengthInput = Convert.ToString(SongLengthLabel.Tag);
            string InstrumentationInput = Convert.ToString(InstrumentationLabel.Tag);

            if (BPMBox.SelectedItem == MediumBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic
                )
            {
                genreKey = "Heavy";
                suggestedBands = "Black Sabbath, Iron Maiden, Judas Priest, Dio";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            

            if (BPMBox.SelectedItem == MediumBPM &&
                
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Groove";
                suggestedBands = "Pantera, Damageplan, Alien Weaponry, Lamb of God";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == FastBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Thrash";
                suggestedBands = "Anthrax, Slayer, Megadeth, Metallica";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            

            if (BPMBox.SelectedItem == InsaneBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Death";
                suggestedBands = "Death, Possessed, Feared, XavlegbmaofffassssitimiwoamndutroabcwapwaeiippohfffX";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            

            if (BPMBox.SelectedItem == SlowBPM &&
                
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Doom";
                suggestedBands = "Pagan Altar, Witchfinder General, Pentagram, Trouble";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == SlowBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Death/Doom";
                suggestedBands = "Paradise Lost, Anathema, Mournful Congregation, The Eternal";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            

            if (BPMBox.SelectedItem == FastBPM &&
                
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Classic)
            {
                genreKey = "Power";
                suggestedBands = "DragonForce, Helloween, Powerwolf, Sabaton";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            

            

            

            if (BPMBox.SelectedItem == MediumBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Techno)
            {
                genreKey = "Industrial";
                suggestedBands = "Rammstein, Nine Inch Nails, Ministry, Rob Zombie";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == TraditionalFolk)
            {
                genreKey = "Folk";
                suggestedBands = "Alestorm, Korpiklaani, Tyr, Wintersun";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == SlowBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == NorseFolk)
            {
                genreKey = "Viking";
                suggestedBands = "Amon Amarth, Burzum, Satyricon, Tyr";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == SlowBPM &&
                
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == NorseFolk)
            {
                genreKey = "Pagan";
                suggestedBands = "Moonsorrow, Korpiklaani, Kampfar, Amon Amarth";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == MongolianFolk)
            {
                genreKey = "Mongol";
                suggestedBands = "The HU, Tengger Cavalry, Growl of Clown, Hurd";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);

            }

            if (BPMBox.SelectedItem == FastBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Orchestral)
            {
                genreKey = "SymphonicBlack";
                suggestedBands = "Dimmu Borgir, Emperor, Carach Angren, Cradle of Filth";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Orchestral)
            {
                genreKey = "Symphonic";
                suggestedBands = "Therion, Nightwish, Rhapsody of Fire, Within Temptation";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == InsaneBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Orchestral)
            {
                genreKey = "SymphonicDeath";
                suggestedBands = "Children of Bodom, Fleshgod Apocalypse, Make them Suffer, Betraying the Martyrs";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == FastBPM &&
                
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Orchestral)
            {
                genreKey = "SymphonicPower";
                suggestedBands = "Twilight Force, Kamelot, Rhapsody of Fire, Nightwish";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMInput == "" &&
            TuningInput == "" &&
            TimeSigInput == "" &&
            SongLengthInput == "" &&
            InstrumentationInput == "")
            {
                GenreLabel.Content = "PLEASE SELECT SOME VALUES BEFORE PRESSING CALCULATE";
                SuggestedBandsLabel.Content = "NO SUGGESTED BANDS FOR UNKNOWN GENRE";

            }
        }


        
        

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TuningBox.SelectedIndex = -1;
            TimeSigBox.SelectedIndex = -1;
            BPMBox.SelectedIndex = -1;
            SongLengthBox.SelectedIndex = -1;
            InstrumentBox.SelectedIndex = -1;
            GenreLabel.Content = "Genre Will Appear Here";
            SuggestedBandsLabel.Content = "";
            SuggestedByBPM.Text = "";
            SuggestedByInstrumentation.Text = "";
            SuggestedBySongLength.Text = "";
            SuggestedByTimeSig.Text = "";
            SuggestedByTuning.Text = "";
        }

        private void OutputFunnel(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (BPMBox.SelectedIndex == -1 &&
                TuningBox.SelectedIndex == -1 &&
                TimeSigBox.SelectedIndex == -1 &&
                SongLengthBox.SelectedIndex == -1 &&
                InstrumentBox.SelectedIndex == -1)
            {
                StandardTuning.IsEnabled = true;
                LowTuning.IsEnabled = true;
                SlowBPM.IsEnabled = true;
                MediumBPM.IsEnabled = true;
                FastBPM.IsEnabled = true;
                InsaneBPM.IsEnabled = true;
                StaticTimeSig.IsEnabled = true;
                DynamicTimeSig.IsEnabled = true;
                Classic.IsEnabled = true;
                Orchestral.IsEnabled = true;
                NorseFolk.IsEnabled = true;
                TraditionalFolk.IsEnabled = true;
                MongolianFolk.IsEnabled = true;
                Techno.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;


            }

            else if (BPMBox.SelectedItem == SlowBPM) 
            {
                StandardTuning.IsEnabled = false;
                Orchestral.IsEnabled = false;
                TraditionalFolk.IsEnabled = false;
                MongolianFolk.IsEnabled = false;
                Techno.IsEnabled = false;
                LowTuning.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
                NorseFolk.IsEnabled = true;
                Classic.IsEnabled = true;
                StaticTimeSig.IsEnabled = true;
                DynamicTimeSig.IsEnabled = true;
                SlowBPM.IsEnabled = true;
                MediumBPM.IsEnabled = true;
                FastBPM.IsEnabled = true;
                InsaneBPM.IsEnabled = true;
            }
            else if (BPMBox.SelectedItem == MediumBPM)
            {
                NorseFolk.IsEnabled = false;
                StandardTuning.IsEnabled = true;
                LowTuning.IsEnabled = true;
                SlowBPM.IsEnabled = true;
                MediumBPM.IsEnabled = true;
                FastBPM.IsEnabled = true;
                InsaneBPM.IsEnabled = true;
                StaticTimeSig.IsEnabled = true;
                DynamicTimeSig.IsEnabled = true;
                Classic.IsEnabled = true;
                Orchestral.IsEnabled = true;
                TraditionalFolk.IsEnabled = true;
                MongolianFolk.IsEnabled = true;
                Techno.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
            }
            else if (BPMBox.SelectedItem == FastBPM)
            {
                LowTuning.IsEnabled = false;
                NorseFolk.IsEnabled = false;
                TraditionalFolk.IsEnabled = false;
                MongolianFolk.IsEnabled = false;
                Techno.IsEnabled = false;
                StandardTuning.IsEnabled = true;
                StaticTimeSig.IsEnabled = true;
                DynamicTimeSig.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
                Classic.IsEnabled = true;
                Orchestral.IsEnabled = true;
                SlowBPM.IsEnabled = true;
                MediumBPM.IsEnabled = true;
                FastBPM.IsEnabled = true;
                InsaneBPM.IsEnabled = true;
            }
            else if (BPMBox.SelectedItem == InsaneBPM)
            {
                LowTuning.IsEnabled = false;
                NorseFolk.IsEnabled = false;
                TraditionalFolk.IsEnabled = false;
                MongolianFolk.IsEnabled = false;
                Techno.IsEnabled = false;
                LongSongLength.IsEnabled = false;
                Classic.IsEnabled = true;
                Orchestral.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                StandardTuning.IsEnabled = true;
                StaticTimeSig.IsEnabled = true;
                DynamicTimeSig.IsEnabled = true;
                SlowBPM.IsEnabled = true;
                MediumBPM.IsEnabled = true;
                FastBPM.IsEnabled = true;
                InsaneBPM.IsEnabled = true;
            }
            else if (TuningBox.SelectedItem == StandardTuning)
            {
                SlowBPM.IsEnabled = false;
                NorseFolk.IsEnabled = false;
                MediumBPM.IsEnabled = true;
                FastBPM.IsEnabled = true;
                InsaneBPM.IsEnabled = true;
                StaticTimeSig.IsEnabled = true;
                DynamicTimeSig.IsEnabled = true;
                StandardTuning.IsEnabled = true;
                LowTuning.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
                Classic.IsEnabled = true;
                Orchestral.IsEnabled = true;
                TraditionalFolk.IsEnabled = true;
                MongolianFolk.IsEnabled = true;
                Techno.IsEnabled = true;
            }
            else if (TuningBox.SelectedItem == LowTuning)
            {
                FastBPM.IsEnabled = false;
                InsaneBPM.IsEnabled = false;
                Orchestral.IsEnabled = false;
                TraditionalFolk.IsEnabled = false;
                MongolianFolk.IsEnabled = false;
                Techno.IsEnabled = false;
                Classic.IsEnabled = true;
                NorseFolk.IsEnabled = true;
                SlowBPM.IsEnabled = true;
                MediumBPM.IsEnabled = true;
                StaticTimeSig.IsEnabled = true;
                DynamicTimeSig.IsEnabled = true;
                StandardTuning.IsEnabled = true;
                LowTuning.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
            }
            else if (TimeSigBox.SelectedItem == StaticTimeSig)
            {
                StandardTuning.IsEnabled = true;
                LowTuning.IsEnabled = true;
                SlowBPM.IsEnabled = true;
                MediumBPM.IsEnabled = true;
                FastBPM.IsEnabled = true;
                InsaneBPM.IsEnabled = true;
                StaticTimeSig.IsEnabled = true;
                DynamicTimeSig.IsEnabled = true;
                Classic.IsEnabled = true;
                Orchestral.IsEnabled = true;
                NorseFolk.IsEnabled = true;
                TraditionalFolk.IsEnabled = true;
                MongolianFolk.IsEnabled = true;
                Techno.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
            }
            else if (TimeSigBox.SelectedItem == DynamicTimeSig)
            {
                NorseFolk.IsEnabled = false;
                TraditionalFolk.IsEnabled = false;
                MongolianFolk.IsEnabled = false;
                Techno.IsEnabled = false;
                StandardTuning.IsEnabled = true;
                LowTuning.IsEnabled = true;
                SlowBPM.IsEnabled = true;
                MediumBPM.IsEnabled = true;
                FastBPM.IsEnabled = true;
                InsaneBPM.IsEnabled = true;
                StaticTimeSig.IsEnabled = true;
                DynamicTimeSig.IsEnabled = true;
                Classic.IsEnabled = true;
                Orchestral.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
            }
            else if (SongLengthBox.SelectedItem == MediumSongLength)
            {
                StandardTuning.IsEnabled = true;
                LowTuning.IsEnabled = true;
                SlowBPM.IsEnabled = true;
                MediumBPM.IsEnabled = true;
                FastBPM.IsEnabled = true;
                InsaneBPM.IsEnabled = true;
                StaticTimeSig.IsEnabled = true;
                DynamicTimeSig.IsEnabled = true;
                Classic.IsEnabled = true;
                Orchestral.IsEnabled = true;
                NorseFolk.IsEnabled = true;
                TraditionalFolk.IsEnabled = true;
                MongolianFolk.IsEnabled = true;
                Techno.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
            }
            else if (SongLengthBox.SelectedItem == LongSongLength)
            {
                InsaneBPM.IsEnabled = false;
                TraditionalFolk.IsEnabled = false;
                MongolianFolk.IsEnabled = false;
                Techno.IsEnabled = false;

                StandardTuning.IsEnabled = true;
                LowTuning.IsEnabled = true;
                SlowBPM.IsEnabled = true;
                MediumBPM.IsEnabled = true;
                FastBPM.IsEnabled = true;
                StaticTimeSig.IsEnabled = true;
                DynamicTimeSig.IsEnabled = true;
                Classic.IsEnabled = true;
                Orchestral.IsEnabled = true;
                NorseFolk.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
            }
            else if (InstrumentBox.SelectedItem == Classic)
            {
                StandardTuning.IsEnabled = true;
                LowTuning.IsEnabled = true;
                SlowBPM.IsEnabled = true;
                MediumBPM.IsEnabled = true;
                FastBPM.IsEnabled = true;
                InsaneBPM.IsEnabled = true;
                StaticTimeSig.IsEnabled = true;
                DynamicTimeSig.IsEnabled = true;
                Classic.IsEnabled = true;
                Orchestral.IsEnabled = true;
                NorseFolk.IsEnabled = true;
                TraditionalFolk.IsEnabled = true;
                MongolianFolk.IsEnabled = true;
                Techno.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
            }
            else if (InstrumentBox.SelectedItem == Orchestral)
            {
                SlowBPM.IsEnabled = false;
                LowTuning.IsEnabled = false;
                StandardTuning.IsEnabled = true;
                MediumBPM.IsEnabled = true;
                FastBPM.IsEnabled = true;
                InsaneBPM.IsEnabled = true;
                StaticTimeSig.IsEnabled = true;
                DynamicTimeSig.IsEnabled = true;
                Classic.IsEnabled = true;
                Orchestral.IsEnabled = true;
                NorseFolk.IsEnabled = true;
                TraditionalFolk.IsEnabled = true;
                MongolianFolk.IsEnabled = true;
                Techno.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
            }
            else if (InstrumentBox.SelectedItem == TraditionalFolk)
            {
                SlowBPM.IsEnabled = false;
                LowTuning.IsEnabled = false;
                FastBPM.IsEnabled = false;
                InsaneBPM.IsEnabled = false;
                DynamicTimeSig.IsEnabled = false;
                LongSongLength.IsEnabled = false;
                StandardTuning.IsEnabled = true;
                
                MediumBPM.IsEnabled = true;
                
                
                StaticTimeSig.IsEnabled = true;
                
                Classic.IsEnabled = true;
                Orchestral.IsEnabled = true;
                NorseFolk.IsEnabled = true;
                TraditionalFolk.IsEnabled = true;
                MongolianFolk.IsEnabled = true;
                Techno.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                
            }
            else if (InstrumentBox.SelectedItem == MongolianFolk)
            {
                SlowBPM.IsEnabled = false;
                LowTuning.IsEnabled = false;
                FastBPM.IsEnabled = false;
                InsaneBPM.IsEnabled = false;
                DynamicTimeSig.IsEnabled = false;
                LongSongLength.IsEnabled = false;
                StandardTuning.IsEnabled = true;
                
                
                MediumBPM.IsEnabled = true;
                
                StaticTimeSig.IsEnabled = true;
                
                Classic.IsEnabled = true;
                Orchestral.IsEnabled = true;
                NorseFolk.IsEnabled = true;
                TraditionalFolk.IsEnabled = true;
                MongolianFolk.IsEnabled = true;
                Techno.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                
            }
            else if (InstrumentBox.SelectedItem == NorseFolk)
            {
                MediumBPM.IsEnabled = false;
                FastBPM.IsEnabled = false;
                InsaneBPM.IsEnabled = false;
                StandardTuning.IsEnabled = false;
                DynamicTimeSig.IsEnabled = false;
                
                LowTuning.IsEnabled = true;
                SlowBPM.IsEnabled = true;
                
                
                StaticTimeSig.IsEnabled = true;
                
                Classic.IsEnabled = true;
                Orchestral.IsEnabled = true;
                NorseFolk.IsEnabled = true;
                TraditionalFolk.IsEnabled = true;
                MongolianFolk.IsEnabled = true;
                Techno.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
            }
            else if (InstrumentBox.SelectedItem == Techno)
            {
                SlowBPM.IsEnabled = false;
                LowTuning.IsEnabled = false;
                FastBPM.IsEnabled = false;
                InsaneBPM.IsEnabled = false;
                DynamicTimeSig.IsEnabled = false;
                LongSongLength.IsEnabled = false;
                StandardTuning.IsEnabled = true;


                MediumBPM.IsEnabled = true;

                StaticTimeSig.IsEnabled = true;

                Classic.IsEnabled = true;
                Orchestral.IsEnabled = true;
                NorseFolk.IsEnabled = true;
                TraditionalFolk.IsEnabled = true;
                MongolianFolk.IsEnabled = true;
                Techno.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
            }
            else 
            {
                StandardTuning.IsEnabled = true;
                LowTuning.IsEnabled = true;
                SlowBPM.IsEnabled = true;
                MediumBPM.IsEnabled = true;
                FastBPM.IsEnabled = true;
                InsaneBPM.IsEnabled = true;
                StaticTimeSig.IsEnabled = true;
                DynamicTimeSig.IsEnabled = true;
                Classic.IsEnabled = true;
                Orchestral.IsEnabled = true;
                NorseFolk.IsEnabled = true;
                TraditionalFolk.IsEnabled = true;
                MongolianFolk.IsEnabled = true;
                Techno.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
            }
            
        }

        
    }
}
