namespace Tic_Tac_Toe
{
    partial class Select_area_form
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
            this.btn3x3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btn3x3
            // 
            this.btn3x3.Location = new System.Drawing.Point(156, 192);
            this.btn3x3.Name = "btn3x3";
            this.btn3x3.Size = new System.Drawing.Size(75, 23);
            this.btn3x3.TabIndex = 0;
            this.btn3x3.Text = "button1";
            this.btn3x3.UseVisualStyleBackColor = true;
            this.btn3x3.Click += new System.EventHandler(this.button1_Click);
            // 
            // Select_area_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 301);
            this.Controls.Add(this.btn3x3);
            this.Name = "Select_area_form";
            this.Text = "duz";
            this.Load += new System.EventHandler(this.Select_area_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn3x3;
    }
}

