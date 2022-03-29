
namespace Math_game
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Additionbtn = new System.Windows.Forms.Label();
            this.Subtractionbtn = new System.Windows.Forms.Label();
            this.Multiplicationbtn = new System.Windows.Forms.Label();
            this.divisionbtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(136, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 354);
            this.panel1.TabIndex = 0;
            // 
            // Additionbtn
            // 
            this.Additionbtn.AutoSize = true;
            this.Additionbtn.Font = new System.Drawing.Font("MV Boli", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Additionbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Additionbtn.Location = new System.Drawing.Point(12, 20);
            this.Additionbtn.Name = "Additionbtn";
            this.Additionbtn.Size = new System.Drawing.Size(175, 50);
            this.Additionbtn.TabIndex = 4;
            this.Additionbtn.Text = "Addition";
            this.Additionbtn.Click += new System.EventHandler(this.Additionbtn_Click);
            // 
            // Subtractionbtn
            // 
            this.Subtractionbtn.AutoSize = true;
            this.Subtractionbtn.Font = new System.Drawing.Font("MV Boli", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtractionbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Subtractionbtn.Location = new System.Drawing.Point(193, 20);
            this.Subtractionbtn.Name = "Subtractionbtn";
            this.Subtractionbtn.Size = new System.Drawing.Size(237, 50);
            this.Subtractionbtn.TabIndex = 5;
            this.Subtractionbtn.Text = "Subtraction";
            this.Subtractionbtn.Click += new System.EventHandler(this.Subtractionbtn_Click);
            // 
            // Multiplicationbtn
            // 
            this.Multiplicationbtn.AutoSize = true;
            this.Multiplicationbtn.Font = new System.Drawing.Font("MV Boli", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicationbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Multiplicationbtn.Location = new System.Drawing.Point(436, 20);
            this.Multiplicationbtn.Name = "Multiplicationbtn";
            this.Multiplicationbtn.Size = new System.Drawing.Size(273, 50);
            this.Multiplicationbtn.TabIndex = 6;
            this.Multiplicationbtn.Text = "Multiplication";
            this.Multiplicationbtn.Click += new System.EventHandler(this.Multiplicationbtn_Click);
            // 
            // divisionbtn
            // 
            this.divisionbtn.AutoSize = true;
            this.divisionbtn.Font = new System.Drawing.Font("MV Boli", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.divisionbtn.Location = new System.Drawing.Point(718, 20);
            this.divisionbtn.Name = "divisionbtn";
            this.divisionbtn.Size = new System.Drawing.Size(151, 50);
            this.divisionbtn.TabIndex = 7;
            this.divisionbtn.Text = "division";
            this.divisionbtn.Click += new System.EventHandler(this.divisionbtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(881, 467);
            this.Controls.Add(this.divisionbtn);
            this.Controls.Add(this.Multiplicationbtn);
            this.Controls.Add(this.Subtractionbtn);
            this.Controls.Add(this.Additionbtn);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Additionbtn;
        private System.Windows.Forms.Label Subtractionbtn;
        private System.Windows.Forms.Label Multiplicationbtn;
        private System.Windows.Forms.Label divisionbtn;
    }
}