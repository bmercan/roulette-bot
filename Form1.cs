using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Runtime.InteropServices;

namespace rouletteBet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int totalRoundCounter = 0;
        int roundLimiter = 0;
        int generatedNumber;
        int counter = 1;
        int roundCounter = 1;
        bool betable = true;
        bool start = true;
        private void Form1_Load(object sender, EventArgs e)
        {
            firefoxservice.HideCommandPromptWindow = true;
            firefox = new FirefoxDriver(firefoxservice, new FirefoxOptions());
            firefox.Navigate().GoToUrl("https://www.google.com");

        }

        static FirefoxDriverService firefoxservice = FirefoxDriverService.CreateDefaultService();
        static FirefoxDriver firefox;

        private void clicker(int num)
        {

            try
            {
                firefox.SwitchTo().Window(firefox.WindowHandles.Last());
                var DBViFrame = firefox.FindElement(By.TagName("iframe"));
                firefox.SwitchTo().Frame(DBViFrame);
                var dataEntryButton = firefox.FindElement(By.XPath("//*[name()=\"svg\"]//*[name()=\"g\"]//*[name()=\"rect\"][" + num + "]"));
                dataEntryButton.Click();
            }
            catch (Exception)
            {
                predicts.Remove(num);
                int newNumber = _random.Next(1, 37);
                clicker(newNumber);
                predicts.Add(newNumber);
            }


        }
        private readonly Random _random = new Random();
        private void numberGenerator()
        {
            generatedNumber = _random.Next(18, 24);
        }

        List<int> predicts = new List<int>();
        private void predicter()
        {
            for (int i = 0; i < generatedNumber; i++)
            {
                int predictedNumber = _random.Next(1, 37);
                predicts.Add(predictedNumber);
            }
            foreach (var item in predicts)
            {
                Console.WriteLine(counter + ". " + item);
                counter++;
            }
            counter = 1;
        }
        private void better()
        {
            if (roundCounter <= 3)
            {
                if (predicts.Contains(luckyNumber()) == false && roundCounter != 1)
                {
                    predicts.Clear();
                    numberGenerator();
                    predicter();
                    foreach (var item in predicts.ToList())
                    {
                        clicker(item);
                    }
                    doubleOrNothing();
                }
                else
                {
                    predicts.Clear();
                    numberGenerator();
                    predicter();
                    foreach (var item in predicts.ToList())
                    {
                        clicker(item);
                    }
                }
            }
            else if (roundCounter == 5)
            {
                roundCounter = 0;
            }
            roundCounter++;
            totalRoundCounter++;
            rounder();

        }

        private void rounder()
        {
            if (roundLimiter != 0)
            {
                label5.Visible = true;
                label5.Text = Convert.ToString(roundLimiter - totalRoundCounter);
                guna2TrackBar2.Value = roundLimiter - totalRoundCounter;
            }
        }



        private void checkBetsOpen()
        {
            try
            {
                var DBViFrame = firefox.FindElement(By.TagName("iframe"));
                firefox.SwitchTo().Frame(DBViFrame);

                var dataEntryButton = firefox.FindElement(By.CssSelector("status--ibRSv green--3odx9 landscape--NHZOX animate--I1-ic desktop-theme--fmEBL"));

                string classChecker = dataEntryButton.GetAttribute("class");

                //if betable
                if (classChecker == "status--ibRSv green--3odx9 landscape--NHZOX animate--I1-ic desktop-theme--fmEBL")
                {
                    if (betable == true)
                    {
                        if (totalRoundCounter < roundLimiter || roundLimiter == 0)
                        {
                            //betted
                            better();
                            betable = false;
                        }
                        else
                        {
                            timer1.Stop();
                            baslaButton.Text = "START";
                            totalRoundCounter = 0;
                            roundLimiter = 0;
                            start = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bets on but not betted");
                    }

                }
                //bets off
                else if (classChecker == "status--ibRSv red--G7i1l landscape--NHZOX animate--I1-ic desktop-theme--fmEBL")
                {
                    betable = true;
                    Console.WriteLine("Bahisler Kapalı");
                }
            }
            catch (Exception)
            {
                timer1.Stop();
                start = true;
                baslaButton.Text = "START";
                MessageBox.Show("Table state cannot found");
            }
         

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            checkBetsOpen();
        }


        //winner number
        private int luckyNumber()
        {

            firefox.SwitchTo().Window(firefox.WindowHandles.Last());
            var DBViFrame = firefox.FindElement(By.TagName("iframe"));
            firefox.SwitchTo().Frame(DBViFrame);
            var dataEntryButton = firefox.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[2]/div/div[5]/div[2]/div/div/div/div[2]/div/div[1]/div"));
            string classChecker = dataEntryButton.GetAttribute("innerHTML");

            Console.WriteLine(Convert.ToInt32(classChecker.Split(new string[] { ">" }, StringSplitOptions.None)[1].Split('<')[0].Trim()));

            return Convert.ToInt32(classChecker.Split(new string[] { ">" }, StringSplitOptions.None)[1].Split('<')[0].Trim());
        }
        //doubles bet
        public void doubleOrNothing()
        {
            firefox.SwitchTo().Window(firefox.WindowHandles.Last());
            var DBViFrame = firefox.FindElement(By.TagName("iframe"));
            firefox.SwitchTo().Frame(DBViFrame);
            var dataEntryButton = firefox.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[2]/div/div[6]/div[3]/div/div/div[3]/div/button/span[1]"));
            dataEntryButton.Click();
        }

        private void baslaButton_Click(object sender, EventArgs e)
        {
            switch (start)
            {
                case true:
                    timer1.Start();
                    start = false;
                    baslaButton.Text = "STOP";
                    break;
                case false:
                    timer1.Stop();
                    start = true;
                    baslaButton.Text = "START";
                    break;

            }

        }

        private void button41_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button40_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }


        private void guna2TrackBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = guna2TrackBar3.Value.ToString();
            switch (guna2TrackBar3.Value)
            {
                case 1:
                    roundLimiter = 6;
                    guna2TrackBar2.Maximum = 6;
                    guna2TrackBar2.Value = 6;
                    totalRoundCounter = 0;
                    roundCounter = 1;
                    label4.Text = label5.Text = "6";
                    label5.Visible = true;
                    break;
                case 2:
                    roundLimiter = 12;
                    guna2TrackBar2.Maximum = 12;
                    guna2TrackBar2.Value = 12;
                    totalRoundCounter = 0;
                    roundCounter = 1;
                    label4.Text = label5.Text = "12";
                    label5.Visible = true;
                    break;
                case 3:
                    roundLimiter = 15;
                    guna2TrackBar2.Maximum = 15;
                    guna2TrackBar2.Value = 15;
                    totalRoundCounter = 0;
                    roundCounter = 1;
                    label4.Text = label5.Text = "15";
                    label5.Visible = true;
                    break;
                case 0:
                    roundLimiter = 0;
                    guna2TrackBar2.Maximum = 1;
                    guna2TrackBar2.Value = 1;
                    label4.Text = "Unlimited";
                    label5.Visible = false;
                    break;

            }
            totalRoundCounter = 0;
        }

       
       
    }
}
