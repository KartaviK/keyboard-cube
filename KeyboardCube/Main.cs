using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardCube
{
	public partial class Main : Form 
	{
		public Main()
		{
			InitializeComponent();
		}

		private void Main_KeyPress(object sender, KeyPressEventArgs e)
		{
			MessageBox.Show("Pressed");
		}

		private void Main_KeyUp(object sender, KeyEventArgs e)
		{
			
		}

		private void buttonRotate_KeyDown(object sender, KeyEventArgs e)
		{
			MessageBox.Show($"{e.KeyValue}:{e.KeyCode}");
		}
	}
}
