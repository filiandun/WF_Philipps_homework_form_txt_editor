namespace TxtEditor
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonCreateFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(161, 62);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(158, 27);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.Location = new System.Drawing.Point(161, 95);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(158, 27);
            this.buttonCreateFile.TabIndex = 3;
            this.buttonCreateFile.Text = "Создать новый";
            this.buttonCreateFile.UseVisualStyleBackColor = true;
            this.buttonCreateFile.Click += new System.EventHandler(this.buttonCreateFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TxtEditor.Properties.Resources.Microsoft_Word_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 187);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCreateFile);
            this.Controls.Add(this.buttonOpenFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microsoft Word (пробная версия)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}