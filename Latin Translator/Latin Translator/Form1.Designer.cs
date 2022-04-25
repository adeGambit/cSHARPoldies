
namespace Latin_Translator
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
            this.label1 = new System.Windows.Forms.Label();
            this.latinLabelSinister = new System.Windows.Forms.Button();
            this.dexterButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.translationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a word from below to translate.";
            this.label1.Click += new System.EventHandler(this.latinTranslatePromptLabel);
            // 
            // latinLabelSinister
            // 
            this.latinLabelSinister.Location = new System.Drawing.Point(103, 211);
            this.latinLabelSinister.Name = "latinLabelSinister";
            this.latinLabelSinister.Size = new System.Drawing.Size(75, 34);
            this.latinLabelSinister.TabIndex = 1;
            this.latinLabelSinister.Text = "Sinister";
            this.latinLabelSinister.UseVisualStyleBackColor = true;
            this.latinLabelSinister.TextChanged += new System.EventHandler(this.Sinister);
            this.latinLabelSinister.Click += new System.EventHandler(this.Left);
            // 
            // dexterButton
            // 
            this.dexterButton.Location = new System.Drawing.Point(326, 211);
            this.dexterButton.Name = "dexterButton";
            this.dexterButton.Size = new System.Drawing.Size(75, 34);
            this.dexterButton.TabIndex = 2;
            this.dexterButton.Text = "Dexter";
            this.dexterButton.UseVisualStyleBackColor = true;
            this.dexterButton.Click += new System.EventHandler(this.dexterTranslateButton);
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(556, 211);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(75, 34);
            this.mediumButton.TabIndex = 3;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.Center);
            // 
            // translationLabel
            // 
            this.translationLabel.AutoSize = true;
            this.translationLabel.Location = new System.Drawing.Point(350, 142);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(0, 20);
            this.translationLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.dexterButton);
            this.Controls.Add(this.latinLabelSinister);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Latin Tranlator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button latinLabelSinister;
        private System.Windows.Forms.Button dexterButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Label translationLabel;
    }
}

