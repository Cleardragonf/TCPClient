
namespace TCPClient
{
    partial class Skill
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSkillName = new System.Windows.Forms.Label();
            this.lblMastery = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblSkillName);
            this.flowLayoutPanel1.Controls.Add(this.lblMastery);
            this.flowLayoutPanel1.Controls.Add(this.lblLevel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(424, 33);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblSkillName
            // 
            this.lblSkillName.AutoSize = true;
            this.lblSkillName.Location = new System.Drawing.Point(3, 0);
            this.lblSkillName.Name = "lblSkillName";
            this.lblSkillName.Size = new System.Drawing.Size(93, 20);
            this.lblSkillName.TabIndex = 0;
            this.lblSkillName.Text = "lblSkillName";
            // 
            // lblMastery
            // 
            this.lblMastery.AutoSize = true;
            this.lblMastery.Location = new System.Drawing.Point(102, 0);
            this.lblMastery.Name = "lblMastery";
            this.lblMastery.Size = new System.Drawing.Size(78, 20);
            this.lblMastery.TabIndex = 1;
            this.lblMastery.Text = "lblMastery";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(186, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(60, 20);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "lblLevel";
            // 
            // Skill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Skill";
            this.Size = new System.Drawing.Size(424, 33);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label lblSkillName;
        public System.Windows.Forms.Label lblMastery;
        public System.Windows.Forms.Label lblLevel;
    }
}
