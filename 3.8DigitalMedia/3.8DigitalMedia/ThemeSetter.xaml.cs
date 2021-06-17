using System;
using System.Windows;
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


            
            if (ColourSelector.SelectedItem == Dragonforce)
            {
                
                uriSkin = @"Resources\DragonForce\DragonForceDict.xaml";
            }
            else if(ColourSelector.SelectedItem == Slayer)
            {
                
                uriSkin = @"Resources\Slayer\SlayerDict.xaml";
            }
            else if (ColourSelector.SelectedItem == Metallica)
            {
                uriSkin = @"Resources\Metallica\MetallicaDict.xaml";
            }
            else if (ColourSelector.SelectedItem == SOAD)
            {
                uriSkin = @"Resources\SOAD\SOADDict.xaml";
            }
            else if (ColourSelector.SelectedItem == Default)
            {
                uriSkin = @"Resources\Default\DefaultTheme.xaml";
            }
            rd.MergedDictionaries.Add(Application.LoadComponent(new Uri(uriSkin, UriKind.Relative)) as ResourceDictionary);
            Application.Current.Resources = rd;
        }
    }

}

