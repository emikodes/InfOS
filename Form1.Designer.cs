
namespace InfOS
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CPU = new System.Windows.Forms.TextBox();
            this.GPU = new System.Windows.Forms.TextBox();
            this.NICS = new System.Windows.Forms.TextBox();
            this.TRACKPAD = new System.Windows.Forms.TextBox();
            this.KEYBOARD = new System.Windows.Forms.TextBox();
            this.MODEL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CPUFAMILY = new System.Windows.Forms.TextBox();
            this.thirtytwo = new System.Windows.Forms.RadioButton();
            this.sixtyfour = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.MOBO = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.Salva = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 15.75F);
            this.label2.Location = new System.Drawing.Point(44, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "GPU\'s: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 15.75F);
            this.label4.Location = new System.Drawing.Point(44, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIC\'S:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bebas Neue", 15.75F);
            this.label6.Location = new System.Drawing.Point(44, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "TrackPad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bebas Neue", 15.75F);
            this.label7.Location = new System.Drawing.Point(44, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Keyboard Interface:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bebas Neue", 15.75F);
            this.label8.Location = new System.Drawing.Point(44, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Model:";
            // 
            // CPU
            // 
            this.CPU.HideSelection = false;
            this.CPU.Location = new System.Drawing.Point(221, 99);
            this.CPU.Name = "CPU";
            this.CPU.ReadOnly = true;
            this.CPU.Size = new System.Drawing.Size(530, 20);
            this.CPU.TabIndex = 8;
            // 
            // GPU
            // 
            this.GPU.Location = new System.Drawing.Point(221, 144);
            this.GPU.Name = "GPU";
            this.GPU.ReadOnly = true;
            this.GPU.Size = new System.Drawing.Size(530, 20);
            this.GPU.TabIndex = 9;
            // 
            // NICS
            // 
            this.NICS.Location = new System.Drawing.Point(221, 225);
            this.NICS.Name = "NICS";
            this.NICS.ReadOnly = true;
            this.NICS.Size = new System.Drawing.Size(530, 20);
            this.NICS.TabIndex = 11;
            // 
            // TRACKPAD
            // 
            this.TRACKPAD.Location = new System.Drawing.Point(221, 268);
            this.TRACKPAD.Name = "TRACKPAD";
            this.TRACKPAD.ReadOnly = true;
            this.TRACKPAD.Size = new System.Drawing.Size(530, 20);
            this.TRACKPAD.TabIndex = 13;
            // 
            // KEYBOARD
            // 
            this.KEYBOARD.Location = new System.Drawing.Point(221, 309);
            this.KEYBOARD.Name = "KEYBOARD";
            this.KEYBOARD.ReadOnly = true;
            this.KEYBOARD.Size = new System.Drawing.Size(530, 20);
            this.KEYBOARD.TabIndex = 14;
            // 
            // MODEL
            // 
            this.MODEL.Location = new System.Drawing.Point(221, 345);
            this.MODEL.Name = "MODEL";
            this.MODEL.ReadOnly = true;
            this.MODEL.Size = new System.Drawing.Size(530, 20);
            this.MODEL.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 15.75F);
            this.label3.Location = new System.Drawing.Point(44, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "CPU Family/Series:";
            // 
            // CPUFAMILY
            // 
            this.CPUFAMILY.Location = new System.Drawing.Point(221, 183);
            this.CPUFAMILY.Name = "CPUFAMILY";
            this.CPUFAMILY.ReadOnly = true;
            this.CPUFAMILY.Size = new System.Drawing.Size(530, 20);
            this.CPUFAMILY.TabIndex = 17;
            // 
            // thirtytwo
            // 
            this.thirtytwo.AutoSize = true;
            this.thirtytwo.Enabled = false;
            this.thirtytwo.Location = new System.Drawing.Point(268, 446);
            this.thirtytwo.Name = "thirtytwo";
            this.thirtytwo.Size = new System.Drawing.Size(78, 17);
            this.thirtytwo.TabIndex = 18;
            this.thirtytwo.TabStop = true;
            this.thirtytwo.Text = "x86 (32 Bit)";
            this.thirtytwo.UseVisualStyleBackColor = true;
            // 
            // sixtyfour
            // 
            this.sixtyfour.AutoSize = true;
            this.sixtyfour.Location = new System.Drawing.Point(466, 446);
            this.sixtyfour.Name = "sixtyfour";
            this.sixtyfour.Size = new System.Drawing.Size(78, 17);
            this.sixtyfour.TabIndex = 19;
            this.sixtyfour.TabStop = true;
            this.sixtyfour.Text = "x64 (64 Bit)";
            this.sixtyfour.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 15.75F);
            this.label5.Location = new System.Drawing.Point(44, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "MotherBoard Name:";
            // 
            // MOBO
            // 
            this.MOBO.Location = new System.Drawing.Point(221, 387);
            this.MOBO.Name = "MOBO";
            this.MOBO.ReadOnly = true;
            this.MOBO.Size = new System.Drawing.Size(530, 20);
            this.MOBO.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Save Report";
            // 
            // Salva
            // 
            this.Salva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Salva.BackColor = System.Drawing.Color.White;
            this.Salva.BackgroundImage = global::InfOS.Properties.Resources.download;
            this.Salva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Salva.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Salva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salva.ForeColor = System.Drawing.Color.Transparent;
            this.Salva.Location = new System.Drawing.Point(49, 428);
            this.Salva.Name = "Salva";
            this.Salva.Size = new System.Drawing.Size(57, 54);
            this.Salva.TabIndex = 22;
            this.Salva.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Salva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Salva.UseVisualStyleBackColor = false;
            this.Salva.Click += new System.EventHandler(this.Salva_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::InfOS.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(325, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Salva);
            this.Controls.Add(this.MOBO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sixtyfour);
            this.Controls.Add(this.thirtytwo);
            this.Controls.Add(this.CPUFAMILY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MODEL);
            this.Controls.Add(this.KEYBOARD);
            this.Controls.Add(this.TRACKPAD);
            this.Controls.Add(this.NICS);
            this.Controls.Add(this.GPU);
            this.Controls.Add(this.CPU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "InfOS";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.HelpButtonEvent);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CPU;
        private System.Windows.Forms.TextBox GPU;
        private System.Windows.Forms.TextBox NICS;
        private System.Windows.Forms.TextBox TRACKPAD;
        private System.Windows.Forms.TextBox KEYBOARD;
        private System.Windows.Forms.TextBox MODEL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CPUFAMILY;
        private System.Windows.Forms.RadioButton thirtytwo;
        private System.Windows.Forms.RadioButton sixtyfour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MOBO;
        private System.Windows.Forms.Button Salva;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

