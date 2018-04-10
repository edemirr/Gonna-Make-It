namespace Gonna_Make_It
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.resim = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelx = new System.Windows.Forms.Label();
            this.labely = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).BeginInit();
            this.SuspendLayout();
            // 
            // resim
            // 
            this.resim.BackColor = System.Drawing.Color.Transparent;
            this.resim.Image = ((System.Drawing.Image)(resources.GetObject("resim.Image")));
            this.resim.Location = new System.Drawing.Point(113, 105);
            this.resim.Name = "resim";
            this.resim.Size = new System.Drawing.Size(25, 35);
            this.resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resim.TabIndex = 0;
            this.resim.TabStop = false;
            this.resim.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resim_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "X Location : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-2, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y Location :";
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.BackColor = System.Drawing.Color.Transparent;
            this.labelx.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelx.ForeColor = System.Drawing.Color.White;
            this.labelx.Location = new System.Drawing.Point(62, 15);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(0, 19);
            this.labelx.TabIndex = 5;
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.BackColor = System.Drawing.Color.Transparent;
            this.labely.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labely.ForeColor = System.Drawing.Color.White;
            this.labely.Location = new System.Drawing.Point(62, 41);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(0, 19);
            this.labely.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(336, 274);
            this.Controls.Add(this.labely);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resim);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "You can never catch Kenny";
            ((System.ComponentModel.ISupportInitialize)(this.resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox resim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labely;
    }
}