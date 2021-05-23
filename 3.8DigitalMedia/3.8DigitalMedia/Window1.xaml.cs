using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;

namespace _3._8DigitalMedia
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public string FeatureNotImplementedMessage = "This feature is not availiable quite yet, check back after the next update";
        public string FeatureNotImplementedTitle = "Feature under development";
        public Window1()
        {
            InitializeComponent();
            Dictionary<string, Genre> genreDictionary = new Dictionary<string, Genre>()
            {
                { "Heavy", new Genre("Heavy Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Medium) },
                { "Prog", new Genre("Progressive Metal", BPM.Medium, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium) },
                { "Groove", new Genre("Groove Metal", BPM.Medium, Tuning.Standard, TimeSignature.Dynamic, SongLength.Long) },
                { "Industrial", new Genre("Industrial Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Short) },
                { "Thrash", new Genre("Thrash Metal", BPM.Fast, Tuning.Standard, TimeSignature.Static, SongLength.Medium) },
                { "Black", new Genre("Black Metal", BPM.Fast, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium) },
                { "Power", new Genre("Power Metal", BPM.Fast, Tuning.Standard, TimeSignature.Static, SongLength.Long) },
                { "Death", new Genre("Death Metal", BPM.Insane, Tuning.Standard, TimeSignature.Static, SongLength.Medium) },
                { "Tech Death", new Genre("Technical Death Metal", BPM.Insane, Tuning.Standard, TimeSignature.Dynamic, SongLength.Medium) },
                { "Doom", new Genre("Doom Metal", BPM.Slow, Tuning.Low, TimeSignature.Static, SongLength.Long) },
                { "Death/Doom", new Genre("Death Doom Metal", BPM.Slow, Tuning.Low, TimeSignature.Static, SongLength.Medium) },
                { "Sludge", new Genre("Sludge Metal", BPM.Slow, Tuning.Low, TimeSignature.Dynamic, SongLength.Long) },
                { "Alt", new Genre("Alternative Metal", BPM.Medium, Tuning.Low, TimeSignature.Static, SongLength.Medium) },
                { "Nu", new Genre("Nu Metal", BPM.Medium, Tuning.Low, TimeSignature.Dynamic, SongLength.Medium) },
                { "Djent", new Genre("Djent", BPM.Slow, Tuning.Low, TimeSignature.Dynamic, SongLength.Medium) }
                
            };
            SolidColorBrush BorderBrush = Brushes.Black;
            Thickness BorderThickness = new Thickness(2);
            
            HeavyName.Content = genreDictionary["Heavy"].name;
            HeavyName.BorderBrush = BorderBrush;
            HeavyName.BorderThickness = BorderThickness;

            HeavyBPM.Content = genreDictionary["Heavy"].bpm;
            HeavyBPM.BorderBrush = BorderBrush;
            HeavyBPM.BorderThickness = BorderThickness;

            HeavyTuning.Content = genreDictionary["Heavy"].tuning;
            HeavyTuning.BorderBrush = BorderBrush;
            HeavyTuning.BorderThickness = BorderThickness;

            HeavyTimeSig.Content = genreDictionary["Heavy"].timeSignature;
            HeavyTimeSig.BorderBrush = BorderBrush;
            HeavyTimeSig.BorderThickness = BorderThickness;

            HeavySongLength.Content = genreDictionary["Heavy"].songLength;
            HeavySongLength.BorderBrush = BorderBrush;
            HeavySongLength.BorderThickness = BorderThickness;

            ProgName.Content = genreDictionary["Prog"].name;
            ProgName.BorderBrush = BorderBrush;
            ProgName.BorderThickness = BorderThickness;

            ProgBPM.Content = genreDictionary["Prog"].bpm;
            ProgBPM.BorderBrush = BorderBrush;
            ProgBPM.BorderThickness = BorderThickness;

            ProgTuning.Content = genreDictionary["Prog"].tuning;
            ProgTuning.BorderBrush = BorderBrush;
            ProgTuning.BorderThickness = BorderThickness;

            ProgTimeSig.Content = genreDictionary["Prog"].timeSignature;
            ProgTimeSig.BorderBrush = BorderBrush;
            ProgTimeSig.BorderThickness = BorderThickness;

            ProgSongLength.Content = genreDictionary["Prog"].songLength;
            ProgSongLength.BorderBrush = BorderBrush;
            ProgSongLength.BorderThickness = BorderThickness;

            GrooveName.Content = genreDictionary["Groove"].name;
            GrooveName.BorderBrush = BorderBrush;
            GrooveName.BorderThickness = BorderThickness;

            GrooveBPM.Content = genreDictionary["Groove"].bpm;
            GrooveBPM.BorderBrush = BorderBrush;
            GrooveBPM.BorderThickness = BorderThickness;

            GrooveTuning.Content = genreDictionary["Groove"].tuning;
            GrooveTuning.BorderBrush = BorderBrush;
            GrooveTuning.BorderThickness = BorderThickness;

            GrooveTimeSig.Content = genreDictionary["Groove"].timeSignature;
            GrooveTimeSig.BorderBrush = BorderBrush;
            GrooveTimeSig.BorderThickness = BorderThickness;

            GrooveSongLength.Content = genreDictionary["Groove"].songLength;
            GrooveSongLength.BorderBrush = BorderBrush;
            GrooveSongLength.BorderThickness = BorderThickness;

            IndustrialName.Content = genreDictionary["Industrial"].name;
            IndustrialName.BorderBrush = BorderBrush;
            IndustrialName.BorderThickness = BorderThickness;

            IndustrialBPM.Content = genreDictionary["Industrial"].bpm;
            IndustrialBPM.BorderBrush = BorderBrush;
            IndustrialBPM.BorderThickness = BorderThickness;

            IndustrialTuning.Content = genreDictionary["Industrial"].tuning;
            IndustrialTuning.BorderBrush = BorderBrush;
            IndustrialTuning.BorderThickness = BorderThickness;

            IndustrialTimeSig.Content = genreDictionary["Industrial"].timeSignature;
            IndustrialTimeSig.BorderBrush = BorderBrush;
            IndustrialTimeSig.BorderThickness = BorderThickness;

            IndustrialSongLength.Content = genreDictionary["Industrial"].songLength;
            IndustrialSongLength.BorderBrush = BorderBrush;
            IndustrialSongLength.BorderThickness = BorderThickness;

            ThrashName.Content = genreDictionary["Thrash"].name;
            ThrashName.BorderBrush = BorderBrush;
            ThrashName.BorderThickness = BorderThickness;

            ThrashBPM.Content = genreDictionary["Thrash"].bpm;
            ThrashBPM.BorderBrush = BorderBrush;
            ThrashBPM.BorderThickness = BorderThickness;

            ThrashTuning.Content = genreDictionary["Thrash"].tuning;
            ThrashTuning.BorderBrush = BorderBrush;
            ThrashTuning.BorderThickness = BorderThickness;

            ThrashTimeSig.Content = genreDictionary["Thrash"].timeSignature;
            ThrashTimeSig.BorderBrush = BorderBrush;
            ThrashTimeSig.BorderThickness = BorderThickness;

            ThrashSongLength.Content = genreDictionary["Thrash"].songLength;
            ThrashSongLength.BorderBrush = BorderBrush;
            ThrashSongLength.BorderThickness = BorderThickness;

            BlackName.Content = genreDictionary["Black"].name;
            BlackName.BorderBrush = BorderBrush;
            BlackName.BorderThickness = BorderThickness;

            BlackBPM.Content = genreDictionary["Black"].bpm;
            BlackBPM.BorderBrush = BorderBrush;
            BlackBPM.BorderThickness = BorderThickness;

            BlackTuning.Content = genreDictionary["Black"].tuning;
            BlackTuning.BorderBrush = BorderBrush;
            BlackTuning.BorderThickness = BorderThickness;

            BlackTimeSig.Content = genreDictionary["Black"].timeSignature;
            BlackTimeSig.BorderBrush = BorderBrush;
            BlackTimeSig.BorderThickness = BorderThickness;

            BlackSongLength.Content = genreDictionary["Black"].songLength;
            BlackSongLength.BorderBrush = BorderBrush;
            BlackSongLength.BorderThickness = BorderThickness;

            PowerName.Content = genreDictionary["Power"].name;
            PowerName.BorderBrush = BorderBrush;
            PowerName.BorderThickness = BorderThickness;

            PowerBPM.Content = genreDictionary["Power"].bpm;
            PowerBPM.BorderBrush = BorderBrush;
            PowerBPM.BorderThickness = BorderThickness;

            PowerTuning.Content = genreDictionary["Power"].tuning;
            PowerTuning.BorderBrush = BorderBrush;
            PowerTuning.BorderThickness = BorderThickness;

            PowerTimeSig.Content = genreDictionary["Power"].timeSignature;
            PowerTimeSig.BorderBrush = BorderBrush;
            PowerTimeSig.BorderThickness = BorderThickness;

            PowerSongLength.Content = genreDictionary["Power"].songLength;
            PowerSongLength.BorderBrush = BorderBrush;
            PowerSongLength.BorderThickness = BorderThickness;

            DeathName.Content = genreDictionary["Death"].name;
            DeathName.BorderBrush = BorderBrush;
            DeathName.BorderThickness = BorderThickness;

            DeathBPM.Content = genreDictionary["Death"].bpm;
            DeathBPM.BorderBrush = BorderBrush;
            DeathBPM.BorderThickness = BorderThickness;

            DeathTuning.Content = genreDictionary["Death"].tuning;
            DeathTuning.BorderBrush = BorderBrush;
            DeathTuning.BorderThickness = BorderThickness;

            DeathTimeSig.Content = genreDictionary["Death"].timeSignature;
            DeathTimeSig.BorderBrush = BorderBrush;
            DeathTimeSig.BorderThickness = BorderThickness;

            DeathSongLength.Content = genreDictionary["Death"].songLength;
            DeathSongLength.BorderBrush = BorderBrush;
            DeathSongLength.BorderThickness = BorderThickness;

            TechDeathName.Content = genreDictionary["Tech Death"].name;
            TechDeathName.BorderBrush = BorderBrush;
            TechDeathName.BorderThickness = BorderThickness;

            TechDeathBPM.Content = genreDictionary["Tech Death"].bpm;
            TechDeathBPM.BorderBrush = BorderBrush;
            TechDeathBPM.BorderThickness = BorderThickness;

            TechDeathTuning.Content = genreDictionary["Tech Death"].tuning;
            TechDeathTuning.BorderBrush = BorderBrush;
            TechDeathTuning.BorderThickness = BorderThickness;

            TechDeathTimeSig.Content = genreDictionary["Tech Death"].timeSignature;
            TechDeathTimeSig.BorderBrush = BorderBrush;
            TechDeathTimeSig.BorderThickness = BorderThickness;

            TechDeathSongLength.Content = genreDictionary["Tech Death"].songLength;
            TechDeathSongLength.BorderBrush = BorderBrush;
            TechDeathSongLength.BorderThickness = BorderThickness;

            DoomName.Content = genreDictionary["Doom"].name;
            DoomName.BorderBrush = BorderBrush;
            DoomName.BorderThickness = BorderThickness;

            DoomBPM.Content = genreDictionary["Doom"].bpm;
            DoomBPM.BorderBrush = BorderBrush;
            DoomBPM.BorderThickness = BorderThickness;

            DoomTuning.Content = genreDictionary["Doom"].tuning;
            DoomTuning.BorderBrush = BorderBrush;
            DoomTuning.BorderThickness = BorderThickness;

            DoomTimeSig.Content = genreDictionary["Doom"].timeSignature;
            DoomTimeSig.BorderBrush = BorderBrush;
            DoomTimeSig.BorderThickness = BorderThickness;

            DoomSongLength.Content = genreDictionary["Doom"].songLength;
            DoomSongLength.BorderBrush = BorderBrush;
            DoomSongLength.BorderThickness = BorderThickness;

            DeathDoomName.Content = genreDictionary["Death/Doom"].name;
            DeathDoomName.BorderBrush = BorderBrush;
            DeathDoomName.BorderThickness = BorderThickness;

            DeathDoomBPM.Content = genreDictionary["Death/Doom"].bpm;
            DeathDoomBPM.BorderBrush = BorderBrush;
            DeathDoomBPM.BorderThickness = BorderThickness;

            DeathDoomTuning.Content = genreDictionary["Death/Doom"].tuning;
            DeathDoomTuning.BorderBrush = BorderBrush;
            DeathDoomTuning.BorderThickness = BorderThickness;

            DeathDoomTimeSig.Content = genreDictionary["Death/Doom"].timeSignature;
            DeathDoomTimeSig.BorderBrush = BorderBrush;
            DeathDoomTimeSig.BorderThickness = BorderThickness;

            DeathDoomSongLength.Content = genreDictionary["Death/Doom"].songLength;
            DeathDoomSongLength.BorderBrush = BorderBrush;
            DeathDoomSongLength.BorderThickness = BorderThickness;


            SludgeName.Content = genreDictionary["Sludge"].name;
            SludgeName.BorderBrush = BorderBrush;
            SludgeName.BorderThickness = BorderThickness;

            SludgeBPM.Content = genreDictionary["Sludge"].bpm;
            SludgeBPM.BorderBrush = BorderBrush;
            SludgeBPM.BorderThickness = BorderThickness;

            SludgeTuning.Content = genreDictionary["Sludge"].tuning;
            SludgeTuning.BorderBrush = BorderBrush;
            SludgeTuning.BorderThickness = BorderThickness;

            SludgeTimeSig.Content = genreDictionary["Sludge"].timeSignature;
            SludgeTimeSig.BorderBrush = BorderBrush;
            SludgeTimeSig.BorderThickness = BorderThickness;

            SludgeSongLength.Content = genreDictionary["Sludge"].songLength;
            SludgeSongLength.BorderBrush = BorderBrush;
            SludgeSongLength.BorderThickness = BorderThickness;

            AltName.Content = genreDictionary["Alt"].name;
            AltName.BorderBrush = BorderBrush;
            AltName.BorderThickness = BorderThickness;

            AltBPM.Content = genreDictionary["Alt"].bpm;
            AltBPM.BorderBrush = BorderBrush;
            AltBPM.BorderThickness = BorderThickness;

            AltTuning.Content = genreDictionary["Alt"].tuning;
            AltTuning.BorderBrush = BorderBrush;
            AltTuning.BorderThickness = BorderThickness;

            AltTimeSig.Content = genreDictionary["Alt"].timeSignature;
            AltTimeSig.BorderBrush = BorderBrush;
            AltTimeSig.BorderThickness = BorderThickness;

            AltSongLength.Content = genreDictionary["Alt"].songLength;
            AltSongLength.BorderBrush = BorderBrush;
            AltSongLength.BorderThickness = BorderThickness;

            NuName.Content = genreDictionary["Nu"].name;
            NuName.BorderBrush = BorderBrush;
            NuName.BorderThickness = BorderThickness;

            NuBPM.Content = genreDictionary["Nu"].bpm;
            NuBPM.BorderBrush = BorderBrush;
            NuBPM.BorderThickness = BorderThickness;

            NuTuning.Content = genreDictionary["Nu"].tuning;
            NuTuning.BorderBrush = BorderBrush;
            NuTuning.BorderThickness = BorderThickness;

            NuTimeSig.Content = genreDictionary["Nu"].timeSignature;
            NuTimeSig.BorderBrush = BorderBrush;
            NuTimeSig.BorderThickness = BorderThickness;

            NuSongLength.Content = genreDictionary["Nu"].songLength;
            NuSongLength.BorderBrush = BorderBrush;
            NuSongLength.BorderThickness = BorderThickness;

            DjentName.Content = genreDictionary["Djent"].name;
            DjentName.BorderBrush = BorderBrush;
            DjentName.BorderThickness = BorderThickness;

            DjentBPM.Content = genreDictionary["Djent"].bpm;
            DjentBPM.BorderBrush = BorderBrush;
            DjentBPM.BorderThickness = BorderThickness;

            DjentTuning.Content = genreDictionary["Djent"].tuning;
            DjentTuning.BorderBrush = BorderBrush;
            DjentTuning.BorderThickness = BorderThickness;

            DjentTimeSig.Content = genreDictionary["Djent"].timeSignature;
            DjentTimeSig.BorderBrush = BorderBrush;
            DjentTimeSig.BorderThickness = BorderThickness;

            DjentSongLength.Content = genreDictionary["Djent"].songLength;
            DjentSongLength.BorderBrush = BorderBrush;
            DjentSongLength.BorderThickness = BorderThickness;

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

        private void Info_Click(object sender, RoutedEventArgs e)
        {

            Summary summary = new Summary();
            summary.Show();
        }


    }
}
