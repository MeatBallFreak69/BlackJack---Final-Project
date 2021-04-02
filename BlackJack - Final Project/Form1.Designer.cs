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
            this.imgChpPlcDwn = new System.Windows.Forms.PictureBox();
            this.tltChipPlacement = new System.Windows.Forms.ToolTip(this.components);
            this.imgOneChip = new System.Windows.Forms.PictureBox();
            this.imgFiveChip = new System.Windows.Forms.PictureBox();
            this.imgTenChip = new System.Windows.Forms.PictureBox();
            this.imgTwentyChip = new System.Windows.Forms.PictureBox();
            this.imgFiftyChip = new System.Windows.Forms.PictureBox();
            this.imgHundredChip = new System.Windows.Forms.PictureBox();
            this.tltOneChip = new System.Windows.Forms.ToolTip(this.components);
            this.tltFiveChip = new System.Windows.Forms.ToolTip(this.components);
            this.tltTenChip = new System.Windows.Forms.ToolTip(this.components);
            this.tltTwentyChip = new System.Windows.Forms.ToolTip(this.components);
            this.tltFiftyChip = new System.Windows.Forms.ToolTip(this.components);
            this.tltHundredChip = new System.Windows.Forms.ToolTip(this.components);
            this.lblBet = new System.Windows.Forms.Label();
            this.btnResetBet = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.imgEnemyCardOne = new System.Windows.Forms.PictureBox();
            this.imgEnemyCardTwo = new System.Windows.Forms.PictureBox();
            this.imgPlayerCardTwo = new System.Windows.Forms.PictureBox();
            this.imgPlayerCardOne = new System.Windows.Forms.PictureBox();
            this.lblEnemyCardsValue = new System.Windows.Forms.Label();
            this.lblPlayerCardsValue = new System.Windows.Forms.Label();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.imgPlayerCardThree = new System.Windows.Forms.PictureBox();
            this.imgEnemyCardThree = new System.Windows.Forms.PictureBox();
            this.imgEnemyCardFour = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgDealHand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChpPlcDwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOneChip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiveChip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTenChip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTwentyChip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiftyChip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHundredChip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEnemyCardOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEnemyCardTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerCardTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerCardOne)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerCardThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEnemyCardThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEnemyCardFour)).BeginInit();
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
            this.btnTutorials.Location = new System.Drawing.Point(6, 13);
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
            this.btnQuit.Location = new System.Drawing.Point(87, 13);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // imgDealHand
            // 
            this.imgDealHand.BackColor = System.Drawing.Color.Black;
            this.imgDealHand.Image = global::BlackJack___Final_Project.Properties.Resources.red_back;
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
            // imgChpPlcDwn
            // 
            this.imgChpPlcDwn.BackColor = System.Drawing.Color.Green;
            this.imgChpPlcDwn.Location = new System.Drawing.Point(236, 233);
            this.imgChpPlcDwn.Name = "imgChpPlcDwn";
            this.imgChpPlcDwn.Size = new System.Drawing.Size(343, 225);
            this.imgChpPlcDwn.TabIndex = 12;
            this.imgChpPlcDwn.TabStop = false;
            // 
            // imgOneChip
            // 
            this.imgOneChip.BackColor = System.Drawing.Color.Transparent;
            this.imgOneChip.Image = global::BlackJack___Final_Project.Properties.Resources._1Chip;
            this.imgOneChip.Location = new System.Drawing.Point(12, 359);
            this.imgOneChip.Name = "imgOneChip";
            this.imgOneChip.Size = new System.Drawing.Size(60, 60);
            this.imgOneChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgOneChip.TabIndex = 13;
            this.imgOneChip.TabStop = false;
            this.imgOneChip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgOneChip_MouseDown);
            this.imgOneChip.MouseHover += new System.EventHandler(this.imgOneChip_MouseHover);
            // 
            // imgFiveChip
            // 
            this.imgFiveChip.BackColor = System.Drawing.Color.Transparent;
            this.imgFiveChip.Image = global::BlackJack___Final_Project.Properties.Resources._5Chip;
            this.imgFiveChip.Location = new System.Drawing.Point(78, 359);
            this.imgFiveChip.Name = "imgFiveChip";
            this.imgFiveChip.Size = new System.Drawing.Size(60, 60);
            this.imgFiveChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFiveChip.TabIndex = 14;
            this.imgFiveChip.TabStop = false;
            this.imgFiveChip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgFiveChip_MouseDown);
            this.imgFiveChip.MouseHover += new System.EventHandler(this.imgFiveChip_MouseHover);
            // 
            // imgTenChip
            // 
            this.imgTenChip.BackColor = System.Drawing.Color.Transparent;
            this.imgTenChip.Image = global::BlackJack___Final_Project.Properties.Resources._10Chip;
            this.imgTenChip.Location = new System.Drawing.Point(12, 293);
            this.imgTenChip.Name = "imgTenChip";
            this.imgTenChip.Size = new System.Drawing.Size(60, 60);
            this.imgTenChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTenChip.TabIndex = 15;
            this.imgTenChip.TabStop = false;
            this.imgTenChip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgTenChip_MouseDown);
            this.imgTenChip.MouseHover += new System.EventHandler(this.imgTenChip_MouseHover);
            // 
            // imgTwentyChip
            // 
            this.imgTwentyChip.BackColor = System.Drawing.Color.Transparent;
            this.imgTwentyChip.Image = global::BlackJack___Final_Project.Properties.Resources._20Chip;
            this.imgTwentyChip.Location = new System.Drawing.Point(78, 293);
            this.imgTwentyChip.Name = "imgTwentyChip";
            this.imgTwentyChip.Size = new System.Drawing.Size(60, 60);
            this.imgTwentyChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTwentyChip.TabIndex = 16;
            this.imgTwentyChip.TabStop = false;
            this.imgTwentyChip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgTwentyChip_MouseDown);
            this.imgTwentyChip.MouseHover += new System.EventHandler(this.imgTwentyChip_MouseHover);
            // 
            // imgFiftyChip
            // 
            this.imgFiftyChip.BackColor = System.Drawing.Color.Transparent;
            this.imgFiftyChip.Image = global::BlackJack___Final_Project.Properties.Resources._50Chip;
            this.imgFiftyChip.Location = new System.Drawing.Point(12, 227);
            this.imgFiftyChip.Name = "imgFiftyChip";
            this.imgFiftyChip.Size = new System.Drawing.Size(60, 60);
            this.imgFiftyChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFiftyChip.TabIndex = 17;
            this.imgFiftyChip.TabStop = false;
            this.imgFiftyChip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgFiftyChip_MouseDown);
            this.imgFiftyChip.MouseHover += new System.EventHandler(this.imgFiftyChip_MouseHover);
            // 
            // imgHundredChip
            // 
            this.imgHundredChip.BackColor = System.Drawing.Color.Transparent;
            this.imgHundredChip.Image = global::BlackJack___Final_Project.Properties.Resources._100Chip;
            this.imgHundredChip.Location = new System.Drawing.Point(78, 227);
            this.imgHundredChip.Name = "imgHundredChip";
            this.imgHundredChip.Size = new System.Drawing.Size(60, 60);
            this.imgHundredChip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHundredChip.TabIndex = 18;
            this.imgHundredChip.TabStop = false;
            this.imgHundredChip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgHundredChip_MouseDown);
            this.imgHundredChip.MouseHover += new System.EventHandler(this.imgHundredChip_MouseHover);
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.BackColor = System.Drawing.Color.Transparent;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(338, 204);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(139, 20);
            this.lblBet.TabIndex = 19;
            this.lblBet.Text = "Bet Amount:  $0";
            // 
            // btnResetBet
            // 
            this.btnResetBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetBet.Location = new System.Drawing.Point(236, 204);
            this.btnResetBet.Name = "btnResetBet";
            this.btnResetBet.Size = new System.Drawing.Size(87, 23);
            this.btnResetBet.TabIndex = 20;
            this.btnResetBet.Text = "Reset Bet";
            this.btnResetBet.UseVisualStyleBackColor = true;
            this.btnResetBet.Click += new System.EventHandler(this.btnResetBet_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.Location = new System.Drawing.Point(492, 204);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(87, 23);
            this.btnDeal.TabIndex = 21;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // imgEnemyCardOne
            // 
            this.imgEnemyCardOne.BackColor = System.Drawing.Color.Black;
            this.imgEnemyCardOne.Image = global::BlackJack___Final_Project.Properties.Resources.red_back;
            this.imgEnemyCardOne.Location = new System.Drawing.Point(259, 12);
            this.imgEnemyCardOne.Name = "imgEnemyCardOne";
            this.imgEnemyCardOne.Size = new System.Drawing.Size(100, 155);
            this.imgEnemyCardOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEnemyCardOne.TabIndex = 22;
            this.imgEnemyCardOne.TabStop = false;
            this.imgEnemyCardOne.Visible = false;
            // 
            // imgEnemyCardTwo
            // 
            this.imgEnemyCardTwo.BackColor = System.Drawing.Color.Black;
            this.imgEnemyCardTwo.Image = global::BlackJack___Final_Project.Properties.Resources.red_back;
            this.imgEnemyCardTwo.Location = new System.Drawing.Point(342, 12);
            this.imgEnemyCardTwo.Name = "imgEnemyCardTwo";
            this.imgEnemyCardTwo.Size = new System.Drawing.Size(100, 155);
            this.imgEnemyCardTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEnemyCardTwo.TabIndex = 23;
            this.imgEnemyCardTwo.TabStop = false;
            this.imgEnemyCardTwo.Visible = false;
            // 
            // imgPlayerCardTwo
            // 
            this.imgPlayerCardTwo.BackColor = System.Drawing.Color.Black;
            this.imgPlayerCardTwo.Image = global::BlackJack___Final_Project.Properties.Resources.red_back;
            this.imgPlayerCardTwo.Location = new System.Drawing.Point(342, 268);
            this.imgPlayerCardTwo.Name = "imgPlayerCardTwo";
            this.imgPlayerCardTwo.Size = new System.Drawing.Size(100, 155);
            this.imgPlayerCardTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerCardTwo.TabIndex = 25;
            this.imgPlayerCardTwo.TabStop = false;
            this.imgPlayerCardTwo.Visible = false;
            // 
            // imgPlayerCardOne
            // 
            this.imgPlayerCardOne.BackColor = System.Drawing.Color.Black;
            this.imgPlayerCardOne.Image = global::BlackJack___Final_Project.Properties.Resources.red_back;
            this.imgPlayerCardOne.Location = new System.Drawing.Point(259, 268);
            this.imgPlayerCardOne.Name = "imgPlayerCardOne";
            this.imgPlayerCardOne.Size = new System.Drawing.Size(100, 155);
            this.imgPlayerCardOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerCardOne.TabIndex = 24;
            this.imgPlayerCardOne.TabStop = false;
            this.imgPlayerCardOne.Visible = false;
            // 
            // lblEnemyCardsValue
            // 
            this.lblEnemyCardsValue.AutoSize = true;
            this.lblEnemyCardsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyCardsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyCardsValue.Location = new System.Drawing.Point(8, 70);
            this.lblEnemyCardsValue.Name = "lblEnemyCardsValue";
            this.lblEnemyCardsValue.Size = new System.Drawing.Size(191, 20);
            this.lblEnemyCardsValue.TabIndex = 26;
            this.lblEnemyCardsValue.Text = "Computer Card Value: ";
            // 
            // lblPlayerCardsValue
            // 
            this.lblPlayerCardsValue.AutoSize = true;
            this.lblPlayerCardsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerCardsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCardsValue.Location = new System.Drawing.Point(8, 190);
            this.lblPlayerCardsValue.Name = "lblPlayerCardsValue";
            this.lblPlayerCardsValue.Size = new System.Drawing.Size(162, 20);
            this.lblPlayerCardsValue.TabIndex = 27;
            this.lblPlayerCardsValue.Text = "Player Card Value: ";
            // 
            // grpMenu
            // 
            this.grpMenu.BackColor = System.Drawing.Color.Transparent;
            this.grpMenu.Controls.Add(this.btnTutorials);
            this.grpMenu.Controls.Add(this.btnQuit);
            this.grpMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenu.Location = new System.Drawing.Point(12, 12);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(169, 44);
            this.grpMenu.TabIndex = 28;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Menu";
            // 
            // btnHit
            // 
            this.btnHit.Enabled = false;
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(159, 293);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(71, 35);
            this.btnHit.TabIndex = 29;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Enabled = false;
            this.btnStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Location = new System.Drawing.Point(159, 374);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(71, 35);
            this.btnStand.TabIndex = 30;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // imgPlayerCardThree
            // 
            this.imgPlayerCardThree.BackColor = System.Drawing.Color.Black;
            this.imgPlayerCardThree.Image = global::BlackJack___Final_Project.Properties.Resources.red_back;
            this.imgPlayerCardThree.Location = new System.Drawing.Point(425, 268);
            this.imgPlayerCardThree.Name = "imgPlayerCardThree";
            this.imgPlayerCardThree.Size = new System.Drawing.Size(100, 155);
            this.imgPlayerCardThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayerCardThree.TabIndex = 31;
            this.imgPlayerCardThree.TabStop = false;
            this.imgPlayerCardThree.Visible = false;
            // 
            // imgEnemyCardThree
            // 
            this.imgEnemyCardThree.BackColor = System.Drawing.Color.Black;
            this.imgEnemyCardThree.Image = global::BlackJack___Final_Project.Properties.Resources.red_back;
            this.imgEnemyCardThree.Location = new System.Drawing.Point(425, 12);
            this.imgEnemyCardThree.Name = "imgEnemyCardThree";
            this.imgEnemyCardThree.Size = new System.Drawing.Size(100, 155);
            this.imgEnemyCardThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEnemyCardThree.TabIndex = 32;
            this.imgEnemyCardThree.TabStop = false;
            this.imgEnemyCardThree.Visible = false;
            // 
            // imgEnemyCardFour
            // 
            this.imgEnemyCardFour.BackColor = System.Drawing.Color.Black;
            this.imgEnemyCardFour.Image = global::BlackJack___Final_Project.Properties.Resources.red_back;
            this.imgEnemyCardFour.Location = new System.Drawing.Point(504, 12);
            this.imgEnemyCardFour.Name = "imgEnemyCardFour";
            this.imgEnemyCardFour.Size = new System.Drawing.Size(100, 155);
            this.imgEnemyCardFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEnemyCardFour.TabIndex = 33;
            this.imgEnemyCardFour.TabStop = false;
            this.imgEnemyCardFour.Visible = false;
            // 
            // frmMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.imgEnemyCardFour);
            this.Controls.Add(this.imgEnemyCardThree);
            this.Controls.Add(this.imgPlayerCardThree);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblPlayerCardsValue);
            this.Controls.Add(this.lblEnemyCardsValue);
            this.Controls.Add(this.imgPlayerCardTwo);
            this.Controls.Add(this.imgPlayerCardOne);
            this.Controls.Add(this.imgEnemyCardTwo);
            this.Controls.Add(this.imgEnemyCardOne);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.btnResetBet);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.imgHundredChip);
            this.Controls.Add(this.imgFiftyChip);
            this.Controls.Add(this.imgTwentyChip);
            this.Controls.Add(this.imgTenChip);
            this.Controls.Add(this.imgFiveChip);
            this.Controls.Add(this.imgOneChip);
            this.Controls.Add(this.imgChpPlcDwn);
            this.Controls.Add(this.imgDealHand);
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
            ((System.ComponentModel.ISupportInitialize)(this.imgTenChip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTwentyChip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiftyChip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHundredChip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEnemyCardOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEnemyCardTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerCardTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerCardOne)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayerCardThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEnemyCardThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEnemyCardFour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Button btnTutorials;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox imgDealHand;
        private System.Windows.Forms.Timer tmrAddCards;
        private System.Windows.Forms.PictureBox imgChpPlcDwn;
        private System.Windows.Forms.ToolTip tltChipPlacement;
        private System.Windows.Forms.PictureBox imgOneChip;
        private System.Windows.Forms.PictureBox imgFiveChip;
        private System.Windows.Forms.PictureBox imgTenChip;
        private System.Windows.Forms.PictureBox imgTwentyChip;
        private System.Windows.Forms.PictureBox imgFiftyChip;
        private System.Windows.Forms.PictureBox imgHundredChip;
        private System.Windows.Forms.ToolTip tltOneChip;
        private System.Windows.Forms.ToolTip tltFiveChip;
        private System.Windows.Forms.ToolTip tltTenChip;
        private System.Windows.Forms.ToolTip tltTwentyChip;
        private System.Windows.Forms.ToolTip tltFiftyChip;
        private System.Windows.Forms.ToolTip tltHundredChip;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Button btnResetBet;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.PictureBox imgEnemyCardOne;
        private System.Windows.Forms.PictureBox imgEnemyCardTwo;
        private System.Windows.Forms.PictureBox imgPlayerCardTwo;
        private System.Windows.Forms.PictureBox imgPlayerCardOne;
        private System.Windows.Forms.Label lblEnemyCardsValue;
        private System.Windows.Forms.Label lblPlayerCardsValue;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.PictureBox imgPlayerCardThree;
        private System.Windows.Forms.PictureBox imgEnemyCardThree;
        private System.Windows.Forms.PictureBox imgEnemyCardFour;
    }
}

