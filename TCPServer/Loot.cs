using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace TCPServer
{
    class Loot
    {

        public List<XmlNode> listOfWeapons = new List<XmlNode>();
        internal XmlElement CreateChest(int difficultyLevel, XmlDocument doc)
        {
            XmlElement xmlChest = doc.CreateElement("Chest");
            XmlAttribute exp = doc.CreateAttribute("exp");
            exp.Value = ((difficultyLevel * difficultyLevel) / 2).ToString();
            xmlChest.Attributes.Append(exp);

            XmlElement contents = doc.CreateElement("contents");
            xmlChest.AppendChild(contents);

            XmlDocument lootDoc = new XmlDocument();
            lootDoc.Load(@"..\..\..\Configuration\Loot\ChestLoot.xml");

            XmlDocument materialDoc = new XmlDocument();
            materialDoc.Load(@"..\..\..\Configuration\BaseMaterial.xml");

            XmlNode lootTypes = lootDoc.SelectSingleNode("/Loot");

            List<String> listOfLootTypes = new List<string>(new string[] { "Weapons", "Money", "Books" }); //"Material","Items",
            for (int i = 0; i < difficultyLevel; i++)
            {
                Random rand = new Random();
                int selectIndex = rand.Next(0, listOfLootTypes.Count);
                string selectedItem = listOfLootTypes[selectIndex];
                if (selectedItem == "Weapons")
                {
                    XmlNode weapons = materialDoc.SelectSingleNode("/Materials/Weapons");
                    foreach (XmlNode weapon in weapons)
                    {
                        listOfWeapons.Add(weapon);
                    }
                    Random random = new Random();
                    int weaponIndex = random.Next(1, listOfWeapons.Count);

                    XmlNode selectedWeapon = listOfWeapons[weaponIndex];

                    XmlElement xmlWeapon = doc.CreateElement("weapon");


                    List<String> typesOfWeapons = new List<string>(new string[] { "Sword", "Dagger", "WarHammer", "Saber", "Pike", "Mace", "Bow", "Arrow", "Halberd" });
                    int typeIndex = random.Next(1, typesOfWeapons.Count);
                    XmlAttribute xmlname = doc.CreateAttribute("name");
                    xmlname.Value = selectedWeapon.Attributes["name"].Value.ToString() + " " + typesOfWeapons[typeIndex].ToString();
                    xmlWeapon.Attributes.Append(xmlname);
                    
                    if (typesOfWeapons[typeIndex].Contains("Arrow"))
                    {
                        Random random1 = new Random();
                        int numberOfArrows = random1.Next(1, 100);
                        XmlAttribute xmlAmount = doc.CreateAttribute("amount");
                        xmlAmount.Value = numberOfArrows.ToString();
                        xmlWeapon.Attributes.Append(xmlAmount);
                    }
                    
                    XmlAttribute xmlAttack = doc.CreateAttribute("attack");
                    //start setting the attack value below then the durability... then make sure to append it to the xmlChest...
                    xmlAttack.Value = random.Next(int.Parse(selectedWeapon.Attributes["min_attack"].Value), int.Parse(selectedWeapon.Attributes["max_attack"].Value)).ToString();
                    xmlWeapon.Attributes.Append(xmlAttack);
                    XmlAttribute xmlDurability = doc.CreateAttribute("durability");
                    xmlDurability.Value = random.Next(int.Parse(selectedWeapon.Attributes["min_durability"].Value), int.Parse(selectedWeapon.Attributes["max_durability"].Value)).ToString();
                    xmlWeapon.Attributes.Append(xmlDurability);

                    contents.AppendChild(xmlWeapon);
                }
                else if (selectedItem == "Money")
                {
                    List<String> money = new List<string>(new string[] { "Copper", "silver", "Electrum", "Gold", "Copper", "silver", "Electrum", "Gold", "Platinum", "Copper", "silver", "Electrum", "Copper", "silver", "Copper" });
                    Random randmoney = new Random();
                    Random randAmount = new Random();
                    int moneyType = randmoney.Next(1, money.Count);
                    int moneyAmount = randAmount.Next(1, 101);

                    XmlElement moneyContent = doc.CreateElement("money");
                    XmlAttribute amount = doc.CreateAttribute("Amount");
                    amount.Value = moneyAmount + " " + money[moneyType];
                    moneyContent.Attributes.Append(amount);

                    contents.AppendChild(moneyContent);

                }
                else if (selectedItem == "Books")
                {
                    XmlDocument bookDoc = new XmlDocument();
                    bookDoc.Load(@"..\..\..\Configuration\Loot\Books.xml");

                    XmlNode TypesOfBooks = bookDoc.SelectSingleNode("/Books");
                    List<XmlNode> ListOfBooks = new List<XmlNode>();
                    foreach (XmlNode node in TypesOfBooks)
                    {
                        ListOfBooks.Add(node);
                    }




                    Random random = new Random();
                    int bookindex = random.Next(1, ListOfBooks.Count);
                    XmlNode book = ListOfBooks[bookindex];



                    XmlElement bookContent = doc.CreateElement("book");
                    XmlAttribute bookName = doc.CreateAttribute("name");
                    bookName.Value = book.Attributes["name"].Value;
                    bookContent.Attributes.Append(bookName);

                    if (book.Attributes["name"].Value.Contains("experience"))
                    {
                        XmlAttribute bookExp = doc.CreateAttribute("exp");
                        bookExp.Value = (difficultyLevel * 25).ToString();
                        bookContent.Attributes.Append(bookExp);
                    }
                    
                    contents.AppendChild(bookContent);
                }
                else if (selectedItem == "Items")
                {

                }
                else if (selectedItem == "Material")
                {

                }
                xmlChest.AppendChild(contents);
            }
            return xmlChest;
        }
    }
}
