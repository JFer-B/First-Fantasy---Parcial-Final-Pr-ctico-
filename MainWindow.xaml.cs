using FIrstFantasyGame.Classes;
using FIrstFantasyGame.Classes.Equippables;
using FIrstFantasyGame.Classes.Equippables.Armament;
using FIrstFantasyGame.Classes.Subject;
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

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            Character mycharacter;
            string chName = "JFerk";
            Bow arco = new Bow("Trinfo", "Rare");

            string option = cboxCharacter.Text;

            switch (option)
            {
                case "Wizard":
                    mycharacter = new Wizard(chName, arco);
                    break;
                case "Rogue":
                    mycharacter = new Rogue(chName, arco);
                    break;
                case "Cleric":
                    mycharacter = new Cleric(chName, arco);
                    break;
                case "Fighter":
                    mycharacter = new Fighter(chName, arco);
                    break;
                default:
                    mycharacter = null;
                    MessageBox.Show("You MUST select a class");
                    break;
            }

            if(mycharacter != null)
            {
                int attack = mycharacter.Attack(arco);
                txtOutput.Text = attack.ToString() + " " + arco.Damage.ToString();
            }
        }
    }
}
