using System.Windows.Forms;

namespace KeyboardCube
{
	public partial class Main : Form 
	{
		public Main()
		{
			InitializeComponent();
		}

		private void buttonRotate_KeyDown(object sender, KeyEventArgs e)
		{
			MessageBox.Show($"{e.KeyValue}:{e.KeyCode}");
		}
	}
}
