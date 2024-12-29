/*
 * Created by SharpDevelop.
 * User: Vice Mayor Office
 * Date: 5/28/2023
 * Time: 2:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Form1
{
	partial class StarFire_Strike
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox player;
		private System.Windows.Forms.PictureBox alien;
		private System.Windows.Forms.PictureBox ship;
		private System.Windows.Forms.Label lbl_score;
		private System.Windows.Forms.Label lbl_over;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox Restart;
		private System.Windows.Forms.Label lbl_quit;
		private System.Windows.Forms.Label lbl_restart;
		
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.alien = new System.Windows.Forms.PictureBox();
            this.ship = new System.Windows.Forms.PictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_over = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Restart = new System.Windows.Forms.GroupBox();
            this.lbl_quit = new System.Windows.Forms.Label();
            this.lbl_restart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Restart.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Form1.Properties.Resource1.Stars_img;
            this.pictureBox2.Location = new System.Drawing.Point(16, 386);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(478, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "star";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Form1.Properties.Resource1.player;
            this.player.Location = new System.Drawing.Point(260, 446);
            this.player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(119, 92);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // alien
            // 
            this.alien.BackColor = System.Drawing.Color.Transparent;
            this.alien.Image = global::Form1.Properties.Resource1.ship_1;
            this.alien.Location = new System.Drawing.Point(33, 65);
            this.alien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alien.Name = "alien";
            this.alien.Size = new System.Drawing.Size(97, 74);
            this.alien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alien.TabIndex = 3;
            this.alien.TabStop = false;
            this.alien.Tag = "enemy";
            // 
            // ship
            // 
            this.ship.BackColor = System.Drawing.Color.Transparent;
            this.ship.Image = global::Form1.Properties.Resource1.ship__2_;
            this.ship.Location = new System.Drawing.Point(372, 0);
            this.ship.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ship.Name = "ship";
            this.ship.Size = new System.Drawing.Size(97, 74);
            this.ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship.TabIndex = 4;
            this.ship.TabStop = false;
            this.ship.Tag = "enemy";
            // 
            // lbl_score
            // 
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.Red;
            this.lbl_score.Location = new System.Drawing.Point(0, 4);
            this.lbl_score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(221, 58);
            this.lbl_score.TabIndex = 6;
            this.lbl_score.Text = "Score : 0";
            // 
            // lbl_over
            // 
            this.lbl_over.BackColor = System.Drawing.Color.Transparent;
            this.lbl_over.Font = new System.Drawing.Font("High Tower Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_over.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_over.Location = new System.Drawing.Point(84, 75);
            this.lbl_over.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(313, 58);
            this.lbl_over.TabIndex = 7;
            this.lbl_over.Text = "GAME OVER ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Form1.Properties.Resource1.Stars_img;
            this.pictureBox1.Location = new System.Drawing.Point(0, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "star";
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.Transparent;
            this.Restart.Controls.Add(this.lbl_quit);
            this.Restart.Controls.Add(this.lbl_restart);
            this.Restart.Controls.Add(this.lbl_over);
            this.Restart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.Location = new System.Drawing.Point(97, 167);
            this.Restart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Restart.Name = "Restart";
            this.Restart.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Restart.Size = new System.Drawing.Size(481, 278);
            this.Restart.TabIndex = 9;
            this.Restart.TabStop = false;
            this.Restart.Text = "Menu";
            // 
            // lbl_quit
            // 
            this.lbl_quit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_quit.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quit.ForeColor = System.Drawing.Color.Red;
            this.lbl_quit.Location = new System.Drawing.Point(163, 204);
            this.lbl_quit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_quit.Name = "lbl_quit";
            this.lbl_quit.Size = new System.Drawing.Size(105, 42);
            this.lbl_quit.TabIndex = 11;
            this.lbl_quit.Text = "Quit";
            this.lbl_quit.Click += new System.EventHandler(this.Lbl_quitClick);
            // 
            // lbl_restart
            // 
            this.lbl_restart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_restart.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_restart.ForeColor = System.Drawing.Color.Red;
            this.lbl_restart.Location = new System.Drawing.Point(151, 133);
            this.lbl_restart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_restart.Name = "lbl_restart";
            this.lbl_restart.Size = new System.Drawing.Size(151, 58);
            this.lbl_restart.TabIndex = 10;
            this.lbl_restart.Text = "Restart";
            this.lbl_restart.Click += new System.EventHandler(this.Lbl_restartClick);
            // 
            // StarFire_Strike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(645, 567);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.ship);
            this.Controls.Add(this.alien);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StarFire_Strike";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Starfire Strike";
            this.Load += new System.EventHandler(this.StarFire_Strike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Restart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
