namespace HorseRace
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pc3 = new System.Windows.Forms.PictureBox();
            this.pc2 = new System.Windows.Forms.PictureBox();
            this.pc1 = new System.Windows.Forms.PictureBox();
            this.btnYarisiBaslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFinish = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1296, 10);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1296, 10);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1296, 10);
            this.label3.TabIndex = 2;
            // 
            // pc3
            // 
            this.pc3.Image = global::HorseRace.Properties.Resources.horse5;
            this.pc3.Location = new System.Drawing.Point(0, 207);
            this.pc3.Name = "pc3";
            this.pc3.Size = new System.Drawing.Size(100, 50);
            this.pc3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc3.TabIndex = 5;
            this.pc3.TabStop = false;
            // 
            // pc2
            // 
            this.pc2.Image = global::HorseRace.Properties.Resources.horse3;
            this.pc2.Location = new System.Drawing.Point(0, 273);
            this.pc2.Name = "pc2";
            this.pc2.Size = new System.Drawing.Size(100, 50);
            this.pc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc2.TabIndex = 4;
            this.pc2.TabStop = false;
            // 
            // pc1
            // 
            this.pc1.Image = global::HorseRace.Properties.Resources.horse1;
            this.pc1.Location = new System.Drawing.Point(0, 339);
            this.pc1.Name = "pc1";
            this.pc1.Size = new System.Drawing.Size(100, 50);
            this.pc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pc1.TabIndex = 3;
            this.pc1.TabStop = false;
            // 
            // btnYarisiBaslat
            // 
            this.btnYarisiBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYarisiBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYarisiBaslat.ForeColor = System.Drawing.Color.White;
            this.btnYarisiBaslat.Location = new System.Drawing.Point(1004, 25);
            this.btnYarisiBaslat.Name = "btnYarisiBaslat";
            this.btnYarisiBaslat.Size = new System.Drawing.Size(292, 67);
            this.btnYarisiBaslat.TabIndex = 6;
            this.btnYarisiBaslat.Text = "Yarışı Başlat";
            this.btnYarisiBaslat.UseVisualStyleBackColor = true;
            this.btnYarisiBaslat.Click += new System.EventHandler(this.BtnYarisiBaslat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.White;
            this.lblFinish.Location = new System.Drawing.Point(1286, 230);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(10, 214);
            this.lblFinish.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1327, 527);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.btnYarisiBaslat);
            this.Controls.Add(this.pc3);
            this.Controls.Add(this.pc2);
            this.Controls.Add(this.pc1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pc1;
        private System.Windows.Forms.PictureBox pc2;
        private System.Windows.Forms.PictureBox pc3;
        private System.Windows.Forms.Button btnYarisiBaslat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFinish;
    }
}

