namespace AllInOne
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ShowMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_AutoRun = new System.Windows.Forms.Button();
            this.showPicture = new System.Windows.Forms.PictureBox();
            this.button_Debug = new System.Windows.Forms.Button();
            this.UpdateUITimer = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowMessage
            // 
            this.ShowMessage.BackColor = System.Drawing.Color.DarkOrchid;
            this.ShowMessage.Font = new System.Drawing.Font("SimSun", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShowMessage.ForeColor = System.Drawing.Color.Navy;
            this.ShowMessage.Location = new System.Drawing.Point(0, 748);
            this.ShowMessage.Name = "ShowMessage";
            this.ShowMessage.Size = new System.Drawing.Size(1456, 76);
            this.ShowMessage.TabIndex = 27;
            this.ShowMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("SimSun", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1456, 76);
            this.label1.TabIndex = 28;
            this.label1.Text = "All In One Test System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_AutoRun
            // 
            this.button_AutoRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_AutoRun.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_AutoRun.Location = new System.Drawing.Point(8, 633);
            this.button_AutoRun.Name = "button_AutoRun";
            this.button_AutoRun.Size = new System.Drawing.Size(242, 99);
            this.button_AutoRun.TabIndex = 29;
            this.button_AutoRun.Text = "Auto Run";
            this.button_AutoRun.UseVisualStyleBackColor = false;
            this.button_AutoRun.Click += new System.EventHandler(this.button_AutoRun_Click);
            // 
            // showPicture
            // 
            this.showPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.showPicture.Image = global::AllInOne.Properties.Resources.Initial;
            this.showPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("showPicture.InitialImage")));
            this.showPicture.Location = new System.Drawing.Point(0, 76);
            this.showPicture.Name = "showPicture";
            this.showPicture.Size = new System.Drawing.Size(1456, 550);
            this.showPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPicture.TabIndex = 30;
            this.showPicture.TabStop = false;
            // 
            // button_Debug
            // 
            this.button_Debug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Debug.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Debug.Location = new System.Drawing.Point(1203, 633);
            this.button_Debug.Name = "button_Debug";
            this.button_Debug.Size = new System.Drawing.Size(242, 99);
            this.button_Debug.TabIndex = 31;
            this.button_Debug.Text = "Debug";
            this.button_Debug.UseVisualStyleBackColor = false;
            this.button_Debug.Click += new System.EventHandler(this.button_Debug_Click);
            // 
            // UpdateUITimer
            // 
            this.UpdateUITimer.Interval = 1000;
            this.UpdateUITimer.Tick += new System.EventHandler(this.UpdateUITimer_Tick);
            // 
            // TimerLabel
            // 
            this.TimerLabel.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimerLabel.ForeColor = System.Drawing.Color.Lime;
            this.TimerLabel.Location = new System.Drawing.Point(548, 639);
            this.TimerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(392, 84);
            this.TimerLabel.TabIndex = 32;
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1456, 813);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.button_Debug);
            this.Controls.Add(this.showPicture);
            this.Controls.Add(this.button_AutoRun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowMessage);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AllInOne";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.showPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ShowMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AutoRun;
        private System.Windows.Forms.PictureBox showPicture;
        private System.Windows.Forms.Button button_Debug;
        private System.Windows.Forms.Timer UpdateUITimer;
        private System.Windows.Forms.Label TimerLabel;
    }
}

