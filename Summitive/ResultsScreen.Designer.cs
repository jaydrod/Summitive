namespace Summitive
{
    partial class ResultsScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultslable = new System.Windows.Forms.Label();
            this.resultresultlasble = new System.Windows.Forms.Label();
            this.Playagain = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultslable
            // 
            this.resultslable.AutoSize = true;
            this.resultslable.BackColor = System.Drawing.Color.Black;
            this.resultslable.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultslable.ForeColor = System.Drawing.SystemColors.Control;
            this.resultslable.Location = new System.Drawing.Point(140, 26);
            this.resultslable.Name = "resultslable";
            this.resultslable.Size = new System.Drawing.Size(157, 42);
            this.resultslable.TabIndex = 0;
            this.resultslable.Text = "Results";
            // 
            // resultresultlasble
            // 
            this.resultresultlasble.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultresultlasble.ForeColor = System.Drawing.SystemColors.Control;
            this.resultresultlasble.Location = new System.Drawing.Point(14, 74);
            this.resultresultlasble.Name = "resultresultlasble";
            this.resultresultlasble.Size = new System.Drawing.Size(486, 237);
            this.resultresultlasble.TabIndex = 1;
            // 
            // Playagain
            // 
            this.Playagain.Location = new System.Drawing.Point(65, 380);
            this.Playagain.Name = "Playagain";
            this.Playagain.Size = new System.Drawing.Size(75, 23);
            this.Playagain.TabIndex = 2;
            this.Playagain.Text = "Play Again";
            this.Playagain.UseVisualStyleBackColor = true;
            this.Playagain.Click += new System.EventHandler(this.Playagain_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(256, 380);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 3;
            this.Exitbutton.Text = "Exit ";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // ResultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Playagain);
            this.Controls.Add(this.resultresultlasble);
            this.Controls.Add(this.resultslable);
            this.Name = "ResultsScreen";
            this.Size = new System.Drawing.Size(530, 420);
            this.Load += new System.EventHandler(this.ResultsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultslable;
        private System.Windows.Forms.Label resultresultlasble;
        private System.Windows.Forms.Button Playagain;
        private System.Windows.Forms.Button Exitbutton;
    }
}
