
namespace TCPServer
{
    partial class DMDungeonWindow
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grpbxDungeonCreation = new System.Windows.Forms.GroupBox();
            this.btnCreateDungeon = new System.Windows.Forms.Button();
            this.drpDungeonLocation = new System.Windows.Forms.ComboBox();
            this.drpOutsideEnviornment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDifficultyLevel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumberOfMonsters = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpbxCreateRooms = new System.Windows.Forms.GroupBox();
            this.txtRemainingRooms = new System.Windows.Forms.TextBox();
            this.lblRemainingRooms = new System.Windows.Forms.Label();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.txtRoomLength = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRoomWidth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpbxDungeonCreation.SuspendLayout();
            this.grpbxCreateRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 51);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(160, 51);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // grpbxDungeonCreation
            // 
            this.grpbxDungeonCreation.Controls.Add(this.btnCreateDungeon);
            this.grpbxDungeonCreation.Controls.Add(this.drpDungeonLocation);
            this.grpbxDungeonCreation.Controls.Add(this.drpOutsideEnviornment);
            this.grpbxDungeonCreation.Controls.Add(this.label5);
            this.grpbxDungeonCreation.Controls.Add(this.label4);
            this.grpbxDungeonCreation.Controls.Add(this.txtDifficultyLevel);
            this.grpbxDungeonCreation.Controls.Add(this.label3);
            this.grpbxDungeonCreation.Controls.Add(this.txtNumberOfMonsters);
            this.grpbxDungeonCreation.Controls.Add(this.label2);
            this.grpbxDungeonCreation.Location = new System.Drawing.Point(12, 126);
            this.grpbxDungeonCreation.Name = "grpbxDungeonCreation";
            this.grpbxDungeonCreation.Size = new System.Drawing.Size(262, 202);
            this.grpbxDungeonCreation.TabIndex = 2;
            this.grpbxDungeonCreation.TabStop = false;
            this.grpbxDungeonCreation.Text = "Create A Dungeon";
            this.grpbxDungeonCreation.Visible = false;
            // 
            // btnCreateDungeon
            // 
            this.btnCreateDungeon.Location = new System.Drawing.Point(91, 163);
            this.btnCreateDungeon.Name = "btnCreateDungeon";
            this.btnCreateDungeon.Size = new System.Drawing.Size(75, 23);
            this.btnCreateDungeon.TabIndex = 11;
            this.btnCreateDungeon.Text = "Create";
            this.btnCreateDungeon.UseVisualStyleBackColor = true;
            this.btnCreateDungeon.Click += new System.EventHandler(this.btnCreateDungeon_Click);
            // 
            // drpDungeonLocation
            // 
            this.drpDungeonLocation.FormattingEnabled = true;
            this.drpDungeonLocation.Location = new System.Drawing.Point(131, 134);
            this.drpDungeonLocation.Name = "drpDungeonLocation";
            this.drpDungeonLocation.Size = new System.Drawing.Size(94, 23);
            this.drpDungeonLocation.TabIndex = 10;
            // 
            // drpOutsideEnviornment
            // 
            this.drpOutsideEnviornment.FormattingEnabled = true;
            this.drpOutsideEnviornment.Location = new System.Drawing.Point(131, 105);
            this.drpOutsideEnviornment.Name = "drpOutsideEnviornment";
            this.drpOutsideEnviornment.Size = new System.Drawing.Size(94, 23);
            this.drpOutsideEnviornment.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dungeon Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Outside Environment";
            // 
            // txtDifficultyLevel
            // 
            this.txtDifficultyLevel.Location = new System.Drawing.Point(173, 76);
            this.txtDifficultyLevel.Name = "txtDifficultyLevel";
            this.txtDifficultyLevel.Size = new System.Drawing.Size(25, 23);
            this.txtDifficultyLevel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Difficulty Level";
            // 
            // txtNumberOfMonsters
            // 
            this.txtNumberOfMonsters.Location = new System.Drawing.Point(173, 47);
            this.txtNumberOfMonsters.Name = "txtNumberOfMonsters";
            this.txtNumberOfMonsters.Size = new System.Drawing.Size(25, 23);
            this.txtNumberOfMonsters.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Monsters";
            // 
            // grpbxCreateRooms
            // 
            this.grpbxCreateRooms.Controls.Add(this.txtRemainingRooms);
            this.grpbxCreateRooms.Controls.Add(this.lblRemainingRooms);
            this.grpbxCreateRooms.Controls.Add(this.btnCreateRoom);
            this.grpbxCreateRooms.Controls.Add(this.txtRoomLength);
            this.grpbxCreateRooms.Controls.Add(this.label8);
            this.grpbxCreateRooms.Controls.Add(this.txtRoomWidth);
            this.grpbxCreateRooms.Controls.Add(this.label9);
            this.grpbxCreateRooms.Location = new System.Drawing.Point(280, 12);
            this.grpbxCreateRooms.Name = "grpbxCreateRooms";
            this.grpbxCreateRooms.Size = new System.Drawing.Size(256, 202);
            this.grpbxCreateRooms.TabIndex = 12;
            this.grpbxCreateRooms.TabStop = false;
            this.grpbxCreateRooms.Text = "Number of Rooms in the Dungeon";
            this.grpbxCreateRooms.Visible = false;
            // 
            // txtRemainingRooms
            // 
            this.txtRemainingRooms.Location = new System.Drawing.Point(118, 21);
            this.txtRemainingRooms.Name = "txtRemainingRooms";
            this.txtRemainingRooms.Size = new System.Drawing.Size(44, 23);
            this.txtRemainingRooms.TabIndex = 13;
            // 
            // lblRemainingRooms
            // 
            this.lblRemainingRooms.AutoSize = true;
            this.lblRemainingRooms.Location = new System.Drawing.Point(6, 26);
            this.lblRemainingRooms.Name = "lblRemainingRooms";
            this.lblRemainingRooms.Size = new System.Drawing.Size(70, 15);
            this.lblRemainingRooms.TabIndex = 12;
            this.lblRemainingRooms.Text = "How many?";
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(58, 166);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(75, 23);
            this.btnCreateRoom.TabIndex = 11;
            this.btnCreateRoom.Text = "Create";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // txtRoomLength
            // 
            this.txtRoomLength.Enabled = false;
            this.txtRoomLength.Location = new System.Drawing.Point(118, 79);
            this.txtRoomLength.Name = "txtRoomLength";
            this.txtRoomLength.Size = new System.Drawing.Size(44, 23);
            this.txtRoomLength.TabIndex = 5;
            this.txtRoomLength.Text = "1";
            this.txtRoomLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Length";
            // 
            // txtRoomWidth
            // 
            this.txtRoomWidth.Enabled = false;
            this.txtRoomWidth.Location = new System.Drawing.Point(118, 50);
            this.txtRoomWidth.Name = "txtRoomWidth";
            this.txtRoomWidth.Size = new System.Drawing.Size(44, 23);
            this.txtRoomWidth.TabIndex = 3;
            this.txtRoomWidth.Text = "1";
            this.txtRoomWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Width";
            // 
            // DMDungeonWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 373);
            this.Controls.Add(this.grpbxCreateRooms);
            this.Controls.Add(this.grpbxDungeonCreation);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnCreate);
            this.Name = "DMDungeonWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f";
            this.Load += new System.EventHandler(this.DMDungeonWindow_Load);
            this.grpbxDungeonCreation.ResumeLayout(false);
            this.grpbxDungeonCreation.PerformLayout();
            this.grpbxCreateRooms.ResumeLayout(false);
            this.grpbxCreateRooms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox grpbxDungeonCreation;
        private System.Windows.Forms.Button btnCreateDungeon;
        private System.Windows.Forms.ComboBox drpDungeonLocation;
        private System.Windows.Forms.ComboBox drpOutsideEnviornment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDifficultyLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumberOfMonsters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRoomWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRoomLength;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.GroupBox grpbxCreateRooms;
        private System.Windows.Forms.TextBox txtRemainingRooms;
        private System.Windows.Forms.Label lblRemainingRooms;
    }
}

