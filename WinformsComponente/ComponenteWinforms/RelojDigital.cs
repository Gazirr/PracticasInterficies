using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComponenteWinForms
{
    public partial class RelojDigital : UserControl
    {
        private Timer timer;
        private DateTime horaActual;

        public event EventHandler AlarmaActivada;

        // Propiedades públicas
        public bool MostrarSegundos { get; set; } = true;
        public bool Formato24Horas { get; set; } = true;
        public Color ColorTexto { get; set; } = Color.Black;
        public TimeSpan? HoraAlarma { get; set; } = null;

        public RelojDigital()
        {
            InitializeComponent();
            horaActual = DateTime.Now;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        // Métodos públicos
        public void Iniciar()
        {
            timer.Start();
        }

        public void Detener()
        {
            timer.Stop();
        }

        // Timer Tick
        private void Timer_Tick(object sender, EventArgs e)
        {
            horaActual = horaActual.AddSeconds(1);
            VerificarAlarma();
            Invalidate(); // Fuerza repintado
        }

        // Verificar si es hora de alarma
        private void VerificarAlarma()
        {
            if (HoraAlarma.HasValue &&
                horaActual.TimeOfDay.Hours == HoraAlarma.Value.Hours &&
                horaActual.TimeOfDay.Minutes == HoraAlarma.Value.Minutes &&
                (!MostrarSegundos || horaActual.TimeOfDay.Seconds == HoraAlarma.Value.Seconds))
            {
                AlarmaActivada?.Invoke(this, EventArgs.Empty);
            }
        }

        // Dibujar el reloj
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            string formato = Formato24Horas
                ? (MostrarSegundos ? "HH:mm:ss" : "HH:mm")
                : (MostrarSegundos ? "hh:mm:ss tt" : "hh:mm tt");

            string textoHora = horaActual.ToString(formato);

            using (Brush b = new SolidBrush(ColorTexto))
            {
                e.Graphics.Clear(this.BackColor);
                e.Graphics.DrawString(
                    textoHora,
                    this.Font,
                    b,
                    new PointF(0, 0));
            }
        }
    }
}
