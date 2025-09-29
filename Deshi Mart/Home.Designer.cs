namespace Deshi_Mart
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            SuspendLayout();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 62F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 231, 151);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1252, 673);
            Font = new Font("Javanese Text", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 10, 6, 10);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deshi Mart";
            WindowState = FormWindowState.Minimized;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
