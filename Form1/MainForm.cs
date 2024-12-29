/*
 * Created by SharpDevelop.
 * User: Vice Mayor Office
 * Date: 5/28/2023
 * Time: 12:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Form1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.Opacity = 0;
		}
		void Timer1Tick(object sender, EventArgs e)
		{
	
			if(Opacity<100)
			{
				Opacity +=0.05;
				progressBar1.Increment(2);
			}
			if(progressBar1.Value==100)
			{
				timer1.Stop();
				Game_Menu option = new Game_Menu();
				option.ShowDialog();
				
			}
		}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
