namespace WindowsFormsApplication9
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.bLeft = new System.Windows.Forms.Button();
            this.bRight = new System.Windows.Forms.Button();
            this.bFind = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder";
            // 
            // tbFolder
            // 
            this.tbFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFolder.Location = new System.Drawing.Point(67, 13);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(301, 22);
            this.tbFolder.TabIndex = 1;
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(375, 11);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(25, 23);
            this.bSearch.TabIndex = 2;
            this.bSearch.Text = "...";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(106, 74);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(205, 116);
            this.pbPicture.TabIndex = 3;
            this.pbPicture.TabStop = false;
            // 
            // bLeft
            // 
            this.bLeft.Location = new System.Drawing.Point(16, 74);
            this.bLeft.Name = "bLeft";
            this.bLeft.Size = new System.Drawing.Size(75, 56);
            this.bLeft.TabIndex = 4;
            this.bLeft.Text = ".";
            this.bLeft.UseVisualStyleBackColor = true;
            this.bLeft.Click += new System.EventHandler(this.bLeft_Click);
            // 
            // bRight
            // 
            this.bRight.Location = new System.Drawing.Point(325, 74);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(75, 56);
            this.bRight.TabIndex = 5;
            this.bRight.Text = ".";
            this.bRight.UseVisualStyleBackColor = true;
            // 
            // bFind
            // 
            this.bFind.Location = new System.Drawing.Point(135, 45);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(151, 23);
            this.bFind.TabIndex = 6;
            this.bFind.Text = "FIND";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 221);
            this.Controls.Add(this.bFind);
            this.Controls.Add(this.bRight);
            this.Controls.Add(this.bLeft);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.tbFolder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button bLeft;
        private System.Windows.Forms.Button bRight;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

