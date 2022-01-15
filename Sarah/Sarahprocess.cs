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
using System.Diagnostics;

namespace Sarah
{
    public partial class Sarahprocess : Form
    {
        SpeechSynthesizer sarahspeak = new SpeechSynthesizer();
        SpeechRecognitionEngine sarahprocess = new SpeechRecognitionEngine();
        SpeechRecognitionEngine sarahexitprocess = new SpeechRecognitionEngine();
        bool StopSP = true;
        bool StopS = true;
        List<Process> currentprocess = new List<Process>();
        List<string> defaultsarahcommands = File.ReadAllLines(@"sarahexitsprocess.txt").ToList();
        List<string> usualprocess = File.ReadAllLines(@"sarahusualprocessname.txt").ToList();
        List<string> processcommand = File.ReadAllLines(@"sarahprocesscommand.txt").ToList();
        List<string> computeusualprocess = File.ReadAllLines(@"usualprocess.txt").ToList();
        string username = "";
        public Sarahprocess()
        {
            InitializeComponent();
            List<string> sarahcommand = File.ReadAllLines(@"sarahusercommand.txt").ToList();
            defaultsarahcommands.AddRange(sarahcommand);
            username = SystemInformation.UserName.ToString();
        }

        private void Sarahprocess_Load(object sender, EventArgs e)
        {
            LoadCurrentProcess();
            showusualprocess();
            showsarahprocesscommand();
            sarahexitprocess.SetInputToDefaultAudioDevice();
            sarahexitprocess.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"sarahexitprocess.txt")))));
            sarahexitprocess.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sarahexitprocess_SpeechRecognized);
            if (StopSP == true)
            {
                sarahexitprocess.RecognizeAsync(RecognizeMode.Multiple);
                StopSP = false;
            }
        }
        private void LoadCurrentProcess()
        {
            currentprocess = Process.GetProcesses().ToList();
            lstcurrentprocessname.Visible = true;
            sarahspeak.SpeakAsync($"Hello {username} Current Process loaded");
            foreach(var process in currentprocess)
            {
                string processname = process.ProcessName;
                lstcurrentprocessname.Items.Add(processname);
            }
        }
        private void showusualprocess()
        {
            foreach(var process in usualprocess)
            {
                lstusualprocessname.Items.Add(process);
            }
        }
        private void showsarahprocesscommand()
        {
            foreach(var command in defaultsarahcommands)
            {
                lstsarahprocesscommand.Items.Add(command);
            }
        }
        private void sarahexitprocess_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            try 
            {              
                string speech = e.Result.Text;
                tbsarahinput.Text = speech;
                if (speech == "Wake up" && StopS==true)
                {
                    sarahprocess.SetInputToDefaultAudioDevice();
                    sarahprocess.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"sarahusercommand.txt")))));
                    sarahprocess.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sarahprocess_SpeechRecognized);
                    sarahprocess.RecognizeAsync(RecognizeMode.Multiple);
                    StopS = false;
                    sarahspeak.SpeakAsync($"Hi {username} i run very well");
                }
                else if (speech == "Hide Current Process")
                {
                    lstcurrentprocessname.Visible = false;
                }
                else if (speech == "Hide Process command")
                {
                    lstsarahprocesscommand.Visible = false;
                }
                else if (speech == "Hide Usual Process")
                {
                    lstusualprocessname.Visible = false;
                }
                else if (speech == "Show Current Process")
                {
                    lstcurrentprocessname.Visible = true;
                }
                else if (speech == "Show Process command")
                {
                    lstsarahprocesscommand.Visible = true;
                }
                else if (speech == "Show Usual Process")
                {
                    lstusualprocessname.Visible = true;
                }
                else if (speech == "Load Current Process")
                {
                    LoadCurrentProcess();
                }
                else if (speech == "Minimize")
                {
                    Minimize(this);
                }
                else if (speech == "Show Sarah Process")
                {
                    Minimize(this);
                }
                /*else if (speech == "Sarah Dashboard")
                {
                    this.Close();
                }*/
            }
            catch(Exception SPerr)
            {
                MessageBox.Show($"{SPerr.Message}");
            }
        }

        private void Minimize(Form form)
        {
            if(form.WindowState==FormWindowState.Normal)
            {
                form.WindowState = FormWindowState.Minimized;
            }
            else if(form.WindowState==FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Normal;
            }
        }

        private void sarahprocess_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            try
            {
                string speech = e.Result.Text;
                foreach (var prusualname in usualprocess)
                {
                    var speechcheck = speech.IndexOf(prusualname);
                    if (speechcheck != -1)
                    {
                        tbsarahinput.Text = speech;
                        foreach (var prcommand in processcommand)
                        {
                            var prcommancheck = prcommand.IndexOf(prusualname);
                            if (prcommancheck != -1)
                            {
                                foreach (var cpusualprocess in computeusualprocess)
                                {
                                    var computeusualprocesscheck = prcommand.IndexOf(cpusualprocess);
                                    if (computeusualprocesscheck != -1)
                                    {
                                        var startcheck = speech.IndexOf("Start");
                                        var stopcheck = speech.IndexOf("Stop");
                                        if (startcheck != -1)
                                        {
                                            Process pr = new Process();
                                            pr.StartInfo.FileName = cpusualprocess;
                                            pr.Start();
                                            StopS = true;
                                            sarahprocess.RecognizeAsyncCancel();
                                        }
                                        else if (stopcheck != -1)
                                        {
                                            List<Process> lstpr = Process.GetProcesses().ToList();
                                            foreach (var lpr in lstpr)
                                            {
                                                string prname = lpr.ProcessName;
                                                if (prname == cpusualprocess)
                                                {
                                                    lpr.Kill();
                                                    StopS = true;
                                                    sarahprocess.RecognizeAsyncCancel();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception Serr)
            {
                MessageBox.Show($"{Serr.Message}");
            }
        }
    }
}
