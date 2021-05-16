using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace TCPServer
{
    class DungeonCreation
    {

        List<XmlNode> SelectedEntities = new List<XmlNode>();
        public DungeonCreation(XmlElement xmlDungeon, int NumberOfRooms, int NumberOfMonsters, int DifficultyLevel, string Environment, string Location)
        {

            Random randomizedMonsters = new Random();
            Random randomizedChests = new Random();

            int TotalMonsters = randomizedMonsters.Next(1, (DifficultyLevel * 2) * NumberOfMonsters);
            int TotalChests = randomizedChests.Next(1, (DifficultyLevel * NumberOfRooms));



            XmlDocument doc = new XmlDocument();
            doc.Load(@"..\..\..\Configuration\EntityList.xml");

            XmlDocument doc2 = new XmlDocument();
            doc2.Load(@"..\..\..\Configuration\DungeonEncounters.xml");
            
            XmlNodeList listOfEntities = doc.SelectNodes("//Entities/Hostile/Entity");
            

            foreach (XmlNode node in listOfEntities)
            {
                XmlNodeList locations = node.SelectNodes("./Location/type");
                foreach (XmlNode xmlNode in locations)
                {
                    if(xmlNode.InnerText == Environment)
                    {
                        SelectedEntities.Add(node);
                    }
                    
                }
            }

            /*
            foreach (XmlNode xmlNode1 in SelectedEntities)
            {
                System.Diagnostics.Debug.WriteLine(xmlNode1.Attributes["name"].Value);
            }
            */

            //XmlElement dungeon = doc2.CreateElement("Dungeon" + DateTime.Now.ToString("MMddyyyyHHmm"));
            XmlNode dungeon = doc2.SelectSingleNode(@"/Dungeons/" + xmlDungeon.Name);
            XmlNode DungeonRoom = doc2.SelectSingleNode(@"/Dungeons/"+xmlDungeon.Name);

            foreach (XmlElement room in DungeonRoom)
            {
                System.Diagnostics.Debug.WriteLine(room.Name);
                Random rand = new Random();
                Random rand2 = new Random();
                int MonstersPerRoom = 0;
                int ChestsPerRoom = 0;
                if(TotalChests <= 0)
                {
                    ChestsPerRoom = 0;
                }
                else
                {
                    ChestsPerRoom = rand2.Next(1, DifficultyLevel +1);
                }
                if(TotalMonsters <= 0)
                {
                    MonstersPerRoom = 0;
                }
                else
                {
                    MonstersPerRoom = rand.Next(1, (int.Parse(room.GetAttribute("width"))* int.Parse(room.GetAttribute("length"))));
                }
                if (ChestsPerRoom < DifficultyLevel)
                {

                        Loot chest = new Loot();
                        room.AppendChild(chest.CreateChest(DifficultyLevel, doc2));

                }

                for (int i = 0; i < MonstersPerRoom; i++)
                {

                    //we have the total number...now we need to randomize which monster generates each time...
                    Random random = new Random();
                    int selectedEntity = random.Next(SelectedEntities.Count);
                    XmlNode node = SelectedEntities[selectedEntity];

                    int hp = 1;
                    int defense = 0;
                    int attack = 0;
                    int speed = 0;
                    int exp;
                    int energy = 1;
                    bool canBlock = false;
                    bool canDodge = false;
                    bool canRetaliate = false;

                    XmlElement entity = doc2.CreateElement("Entity");
                    XmlAttribute xmlName = doc2.CreateAttribute("name");
                    xmlName.Value = node.Attributes.GetNamedItem("name").Value;
                    entity.Attributes.Append(xmlName);
                    XmlAttribute xmlNumber = doc2.CreateAttribute("id");
                    xmlNumber.Value = i.ToString();
                    entity.Attributes.Append(xmlNumber);

                    room.AppendChild(entity);

                    foreach (XmlNode xmlNode in node)
                    {
                        if (xmlNode.Name == "Attack")
                        {
                            attack = StatA(Int32.Parse(xmlNode.Attributes["max"].Value), Int32.Parse(xmlNode.Attributes["min"].Value), DifficultyLevel);
                            XmlAttribute xmlAttack = doc2.CreateAttribute("attack");
                            xmlAttack.Value = attack.ToString();
                            entity.Attributes.Append(xmlAttack);


                        }
                        if (xmlNode.Name == "Defense")
                        {
                            defense = StatA(Int32.Parse(xmlNode.Attributes["max"].Value), Int32.Parse(xmlNode.Attributes["min"].Value), DifficultyLevel);
                            XmlAttribute xmlDefense = doc2.CreateAttribute("defense");
                            xmlDefense.Value = defense.ToString();
                            entity.Attributes.Append(xmlDefense);

                        }
                        if (xmlNode.Name == "HP")
                        {
                            hp = StatA(Int32.Parse(xmlNode.Attributes["max"].Value), Int32.Parse(xmlNode.Attributes["min"].Value), DifficultyLevel);
                            XmlAttribute xmlHP = doc2.CreateAttribute("HP");
                            xmlHP.Value = hp.ToString();
                            entity.Attributes.Append(xmlHP);

                        }
                        if (xmlNode.Name == "Energy")
                        {
                            energy = StatA(Int32.Parse(xmlNode.Attributes["max"].Value), Int32.Parse(xmlNode.Attributes["min"].Value), DifficultyLevel);
                            XmlAttribute xmlEnergy = doc2.CreateAttribute("Energy");
                            xmlEnergy.Value = energy.ToString();
                            entity.Attributes.Append(xmlEnergy);

                        }
                        if (xmlNode.Name == "Speed")
                        {
                            speed = StatA(Int32.Parse(xmlNode.Attributes["max"].Value), Int32.Parse(xmlNode.Attributes["min"].Value), DifficultyLevel);
                            XmlAttribute xmlSpeed = doc2.CreateAttribute("speed");
                            xmlSpeed.Value = speed.ToString();
                            entity.Attributes.Append(xmlSpeed);

                        }
                        if (xmlNode.Name == "CanBlock")
                        {
                            canBlock = StatB();
                            XmlAttribute xmlBlock = doc2.CreateAttribute("CanBlock");
                            xmlBlock.Value = canBlock.ToString();
                            entity.Attributes.Append(xmlBlock);
                        }
                        if (xmlNode.Name == "CanDodge")
                        {
                            canDodge = StatB();
                            XmlAttribute xmlDodge = doc2.CreateAttribute("CanDodge");
                            xmlDodge.Value = canDodge.ToString();
                            entity.Attributes.Append(xmlDodge);
                        }
                        if (xmlNode.Name == "CanRetaliate")
                        {
                            canRetaliate = StatB();
                            XmlAttribute xmlRetaliate = doc2.CreateAttribute("CanRetaliate");
                            xmlRetaliate.Value = canRetaliate.ToString();
                            entity.Attributes.Append(xmlRetaliate);
                        }


                        exp = ((attack + defense) / energy) + ((speed + attack) / DifficultyLevel);
                        if (canBlock) { exp += 1; }
                        if (canDodge) { exp += 1; }
                        if (canRetaliate) { exp += 1; }

                        XmlAttribute xmlExp = doc2.CreateAttribute("exp");
                        xmlExp.Value = Math.Abs(exp).ToString();
                        entity.Attributes.Append(xmlExp);

                    }





                }

                TotalMonsters = TotalMonsters - MonstersPerRoom;
            }

            

            XmlNode root = doc2.DocumentElement;
            root.AppendChild(dungeon);



            doc2.Save(@"..\..\..\Configuration\DungeonEncounters.xml");
        }

        /*
         * Currently:
         * List of Entities -> Number of monsters -> Setting Which Monster Based on Environment
         * 
         * Needed:
         * Per Room -> Number of Etities
         * 
         * Figured....
         * 
         * Per Room Designation...then Randomize the number PER room...remove from total remaining...and continue though each room...
         * 
         * 
         */

        public int StatA(int maxInt, int minInt, int difficulty)
        {
            int statAttack = 0;
            Random number = new Random();
            statAttack = number.Next(minInt, maxInt + 1);
            statAttack = statAttack * difficulty;

            return statAttack;
        }

        public bool StatB()
        {
            bool canBeBlocked = false;
            var random = new Random();
            canBeBlocked = random.Next(2) == 1;
            return canBeBlocked;
        }


    }
}
