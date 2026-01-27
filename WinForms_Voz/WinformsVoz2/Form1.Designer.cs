namespace WinformsVoz2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.TextBox txtLog;

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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblLast = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 30);
            this.btnStart.Text = "Iniciar voz";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(120, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 30);
            this.btnStop.Text = "Parar voz";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(12, 55);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(150, 20);
            this.lblLast.Text = "Último comando:";
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(12, 85);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(200, 100);
            this.pnlColor.BackColor = System.Drawing.Color.LightGray;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 200);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(400, 200);
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(430, 420);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.txtLog);
            this.Name = "Form1";
            this.Text = "RA2 Voz WinForms";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

