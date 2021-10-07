
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
        

        
        public string MediumLength = Convert.ToString(SongLength.Medium);
        public string Long = Convert.ToString(SongLength.Long);
       

        public string ClassicI = Convert.ToString(Instrumentation.Metal);
        public string OrchestralI = Convert.ToString(Instrumentation.Orchestral);
        public string TradFolk = Convert.ToString(Instrumentation.Folk);
        
        public string VikingrFolk = Convert.ToString(Instrumentation.Nordic);

        public Dictionary<string, Genre> genreDictionary = new Dictionary<string, Genre>()
            {
                { "Heavy", new Genre("Heavy Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Metal, CountryOrigin.UK) },
                { "Prog", new Genre("Progressive Metal", BPM.Medium, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium, Instrumentation.Metal, CountryOrigin.USA) },
                { "Groove", new Genre("Groove Metal", BPM.Medium, Tuning.Standard, TimeSignature.Dynamic, SongLength.Long, Instrumentation.Metal, CountryOrigin.USA) },
                { "Thrash", new Genre("Thrash Metal", BPM.Fast, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Metal, CountryOrigin.USA) },
                { "Black", new Genre("Black Metal", BPM.Fast, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium, Instrumentation.Metal, CountryOrigin.Finland) },
                { "Death", new Genre("Death Metal", BPM.Insane, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Metal, CountryOrigin.USA) },
                { "Tech Death", new Genre("Technical Death Metal", BPM.Insane, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium, Instrumentation.Metal, CountryOrigin.USA) },
                { "Doom", new Genre("Doom Metal", BPM.Slow, Tuning.Low, TimeSignature.Static, SongLength.Long, Instrumentation.Metal, CountryOrigin.UK) },
                { "Death/Doom", new Genre("Death Doom Metal", BPM.Slow, Tuning.Low, TimeSignature.Static, SongLength.Medium, Instrumentation.Metal, CountryOrigin.UK) },
                { "Sludge", new Genre("Sludge Metal", BPM.Slow, Tuning.Low, TimeSignature.Dynamic, SongLength.Long, Instrumentation.Metal, CountryOrigin.USA) },
                { "Power", new Genre("Power Metal", BPM.Fast, Tuning.Standard, TimeSignature.Static, SongLength.Long, Instrumentation.Metal, CountryOrigin.USA) },
                { "Alt", new Genre("Alternative Metal", BPM.Medium, Tuning.Low, TimeSignature.Static, SongLength.Medium, Instrumentation.Metal, CountryOrigin.USA) },
                { "Nu", new Genre("Nu Metal", BPM.Medium, Tuning.Low, TimeSignature.Dynamic, SongLength.Medium, Instrumentation.Metal, CountryOrigin.USA) },
                { "Djent", new Genre("Djent", BPM.Slow, Tuning.Low, TimeSignature.Dynamic, SongLength.Medium, Instrumentation.Metal, CountryOrigin.Sweden) },
                { "Industrial", new Genre("Industrial Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Techno, CountryOrigin.Germany) },
                { "Folk", new Genre("Folk Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Folk, CountryOrigin.Sweden) },
                { "Viking", new Genre("Viking Metal", BPM.Slow, Tuning.Low, TimeSignature.Static, SongLength.Medium, Instrumentation.Nordic, CountryOrigin.Norway) },
                { "Pagan", new Genre("Pagan Metal", BPM.Slow, Tuning.Low, TimeSignature.Static, SongLength.Long, Instrumentation.Nordic, CountryOrigin.Norway) },
                { "Mongol", new Genre("Mongolian Folk Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Folk, CountryOrigin.Mongolia) },
                { "SymphonicBlack", new Genre("Symphonic Black Metal", BPM.Fast, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium, Instrumentation.Orchestral, CountryOrigin.Finland) },
                { "Symphonic", new Genre("Symphonic Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Orchestral, CountryOrigin.USA) },
                { "SymphonicDeath", new Genre("Symphonic Death Metal", BPM.Insane, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Orchestral, CountryOrigin.USA) },
                { "SymphonicPower", new Genre("Symphonic Power Metal", BPM.Fast, Tuning.Standard, TimeSignature.Static, SongLength.Long, Instrumentation.Orchestral, CountryOrigin.USA) },
                { "HardRock", new Genre("Hard Rock", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Medium, Instrumentation.Rock, CountryOrigin.UK) },
                { "ProgRock", new Genre("Progressive Rock", BPM.Medium, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium, Instrumentation.Rock, CountryOrigin.UK) },
                { "MathRock", new Genre("Math Rock", BPM.Medium, Tuning.Standard, TimeSignature.Dynamic, SongLength.Long, Instrumentation.Rock, CountryOrigin.USA) },
                { "AltRock", new Genre("Alternative Rock", BPM.Medium, Tuning.Low, TimeSignature.Static, SongLength.Medium, Instrumentation.Rock, CountryOrigin.UK) },
                { "Grunge", new Genre("Grunge", BPM.Medium, Tuning.Low, TimeSignature.Dynamic, SongLength.Medium, Instrumentation.Rock, CountryOrigin.USA) },
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

            Classic.Content = Instrumentation.Metal;
            Orchestral.Content = Instrumentation.Orchestral;
            TraditionalFolk.Content = Instrumentation.Folk;
            
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
            List<string> AllInstRockValues = new List<string>();
            List<string> AllCountryUSAValues = new List<string>();
            List<string> AllCountryUKValues = new List<string>();
            List<string> AllCountryNZValues = new List<string>();
            List<string> AllCountryNorwayValues = new List<string>();
            List<string> AllCountrySwedenValues = new List<string>();
            List<string> AllCountryGermanyValues = new List<string>();
            List<string> AllCountryFinlandValues = new List<string>();
            List<string> AllCountryMongoliaValues = new List<string>();



            foreach (var agv in GroupedValues)
            {
                var allTuningLookup = agv.ToLookup(e => e.Value.tuning);
                var allBPMLookup = agv.ToLookup(e => e.Value.bpm);
                var allTimeSigLookup = agv.ToLookup(e => e.Value.timeSignature);
                var allSongLenLookup = agv.ToLookup(e => e.Value.songLength);
                var allInstLookup = agv.ToLookup(e => e.Value.instrumentation);
                var allCountryLookup = agv.ToLookup(e => e.Value.originCountry);

                var StandardTuningCheck = allTuningLookup[Tuning.Standard];
                var LowTuningCheck = allTuningLookup[Tuning.Low];

                var SlowBPMCheck = allBPMLookup[BPM.Slow];
                var MediumBPMCheck = allBPMLookup[BPM.Medium];
                var FastBPMCheck = allBPMLookup[BPM.Fast];
                var InsaneBPMCheck = allBPMLookup[BPM.Insane];

                var StaticTimeSigCheck = allTimeSigLookup[TimeSignature.Static];
                var DynamicTimeSigCheck = allTimeSigLookup[TimeSignature.Dynamic];

                
                var MediumSongLengthCheck = allSongLenLookup[SongLength.Medium];
                var LongSongLengthCheck = allSongLenLookup[SongLength.Long];
                

                var ClassicInstCheck = allInstLookup[Instrumentation.Metal];
                var OrchestralInstCheck = allInstLookup[Instrumentation.Orchestral];
                var FolkInstCheck = allInstLookup[Instrumentation.Folk];
                var NorseInstCheck = allInstLookup[Instrumentation.Nordic];
                var TechnoInstCheck = allInstLookup[Instrumentation.Techno];
                var RockInstCheck = allInstLookup[Instrumentation.Rock];

                var USACountryCheck = allCountryLookup[CountryOrigin.USA];
                var UKCountryCheck = allCountryLookup[CountryOrigin.UK];
                var NZCountryCheck = allCountryLookup[CountryOrigin.NZ];
                var NorwayCountryCheck = allCountryLookup[CountryOrigin.Norway];
                var SwedenCountryCheck = allCountryLookup[CountryOrigin.Sweden];
                var FinlandCountryCheck = allCountryLookup[CountryOrigin.Finland];
                var GermanyCountryCheck = allCountryLookup[CountryOrigin.Germany];
                var MongoliaCountryCheck = allCountryLookup[CountryOrigin.Mongolia];




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
                    Classic.Content = Instrumentation.Metal + $" ({ClassicCheck} Genres)";
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
                foreach (var CheckStr in RockInstCheck)
                {
                    string selectedInstrumentation = CheckStr.Key;
                    AllInstRockValues.Add(selectedInstrumentation);
                    int RockCheck = AllInstRockValues.Count();
                    Rock.Content = Instrumentation.Rock + $" ({RockCheck} Genres)";
                }
                foreach (var CheckStr in USACountryCheck)
                {
                    string selectedCountry = CheckStr.Key;
                    AllCountryUSAValues.Add(selectedCountry);
                    int USACheck = AllCountryUSAValues.Count();
                    USA.Content = CountryOrigin.USA + $" ({USACheck} Genres)";
                }
                foreach (var CheckStr in UKCountryCheck)
                {
                    string selectedCountry = CheckStr.Key;
                    AllCountryUKValues.Add(selectedCountry);
                    int UKCheck = AllCountryUKValues.Count();
                    UK.Content = CountryOrigin.UK + $" ({UKCheck} Genres)";
                }
                foreach (var CheckStr in NZCountryCheck)
                {
                    string selectedCountry = CheckStr.Key;
                    AllCountryNZValues.Add(selectedCountry);
                    int NZCheck = AllCountryNZValues.Count();
                    NZ.Content = CountryOrigin.NZ + $" ({NZCheck} Genres)";
                }
                foreach (var CheckStr in NorwayCountryCheck)
                {
                    string selectedCountry = CheckStr.Key;
                    AllCountryNorwayValues.Add(selectedCountry);
                    int NORCheck = AllCountryNorwayValues.Count();
                    NOR.Content = CountryOrigin.Norway + $" ({NORCheck} Genres)";
                }
                foreach (var CheckStr in SwedenCountryCheck)
                {
                    string selectedCountry = CheckStr.Key;
                    AllCountrySwedenValues.Add(selectedCountry);
                    int SWECheck = AllCountrySwedenValues.Count();
                    SWE.Content = CountryOrigin.Sweden + $" ({SWECheck} Genres)";
                }
                foreach (var CheckStr in FinlandCountryCheck)
                {
                    string selectedCountry = CheckStr.Key;
                    AllCountryFinlandValues.Add(selectedCountry);
                    int FINCheck = AllCountryFinlandValues.Count();
                    FIN.Content = CountryOrigin.Finland + $" ({FINCheck} Genres)";
                }
                foreach (var CheckStr in GermanyCountryCheck)
                {
                    string selectedCountry = CheckStr.Key;
                    AllCountryGermanyValues.Add(selectedCountry);
                    int GERCheck = AllCountryGermanyValues.Count();
                    GER.Content = CountryOrigin.Germany + $" ({GERCheck} Genres)";
                }
                foreach (var CheckStr in MongoliaCountryCheck)
                {
                    string selectedCountry = CheckStr.Key;
                    AllCountryMongoliaValues.Add(selectedCountry);
                    int MongolCheck = AllCountryMongoliaValues.Count();
                    MON.Content = CountryOrigin.Mongolia + $" ({MongolCheck} Genres)";
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
            string CountryInput = Convert.ToString(CountryBox.SelectedItem);

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == UK)
            {
                genreKey = "Heavy";
                suggestedBands = "Black Sabbath, Iron Maiden, Judas Priest, Dio";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "Prog";
                suggestedBands = "Dream Theatre, Opeth, Gojira, Mastodon";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "Groove";
                suggestedBands = "Pantera, Damageplan, Alien Weaponry, Lamb of God";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == FastBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "Thrash";
                suggestedBands = "Anthrax, Slayer, Megadeth, Metallica";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == FastBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == FIN)
            {
                genreKey = "Black";
                suggestedBands = "Mayhem, Darkthrone, Venom, Paracoccidioidomicosisproctitissarcomucosis";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == InsaneBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "Death";
                suggestedBands = "Death, Possessed, Feared, XavlegbmaofffassssitimiwoamndutroabcwapwaeiippohfffX";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == InsaneBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "Tech Death";
                suggestedBands = "Death, Pestilence, Atheist, Nocturnus";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == SlowBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == UK)
            {
                genreKey = "Doom";
                suggestedBands = "Pagan Altar, Witchfinder General, Pentagram, Trouble";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == SlowBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == UK)
            {
                genreKey = "Death/Doom";
                suggestedBands = "Paradise Lost, Anathema, Mournful Congregation, The Eternal";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == SlowBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "Sludge";
                suggestedBands = "Eyehategod, Crowbar, Buzzoven, Acid Bath";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == FastBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "Power";
                suggestedBands = "DragonForce, Helloween, Powerwolf, Sabaton";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "Alt";
                suggestedBands = "Alice in Chains, Faith No More, Tool, System of a Down";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "Nu";
                suggestedBands = "Linkin Park, Slipknot, Korn, Disturbed";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == SlowBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == SWE)
            {
                genreKey = "Djent";
                suggestedBands = "Born of Osiris, Meshuggah, Periphery, Animals As Leaders";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Techno &&
                CountryBox.SelectedItem == GER)
            {
                genreKey = "Industrial";
                suggestedBands = "Rammstein, Nine Inch Nails, Ministry, Rob Zombie";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == TraditionalFolk &&
                CountryBox.SelectedItem == SWE)
            {
                genreKey = "Folk";
                suggestedBands = "Alestorm, Korpiklaani, Tyr, Wintersun";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }
            
            if (BPMBox.SelectedItem == SlowBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == NorseFolk &&
                CountryBox.SelectedItem == NOR)
            {
                genreKey = "Viking";
                suggestedBands = "Amon Amarth, Burzum, Satyricon, Tyr";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }
            
            if (BPMBox.SelectedItem == SlowBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == NorseFolk &&
                CountryBox.SelectedItem == NOR)
            {
                genreKey = "Pagan";
                suggestedBands = "Moonsorrow, Korpiklaani, Kampfar, Amon Amarth";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }
            
            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == TraditionalFolk &&
                CountryBox.SelectedItem == MON)
            {
                genreKey = "Mongol";
                suggestedBands = "The HU, Tengger Cavalry, Growl of Clown, Hurd";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
                
            }
            
            if (BPMBox.SelectedItem == FastBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Orchestral &&
                CountryBox.SelectedItem == FIN)
            {
                genreKey = "SymphonicBlack";
                suggestedBands = "Dimmu Borgir, Emperor, Carach Angren, Cradle of Filth";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Orchestral &&
                CountryBox.SelectedItem == USA) 
            {
                genreKey = "Symphonic";
                suggestedBands = "Therion, Nightwish, Rhapsody of Fire, Within Temptation";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == InsaneBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Orchestral &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "SymphonicDeath";
                suggestedBands = "Children of Bodom, Fleshgod Apocalypse, Make them Suffer, Betraying the Martyrs";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == FastBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Orchestral &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "SymphonicPower";
                suggestedBands = "Twilight Force, Kamelot, Rhapsody of Fire, Nightwish";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Rock &&
                CountryBox.SelectedItem == UK)
            {
                genreKey = "HardRock";
                suggestedBands = "Jimi Hendrix, Led Zeppelin, KISS, Queen";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }
            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Rock &&
                CountryBox.SelectedItem == UK
                )
            {
                genreKey = "ProgRock";
                suggestedBands = "Yes, Emmerson Lake & Palmer, Pink Floyd, Rush";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }
            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == StandardTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Rock &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "MathRock";
                suggestedBands = "King Crimson, Polyphia, The Dillenger Escape Plan, Turing Machine";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }
            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == StaticTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Rock &&
                CountryBox.SelectedItem == UK)
            {
                genreKey = "AltRock";
                suggestedBands = "blink-182, Blur, Fall Out Boy, Evanesance";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                TuningBox.SelectedItem == LowTuning &&
                TimeSigBox.SelectedItem == DynamicTimeSig &&
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Rock &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "Grunge";
                suggestedBands = "Nirvana, Pearl Jam, Soundgarden, Stone Temple Pilots";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMInput == "" &&
            TuningInput == "" &&
            TimeSigInput == "" &&
            SongLengthInput == "" &&
            InstrumentationInput == "" &&
            CountryInput == "")
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
                    var selectedInstrumentation = InstrumentLookup[Instrumentation.Metal];
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
                else if (InstrumentationInput == Rock)
                {
                    var selectedInstrumentation = InstrumentLookup[Instrumentation.Rock];
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
        public void SuggestedCountryCheck()
        {
            var CountryInput = CountryBox.SelectedItem;
            var GroupedValues = genreDictionary.GroupBy(x => x.Value.bpm);
            List<string> CountryValues = new List<string>();
            foreach (var gv in GroupedValues)
            {
                var CountryLookup = gv.ToLookup(e => e.Value.originCountry);
                if (CountryInput == USA)
                {
                    var selectedCountry = CountryLookup[CountryOrigin.USA];
                    foreach (var str in selectedCountry)
                    {
                        string selectedGenre = str.Key;
                        CountryValues.Add(selectedGenre);
                        string combinedCountryValues = String.Join(", ", CountryValues);
                        SuggestedByCountry.Text = combinedCountryValues;
                    }
                }
                else if (CountryInput == UK)
                {
                    var selectedCountry = CountryLookup[CountryOrigin.USA];
                    foreach (var str in selectedCountry)
                    {
                        string selectedGenre = str.Key;
                        CountryValues.Add(selectedGenre);
                        string combinedCountryValues = String.Join(", ", CountryValues);
                        SuggestedByCountry.Text = combinedCountryValues;
                    }
                }
                else if (CountryInput == NZ)
                {
                    var selectedCountry = CountryLookup[CountryOrigin.USA];
                    foreach (var str in selectedCountry)
                    {
                        string selectedGenre = str.Key;
                        CountryValues.Add(selectedGenre);
                        string combinedCountryValues = String.Join(", ", CountryValues);
                        SuggestedByCountry.Text = combinedCountryValues;
                    }
                }
                else if (CountryInput == NOR)
                {
                    var selectedCountry = CountryLookup[CountryOrigin.USA];
                    foreach (var str in selectedCountry)
                    {
                        string selectedGenre = str.Key;
                        CountryValues.Add(selectedGenre);
                        string combinedCountryValues = String.Join(", ", CountryValues);
                        SuggestedByCountry.Text = combinedCountryValues;
                    }
                }
                else if (CountryInput == SWE)
                {
                    var selectedCountry = CountryLookup[CountryOrigin.USA];
                    foreach (var str in selectedCountry)
                    {
                        string selectedGenre = str.Key;
                        CountryValues.Add(selectedGenre);
                        string combinedCountryValues = String.Join(", ", CountryValues);
                        SuggestedByCountry.Text = combinedCountryValues;
                    }
                }
                else if (CountryInput == FIN)
                {
                    var selectedCountry = CountryLookup[CountryOrigin.USA];
                    foreach (var str in selectedCountry)
                    {
                        string selectedGenre = str.Key;
                        CountryValues.Add(selectedGenre);
                        string combinedCountryValues = String.Join(", ", CountryValues);
                        SuggestedByCountry.Text = combinedCountryValues;
                    }
                }
                else if (CountryInput == GER)
                {
                    var selectedCountry = CountryLookup[CountryOrigin.USA];
                    foreach (var str in selectedCountry)
                    {
                        string selectedGenre = str.Key;
                        CountryValues.Add(selectedGenre);
                        string combinedCountryValues = String.Join(", ", CountryValues);
                        SuggestedByCountry.Text = combinedCountryValues;
                    }
                }
                else if (CountryInput == MON)
                {
                    var selectedCountry = CountryLookup[CountryOrigin.Mongolia];
                    foreach (var str in selectedCountry)
                    {
                        string selectedGenre = str.Key;
                        CountryValues.Add(selectedGenre);
                        string combinedCountryValues = String.Join(", ", CountryValues);
                        SuggestedByCountry.Text = combinedCountryValues;
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
            string CountryInput = Convert.ToString(CountryBox.SelectedItem);
            SuggestedBPMCheck();
            SuggestedTuningCheck();
            SuggestedTimeSigCheck();
            SuggestedSongLengthCheck();
            SuggestedInstrumentationCheck();
            SuggestedCountryCheck();

            if (TuningInput == ""
                && BPMInput == ""
                && TimeSigInput == ""
                && SongLengthInput == ""
                && InstrumentationInput == ""
                && CountryInput == "")
            {
                SuggestedByBPM.Text = "Error";
                SuggestedBySongLength.Text = "Error";
                SuggestedByTimeSig.Text = "Error";
                SuggestedByTuning.Text = "Error";
                SuggestedByInstrumentation.Text = "Error";
                SuggestedByCountry.Text = "Error";
            }

        }

        public void GenreDisplay(string genreKey, Dictionary<string, Genre> genreDictionary, string suggestedBands)
        {

            GenreLabel.Content = genreDictionary[genreKey].name;
            SuggestedBandsLabel.Content = suggestedBands;

        }
        public enum SongLength
        {

            Medium,
            Long

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
            Static

        }
        public enum Instrumentation
        {
            Metal,
            Orchestral,
            Folk,

            Nordic,
            Techno,
            Rock
        }
        public enum CountryOrigin
        {
            USA,
            UK,
            Norway,
            Finland,
            NZ,
            Mongolia,
            Sweden,
            Germany
        }
        public class Genre
        {
            public string name;
            public BPM bpm;
            public Tuning tuning;
            public TimeSignature timeSignature;
            public SongLength songLength;
            public Instrumentation instrumentation;
            public CountryOrigin originCountry;
            public Genre(string name, BPM bpm, Tuning tuning, TimeSignature timeSignature, SongLength songLength, Instrumentation instrumentation, CountryOrigin originCountry)
            {
                this.name = name;
                this.bpm = bpm;
                this.tuning = tuning;
                this.timeSignature = timeSignature;
                this.songLength = songLength;
                this.instrumentation = instrumentation;
                this.originCountry = originCountry;
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
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == UK)
            {
                genreKey = "Heavy";
                suggestedBands = "Black Sabbath, Iron Maiden, Judas Priest, Dio";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            

            if (BPMBox.SelectedItem == MediumBPM &&
                
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "Groove";
                suggestedBands = "Pantera, Damageplan, Alien Weaponry, Lamb of God";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == FastBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "Thrash";
                suggestedBands = "Anthrax, Slayer, Megadeth, Metallica";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == FastBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == FIN)
            {
                genreKey = "Black";
                suggestedBands = "Mayhem, Darkthrone, Venom, Paracoccidioidomicosisproctitissarcomucosis";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }



            if (BPMBox.SelectedItem == InsaneBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "Death";
                suggestedBands = "Death, Possessed, Feared, XavlegbmaofffassssitimiwoamndutroabcwapwaeiippohfffX";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            

            if (BPMBox.SelectedItem == SlowBPM &&
                
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == UK)
            {
                genreKey = "Doom";
                suggestedBands = "Pagan Altar, Witchfinder General, Pentagram, Trouble";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == SlowBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == UK)
            {
                genreKey = "Death/Doom";
                suggestedBands = "Paradise Lost, Anathema, Mournful Congregation, The Eternal";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            

            if (BPMBox.SelectedItem == FastBPM &&
                
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Classic &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "Power";
                suggestedBands = "DragonForce, Helloween, Powerwolf, Sabaton";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            

            

            

            if (BPMBox.SelectedItem == MediumBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Techno &&
                CountryBox.SelectedItem == GER)
            {
                genreKey = "Industrial";
                suggestedBands = "Rammstein, Nine Inch Nails, Ministry, Rob Zombie";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == TraditionalFolk &&
                CountryBox.SelectedItem == SWE)
            {
                genreKey = "Folk";
                suggestedBands = "Alestorm, Korpiklaani, Tyr, Wintersun";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == SlowBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == NorseFolk &&
                CountryBox.SelectedItem == NOR)
            {
                genreKey = "Viking";
                suggestedBands = "Amon Amarth, Burzum, Satyricon, Tyr";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == SlowBPM &&
                
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == NorseFolk &&
                CountryBox.SelectedItem == NOR)
            {
                genreKey = "Pagan";
                suggestedBands = "Moonsorrow, Korpiklaani, Kampfar, Amon Amarth";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == TraditionalFolk &&
                CountryBox.SelectedItem == MON)
            {
                genreKey = "Mongol";
                suggestedBands = "The HU, Tengger Cavalry, Growl of Clown, Hurd";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);

            }

            if (BPMBox.SelectedItem == FastBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Orchestral &&
                CountryBox.SelectedItem == FIN)
            {
                genreKey = "SymphonicBlack";
                suggestedBands = "Dimmu Borgir, Emperor, Carach Angren, Cradle of Filth";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == MediumBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Orchestral &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "Symphonic";
                suggestedBands = "Therion, Nightwish, Rhapsody of Fire, Within Temptation";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == InsaneBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Orchestral &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "SymphonicDeath";
                suggestedBands = "Children of Bodom, Fleshgod Apocalypse, Make them Suffer, Betraying the Martyrs";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }

            if (BPMBox.SelectedItem == FastBPM &&
                
                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Orchestral &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "SymphonicPower";
                suggestedBands = "Twilight Force, Kamelot, Rhapsody of Fire, Nightwish";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }
            if (BPMBox.SelectedItem == MediumBPM &&
                
                SongLengthBox.SelectedItem == MediumSongLength &&
                InstrumentBox.SelectedItem == Rock &&
                CountryBox.SelectedItem == UK)
            {
                genreKey = "HardRock";
                suggestedBands = "Jimi Hendrix Experience, Led Zeppelin, KISS, Queen";
                GenreDisplay(genreKey, genreDictionary, suggestedBands);
            }
            if (BPMBox.SelectedItem == MediumBPM &&

                SongLengthBox.SelectedItem == LongSongLength &&
                InstrumentBox.SelectedItem == Rock &&
                CountryBox.SelectedItem == USA)
            {
                genreKey = "MathRock";
                suggestedBands = "King Crimson, Polyphia, The Dillenger Escape Plan, Turing Machine";
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
            CountryBox.SelectedIndex = -1;
            GenreLabel.Content = "Genre Will Appear Here";
            SuggestedBandsLabel.Content = "";
            SuggestedByBPM.Text = "";
            SuggestedByInstrumentation.Text = "";
            SuggestedBySongLength.Text = "";
            SuggestedByTimeSig.Text = "";
            SuggestedByTuning.Text = "";
            SuggestedByCountry.Text = "";
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
                
                Techno.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
                Rock.IsEnabled = true;

            }

            else if (BPMBox.SelectedItem == SlowBPM) 
            {
                StandardTuning.IsEnabled = false;
                Orchestral.IsEnabled = false;
                TraditionalFolk.IsEnabled = false;
               
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
                
                Techno.IsEnabled = true;
                Rock.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
            }
            else if (BPMBox.SelectedItem == FastBPM)
            {
                LowTuning.IsEnabled = false;
                NorseFolk.IsEnabled = false;
                TraditionalFolk.IsEnabled = false;
                
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
                
                Techno.IsEnabled = true;
                Rock.IsEnabled = true;
            }
            else if (TuningBox.SelectedItem == LowTuning)
            {
                FastBPM.IsEnabled = false;
                InsaneBPM.IsEnabled = false;
                Orchestral.IsEnabled = false;
                TraditionalFolk.IsEnabled = false;
                
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
                
                Techno.IsEnabled = true;
                Rock.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
            }
            else if (TimeSigBox.SelectedItem == DynamicTimeSig)
            {
                NorseFolk.IsEnabled = false;
                TraditionalFolk.IsEnabled = false;
                
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
                
                Techno.IsEnabled = true;
                Rock.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;
            }
            else if (SongLengthBox.SelectedItem == LongSongLength)
            {
                InsaneBPM.IsEnabled = false;
                TraditionalFolk.IsEnabled = false;
                
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
                
                Techno.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
            }
            else if (InstrumentBox.SelectedItem == Rock)
            {
                //SlowBPM.IsEnabled = false;
                //LowTuning.IsEnabled = false;
                //FastBPM.IsEnabled = false;
                //InsaneBPM.IsEnabled = false;
                //DynamicTimeSig.IsEnabled = false;
                //LongSongLength.IsEnabled = false;
                //StandardTuning.IsEnabled = true;


                MediumBPM.IsEnabled = true;

                StaticTimeSig.IsEnabled = true;

                //Classic.IsEnabled = true;
                //Orchestral.IsEnabled = true;
                //NorseFolk.IsEnabled = true;
                //TraditionalFolk.IsEnabled = true;
                
                //Techno.IsEnabled = true;
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
                
                Techno.IsEnabled = true;
                Rock.IsEnabled = true;
                MediumSongLength.IsEnabled = true;
                LongSongLength.IsEnabled = true;

            }
            
        }

        
    }
}
