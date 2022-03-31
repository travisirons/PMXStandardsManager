namespace pmxLayerCreate
{
    partial class LayerCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayerCreate));
            this.lstGroups = new System.Windows.Forms.ListBox();
            this.btnAddtoDrawing = new System.Windows.Forms.Button();
            this.lstViewLayerList = new System.Windows.Forms.ListView();
            this.colLayerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLayerDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLayerColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLayerLinetype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmdDiscipline = new System.Windows.Forms.ComboBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.chkFilterExisting = new System.Windows.Forms.CheckBox();
            this.chkFilterSymbol = new System.Windows.Forms.CheckBox();
            this.chkFilterText = new System.Windows.Forms.CheckBox();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.grpSuffix = new System.Windows.Forms.GroupBox();
            this.cmbLayerSuffix = new System.Windows.Forms.ComboBox();
            this.chkAddLayerOverwrite = new System.Windows.Forms.CheckBox();
            this.lblLayerCount = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpSearch.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpSuffix.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstGroups
            // 
            this.lstGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstGroups.FormattingEnabled = true;
            this.lstGroups.Location = new System.Drawing.Point(12, 69);
            this.lstGroups.Name = "lstGroups";
            this.lstGroups.Size = new System.Drawing.Size(181, 301);
            this.lstGroups.TabIndex = 0;
            this.lstGroups.SelectedIndexChanged += new System.EventHandler(this.lstGroups_SelectedIndexChanged);
            // 
            // btnAddtoDrawing
            // 
            this.btnAddtoDrawing.Location = new System.Drawing.Point(12, 404);
            this.btnAddtoDrawing.Name = "btnAddtoDrawing";
            this.btnAddtoDrawing.Size = new System.Drawing.Size(181, 38);
            this.btnAddtoDrawing.TabIndex = 1;
            this.btnAddtoDrawing.Text = "<< Add to Drawing";
            this.btnAddtoDrawing.UseVisualStyleBackColor = true;
            this.btnAddtoDrawing.Click += new System.EventHandler(this.btnAddtoDrawing_Click);
            // 
            // lstViewLayerList
            // 
            this.lstViewLayerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstViewLayerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLayerName,
            this.colLayerDescription,
            this.colLayerColor,
            this.colLayerLinetype});
            this.lstViewLayerList.FullRowSelect = true;
            this.lstViewLayerList.GridLines = true;
            this.lstViewLayerList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstViewLayerList.HideSelection = false;
            this.lstViewLayerList.Location = new System.Drawing.Point(211, 69);
            this.lstViewLayerList.Name = "lstViewLayerList";
            this.lstViewLayerList.Size = new System.Drawing.Size(856, 373);
            this.lstViewLayerList.TabIndex = 2;
            this.lstViewLayerList.UseCompatibleStateImageBehavior = false;
            this.lstViewLayerList.View = System.Windows.Forms.View.Details;
            // 
            // colLayerName
            // 
            this.colLayerName.Text = "Layer Name";
            this.colLayerName.Width = 200;
            // 
            // colLayerDescription
            // 
            this.colLayerDescription.Text = "Layer Description";
            this.colLayerDescription.Width = 356;
            // 
            // colLayerColor
            // 
            this.colLayerColor.Text = "Color";
            this.colLayerColor.Width = 79;
            // 
            // colLayerLinetype
            // 
            this.colLayerLinetype.Text = "Linetype";
            this.colLayerLinetype.Width = 211;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(9, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(481, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmdDiscipline
            // 
            this.cmdDiscipline.FormattingEnabled = true;
            this.cmdDiscipline.Location = new System.Drawing.Point(12, 31);
            this.cmdDiscipline.Name = "cmdDiscipline";
            this.cmdDiscipline.Size = new System.Drawing.Size(181, 21);
            this.cmdDiscipline.TabIndex = 4;
            this.cmdDiscipline.SelectedIndexChanged += new System.EventHandler(this.cmdDiscipline_SelectedIndexChanged);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Location = new System.Drawing.Point(211, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(499, 51);
            this.grpSearch.TabIndex = 5;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.chkFilterExisting);
            this.grpFilter.Controls.Add(this.chkFilterSymbol);
            this.grpFilter.Controls.Add(this.chkFilterText);
            this.grpFilter.Location = new System.Drawing.Point(719, 12);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(170, 51);
            this.grpFilter.TabIndex = 6;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // chkFilterExisting
            // 
            this.chkFilterExisting.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFilterExisting.AutoSize = true;
            this.chkFilterExisting.Location = new System.Drawing.Point(109, 18);
            this.chkFilterExisting.Name = "chkFilterExisting";
            this.chkFilterExisting.Size = new System.Drawing.Size(53, 23);
            this.chkFilterExisting.TabIndex = 13;
            this.chkFilterExisting.Text = "Existing";
            this.chkFilterExisting.UseVisualStyleBackColor = true;
            this.chkFilterExisting.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkFilterExisting_CheckedChanged);
            // 
            // chkFilterSymbol
            // 
            this.chkFilterSymbol.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFilterSymbol.AutoSize = true;
            this.chkFilterSymbol.Location = new System.Drawing.Point(52, 18);
            this.chkFilterSymbol.Name = "chkFilterSymbol";
            this.chkFilterSymbol.Size = new System.Drawing.Size(51, 23);
            this.chkFilterSymbol.TabIndex = 12;
            this.chkFilterSymbol.Text = "Symbol";
            this.chkFilterSymbol.UseVisualStyleBackColor = true;
            this.chkFilterSymbol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkFilterSymbol_CheckedChanged);
            // 
            // chkFilterText
            // 
            this.chkFilterText.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFilterText.AutoSize = true;
            this.chkFilterText.Location = new System.Drawing.Point(8, 18);
            this.chkFilterText.Name = "chkFilterText";
            this.chkFilterText.Size = new System.Drawing.Size(38, 23);
            this.chkFilterText.TabIndex = 11;
            this.chkFilterText.Text = "Text";
            this.chkFilterText.UseVisualStyleBackColor = true;
            this.chkFilterText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ckbFilterText_CheckedChanged);
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Location = new System.Drawing.Point(9, 12);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(52, 13);
            this.lblDiscipline.TabIndex = 7;
            this.lblDiscipline.Text = "Discipline";
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDone.Location = new System.Drawing.Point(978, 459);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(89, 34);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // grpSuffix
            // 
            this.grpSuffix.Controls.Add(this.cmbLayerSuffix);
            this.grpSuffix.Location = new System.Drawing.Point(898, 12);
            this.grpSuffix.Name = "grpSuffix";
            this.grpSuffix.Size = new System.Drawing.Size(169, 51);
            this.grpSuffix.TabIndex = 10;
            this.grpSuffix.TabStop = false;
            this.grpSuffix.Text = "Suffix";
            // 
            // cmbLayerSuffix
            // 
            this.cmbLayerSuffix.FormattingEnabled = true;
            this.cmbLayerSuffix.Items.AddRange(new object[] {
            "[1] Phase 1",
            "[2] Phase 2",
            "[3] Phase 3",
            "[4] Phase 4",
            "[A] Abandoned",
            "[D] Demo",
            "[F] Future",
            "[O] By Others",
            "[R] Record"});
            this.cmbLayerSuffix.Location = new System.Drawing.Point(11, 18);
            this.cmbLayerSuffix.Name = "cmbLayerSuffix";
            this.cmbLayerSuffix.Size = new System.Drawing.Size(146, 21);
            this.cmbLayerSuffix.TabIndex = 0;
            // 
            // chkAddLayerOverwrite
            // 
            this.chkAddLayerOverwrite.AutoSize = true;
            this.chkAddLayerOverwrite.Location = new System.Drawing.Point(16, 379);
            this.chkAddLayerOverwrite.Name = "chkAddLayerOverwrite";
            this.chkAddLayerOverwrite.Size = new System.Drawing.Size(144, 17);
            this.chkAddLayerOverwrite.TabIndex = 11;
            this.chkAddLayerOverwrite.Text = "Overwrite Existing Layers";
            this.chkAddLayerOverwrite.UseVisualStyleBackColor = true;
            // 
            // lblLayerCount
            // 
            this.lblLayerCount.AutoSize = true;
            this.lblLayerCount.Location = new System.Drawing.Point(208, 447);
            this.lblLayerCount.Name = "lblLayerCount";
            this.lblLayerCount.Size = new System.Drawing.Size(88, 13);
            this.lblLayerCount.TabIndex = 12;
            this.lblLayerCount.Text = "No Layers Found";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResult.Location = new System.Drawing.Point(16, 491);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 13;
            // 
            // LayerCreate
            // 
            this.AcceptButton = this.btnDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDone;
            this.ClientSize = new System.Drawing.Size(1081, 516);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblLayerCount);
            this.Controls.Add(this.chkAddLayerOverwrite);
            this.Controls.Add(this.grpSuffix);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblDiscipline);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.cmdDiscipline);
            this.Controls.Add(this.lstViewLayerList);
            this.Controls.Add(this.btnAddtoDrawing);
            this.Controls.Add(this.lstGroups);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LayerCreate";
            this.Text = "Layere Create";
            this.Load += new System.EventHandler(this.LayerCreate_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpSuffix.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGroups;
        private System.Windows.Forms.Button btnAddtoDrawing;
        private System.Windows.Forms.ListView lstViewLayerList;
        private System.Windows.Forms.ColumnHeader colLayerName;
        private System.Windows.Forms.ColumnHeader colLayerDescription;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmdDiscipline;
        private System.Windows.Forms.ColumnHeader colLayerColor;
        private System.Windows.Forms.ColumnHeader colLayerLinetype;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.GroupBox grpSuffix;
        private System.Windows.Forms.ComboBox cmbLayerSuffix;
        private System.Windows.Forms.CheckBox chkFilterText;
        private System.Windows.Forms.CheckBox chkFilterExisting;
        private System.Windows.Forms.CheckBox chkFilterSymbol;
        private System.Windows.Forms.CheckBox chkAddLayerOverwrite;
        private System.Windows.Forms.Label lblLayerCount;
        private System.Windows.Forms.Label lblResult;
    }
}

