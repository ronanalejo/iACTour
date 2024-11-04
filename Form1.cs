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


namespace AI_VOICE_RECOGNITION_BENNETT_TANYAG
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEng = new SpeechRecognitionEngine();
        SpeechSynthesizer synth = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
                Choices commands = new Choices();
                commands.Add(new string[] {"What is iACADEMY", "What floor is (PlaceA)", "Could you give me the payment options to pay my tuition in iACADEMY", "What are the available organizations in iACADEMY", "What are the available courses in iACADEMY", "Bye bot"});
                GrammarBuilder gBuilder = new GrammarBuilder();
                gBuilder.Append(commands);
                Grammar grammar = new Grammar(gBuilder);

                recEng.LoadGrammarAsync(grammar);
                recEng.SetInputToDefaultAudioDevice();
                recEng.SpeechRecognized += RecEng_SpeechRecognized;
                recEng.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            txtSpeech.Text = "iAC tour is now in operation";
            synth.Speak("Ayak tour is now in operation");
            
        }

        private void RecEng_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string s;
            if (btnEnable.Enabled == false)
            {
                switch (e.Result.Text)
                {
                    case "What is iACADEMY":
                        txtSpeech.Clear();
                        txtSpeech.Text = txtSpeech.Text + "Information and Communications Technology Academy, better known as iAcademy, is a private, non-sectarian educational institution in the Philippines.\r\nThe school boasts a hands-on approach and industry-aligned curriculum Computer Science, Multimedia Arts and Design, and Business programs. For more information, please head over to iacademy.edu.ph \r\n";
                        s = txtSpeech.Text;
                        synth.Speak(s);
                        break;
                    case "What floor is (PlaceA)":
                        txtSpeech.Clear();
                        s = "it's somewhere. \r\n";
                        txtSpeech.Text = s;
                        synth.Speak(s);
                        break;
                    case "Could you give me the payment options to pay my tuition in iACADEMY":
                        txtSpeech.Clear();
                        s = "There are several options to pay your tuition. \r\nOptions include: \r\nCash Payment for Onsite Enrollment \r\nCredit card payment for Onsite payment \r\nCheck Payment for both Onsite and Online payment \r\nBank Transfer for online enrollment.\r\n";
                        txtSpeech.Text = s;
                        synth.Speak(s);
                        break;
                    case "What are the available organizations in iACADEMY":
                        txtSpeech.Clear();
                        s = "Here are the list of organizations in iACADEMY \r\nThe following fall under the UG Department \r\nCSO \r\nISO \r\niACT \r\niACMedia \r\nVox Volare \r\niSekai \r\nPikzel \r\nMomentum \r\nOptics \r\nOctave \r\nRhythm \r\nTMT \r\nElix \r\nCompile \r\nInsight \r\nWonder \r\nPrima \r\nGCP \r\nThe following now fall under the SHS Department \r\nYFS \r\nSilakbo \r\niJSD \r\niMGG \r\nSHS Student Council \r\nSHS ISO \r\nSHS Prima \r\nSHSOctave \r\nSinlikhay";
                        txtSpeech.Text = s;
                        synth.Speak("Here are the list of organizations in eye academy. The following fall under the UG Department: CSO, ISO, iACT, iACMedia, Vox Volare, eeSekai, Pikzel, Momentum, Optics, Octave, Rhythm, TMT, Elix Compile, Insight, Wonder, Prima, GCP The following now fall under the SHS Department, YFS, Seelakbo, i JSD, i MGG, SHS Student Council, SHS ISO, SHS Preema, SHSOctave, Sinlikhay");
                        break;
                    case "What are the available courses in iACADEMY":
                        txtSpeech.Clear();
                        s = "There are four departments, namely: Senior Highschool, School of Computing, School of Arts and Design, and School of Business and Liberal Arts. \r\nFor Senior Highschool, the courses are as follows: \r\nAccountancy, Business, and Management \r\nArts and Design \r\nAudio Production \r\nAnimation \r\nFashion Design \r\nGraphic Illustration \r\nSoftware Development \r\nRobotics \r\nAnd Humanities and Social Sciences. \r\nFor School of Computing, the courses are as follows: \r\nGame Development \r\nSoftware Engineering \r\nCloud Computing \r\nData Science \r\nWeb Development \r\nFor School of Arts and Design, the courses are as follows: \r\nFashion Design and Technology \r\nMultimedia Arts and Design \r\nAnimation \r\nMusic Production and Sound Design \r\nFilm and Visual Effects \r\nFor School of Business and Liberal Arts, the courses are as follows: \r\nMarketing Management \r\nE-Management \r\nReal Estate Management \r\nPsychology \r\nAccountancy.";
                        txtSpeech.Text = s;
                        synth.Speak(s);
                        break;
                    case "Bye bot":
                        s = "See ya next time. \r\n";
                        txtSpeech.Text = s;
                        synth.Speak(s);
                        System.Environment.Exit(0);
                        break;
                }
            }
            // throw new NotImplementedException();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = "MIC IS ENABLED";
            btnEnable.Enabled = false;
            btnEnable.BackColor = Color.Green;
            btnDisable.Enabled = true;
            btnDisable.BackColor = Color.Gray;
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = "MIC IS DISABLED";
            btnEnable.Enabled = true;
            btnEnable.BackColor = Color.Gray;
            btnDisable.Enabled = false;
            btnDisable.BackColor = Color.Red;
        }
    }
}
