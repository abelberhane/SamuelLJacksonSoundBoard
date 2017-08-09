using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
// This was much simpler than I expected. I needed to add Using System.Media to use the Sound player class. 
//Pass the specific location of where the audio file was located and then instantiated the play property on each click. 
//

namespace SoundBoard
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
       
        private void ambulanceButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Ambulance);
            sp.Play();
        }

        private void askingButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Asking);
            sp.Play();
        }

        private void attitudeButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Attitude);
            sp.Play();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Back);
            sp.Play();
        }

        private void buttsButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Butts);
            sp.Play();
        }

        private void cantButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Cant);
            sp.Play();
        }

        private void countryButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Country);
            sp.Play();
        }

        private void enoughButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Enough);
            sp.Play();
        }

        private void errorButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Error);
            sp.Play();
        }

        private void fonzieButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Fonzie);
            sp.Play();
        }

        private void howButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.How);
            sp.Play();
        }

        private void jobButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Job);
            sp.Play();
        }

        private void kahunaButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Kahuna);
            sp.Play();
        }

        private void questionsButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Questions);
            sp.Play();
        }

        private void rememberButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Remember);
            sp.Play();
        }

        private void retortButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Retort);
            sp.Play();
        }

        private void stfuButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.STFU);
            sp.Play();
        }

        private void talkingButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Talking);
            sp.Play();
        }

        private void walkButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.Walk);
            sp.Play();
        }

        private void youButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(SoundBoard.Properties.Resources.You);
            sp.Play();
        }
    }
}
