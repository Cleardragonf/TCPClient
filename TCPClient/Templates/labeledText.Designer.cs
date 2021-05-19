
namespace TCPClient.Templates
{
    partial class labeledText
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
            this.lbl = new System.Windows.Forms.Label();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(4, 5);
            this.lbl.Margin = new System.Windows.Forms.Padding(5);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(66, 20);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "martines";
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(95, 3);
            this.txtBx.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(125, 27);
            this.txtBx.TabIndex = 3;
            // 
            // labeledText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtBx);
            this.Name = "labeledText";
            this.Size = new System.Drawing.Size(223, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl;
        public System.Windows.Forms.TextBox txtBx;
    }
}
