namespace RA2_Voz_WinForms
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Iniciar voz";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(118, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 30);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Parar voz";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 55);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(14, 15);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "—";
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.LightGray;
            this.panelColor.Location = new System.Drawing.Point(12, 80);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(206, 80);
            this.panelColor.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 170);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(360, 150);
            this.txtLog.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 331);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "RA2 Voz WinForms";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.TextBox txtLog;
    }
}
