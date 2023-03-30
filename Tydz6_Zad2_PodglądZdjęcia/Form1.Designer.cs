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
            ((System.ComponentModel.ISupportInitialize)(this.pbPict)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPict
            // 
            this.pbPict.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPict.BackColor = System.Drawing.Color.White;
            this.pbPict.Location = new System.Drawing.Point(2, 73);
            this.pbPict.Name = "pbPict";
            this.pbPict.Size = new System.Drawing.Size(319, 253);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(322, 326);
            this.Controls.Add(this.btnClearPicBox);
            this.Controls.Add(this.btnPicLoad);
            this.Controls.Add(this.pbPict);
            this.MinimumSize = new System.Drawing.Size(338, 365);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podgląd zdjęcia";
            ((System.ComponentModel.ISupportInitialize)(this.pbPict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPict;
        private System.Windows.Forms.Button btnPicLoad;
        private System.Windows.Forms.Button btnClearPicBox;
    }
}

