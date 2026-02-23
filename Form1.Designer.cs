namespace firstForm
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
            this.gvVetList = new System.Windows.Forms.DataGridView();
            this.btnNewVet = new System.Windows.Forms.Button();
            this.btnDelVet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbSearchOptions = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvVetList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvVetList
            // 
            this.gvVetList.AllowUserToAddRows = false;
            this.gvVetList.AllowUserToDeleteRows = false;
            this.gvVetList.AllowUserToOrderColumns = true;
            this.gvVetList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvVetList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvVetList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.gvVetList.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.gvVetList.Location = new System.Drawing.Point(12, 129);
            this.gvVetList.Name = "gvVetList";
            this.gvVetList.ReadOnly = true;
            this.gvVetList.Size = new System.Drawing.Size(830, 150);
            this.gvVetList.TabIndex = 0;
            this.gvVetList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnNewVet
            // 
            this.btnNewVet.Location = new System.Drawing.Point(83, 316);
            this.btnNewVet.Name = "btnNewVet";
            this.btnNewVet.Size = new System.Drawing.Size(131, 23);
            this.btnNewVet.TabIndex = 18;
            this.btnNewVet.Text = "Add New Vet";
            this.btnNewVet.UseVisualStyleBackColor = true;
            this.btnNewVet.Click += new System.EventHandler(this.btnNewVet_Click);
            // 
            // btnDelVet
            // 
            this.btnDelVet.Location = new System.Drawing.Point(357, 316);
            this.btnDelVet.Name = "btnDelVet";
            this.btnDelVet.Size = new System.Drawing.Size(131, 23);
            this.btnDelVet.TabIndex = 19;
            this.btnDelVet.Text = "Delete Vet";
            this.btnDelVet.UseVisualStyleBackColor = true;
            this.btnDelVet.Click += new System.EventHandler(this.btnDelVet_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(631, 316);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update Vet";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(178, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(298, 20);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbSearchOptions
            // 
            this.cbSearchOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSearchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchOptions.FormattingEnabled = true;
            this.cbSearchOptions.Items.AddRange(new object[] {
            "Номер на ветеринар",
            "Име",
            "Фамилия",
            "Телефон",
            "Имейл",
            "Образование",
            "Позиция",
            "Процент"});
            this.cbSearchOptions.Location = new System.Drawing.Point(574, 37);
            this.cbSearchOptions.Name = "cbSearchOptions";
            this.cbSearchOptions.Size = new System.Drawing.Size(121, 21);
            this.cbSearchOptions.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(853, 366);
            this.Controls.Add(this.cbSearchOptions);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelVet);
            this.Controls.Add(this.btnNewVet);
            this.Controls.Add(this.gvVetList);
            this.Name = "Form1";
            this.Text = "Ветеринари";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvVetList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvVetList;
        private System.Windows.Forms.Button btnNewVet;
        private System.Windows.Forms.Button btnDelVet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbSearchOptions;
    }
}

