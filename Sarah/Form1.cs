using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;

namespace Sarah
{
    public partial class Form1 : Form
    {
        string username = SystemInformation.UserName.ToString();
        SpeechRecognitionEngine sarahpresentation = new SpeechRecognitionEngine();
        SpeechSynthesizer sarahspeak = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
            tbsarahpresentation.Visible = false;
            tbsarahkeyboard.Visible = false;
            tbsarahprocess.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  sarahdashboardicon.Visible = false;
                sarahspeak.SpeakAsync($"Hello {username} I'm sarah");
                tbsarahpresentation.Visible = true;
                tbsarahpresentation.Text = $"Hello {username} I'm sarah use on this command";
                tbsarahprocess.Text = "Sarah Process";
                tbsarahkeyboard.Text = "Sarah Keyboard";
                tbsarahkeyboard.Visible = true;
                tbsarahprocess.Visible = true;
                sarahpresentation.SetInputToDefaultAudioDevice();
                sarahpresentation.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"sarahpresentation.txt")))));
                sarahpresentation.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sarahpresentation_SpeechRecognized);
                sarahpresentation.RecognizeAsync(RecognizeMode.Multiple);
                
        }

        private void sarahpresentation_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
                       
            string speech = e.Result.Text;
            if(speech== "Sarah Keyboard")
            {
                this.Hide();
               /* sarahdashboardicon.Visible = true;
                sarahdashboardicon.Text = "Sarah Dashboard\nSarah Keyboard is running";*/
                SarahKeyboard sarahkeyboard = new SarahKeyboard();
                sarahkeyboard.Show();
                /* sarahkeyboard = null;
                 this.Show();*/
                sarahpresentation.RecognizeAsyncCancel();
            }
            else if(speech== "Sarah Process")
            {
                this.Hide();
                /*sarahdashboardicon.Visible = true;
                sarahdashboardicon.Text = "Sarah Dashboard\nSarah Process is running";*/
                Sarahprocess sarahprocess = new Sarahprocess();
                sarahprocess.Show();
                /* sarahprocess = null;
                 this.Show();*/
                sarahpresentation.RecognizeAsyncCancel();
            }
        }
    }
}
