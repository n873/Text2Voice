namespace WindowsForms_TextReader
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
            this.btnGetBook = new System.Windows.Forms.Button();
            this.rtxtbxBookText = new System.Windows.Forms.RichTextBox();
            this.tbarVolume = new System.Windows.Forms.TrackBar();
            this.tbarRate = new System.Windows.Forms.TrackBar();
            this.btnReadBook = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.cbxVoiceType = new System.Windows.Forms.ComboBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetBook
            // 
            this.btnGetBook.Location = new System.Drawing.Point(38, 55);
            this.btnGetBook.Name = "btnGetBook";
            this.btnGetBook.Size = new System.Drawing.Size(404, 23);
            this.btnGetBook.TabIndex = 0;
            this.btnGetBook.Text = "Choose a book";
            this.btnGetBook.UseVisualStyleBackColor = true;
            this.btnGetBook.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // rtxtbxBookText
            // 
            this.rtxtbxBookText.Location = new System.Drawing.Point(12, 102);
            this.rtxtbxBookText.Name = "rtxtbxBookText";
            this.rtxtbxBookText.Size = new System.Drawing.Size(313, 325);
            this.rtxtbxBookText.TabIndex = 2;
            this.rtxtbxBookText.Text = "";
            // 
            // tbarVolume
            // 
            this.tbarVolume.Location = new System.Drawing.Point(347, 154);
            this.tbarVolume.Name = "tbarVolume";
            this.tbarVolume.Size = new System.Drawing.Size(119, 45);
            this.tbarVolume.TabIndex = 3;
            // 
            // tbarRate
            // 
            this.tbarRate.Location = new System.Drawing.Point(347, 227);
            this.tbarRate.Name = "tbarRate";
            this.tbarRate.Size = new System.Drawing.Size(119, 45);
            this.tbarRate.TabIndex = 3;
            // 
            // btnReadBook
            // 
            this.btnReadBook.BackColor = System.Drawing.Color.Black;
            this.btnReadBook.BackgroundImage = global::WindowsForms_TextReader.Properties.Resources.Play_Button_1;
            this.btnReadBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReadBook.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReadBook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnReadBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnReadBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReadBook.Location = new System.Drawing.Point(331, 309);
            this.btnReadBook.Name = "btnReadBook";
            this.btnReadBook.Size = new System.Drawing.Size(43, 39);
            this.btnReadBook.TabIndex = 5;
            this.btnReadBook.UseVisualStyleBackColor = false;
            this.btnReadBook.Click += new System.EventHandler(this.btnReadBook_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(295, 433);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button2";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(391, 433);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "button2";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // cbxVoiceType
            // 
            this.cbxVoiceType.DisplayMember = "Select a voice";
            this.cbxVoiceType.FormattingEnabled = true;
            this.cbxVoiceType.Items.AddRange(new object[] {
            "Select a voice",
            "Female",
            "Male",
            "Neutral"});
            this.cbxVoiceType.Location = new System.Drawing.Point(347, 102);
            this.cbxVoiceType.Name = "cbxVoiceType";
            this.cbxVoiceType.Size = new System.Drawing.Size(121, 21);
            this.cbxVoiceType.TabIndex = 6;
            this.cbxVoiceType.ValueMember = "Select a voice";
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Black;
            this.btnPause.BackgroundImage = global::WindowsForms_TextReader.Properties.Resources.Pause_Button_1;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Location = new System.Drawing.Point(380, 309);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(43, 39);
            this.btnPause.TabIndex = 5;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Black;
            this.btnStop.BackgroundImage = global::WindowsForms_TextReader.Properties.Resources.Stop_Button_1;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(429, 309);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(43, 39);
            this.btnStop.TabIndex = 5;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 469);
            this.Controls.Add(this.cbxVoiceType);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReadBook);
            this.Controls.Add(this.tbarRate);
            this.Controls.Add(this.tbarVolume);
            this.Controls.Add(this.rtxtbxBookText);
            this.Controls.Add(this.btnGetBook);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetBook;
        private System.Windows.Forms.RichTextBox rtxtbxBookText;
        private System.Windows.Forms.TrackBar tbarVolume;
        private System.Windows.Forms.TrackBar tbarRate;
        private System.Windows.Forms.Button btnReadBook;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox cbxVoiceType;
    }
}

