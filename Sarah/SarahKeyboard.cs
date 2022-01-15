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
using System.Globalization;

namespace Sarah
{
    public partial class SarahKeyboard : Form
    {
        SpeechRecognitionEngine sarahkeyboardrecognition = new SpeechRecognitionEngine();
        SpeechRecognitionEngine sarahkeyboardexit = new SpeechRecognitionEngine();
        SpeechRecognitionEngine sarahalphabet = new SpeechRecognitionEngine();
        bool StopSKR = true;
        bool StopSKE = true;
        bool StopSKA = true;
        int checkalphabet = 0;
        int checkfunctionkey = 0;
        public SarahKeyboard()
        {
            InitializeComponent();

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle = 0x08000000;
                return param;
            }
        }

        private void btnTab_Click_1(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void btnEnternp_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void Alphabet(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send((btn.Text).ToUpper());
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send((btn.Text).ToLower());
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F1}");
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F3}");
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F5}");
        }

        private void btnF6_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F6}");
        }

        private void btnF7_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F7}");
        }

        private void btnF8_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F8}");
        }

        private void btnF9_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F9}");
        }

        private void btnF10_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F10}");
        }

        private void btnF11_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F11}");
        }

        private void btnF12_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F12}");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void btnEndPrnt_Click(object sender, EventArgs e)
        {

        }

        private void btnNumpad(object sender, EventArgs e)
        {

        }

        private void btnNumpad1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (chkNumLock.Checked == true)
            {
                SendKeys.Send((btn.Text));
            }
        }

        private void btnPMEqual_Click(object sender, EventArgs e)
        {
            if (chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{+}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send("{=}");
            }
        }

        private void btnUnderscore_Click(object sender, EventArgs e)
        {
            if (chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{_}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send("{-}");
            }
        }

        private void btnRightParenthesis_Click(object sender, EventArgs e)
        {
            if (chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{)}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send("{0}");
            }
        }

        private void btnLeftParenthesis_Click(object sender, EventArgs e)
        {
            if (chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{(}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send("{9}");
            }
        }

        private void btn8Asterisk_Click(object sender, EventArgs e)
        {
            if (chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{*}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send("{8}");
            }
        }

        private void btn7Ampersand_Click(object sender, EventArgs e)
        {
            if (chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{&}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send("{7}");
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{^}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send("{6}");
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{%}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send("{5}");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{$}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send("{4}");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{£}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send("{3}");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{″}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send("{2}");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{!}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send("{1}");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send("{¬}");
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send("{`}");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string btn = "{{}";
            string btns = "{[}";
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send(btn);
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send(btns);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string btn = "{}}";
            string btns = "{]}";
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send(btn);
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send(btns);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string btn = "~";
            string btns = "#";
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send(btn);
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send(btns);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string btn = "@";
            string btns = "'";
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send(btn);
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send(btns);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string btn = ":";
            string btns = ";";
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send(btn);
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send(btns);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string btn = "?";
            string btns = "/";
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send(btn);
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send(btns);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string btn = ">";
            string btns = ".";
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send(btn);
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send(btns);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string btn = "<";
            string btns = ",";
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send(btn);
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send(btns);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string btn = "|";
            string btns = "\\";
            if (chkCapsLock.Checked == true || chkShiftLeft.Checked == true || chkShiftRight.Checked == true)
            {
                SendKeys.Send(btn);
                chkShiftLeft.Checked = false;
                chkShiftRight.Checked = false;
            }
            else
            {
                SendKeys.Send(btns);
            }
        }

        private void btnCtrl_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^");
        }

        private void btndividenp_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (chkNumLock.Checked == true)
            {
                SendKeys.Send("{DIVIDE}");
            }
        }

        private void btnmultiplenp_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (chkNumLock.Checked == true)
            {
                SendKeys.Send("{MULTIPLY}");
            }
        }

        private void btnplusnp_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (chkNumLock.Checked == true)
            {
                SendKeys.Send("{ADD}");
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (chkNumLock.Checked == true)
            {
                SendKeys.Send("{SUBTRACT}");
            }
        }

        private void btnpgup_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGUP}");
        }

        private void btnpgdn_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGDN}");
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            SendKeys.Send("%");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^{ESC}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DEL}");
        }

        private void btnInsertPause_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{INSERT}");
        }

        private void SarahKeyboard_Load(object sender, EventArgs e)
        {
            sarahkeyboardexit.SetInputToDefaultAudioDevice();
            sarahkeyboardexit.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"sarahexitkeyboard.txt")))));
            sarahkeyboardexit.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sarahkeyboardexit_SpeechRecognized);
            sarahkeyboardexit.RecognizeAsync(RecognizeMode.Multiple);
            StopSKE = false;
            sarahkeyboardrecognition.SetInputToDefaultAudioDevice();
            sarahkeyboardrecognition.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"sarahkeyboardalphabet.txt")))));
            sarahkeyboardrecognition.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sarahkeyboardrecognition_SpeechRecognized);
            sarahkeyboardrecognition.RecognizeAsyncCancel();
            StopSKR = true;
            sarahalphabet.SetInputToDefaultAudioDevice();
            sarahalphabet.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"sarahalphabet.txt")))));
            sarahalphabet.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sarahalphabet_SpeechRecognized);
            sarahalphabet.RecognizeAsyncCancel();
            StopSKA = true;
        }

        private void sarahalphabet_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            try
            {
                string speech = e.Result.Text;
                tbsarahinput.Text = speech;
                if (speech == "a")
                {
                    btnA.PerformClick();
                }
                else if (speech == "b")
                {
                    btnB.PerformClick();
                }
                else if (speech == "c")
                {
                    btnC.PerformClick();
                }
                else if (speech == "d")
                {
                    btnD.PerformClick();
                }
                else if (speech == "e")
                {
                    btnE.PerformClick();
                }
                else if (speech == "f")
                {
                    btnF.PerformClick();
                }
                else if (speech == "g")
                {
                    btnG.PerformClick();
                }
                else if (speech == "h")
                {
                    btnH.PerformClick();
                }
                else if (speech == "i")
                {
                    btnI.PerformClick();
                }
                else if (speech == "j")
                {
                    btnJ.PerformClick();
                }
                else if (speech == "k")
                {
                    btnK.PerformClick();
                }
                else if (speech == "l")
                {
                    btnL.PerformClick();
                }
                else if (speech == "m")
                {
                    btnM.PerformClick();
                }
                else if (speech == "n")
                {
                    btnN.PerformClick();
                }
                else if (speech == "o")
                {
                    btnO.PerformClick();
                }
                else if (speech == "p")
                {
                    btnP.PerformClick();
                }
                else if (speech == "q")
                {
                    btnQ.PerformClick();
                }
                else if (speech == "r")
                {
                    btnR.PerformClick();
                }
                else if (speech == "s")
                {
                    btnS.PerformClick();
                }
                else if (speech == "t")
                {
                    btnT.PerformClick();
                }
                else if (speech == "u")
                {
                    btnU.PerformClick();
                }
                else if (speech == "v")
                {
                    btnV.PerformClick();
                }
                else if (speech == "w")
                {
                    btnW.PerformClick();
                }
                else if (speech == "x")
                {
                    btnX.PerformClick();
                }
                else if (speech == "y")
                {
                    btnY.PerformClick();
                }
                else if (speech == "z")
                {
                    btnZ.PerformClick();
                }
                else if (speech == "1")
                {
                    btn1np.PerformClick();
                }
                else if (speech == "2")
                {
                    btn2np.PerformClick();
                }
                else if (speech == "3")
                {
                    btn3np.PerformClick();
                }
                else if (speech == "4")
                {
                    btn4np.PerformClick();
                }
                else if (speech == "5")
                {
                    btn5np.PerformClick();
                }
                else if (speech == "6")
                {
                    btn6np.PerformClick();
                }
                else if (speech == "7")
                {
                    btn7np.PerformClick();
                }
                else if (speech == "8")
                {
                    btn8np.PerformClick();
                }
                else if (speech == "9")
                {
                    btn9np.PerformClick();
                }
                else if (speech == "0")
                {
                    btn0np.PerformClick();
                }
                else if(speech== "SPACE")
                {
                    btnSpace.PerformClick();
                }
                else if(speech== "Stop alphabet")
                {
                    StopSKA = true;
                    if(StopSKE==true)
                    {
                        StopSKE = false;
                        sarahkeyboardexit.RecognizeAsync(RecognizeMode.Multiple);
                    }
                    sarahalphabet.RecognizeAsyncCancel();
                }
            }
            catch(Exception alphabeterror)
            {
                MessageBox.Show($"{alphabeterror.Message}");
            }
            

        }

        private void sarahkeyboardexit_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            try
            {
                string speech = e.Result.Text;
                tbsarahinput.Text = speech;
                if (speech == "Start function Key" && StopSKR == true)
                {
                    if(checkfunctionkey==0)
                    {
                        checkfunctionkey = 1;
                    }
                    else if(checkfunctionkey==1)
                    {
                        checkfunctionkey = 2;
                    }
                    if(checkfunctionkey==2)
                    {
                        StopSKR = false;
                        sarahkeyboardrecognition.RecognizeAsync(RecognizeMode.Multiple);
                        if (StopSKE == false)
                        {
                            StopSKE = true;
                            sarahkeyboardexit.RecognizeAsyncCancel();
                        }
                        checkfunctionkey = 0;
                    }                  
                }
                else if (speech == "Start Alphabet" && StopSKA == true)
                {
                    if (checkalphabet == 0)
                    {
                        checkalphabet = 1;
                    }
                    else if (checkalphabet == 1)
                    {
                        checkalphabet = 2;
                    }
                    if(checkalphabet==2)
                    {
                        StopSKA = false;
                        sarahalphabet.RecognizeAsync(RecognizeMode.Multiple);
                        if (StopSKE == false)
                        {
                            StopSKE = true;
                            sarahkeyboardexit.RecognizeAsyncCancel();
                        }
                        checkalphabet = 0;
                    }                    
                }
            }
            catch(Exception sarahkeyboardexiterr)

            {
                MessageBox.Show($"{sarahkeyboardexiterr.Message}");
            }
            
        }

        private void sarahkeyboardrecognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            try 
            {
                string speech = e.Result.Text;
                tbsarahinput.Text = speech;
                if (speech == "SHIFT")
                {
                    if (chkShiftLeft.Checked == false)
                    {
                        chkShiftLeft.Checked = true;
                    }
                    else if (chkShiftLeft.Checked == true)
                    {
                        chkShiftLeft.Checked = false;
                    }
                }
                else if (speech == "NUMPAD")
                {
                    if (chkNumLock.Checked == true)
                    {
                        chkNumLock.Checked = false;
                    }
                    else if (chkNumLock.Checked == false)
                    {
                        chkNumLock.Checked = true;
                    }
                }
                else if (speech == "CAPSLOCK")
                {
                    if (chkCapsLock.Checked == false)
                    {
                        chkCapsLock.Checked = true;
                    }
                    else if (chkCapsLock.Checked == true)
                    {
                        chkCapsLock.Checked = false;
                    }
                }
                else if(speech== "BACKPARAGRAPH")
                {
                    SendKeys.Send("^{UP}");
                }
                else if (speech == "BACKSPACE")
                {
                    btnBackspace.PerformClick();
                }
                else if(speech== "BACKWORD")
                {
                    SendKeys.Send("^{LEFT}");
                }
                else if (speech == "SPACE")
                {
                    btnSpace.PerformClick();
                }
                else if (speech == "DEL")
                {
                    btnDelete.PerformClick();
                }
                else if (speech == "DOWN")
                {
                    button12.PerformClick();
                }
                else if (speech == "ESCAPE")
                {
                    btnEsc.PerformClick();
                }
                else if (speech == "INSERT")
                {
                    btnInsertPause.PerformClick();
                }
                else if (speech == "LEFT")
                {
                    button9.PerformClick();
                }
                else if ((speech == "NEXT LINE") || (speech == "PUSH"))
                {
                    btnEnter.PerformClick();
                }
                else if(speech== "NEXTPARAGRAPH")
                {
                    SendKeys.Send("^{DOWN}");
                }
                else if(speech=="NEXTWORD")
                {
                    SendKeys.Send("^{RIGHT}");
                }
                else if (speech == "PAGE DOWN")
                {
                    btnpgdn.PerformClick();
                }
                else if (speech == "PAGE UP")
                {
                    btnpgup.PerformClick();
                }
                else if (speech == "RIGHT")
                {
                    button11.PerformClick();
                }
                else if (speech == "TAB")
                {
                    btnTab.PerformClick();
                }
                else if (speech == "UP")
                {
                    button4.PerformClick();
                }
                else if (speech == "WIN")
                {
                    button15.PerformClick();
                }
                else if (speech == "ADD")
                {
                    btnplusnp.PerformClick();
                }
                else if (speech == "DIVIDE")
                {
                    btndividenp.PerformClick();
                }
                else if (speech == "MINUS")
                {
                    btnminus.PerformClick();
                }
                else if (speech == "MULTIPLE")
                {
                    btnmultiplenp.PerformClick();
                }
                else if (speech == "ALT F 4")
                {
                    SendKeys.Send("%{F4}");
                }
                else if (speech == "ALT TAB")
                {
                    SendKeys.Send("%{TAB}");
                }
                else if (speech == "CONTROL A")
                {
                    SendKeys.Send("^{A}");
                }
                else if (speech == "CONTROL C")
                {
                    SendKeys.Send("^{C}");
                }
                else if (speech == "CONTROL V")
                {
                    SendKeys.Send("^{V}");
                }
                else if (speech == "CONTROL X")
                {
                    SendKeys.Send("^{X}");
                }
                else if (speech == "CONTROL Z")
                {
                    SendKeys.Send("^{Z}");
                }
                else if (speech == "F 1")
                {
                    btnF1.PerformClick();
                }
                else if (speech == "F 2")
                {
                    btnF2.PerformClick();
                }
                else if (speech == "F 3")
                {
                    btnF3.PerformClick();
                }
                else if (speech == "F 4")
                {
                    btnF4.PerformClick();
                }
                else if (speech == "F 5")
                {
                    btnF5.PerformClick();
                }
                else if (speech == "F 6")
                {
                    btnF6.PerformClick();
                }
                else if (speech == "F 7")
                {
                    btnF7.PerformClick();
                }
                else if (speech == "F 8")
                {
                    btnF8.PerformClick();
                }
                else if (speech == "F 9")
                {
                    btnF9.PerformClick();
                }
                else if (speech == "F 10")
                {
                    btnF10.PerformClick();
                }
                else if (speech == "F 11")
                {
                    btnF11.PerformClick();
                }
                else if (speech == "F 12")
                {
                    btnF12.PerformClick();
                }
                else if (speech== "Stop function Key")
                {
                    StopSKR = true;
                    if(StopSKE==true)
                    {
                        sarahkeyboardexit.RecognizeAsync(RecognizeMode.Multiple);
                    }
                    sarahkeyboardrecognition.RecognizeAsyncCancel();
                }
            }
            catch(Exception Keyerr)
            {
                MessageBox.Show($"{Keyerr.Message}");
            }
            
        }

        private void btnFn_Click(object sender, EventArgs e)
        {

        }
    }
}