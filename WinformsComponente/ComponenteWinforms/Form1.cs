using System;
using System.Drawing;
using System.Windows.Forms;
using ComponenteWinForms; // Namespace unificado con tu control

namespace TestRelojDigital
{
    public partial class Form1 : Form
    {
        private RelojDigital reloj;

        public Form1()
        {
            InitializeComponent();

            // Crear instancia del RelojDigital
            reloj = new RelojDigital();

            // Configurar posición y tamaño
            reloj.Location = new Point(50, 50);
            reloj.Size = new Size(200, 100);

            // Configurar propiedades
            reloj.MostrarSegundos = true;
            reloj.Formato24Horas = true;
            reloj.ColorTexto = Color.Blue;
            reloj.HoraAlarma = new TimeSpan(14, 30, 0); // Ejemplo: alarma a las 14:30:00

            // Suscribirse al evento de alarma
            reloj.AlarmaActivada += Reloj_AlarmaActivada;

            // Añadir al formulario
            this.Controls.Add(reloj);

            // Iniciar el reloj
            reloj.Iniciar();
        }

        // Evento que se dispara cuando salta la alarma
        private void Reloj_AlarmaActivada(object sender, EventArgs e)
        {
            MessageBox.Show("¡La alarma ha sonado!", "Alarma", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
