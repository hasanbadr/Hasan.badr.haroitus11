namespace Hasan.badr.haroitus11
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
            label1 = new Label();
            Noppa01PB = new PictureBox();
            Noppa02PB = new PictureBox();
            HeitäBT = new Button();
            ((System.ComponentModel.ISupportInitialize)Noppa01PB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Noppa02PB).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 41);
            label1.TabIndex = 0;
            label1.Text = "Nopan heitto";
            // 
            // Noppa01PB
            // 
            Noppa01PB.Image = Properties.Resources.Nopanheitto1;
            Noppa01PB.Location = new Point(14, 53);
            Noppa01PB.Name = "Noppa01PB";
            Noppa01PB.Size = new Size(100, 95);
            Noppa01PB.SizeMode = PictureBoxSizeMode.Zoom;
            Noppa01PB.TabIndex = 1;
            Noppa01PB.TabStop = false;
            // 
            // Noppa02PB
            // 
            Noppa02PB.Image = Properties.Resources.Nopanheitto1;
            Noppa02PB.Location = new Point(135, 53);
            Noppa02PB.Name = "Noppa02PB";
            Noppa02PB.Size = new Size(100, 95);
            Noppa02PB.SizeMode = PictureBoxSizeMode.Zoom;
            Noppa02PB.TabIndex = 2;
            Noppa02PB.TabStop = false;
            // 
            // HeitäBT
            // 
            HeitäBT.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            HeitäBT.Location = new Point(14, 154);
            HeitäBT.Name = "HeitäBT";
            HeitäBT.Size = new Size(221, 53);
            HeitäBT.TabIndex = 3;
            HeitäBT.Text = "Heitä";
            HeitäBT.UseVisualStyleBackColor = true;
            HeitäBT.Click += HeitäBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 223);
            Controls.Add(HeitäBT);
            Controls.Add(Noppa02PB);
            Controls.Add(Noppa01PB);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Nopan Heito";
            ((System.ComponentModel.ISupportInitialize)Noppa01PB).EndInit();
            ((System.ComponentModel.ISupportInitialize)Noppa02PB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox Noppa01PB;
        private PictureBox Noppa02PB;
        private Button HeitäBT;
    }
}