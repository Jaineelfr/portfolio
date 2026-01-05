using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sponge_treasure_hunt
{
    public partial class Form2 : Form
    {
        // Two arrays for game state:
        // 'spongebob' contains different values ("crab", "money", "rich"), which represent game outcomes.
        string[] spongebob = {"crab", "money",  "rich", "money", "crab", "rich", "money", "crab", "rich", "money", "crab", "rich", "money", "money", "money", "crab" };
        // 'patrick' will store the shuffled items from 'spongebob' after game starts.
        string[] patrick = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        // Random object for generating random numbers.
        Random box = new Random();
        // Game variables:
        int counter = 0; // Tracks how many items have been placed in 'patrick'.
        int money = 500; // Initial money the player has.
        int rich = 0;    // Number of "rich" items found (goal is to find 4).
        int lives = 3;   // The player starts with 3 lives.

        public Form2()
        {
            InitializeComponent(); // Initializes the form and its components.
        }

        // Click event handler for picture box 1 (more to come later)
        private void pb1_Click(object sender, EventArgs e)
        {
            
        }

        // Updates the money label on the UI to show the current money value.
        private void scoremoney()
        {
            lbl_money.Text = money.ToString();
        }

        // Function to handle when a "rich" item is found.
        private void riches()
        {
            
            rich = rich + 1;// Increments the 'rich' count.
            MessageBox.Show("Congrats you've found " + rich + " out of 4");

            // Check if the player has found all 4 rich items and won the game.
            if (rich == 4)
            {
                MessageBox.Show("Congrats you've officially overthrown the economy of the bikini bottom, and now ur rich as hell!!");
                Application.Exit(); // Closes the game.
            }
            // Updates the riches label with the current count.
            lbl_riches.Text = rich.ToString();
        }

        // Function to handle when a "crab" item is found (player loses money and lives).
        private void crab()
        {
            money = money - 100; // Deducts 100 money.
            lives = lives - 1;   // Player loses one life.
                                 // Update heart icons (lives display) based on remaining lives.
            if (lives == 2)
            {
                pb_h1.Visible = false; // Hides the first heart.
            }
            else if (lives == 1)
            {
                pb_h2.Visible = false; // Hides the second heart.
            }
            else if (lives == 0)
            {
                pb_h3.Visible = false; // Hides the third heart.

                // Player has lost all lives; game over message.
                MessageBox.Show("You have lost all your lives, and Mr. Krabs has now overtaken your entire family estate. " +
                    "Cause you're a dumbass like holy shit man, how do you lose like that! " +
                    "(that comment was for everybody except John, because I need a good mark John please) But hey you can always try again! I lied you're a loser" +
                    "HEHE");

                Application.Exit(); // Closes the game.
            }


        }

        // Click event handlers for other picture boxes (similar to pb1_Click but filled later)
        private void pb2_Click(object sender, EventArgs e)
        {
          
            
        }

        private void pb3_Click(object sender, EventArgs e)
        {
          
        }

        private void pb4_Click(object sender, EventArgs e)
        {
         
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            
        }

        private void pb6_Click(object sender, EventArgs e)
        {
      
        }

        private void pb7_Click(object sender, EventArgs e)
        {
        
        }

        private void pb8_Click(object sender, EventArgs e)
        {
           
        }

        private void pb9_Click(object sender, EventArgs e)
        {
         
        }

        private void pb10_Click(object sender, EventArgs e)
        {
           
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            
        }

        private void pb13_Click(object sender, EventArgs e)
        {
           
          
        }

        private void pb14_Click(object sender, EventArgs e)
        {
           
        }

        private void pb15_Click(object sender, EventArgs e)
        {
            
          
        }

        private void pb16_Click(object sender, EventArgs e)
        {
         
        }

        // This method is triggered when the form loads.
        private void Form2_Load(object sender, EventArgs e)
        {
           // This loop randomly places items from 'spongebob' into 'patrick' (shuffling them).
            while (counter < spongebob.Length)
            {
                int num = box.Next(0, spongebob.Length); // Randomly selects an index.

                if (spongebob[num] != "gone") // Ensures the same item isn't selected twice.
                {
                    patrick[counter] = spongebob[num]; // Places the selected item into 'patrick'.
                    spongebob[num] = "gone"; // Marks the selected item as "gone" so it can't be reused.
                    counter++; // Increases the counter.
                }
            }
        }

        // Handles clicks on labels and other components (not implemented yet).
        private void lbl_riches_Click(object sender, EventArgs e)
        {
           
        }

        private void pb_h3_Click(object sender, EventArgs e)
        {

        }


        // Universal event handler for when any picture box is clicked.
        private void pluh(object sender, EventArgs e)
        {
            PictureBox picked = (PictureBox)sender; // Identifies which picture box was clicked.
            char[] pic_one = picked.Name.ToCharArray(); // Extracts the name of the picture box (e.g., "pb1").

            // Converts the picture box name (e.g., "pb01") to its corresponding index (e.g., 1).
            int num_in_name = int.Parse(pic_one[2].ToString() + pic_one[3]);

            // Uses the item in 'patrick' at the corresponding index to determine what happens.
            switch (patrick[num_in_name])
            {
                case "crab": // If it's a "crab", show the crab image and deduct money/lives.
                    picked.BackgroundImage = Properties.Resources.crab;
                    crab(); // Calls the crab method.
                    break;

                case "rich": // If it's a "rich", show the rich image and increase the count.
                    picked.BackgroundImage = Properties.Resources.rich;
                    riches(); // Calls the riches method.
                    break;

                case "money": // If it's "money", show the money image and update the money.
                    picked.BackgroundImage = Properties.Resources.money;
                    scoremoney(); // Calls the scoremoney method.
                    break;
            }
        }
    }
}
