namespace voiceCommand2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.dent1 = new System.Windows.Forms.PictureBox();
            this.dent2 = new System.Windows.Forms.PictureBox();
            this.dent3 = new System.Windows.Forms.PictureBox();
            this.mainPic = new System.Windows.Forms.PictureBox();
            this.picturedent3 = new System.Windows.Forms.PictureBox();
            this.picturedent2 = new System.Windows.Forms.PictureBox();
            this.picturedent1 = new System.Windows.Forms.PictureBox();
            this.dent2_right = new System.Windows.Forms.Timer(this.components);
            this.dent2_left = new System.Windows.Forms.Timer(this.components);
            this.dent2_up = new System.Windows.Forms.Timer(this.components);
            this.dent2_down = new System.Windows.Forms.Timer(this.components);
            this.dent3_right = new System.Windows.Forms.Timer(this.components);
            this.dent3_left = new System.Windows.Forms.Timer(this.components);
            this.dent3_up = new System.Windows.Forms.Timer(this.components);
            this.dent3_down = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturedent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturedent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturedent1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Voice Command";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.left_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.up_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.down_Tick);
            // 
            // dent1
            // 
            this.dent1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dent1.Image = global::voiceCommand2.Properties.Resources.dent1;
            this.dent1.Location = new System.Drawing.Point(24, 12);
            this.dent1.Name = "dent1";
            this.dent1.Size = new System.Drawing.Size(63, 47);
            this.dent1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dent1.TabIndex = 5;
            this.dent1.TabStop = false;
            // 
            // dent2
            // 
            this.dent2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dent2.Image = global::voiceCommand2.Properties.Resources.dent4;
            this.dent2.Location = new System.Drawing.Point(24, 65);
            this.dent2.Name = "dent2";
            this.dent2.Size = new System.Drawing.Size(63, 47);
            this.dent2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dent2.TabIndex = 6;
            this.dent2.TabStop = false;
            // 
            // dent3
            // 
            this.dent3.Image = global::voiceCommand2.Properties.Resources.dent2;
            this.dent3.Location = new System.Drawing.Point(24, 117);
            this.dent3.Name = "dent3";
            this.dent3.Size = new System.Drawing.Size(63, 47);
            this.dent3.TabIndex = 7;
            this.dent3.TabStop = false;
            // 
            // mainPic
            // 
            this.mainPic.Image = global::voiceCommand2.Properties.Resources.dent3;
            this.mainPic.Location = new System.Drawing.Point(252, 81);
            this.mainPic.Name = "mainPic";
            this.mainPic.Size = new System.Drawing.Size(334, 232);
            this.mainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPic.TabIndex = 8;
            this.mainPic.TabStop = false;
            // 
            // picturedent3
            // 
            this.picturedent3.BackColor = System.Drawing.Color.Transparent;
            this.picturedent3.Image = global::voiceCommand2.Properties.Resources.dent2;
            this.picturedent3.Location = new System.Drawing.Point(24, 358);
            this.picturedent3.Name = "picturedent3";
            this.picturedent3.Size = new System.Drawing.Size(438, 50);
            this.picturedent3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturedent3.TabIndex = 11;
            this.picturedent3.TabStop = false;
            this.picturedent3.Visible = false;
            // 
            // picturedent2
            // 
            this.picturedent2.BackColor = System.Drawing.Color.Transparent;
            this.picturedent2.Image = global::voiceCommand2.Properties.Resources.dent4;
            this.picturedent2.Location = new System.Drawing.Point(364, 120);
            this.picturedent2.Name = "picturedent2";
            this.picturedent2.Size = new System.Drawing.Size(334, 232);
            this.picturedent2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturedent2.TabIndex = 12;
            this.picturedent2.TabStop = false;
            this.picturedent2.Visible = false;
            // 
            // picturedent1
            // 
            this.picturedent1.BackColor = System.Drawing.Color.Transparent;
            this.picturedent1.Image = global::voiceCommand2.Properties.Resources.dent1;
            this.picturedent1.Location = new System.Drawing.Point(24, 120);
            this.picturedent1.Name = "picturedent1";
            this.picturedent1.Size = new System.Drawing.Size(334, 232);
            this.picturedent1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturedent1.TabIndex = 13;
            this.picturedent1.TabStop = false;
            this.picturedent1.Visible = false;
            // 
            // dent2_right
            // 
            this.dent2_right.Tick += new System.EventHandler(this.dent2_right_Tick);
            // 
            // dent2_left
            // 
            this.dent2_left.Tick += new System.EventHandler(this.dent2_left_Tick);
            // 
            // dent2_up
            // 
            this.dent2_up.Tick += new System.EventHandler(this.dent2_up_Tick);
            // 
            // dent2_down
            // 
            this.dent2_down.Tick += new System.EventHandler(this.dent2_down_Tick);
            // 
            // dent3_right
            // 
            this.dent3_right.Tick += new System.EventHandler(this.dent3_right_Tick);
            // 
            // dent3_left
            // 
            this.dent3_left.Tick += new System.EventHandler(this.dent3_left_Tick);
            // 
            // dent3_up
            // 
            this.dent3_up.Tick += new System.EventHandler(this.dent3_up_Tick);
            // 
            // dent3_down
            // 
            this.dent3_down.Tick += new System.EventHandler(this.dent3_down_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picturedent1);
            this.Controls.Add(this.picturedent2);
            this.Controls.Add(this.picturedent3);
            this.Controls.Add(this.mainPic);
            this.Controls.Add(this.dent3);
            this.Controls.Add(this.dent2);
            this.Controls.Add(this.dent1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturedent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturedent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturedent1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.PictureBox dent1;
        private System.Windows.Forms.PictureBox dent2;
        private System.Windows.Forms.PictureBox dent3;
        private System.Windows.Forms.PictureBox mainPic;
        private System.Windows.Forms.PictureBox picturedent3;
        private System.Windows.Forms.PictureBox picturedent2;
        private System.Windows.Forms.PictureBox picturedent1;
        private System.Windows.Forms.Timer dent2_right;
        private System.Windows.Forms.Timer dent2_left;
        private System.Windows.Forms.Timer dent2_up;
        private System.Windows.Forms.Timer dent2_down;
        private System.Windows.Forms.Timer dent3_right;
        private System.Windows.Forms.Timer dent3_left;
        private System.Windows.Forms.Timer dent3_up;
        private System.Windows.Forms.Timer dent3_down;
    }
}

