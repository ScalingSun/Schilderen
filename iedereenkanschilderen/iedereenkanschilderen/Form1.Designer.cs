namespace iedereenkanschilderen
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
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.txbContent = new System.Windows.Forms.TextBox();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.txbNameFile = new System.Windows.Forms.TextBox();
            this.lblFileOpened = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbSaveFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(267, 41);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(267, 143);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 3;
            this.btnDraw.Text = "Draw!";
            this.btnDraw.UseVisualStyleBackColor = true;
            // 
            // txbContent
            // 
            this.txbContent.Location = new System.Drawing.Point(12, 41);
            this.txbContent.Multiline = true;
            this.txbContent.Name = "txbContent";
            this.txbContent.Size = new System.Drawing.Size(239, 387);
            this.txbContent.TabIndex = 4;
            // 
            // btnNewFile
            // 
            this.btnNewFile.Location = new System.Drawing.Point(373, 12);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(75, 23);
            this.btnNewFile.TabIndex = 5;
            this.btnNewFile.Text = "New File";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // txbNameFile
            // 
            this.txbNameFile.Location = new System.Drawing.Point(267, 14);
            this.txbNameFile.Name = "txbNameFile";
            this.txbNameFile.Size = new System.Drawing.Size(100, 20);
            this.txbNameFile.TabIndex = 6;
            this.txbNameFile.Text = "Filename";
            // 
            // lblFileOpened
            // 
            this.lblFileOpened.AutoSize = true;
            this.lblFileOpened.Location = new System.Drawing.Point(13, 14);
            this.lblFileOpened.Name = "lblFileOpened";
            this.lblFileOpened.Size = new System.Drawing.Size(68, 13);
            this.lblFileOpened.TabIndex = 7;
            this.lblFileOpened.Text = "File opened: ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(373, 69);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbSaveFileName
            // 
            this.txbSaveFileName.Location = new System.Drawing.Point(267, 70);
            this.txbSaveFileName.Name = "txbSaveFileName";
            this.txbSaveFileName.Size = new System.Drawing.Size(100, 20);
            this.txbSaveFileName.TabIndex = 9;
            this.txbSaveFileName.Text = "Filename";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.txbSaveFileName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFileOpened);
            this.Controls.Add(this.txbNameFile);
            this.Controls.Add(this.btnNewFile);
            this.Controls.Add(this.txbContent);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnLoadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txbContent;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.TextBox txbNameFile;
        private System.Windows.Forms.Label lblFileOpened;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbSaveFileName;
    }
}

