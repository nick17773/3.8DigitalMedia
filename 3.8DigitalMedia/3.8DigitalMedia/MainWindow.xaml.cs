using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Diagnostics;

namespace _3._8DigitalMedia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            
            InitializeComponent();

            
            

        }
        public void GenreAlgorithm()
        {
            var TuningInput = TuningBox.SelectedValue;
            var BPMInput = BPMBox.SelectedValue;
            var TimeSigInput = TimeSigBox.SelectedValue;
            var SongLengthInput = SongLengthBox.SelectedValue;


            Dictionary<string, Genre> genreDictionary = new Dictionary<string, Genre>()
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
                { "Alt", new Genre("Alternative Metal", BPM.Medium, Tuning.Low, TimeSignature.Static, SongLength.Medium) },
                { "Nu", new Genre("Nu Metal", BPM.Medium, Tuning.Low, TimeSignature.Dynamic, SongLength.Medium) },
                { "Djent", new Genre("Djent", BPM.Slow, Tuning.Low, TimeSignature.Dynamic, SongLength.Medium) },
                { "Industrial", new Genre("Industrial Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Short) }
            };


            string genreKey;
            string suggestedBands;

            Short.Content = SongLength.Short;
            MediumLength.Content = SongLength.Medium;
            Long.Content = SongLength.Long;
            Extreme.Content = SongLength.Extreme;
            Slow.Content = BPM.Slow;
            MediumBPM.Content = BPM.Medium;
            Fast.Content = BPM.Fast;
            Insane.Content = BPM.Insane;
            Static.Content = TimeSignature.Static;
            Dynamic.Content = TimeSignature.Dynamic;
            Weird.Content = TimeSignature.Weird;
            Standard.Content = Tuning.Standard;
            Low.Content = Tuning.Low;
            Special.Content = Tuning.Special;
            //string TuningInput = TuningInputBox.Text;
            //string BPMInput = BPMInputBox.Text;
            //string TimeSigInput = TimeSigInputBox.Text;
            //string SongLengthInput = SongLengthInputBox.Text;
            if (TuningInput == Standard.Content)
            {
                if (BPMInput == Fast.Content)
                {
                    if (TimeSigInput == Static.Content)
                    {
                        if (SongLengthInput == MediumLength.Content)
                        {
                            genreKey = "Thrash";
                            suggestedBands = "Anthrax, Slayer, Megadeth, Metallica";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);
                        }
                        else if (SongLengthInput == Long.Content)
                        {
                            genreKey = "Power";
                            suggestedBands = "DragonForce, Helloween, Powerwolf, Sabaton";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);
                        }
                    }
                }
                else if (BPMInput == MediumBPM.Content)
                {
                    if (TimeSigInput == Static.Content)
                    {

                        if (SongLengthInput == Short.Content)
                        {
                            genreKey = "Industrial";
                            suggestedBands = "Rammstein, Nine Inch Nails, Ministry, Rob Zombie";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);
                        }
                        else if (SongLengthInput == MediumLength.Content)
                        {
                            genreKey = "Heavy";
                            suggestedBands = "Black Sabbath, Iron Maiden, Judas Priest, Dio";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);
                        }
                    }
                    else if (TimeSigInput == Dynamic.Content)
                    {
                        if (SongLengthInput == MediumLength.Content)
                        {
                            genreKey = "Prog";
                            suggestedBands = "Dream Theatre, Opeth, Gojira, Mastodon";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);
                        }
                        else if (SongLengthInput == Long.Content)
                        {
                            genreKey = "Groove";
                            suggestedBands = "Pantera, Damageplan, HellYeah, Lamb of God";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);
                        }
                    }
                }
                else if (BPMInput == Insane.Content)
                {
                    if (TimeSigInput == Static.Content)
                    {
                        genreKey = "Death";
                        suggestedBands = "Death, Possessed, Obituary, Carcass";
                        GenreDisplay(genreKey, genreDictionary, suggestedBands);
                    }
                    else if (TimeSigInput == Dynamic.Content)
                    {
                        genreKey = "Tech Death";
                        suggestedBands = "Death, Pestilence, Atheist, Nocturnus";
                        GenreDisplay(genreKey, genreDictionary, suggestedBands);
                    }
                }
            }
            else if (TuningInput == Low.Content)
            {
                if (BPMInput == Slow.Content)
                {
                    if (TimeSigInput == Static.Content)
                    {
                        if (SongLengthInput == Long.Content)
                        {
                            genreKey = "Doom";
                            suggestedBands = "Pagan Altar, Witchfinder General, Pentagram, Trouble";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);
                        }
                        else if (SongLengthInput == MediumLength.Content)
                        {
                            genreKey = "Death/Doom";
                            suggestedBands = "Paradise Lost, Anathema, Corrupted, The Eternal";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);
                        }
                    }
                    else if (TimeSigInput == Dynamic.Content)
                    {

                        if (SongLengthInput == Long.Content)
                        {
                            genreKey = "Sludge";
                            suggestedBands = "Eyehategod, Crowbar, Buzzoven, Acid Bath";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);
                        }
                        else if (SongLengthInput == MediumLength.Content)
                        {
                            genreKey = "Djent";
                            suggestedBands = "Born of Osiris, Meshuggah, Periphery, Animals As Leaders";
                            GenreDisplay(genreKey, genreDictionary, suggestedBands);
                        }
                    }
                }
                else if (BPMInput == MediumBPM.Content)
                {
                    if (TimeSigInput == Static.Content)
                    {
                        genreKey = "Alt";
                        suggestedBands = "Alice in Chains, Faith No More, Tool, System of a Down";
                        GenreDisplay(genreKey, genreDictionary, suggestedBands);
                    }
                    else if (TimeSigInput == Dynamic.Content)
                    {
                        genreKey = "Nu";
                        suggestedBands = "Linkin Park, Slipknot, Korn, Disturbed";
                        GenreDisplay(genreKey, genreDictionary, suggestedBands);
                    }

                }
            }
        }
        public void GenreDisplay(string genreKey, Dictionary<string, Genre> genreDictionary, string suggestedBands)
        {
            
            GenreNameLabel.Content = genreDictionary[genreKey].name;
            Debug.WriteLine(genreDictionary[genreKey].name);
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

        private void BPMBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GenreAlgorithm();
        }

        private void TuningBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GenreAlgorithm();
        }

        private void TimeSigBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GenreAlgorithm();
        }

        private void SongLengthBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GenreAlgorithm();
        }
    }
}
