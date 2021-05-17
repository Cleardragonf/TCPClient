using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TCPServer
{
    public partial class DMDungeonWindow : Form
    {
        public DMDungeonWindow()
        {
            InitializeComponent();
            this.btnCreateDungeon.Left = (this.grpbxDungeonCreation.Width - this.btnCreateDungeon.Width) / 2;
            
            doc.Load(@"..\..\..\Configuration\DungeonEncounters.xml");
            xmlDungeon = doc.CreateElement("Dungeon" + DateTime.Now.ToString("MMddyyyyHHmmss"));
            root = doc.DocumentElement;
            
        }

        public int NumberOfRooms;
        public XmlDocument doc = new XmlDocument();
        public XmlElement xmlDungeon;
        public XmlNode root;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            btnCreate.Visible = false;
            btnLoad.Visible = false;
            grpbxCreateRooms.Visible = true;
            System.Diagnostics.Debug.WriteLine("Hello");
        }

        private void btnCreateDungeon_Click(object sender, EventArgs e)
        {
            DungeonCreation dungeon = new DungeonCreation(xmlDungeon, NumberOfRooms, Int32.Parse(this.txtNumberOfMonsters.Text), Int32.Parse(this.txtDifficultyLevel.Text), this.drpOutsideEnviornment.Text, this.drpDungeonLocation.Text);
            grpbxDungeonCreation.Visible = false;
            grpbxCreateRooms.Visible = true;
            this.Close();
            DMDungeonWindow form = new DMDungeonWindow();
            form.Show();
        }

        private void DMDungeonWindow_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"..\..\..\Configuration\config.xml");
            XmlNodeList listOfEnvironments = doc.SelectNodes("//Config/Environments/Environment");
            foreach (XmlNode node in listOfEnvironments)
            {
                System.Diagnostics.Debug.WriteLine(node.InnerText);
                System.Diagnostics.Debug.WriteLine(node.Attributes["name"].Value);
                this.drpOutsideEnviornment.Items.Add(node.Attributes["name"].Value);
            }
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtRemainingRooms.Text))
            {
                //try passing dungeon to find which dungeon to looop through 
                


                txtRoomLength.Enabled = true;
                txtRoomWidth.Enabled = true;
                txtRemainingRooms.Enabled = false;
                NumberOfRooms = int.Parse(txtRemainingRooms.Text);
                grpbxCreateRooms.Text = "Create the Rooms";
                if (NumberOfRooms != 1)
                {
                    XmlElement xmlRoom = doc.CreateElement("Room_" + NumberOfRooms);
                    XmlAttribute xmlRoomWidth = doc.CreateAttribute("width");
                    XmlAttribute xmlRoomLength = doc.CreateAttribute("length");
                    xmlRoomWidth.Value = txtRoomWidth.Text;
                    xmlRoomLength.Value = txtRoomLength.Text;
                    xmlRoom.Attributes.Append(xmlRoomLength);
                    xmlRoom.Attributes.Append(xmlRoomWidth);
                    xmlDungeon.AppendChild(xmlRoom);
                    
                    NumberOfRooms -= 1;
                    txtRemainingRooms.Text = NumberOfRooms.ToString();
                    //create a room with the parameters of width and length...give it a value...then start again...
                    
                    root.AppendChild(xmlDungeon);
                    doc.Save(@"..\..\..\Configuration\DungeonEncounters.xml");
                }
                else
                {

                    doc.Save(@"..\..\..\Configuration\DungeonEncounters.xml");
                    grpbxCreateRooms.Visible = false;
                    grpbxDungeonCreation.Visible = true;

                    //create the final room with width and length...then move on to number of monsters... etc
                }


            }



        }

        public XmlNode Dungeon;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            XmlNode listOfDungeons = doc.SelectSingleNode(@"/Dungeons");
            foreach (XmlNode node in listOfDungeons)
            {
                drpbxLoadDungeon.Items.Add(node.Name);
            }
            btnCreate.Visible = false;
            btnLoad.Visible = false;
            drpbxLoadDungeon.Visible = true;
            btnOk.Visible = true;
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Dungeon = doc.SelectSingleNode(@"/Dungeons/" + drpbxLoadDungeon.SelectedItem.ToString());
            this.Close();
            InteractiveDungeonWindow form = new InteractiveDungeonWindow(Dungeon);
            form.Show();
        }
    }
}
