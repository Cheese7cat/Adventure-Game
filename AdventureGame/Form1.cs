using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    //Paige Chaisson
    //Adventure Game
    //2019/11/07
    public partial class Form1 : Form
    {
        int scene = 0;
        public Form1()
        {
            InitializeComponent();
            output.Text = "You want a sandwich. you begin to make your sandwich but you realize you have no cheese. Will you get cheese or settle for something else? ";
            redOutput.Text = " something else";
            blueOutput.Text = " get cheese";

            sceneImage.BackgroundImage = Properties.Resources.sceneOne;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.M) // red button 
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 0; }
                else if (scene == 3) { scene = 4; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 6; }
                else if (scene == 6) { scene = 0; }
                else if (scene == 7) { scene = 9; }
                else if (scene == 8) { scene = 0; }
                else if (scene == 9) { scene = 10; }
                else if (scene == 10) { scene = 99; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 13) { scene = 0;  }
                else if (scene == 14) { scene = 0; }
                else if (scene == 15) { scene = 14; }
                else if (scene == 16) { scene = 0; }
                else if (scene == 17) { scene = 0; }
               
            }
           if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0) { scene = 3; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 2) { this.Close(); }
                else if (scene == 3) { scene = 11; }
                else if (scene == 4) { scene = 11; }
                else if (scene == 5) { scene = 7; }
                else if (scene == 6) { this.Close(); }
                else if (scene == 7) { scene = 8; }
                else if (scene == 8) { this.Close(); }
                else if (scene == 9) { scene = 17; }
                else if (scene == 10) { scene = 0; }
                else if (scene == 11) { scene = 14; }
                else if (scene == 12) { scene = 15; }
                else if (scene == 13) { this.Close(); }
                else if (scene == 14) { this.Close(); }
                else if (scene == 15) { scene = 16; }
                else if (scene == 16) { scene = 99; }
                else if (scene == 17) { this.Close(); }
                else if (scene == 99) { this.Close(); }
            }

           switch (scene)
            {
                case 0:
                    break;
                case 1:
                    output.Text = "You monster, you can not just settle for something else  you want a sandwich like a real man. Look for cheese or not.";

                    redOutput.Text = " something else";
                    blueOutput.Text = " look for cheese ";
                    break;
                case 2:
                    output.Text = "You decide not to have a sandwich because you are a weak little man baby. The end. Would you like to play again? ";
                    redOutput.Text = "yes";
                    blueOutput.Text = "no";
                    break;
                case 3:
                    output.Text = "You decide that cheese must be found in order to enjoy your sandwich, but where do you start. Go outside or look in the fridge again ? ";
                    redOutput.Text = "look in fridge";
                    blueOutput.Text = "go outside";
                    break;
                case 4:
                    output.Text = "You open the fridge and still no cheese is there. You decide that there are only two options from this point,  go outside to find cheese or open a portal to hell.";
                    redOutput.Text = "open portal";
                        blueOutput.Text = "go outside";
                    sceneImage.BackgroundImage = Properties.Resources.scene4;
                    break;
                case 5:
                    output.Text = "You figer that goats are associated with hell so you can get some goat cheese to shake things up. Oh but how as that portal made again? Throw milk at the wall or throw milk on the floor?";
                    redOutput.Text = "floor";
                        blueOutput.Text = "wall";
                    sceneImage.BackgroundImage = Properties.Resources.scene5;
                    break;
                case 6:
                    output.Text = "Well now you just have a bunch of milk on the floor. You can no longer have you sandwich as now you have to clean this big mess, good job buddy. Play again?";
                    redOutput.Text = "yes";
                    blueOutput.Text = "no";
                    sceneImage.BackgroundImage = Properties.Resources.scene6;
                    break;
                case 7:
                    output.Text = "After throwing milk at the wall a portal to hell opens up.  Will you walk in or wright a note and pass it through?";
                    redOutput.Text = "pass note";
                    blueOutput.Text = "go on in";
                    break;
                case 8:
                    output.Text = "You walk in and the portal closes behind you. You are trapped in hell because you were to lazy to go to the store and get some bloody cheese. Play again?";
                    redOutput.Text = "yes";
                    blueOutput.Text = "no";
                    break;
                case 9:
                    output.Text = "You pass a note through and after about a minute to so a block of cheese is tossed out. Use it? ";
                    redOutput.Text = "Yes";
                    blueOutput.Text = "No";
                    sceneImage.BackgroundImage = Properties.Resources.scene9;
                    break;
                case 10:
                    output.Text = "You place the cheese upon your sandwich and as you eat it you realize something, its hot like really hot. You're just on fire, but its worth it. Play again? ";
                    redOutput.Text = " yes";
                    blueOutput.Text = "no";
                    break;
                case 11:
                    output.Text = "You go outside. great you're outside now, so now what? Will you go to the store or  go to a farm?";
                    redOutput.Text = "farm";
                    blueOutput.Text = "store";
                    sceneImage.BackgroundImage = Properties.Resources.scene11;
                    break;
                case 12:
                    output.Text = "You go to your local farm and you see it, a cow. Will you obtain its milk?";
                    redOutput.Text = "yes";
                    blueOutput.Text = "no";
                    sceneImage.BackgroundImage = Properties.Resources.scene12;
                    break;
                case 13:
                    output.Text = "You go up to the cow  but as you go to milk it you realize that this is not a cow, it is a bull. It kicks you in the face and now you have brain damage. play again? ";
                    redOutput.Text = "yes";
                    blueOutput.Text = "no";
                    sceneImage.BackgroundImage = Properties.Resources.scene13;
                    break;
                case 14:
                    output.Text = "You go to the store and get some cheese. You can finally enjoy your sandwich. The end. Would you like to play again? ";
                    redOutput.Text = "yes";
                    blueOutput.Text = "no";
                    sceneImage.BackgroundImage = Properties.Resources.scene14;
                    break;
                case 15:
                    output.Text = "You remember that you dont know how to make cheese. Go to the store?";
                    redOutput.Text = "yes";
                    blueOutput.Text = "no";
                    break;
                case 16:
                    output.Text = "Well now you have no cheese and cannot enjoy your sandwich. Play again?";
                    redOutput.Text = "yes";
                    blueOutput.Text = "no";
                    break;
                case 17:
                    output.Text = "You decide not to use it and now you have no cheese for you sandwich. Play again?";
                    redOutput.Text = "yes";
                    blueOutput.Text = "no";
                    break;
                case 99:
                    output.Text = " You have no cheese for your sandwich. You have failed play again?";
                    redOutput.Text = "yes";
                    blueOutput.Text = "no";

                    break;
            }
        } 

        private void Form1_Load(object sender, EventArgs e)
        {

          
          
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }
    }
}
