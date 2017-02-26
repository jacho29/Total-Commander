namespace Commander
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
            this.cmdKopiuj = new System.Windows.Forms.Button();
            this.cmdUsun = new System.Windows.Forms.Button();
            this.cmdPrzenies = new System.Windows.Forms.Button();
            this.lvOkno1 = new System.Windows.Forms.ListView();
            this.lvOkno2 = new System.Windows.Forms.ListView();
            this.Dysk1 = new System.Windows.Forms.ComboBox();
            this.Dysk2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdKopiuj
            // 
            this.cmdKopiuj.Location = new System.Drawing.Point(30, 319);
            this.cmdKopiuj.Name = "cmdKopiuj";
            this.cmdKopiuj.Size = new System.Drawing.Size(127, 58);
            this.cmdKopiuj.TabIndex = 4;
            this.cmdKopiuj.Text = "KOPIUJ\r\n   F6\r\n";
            this.cmdKopiuj.UseVisualStyleBackColor = true;
            this.cmdKopiuj.Click += new System.EventHandler(this.cmdKopiuj_Click);
            // 
            // cmdUsun
            // 
            this.cmdUsun.Location = new System.Drawing.Point(188, 319);
            this.cmdUsun.Name = "cmdUsun";
            this.cmdUsun.Size = new System.Drawing.Size(127, 58);
            this.cmdUsun.TabIndex = 5;
            this.cmdUsun.Text = "USUŃ\r\n   F7";
            this.cmdUsun.UseVisualStyleBackColor = true;
            this.cmdUsun.Click += new System.EventHandler(this.cmdUsun_Click);
            // 
            // cmdPrzenies
            // 
            this.cmdPrzenies.Location = new System.Drawing.Point(353, 319);
            this.cmdPrzenies.Name = "cmdPrzenies";
            this.cmdPrzenies.Size = new System.Drawing.Size(127, 58);
            this.cmdPrzenies.TabIndex = 8;
            this.cmdPrzenies.Text = "PRZENIEŚ\r\n    F8";
            this.cmdPrzenies.UseVisualStyleBackColor = true;
            this.cmdPrzenies.Click += new System.EventHandler(this.cmdPrzenies_Click);
            // 
            // lvOkno1
            // 
            this.lvOkno1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvOkno1.FullRowSelect = true;
            this.lvOkno1.HideSelection = false;
            this.lvOkno1.Location = new System.Drawing.Point(30, 55);
            this.lvOkno1.Name = "lvOkno1";
            this.lvOkno1.Size = new System.Drawing.Size(202, 232);
            this.lvOkno1.TabIndex = 9;
            this.lvOkno1.TileSize = new System.Drawing.Size(220, 15);
            this.lvOkno1.UseCompatibleStateImageBehavior = false;
            this.lvOkno1.View = System.Windows.Forms.View.Tile;
            this.lvOkno1.Enter += new System.EventHandler(this.lvOkno1_Enter);
            this.lvOkno1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvOkno_KeyDown);
            this.lvOkno1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvOkno_MouseDoubleClick);
            // 
            // lvOkno2
            // 
            this.lvOkno2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvOkno2.FullRowSelect = true;
            this.lvOkno2.HideSelection = false;
            this.lvOkno2.Location = new System.Drawing.Point(277, 55);
            this.lvOkno2.Name = "lvOkno2";
            this.lvOkno2.Size = new System.Drawing.Size(203, 232);
            this.lvOkno2.TabIndex = 10;
            this.lvOkno2.TileSize = new System.Drawing.Size(220, 15);
            this.lvOkno2.UseCompatibleStateImageBehavior = false;
            this.lvOkno2.View = System.Windows.Forms.View.Tile;
            this.lvOkno2.Enter += new System.EventHandler(this.lvOkno2_Enter);
            this.lvOkno2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvOkno_KeyDown);
            this.lvOkno2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvOkno_MouseDoubleClick);
            // 
            // Dysk1
            // 
            this.Dysk1.FormattingEnabled = true;
            this.Dysk1.Location = new System.Drawing.Point(30, 12);
            this.Dysk1.Name = "Dysk1";
            this.Dysk1.Size = new System.Drawing.Size(121, 21);
            this.Dysk1.TabIndex = 11;
            this.Dysk1.SelectedIndexChanged += new System.EventHandler(this.Dysk1_SelectedIndexChanged);
            // 
            // Dysk2
            // 
            this.Dysk2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dysk2.FormattingEnabled = true;
            this.Dysk2.Location = new System.Drawing.Point(277, 12);
            this.Dysk2.Name = "Dysk2";
            this.Dysk2.Size = new System.Drawing.Size(121, 21);
            this.Dysk2.TabIndex = 12;
            this.Dysk2.SelectedIndexChanged += new System.EventHandler(this.Dysk2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 413);
            this.Controls.Add(this.Dysk2);
            this.Controls.Add(this.Dysk1);
            this.Controls.Add(this.lvOkno2);
            this.Controls.Add(this.lvOkno1);
            this.Controls.Add(this.cmdPrzenies);
            this.Controls.Add(this.cmdUsun);
            this.Controls.Add(this.cmdKopiuj);
            this.Name = "Form1";
            this.Text = "Commander by Piotr Jaśkiewicz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdKopiuj;
        private System.Windows.Forms.Button cmdUsun;
        private System.Windows.Forms.Button cmdPrzenies;
        private System.Windows.Forms.ListView lvOkno1;
        private System.Windows.Forms.ListView lvOkno2;
        private System.Windows.Forms.ComboBox Dysk1;
        private System.Windows.Forms.ComboBox Dysk2;
    }
}

