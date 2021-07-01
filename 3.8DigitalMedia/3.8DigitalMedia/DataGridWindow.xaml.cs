using System.Collections.Generic;
using System.Windows;

namespace _3._8DigitalMedia
{
    /// <summary>
    /// Interaction logic for DataGridWindow.xaml
    /// </summary>
    public partial class DataGridWindow : Window
    {
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
                { "Industrial", new Genre("Industrial Metal", BPM.Medium, Tuning.Standard, TimeSignature.Static, SongLength.Short, Instrumentation.Classic) }
            };
        public DataGridWindow()
        {
            InitializeComponent();
            GenreDataGrid.Items.Add(new DataItem
            {
                Column1 = genreDictionary["Heavy"].name,
                Column2 = genreDictionary["Heavy"].bpm.ToString(),
                Column3 = genreDictionary["Heavy"].tuning.ToString(),
                Column4 = genreDictionary["Heavy"].timeSignature.ToString(),
                Column5 = genreDictionary["Heavy"].songLength.ToString(),
                Column6 = genreDictionary["Heavy"].instrumentation.ToString()
            });
            GenreDataGrid.Items.Add(new DataItem
            {
                Column1 = genreDictionary["Prog"].name,
                Column2 = genreDictionary["Prog"].bpm.ToString(),
                Column3 = genreDictionary["Prog"].tuning.ToString(),
                Column4 = genreDictionary["Prog"].timeSignature.ToString(),
                Column5 = genreDictionary["Prog"].songLength.ToString(),
                Column6 = genreDictionary["Prog"].instrumentation.ToString()
            });
            GenreDataGrid.Items.Add(new DataItem
            {
                Column1 = genreDictionary["Groove"].name,
                Column2 = genreDictionary["Groove"].bpm.ToString(),
                Column3 = genreDictionary["Groove"].tuning.ToString(),
                Column4 = genreDictionary["Groove"].timeSignature.ToString(),
                Column5 = genreDictionary["Groove"].songLength.ToString(),
                Column6 = genreDictionary["Groove"].instrumentation.ToString()
            });
            GenreDataGrid.Items.Add(new DataItem
            {
                Column1 = genreDictionary["Industrial"].name,
                Column2 = genreDictionary["Industrial"].bpm.ToString(),
                Column3 = genreDictionary["Industrial"].tuning.ToString(),
                Column4 = genreDictionary["Industrial"].timeSignature.ToString(),
                Column5 = genreDictionary["Industrial"].songLength.ToString(),
                Column6 = genreDictionary["Industrial"].instrumentation.ToString()
            });
            GenreDataGrid.Items.Add(new DataItem
            {
                Column1 = genreDictionary["Thrash"].name,
                Column2 = genreDictionary["Thrash"].bpm.ToString(),
                Column3 = genreDictionary["Thrash"].tuning.ToString(),
                Column4 = genreDictionary["Thrash"].timeSignature.ToString(),
                Column5 = genreDictionary["Thrash"].songLength.ToString(),
                Column6 = genreDictionary["Thrash"].instrumentation.ToString()
            });
            GenreDataGrid.Items.Add(new DataItem
            {
                Column1 = genreDictionary["Black"].name,
                Column2 = genreDictionary["Black"].bpm.ToString(),
                Column3 = genreDictionary["Black"].tuning.ToString(),
                Column4 = genreDictionary["Black"].timeSignature.ToString(),
                Column5 = genreDictionary["Black"].songLength.ToString(),
                Column6 = genreDictionary["Black"].instrumentation.ToString()
            });
            GenreDataGrid.Items.Add(new DataItem
            {
                Column1 = genreDictionary["Power"].name,
                Column2 = genreDictionary["Power"].bpm.ToString(),
                Column3 = genreDictionary["Power"].tuning.ToString(),
                Column4 = genreDictionary["Power"].timeSignature.ToString(),
                Column5 = genreDictionary["Power"].songLength.ToString(),
                Column6 = genreDictionary["Power"].instrumentation.ToString()
            });
            GenreDataGrid.Items.Add(new DataItem
            {
                Column1 = genreDictionary["Death"].name,
                Column2 = genreDictionary["Death"].bpm.ToString(),
                Column3 = genreDictionary["Death"].tuning.ToString(),
                Column4 = genreDictionary["Death"].timeSignature.ToString(),
                Column5 = genreDictionary["Death"].songLength.ToString(),
                Column6 = genreDictionary["Death"].instrumentation.ToString()
            });
            GenreDataGrid.Items.Add(new DataItem
            {
                Column1 = genreDictionary["Tech Death"].name,
                Column2 = genreDictionary["Tech Death"].bpm.ToString(),
                Column3 = genreDictionary["Tech Death"].tuning.ToString(),
                Column4 = genreDictionary["Tech Death"].timeSignature.ToString(),
                Column5 = genreDictionary["Tech Death"].songLength.ToString(),
                Column6 = genreDictionary["Tech Death"].instrumentation.ToString()
            });
            GenreDataGrid.Items.Add(new DataItem
            {
                Column1 = genreDictionary["Doom"].name,
                Column2 = genreDictionary["Doom"].bpm.ToString(),
                Column3 = genreDictionary["Doom"].tuning.ToString(),
                Column4 = genreDictionary["Doom"].timeSignature.ToString(),
                Column5 = genreDictionary["Doom"].songLength.ToString(),
                Column6 = genreDictionary["Doom"].instrumentation.ToString()
            });
            GenreDataGrid.Items.Add(new DataItem
            {
                Column1 = genreDictionary["Death/Doom"].name,
                Column2 = genreDictionary["Death/Doom"].bpm.ToString(),
                Column3 = genreDictionary["Death/Doom"].tuning.ToString(),
                Column4 = genreDictionary["Death/Doom"].timeSignature.ToString(),
                Column5 = genreDictionary["Death/Doom"].songLength.ToString(),
                Column6 = genreDictionary["Death/Doom"].instrumentation.ToString()
            });
            GenreDataGrid.Items.Add(new DataItem
            {
                Column1 = genreDictionary["Sludge"].name,
                Column2 = genreDictionary["Sludge"].bpm.ToString(),
                Column3 = genreDictionary["Sludge"].tuning.ToString(),
                Column4 = genreDictionary["Sludge"].timeSignature.ToString(),
                Column5 = genreDictionary["Sludge"].songLength.ToString(),
                Column6 = genreDictionary["Sludge"].instrumentation.ToString()
            });
            GenreDataGrid.Items.Add(new DataItem
            {
                Column1 = genreDictionary["Alt"].name,
                Column2 = genreDictionary["Alt"].bpm.ToString(),
                Column3 = genreDictionary["Alt"].tuning.ToString(),
                Column4 = genreDictionary["Alt"].timeSignature.ToString(),
                Column5 = genreDictionary["Alt"].songLength.ToString(),
                Column6 = genreDictionary["Alt"].instrumentation.ToString()
            });
            GenreDataGrid.Items.Add(new DataItem
            {
                Column1 = genreDictionary["Nu"].name,
                Column2 = genreDictionary["Nu"].bpm.ToString(),
                Column3 = genreDictionary["Nu"].tuning.ToString(),
                Column4 = genreDictionary["Nu"].timeSignature.ToString(),
                Column5 = genreDictionary["Nu"].songLength.ToString(),
                Column6 = genreDictionary["Nu"].instrumentation.ToString()
            });
            GenreDataGrid.Items.Add(new DataItem
            {
                Column1 = genreDictionary["Djent"].name,
                Column2 = genreDictionary["Djent"].bpm.ToString(),
                Column3 = genreDictionary["Djent"].tuning.ToString(),
                Column4 = genreDictionary["Djent"].timeSignature.ToString(),
                Column5 = genreDictionary["Djent"].songLength.ToString(),
                Column6 = genreDictionary["Djent"].instrumentation.ToString()
            });




        }
        public class DataItem
        {
            public string Column1 { get; set; }
            public string Column2 { get; set; }
            public string Column3 { get; set; }
            public string Column4 { get; set; }
            public string Column5 { get; set; }
            public string Column6 { get; set; }
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
        public enum Instrumentation
        {
            Classic,
            Orchestral,
            TraditionalFolk,
            MongolianFolk
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
            Summary summary = new Summary();
            summary.Show();
        }


    }
}
