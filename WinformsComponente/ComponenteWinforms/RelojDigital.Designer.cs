using System.Drawing;

namespace ComponenteWinForms
{
    partial class RelojDigital
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.Size = new Size(200, 60);
        }
    }
}
