using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Timers;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BigApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int score = 0;
        int clickamount = 1;
        int upgradecost = 10;
        int timerincreasecost = 10;
        int atimertime = 2000;
        bool doauto = false;
        System.Timers.Timer aTimer;


        private async void ScreenUpdate()
        {
            testbox.Text = Convert.ToString(score);
            UpgradeCost.Text = Convert.ToString(upgradecost);
            ClickAmount.Text = "+"+Convert.ToString(clickamount);
            AutoToggle.Content = Convert.ToString(doauto);
            TimeIncrease.Content = Convert.ToString(atimertime);
            TimeCost.Text = Convert.ToString(timerincreasecost);
        }

        private void Clicked()
        {
            score = score + clickamount;
        }
        public MainPage()
        {
            
            InitializeComponent();
            DataContext = this;
            ScreenUpdate();
            SetTimer();

        }

        private void BIG_Button_Click(object sender, RoutedEventArgs e)
        {
            Clicked();
            ScreenUpdate();
        }

        private void UPGRADE_Click(object sender, RoutedEventArgs e)
        {
            if(score>=upgradecost)
            {
                clickamount++;
                score = score - upgradecost;
                upgradecost = Convert.ToInt32(upgradecost * 1.1);
                ScreenUpdate();
            }
            
            
        }
        private void AutoToggle_Click(object sender, RoutedEventArgs e)
        {
            doauto = !doauto;
            ScreenUpdate();
        }
        private async void TimeIncrease_Click(object sender, RoutedEventArgs e)
        {
            if (timerincreasecost <= score)
            {
                score = score - timerincreasecost;
                timerincreasecost = Convert.ToInt32(timerincreasecost * 1.1);
                atimertime = Convert.ToInt32(atimertime * 0.95);
                aTimer.Enabled = false;
                aTimer.Interval = atimertime;
                aTimer.Enabled = true;
                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    ScreenUpdate();
                });
            };
        }
        private void testbox_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void UpgradeCost_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        private void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(atimertime);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        private async void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (doauto)
            {
                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    Clicked();
                    ScreenUpdate();
                });
                
            }
        }

    }
}
