
namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_GB01 = new System.Windows.Forms.PictureBox();
            this.pb_GB02 = new System.Windows.Forms.PictureBox();
            this.pb_GB10 = new System.Windows.Forms.PictureBox();
            this.pb_GB11 = new System.Windows.Forms.PictureBox();
            this.pb_GB12 = new System.Windows.Forms.PictureBox();
            this.pb_GB20 = new System.Windows.Forms.PictureBox();
            this.pb_GB21 = new System.Windows.Forms.PictureBox();
            this.pb_GB22 = new System.Windows.Forms.PictureBox();
            this.pb_GB00 = new System.Windows.Forms.PictureBox();
            this.lb_cPlayer = new System.Windows.Forms.Label();
            this.btn_NewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB00)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_GB01
            // 
            this.pb_GB01.Image = global::TicTacToe.Properties.Resources.imgDefault;
            this.pb_GB01.Location = new System.Drawing.Point(363, 58);
            this.pb_GB01.Name = "pb_GB01";
            this.pb_GB01.Size = new System.Drawing.Size(151, 152);
            this.pb_GB01.TabIndex = 1;
            this.pb_GB01.TabStop = false;
            this.pb_GB01.Click += new System.EventHandler(this.pb_GB01_Click);
            // 
            // pb_GB02
            // 
            this.pb_GB02.Image = global::TicTacToe.Properties.Resources.imgDefault;
            this.pb_GB02.Location = new System.Drawing.Point(535, 58);
            this.pb_GB02.Name = "pb_GB02";
            this.pb_GB02.Size = new System.Drawing.Size(151, 152);
            this.pb_GB02.TabIndex = 2;
            this.pb_GB02.TabStop = false;
            this.pb_GB02.Click += new System.EventHandler(this.pb_GB02_Click);
            // 
            // pb_GB10
            // 
            this.pb_GB10.Image = global::TicTacToe.Properties.Resources.imgDefault;
            this.pb_GB10.Location = new System.Drawing.Point(196, 217);
            this.pb_GB10.Name = "pb_GB10";
            this.pb_GB10.Size = new System.Drawing.Size(151, 152);
            this.pb_GB10.TabIndex = 3;
            this.pb_GB10.TabStop = false;
            this.pb_GB10.Click += new System.EventHandler(this.pb_GB10_Click);
            // 
            // pb_GB11
            // 
            this.pb_GB11.Image = global::TicTacToe.Properties.Resources.imgDefault;
            this.pb_GB11.Location = new System.Drawing.Point(363, 217);
            this.pb_GB11.Name = "pb_GB11";
            this.pb_GB11.Size = new System.Drawing.Size(151, 152);
            this.pb_GB11.TabIndex = 4;
            this.pb_GB11.TabStop = false;
            this.pb_GB11.Click += new System.EventHandler(this.pb_GB11_Click);
            // 
            // pb_GB12
            // 
            this.pb_GB12.Image = global::TicTacToe.Properties.Resources.imgDefault;
            this.pb_GB12.Location = new System.Drawing.Point(535, 217);
            this.pb_GB12.Name = "pb_GB12";
            this.pb_GB12.Size = new System.Drawing.Size(151, 152);
            this.pb_GB12.TabIndex = 5;
            this.pb_GB12.TabStop = false;
            this.pb_GB12.Click += new System.EventHandler(this.pb_GB12_Click);
            // 
            // pb_GB20
            // 
            this.pb_GB20.Image = global::TicTacToe.Properties.Resources.imgDefault;
            this.pb_GB20.Location = new System.Drawing.Point(196, 376);
            this.pb_GB20.Name = "pb_GB20";
            this.pb_GB20.Size = new System.Drawing.Size(151, 152);
            this.pb_GB20.TabIndex = 6;
            this.pb_GB20.TabStop = false;
            this.pb_GB20.Click += new System.EventHandler(this.pb_GB20_Click);
            // 
            // pb_GB21
            // 
            this.pb_GB21.Image = global::TicTacToe.Properties.Resources.imgDefault;
            this.pb_GB21.Location = new System.Drawing.Point(363, 376);
            this.pb_GB21.Name = "pb_GB21";
            this.pb_GB21.Size = new System.Drawing.Size(151, 152);
            this.pb_GB21.TabIndex = 7;
            this.pb_GB21.TabStop = false;
            this.pb_GB21.Click += new System.EventHandler(this.pb_GB21_Click);
            // 
            // pb_GB22
            // 
            this.pb_GB22.Image = global::TicTacToe.Properties.Resources.imgDefault;
            this.pb_GB22.Location = new System.Drawing.Point(535, 376);
            this.pb_GB22.Name = "pb_GB22";
            this.pb_GB22.Size = new System.Drawing.Size(151, 152);
            this.pb_GB22.TabIndex = 8;
            this.pb_GB22.TabStop = false;
            this.pb_GB22.Click += new System.EventHandler(this.pb_GB22_Click);
            // 
            // pb_GB00
            // 
            this.pb_GB00.Image = global::TicTacToe.Properties.Resources.imgDefault;
            this.pb_GB00.Location = new System.Drawing.Point(196, 58);
            this.pb_GB00.Name = "pb_GB00";
            this.pb_GB00.Size = new System.Drawing.Size(151, 152);
            this.pb_GB00.TabIndex = 9;
            this.pb_GB00.TabStop = false;
            this.pb_GB00.Click += new System.EventHandler(this.pb_GB00_Click);
            // 
            // lb_cPlayer
            // 
            this.lb_cPlayer.AutoSize = true;
            this.lb_cPlayer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_cPlayer.Location = new System.Drawing.Point(393, 9);
            this.lb_cPlayer.Name = "lb_cPlayer";
            this.lb_cPlayer.Size = new System.Drawing.Size(90, 30);
            this.lb_cPlayer.TabIndex = 10;
            this.lb_cPlayer.Text = "Player 1";
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.Location = new System.Drawing.Point(12, 16);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(75, 23);
            this.btn_NewGame.TabIndex = 11;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = true;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 541);
            this.Controls.Add(this.btn_NewGame);
            this.Controls.Add(this.lb_cPlayer);
            this.Controls.Add(this.pb_GB00);
            this.Controls.Add(this.pb_GB22);
            this.Controls.Add(this.pb_GB21);
            this.Controls.Add(this.pb_GB20);
            this.Controls.Add(this.pb_GB12);
            this.Controls.Add(this.pb_GB11);
            this.Controls.Add(this.pb_GB10);
            this.Controls.Add(this.pb_GB02);
            this.Controls.Add(this.pb_GB01);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GB00)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_GB01;
        private System.Windows.Forms.PictureBox pb_GB02;
        private System.Windows.Forms.PictureBox pb_GB10;
        private System.Windows.Forms.PictureBox pb_GB11;
        private System.Windows.Forms.PictureBox pb_GB12;
        private System.Windows.Forms.PictureBox pb_GB20;
        private System.Windows.Forms.PictureBox pb_GB21;
        private System.Windows.Forms.PictureBox pb_GB22;
        private System.Windows.Forms.PictureBox pb_GB00;
        private System.Windows.Forms.Label lb_cPlayer;
        private System.Windows.Forms.Button btn_NewGame;
    }
}

