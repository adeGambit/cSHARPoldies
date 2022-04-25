
namespace DayOfTheWeekTutorialExcersise
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
            this.dayOfTheWeekPromptLabel = new System.Windows.Forms.Label();
            this.dayOfTheWeekTextBox = new System.Windows.Forms.TextBox();
            this.monthPromptLabel = new System.Windows.Forms.Label();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayOfTheMonthPromptLable = new System.Windows.Forms.Label();
            this.dayOfTheMonthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yearPromptLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.showDateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayOfTheWeekPromptLabel
            // 
            this.dayOfTheWeekPromptLabel.AutoSize = true;
            this.dayOfTheWeekPromptLabel.Location = new System.Drawing.Point(0, 0);
            this.dayOfTheWeekPromptLabel.Name = "dayOfTheWeekPromptLabel";
            this.dayOfTheWeekPromptLabel.Size = new System.Drawing.Size(170, 20);
            this.dayOfTheWeekPromptLabel.TabIndex = 0;
            this.dayOfTheWeekPromptLabel.Text = "Enter Day of the Week";
            // 
            // dayOfTheWeekTextBox
            // 
            this.dayOfTheWeekTextBox.Location = new System.Drawing.Point(612, 12);
            this.dayOfTheWeekTextBox.Name = "dayOfTheWeekTextBox";
            this.dayOfTheWeekTextBox.Size = new System.Drawing.Size(100, 26);
            this.dayOfTheWeekTextBox.TabIndex = 1;
            // 
            // monthPromptLabel
            // 
            this.monthPromptLabel.AutoSize = true;
            this.monthPromptLabel.Location = new System.Drawing.Point(0, 50);
            this.monthPromptLabel.Name = "monthPromptLabel";
            this.monthPromptLabel.Size = new System.Drawing.Size(215, 20);
            this.monthPromptLabel.TabIndex = 2;
            this.monthPromptLabel.Text = "Enter the Name of the Month";
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(612, 50);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 26);
            this.monthTextBox.TabIndex = 3;
            // 
            // dayOfTheMonthPromptLable
            // 
            this.dayOfTheMonthPromptLable.AutoSize = true;
            this.dayOfTheMonthPromptLable.Location = new System.Drawing.Point(12, 100);
            this.dayOfTheMonthPromptLable.Name = "dayOfTheMonthPromptLable";
            this.dayOfTheMonthPromptLable.Size = new System.Drawing.Size(263, 20);
            this.dayOfTheMonthPromptLable.TabIndex = 4;
            this.dayOfTheMonthPromptLable.Text = "Enter the Numeric Day of the Month";
            // 
            // dayOfTheMonthTextBox
            // 
            this.dayOfTheMonthTextBox.Location = new System.Drawing.Point(612, 100);
            this.dayOfTheMonthTextBox.Name = "dayOfTheMonthTextBox";
            this.dayOfTheMonthTextBox.Size = new System.Drawing.Size(100, 26);
            this.dayOfTheMonthTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // yearPromptLabel
            // 
            this.yearPromptLabel.AutoSize = true;
            this.yearPromptLabel.Location = new System.Drawing.Point(12, 142);
            this.yearPromptLabel.Name = "yearPromptLabel";
            this.yearPromptLabel.Size = new System.Drawing.Size(113, 20);
            this.yearPromptLabel.TabIndex = 7;
            this.yearPromptLabel.Text = "Enter the Year";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(612, 142);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 26);
            this.yearTextBox.TabIndex = 8;
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.AutoSize = true;
            this.dateOutputLabel.Location = new System.Drawing.Point(376, 234);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(0, 20);
            this.dateOutputLabel.TabIndex = 9;
            // 
            // showDateButton
            // 
            this.showDateButton.Location = new System.Drawing.Point(95, 325);
            this.showDateButton.Name = "showDateButton";
            this.showDateButton.Size = new System.Drawing.Size(120, 36);
            this.showDateButton.TabIndex = 10;
            this.showDateButton.Text = "Show Date";
            this.showDateButton.UseVisualStyleBackColor = true;
            this.showDateButton.Click += new System.EventHandler(this.showDateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(316, 325);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(131, 36);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(559, 325);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 36);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDateButton);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.yearPromptLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dayOfTheMonthTextBox);
            this.Controls.Add(this.dayOfTheMonthPromptLable);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.monthPromptLabel);
            this.Controls.Add(this.dayOfTheWeekTextBox);
            this.Controls.Add(this.dayOfTheWeekPromptLabel);
            this.Name = "Form1";
            this.Text = "Birth Date String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayOfTheWeekPromptLabel;
        private System.Windows.Forms.TextBox dayOfTheWeekTextBox;
        private System.Windows.Forms.Label monthPromptLabel;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.Label dayOfTheMonthPromptLable;
        private System.Windows.Forms.TextBox dayOfTheMonthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label yearPromptLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.Button showDateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

