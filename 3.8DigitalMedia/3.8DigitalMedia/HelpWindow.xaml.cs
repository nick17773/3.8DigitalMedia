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
    /// Interaction logic for HelpWindow.xaml
    /// </summary>
    public partial class HelpWindow : Window
    {
        public HelpWindow()
        {
            InitializeComponent();
            //RandomEffect();
            
        }
        
        //private async void RandomEffect()
        //{
        //    for (int woosh = 0; woosh < 50; woosh++)
        //    {
        //        int rotat_e = 0;
                
        //        RotateTransform rotatE = new RotateTransform(rotat_e += 10);
        //        HelpTitle.RenderTransform = rotatE;
                
        //        int Delay = 10;
        //        await Task.Delay(Delay);
        //    }
        //}


    }
}
