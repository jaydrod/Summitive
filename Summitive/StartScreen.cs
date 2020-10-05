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
    public partial class StartScreen : UserControl
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {

            Form f = this.FindForm();
            f.Controls.Remove(this);
            AddCharecterScreen cs = new AddCharecterScreen();
            f.Controls.Add(cs);
            
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
