namespace Black_Jack
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDrawCard = new System.Windows.Forms.Button();
            this.btnRemoveCard = new System.Windows.Forms.Button();
            this.btnBet = new System.Windows.Forms.Button();
            this.lstPlayerHand = new System.Windows.Forms.ListBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblDeckInfo = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.numBet = new System.Windows.Forms.NumericUpDown();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDrawCard
            // 
            this.btnDrawCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnDrawCard.Location = new System.Drawing.Point(573, 371);
            this.btnDrawCard.Name = "btnDrawCard";
            this.btnDrawCard.Size = new System.Drawing.Size(138, 26);
            this.btnDrawCard.TabIndex = 0;
            this.btnDrawCard.Text = "взять карту";
            this.btnDrawCard.UseVisualStyleBackColor = true;
            this.btnDrawCard.Click += new System.EventHandler(this.btnDrawCard_Click);
            // 
            // btnRemoveCard
            // 
            this.btnRemoveCard.Location = new System.Drawing.Point(401, 371);
            this.btnRemoveCard.Name = "btnRemoveCard";
            this.btnRemoveCard.Size = new System.Drawing.Size(138, 26);
            this.btnRemoveCard.TabIndex = 1;
            this.btnRemoveCard.Text = "удалить карту";
            this.btnRemoveCard.UseVisualStyleBackColor = true;
            this.btnRemoveCard.Click += new System.EventHandler(this.btnRemoveCard_Click);
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(242, 371);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(138, 25);
            this.btnBet.TabIndex = 3;
            this.btnBet.Text = "сделать ставку";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lstPlayerHand
            // 
            this.lstPlayerHand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPlayerHand.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstPlayerHand.FormattingEnabled = true;
            this.lstPlayerHand.Location = new System.Drawing.Point(595, 166);
            this.lstPlayerHand.Name = "lstPlayerHand";
            this.lstPlayerHand.Size = new System.Drawing.Size(169, 171);
            this.lstPlayerHand.TabIndex = 4;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalance.Location = new System.Drawing.Point(16, 275);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(106, 18);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "Ваш баланс:";
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // lblDeckInfo
            // 
            this.lblDeckInfo.AutoSize = true;
            this.lblDeckInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeckInfo.Location = new System.Drawing.Point(16, 9);
            this.lblDeckInfo.Name = "lblDeckInfo";
            this.lblDeckInfo.Size = new System.Drawing.Size(110, 18);
            this.lblDeckInfo.TabIndex = 7;
            this.lblDeckInfo.Text = "Информация";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayerScore.Location = new System.Drawing.Point(16, 147);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(157, 18);
            this.lblPlayerScore.TabIndex = 8;
            this.lblPlayerScore.Text = "количество очков;";
            // 
            // numBet
            // 
            this.numBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numBet.Location = new System.Drawing.Point(19, 371);
            this.numBet.Name = "numBet";
            this.numBet.Size = new System.Drawing.Size(138, 26);
            this.numBet.TabIndex = 5;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewGame.Image = global::Black_Jack.Properties.Resources._66;
            this.btnNewGame.Location = new System.Drawing.Point(712, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(63, 54);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Black_Jack.Properties.Resources.blackjack_logo3;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(774, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 420);
            this.Controls.Add(this.lstPlayerHand);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblDeckInfo);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.numBet);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnRemoveCard);
            this.Controls.Add(this.btnDrawCard);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDrawCard;
        private System.Windows.Forms.Button btnRemoveCard;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.ListBox lstPlayerHand;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblDeckInfo;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.NumericUpDown numBet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

