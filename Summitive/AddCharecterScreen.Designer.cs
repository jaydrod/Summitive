namespace Summitive
{
    partial class AddCharecterScreen
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
            this.choosecharecterlable = new System.Windows.Forms.Label();
            this.Breannabutton = new System.Windows.Forms.Button();
            this.Maxbutton = new System.Windows.Forms.Button();
            this.Chrisbutton = new System.Windows.Forms.Button();
            this.Jaydenbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choosecharecterlable
            // 
            this.choosecharecterlable.AutoSize = true;
            this.choosecharecterlable.Font = new System.Drawing.Font("Castellar", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosecharecterlable.ForeColor = System.Drawing.Color.Black;
            this.choosecharecterlable.Location = new System.Drawing.Point(118, 48);
            this.choosecharecterlable.Name = "choosecharecterlable";
            this.choosecharecterlable.Size = new System.Drawing.Size(453, 35);
            this.choosecharecterlable.TabIndex = 0;
            this.choosecharecterlable.Text = "Choose Your Charecter";
            // 
            // Breannabutton
            // 
            this.Breannabutton.BackColor = System.Drawing.Color.MidnightBlue;
            this.Breannabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Breannabutton.ForeColor = System.Drawing.Color.White;
            this.Breannabutton.Location = new System.Drawing.Point(176, 167);
            this.Breannabutton.Name = "Breannabutton";
            this.Breannabutton.Size = new System.Drawing.Size(318, 34);
            this.Breannabutton.TabIndex = 1;
            this.Breannabutton.Text = "Breanna";
            this.Breannabutton.UseVisualStyleBackColor = false;
            this.Breannabutton.Click += new System.EventHandler(this.Breannabutton_Click);
            // 
            // Maxbutton
            // 
            this.Maxbutton.BackColor = System.Drawing.Color.Purple;
            this.Maxbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maxbutton.Location = new System.Drawing.Point(176, 230);
            this.Maxbutton.Name = "Maxbutton";
            this.Maxbutton.Size = new System.Drawing.Size(318, 31);
            this.Maxbutton.TabIndex = 2;
            this.Maxbutton.Text = "Max";
            this.Maxbutton.UseVisualStyleBackColor = false;
            this.Maxbutton.Click += new System.EventHandler(this.Maxbutton_Click);
            // 
            // Chrisbutton
            // 
            this.Chrisbutton.BackColor = System.Drawing.Color.Green;
            this.Chrisbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chrisbutton.Location = new System.Drawing.Point(176, 292);
            this.Chrisbutton.Name = "Chrisbutton";
            this.Chrisbutton.Size = new System.Drawing.Size(318, 29);
            this.Chrisbutton.TabIndex = 3;
            this.Chrisbutton.Text = "Chris";
            this.Chrisbutton.UseVisualStyleBackColor = false;
            this.Chrisbutton.Click += new System.EventHandler(this.Chrisbutton_Click);
            // 
            // Jaydenbutton
            // 
            this.Jaydenbutton.BackColor = System.Drawing.Color.Red;
            this.Jaydenbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jaydenbutton.Location = new System.Drawing.Point(176, 351);
            this.Jaydenbutton.Name = "Jaydenbutton";
            this.Jaydenbutton.Size = new System.Drawing.Size(318, 24);
            this.Jaydenbutton.TabIndex = 4;
            this.Jaydenbutton.Text = "Jayden";
            this.Jaydenbutton.UseVisualStyleBackColor = false;
            this.Jaydenbutton.Click += new System.EventHandler(this.Jaydenbutton_Click);
            // 
            // AddCharecterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.Jaydenbutton);
            this.Controls.Add(this.Chrisbutton);
            this.Controls.Add(this.Maxbutton);
            this.Controls.Add(this.Breannabutton);
            this.Controls.Add(this.choosecharecterlable);
            this.Name = "AddCharecterScreen";
            this.Size = new System.Drawing.Size(706, 499);
            this.Load += new System.EventHandler(this.AddCharecterScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choosecharecterlable;
        private System.Windows.Forms.Button Breannabutton;
        private System.Windows.Forms.Button Maxbutton;
        private System.Windows.Forms.Button Chrisbutton;
        private System.Windows.Forms.Button Jaydenbutton;
    }
}
