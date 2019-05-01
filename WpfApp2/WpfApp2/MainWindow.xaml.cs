using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Data
        Bitmap Pass2_1;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            Pass2_1 = (Bitmap)Bitmap.FromFile("Data//Pass2_1.png");
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Task t = new Task(() =>
            {
                
                Auto();
            });
            t.Start();
        }

        

        void Auto()
        {
            List<String> devices = new List<string>();
             devices = KAutoHelper.ADBHelper.GetDevices();

            var n = 0;
            foreach(var deviceID in devices)
            {
                Task t = new Task(() =>
                {
                    while (true)
                    {
                        Delay(1);
                        n++;
                        Delay(3);
                        KAutoHelper.ADBHelper.InputText(deviceID, ""+n);
                        Delay(2);

                        KAutoHelper.ADBHelper.TapByPercent(deviceID, 7.8, 14.1);
                        Delay(3);

                        KAutoHelper.ADBHelper.InputText(deviceID, "k");
                        Delay(1);
                        KAutoHelper.ADBHelper.InputText(deviceID, "a");
                        Delay(2);
                        KAutoHelper.ADBHelper.InputText(deviceID, "n");
                        Delay(1);
                        KAutoHelper.ADBHelper.InputText(deviceID, "g");
                        Delay(1);
                        KAutoHelper.ADBHelper.InputText(deviceID, "h");
                        Delay(1);
                        KAutoHelper.ADBHelper.InputText(deviceID, "y");
                        Delay(2);
                        KAutoHelper.ADBHelper.InputText(deviceID, "n");
                        Delay(2);

                        KAutoHelper.ADBHelper.TapByPercent(deviceID, 56.2, 14.3);
                        Delay(3);

                        KAutoHelper.ADBHelper.Key(deviceID, KAutoHelper.ADBKeyEvent.KEYCODE_TAB);
                        Delay(3);

                        Delay(2);
                        KAutoHelper.ADBHelper.InputText(deviceID, "1");
                        Delay(1);
                        KAutoHelper.ADBHelper.InputText(deviceID, "2");
                        Delay(1);
                        KAutoHelper.ADBHelper.InputText(deviceID, "3");
                        Delay(1);
                        KAutoHelper.ADBHelper.InputText(deviceID, "4");
                        Delay(1);
                        KAutoHelper.ADBHelper.InputText(deviceID, "5");
                        Delay(1);
                        KAutoHelper.ADBHelper.InputText(deviceID, "6");
                        Delay(1);
                        KAutoHelper.ADBHelper.InputText(deviceID, "q");
                        Delay(1);
                        KAutoHelper.ADBHelper.InputText(deviceID, "w");
                        Delay(1);
                        KAutoHelper.ADBHelper.InputText(deviceID, "e");
                        Delay(3);

                        KAutoHelper.ADBHelper.Key(deviceID, KAutoHelper.ADBKeyEvent.KEYCODE_ENTER);
                        Delay(15);

                        
                        for (int i = 0; i <= 4; i++)
                        {
                            
                            
                            var screen = KAutoHelper.ADBHelper.ScreenShoot(deviceID);
                            var topUpPoint = KAutoHelper.ImageScanOpenCV.FindOutPoint(screen, Pass2_1);
                            

                            if (topUpPoint != null)
                            {
                                KAutoHelper.ADBHelper.Tap(deviceID, topUpPoint.Value.X, topUpPoint.Value.Y);
                                Delay(5);
                            }

                            if(topUpPoint == null)
                            {
                                Delay(10);
                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 47.6, 38.2);
                                Delay(10);

                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 92.2, 17.2);
                                Delay(3);

                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 72.3, 82.1);
                                Delay(3);

                                KAutoHelper.ADBHelper.TapByPercent(deviceID, 78.8, 63.9);
                                Delay(7);
                            }



                        }
                        
                        

                        
                            

                        


                    }
                });
                t.Start();
            }

        }

        

        void Delay(int Delay)
        {
            while (Delay > 0)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Delay--;
                
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
