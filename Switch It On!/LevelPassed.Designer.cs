namespace Switch_It_On_
{
    partial class LevelPassed
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
            this.bt_Replay = new System.Windows.Forms.Button();
            this.bt_select = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbStele = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStele)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Replay
            // 
            this.bt_Replay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Replay.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_Replay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Replay.Location = new System.Drawing.Point(597, 396);
            this.bt_Replay.Name = "bt_Replay";
            this.bt_Replay.Size = new System.Drawing.Size(178, 43);
            this.bt_Replay.TabIndex = 10;
            this.bt_Replay.Text = "Replay Level";
            this.bt_Replay.UseVisualStyleBackColor = false;
            this.bt_Replay.Click += new System.EventHandler(this.bt_Replay_Click);
            // 
            // bt_select
            // 
            this.bt_select.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_select.BackColor = System.Drawing.Color.SkyBlue;
            this.bt_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_select.Location = new System.Drawing.Point(401, 396);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(178, 43);
            this.bt_select.TabIndex = 8;
            this.bt_select.Text = "Select Level";
            this.bt_select.UseVisualStyleBackColor = false;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(324, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "You have successfully completed the 1st level!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(363, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 62);
            this.label1.TabIndex = 6;
            this.label1.Text = "Congratulations!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbStele
            // 
            this.pbStele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbStele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbStele.Location = new System.Drawing.Point(424, 281);
            this.pbStele.Name = "pbStele";
            this.pbStele.Size = new System.Drawing.Size(311, 100);
            this.pbStele.TabIndex = 9;
            this.pbStele.TabStop = false;
            // 
            // LevelPassed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Switch_It_On_.Properties.Resources.lv_passed4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1170, 617);
            this.ControlBox = false;
            this.Controls.Add(this.bt_Replay);
            this.Controls.Add(this.pbStele);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LevelPassed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbStele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Replay;
        private System.Windows.Forms.PictureBox pbStele;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}