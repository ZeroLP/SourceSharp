namespace SourceSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LocalPlayerText = new System.Windows.Forms.Label();
            this.DisplayHealth = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Aimbot = new System.Windows.Forms.CheckBox();
            this.InfinitePistolM = new System.Windows.Forms.CheckBox();
            this.InfinitePistolA = new System.Windows.Forms.CheckBox();
            this.InfiniteHealth = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DisplayPosition = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocalPlayerText
            // 
            this.LocalPlayerText.AutoSize = true;
            this.LocalPlayerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalPlayerText.Location = new System.Drawing.Point(431, 36);
            this.LocalPlayerText.Name = "LocalPlayerText";
            this.LocalPlayerText.Size = new System.Drawing.Size(95, 20);
            this.LocalPlayerText.TabIndex = 4;
            this.LocalPlayerText.Text = "Info Section";
            // 
            // DisplayHealth
            // 
            this.DisplayHealth.AutoSize = true;
            this.DisplayHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayHealth.Location = new System.Drawing.Point(8, 30);
            this.DisplayHealth.Name = "DisplayHealth";
            this.DisplayHealth.Size = new System.Drawing.Size(149, 22);
            this.DisplayHealth.TabIndex = 5;
            this.DisplayHealth.Text = "Display Health Info";
            this.DisplayHealth.UseVisualStyleBackColor = true;
            this.DisplayHealth.CheckedChanged += new System.EventHandler(this.DisplayHealth_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Aimbot);
            this.groupBox1.Controls.Add(this.InfinitePistolM);
            this.groupBox1.Controls.Add(this.InfinitePistolA);
            this.groupBox1.Controls.Add(this.InfiniteHealth);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 202);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hacks";
            // 
            // Aimbot
            // 
            this.Aimbot.AutoSize = true;
            this.Aimbot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aimbot.Location = new System.Drawing.Point(6, 114);
            this.Aimbot.Name = "Aimbot";
            this.Aimbot.Size = new System.Drawing.Size(124, 22);
            this.Aimbot.TabIndex = 11;
            this.Aimbot.Text = "Aimbot(Buggy)";
            this.Aimbot.UseVisualStyleBackColor = true;
            this.Aimbot.CheckedChanged += new System.EventHandler(this.Aimbot_CheckedChanged);
            // 
            // InfinitePistolM
            // 
            this.InfinitePistolM.AutoSize = true;
            this.InfinitePistolM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfinitePistolM.Location = new System.Drawing.Point(6, 86);
            this.InfinitePistolM.Name = "InfinitePistolM";
            this.InfinitePistolM.Size = new System.Drawing.Size(148, 22);
            this.InfinitePistolM.TabIndex = 10;
            this.InfinitePistolM.Text = "Infinite Mag(Pistol)";
            this.InfinitePistolM.UseVisualStyleBackColor = true;
            this.InfinitePistolM.CheckedChanged += new System.EventHandler(this.InfinitePistolM_CheckedChanged);
            // 
            // InfinitePistolA
            // 
            this.InfinitePistolA.AutoSize = true;
            this.InfinitePistolA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfinitePistolA.Location = new System.Drawing.Point(6, 58);
            this.InfinitePistolA.Name = "InfinitePistolA";
            this.InfinitePistolA.Size = new System.Drawing.Size(163, 22);
            this.InfinitePistolA.TabIndex = 9;
            this.InfinitePistolA.Text = "Infinite Ammo(Pistol)";
            this.InfinitePistolA.UseVisualStyleBackColor = true;
            this.InfinitePistolA.CheckedChanged += new System.EventHandler(this.InfinitePistolA_CheckedChanged);
            // 
            // InfiniteHealth
            // 
            this.InfiniteHealth.AutoSize = true;
            this.InfiniteHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfiniteHealth.Location = new System.Drawing.Point(6, 30);
            this.InfiniteHealth.Name = "InfiniteHealth";
            this.InfiniteHealth.Size = new System.Drawing.Size(114, 22);
            this.InfiniteHealth.TabIndex = 8;
            this.InfiniteHealth.Text = "Infinite Health";
            this.InfiniteHealth.UseVisualStyleBackColor = true;
            this.InfiniteHealth.CheckedChanged += new System.EventHandler(this.InfiniteHealth_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DisplayPosition);
            this.groupBox2.Controls.Add(this.DisplayHealth);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(181, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 202);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informatic";
            // 
            // DisplayPosition
            // 
            this.DisplayPosition.AutoSize = true;
            this.DisplayPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayPosition.Location = new System.Drawing.Point(6, 58);
            this.DisplayPosition.Name = "DisplayPosition";
            this.DisplayPosition.Size = new System.Drawing.Size(161, 22);
            this.DisplayPosition.TabIndex = 6;
            this.DisplayPosition.Text = "Display Position Info";
            this.DisplayPosition.UseVisualStyleBackColor = true;
            this.DisplayPosition.CheckedChanged += new System.EventHandler(this.DisplayPosition_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 249);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LocalPlayerText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SourceSharp";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LocalPlayerText;
        private System.Windows.Forms.CheckBox DisplayHealth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Aimbot;
        private System.Windows.Forms.CheckBox InfinitePistolM;
        private System.Windows.Forms.CheckBox InfinitePistolA;
        private System.Windows.Forms.CheckBox InfiniteHealth;
        private System.Windows.Forms.CheckBox DisplayPosition;
    }
}

