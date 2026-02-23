namespace firstForm
{
    partial class SPECIES
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
            this.gvSpecies = new System.Windows.Forms.DataGridView();
            this.lbInformation = new System.Windows.Forms.Label();
            this.btShow = new System.Windows.Forms.Button();
            this.gvBreed = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видЖивотноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.породаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактирайToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSpecies = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPriceSpecies = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNameSpecies = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btmAddSpecies = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSpecies = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPercentBreed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNameBreed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btAddBreed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvSpecies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBreed)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelSpecies.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvSpecies
            // 
            this.gvSpecies.AllowUserToDeleteRows = false;
            this.gvSpecies.AllowUserToOrderColumns = true;
            this.gvSpecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSpecies.Location = new System.Drawing.Point(41, 39);
            this.gvSpecies.Name = "gvSpecies";
            this.gvSpecies.Size = new System.Drawing.Size(389, 264);
            this.gvSpecies.TabIndex = 0;
            this.gvSpecies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.gvSpecies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbInformation
            // 
            this.lbInformation.AutoSize = true;
            this.lbInformation.Location = new System.Drawing.Point(60, 356);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(0, 13);
            this.lbInformation.TabIndex = 2;
            // 
            // btShow
            // 
            this.btShow.Location = new System.Drawing.Point(410, 324);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(116, 45);
            this.btShow.TabIndex = 3;
            this.btShow.Text = "Покажи";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // gvBreed
            // 
            this.gvBreed.AllowUserToDeleteRows = false;
            this.gvBreed.AllowUserToOrderColumns = true;
            this.gvBreed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBreed.Location = new System.Drawing.Point(494, 39);
            this.gvBreed.Name = "gvBreed";
            this.gvBreed.Size = new System.Drawing.Size(343, 264);
            this.gvBreed.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавиToolStripMenuItem,
            this.редактирайToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавиToolStripMenuItem
            // 
            this.добавиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видЖивотноToolStripMenuItem,
            this.породаToolStripMenuItem});
            this.добавиToolStripMenuItem.Name = "добавиToolStripMenuItem";
            this.добавиToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.добавиToolStripMenuItem.Text = "Добави";
            // 
            // видЖивотноToolStripMenuItem
            // 
            this.видЖивотноToolStripMenuItem.Name = "видЖивотноToolStripMenuItem";
            this.видЖивотноToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.видЖивотноToolStripMenuItem.Text = "Вид животно";
            // 
            // породаToolStripMenuItem
            // 
            this.породаToolStripMenuItem.Name = "породаToolStripMenuItem";
            this.породаToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.породаToolStripMenuItem.Text = "Порода";
            // 
            // редактирайToolStripMenuItem
            // 
            this.редактирайToolStripMenuItem.Name = "редактирайToolStripMenuItem";
            this.редактирайToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.редактирайToolStripMenuItem.Text = "Редактирай";
            // 
            // panelSpecies
            // 
            this.panelSpecies.Controls.Add(this.label3);
            this.panelSpecies.Controls.Add(this.tbPriceSpecies);
            this.panelSpecies.Controls.Add(this.label2);
            this.panelSpecies.Controls.Add(this.tbNameSpecies);
            this.panelSpecies.Controls.Add(this.label1);
            this.panelSpecies.Controls.Add(this.btmAddSpecies);
            this.panelSpecies.Location = new System.Drawing.Point(50, 396);
            this.panelSpecies.Name = "panelSpecies";
            this.panelSpecies.Size = new System.Drawing.Size(404, 196);
            this.panelSpecies.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID се генерира автоматично от системата";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbPriceSpecies
            // 
            this.tbPriceSpecies.Location = new System.Drawing.Point(186, 75);
            this.tbPriceSpecies.Name = "tbPriceSpecies";
            this.tbPriceSpecies.Size = new System.Drawing.Size(100, 20);
            this.tbPriceSpecies.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Начална цена за преглед";
            // 
            // tbNameSpecies
            // 
            this.tbNameSpecies.Location = new System.Drawing.Point(186, 35);
            this.tbNameSpecies.Name = "tbNameSpecies";
            this.tbNameSpecies.Size = new System.Drawing.Size(100, 20);
            this.tbNameSpecies.TabIndex = 2;
            this.tbNameSpecies.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Име";
            // 
            // btmAddSpecies
            // 
            this.btmAddSpecies.Location = new System.Drawing.Point(173, 131);
            this.btmAddSpecies.Name = "btmAddSpecies";
            this.btmAddSpecies.Size = new System.Drawing.Size(204, 45);
            this.btmAddSpecies.TabIndex = 0;
            this.btmAddSpecies.Text = "Добави вида животно";
            this.btmAddSpecies.UseVisualStyleBackColor = true;
            this.btmAddSpecies.Click += new System.EventHandler(this.btmAddSpecies_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbSpecies);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbPercentBreed);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbNameBreed);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btAddBreed);
            this.panel1.Location = new System.Drawing.Point(494, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 201);
            this.panel1.TabIndex = 8;
            // 
            // cbSpecies
            // 
            this.cbSpecies.FormattingEnabled = true;
            this.cbSpecies.Location = new System.Drawing.Point(186, 18);
            this.cbSpecies.Name = "cbSpecies";
            this.cbSpecies.Size = new System.Drawing.Size(100, 21);
            this.cbSpecies.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Вид";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID се генерира автоматично от системата";
            // 
            // tbPercentBreed
            // 
            this.tbPercentBreed.Location = new System.Drawing.Point(186, 75);
            this.tbPercentBreed.Name = "tbPercentBreed";
            this.tbPercentBreed.Size = new System.Drawing.Size(100, 20);
            this.tbPercentBreed.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Начална цена за преглед";
            // 
            // tbNameBreed
            // 
            this.tbNameBreed.Location = new System.Drawing.Point(186, 47);
            this.tbNameBreed.Name = "tbNameBreed";
            this.tbNameBreed.Size = new System.Drawing.Size(100, 20);
            this.tbNameBreed.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Име";
            // 
            // btAddBreed
            // 
            this.btAddBreed.Location = new System.Drawing.Point(173, 131);
            this.btAddBreed.Name = "btAddBreed";
            this.btAddBreed.Size = new System.Drawing.Size(204, 45);
            this.btAddBreed.TabIndex = 0;
            this.btAddBreed.Text = "Добави вида животно";
            this.btAddBreed.UseVisualStyleBackColor = true;
            this.btAddBreed.Click += new System.EventHandler(this.button1_Click);
            // 
            // SPECIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSpecies);
            this.Controls.Add(this.gvBreed);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.gvSpecies);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SPECIES";
            this.Text = "SPECIES";
            this.Load += new System.EventHandler(this.SPECIES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSpecies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBreed)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSpecies.ResumeLayout(false);
            this.panelSpecies.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvSpecies;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.DataGridView gvBreed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видЖивотноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem породаToolStripMenuItem;
        private System.Windows.Forms.Panel panelSpecies;
        private System.Windows.Forms.Button btmAddSpecies;
        private System.Windows.Forms.TextBox tbPriceSpecies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNameSpecies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem редактирайToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSpecies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPercentBreed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNameBreed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAddBreed;
    }
}