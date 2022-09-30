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

namespace Wpf_Pisarev_Aleksei_Nikolaevih_PR2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private object lbl1;
        private object inkCanvas1;

        public Window1()
        {
            InitializeComponent();
            mcolor = new ColorRGB();
            mcolor.red = 0;
            mcolor.green = 0;
            mcolor.blue = 0;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public class ColorRGB
        {
            public byte red { get; set; }
            public byte green { get; set; }
            public byte blue { get; set; }
        }
        public ColorRGB mcolor { get; set; }

        public Color clr { get; set; }
        private void sld_Color_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            string crlName = slider.Name; 
            double value = slider.Value;
                                         
            if (crlName.Equals("sld_RedColor"))
            {
                mcolor.red = Convert.ToByte(value);
            }
            if (crlName.Equals("sld_GreenColor"))
            {
                mcolor.green = Convert.ToByte(value);
            }
            if (crlName.Equals("sld_BlueColor"))
            {
                mcolor.blue = Convert.ToByte(value);
            }

            
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
           
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object p = this.inkCanvas1.Strokes.Clear();
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btn_kisti_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.EditingMode = InkCanvasEditingMode.Ink;

        }

        private void btn_lastik_Click(object sender, RoutedEventArgs e)
        {
            if (inkCanvas1.EditingMode == InkCanvasEditingMode.Ink)
                inkCanvas1.EditingMode = InkCanvasEditingMode.EraseByPoint;
            else
                inkCanvas1.EditingMode = InkCanvasEditingMode.Ink;
        }



    }

}
