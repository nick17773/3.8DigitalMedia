using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

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
        public string Special = Convert.ToString(Tuning.Special);

        public string Static = Convert.ToString(TimeSignature.Static);
        public string Dynamic = Convert.ToString(TimeSignature.Dynamic);
        public string Weird = Convert.ToString(TimeSignature.Weird);

        public string Short = Convert.ToString(SongLength.Short);
        public string MediumLength = Convert.ToString(SongLength.Medium);
        public string Long = Convert.ToString(SongLength.Long);
        public string Extreme = Convert.ToString(SongLength.Extreme);

        public Dictionary<string, Genre> genreDictionary = new Dictionary<string, Genre>()
            {
                { "Heavy", new Genre("Heavy Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Medium) },
                { "Prog", new Genre("Progressive Metal", BPM.Medium, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium) },
                { "Groove", new Genre("Groove Metal", BPM.Medium, Tuning.Standard, TimeSignature.Dynamic, SongLength.Long) },
                { "Thrash", new Genre("Thrash Metal", BPM.Fast, Tuning.Standard, TimeSignature.Static, SongLength.Medium) },
                { "Black", new Genre("Black Metal", BPM.Fast, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium) },
                { "Death", new Genre("Death Metal", BPM.Insane, Tuning.Standard, TimeSignature.Static, SongLength.Medium) },
                { "Tech Death", new Genre("Technical Death Metal", BPM.Insane, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium) },
                { "Doom", new Genre("Doom Metal", BPM.Slow, Tuning.Low, TimeSignature.Static, SongLength.Long) },
                { "Death/Doom", new Genre("Death Doom Metal", BPM.Slow, Tuning.Low, TimeSignature.Static, SongLength.Medium) },
                { "Sludge", new Genre("Sludge Metal", BPM.Slow, Tuning.Low, TimeSignature.Dynamic, SongLength.Long) },
                { "Power", new Genre("Power Metal", BPM.Fast, Tuning.Standard, TimeSignature.Static, SongLength.Long) },
                { "Alt", new Genre("Alternative Metal", BPM.Medium, Tuning.Low, TimeSignature.Static, SongLength.Medium) },
                { "Nu", new Genre("Nu Metal", BPM.Medium, Tuning.Low, TimeSignature.Dynamic, SongLength.Medium) },
                { "Djent", new Genre("Djent", BPM.Slow, Tuning.Low, TimeSignature.Dynamic, SongLength.Medium) },
                { "Industrial", new Genre("Industrial Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Short) }
            };

        public MainWindow()
        {

            InitializeComponent();

            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.GetApplicationDefault(),
            });



            SlowBPM.Content = BPM.Slow;
            MediumBPM.Content = BPM.Medium;
            FastBPM.Content = BPM.Fast;
            InsaneBPM.Content = BPM.Insane;

            StandardTuning.Content = Tuning.Standard;
            LowTuning.Content = Tuning.Low;
            SpecialTuning.Content = Tuning.Special;

            StaticTimeSig.Content = TimeSignature.Static;
            DynamicTimeSig.Content = TimeSignature.Dynamic;
            WeirdTimeSig.Content = TimeSignature.Weird;

            ShortSongLength.Content = SongLength.Short;
            MediumSongLength.Content = SongLength.Medium;
            LongSongLength.Content = SongLength.Long;
            ExtremeSongLength.Content = SongLength.Extreme;













        }
        public void Check()
        {


            //string TuningInput = Convert.ToString(TuningLabel.Content);
            //string BPMInput = Convert.ToString(BPMLabel.Content);
            //string TimeSigInput = Convert.ToString(TimeSigLabel.Content);
            //string SongLengthInput = Convert.ToString(SongLengthLabel.Content);

            string TuningInput = Convert.ToString(TuningLabel.Tag);
            string BPMInput = Convert.ToString(BPMLabel.Tag);
            string TimeSigInput = Convert.ToString(TimeSigLabel.Tag);
            string SongLengthInput = Convert.ToString(SongLengthLabel.Tag);

            if (TuningInput == Standard)
            {
                if (BPMInput == Fast)
                {
                    if (TimeSigInput == Static)
                    {
                        if (SongLengthInput == MediumLength)
                        {
                            genreKey = "Thrash";
                            suggestedBands = "Anthrax, Slayer, Megadeth, Metallica";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);

                        }
                        else if (SongLengthInput == Long)
                        {
                            genreKey = "Power";
                            suggestedBands = "DragonForce, Helloween, Powerwolf, Sabaton";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);

                        }
                    }
                    else if (TimeSigInput == Dynamic)
                    {
                        if (SongLengthInput == MediumLength)
                        {
                            genreKey = "Black";
                            suggestedBands = "Mayhem, Darkthrone, Venom, Paracoccidioidomicosisproctitissarcomucosis";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);

                        }
                    }
                }
                else if (BPMInput == MediumBPMS)
                {
                    if (TimeSigInput == Static)
                    {

                        if (SongLengthInput == Short)
                        {
                            genreKey = "Industrial";
                            suggestedBands = "Rammstein, Nine Inch Nails, Ministry, Rob Zombie";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);

                        }
                        else if (SongLengthInput == MediumLength)
                        {
                            genreKey = "Heavy";
                            suggestedBands = "Black Sabbath, Iron Maiden, Judas Priest, Dio";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);

                        }
                    }
                    else if (TimeSigInput == Dynamic)
                    {
                        if (SongLengthInput == MediumLength)
                        {
                            genreKey = "Prog";
                            suggestedBands = "Dream Theatre, Opeth, Gojira, Mastodon";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);

                        }
                        else if (SongLengthInput == Long)
                        {
                            genreKey = "Groove";
                            suggestedBands = "Pantera, Damageplan, Alien Weaponry, Lamb of God";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);

                        }
                    }
                }
                else if (BPMInput == Insane)
                {
                    if (TimeSigInput == Static)
                    {

                        if (SongLengthInput == MediumLength)
                        {
                            genreKey = "Death";
                            suggestedBands = "Death, Possessed, Feared, XavlegbmaofffassssitimiwoamndutroabcwapwaeiippohfffX";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);

                        }
                    }
                    else if (TimeSigInput == Dynamic)
                    {

                        if (SongLengthInput == MediumLength)
                        {
                            genreKey = "Tech Death";
                            suggestedBands = "Death, Pestilence, Atheist, Nocturnus";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);

                        }
                    }
                }
            }
            else if (TuningInput == Low)
            {
                if (BPMInput == Slow)
                {
                    if (TimeSigInput == Static)
                    {
                        if (SongLengthInput == Long)
                        {
                            genreKey = "Doom";
                            suggestedBands = "Pagan Altar, Witchfinder General, Pentagram, Trouble";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);

                        }
                        else if (SongLengthInput == MediumLength)
                        {
                            genreKey = "Death/Doom";
                            suggestedBands = "Paradise Lost, Anathema, Mournful Congregation, The Eternal";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);

                        }
                    }
                    else if (TimeSigInput == Dynamic)
                    {

                        if (SongLengthInput == Long)
                        {
                            genreKey = "Sludge";
                            suggestedBands = "Eyehategod, Crowbar, Buzzoven, Acid Bath";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);

                        }
                        else if (SongLengthInput == MediumLength)
                        {
                            genreKey = "Djent";
                            suggestedBands = "Born of Osiris, Meshuggah, Periphery, Animals As Leaders";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);

                        }
                    }
                }
                else if (BPMInput == MediumBPMS)
                {
                    if (TimeSigInput == Static)
                    {
                        genreKey = "Alt";
                        suggestedBands = "Alice in Chains, Faith No More, Tool, System of a Down";
                        GenreDisplay(genreKey, genreDictionary, suggestedBands);

                    }
                    else if (TimeSigInput == Dynamic)
                    {
                        genreKey = "Nu";
                        suggestedBands = "Linkin Park, Slipknot, Korn, Disturbed";
                        GenreDisplay(genreKey, genreDictionary, suggestedBands);

                    }
                }
            }
            if (BPMInput == "" &&
                TuningInput == "" &&
                TimeSigInput == "" &&
                SongLengthInput == "")
            {
                GenreLabel.Content = "PLEASE SELECT SOME VALUES BEFORE PRESSING CALCULATE";
                SuggestedBandsLabel.Content = "NO SUGGESTED BANDS FOR UNKNOWN GENRE";

            }

        }
        public void SuggestedBPMCheck()
        {
            string BPMInput = Convert.ToString(BPMLabel.Tag);
            var GroupedValues = genreDictionary.GroupBy(x => x.Value.bpm);
            List<string> BPMValues = new List<string>();
            foreach (var gv in GroupedValues)
            {
                var BPMlookup = gv.ToLookup(e => e.Value.bpm);
                if (BPMInput == Slow)
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
                else if (BPMInput == MediumBPMS)
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
                else if (BPMInput == Fast)
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
                else if (BPMInput == Insane)
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
            string TuningInput = Convert.ToString(TuningLabel.Tag);
            var GroupedValues = genreDictionary.GroupBy(x => x.Value.bpm);
            List<string> TuningValues = new List<string>();
            foreach (var gv in GroupedValues)
            {
                var Tuninglookup = gv.ToLookup(e => e.Value.tuning);
                if (TuningInput == Standard)
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
                else if (TuningInput == Low)
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
            string TimeSigInput = Convert.ToString(TimeSigLabel.Tag);
            var GroupedValues = genreDictionary.GroupBy(x => x.Value.bpm);
            List<string> TimeSigValues = new List<string>();
            foreach (var gv in GroupedValues)
            {
                var TimeSiglookup = gv.ToLookup(e => e.Value.timeSignature);
                if (TimeSigInput == Static)
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
                else if (TimeSigInput == Dynamic)
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
            string SongLengthInput = Convert.ToString(SongLengthLabel.Tag);
            var GroupedValues = genreDictionary.GroupBy(x => x.Value.bpm);
            List<string> SongLengthValues = new List<string>();
            foreach (var gv in GroupedValues)
            {
                var SongLengthlookup = gv.ToLookup(e => e.Value.songLength);
                if (SongLengthInput == Short)
                {
                    var selectedSongLength = SongLengthlookup[SongLength.Short];
                    foreach (var str in selectedSongLength)
                    {
                        string selectedGenre = str.Key;
                        SongLengthValues.Add(selectedGenre);
                        string combinedSongLengthValues = String.Join(", ", SongLengthValues);
                        SuggestedBySongLength.Text = combinedSongLengthValues;
                    }
                }
                else if (SongLengthInput == MediumLength)
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
                else if (SongLengthInput == Long)
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
                else if (SongLengthInput == Extreme)
                {
                    var selectedSongLength = SongLengthlookup[SongLength.Extreme];
                    foreach (var str in selectedSongLength)
                    {
                        string selectedGenre = str.Key;
                        SongLengthValues.Add(selectedGenre);
                        string combinedSongLengthValues = String.Join(", ", SongLengthValues);
                        SuggestedBySongLength.Text = combinedSongLengthValues;
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
            SuggestedBPMCheck();
            SuggestedTuningCheck();
            SuggestedTimeSigCheck();
            SuggestedSongLengthCheck();

            if (TuningInput == ""
                && BPMInput == ""
                && TimeSigInput == ""
                && SongLengthInput == "")
            {
                SuggestedByBPM.Text = "ERROR";
                SuggestedBySongLength.Text = "ERROR";
                SuggestedByTimeSig.Text = "ERROR";
                SuggestedByTuning.Text = "ERROR";
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



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Check();
            GenreSuggestions();
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
    }
}