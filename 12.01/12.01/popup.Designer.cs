
namespace _12._01
{
    partial class popup
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
            this.megoldasrich = new System.Windows.Forms.RichTextBox();
            this.feladatbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // megoldasrich
            // 
            this.megoldasrich.Location = new System.Drawing.Point(12, 38);
            this.megoldasrich.Name = "megoldasrich";
            this.megoldasrich.Size = new System.Drawing.Size(776, 354);
            this.megoldasrich.TabIndex = 13;
            this.megoldasrich.Text = "";
            // 
            // feladatbox
            // 
            this.feladatbox.Location = new System.Drawing.Point(12, 12);
            this.feladatbox.Name = "feladatbox";
            this.feladatbox.Size = new System.Drawing.Size(776, 20);
            this.feladatbox.TabIndex = 12;
            // 
            // popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.megoldasrich);
            this.Controls.Add(this.feladatbox);
            this.Name = "popup";
            this.Text = "popup";
            this.Load += new System.EventHandler(this.popup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox megoldasrich;
        private System.Windows.Forms.TextBox feladatbox;
    }
}