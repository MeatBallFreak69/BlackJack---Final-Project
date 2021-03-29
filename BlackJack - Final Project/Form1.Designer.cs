namespace BlackJack___Final_Project
{
    partial class frmMainGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainGame));
            this.lblBank = new System.Windows.Forms.Label();
            this.imgEnemyFirstCard = new System.Windows.Forms.PictureBox();
            this.btnTutorials = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgEnemyFirstCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.BackColor = System.Drawing.Color.Transparent;
            this.lblBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.Location = new System.Drawing.Point(12, 441);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(60, 20);
            this.lblBank.TabIndex = 0;
            this.lblBank.Text = "Bank: ";
            // 
            // imgEnemyFirstCard
            // 
            this.imgEnemyFirstCard.Image = global::BlackJack___Final_Project.Properties.Resources.red_back;
            this.imgEnemyFirstCard.Location = new System.Drawing.Point(358, 12);
            this.imgEnemyFirstCard.Name = "imgEnemyFirstCard";
            this.imgEnemyFirstCard.Size = new System.Drawing.Size(100, 155);
            this.imgEnemyFirstCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEnemyFirstCard.TabIndex = 1;
            this.imgEnemyFirstCard.TabStop = false;
            // 
            // btnTutorials
            // 
            this.btnTutorials.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutorials.Location = new System.Drawing.Point(13, 12);
            this.btnTutorials.Name = "btnTutorials";
            this.btnTutorials.Size = new System.Drawing.Size(75, 23);
            this.btnTutorials.TabIndex = 2;
            this.btnTutorials.Text = "Tutorials";
            this.btnTutorials.UseVisualStyleBackColor = true;
            this.btnTutorials.Click += new System.EventHandler(this.btnTutorials_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(13, 41);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack___Final_Project.Properties.Resources.Basic_BlackJack_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnTutorials);
            this.Controls.Add(this.imgEnemyFirstCard);
            this.Controls.Add(this.lblBank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainGame";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.frmMainGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgEnemyFirstCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.PictureBox imgEnemyFirstCard;
        private System.Windows.Forms.Button btnTutorials;
        private System.Windows.Forms.Button btnQuit;
    }
}

