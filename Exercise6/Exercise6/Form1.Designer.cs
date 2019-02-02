namespace Exercise6
{
    partial class MainForm
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
            this.buttonRollDice = new System.Windows.Forms.Button();
            this.textDie1 = new System.Windows.Forms.TextBox();
            this.textDie2 = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRollDice
            // 
            this.buttonRollDice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRollDice.ForeColor = System.Drawing.Color.White;
            this.buttonRollDice.Location = new System.Drawing.Point(11, 12);
            this.buttonRollDice.Name = "buttonRollDice";
            this.buttonRollDice.Size = new System.Drawing.Size(200, 200);
            this.buttonRollDice.TabIndex = 0;
            this.buttonRollDice.Text = "Roll Dice";
            this.buttonRollDice.UseVisualStyleBackColor = false;
            this.buttonRollDice.Click += new System.EventHandler(this.buttonRollDice_Click);
            // 
            // textDie1
            // 
            this.textDie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDie1.ForeColor = System.Drawing.Color.Black;
            this.textDie1.Location = new System.Drawing.Point(226, 12);
            this.textDie1.Multiline = true;
            this.textDie1.Name = "textDie1";
            this.textDie1.Size = new System.Drawing.Size(100, 100);
            this.textDie1.TabIndex = 1;
            this.textDie1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDie2
            // 
            this.textDie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDie2.ForeColor = System.Drawing.Color.Black;
            this.textDie2.Location = new System.Drawing.Point(346, 12);
            this.textDie2.Multiline = true;
            this.textDie2.Name = "textDie2";
            this.textDie2.Size = new System.Drawing.Size(100, 100);
            this.textDie2.TabIndex = 2;
            this.textDie2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(226, 153);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(220, 59);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(457, 223);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textDie2);
            this.Controls.Add(this.textDie1);
            this.Controls.Add(this.buttonRollDice);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForm";
            this.Text = "Dice Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRollDice;
        private System.Windows.Forms.TextBox textDie1;
        private System.Windows.Forms.TextBox textDie2;
        private System.Windows.Forms.Button buttonClose;
    }
}

