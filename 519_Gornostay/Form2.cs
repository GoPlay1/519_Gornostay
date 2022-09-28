using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _519_Gornostay
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		Form1 f1;
		Form2 f2;
		Form3 f3;
		private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			f1 = new Form1();
			f1.Show();
		}

		private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			f2 = new Form2();
			f2.Show();
		}

		private void открытьToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			f3 = new Form3();
			f3.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
