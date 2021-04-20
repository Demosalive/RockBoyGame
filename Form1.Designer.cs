namespace LearningGameCode
{
    partial class SquareBoy
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
            this.scoreText = new System.Windows.Forms.Label();
            this.threat2 = new System.Windows.Forms.PictureBox();
            this.Hero = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.Threat1 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.top2 = new System.Windows.Forms.PictureBox();
            this.top1 = new System.Windows.Forms.PictureBox();
            this.top3 = new System.Windows.Forms.PictureBox();
            this.top4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.threat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Threat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top4)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.SystemColors.Info;
            this.scoreText.Font = new System.Drawing.Font("Oswald", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(12, 603);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(103, 40);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // threat2
            // 
            this.threat2.Image = global::LearningGameCode.Properties.Resources.squarerock1;
            this.threat2.Location = new System.Drawing.Point(646, 387);
            this.threat2.Name = "threat2";
            this.threat2.Size = new System.Drawing.Size(201, 187);
            this.threat2.TabIndex = 3;
            this.threat2.TabStop = false;
            // 
            // Hero
            // 
            this.Hero.Image = global::LearningGameCode.Properties.Resources.hero_1;
            this.Hero.Location = new System.Drawing.Point(134, 526);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(53, 48);
            this.Hero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hero.TabIndex = 2;
            this.Hero.TabStop = false;
            // 
            // floor
            // 
            this.floor.Image = global::LearningGameCode.Properties.Resources.floor;
            this.floor.Location = new System.Drawing.Point(-12, 580);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(843, 81);
            this.floor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.floor.TabIndex = 1;
            this.floor.TabStop = false;
            // 
            // Threat1
            // 
            this.Threat1.Image = global::LearningGameCode.Properties.Resources.squarerock1;
            this.Threat1.Location = new System.Drawing.Point(219, 247);
            this.Threat1.Name = "Threat1";
            this.Threat1.Size = new System.Drawing.Size(100, 98);
            this.Threat1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Threat1.TabIndex = 0;
            this.Threat1.TabStop = false;
            this.Threat1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // top2
            // 
            this.top2.Image = global::LearningGameCode.Properties.Resources.squarerock1;
            this.top2.Location = new System.Drawing.Point(151, -154);
            this.top2.Name = "top2";
            this.top2.Size = new System.Drawing.Size(208, 185);
            this.top2.TabIndex = 5;
            this.top2.TabStop = false;
            // 
            // top1
            // 
            this.top1.Image = global::LearningGameCode.Properties.Resources.squarerock1;
            this.top1.Location = new System.Drawing.Point(444, -84);
            this.top1.Name = "top1";
            this.top1.Size = new System.Drawing.Size(100, 186);
            this.top1.TabIndex = 6;
            this.top1.TabStop = false;
            // 
            // top3
            // 
            this.top3.Image = global::LearningGameCode.Properties.Resources.squarerock1;
            this.top3.Location = new System.Drawing.Point(-12, -109);
            this.top3.Name = "top3";
            this.top3.Size = new System.Drawing.Size(100, 188);
            this.top3.TabIndex = 7;
            this.top3.TabStop = false;
            // 
            // top4
            // 
            this.top4.Image = global::LearningGameCode.Properties.Resources.squarerock1;
            this.top4.Location = new System.Drawing.Point(665, -22);
            this.top4.Name = "top4";
            this.top4.Size = new System.Drawing.Size(157, 184);
            this.top4.TabIndex = 8;
            this.top4.TabStop = false;
            // 
            // SquareBoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(823, 652);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.top4);
            this.Controls.Add(this.top3);
            this.Controls.Add(this.top1);
            this.Controls.Add(this.top2);
            this.Controls.Add(this.threat2);
            this.Controls.Add(this.Hero);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.Threat1);
            this.Name = "SquareBoy";
            this.Text = " SquareBoy";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.threat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Threat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Threat1;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox Hero;
        private System.Windows.Forms.PictureBox threat2;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox top2;
        private System.Windows.Forms.PictureBox top1;
        private System.Windows.Forms.PictureBox top3;
        private System.Windows.Forms.PictureBox top4;
    }
}

