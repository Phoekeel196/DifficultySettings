namespace DifficultySettings
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.easyButton = new System.Windows.Forms.Button();
            this.difficultButton = new System.Windows.Forms.Button();
            this.impossibleButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 450);
            this.label1.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Black;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(118, 109);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(174, 39);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username";
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(320, 106);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(350, 45);
            this.usernameInput.TabIndex = 2;
            this.usernameInput.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // easyButton
            // 
            this.easyButton.AutoSize = true;
            this.easyButton.BackColor = System.Drawing.Color.Black;
            this.easyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.ForeColor = System.Drawing.Color.White;
            this.easyButton.Location = new System.Drawing.Point(12, 227);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(240, 73);
            this.easyButton.TabIndex = 3;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.MageButton_Click);
            // 
            // difficultButton
            // 
            this.difficultButton.AutoSize = true;
            this.difficultButton.BackColor = System.Drawing.Color.Black;
            this.difficultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultButton.ForeColor = System.Drawing.Color.White;
            this.difficultButton.Location = new System.Drawing.Point(258, 227);
            this.difficultButton.Name = "difficultButton";
            this.difficultButton.Size = new System.Drawing.Size(272, 73);
            this.difficultButton.TabIndex = 4;
            this.difficultButton.Text = "Difficult";
            this.difficultButton.UseVisualStyleBackColor = false;
            this.difficultButton.Click += new System.EventHandler(this.DifficultButton_Click);
            // 
            // impossibleButton
            // 
            this.impossibleButton.AutoSize = true;
            this.impossibleButton.BackColor = System.Drawing.Color.Black;
            this.impossibleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impossibleButton.ForeColor = System.Drawing.Color.White;
            this.impossibleButton.Location = new System.Drawing.Point(536, 227);
            this.impossibleButton.Name = "impossibleButton";
            this.impossibleButton.Size = new System.Drawing.Size(252, 73);
            this.impossibleButton.TabIndex = 5;
            this.impossibleButton.Text = "Impossible";
            this.impossibleButton.UseVisualStyleBackColor = false;
            this.impossibleButton.Click += new System.EventHandler(this.ImpossibleButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(120, 320);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(550, 100);
            this.welcomeLabel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 55);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 55);
            this.label3.TabIndex = 9;
            this.label3.Text = "Unoriganal shooter game \r\n\r\n\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "WWW.Unoriganal.shooter.game.com/httpdotkiki515528F497175708%2131159&authkey=%21AI" +
    "hFHKQkoaMmYzk&page=View&wd=target%283U%20Notes.one%7C8349b257-930b-48a4-950e-623" +
    "a5b3c0f90%2FDifficulty%20Settings%7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(220, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select You Difficulty Setting";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.impossibleButton);
            this.Controls.Add(this.difficultButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button difficultButton;
        private System.Windows.Forms.Button impossibleButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}

