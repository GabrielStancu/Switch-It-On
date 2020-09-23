namespace Switch_It_On_
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btNewGame = new System.Windows.Forms.Button();
            this.btInstr = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btNewGame
            // 
            this.btNewGame.BackColor = System.Drawing.Color.Navy;
            this.btNewGame.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btNewGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btNewGame.Location = new System.Drawing.Point(444, 286);
            this.btNewGame.Name = "btNewGame";
            this.btNewGame.Size = new System.Drawing.Size(330, 86);
            this.btNewGame.TabIndex = 0;
            this.btNewGame.Text = "New Game";
            this.btNewGame.UseVisualStyleBackColor = false;
            this.btNewGame.Click += new System.EventHandler(this.btNewGame_Click);
            // 
            // btInstr
            // 
            this.btInstr.BackColor = System.Drawing.Color.Navy;
            this.btInstr.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btInstr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btInstr.Location = new System.Drawing.Point(444, 383);
            this.btInstr.Name = "btInstr";
            this.btInstr.Size = new System.Drawing.Size(330, 86);
            this.btInstr.TabIndex = 1;
            this.btInstr.Text = "Instructions";
            this.btInstr.UseVisualStyleBackColor = false;
            this.btInstr.Click += new System.EventHandler(this.btInstr_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Navy;
            this.btExit.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btExit.Location = new System.Drawing.Point(444, 480);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(330, 86);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Exit Game";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(341, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 115);
            this.label1.TabIndex = 3;
            this.label1.Text = "Switch It On!";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Switch_It_On_.Properties.Resources.bg_joc6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 640);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btInstr);
            this.Controls.Add(this.btNewGame);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNewGame;
        private System.Windows.Forms.Button btInstr;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label1;
    }
}

