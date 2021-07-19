
namespace Rock_Paper_Scissor
{
    partial class RPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPS));
            this.roc = new System.Windows.Forms.PictureBox();
            this.pap = new System.Windows.Forms.PictureBox();
            this.sci = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.roc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sci)).BeginInit();
            this.SuspendLayout();
            // 
            // roc
            // 
            this.roc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roc.Image = ((System.Drawing.Image)(resources.GetObject("roc.Image")));
            this.roc.Location = new System.Drawing.Point(0, 0);
            this.roc.Name = "roc";
            this.roc.Size = new System.Drawing.Size(100, 97);
            this.roc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roc.TabIndex = 0;
            this.roc.TabStop = false;
            this.roc.Click += new System.EventHandler(this.roc_Click);
            // 
            // pap
            // 
            this.pap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pap.Image = ((System.Drawing.Image)(resources.GetObject("pap.Image")));
            this.pap.Location = new System.Drawing.Point(142, 0);
            this.pap.Name = "pap";
            this.pap.Size = new System.Drawing.Size(100, 97);
            this.pap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pap.TabIndex = 1;
            this.pap.TabStop = false;
            this.pap.Click += new System.EventHandler(this.pap_Click);
            // 
            // sci
            // 
            this.sci.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sci.Image = ((System.Drawing.Image)(resources.GetObject("sci.Image")));
            this.sci.Location = new System.Drawing.Point(0, 139);
            this.sci.Name = "sci";
            this.sci.Size = new System.Drawing.Size(100, 97);
            this.sci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sci.TabIndex = 2;
            this.sci.TabStop = false;
            this.sci.Click += new System.EventHandler(this.sci_Click);
            // 
            // RPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(267, 264);
            this.Controls.Add(this.sci);
            this.Controls.Add(this.pap);
            this.Controls.Add(this.roc);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "RPS";
            this.Text = "RPS";
            this.Load += new System.EventHandler(this.RPS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox roc;
        private System.Windows.Forms.PictureBox pap;
        private System.Windows.Forms.PictureBox sci;
    }
}

