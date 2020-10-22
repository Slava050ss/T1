using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Laba1
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Random rand;
        public MainPage()
        {
            this.InitializeComponent();
            rand = new Random();
        }
        private byte[] GetRandomBytes(int n)
        {
            var randomBytes = new byte[n];
            rand.NextBytes(randomBytes);
            return randomBytes;
        }


        private void T_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            byte[] rgb = GetRandomBytes(3);
            //создать сплошной цвет 3 ранд знач 
            var randomCoulorBruch = new SolidColorBrush(Color.FromArgb(255, rgb[0], rgb[1], rgb[2]));
            T.BorderBrush = randomCoulorBruch;
            T.Foreground = randomCoulorBruch;
        }
    }
}
