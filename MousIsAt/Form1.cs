using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MousIsAt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ticker.Start();
        }

        private void ticker_Tick(object sender, EventArgs e)
        {
            locx.Text = Cursor.Position.X.ToString();
            locy.Text = Cursor.Position.Y.ToString();

        }
    }
}
