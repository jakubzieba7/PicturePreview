namespace Tydz6_Zad2_PodglądZdjęcia
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
            this.pbPict = new System.Windows.Forms.PictureBox();
            this.btnPicLoad = new System.Windows.Forms.Button();
            this.btnClearPicBox = new System.Windows.Forms.Button();
            this.tbPicturePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPict)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPict
            // 
            this.pbPict.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPict.BackColor = System.Drawing.Color.White;
            this.pbPict.Location = new System.Drawing.Point(0, 114);
            this.pbPict.Name = "pbPict";
            this.pbPict.Size = new System.Drawing.Size(486, 470);
            this.pbPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPict.TabIndex = 0;
            this.pbPict.TabStop = false;
            // 
            // btnPicLoad
            // 
            this.btnPicLoad.Location = new System.Drawing.Point(27, 25);
            this.btnPicLoad.Name = "btnPicLoad";
            this.btnPicLoad.Size = new System.Drawing.Size(98, 23);
            this.btnPicLoad.TabIndex = 1;
            this.btnPicLoad.Text = "Wczytaj zdjęcie";
            this.btnPicLoad.UseVisualStyleBackColor = true;
            this.btnPicLoad.Click += new System.EventHandler(this.btnPicLoad_Click);
            // 
            // btnClearPicBox
            // 
            this.btnClearPicBox.Location = new System.Drawing.Point(167, 25);
            this.btnClearPicBox.Name = "btnClearPicBox";
            this.btnClearPicBox.Size = new System.Drawing.Size(89, 23);
            this.btnClearPicBox.TabIndex = 2;
            this.btnClearPicBox.Text = "Wyczyść";
            this.btnClearPicBox.UseVisualStyleBackColor = true;
            // 
            // tbPicturePath
            // 
            this.tbPicturePath.Location = new System.Drawing.Point(14, 19);
            this.tbPicturePath.Name = "tbPicturePath";
            this.tbPicturePath.Size = new System.Drawing.Size(377, 20);
            this.tbPicturePath.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPicturePath);
            this.groupBox1.Location = new System.Drawing.Point(13, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 53);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ścieżka pliku";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(485, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearPicBox);
            this.Controls.Add(this.btnPicLoad);
            this.Controls.Add(this.pbPict);
            this.MinimumSize = new System.Drawing.Size(338, 365);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podgląd zdjęcia";
            ((System.ComponentModel.ISupportInitialize)(this.pbPict)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPict;
        private System.Windows.Forms.Button btnPicLoad;
        private System.Windows.Forms.Button btnClearPicBox;
        private System.Windows.Forms.TextBox tbPicturePath;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

