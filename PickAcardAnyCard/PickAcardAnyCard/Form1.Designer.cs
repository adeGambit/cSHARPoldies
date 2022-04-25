
namespace PickAcardAnyCard
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
            this.clickAcardLabel = new System.Windows.Forms.Label();
            this.aceOfhearts = new System.Windows.Forms.PictureBox();
            this.kingSpade = new System.Windows.Forms.PictureBox();
            this.queenHearts = new System.Windows.Forms.PictureBox();
            this.aceOfSpadespictureBox = new System.Windows.Forms.PictureBox();
            this.answerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aceOfhearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingSpade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queenHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceOfSpadespictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // clickAcardLabel
            // 
            this.clickAcardLabel.AutoSize = true;
            this.clickAcardLabel.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickAcardLabel.Location = new System.Drawing.Point(431, 9);
            this.clickAcardLabel.Name = "clickAcardLabel";
            this.clickAcardLabel.Size = new System.Drawing.Size(516, 40);
            this.clickAcardLabel.TabIndex = 0;
            this.clickAcardLabel.Text = "Click a Card to see it\'s Name...";
            this.clickAcardLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clickAcardLabel.Click += new System.EventHandler(this.clickAcardLabel_Click);
            // 
            // aceOfhearts
            // 
            this.aceOfhearts.Image = global::PickAcardAnyCard.Properties.Resources.aceHeart;
            this.aceOfhearts.Location = new System.Drawing.Point(1168, 69);
            this.aceOfhearts.Name = "aceOfhearts";
            this.aceOfhearts.Size = new System.Drawing.Size(471, 656);
            this.aceOfhearts.TabIndex = 4;
            this.aceOfhearts.TabStop = false;
            this.aceOfhearts.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kingSpade
            // 
            this.kingSpade.Image = global::PickAcardAnyCard.Properties.Resources.kingSpade;
            this.kingSpade.Location = new System.Drawing.Point(784, 69);
            this.kingSpade.Name = "kingSpade";
            this.kingSpade.Size = new System.Drawing.Size(378, 446);
            this.kingSpade.TabIndex = 3;
            this.kingSpade.TabStop = false;
            this.kingSpade.Click += new System.EventHandler(this.kingSpade_Click);
            // 
            // queenHearts
            // 
            this.queenHearts.Image = global::PickAcardAnyCard.Properties.Resources.queenHeart;
            this.queenHearts.Location = new System.Drawing.Point(438, 69);
            this.queenHearts.Name = "queenHearts";
            this.queenHearts.Size = new System.Drawing.Size(451, 593);
            this.queenHearts.TabIndex = 2;
            this.queenHearts.TabStop = false;
            this.queenHearts.Click += new System.EventHandler(this.queenHearts_Click);
            // 
            // aceOfSpadespictureBox
            // 
            this.aceOfSpadespictureBox.Image = global::PickAcardAnyCard.Properties.Resources.aceSpade;
            this.aceOfSpadespictureBox.Location = new System.Drawing.Point(12, 69);
            this.aceOfSpadespictureBox.Name = "aceOfSpadespictureBox";
            this.aceOfSpadespictureBox.Size = new System.Drawing.Size(420, 593);
            this.aceOfSpadespictureBox.TabIndex = 1;
            this.aceOfSpadespictureBox.TabStop = false;
            this.aceOfSpadespictureBox.Click += new System.EventHandler(this.aceOfSpadespictureBox_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(828, 792);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(0, 40);
            this.answerLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1717, 931);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.aceOfhearts);
            this.Controls.Add(this.kingSpade);
            this.Controls.Add(this.queenHearts);
            this.Controls.Add(this.aceOfSpadespictureBox);
            this.Controls.Add(this.clickAcardLabel);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.aceOfhearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingSpade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queenHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceOfSpadespictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clickAcardLabel;
        private System.Windows.Forms.PictureBox aceOfSpadespictureBox;
        private System.Windows.Forms.PictureBox queenHearts;
        private System.Windows.Forms.PictureBox kingSpade;
        private System.Windows.Forms.PictureBox aceOfhearts;
        private System.Windows.Forms.Label answerLabel;
    }
}

