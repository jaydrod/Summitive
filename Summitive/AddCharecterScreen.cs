using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summitive
{
    public partial class AddCharecterScreen : UserControl
    {
        public AddCharecterScreen()
        {
            InitializeComponent();
        }

        private void AddCharecterScreen_Load(object sender, EventArgs e)
        {

        }

        private void Breannabutton_Click(object sender, EventArgs e)
        {
            Form1.heroimage = Properties.Resources.Beanna_Sprite;
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen cs = new GameScreen();
            f.Controls.Add(cs);
            cs.Focus();
        }

        private void Maxbutton_Click(object sender, EventArgs e)
        {
            Form1.heroimage = Properties.Resources.Max_Sprite;
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen cs = new GameScreen();
            f.Controls.Add(cs);
            cs.Focus();
        }

        private void Chrisbutton_Click(object sender, EventArgs e)
        {
            Form1.heroimage = Properties.Resources.Chris_Sprite;
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen cs = new GameScreen();
            f.Controls.Add(cs);
            cs.Focus();
        }

        private void Jaydenbutton_Click(object sender, EventArgs e)
        {
            Form1.heroimage = Properties.Resources.Jayden_Sprite;
            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen cs = new GameScreen();
            f.Controls.Add(cs);
            cs.Focus();
        }
    }
}
