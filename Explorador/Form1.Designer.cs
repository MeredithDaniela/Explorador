namespace Explorador
{
    partial class Form1
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
            Combo = new ComboBox();
            picbox = new PictureBox();
            label1 = new Label();
            link = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picbox).BeginInit();
            SuspendLayout();
            // 
            // Combo
            // 
            Combo.FormattingEnabled = true;
            Combo.Location = new Point(12, 32);
            Combo.Name = "Combo";
            Combo.Size = new Size(577, 23);
            Combo.TabIndex = 0;
            Combo.SelectedIndexChanged += Combo_SelectedIndexChanged;
            // 
            // picbox
            // 
            picbox.Location = new Point(12, 81);
            picbox.Name = "picbox";
            picbox.Size = new Size(279, 305);
            picbox.TabIndex = 1;
            picbox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 81);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // link
            // 
            link.AutoSize = true;
            link.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            link.Location = new Point(269, 406);
            link.Name = "link";
            link.Size = new Size(72, 19);
            link.TabIndex = 3;
            link.TabStop = true;
            link.Text = "linkLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(link);
            Controls.Add(label1);
            Controls.Add(picbox);
            Controls.Add(Combo);
            Name = "Form1";
            Text = "Selector de funciones";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Combo;
        private PictureBox picbox;
        private Label label1;
        private LinkLabel link;
    }
}
