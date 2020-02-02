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
        int clickamount2 = 1;
        int upgradecost = 10;
        int timerincreasecost = 10;
        int atimertime = 2000;
        bool doauto = false;
        System.Timers.Timer aTimer;
        double mult1amount = 1;
        double mult2amount = 1;
        double mult3amount = 1;
        double mult4amount = 1;
        int mult1cost = 10;
        int mult2cost = 100;
        int mult3cost = 1000;
        int mult4cost = 1000;



        private async void ScreenUpdate()
        {
            testbox.Text = Convert.ToString(score);
            UpgradeCost.Text = Convert.ToString(upgradecost);
            ClickAmount.Text = "+"+Convert.ToString(clickamount);
            AutoToggle.Content = Convert.ToString(doauto);
            TimeIncrease.Content = Convert.ToString(atimertime);
            TimeCost.Text = Convert.ToString(timerincreasecost);
            Multiplier1.Content = Convert.ToString(mult1amount);
            Multiplier2.Content = Convert.ToString(mult2amount);
            Multiplier3.Content = Convert.ToString(mult3amount);
            Multiplier4.Content = Convert.ToString(mult4amount);
            Multiplier1Cost.Text = Convert.ToString(mult1cost);
            Multiplier2Cost.Text = Convert.ToString(mult2cost);
            Multiplier3Cost.Text = Convert.ToString(mult3cost);
            Multiplier4Cost.Text = Convert.ToString(mult4cost);
            ClickAmount2.Text = Convert.ToString(clickamount2);
        }

        private void recalcclick()
        {
            clickamount2 = Convert.ToInt32(clickamount * mult1amount * mult2amount * mult3amount * mult4amount);
        }
        private void Clicked()
        {
            score = score + clickamount2;
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
                recalcclick();
                ScreenUpdate();
            }
            
            
        }
        private void AutoToggle_Click(object sender, RoutedEventArgs e)
        {
            doauto = !doauto;
            ScreenUpdate();
        }
        private void Multiplier1_Click(object sender, RoutedEventArgs e)
        {
            if (score >= mult1cost)
            {
                score = score - mult1cost;
                mult1amount = mult1amount + 0.5;
                mult1cost = Convert.ToInt32(mult1cost * 2);
                recalcclick();
                ScreenUpdate();
            }
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

        private void Multiplier2_Click(object sender, RoutedEventArgs e)
        {
            if (score >= mult2cost)
            {
                score = score - mult2cost;
                mult2amount = mult2amount + 0.5;
                mult2cost = Convert.ToInt32(mult2cost * 2);
                recalcclick();
                ScreenUpdate();
            }
        }
        private void Multiplier3_Click(object sender, RoutedEventArgs e)
        {
            if (score >= mult3cost)
            {
                score = score - mult3cost;
                mult3amount = mult3amount + 0.5;
                mult3cost = Convert.ToInt32(mult3cost * 2);
                recalcclick();
                ScreenUpdate();
            }
        }

        private void Multiplier4_Click(object sender, RoutedEventArgs e)
        {
            if (score >= mult4cost)
            {
                score = score - mult4cost;
                mult4amount = mult4amount + 0.5;
                mult4cost = Convert.ToInt32(mult4cost * 2);
                recalcclick();
                ScreenUpdate();
            }
        }
    }
}
