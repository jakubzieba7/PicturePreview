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
            this.btnPicBrowse = new System.Windows.Forms.Button();
            this.btnClearPicBox = new System.Windows.Forms.Button();
            this.tbPicturePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPicLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPict)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPict
            // 
            this.pbPict.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPict.BackColor = System.Drawing.Color.White;
            this.pbPict.Location = new System.Drawing.Point(9, 119);
            this.pbPict.MinimumSize = new System.Drawing.Size(434, 316);
            this.pbPict.Name = "pbPict";
            this.pbPict.Size = new System.Drawing.Size(434, 316);
            this.pbPict.TabIndex = 0;
            this.pbPict.TabStop = false;
            // 
            // btnPicBrowse
            // 
            this.btnPicBrowse.Location = new System.Drawing.Point(27, 25);
            this.btnPicBrowse.Name = "btnPicBrowse";
            this.btnPicBrowse.Size = new System.Drawing.Size(98, 23);
            this.btnPicBrowse.TabIndex = 1;
            this.btnPicBrowse.Text = "Wyszukaj zdjęcie";
            this.btnPicBrowse.UseVisualStyleBackColor = true;
            this.btnPicBrowse.Click += new System.EventHandler(this.btnPicBrowse_Click);
            // 
            // btnClearPicBox
            // 
            this.btnClearPicBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClearPicBox.Location = new System.Drawing.Point(175, 25);
            this.btnClearPicBox.Name = "btnClearPicBox";
            this.btnClearPicBox.Size = new System.Drawing.Size(102, 23);
            this.btnClearPicBox.TabIndex = 2;
            this.btnClearPicBox.Text = "Wyczyść podgląd";
            this.btnClearPicBox.UseVisualStyleBackColor = true;
            // 
            // tbPicturePath
            // 
            this.tbPicturePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPicturePath.Location = new System.Drawing.Point(14, 19);
            this.tbPicturePath.Name = "tbPicturePath";
            this.tbPicturePath.Size = new System.Drawing.Size(391, 20);
            this.tbPicturePath.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbPicturePath);
            this.groupBox1.Location = new System.Drawing.Point(13, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 53);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ścieżka pliku";
            // 
            // btnPicLoad
            // 
            this.btnPicLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPicLoad.Location = new System.Drawing.Point(320, 25);
            this.btnPicLoad.Name = "btnPicLoad";
            this.btnPicLoad.Size = new System.Drawing.Size(98, 23);
            this.btnPicLoad.TabIndex = 5;
            this.btnPicLoad.Text = "Wczytaj zdjęcie";
            this.btnPicLoad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(455, 447);
            this.Controls.Add(this.btnPicLoad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearPicBox);
            this.Controls.Add(this.btnPicBrowse);
            this.Controls.Add(this.pbPict);
            this.MinimumSize = new System.Drawing.Size(471, 486);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podgląd zdjęcia";
            ((System.ComponentModel.ISupportInitialize)(this.pbPict)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPict;
        private System.Windows.Forms.Button btnPicBrowse;
        private System.Windows.Forms.Button btnClearPicBox;
        private System.Windows.Forms.TextBox tbPicturePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPicLoad;
    }
}

