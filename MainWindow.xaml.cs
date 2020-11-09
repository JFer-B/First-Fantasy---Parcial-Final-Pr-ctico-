using FIrstFantasyGame.Classes;
using FIrstFantasyGame.Classes.Equippables;
using FIrstFantasyGame.Classes.Equippables.Armament;
using FIrstFantasyGame.Classes.Subject;
using FIrstFantasyGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FIrstFantasyGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<Character> characters = new List<Character>();
        
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            Character mycharacter;
            string chName = txtChName.Text;
            string class_option = cboxCharacter.Text;

            switch (class_option)
            {
                case "Wizard":
                    mycharacter = new Wizard(chName);
                    break;
                case "Rogue":
                    mycharacter = new Rogue(chName);
                    break;
                case "Cleric":
                    mycharacter = new Cleric(chName);
                    break;
                case "Fighter":
                    mycharacter = new Fighter(chName);
                    break;
                default:
                    mycharacter = null;
                    MessageBox.Show("You MUST select a class");
                    break;
            }
            
            if(mycharacter != null)
            {
                Weapon myweapon;
                string wpName = cboxWeapon.Text;
                string weapon_option = wpName;

                switch (weapon_option)
                {
                    case "Axe":
                        myweapon = new Axe(wpName, "Common");
                        break;
                    case "Bow":
                        myweapon = new Bow(wpName, "Common");
                        break;
                    case "Dagger":
                        myweapon = new Dagger(wpName, "Common");
                        break;
                    case "Spear":
                        myweapon = new Spear(wpName, "Common");
                        break;
                    case "Sword":
                        myweapon = new Sword(wpName, "Common");
                        break;
                    default:
                        myweapon = null;
                        MessageBox.Show("You MUST select a WEAPON");
                        break;
                }

                if(myweapon != null)
                {
                    mycharacter.Armament = myweapon;

                    if(cboxArmor.Text != "-Select an Armor-")
                    {
                        Armor myarmor = new Armor(cboxArmor.Text, "Common");
                        mycharacter.Suit = myarmor;

                        characters.Add(mycharacter);

                        cboxCharacters.Items.Add(mycharacter.Name);

                        txtChName.Text = "";
                        cboxCharacter.Text = "-Select a Class-";
                        cboxWeapon.Text = "-Select a Weapon-";
                        cboxArmor.Text = "-Select an Armor-";

                    }
                    else
                    {
                        MessageBox.Show("You MUST select an ARMOR");
                    }
                }

                
            }


        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            string info = "";
            foreach (Character c in characters)
            {
                if (c.Name == cboxCharacters.Text)
                {
                    info = c.ShowInfo();
                    lbCharacter.Content = c.Name;
                }
            }
            cboxCharacters.Text = "-Select a Character-";
            if (info != "")
            {
                txtOutput.Text = info;
            }
            else
            {
                MessageBox.Show("You MUST select a CHARACTER");
            }

        }

        private void btnSlcInventory_Click(object sender, RoutedEventArgs e)
        {
            cboxShowInventory.Items.Clear();
            cboxShowInventory.Items.Add("-Select an Object -");
            cboxShowInventory.Text = "-Select an Object-";

            string option = cboxInventory.Text;
            foreach (Character c in characters)
            {
                if (c.Name == (string)lbCharacter.Content)
                {
                    switch (option)
                    {
                        case "Weapons":
                            foreach(Weapon w in c.WeaponInventory)
                            {
                                cboxShowInventory.Items.Add(w.Name);
                            }
                            break;
                        case "Armors":
                            foreach (Armor a in c.ArmorInventory)
                            {
                                cboxShowInventory.Items.Add(a.Name);
                            }
                            break;
                        case "Potions":
                            foreach (Potion p in c.PotionInventory)
                            {
                                cboxShowInventory.Items.Add(p.Name);
                            }
                            break;
                    }
                }
            }
           
        }

        private void btnSlcObject_Click(object sender, RoutedEventArgs e)
        {
            string option = cboxInventory.Text;
            foreach (Character c in characters)
            {
                if (c.Name == (string)lbCharacter.Content)
                {
                    switch (option)
                    {
                        case "Weapons":
                            foreach (Weapon w in c.WeaponInventory)
                            {
                                if(w.Name == cboxShowInventory.Text)
                                {
                                    txtOutput.Text = w.ShowInfo();
                                    break;
                                }
                                
                            }
                            break;
                        case "Armors":
                            foreach (Armor a in c.ArmorInventory)
                            {
                                if (a.Name == cboxShowInventory.Text)
                                {
                                    txtOutput.Text = a.ShowInfo();
                                    break;
                                }
                            }
                            break;
                        case "Potions":
                            foreach (Potion p in c.PotionInventory)
                            {
                                if (p.Name == cboxShowInventory.Text)
                                {
                                    txtOutput.Text = p.ShowInfo();
                                    break;
                                }
                            }
                            break;
                    }
                    break;
                }
            }
        }

        private void btnRemoveObject_Click(object sender, RoutedEventArgs e)
        {
            string option = cboxInventory.Text;
            foreach (Character c in characters)
            {
                if (c.Name == (string)lbCharacter.Content)
                {
                    switch (option)
                    {
                        case "Weapons":
                            foreach (Weapon w in c.WeaponInventory)
                            {
                                if (w.Name == cboxShowInventory.Text)
                                {
                                    cboxShowInventory.Items.Remove(w.Name);
                                    c.WeaponInventory.Remove(w);
                                    break;
                                }

                            }
                            break;
                        case "Armors":
                            foreach (Armor a in c.ArmorInventory)
                            {
                                cboxShowInventory.Items.Remove(a.Name);
                                c.ArmorInventory.Remove(a);
                                break;
                            }
                            break;
                        case "Potions":
                            foreach (Potion p in c.PotionInventory)
                            {
                                cboxShowInventory.Items.Remove(p.Name);
                                c.PotionInventory.Remove(p);
                                break;
                            }
                            break;
                    }
                    break;
                }
            }
        }

        private void btnUseObject_Click(object sender, RoutedEventArgs e)
        {
            string option = cboxInventory.Text;
            foreach (Character c in characters)
            {
                if (c.Name == (string)lbCharacter.Content)
                {
                    switch (option)
                    {
                        case "Weapons":
                            foreach (Weapon w in c.WeaponInventory)
                            {
                                if (w.Name == cboxShowInventory.Text)
                                {
                                    c.WeaponInventory.Add(c.Armament);
                                    cboxShowInventory.Items.Add(c.Armament.Name);
                                    c.Armament = w;
                                    cboxShowInventory.Items.Remove(w.Name);
                                    c.WeaponInventory.Remove(w);
                                    break;
                                }

                            }
                            break;
                        case "Armors":
                            foreach (Armor a in c.ArmorInventory)
                            {
                                if (a.Name == cboxShowInventory.Text)
                                {
                                    c.ArmorInventory.Add(c.Suit);
                                    cboxShowInventory.Items.Add(c.Suit.Name);
                                    c.Suit = a;
                                    cboxShowInventory.Items.Remove(a.Name);
                                    c.ArmorInventory.Remove(a);
                                    break;
                                }
                                
                            }
                            break;
                        case "Potions":
                            foreach (Potion p in c.PotionInventory)
                            {
                                if (p.Name == cboxShowInventory.Text)
                                {
                                    p.Use(c);
                                    cboxShowInventory.Items.Remove(p.Name);
                                    c.PotionInventory.Remove(p);
                                    break;
                                }
                                
                            }
                            break;
                    }
                    break;
                }
            }
        }
    }
}
