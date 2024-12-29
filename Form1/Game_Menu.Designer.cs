/*
 * Created by SharpDevelop.
 * User: Vice Mayor Office
 * Date: 5/28/2023
 * Time: 1:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Form1
{
	partial class Game_Menu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox btn_exit;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox btn_play;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_play = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Image = global::Form1.Properties.Resource1.close_button_png_30222;
            this.btn_exit.Location = new System.Drawing.Point(421, 417);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(161, 124);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_exit.TabIndex = 2;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exitClick);
            this.btn_exit.MouseLeave += new System.EventHandler(this.Btn_exitMouseLeave);
            this.btn_exit.MouseHover += new System.EventHandler(this.Btn_exitMouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Form1.Properties.Resource1.menu_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(61, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.Image = global::Form1.Properties.Resource1.nori5e4itgl99gfu31v6q9ba39;
            this.btn_play.Location = new System.Drawing.Point(77, 417);
            this.btn_play.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(141, 124);
            this.btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_play.TabIndex = 4;
            this.btn_play.TabStop = false;
            this.btn_play.Click += new System.EventHandler(this.Btn_playClick);
            this.btn_play.MouseLeave += new System.EventHandler(this.Btn_playMouseLeave);
            this.btn_play.MouseHover += new System.EventHandler(this.Btn_playMouseHover);
            // 
            // Game_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Form1.Properties.Resource1.bg;
            this.ClientSize = new System.Drawing.Size(645, 567);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Game_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Menu";
            this.Load += new System.EventHandler(this.Game_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            this.ResumeLayout(false);

		}
	}
}
