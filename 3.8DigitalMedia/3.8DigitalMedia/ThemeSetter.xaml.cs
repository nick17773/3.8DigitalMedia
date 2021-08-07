using System;
using System.Windows;
using System.Media;
using System.Diagnostics;


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



        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var rd = new ResourceDictionary();
            var soundPlayer = new SoundPlayer();


            if (ColourSelector.SelectedItem == Dragonforce)
            {

                uriSkin = @"Resources\DragonForce\DragonForceDict.xaml";
                soundPlayer = new SoundPlayer(Properties.Resources.TTFAFIntro);
                soundPlayer.Play();
            }
            else if (ColourSelector.SelectedItem == Slayer)
            {

                uriSkin = @"Resources\Slayer\SlayerDict.xaml";
                soundPlayer = new SoundPlayer(Properties.Resources.SOHIntro);
                soundPlayer.Play();

                
                
            }
            else if (ColourSelector.SelectedItem == Metallica)
            {
                uriSkin = @"Resources\Metallica\MetallicaDict.xaml";
                soundPlayer = new SoundPlayer(Properties.Resources.BellzIntro);
                soundPlayer.Play();
            }
            else if (ColourSelector.SelectedItem == SOAD)
            {
                uriSkin = @"Resources\SOAD\SOADDict.xaml";
                soundPlayer = new SoundPlayer(Properties.Resources.SuicideIntro);
                soundPlayer.Play();
            }
            else if (ColourSelector.SelectedItem == Pantera)
            {
                uriSkin = @"Resources\Pantera\PanteraDict.xaml";
                soundPlayer = new SoundPlayer(Properties.Resources.WalkIntro);
                soundPlayer.Play();
            }
            else if (ColourSelector.SelectedItem == Tool)
            {
                uriSkin = @"Resources\Tool\ToolDict.xaml";
                soundPlayer = new SoundPlayer(Properties.Resources.SchizIntro);
                soundPlayer.Play();
            }
            else if (ColourSelector.SelectedItem == Megadeth)
            {
                uriSkin = @"Resources\Megadeth\MegadethDict.xaml";
                soundPlayer = new SoundPlayer(Properties.Resources.TOSIntro);
                soundPlayer.Play();
            }
            else if (ColourSelector.SelectedItem == Trivium)
            {
                uriSkin = @"Resources\Trivium\TriviumDict.xaml";
                soundPlayer = new SoundPlayer(Properties.Resources.DeadMenIntro);
                soundPlayer.Play();
            }
            else if (ColourSelector.SelectedItem == Default)
            {
                uriSkin = @"Resources\Default\DefaultTheme.xaml";
                soundPlayer.Stop();
            }
            rd.MergedDictionaries.Add(Application.LoadComponent(new Uri(uriSkin, UriKind.Relative)) as ResourceDictionary);
            Application.Current.Resources = rd;

            
            
            
        }
    }

}

