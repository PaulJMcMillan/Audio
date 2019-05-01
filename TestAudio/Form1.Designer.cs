namespace TestAudio
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
            this.decompressButton = new System.Windows.Forms.Button();
            this.compressButton = new System.Windows.Forms.Button();
            this.decompressMP3toWaveButton = new System.Windows.Forms.Button();
            this.compressWaveToMP3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decompressButton
            // 
            this.decompressButton.Location = new System.Drawing.Point(187, 12);
            this.decompressButton.Name = "decompressButton";
            this.decompressButton.Size = new System.Drawing.Size(127, 45);
            this.decompressButton.TabIndex = 3;
            this.decompressButton.Text = "Decompress GZip File to Wave File";
            this.decompressButton.UseVisualStyleBackColor = true;
            this.decompressButton.Click += new System.EventHandler(this.decompressButton_Click);
            // 
            // compressButton
            // 
            this.compressButton.Location = new System.Drawing.Point(54, 12);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(127, 44);
            this.compressButton.TabIndex = 2;
            this.compressButton.Text = "Compress Wave File to GZipFile";
            this.compressButton.UseVisualStyleBackColor = true;
            this.compressButton.Click += new System.EventHandler(this.compressButton_Click);
            // 
            // decompressMP3toWaveButton
            // 
            this.decompressMP3toWaveButton.Location = new System.Drawing.Point(187, 62);
            this.decompressMP3toWaveButton.Name = "decompressMP3toWaveButton";
            this.decompressMP3toWaveButton.Size = new System.Drawing.Size(127, 45);
            this.decompressMP3toWaveButton.TabIndex = 5;
            this.decompressMP3toWaveButton.Text = "Decompress MP3 File to Wave File";
            this.decompressMP3toWaveButton.UseVisualStyleBackColor = true;
            this.decompressMP3toWaveButton.Click += new System.EventHandler(this.decompressMP3toWaveButton_Click);
            // 
            // compressWaveToMP3Button
            // 
            this.compressWaveToMP3Button.Location = new System.Drawing.Point(54, 62);
            this.compressWaveToMP3Button.Name = "compressWaveToMP3Button";
            this.compressWaveToMP3Button.Size = new System.Drawing.Size(127, 44);
            this.compressWaveToMP3Button.TabIndex = 4;
            this.compressWaveToMP3Button.Text = "Compress Wave File to MP3 File";
            this.compressWaveToMP3Button.UseVisualStyleBackColor = true;
            this.compressWaveToMP3Button.Click += new System.EventHandler(this.compressWaveToMP3Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 186);
            this.Controls.Add(this.decompressMP3toWaveButton);
            this.Controls.Add(this.compressWaveToMP3Button);
            this.Controls.Add(this.decompressButton);
            this.Controls.Add(this.compressButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Wave File Compression/Decompression";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button decompressButton;
        private System.Windows.Forms.Button compressButton;
        private System.Windows.Forms.Button decompressMP3toWaveButton;
        private System.Windows.Forms.Button compressWaveToMP3Button;
    }
}

