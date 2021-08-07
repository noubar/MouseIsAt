namespace MousIsAt
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ticker = new System.Windows.Forms.Timer(this.components);
            this.labelx = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.locx = new System.Windows.Forms.Label();
            this.locy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ticker
            // 
            this.ticker.Tick += new System.EventHandler(this.ticker_Tick);
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelx.Location = new System.Drawing.Point(12, 9);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(39, 26);
            this.labelx.TabIndex = 0;
            this.labelx.Text = "X: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y: ";
            // 
            // locx
            // 
            this.locx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locx.AutoSize = true;
            this.locx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locx.Location = new System.Drawing.Point(43, 11);
            this.locx.Name = "locx";
            this.locx.Size = new System.Drawing.Size(60, 24);
            this.locx.TabIndex = 2;
            this.locx.Text = "label1";
            // 
            // locy
            // 
            this.locy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locy.AutoSize = true;
            this.locy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locy.Location = new System.Drawing.Point(43, 56);
            this.locy.Name = "locy";
            this.locy.Size = new System.Drawing.Size(60, 24);
            this.locy.TabIndex = 3;
            this.locy.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(138, 89);
            this.Controls.Add(this.locy);
            this.Controls.Add(this.locx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MouseIsAt";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer ticker;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label locx;
        private System.Windows.Forms.Label locy;
    }
}

