
namespace rouletteBet
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.guna2TrackBar3 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.guna2TrackBar4 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.baslaButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button41 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TrackBar2 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2TrackBar1
            // 
            this.guna2TrackBar1.HoverState.Parent = this.guna2TrackBar1;
            this.guna2TrackBar1.Location = new System.Drawing.Point(0, 0);
            this.guna2TrackBar1.Name = "guna2TrackBar1";
            this.guna2TrackBar1.Size = new System.Drawing.Size(300, 23);
            this.guna2TrackBar1.TabIndex = 28;
            this.guna2TrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            // 
            // guna2TrackBar3
            // 
            this.guna2TrackBar3.HoverState.Parent = this.guna2TrackBar3;
            this.guna2TrackBar3.Location = new System.Drawing.Point(294, 49);
            this.guna2TrackBar3.Maximum = 3;
            this.guna2TrackBar3.Name = "guna2TrackBar3";
            this.guna2TrackBar3.Size = new System.Drawing.Size(151, 23);
            this.guna2TrackBar3.TabIndex = 10;
            this.guna2TrackBar3.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(129)))), ((int)(((byte)(127)))));
            this.guna2TrackBar3.Value = 0;
            this.guna2TrackBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar3_Scroll);
            // 
            // guna2TrackBar4
            // 
            this.guna2TrackBar4.HoverState.Parent = this.guna2TrackBar4;
            this.guna2TrackBar4.Location = new System.Drawing.Point(0, 0);
            this.guna2TrackBar4.Name = "guna2TrackBar4";
            this.guna2TrackBar4.Size = new System.Drawing.Size(300, 23);
            this.guna2TrackBar4.TabIndex = 27;
            this.guna2TrackBar4.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Round Limit";
            // 
            // baslaButton
            // 
            this.baslaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(73)))));
            this.baslaButton.FlatAppearance.BorderSize = 0;
            this.baslaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baslaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslaButton.ForeColor = System.Drawing.Color.White;
            this.baslaButton.Location = new System.Drawing.Point(12, 88);
            this.baslaButton.Name = "baslaButton";
            this.baslaButton.Size = new System.Drawing.Size(490, 59);
            this.baslaButton.TabIndex = 16;
            this.baslaButton.Text = "START";
            this.baslaButton.UseVisualStyleBackColor = false;
            this.baslaButton.Click += new System.EventHandler(this.baslaButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.panel3.Controls.Add(this.button41);
            this.panel3.Controls.Add(this.button40);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(514, 32);
            this.panel3.TabIndex = 18;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // button41
            // 
            this.button41.FlatAppearance.BorderSize = 0;
            this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button41.ForeColor = System.Drawing.Color.White;
            this.button41.Location = new System.Drawing.Point(451, 0);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(32, 32);
            this.button41.TabIndex = 19;
            this.button41.Text = "_";
            this.button41.UseVisualStyleBackColor = true;
            this.button41.Click += new System.EventHandler(this.button41_Click);
            // 
            // button40
            // 
            this.button40.FlatAppearance.BorderSize = 0;
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.ForeColor = System.Drawing.Color.White;
            this.button40.Location = new System.Drawing.Point(482, 0);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(32, 32);
            this.button40.TabIndex = 0;
            this.button40.Text = "X";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(449, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Unlimited";
            // 
            // guna2TrackBar2
            // 
            this.guna2TrackBar2.HoverState.Parent = this.guna2TrackBar2;
            this.guna2TrackBar2.Location = new System.Drawing.Point(42, 49);
            this.guna2TrackBar2.Maximum = 1;
            this.guna2TrackBar2.Name = "guna2TrackBar2";
            this.guna2TrackBar2.Size = new System.Drawing.Size(151, 23);
            this.guna2TrackBar2.TabIndex = 8;
            this.guna2TrackBar2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(129)))), ((int)(((byte)(127)))));
            this.guna2TrackBar2.Value = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "15";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(514, 164);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.baslaButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2TrackBar3);
            this.Controls.Add(this.guna2TrackBar4);
            this.Controls.Add(this.guna2TrackBar2);
            this.Controls.Add(this.guna2TrackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar3;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button baslaButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar2;
        private System.Windows.Forms.Label label5;
    }
}

