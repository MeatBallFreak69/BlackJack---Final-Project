namespace BlackJack___Final_Project
{
    partial class frmTutorials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutorials));
            this.btnStratagies = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCardValues = new System.Windows.Forms.Button();
            this.btnGameInstructions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStratagies
            // 
            this.btnStratagies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStratagies.Location = new System.Drawing.Point(12, 12);
            this.btnStratagies.Name = "btnStratagies";
            this.btnStratagies.Size = new System.Drawing.Size(86, 38);
            this.btnStratagies.TabIndex = 0;
            this.btnStratagies.Text = "Strategy Guide";
            this.btnStratagies.UseVisualStyleBackColor = true;
            this.btnStratagies.Click += new System.EventHandler(this.btnStratagies_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(288, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCardValues
            // 
            this.btnCardValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCardValues.Location = new System.Drawing.Point(104, 12);
            this.btnCardValues.Name = "btnCardValues";
            this.btnCardValues.Size = new System.Drawing.Size(86, 38);
            this.btnCardValues.TabIndex = 2;
            this.btnCardValues.Text = "Card Values";
            this.btnCardValues.UseVisualStyleBackColor = true;
            this.btnCardValues.Click += new System.EventHandler(this.btnCardValues_Click);
            // 
            // btnGameInstructions
            // 
            this.btnGameInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameInstructions.Location = new System.Drawing.Point(196, 12);
            this.btnGameInstructions.Name = "btnGameInstructions";
            this.btnGameInstructions.Size = new System.Drawing.Size(86, 38);
            this.btnGameInstructions.TabIndex = 3;
            this.btnGameInstructions.Text = "Game Instructions";
            this.btnGameInstructions.UseVisualStyleBackColor = true;
            this.btnGameInstructions.Click += new System.EventHandler(this.btnGameInstructions_Click);
            // 
            // frmTutorials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack___Final_Project.Properties.Resources.Basic_BlackJack_Background;
            this.ClientSize = new System.Drawing.Size(381, 63);
            this.Controls.Add(this.btnGameInstructions);
            this.Controls.Add(this.btnCardValues);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStratagies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTutorials";
            this.Text = "formTutorials";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStratagies;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCardValues;
        private System.Windows.Forms.Button btnGameInstructions;
    }
}