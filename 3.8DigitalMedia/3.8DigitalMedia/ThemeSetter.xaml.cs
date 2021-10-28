using System;
using System.Media;
using System.Windows;


namespace _3._8DigitalMedia
{
    /// <summary>
    /// Interaction logic for ThemeSetter.xaml
    /// </summary>
    public partial class ThemeSetter : Window
    {

        string uriSkin;

        public ThemeSetter()
        {
            InitializeComponent();
        }



        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) // selection logic for the themes, with the sound player (# WILL IMPLEMENT MUTE FUNCTION IN OWN TIME OUT OF SCHOOL)
        {
            var rd = new ResourceDictionary();
            var soundPlayer = new SoundPlayer();

            if (ColourSelector.SelectedItem == Dragonforce)
            {

                uriSkin = @"Resources\DragonForce\DragonForceDict.xaml";
                soundPlayer = new SoundPlayer(Properties.Resources.TTFAFIntro);
                soundPlayer.Play();

                SongLabel.Content = "Band Theme Song: Through the Fire & Flames";
                AlbumLabel.Content = @"Album Inspiration: 
Extreme Power Metal (2019)";
                SongLabel.FontSize = 20;
                AlbumLabel.FontSize = 20;
            }
            else if (ColourSelector.SelectedItem == Slayer)
            {

                uriSkin = @"Resources\Slayer\SlayerDict.xaml";
                soundPlayer = new SoundPlayer(Properties.Resources.SOHIntro);
                soundPlayer.Play();

                SongLabel.Content = "Band Theme Song: South Of Heaven";
                AlbumLabel.Content = @"Album Inspiration: 
Repentless";
                SongLabel.FontSize = 20;
                AlbumLabel.FontSize = 20;
            }
            else if (ColourSelector.SelectedItem == Metallica)
            {
                uriSkin = @"Resources\Metallica\MetallicaDict.xaml";
                soundPlayer = new SoundPlayer(Properties.Resources.BellzIntro);
                soundPlayer.Play();

                SongLabel.Content = "Band Theme Song: For Whom the Bell Tolls";
                AlbumLabel.Content = @"Album Inspiration: 
Hardwired to Self-destruct (2016)";
                SongLabel.FontSize = 24;
                AlbumLabel.FontSize = 24;
            }
            else if (ColourSelector.SelectedItem == SOAD)
            {
                uriSkin = @"Resources\SOAD\SOADDict.xaml";
                soundPlayer = new SoundPlayer(Properties.Resources.SuicideIntro);
                soundPlayer.Play();

                SongLabel.Content = "Band Theme Song: Chop Suey!";
                AlbumLabel.Content = @"Album Inspiration: 
Protect the Land/Genocidal Humanoidz (2020)";
                SongLabel.FontSize = 20;
                AlbumLabel.FontSize = 20;
            }
            else if (ColourSelector.SelectedItem == Pantera)
            {
                uriSkin = @"Resources\Pantera\PanteraDict.xaml";
                soundPlayer = new SoundPlayer(Properties.Resources.WalkIntro);
                soundPlayer.Play();


                SongLabel.Content = "Band Theme Song: Walk";
                AlbumLabel.Content = @"Album Inspiration: 
Vulgar Display of Power (1992)";
                SongLabel.FontSize = 20;
                AlbumLabel.FontSize = 20;
            }
            else if (ColourSelector.SelectedItem == Tool)
            {
                uriSkin = @"Resources\Tool\ToolDict.xaml";
                soundPlayer = new SoundPlayer(Properties.Resources.SchizIntro);
                soundPlayer.Play();

                SongLabel.Content = "Band Theme Song: Schism";
                AlbumLabel.Content = @"Album Inspiration: 
Lateralus (2001)";
            }
            else if (ColourSelector.SelectedItem == Megadeth)
            {
                uriSkin = @"Resources\Megadeth\MegadethDict.xaml";
                soundPlayer = new SoundPlayer(Properties.Resources.TOSIntro);
                soundPlayer.Play();

                SongLabel.Content = "Band Theme Song: Tornado of Souls";
                AlbumLabel.Content = @"Album Inspiration: 
Warheads on Foreheads (2019)";
                SongLabel.FontSize = 20;
                AlbumLabel.FontSize = 20;
            }
            else if (ColourSelector.SelectedItem == Trivium)
            {
                uriSkin = @"Resources\Trivium\TriviumDict.xaml";
                soundPlayer = new SoundPlayer(Properties.Resources.DeadMenIntro);
                soundPlayer.Play();

                SongLabel.Content = @"Band Theme Song: 
What the Dead Men Say/IX";
                AlbumLabel.Content = @"Album Inspiration: 
The Sin and the Sentence (2017)";
            }
            else if (ColourSelector.SelectedItem == Default)
            {
                uriSkin = @"Resources\Default\DefaultTheme.xaml";
                soundPlayer.Stop();

                SongLabel.Content = "Band Theme Song:";
                AlbumLabel.Content = "Album Inspiration:";
            }
            rd.MergedDictionaries.Add(Application.LoadComponent(new Uri(uriSkin, UriKind.Relative)) as ResourceDictionary);
            Application.Current.Resources = rd;




        }
    }

}

