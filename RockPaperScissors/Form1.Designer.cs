namespace RockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chooseLabel = new System.Windows.Forms.Label();
            this.rockButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorsButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.winsLabel = new System.Windows.Forms.Label();
            this.lossesLabel = new System.Windows.Forms.Label();
            this.tiesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chooseLabel
            // 
            this.chooseLabel.BackColor = System.Drawing.Color.DarkRed;
            this.chooseLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseLabel.ForeColor = System.Drawing.Color.White;
            this.chooseLabel.Location = new System.Drawing.Point(18, 0);
            this.chooseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(160, 151);
            this.chooseLabel.TabIndex = 0;
            this.chooseLabel.Text = "Choose Your Move";
            this.chooseLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // rockButton
            // 
            this.rockButton.BackgroundImage = global::RockPaperScissors.Properties.Resources.rock;
            this.rockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rockButton.Location = new System.Drawing.Point(60, 197);
            this.rockButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(75, 77);
            this.rockButton.TabIndex = 1;
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.BackgroundImage = global::RockPaperScissors.Properties.Resources.paper;
            this.paperButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paperButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paperButton.Location = new System.Drawing.Point(60, 306);
            this.paperButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(75, 77);
            this.paperButton.TabIndex = 2;
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // scissorsButton
            // 
            this.scissorsButton.BackgroundImage = global::RockPaperScissors.Properties.Resources.scissors;
            this.scissorsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scissorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scissorsButton.Location = new System.Drawing.Point(60, 414);
            this.scissorsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(75, 77);
            this.scissorsButton.TabIndex = 3;
            this.scissorsButton.UseVisualStyleBackColor = true;
            this.scissorsButton.Click += new System.EventHandler(this.scissorsButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.DarkRed;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(854, 0);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(160, 151);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "Fighting Record";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // winsLabel
            // 
            this.winsLabel.BackColor = System.Drawing.Color.DarkRed;
            this.winsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsLabel.ForeColor = System.Drawing.Color.White;
            this.winsLabel.Location = new System.Drawing.Point(854, 195);
            this.winsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.winsLabel.Name = "winsLabel";
            this.winsLabel.Size = new System.Drawing.Size(160, 78);
            this.winsLabel.TabIndex = 7;
            this.winsLabel.Text = "Wins: 0";
            this.winsLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lossesLabel
            // 
            this.lossesLabel.BackColor = System.Drawing.Color.DarkRed;
            this.lossesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossesLabel.ForeColor = System.Drawing.Color.White;
            this.lossesLabel.Location = new System.Drawing.Point(854, 305);
            this.lossesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lossesLabel.Name = "lossesLabel";
            this.lossesLabel.Size = new System.Drawing.Size(160, 78);
            this.lossesLabel.TabIndex = 8;
            this.lossesLabel.Text = "Losses: 0";
            this.lossesLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tiesLabel
            // 
            this.tiesLabel.BackColor = System.Drawing.Color.DarkRed;
            this.tiesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiesLabel.ForeColor = System.Drawing.Color.White;
            this.tiesLabel.Location = new System.Drawing.Point(854, 412);
            this.tiesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tiesLabel.Name = "tiesLabel";
            this.tiesLabel.Size = new System.Drawing.Size(160, 78);
            this.tiesLabel.TabIndex = 9;
            this.tiesLabel.Text = "Ties: 0";
            this.tiesLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RockPaperScissors.Properties.Resources.dojo700x390;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 540);
            this.Controls.Add(this.tiesLabel);
            this.Controls.Add(this.lossesLabel);
            this.Controls.Add(this.winsLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scissorsButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.chooseLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Label lossesLabel;
        private System.Windows.Forms.Label tiesLabel;
    }
}

