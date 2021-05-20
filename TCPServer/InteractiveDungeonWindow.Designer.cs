
namespace TCPServer
{
    partial class InteractiveDungeonWindow
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
            this.pnlDungeonBoard = new System.Windows.Forms.Panel();
            this.pnlCommandWindow = new System.Windows.Forms.Panel();
            this.lblMoveEntity = new System.Windows.Forms.Label();
            this.bntMoveEntity = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDoorCreated = new System.Windows.Forms.Label();
            this.btnCreateDoors = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.lblRemainingRooms = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMouseLocation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCommandWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDungeonBoard
            // 
            this.pnlDungeonBoard.Location = new System.Drawing.Point(13, 13);
            this.pnlDungeonBoard.Name = "pnlDungeonBoard";
            this.pnlDungeonBoard.Size = new System.Drawing.Size(1379, 785);
            this.pnlDungeonBoard.TabIndex = 0;
            this.pnlDungeonBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.picGrid_Paint);
            this.pnlDungeonBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picGrid_MouseClick);
            this.pnlDungeonBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDungeonBoard_MouseDown);
            this.pnlDungeonBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picGrid_MouseMove);
            this.pnlDungeonBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDungeonBoard_MouseUp);
            // 
            // pnlCommandWindow
            // 
            this.pnlCommandWindow.Controls.Add(this.lblMoveEntity);
            this.pnlCommandWindow.Controls.Add(this.bntMoveEntity);
            this.pnlCommandWindow.Controls.Add(this.label5);
            this.pnlCommandWindow.Controls.Add(this.lblDoorCreated);
            this.pnlCommandWindow.Controls.Add(this.btnCreateDoors);
            this.pnlCommandWindow.Controls.Add(this.label3);
            this.pnlCommandWindow.Controls.Add(this.btnCreateRoom);
            this.pnlCommandWindow.Controls.Add(this.lblRemainingRooms);
            this.pnlCommandWindow.Controls.Add(this.label2);
            this.pnlCommandWindow.Controls.Add(this.lblMouseLocation);
            this.pnlCommandWindow.Controls.Add(this.label1);
            this.pnlCommandWindow.Location = new System.Drawing.Point(1407, 13);
            this.pnlCommandWindow.Name = "pnlCommandWindow";
            this.pnlCommandWindow.Size = new System.Drawing.Size(277, 784);
            this.pnlCommandWindow.TabIndex = 1;
            // 
            // lblMoveEntity
            // 
            this.lblMoveEntity.AutoSize = true;
            this.lblMoveEntity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblMoveEntity.Location = new System.Drawing.Point(104, 353);
            this.lblMoveEntity.Name = "lblMoveEntity";
            this.lblMoveEntity.Size = new System.Drawing.Size(52, 15);
            this.lblMoveEntity.TabIndex = 10;
            this.lblMoveEntity.Text = "disabled";
            // 
            // bntMoveEntity
            // 
            this.bntMoveEntity.Location = new System.Drawing.Point(165, 349);
            this.bntMoveEntity.Name = "bntMoveEntity";
            this.bntMoveEntity.Size = new System.Drawing.Size(103, 23);
            this.bntMoveEntity.TabIndex = 9;
            this.bntMoveEntity.Text = "Move Entity";
            this.bntMoveEntity.UseVisualStyleBackColor = true;
            this.bntMoveEntity.Click += new System.EventHandler(this.bntMoveEntity_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Move Entity";
            // 
            // lblDoorCreated
            // 
            this.lblDoorCreated.AutoSize = true;
            this.lblDoorCreated.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDoorCreated.Location = new System.Drawing.Point(104, 324);
            this.lblDoorCreated.Name = "lblDoorCreated";
            this.lblDoorCreated.Size = new System.Drawing.Size(52, 15);
            this.lblDoorCreated.TabIndex = 7;
            this.lblDoorCreated.Text = "disabled";
            // 
            // btnCreateDoors
            // 
            this.btnCreateDoors.Location = new System.Drawing.Point(165, 320);
            this.btnCreateDoors.Name = "btnCreateDoors";
            this.btnCreateDoors.Size = new System.Drawing.Size(103, 23);
            this.btnCreateDoors.TabIndex = 6;
            this.btnCreateDoors.Text = "Create Door";
            this.btnCreateDoors.UseVisualStyleBackColor = true;
            this.btnCreateDoors.Click += new System.EventHandler(this.btnCreateDoors_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Create Doors";
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(165, 34);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(103, 23);
            this.btnCreateRoom.TabIndex = 4;
            this.btnCreateRoom.Text = "Create Room";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // lblRemainingRooms
            // 
            this.lblRemainingRooms.AutoSize = true;
            this.lblRemainingRooms.Location = new System.Drawing.Point(183, 38);
            this.lblRemainingRooms.Name = "lblRemainingRooms";
            this.lblRemainingRooms.Size = new System.Drawing.Size(0, 15);
            this.lblRemainingRooms.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Create Rooms";
            // 
            // lblMouseLocation
            // 
            this.lblMouseLocation.AutoSize = true;
            this.lblMouseLocation.Location = new System.Drawing.Point(116, 10);
            this.lblMouseLocation.Name = "lblMouseLocation";
            this.lblMouseLocation.Size = new System.Drawing.Size(0, 15);
            this.lblMouseLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mouse\'s Location";
            // 
            // InteractiveDungeonWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 810);
            this.Controls.Add(this.pnlCommandWindow);
            this.Controls.Add(this.pnlDungeonBoard);
            this.DoubleBuffered = true;
            this.Name = "InteractiveDungeonWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DM Board";
            this.Load += new System.EventHandler(this.InteractiveDungeonWindow_Load);
            this.pnlCommandWindow.ResumeLayout(false);
            this.pnlCommandWindow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDungeonBoard;
        private System.Windows.Forms.Panel pnlCommandWindow;
        private System.Windows.Forms.Label lblMouseLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateRoom;
        private System.Windows.Forms.Label lblRemainingRooms;
        private System.Windows.Forms.Button btnCreateDoors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDoorCreated;
        private System.Windows.Forms.Label lblMoveEntity;
        private System.Windows.Forms.Button bntMoveEntity;
        private System.Windows.Forms.Label label5;
    }
}

