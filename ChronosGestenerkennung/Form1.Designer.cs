namespace ChronosGestenerkennung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelRaw = new System.Windows.Forms.Label();
            this.labelGesture = new System.Windows.Forms.Label();
            this.buttonConfigPush = new System.Windows.Forms.Button();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.buttonConfigUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(95, 34);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(210, 23);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 13);
            this.labelStatus.TabIndex = 1;
            // 
            // labelStatusText
            // 
            this.labelStatusText.AutoSize = true;
            this.labelStatusText.Location = new System.Drawing.Point(113, 23);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(91, 13);
            this.labelStatusText.TabIndex = 2;
            this.labelStatusText.Text = "Connectin Status:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(9, 63);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(20, 13);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "X: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(9, 109);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(17, 13);
            this.labelZ.TabIndex = 5;
            this.labelZ.Text = "Z:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(9, 86);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(20, 13);
            this.labelY.TabIndex = 6;
            this.labelY.Text = "Y: ";
            // 
            // labelRaw
            // 
            this.labelRaw.AutoSize = true;
            this.labelRaw.Location = new System.Drawing.Point(113, 54);
            this.labelRaw.Name = "labelRaw";
            this.labelRaw.Size = new System.Drawing.Size(62, 13);
            this.labelRaw.TabIndex = 7;
            this.labelRaw.Text = "Raw Value:";
            // 
            // labelGesture
            // 
            this.labelGesture.AutoSize = true;
            this.labelGesture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGesture.Location = new System.Drawing.Point(113, 86);
            this.labelGesture.Name = "labelGesture";
            this.labelGesture.Size = new System.Drawing.Size(86, 24);
            this.labelGesture.TabIndex = 8;
            this.labelGesture.Text = "Gesture: ";
            // 
            // buttonConfigPush
            // 
            this.buttonConfigPush.Location = new System.Drawing.Point(12, 167);
            this.buttonConfigPush.Name = "buttonConfigPush";
            this.buttonConfigPush.Size = new System.Drawing.Size(75, 23);
            this.buttonConfigPush.TabIndex = 9;
            this.buttonConfigPush.Text = "Config Push";
            this.buttonConfigPush.UseVisualStyleBackColor = true;
    
            // 
            // buttonTimer
            // 
            this.buttonTimer.Location = new System.Drawing.Point(228, 167);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(117, 23);
            this.buttonTimer.TabIndex = 10;
            this.buttonTimer.Text = "Start/Stopp Timer";
            this.buttonTimer.UseVisualStyleBackColor = true;
            this.buttonTimer.Click += new System.EventHandler(this.buttonTimer_Click);
            // 
            // buttonConfigUp
            // 
            this.buttonConfigUp.Location = new System.Drawing.Point(93, 167);
            this.buttonConfigUp.Name = "buttonConfigUp";
            this.buttonConfigUp.Size = new System.Drawing.Size(75, 23);
            this.buttonConfigUp.TabIndex = 11;
            this.buttonConfigUp.Text = "Config Up";
            this.buttonConfigUp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 202);
            this.Controls.Add(this.buttonConfigUp);
            this.Controls.Add(this.buttonTimer);
            this.Controls.Add(this.buttonConfigPush);
            this.Controls.Add(this.labelGesture);
            this.Controls.Add(this.labelRaw);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelStatusText);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelRaw;
        private System.Windows.Forms.Label labelGesture;
        private System.Windows.Forms.Button buttonConfigPush;
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Button buttonConfigUp;
    }
}

