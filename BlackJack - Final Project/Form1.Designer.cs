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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainGame));
            this.lblBank = new System.Windows.Forms.Label();
            this.btnTutorials = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.imgDealHand = new System.Windows.Forms.PictureBox();
            this.tmrAddCards = new System.Windows.Forms.Timer(this.components);
            this.txtBetAmount = new System.Windows.Forms.TextBox();
            this.btnPlaceBet = new System.Windows.Forms.Button();
            this.imgChpPlcDwn = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imgOneChip = new System.Windows.Forms.PictureBox();
            this.imgFiveChip = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgDealHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChpPlcDwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOneChip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiveChip)).BeginInit();
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
            // imgDealHand
            // 
            this.imgDealHand.Location = new System.Drawing.Point(688, 12);
            this.imgDealHand.Name = "imgDealHand";
            this.imgDealHand.Size = new System.Drawing.Size(100, 155);
            this.imgDealHand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDealHand.TabIndex = 6;
            this.imgDealHand.TabStop = false;
            // 
            // tmrAddCards
            // 
            this.tmrAddCards.Tick += new System.EventHandler(this.tmrAddCards_Tick);
            // 
            // txtBetAmount
            // 
            this.txtBetAmount.Location = new System.Drawing.Point(109, 370);
            this.txtBetAmount.Name = "txtBetAmount";
            this.txtBetAmount.Size = new System.Drawing.Size(76, 20);
            this.txtBetAmount.TabIndex = 8;
            this.txtBetAmount.TextChanged += new System.EventHandler(this.txtSelectChips_TextChanged);
            // 
            // btnPlaceBet
            // 
            this.btnPlaceBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceBet.Location = new System.Drawing.Point(110, 396);
            this.btnPlaceBet.Name = "btnPlaceBet";
            this.btnPlaceBet.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceBet.TabIndex = 9;
            this.btnPlaceBet.Text = "Place Bet";
            this.btnPlaceBet.UseVisualStyleBackColor = true;
            this.btnPlaceBet.Visible = false;
            this.btnPlaceBet.Click += new System.EventHandler(this.btnSelectChips_Click);
            // 
            // imgChpPlcDwn
            // 
            this.imgChpPlcDwn.BackColor = System.Drawing.Color.Green;
            this.imgChpPlcDwn.Location = new System.Drawing.Point(236, 233);
            this.imgChpPlcDwn.Name = "imgChpPlcDwn";
            this.imgChpPlcDwn.Size = new System.Drawing.Size(343, 225);
            this.imgChpPlcDwn.TabIndex = 12;
            this.imgChpPlcDwn.TabStop = false;
            this.imgChpPlcDwn.MouseHover += new System.EventHandler(this.imgChpPlcDwn_MouseHover);
            // 
            // imgOneChip
            // 
            this.imgOneChip.Image = global::BlackJack___Final_Project.Properties.Resources._1Chip;
            this.imgOneChip.Location = new System.Drawing.Point(12, 359);
            this.imgOneChip.Name = "imgOneChip";
            this.imgOneChip.Size = new System.Drawing.Size(60, 60);
            this.imgOneChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgOneChip.TabIndex = 13;
            this.imgOneChip.TabStop = false;
            // 
            // imgFiveChip
            // 
            this.imgFiveChip.Image = global::BlackJack___Final_Project.Properties.Resources._1Chip;
            this.imgFiveChip.Location = new System.Drawing.Point(12, 293);
            this.imgFiveChip.Name = "imgFiveChip";
            this.imgFiveChip.Size = new System.Drawing.Size(60, 60);
            this.imgFiveChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFiveChip.TabIndex = 14;
            this.imgFiveChip.TabStop = false;
            // 
            // frmMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.imgFiveChip);
            this.Controls.Add(this.imgOneChip);
            this.Controls.Add(this.imgChpPlcDwn);
            this.Controls.Add(this.btnPlaceBet);
            this.Controls.Add(this.txtBetAmount);
            this.Controls.Add(this.imgDealHand);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnTutorials);
            this.Controls.Add(this.lblBank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.frmMainGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDealHand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChpPlcDwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOneChip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiveChip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Button btnTutorials;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox imgDealHand;
        private System.Windows.Forms.Timer tmrAddCards;
        private System.Windows.Forms.TextBox txtBetAmount;
        private System.Windows.Forms.Button btnPlaceBet;
        private System.Windows.Forms.PictureBox imgChpPlcDwn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox imgOneChip;
        private System.Windows.Forms.PictureBox imgFiveChip;
    }
}

