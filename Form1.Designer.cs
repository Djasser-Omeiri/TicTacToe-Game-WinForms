namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_title = new System.Windows.Forms.Label();
            this.pb22 = new System.Windows.Forms.PictureBox();
            this.pb12 = new System.Windows.Forms.PictureBox();
            this.pb02 = new System.Windows.Forms.PictureBox();
            this.pb21 = new System.Windows.Forms.PictureBox();
            this.pb11 = new System.Windows.Forms.PictureBox();
            this.pb01 = new System.Windows.Forms.PictureBox();
            this.pb20 = new System.Windows.Forms.PictureBox();
            this.pb10 = new System.Windows.Forms.PictureBox();
            this.pb00 = new System.Windows.Forms.PictureBox();
            this.pbBIGPIC = new System.Windows.Forms.PictureBox();
            this.lTurn = new System.Windows.Forms.Label();
            this.pbbig = new System.Windows.Forms.PictureBox();
            this.l_turn = new System.Windows.Forms.Label();
            this.l_Players = new System.Windows.Forms.Label();
            this.l_Winner = new System.Windows.Forms.Label();
            this.l_playerwhowon = new System.Windows.Forms.Label();
            this.b_restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBIGPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbig)).BeginInit();
            this.SuspendLayout();
            // 
            // l_title
            // 
            this.l_title.AutoSize = true;
            this.l_title.BackColor = System.Drawing.Color.Transparent;
            this.l_title.Font = new System.Drawing.Font("Adobe Devanagari", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_title.ForeColor = System.Drawing.Color.White;
            this.l_title.Location = new System.Drawing.Point(313, 9);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(326, 58);
            this.l_title.TabIndex = 1;
            this.l_title.Text = "Tic-Tac-Toe Game";
            // 
            // pb22
            // 
            this.pb22.BackColor = System.Drawing.Color.Transparent;
            this.pb22.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.pb22.Location = new System.Drawing.Point(557, 303);
            this.pb22.Name = "pb22";
            this.pb22.Size = new System.Drawing.Size(125, 94);
            this.pb22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb22.TabIndex = 0;
            this.pb22.TabStop = false;
            this.pb22.Tag = "question";
            this.pb22.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb12
            // 
            this.pb12.BackColor = System.Drawing.Color.Transparent;
            this.pb12.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.pb12.Location = new System.Drawing.Point(557, 187);
            this.pb12.Name = "pb12";
            this.pb12.Size = new System.Drawing.Size(125, 94);
            this.pb12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb12.TabIndex = 0;
            this.pb12.TabStop = false;
            this.pb12.Tag = "question";
            this.pb12.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb02
            // 
            this.pb02.BackColor = System.Drawing.Color.Transparent;
            this.pb02.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.pb02.Location = new System.Drawing.Point(557, 77);
            this.pb02.Name = "pb02";
            this.pb02.Size = new System.Drawing.Size(125, 94);
            this.pb02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb02.TabIndex = 0;
            this.pb02.TabStop = false;
            this.pb02.Tag = "question";
            this.pb02.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb21
            // 
            this.pb21.BackColor = System.Drawing.Color.Transparent;
            this.pb21.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.pb21.Location = new System.Drawing.Point(414, 303);
            this.pb21.Name = "pb21";
            this.pb21.Size = new System.Drawing.Size(125, 94);
            this.pb21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb21.TabIndex = 0;
            this.pb21.TabStop = false;
            this.pb21.Tag = "question";
            this.pb21.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb11
            // 
            this.pb11.BackColor = System.Drawing.Color.Transparent;
            this.pb11.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.pb11.Location = new System.Drawing.Point(414, 187);
            this.pb11.Name = "pb11";
            this.pb11.Size = new System.Drawing.Size(125, 94);
            this.pb11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb11.TabIndex = 0;
            this.pb11.TabStop = false;
            this.pb11.Tag = "question";
            this.pb11.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb01
            // 
            this.pb01.BackColor = System.Drawing.Color.Transparent;
            this.pb01.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.pb01.Location = new System.Drawing.Point(414, 77);
            this.pb01.Name = "pb01";
            this.pb01.Size = new System.Drawing.Size(125, 94);
            this.pb01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb01.TabIndex = 0;
            this.pb01.TabStop = false;
            this.pb01.Tag = "question";
            this.pb01.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb20
            // 
            this.pb20.BackColor = System.Drawing.Color.Transparent;
            this.pb20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb20.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.pb20.Location = new System.Drawing.Point(267, 303);
            this.pb20.Name = "pb20";
            this.pb20.Size = new System.Drawing.Size(125, 94);
            this.pb20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb20.TabIndex = 0;
            this.pb20.TabStop = false;
            this.pb20.Tag = "question";
            this.pb20.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb10
            // 
            this.pb10.BackColor = System.Drawing.Color.Transparent;
            this.pb10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb10.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.pb10.Location = new System.Drawing.Point(267, 187);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(125, 94);
            this.pb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb10.TabIndex = 0;
            this.pb10.TabStop = false;
            this.pb10.Tag = "question";
            this.pb10.Click += new System.EventHandler(this.pb_Click);
            // 
            // pb00
            // 
            this.pb00.BackColor = System.Drawing.Color.Transparent;
            this.pb00.Image = global::TicTacToe.Properties.Resources.question_mark_96;
            this.pb00.Location = new System.Drawing.Point(267, 77);
            this.pb00.Name = "pb00";
            this.pb00.Size = new System.Drawing.Size(125, 94);
            this.pb00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb00.TabIndex = 0;
            this.pb00.TabStop = false;
            this.pb00.Tag = "question";
            this.pb00.Click += new System.EventHandler(this.pb_Click);
            // 
            // pbBIGPIC
            // 
            this.pbBIGPIC.Image = global::TicTacToe.Properties.Resources.Tic_tac_toePNG;
            this.pbBIGPIC.Location = new System.Drawing.Point(-1, 9);
            this.pbBIGPIC.Name = "pbBIGPIC";
            this.pbBIGPIC.Size = new System.Drawing.Size(258, 126);
            this.pbBIGPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBIGPIC.TabIndex = 2;
            this.pbBIGPIC.TabStop = false;
            // 
            // lTurn
            // 
            this.lTurn.AutoSize = true;
            this.lTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lTurn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTurn.ForeColor = System.Drawing.Color.Yellow;
            this.lTurn.Location = new System.Drawing.Point(77, 138);
            this.lTurn.Name = "lTurn";
            this.lTurn.Size = new System.Drawing.Size(102, 43);
            this.lTurn.TabIndex = 3;
            this.lTurn.Text = "Turn";
            // 
            // pbbig
            // 
            this.pbbig.Location = new System.Drawing.Point(-1, 9);
            this.pbbig.Name = "pbbig";
            this.pbbig.Size = new System.Drawing.Size(258, 143);
            this.pbbig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbbig.TabIndex = 2;
            this.pbbig.TabStop = false;
            // 
            // l_turn
            // 
            this.l_turn.AutoSize = true;
            this.l_turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_turn.ForeColor = System.Drawing.Color.Yellow;
            this.l_turn.Location = new System.Drawing.Point(97, 178);
            this.l_turn.Name = "l_turn";
            this.l_turn.Size = new System.Drawing.Size(35, 13);
            this.l_turn.TabIndex = 3;
            this.l_turn.Text = "Turn";
            // 
            // l_Players
            // 
            this.l_Players.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.l_Players.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Players.ForeColor = System.Drawing.Color.White;
            this.l_Players.Location = new System.Drawing.Point(-1, 187);
            this.l_Players.Name = "l_Players";
            this.l_Players.Size = new System.Drawing.Size(258, 43);
            this.l_Players.TabIndex = 4;
            this.l_Players.Text = "Player1";
            this.l_Players.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_Winner
            // 
            this.l_Winner.AutoSize = true;
            this.l_Winner.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Winner.ForeColor = System.Drawing.Color.Yellow;
            this.l_Winner.Location = new System.Drawing.Point(69, 236);
            this.l_Winner.Name = "l_Winner";
            this.l_Winner.Size = new System.Drawing.Size(118, 43);
            this.l_Winner.TabIndex = 3;
            this.l_Winner.Text = "           ";
            // 
            // l_playerwhowon
            // 
            this.l_playerwhowon.AutoSize = true;
            this.l_playerwhowon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_playerwhowon.ForeColor = System.Drawing.Color.Lime;
            this.l_playerwhowon.Location = new System.Drawing.Point(56, 285);
            this.l_playerwhowon.Name = "l_playerwhowon";
            this.l_playerwhowon.Size = new System.Drawing.Size(145, 43);
            this.l_playerwhowon.TabIndex = 4;
            this.l_playerwhowon.Text = "              ";
            // 
            // b_restart
            // 
            this.b_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_restart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_restart.ForeColor = System.Drawing.Color.White;
            this.b_restart.Location = new System.Drawing.Point(30, 358);
            this.b_restart.Name = "b_restart";
            this.b_restart.Size = new System.Drawing.Size(196, 42);
            this.b_restart.TabIndex = 5;
            this.b_restart.Text = "Restart Game";
            this.b_restart.UseVisualStyleBackColor = true;
            this.b_restart.Click += new System.EventHandler(this.b_restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb00);
            this.Controls.Add(this.b_restart);
            this.Controls.Add(this.l_playerwhowon);
            this.Controls.Add(this.l_Players);
            this.Controls.Add(this.l_Winner);
            this.Controls.Add(this.lTurn);
            this.Controls.Add(this.pbBIGPIC);
            this.Controls.Add(this.l_title);
            this.Controls.Add(this.pb22);
            this.Controls.Add(this.pb12);
            this.Controls.Add(this.pb02);
            this.Controls.Add(this.pb21);
            this.Controls.Add(this.pb11);
            this.Controls.Add(this.pb01);
            this.Controls.Add(this.pb20);
            this.Controls.Add(this.pb10);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBIGPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb00;
        private System.Windows.Forms.PictureBox pb01;
        private System.Windows.Forms.PictureBox pb02;
        private System.Windows.Forms.PictureBox pb10;
        private System.Windows.Forms.PictureBox pb11;
        private System.Windows.Forms.PictureBox pb12;
        private System.Windows.Forms.PictureBox pb20;
        private System.Windows.Forms.PictureBox pb21;
        private System.Windows.Forms.PictureBox pb22;
        private System.Windows.Forms.Label l_title;
        private System.Windows.Forms.PictureBox pbBIGPIC;
        private System.Windows.Forms.Label lTurn;
        private System.Windows.Forms.PictureBox pbbig;
        private System.Windows.Forms.Label l_turn;
        private System.Windows.Forms.Label l_Players;
        private System.Windows.Forms.Label l_Winner;
        private System.Windows.Forms.Label l_playerwhowon;
        private System.Windows.Forms.Button b_restart;
    }
}

