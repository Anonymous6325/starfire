/*
 * Created by SharpDevelop.
 * User: Vice Mayor Office
 * Date: 5/28/2023
 * Time: 1:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Form1
{
	public partial class Game_Menu : Form
	{
		public Game_Menu()
		{

			InitializeComponent();
			Application.OpenForms["MainForm"].Hide();

		}
		void Btn_playMouseHover(object sender, EventArgs e)
		{
			btn_play.Image = Properties.Resource1.btn_play_hover;
		}
		void Btn_playMouseLeave(object sender, EventArgs e)
		{
			btn_play.Image = Properties.Resource1.nori5e4itgl99gfu31v6q9ba39;
		}
		void Btn_playClick(object sender, EventArgs e)
		{
			StarFire_Strike ss=new StarFire_Strike();
			ss.ShowDialog();
		}
		void Btn_exitMouseHover(object sender, EventArgs e)
		{
			btn_exit.Image = Properties.Resource1.btn_exit_hover;
		}
		void Btn_exitMouseLeave(object sender, EventArgs e)
		{
			btn_exit.Image = Properties.Resource1.close_button_png_30222;
		}
		void Btn_exitClick(object sender, EventArgs e)
		{
			Application.Exit(); 
		}

        private void Game_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
