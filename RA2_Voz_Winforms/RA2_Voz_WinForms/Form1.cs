using System;
using System.Diagnostics;
using System.Globalization;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace RA2_Voz_WinForms
{
    public partial class Form1 : Form
    {
        private SpeechRecognitionEngine _rec;
        private CultureInfo _culture;

        public Form1()
        {
            InitializeComponent();

            Shown += Form1_Shown;
            FormClosing += Form1_FormClosing;

            btnStart.Click += (_, __) => StartRecognition();
            btnStop.Click += (_, __) => StopRecognition();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _culture = new CultureInfo("es-ES");
            _rec = new SpeechRecognitionEngine(_culture);

            Choices commands = new Choices(
                "hola",
                "limpiar",
                "salir",
                "color rojo",
                "color verde",
                "color azul",
                "abrir bloc de notas",
                "abrir navegador"
            );

            GrammarBuilder gb = new GrammarBuilder(commands);
            gb.Culture = _culture;

            Grammar grammar = new Grammar(gb);

            _rec.LoadGrammar(grammar);
            _rec.SetInputToDefaultAudioDevice();
            _rec.SpeechRecognized += Rec_SpeechRecognized;
        }

        private void StartRecognition()
        {
            _rec.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void StopRecognition()
        {
            _rec.RecognizeAsyncStop();
        }

        private void Rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence < 0.65)
                return;

            string text = e.Result.Text;
            lblResult.Text = text;

            Log($"{text} (Confidence: {e.Result.Confidence:0.00})");

            switch (text)
            {
                case "hola":
                    MessageBox.Show("Hola");
                    break;

                case "limpiar":
                    txtLog.Clear();
                    break;

                case "salir":
                    Close();
                    break;

                case "color rojo":
                    panelColor.BackColor = System.Drawing.Color.Red;
                    break;

                case "color verde":
                    panelColor.BackColor = System.Drawing.Color.Green;
                    break;

                case "color azul":
                    panelColor.BackColor = System.Drawing.Color.Blue;
                    break;

                case "abrir bloc de notas":
                    Process.Start("notepad.exe");
                    break;

                case "abrir navegador":
                    Process.Start("https://www.wikipedia.org");
                    break;
            }
        }

        private void Log(string msg, bool isError = false)
        {
            txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {msg}\n");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _rec?.Dispose();
        }
    }
}
