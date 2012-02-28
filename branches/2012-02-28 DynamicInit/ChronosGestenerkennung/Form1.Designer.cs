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
            this.buttonTimer = new System.Windows.Forms.Button();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSaveUp = new System.Windows.Forms.Button();
            this.buttonSavePush = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonLoadUp = new System.Windows.Forms.Button();
            this.buttonLoadPush = new System.Windows.Forms.Button();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.groupBoxConfig.SuspendLayout();
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
            // buttonTimer
            // 
            this.buttonTimer.Location = new System.Drawing.Point(181, 115);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(117, 23);
            this.buttonTimer.TabIndex = 10;
            this.buttonTimer.Text = "Start/Stopp Timer";
            this.buttonTimer.UseVisualStyleBackColor = true;
            this.buttonTimer.Click += new System.EventHandler(this.buttonTimer_Click);
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.label3);
            this.groupBoxConfig.Controls.Add(this.buttonTimer);
            this.groupBoxConfig.Controls.Add(this.label2);
            this.groupBoxConfig.Controls.Add(this.label1);
            this.groupBoxConfig.Controls.Add(this.buttonSave);
            this.groupBoxConfig.Controls.Add(this.buttonSaveUp);
            this.groupBoxConfig.Controls.Add(this.buttonSavePush);
            this.groupBoxConfig.Controls.Add(this.buttonLoad);
            this.groupBoxConfig.Controls.Add(this.buttonLoadUp);
            this.groupBoxConfig.Controls.Add(this.buttonLoadPush);
            this.groupBoxConfig.Controls.Add(this.textBoxY);
            this.groupBoxConfig.Controls.Add(this.textBoxX);
            this.groupBoxConfig.Controls.Add(this.textBoxZ);
            this.groupBoxConfig.Location = new System.Drawing.Point(12, 165);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(333, 144);
            this.groupBoxConfig.TabIndex = 20;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Config";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "X: ";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(87, 77);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 28;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonSaveUp
            // 
            this.buttonSaveUp.Location = new System.Drawing.Point(87, 48);
            this.buttonSaveUp.Name = "buttonSaveUp";
            this.buttonSaveUp.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveUp.TabIndex = 27;
            this.buttonSaveUp.Text = "SaveUp";
            this.buttonSaveUp.UseVisualStyleBackColor = true;
            // 
            // buttonSavePush
            // 
            this.buttonSavePush.Location = new System.Drawing.Point(87, 19);
            this.buttonSavePush.Name = "buttonSavePush";
            this.buttonSavePush.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePush.TabIndex = 26;
            this.buttonSavePush.Text = "SavePush";
            this.buttonSavePush.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(6, 77);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 25;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonLoadUp
            // 
            this.buttonLoadUp.Location = new System.Drawing.Point(6, 48);
            this.buttonLoadUp.Name = "buttonLoadUp";
            this.buttonLoadUp.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadUp.TabIndex = 24;
            this.buttonLoadUp.Text = "LoadUp";
            this.buttonLoadUp.UseVisualStyleBackColor = true;
            // 
            // buttonLoadPush
            // 
            this.buttonLoadPush.Location = new System.Drawing.Point(6, 19);
            this.buttonLoadPush.Name = "buttonLoadPush";
            this.buttonLoadPush.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadPush.TabIndex = 23;
            this.buttonLoadPush.Text = "LoadPush";
            this.buttonLoadPush.UseVisualStyleBackColor = true;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(201, 45);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(108, 20);
            this.textBoxY.TabIndex = 22;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(201, 19);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(108, 20);
            this.textBoxX.TabIndex = 21;
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(201, 71);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(108, 20);
            this.textBoxZ.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 321);
            this.Controls.Add(this.groupBoxConfig);
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
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
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
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSaveUp;
        private System.Windows.Forms.Button buttonSavePush;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonLoadUp;
        private System.Windows.Forms.Button buttonLoadPush;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

