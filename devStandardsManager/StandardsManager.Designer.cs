namespace devStandardsManager
{
    partial class StandardsManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardsManager));
            this.tabStandards = new System.Windows.Forms.TabControl();
            this.tabLayers = new System.Windows.Forms.TabPage();
            this.chkAddLayerOverwrite = new System.Windows.Forms.CheckBox();
            this.grpSuffix = new System.Windows.Forms.GroupBox();
            this.cmbLayerSuffix = new System.Windows.Forms.ComboBox();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.chkFilterExisting = new System.Windows.Forms.CheckBox();
            this.chkFilterSymbol = new System.Windows.Forms.CheckBox();
            this.chkFilterText = new System.Windows.Forms.CheckBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmdDiscipline = new System.Windows.Forms.ComboBox();
            this.lstViewLayerList = new System.Windows.Forms.ListView();
            this.colLayerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLayerDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLayerColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLayerLinetype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddtoDrawing = new System.Windows.Forms.Button();
            this.lstGroups = new System.Windows.Forms.ListBox();
            this.tabTextStyles = new System.Windows.Forms.TabPage();
            this.txtCheckboxAnno = new System.Windows.Forms.CheckBox();
            this.txtButtonAddtoDrawing = new System.Windows.Forms.Button();
            this.txtImagePanel = new System.Windows.Forms.Panel();
            this.txtImagePreview = new System.Windows.Forms.PictureBox();
            this.txtCheckboxOverwrite = new System.Windows.Forms.CheckBox();
            this.txtListTextStyles = new System.Windows.Forms.ListBox();
            this.txtLabelSelectText = new System.Windows.Forms.Label();
            this.tabDimStyles = new System.Windows.Forms.TabPage();
            this.dimComboBoxGroup = new System.Windows.Forms.ComboBox();
            this.dimCheckBoxAnno = new System.Windows.Forms.CheckBox();
            this.dimButtonAddtoDrawing = new System.Windows.Forms.Button();
            this.dimImagePanel = new System.Windows.Forms.Panel();
            this.dimImagePreview = new System.Windows.Forms.PictureBox();
            this.dimCheckboxOverwrite = new System.Windows.Forms.CheckBox();
            this.dimListboxDimStyles = new System.Windows.Forms.ListBox();
            this.dimLabelSelectDimStyle = new System.Windows.Forms.Label();
            this.tabLeaderStyles = new System.Windows.Forms.TabPage();
            this.ldrButtonAddtoDrawing = new System.Windows.Forms.Button();
            this.ldrImagePanel = new System.Windows.Forms.Panel();
            this.ldrImagePreview = new System.Windows.Forms.PictureBox();
            this.ldrCheckboxOverwrite = new System.Windows.Forms.CheckBox();
            this.ldrListboxLeaders = new System.Windows.Forms.ListBox();
            this.ldrLabelSelectLeader = new System.Windows.Forms.Label();
            this.tabLinetypes = new System.Windows.Forms.TabPage();
            this.linButtonAddtoDrawing = new System.Windows.Forms.Button();
            this.linCheckboxOverwrite = new System.Windows.Forms.CheckBox();
            this.linListboxLinetypes = new System.Windows.Forms.ListBox();
            this.linLabelSelectLinetype = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.ldrCheckBoxAnno = new System.Windows.Forms.CheckBox();
            this.ldrComboBoxGroup = new System.Windows.Forms.ComboBox();
            this.linGroupBoxFilters = new System.Windows.Forms.GroupBox();
            this.linCheckBoxProp = new System.Windows.Forms.CheckBox();
            this.linGroupBoxSearch = new System.Windows.Forms.GroupBox();
            this.linTextBoxSearch = new System.Windows.Forms.TextBox();
            this.linListViewLinetypes = new System.Windows.Forms.ListView();
            this.colLineName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLineDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabStandards.SuspendLayout();
            this.tabLayers.SuspendLayout();
            this.grpSuffix.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.tabTextStyles.SuspendLayout();
            this.txtImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImagePreview)).BeginInit();
            this.tabDimStyles.SuspendLayout();
            this.dimImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimImagePreview)).BeginInit();
            this.tabLeaderStyles.SuspendLayout();
            this.ldrImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ldrImagePreview)).BeginInit();
            this.tabLinetypes.SuspendLayout();
            this.linGroupBoxFilters.SuspendLayout();
            this.linGroupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStandards
            // 
            this.tabStandards.Controls.Add(this.tabLayers);
            this.tabStandards.Controls.Add(this.tabTextStyles);
            this.tabStandards.Controls.Add(this.tabDimStyles);
            this.tabStandards.Controls.Add(this.tabLeaderStyles);
            this.tabStandards.Controls.Add(this.tabLinetypes);
            this.tabStandards.Location = new System.Drawing.Point(-6, 2);
            this.tabStandards.Name = "tabStandards";
            this.tabStandards.SelectedIndex = 1;
            this.tabStandards.Size = new System.Drawing.Size(1092, 548);
            this.tabStandards.TabIndex = 5;
            this.tabStandards.SelectedIndexChanged += new System.EventHandler(this.tabStandards_SelectedIndexChanged);
            // 
            // tabLayers
            // 
            this.tabLayers.BackColor = System.Drawing.SystemColors.Control;
            this.tabLayers.Controls.Add(this.chkAddLayerOverwrite);
            this.tabLayers.Controls.Add(this.grpSuffix);
            this.tabLayers.Controls.Add(this.lblDiscipline);
            this.tabLayers.Controls.Add(this.grpFilter);
            this.tabLayers.Controls.Add(this.grpSearch);
            this.tabLayers.Controls.Add(this.cmdDiscipline);
            this.tabLayers.Controls.Add(this.lstViewLayerList);
            this.tabLayers.Controls.Add(this.btnAddtoDrawing);
            this.tabLayers.Controls.Add(this.lstGroups);
            this.tabLayers.Location = new System.Drawing.Point(4, 22);
            this.tabLayers.Name = "tabLayers";
            this.tabLayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabLayers.Size = new System.Drawing.Size(1084, 522);
            this.tabLayers.TabIndex = 4;
            this.tabLayers.Text = "  Layers";
            // 
            // chkAddLayerOverwrite
            // 
            this.chkAddLayerOverwrite.AutoSize = true;
            this.chkAddLayerOverwrite.Checked = true;
            this.chkAddLayerOverwrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddLayerOverwrite.Location = new System.Drawing.Point(14, 376);
            this.chkAddLayerOverwrite.Name = "chkAddLayerOverwrite";
            this.chkAddLayerOverwrite.Size = new System.Drawing.Size(110, 17);
            this.chkAddLayerOverwrite.TabIndex = 20;
            this.chkAddLayerOverwrite.Text = "Overwrite Existing";
            this.chkAddLayerOverwrite.UseVisualStyleBackColor = true;
            // 
            // grpSuffix
            // 
            this.grpSuffix.Controls.Add(this.cmbLayerSuffix);
            this.grpSuffix.Location = new System.Drawing.Point(895, 7);
            this.grpSuffix.Name = "grpSuffix";
            this.grpSuffix.Size = new System.Drawing.Size(169, 51);
            this.grpSuffix.TabIndex = 19;
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
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Location = new System.Drawing.Point(10, 7);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(52, 13);
            this.lblDiscipline.TabIndex = 18;
            this.lblDiscipline.Text = "Discipline";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.chkFilterExisting);
            this.grpFilter.Controls.Add(this.chkFilterSymbol);
            this.grpFilter.Controls.Add(this.chkFilterText);
            this.grpFilter.Location = new System.Drawing.Point(716, 7);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(170, 51);
            this.grpFilter.TabIndex = 17;
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
            this.chkFilterExisting.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkFilterExisting_MouseUp);
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
            this.chkFilterSymbol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkFilterSymbol_MouseUp);
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
            this.chkFilterText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkFilterText_MouseUp);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Location = new System.Drawing.Point(208, 7);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(499, 51);
            this.grpSearch.TabIndex = 16;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
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
            this.cmdDiscipline.Location = new System.Drawing.Point(10, 26);
            this.cmdDiscipline.Name = "cmdDiscipline";
            this.cmdDiscipline.Size = new System.Drawing.Size(181, 21);
            this.cmdDiscipline.TabIndex = 15;
            this.cmdDiscipline.SelectedIndexChanged += new System.EventHandler(this.cmdDiscipline_SelectedIndexChanged);
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
            this.lstViewLayerList.Location = new System.Drawing.Point(208, 64);
            this.lstViewLayerList.Name = "lstViewLayerList";
            this.lstViewLayerList.Size = new System.Drawing.Size(856, 373);
            this.lstViewLayerList.TabIndex = 14;
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
            // btnAddtoDrawing
            // 
            this.btnAddtoDrawing.Location = new System.Drawing.Point(14, 399);
            this.btnAddtoDrawing.Name = "btnAddtoDrawing";
            this.btnAddtoDrawing.Size = new System.Drawing.Size(180, 40);
            this.btnAddtoDrawing.TabIndex = 13;
            this.btnAddtoDrawing.Text = "<< Add to Drawing";
            this.btnAddtoDrawing.UseVisualStyleBackColor = true;
            this.btnAddtoDrawing.Click += new System.EventHandler(this.btnAddtoDrawing_Click);
            // 
            // lstGroups
            // 
            this.lstGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstGroups.FormattingEnabled = true;
            this.lstGroups.Location = new System.Drawing.Point(10, 64);
            this.lstGroups.Name = "lstGroups";
            this.lstGroups.Size = new System.Drawing.Size(180, 301);
            this.lstGroups.TabIndex = 12;
            this.lstGroups.SelectedIndexChanged += new System.EventHandler(this.lstGroups_SelectedIndexChanged);
            // 
            // tabTextStyles
            // 
            this.tabTextStyles.BackColor = System.Drawing.SystemColors.Control;
            this.tabTextStyles.Controls.Add(this.txtCheckboxAnno);
            this.tabTextStyles.Controls.Add(this.txtButtonAddtoDrawing);
            this.tabTextStyles.Controls.Add(this.txtImagePanel);
            this.tabTextStyles.Controls.Add(this.txtCheckboxOverwrite);
            this.tabTextStyles.Controls.Add(this.txtListTextStyles);
            this.tabTextStyles.Controls.Add(this.txtLabelSelectText);
            this.tabTextStyles.Location = new System.Drawing.Point(4, 22);
            this.tabTextStyles.Name = "tabTextStyles";
            this.tabTextStyles.Padding = new System.Windows.Forms.Padding(3);
            this.tabTextStyles.Size = new System.Drawing.Size(1084, 522);
            this.tabTextStyles.TabIndex = 0;
            this.tabTextStyles.Text = "Text Styes";
            // 
            // txtCheckboxAnno
            // 
            this.txtCheckboxAnno.AutoSize = true;
            this.txtCheckboxAnno.Checked = true;
            this.txtCheckboxAnno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.txtCheckboxAnno.Location = new System.Drawing.Point(13, 26);
            this.txtCheckboxAnno.Name = "txtCheckboxAnno";
            this.txtCheckboxAnno.Size = new System.Drawing.Size(138, 17);
            this.txtCheckboxAnno.TabIndex = 5;
            this.txtCheckboxAnno.Text = "Show Annotative Styles";
            this.txtCheckboxAnno.UseVisualStyleBackColor = true;
            this.txtCheckboxAnno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtCheckboxAnno_MouseUp);
            // 
            // txtButtonAddtoDrawing
            // 
            this.txtButtonAddtoDrawing.Location = new System.Drawing.Point(14, 399);
            this.txtButtonAddtoDrawing.Name = "txtButtonAddtoDrawing";
            this.txtButtonAddtoDrawing.Size = new System.Drawing.Size(180, 40);
            this.txtButtonAddtoDrawing.TabIndex = 4;
            this.txtButtonAddtoDrawing.Text = "<< Add to Drawing";
            this.txtButtonAddtoDrawing.UseVisualStyleBackColor = true;
            this.txtButtonAddtoDrawing.Click += new System.EventHandler(this.txtButtonAddtoDrawing_Click);
            // 
            // txtImagePanel
            // 
            this.txtImagePanel.Controls.Add(this.txtImagePreview);
            this.txtImagePanel.Location = new System.Drawing.Point(207, 26);
            this.txtImagePanel.Margin = new System.Windows.Forms.Padding(0);
            this.txtImagePanel.Name = "txtImagePanel";
            this.txtImagePanel.Size = new System.Drawing.Size(853, 412);
            this.txtImagePanel.TabIndex = 3;
            // 
            // txtImagePreview
            // 
            this.txtImagePreview.Image = ((System.Drawing.Image)(resources.GetObject("txtImagePreview.Image")));
            this.txtImagePreview.Location = new System.Drawing.Point(0, 0);
            this.txtImagePreview.Margin = new System.Windows.Forms.Padding(0);
            this.txtImagePreview.Name = "txtImagePreview";
            this.txtImagePreview.Size = new System.Drawing.Size(853, 413);
            this.txtImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.txtImagePreview.TabIndex = 0;
            this.txtImagePreview.TabStop = false;
            // 
            // txtCheckboxOverwrite
            // 
            this.txtCheckboxOverwrite.AutoSize = true;
            this.txtCheckboxOverwrite.Checked = true;
            this.txtCheckboxOverwrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.txtCheckboxOverwrite.Location = new System.Drawing.Point(14, 376);
            this.txtCheckboxOverwrite.Name = "txtCheckboxOverwrite";
            this.txtCheckboxOverwrite.Size = new System.Drawing.Size(110, 17);
            this.txtCheckboxOverwrite.TabIndex = 2;
            this.txtCheckboxOverwrite.Text = "Overwrite Existing";
            this.txtCheckboxOverwrite.UseVisualStyleBackColor = true;
            // 
            // txtListTextStyles
            // 
            this.txtListTextStyles.FormattingEnabled = true;
            this.txtListTextStyles.Location = new System.Drawing.Point(10, 52);
            this.txtListTextStyles.Name = "txtListTextStyles";
            this.txtListTextStyles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.txtListTextStyles.Size = new System.Drawing.Size(180, 316);
            this.txtListTextStyles.TabIndex = 1;
            // 
            // txtLabelSelectText
            // 
            this.txtLabelSelectText.AutoSize = true;
            this.txtLabelSelectText.Location = new System.Drawing.Point(10, 7);
            this.txtLabelSelectText.Name = "txtLabelSelectText";
            this.txtLabelSelectText.Size = new System.Drawing.Size(87, 13);
            this.txtLabelSelectText.TabIndex = 0;
            this.txtLabelSelectText.Text = "Select Text Style";
            // 
            // tabDimStyles
            // 
            this.tabDimStyles.BackColor = System.Drawing.SystemColors.Control;
            this.tabDimStyles.Controls.Add(this.dimComboBoxGroup);
            this.tabDimStyles.Controls.Add(this.dimCheckBoxAnno);
            this.tabDimStyles.Controls.Add(this.dimButtonAddtoDrawing);
            this.tabDimStyles.Controls.Add(this.dimImagePanel);
            this.tabDimStyles.Controls.Add(this.dimCheckboxOverwrite);
            this.tabDimStyles.Controls.Add(this.dimListboxDimStyles);
            this.tabDimStyles.Controls.Add(this.dimLabelSelectDimStyle);
            this.tabDimStyles.Location = new System.Drawing.Point(4, 22);
            this.tabDimStyles.Name = "tabDimStyles";
            this.tabDimStyles.Padding = new System.Windows.Forms.Padding(3);
            this.tabDimStyles.Size = new System.Drawing.Size(1084, 522);
            this.tabDimStyles.TabIndex = 1;
            this.tabDimStyles.Text = "Dim Styles";
            // 
            // dimComboBoxGroup
            // 
            this.dimComboBoxGroup.FormattingEnabled = true;
            this.dimComboBoxGroup.Location = new System.Drawing.Point(11, 49);
            this.dimComboBoxGroup.Name = "dimComboBoxGroup";
            this.dimComboBoxGroup.Size = new System.Drawing.Size(180, 21);
            this.dimComboBoxGroup.TabIndex = 10;
            this.dimComboBoxGroup.Text = "Civil";
            this.dimComboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.dimComboBoxGroup_SelectedIndexChanged);
            // 
            // dimCheckBoxAnno
            // 
            this.dimCheckBoxAnno.AutoSize = true;
            this.dimCheckBoxAnno.Checked = true;
            this.dimCheckBoxAnno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dimCheckBoxAnno.Location = new System.Drawing.Point(11, 26);
            this.dimCheckBoxAnno.Name = "dimCheckBoxAnno";
            this.dimCheckBoxAnno.Size = new System.Drawing.Size(156, 17);
            this.dimCheckBoxAnno.TabIndex = 9;
            this.dimCheckBoxAnno.Text = "Show Annotative DimStyles";
            this.dimCheckBoxAnno.UseVisualStyleBackColor = true;
            this.dimCheckBoxAnno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dimCheckBoxAnno_MouseUp);
            // 
            // dimButtonAddtoDrawing
            // 
            this.dimButtonAddtoDrawing.Location = new System.Drawing.Point(14, 399);
            this.dimButtonAddtoDrawing.Name = "dimButtonAddtoDrawing";
            this.dimButtonAddtoDrawing.Size = new System.Drawing.Size(180, 40);
            this.dimButtonAddtoDrawing.TabIndex = 8;
            this.dimButtonAddtoDrawing.Text = "<< Add to Drawing";
            this.dimButtonAddtoDrawing.UseVisualStyleBackColor = true;
            this.dimButtonAddtoDrawing.Click += new System.EventHandler(this.dimButtonAddtoDrawing_Click);
            // 
            // dimImagePanel
            // 
            this.dimImagePanel.Controls.Add(this.dimImagePreview);
            this.dimImagePanel.Location = new System.Drawing.Point(207, 26);
            this.dimImagePanel.Name = "dimImagePanel";
            this.dimImagePanel.Size = new System.Drawing.Size(853, 412);
            this.dimImagePanel.TabIndex = 7;
            // 
            // dimImagePreview
            // 
            this.dimImagePreview.Image = ((System.Drawing.Image)(resources.GetObject("dimImagePreview.Image")));
            this.dimImagePreview.Location = new System.Drawing.Point(0, 0);
            this.dimImagePreview.Margin = new System.Windows.Forms.Padding(0);
            this.dimImagePreview.Name = "dimImagePreview";
            this.dimImagePreview.Size = new System.Drawing.Size(853, 413);
            this.dimImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dimImagePreview.TabIndex = 0;
            this.dimImagePreview.TabStop = false;
            // 
            // dimCheckboxOverwrite
            // 
            this.dimCheckboxOverwrite.AutoSize = true;
            this.dimCheckboxOverwrite.Checked = true;
            this.dimCheckboxOverwrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dimCheckboxOverwrite.Location = new System.Drawing.Point(14, 376);
            this.dimCheckboxOverwrite.Name = "dimCheckboxOverwrite";
            this.dimCheckboxOverwrite.Size = new System.Drawing.Size(110, 17);
            this.dimCheckboxOverwrite.TabIndex = 6;
            this.dimCheckboxOverwrite.Text = "Overwrite Existing";
            this.dimCheckboxOverwrite.UseVisualStyleBackColor = true;
            // 
            // dimListboxDimStyles
            // 
            this.dimListboxDimStyles.FormattingEnabled = true;
            this.dimListboxDimStyles.Location = new System.Drawing.Point(11, 78);
            this.dimListboxDimStyles.Name = "dimListboxDimStyles";
            this.dimListboxDimStyles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.dimListboxDimStyles.Size = new System.Drawing.Size(180, 290);
            this.dimListboxDimStyles.TabIndex = 5;
            // 
            // dimLabelSelectDimStyle
            // 
            this.dimLabelSelectDimStyle.AutoSize = true;
            this.dimLabelSelectDimStyle.Location = new System.Drawing.Point(10, 10);
            this.dimLabelSelectDimStyle.Name = "dimLabelSelectDimStyle";
            this.dimLabelSelectDimStyle.Size = new System.Drawing.Size(116, 13);
            this.dimLabelSelectDimStyle.TabIndex = 4;
            this.dimLabelSelectDimStyle.Text = "Select Dim Style Group";
            // 
            // tabLeaderStyles
            // 
            this.tabLeaderStyles.BackColor = System.Drawing.SystemColors.Control;
            this.tabLeaderStyles.Controls.Add(this.ldrComboBoxGroup);
            this.tabLeaderStyles.Controls.Add(this.ldrCheckBoxAnno);
            this.tabLeaderStyles.Controls.Add(this.ldrButtonAddtoDrawing);
            this.tabLeaderStyles.Controls.Add(this.ldrImagePanel);
            this.tabLeaderStyles.Controls.Add(this.ldrCheckboxOverwrite);
            this.tabLeaderStyles.Controls.Add(this.ldrListboxLeaders);
            this.tabLeaderStyles.Controls.Add(this.ldrLabelSelectLeader);
            this.tabLeaderStyles.Location = new System.Drawing.Point(4, 22);
            this.tabLeaderStyles.Name = "tabLeaderStyles";
            this.tabLeaderStyles.Size = new System.Drawing.Size(1084, 522);
            this.tabLeaderStyles.TabIndex = 2;
            this.tabLeaderStyles.Text = "Leader Styles";
            // 
            // ldrButtonAddtoDrawing
            // 
            this.ldrButtonAddtoDrawing.Location = new System.Drawing.Point(14, 399);
            this.ldrButtonAddtoDrawing.Name = "ldrButtonAddtoDrawing";
            this.ldrButtonAddtoDrawing.Size = new System.Drawing.Size(180, 40);
            this.ldrButtonAddtoDrawing.TabIndex = 8;
            this.ldrButtonAddtoDrawing.Text = "<< Add to Drawing";
            this.ldrButtonAddtoDrawing.UseVisualStyleBackColor = true;
            this.ldrButtonAddtoDrawing.Click += new System.EventHandler(this.ldrButtonAddtoDrawing_Click);
            // 
            // ldrImagePanel
            // 
            this.ldrImagePanel.Controls.Add(this.ldrImagePreview);
            this.ldrImagePanel.Location = new System.Drawing.Point(207, 26);
            this.ldrImagePanel.Name = "ldrImagePanel";
            this.ldrImagePanel.Size = new System.Drawing.Size(853, 412);
            this.ldrImagePanel.TabIndex = 7;
            // 
            // ldrImagePreview
            // 
            this.ldrImagePreview.Image = ((System.Drawing.Image)(resources.GetObject("ldrImagePreview.Image")));
            this.ldrImagePreview.Location = new System.Drawing.Point(0, 0);
            this.ldrImagePreview.Margin = new System.Windows.Forms.Padding(0);
            this.ldrImagePreview.Name = "ldrImagePreview";
            this.ldrImagePreview.Size = new System.Drawing.Size(853, 413);
            this.ldrImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ldrImagePreview.TabIndex = 0;
            this.ldrImagePreview.TabStop = false;
            // 
            // ldrCheckboxOverwrite
            // 
            this.ldrCheckboxOverwrite.AutoSize = true;
            this.ldrCheckboxOverwrite.Checked = true;
            this.ldrCheckboxOverwrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ldrCheckboxOverwrite.Location = new System.Drawing.Point(14, 376);
            this.ldrCheckboxOverwrite.Name = "ldrCheckboxOverwrite";
            this.ldrCheckboxOverwrite.Size = new System.Drawing.Size(110, 17);
            this.ldrCheckboxOverwrite.TabIndex = 6;
            this.ldrCheckboxOverwrite.Text = "Overwrite Existing";
            this.ldrCheckboxOverwrite.UseVisualStyleBackColor = true;
            // 
            // ldrListboxLeaders
            // 
            this.ldrListboxLeaders.FormattingEnabled = true;
            this.ldrListboxLeaders.Location = new System.Drawing.Point(11, 78);
            this.ldrListboxLeaders.Name = "ldrListboxLeaders";
            this.ldrListboxLeaders.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ldrListboxLeaders.Size = new System.Drawing.Size(180, 290);
            this.ldrListboxLeaders.TabIndex = 5;
            // 
            // ldrLabelSelectLeader
            // 
            this.ldrLabelSelectLeader.AutoSize = true;
            this.ldrLabelSelectLeader.Location = new System.Drawing.Point(10, 10);
            this.ldrLabelSelectLeader.Name = "ldrLabelSelectLeader";
            this.ldrLabelSelectLeader.Size = new System.Drawing.Size(131, 13);
            this.ldrLabelSelectLeader.TabIndex = 4;
            this.ldrLabelSelectLeader.Text = "Select Leader Style Group";
            // 
            // tabLinetypes
            // 
            this.tabLinetypes.BackColor = System.Drawing.SystemColors.Control;
            this.tabLinetypes.Controls.Add(this.linGroupBoxFilters);
            this.tabLinetypes.Controls.Add(this.linGroupBoxSearch);
            this.tabLinetypes.Controls.Add(this.linListViewLinetypes);
            this.tabLinetypes.Controls.Add(this.linButtonAddtoDrawing);
            this.tabLinetypes.Controls.Add(this.linCheckboxOverwrite);
            this.tabLinetypes.Controls.Add(this.linListboxLinetypes);
            this.tabLinetypes.Controls.Add(this.linLabelSelectLinetype);
            this.tabLinetypes.Location = new System.Drawing.Point(4, 22);
            this.tabLinetypes.Name = "tabLinetypes";
            this.tabLinetypes.Size = new System.Drawing.Size(1084, 522);
            this.tabLinetypes.TabIndex = 3;
            this.tabLinetypes.Text = "Linetypes";
            // 
            // linButtonAddtoDrawing
            // 
            this.linButtonAddtoDrawing.Location = new System.Drawing.Point(14, 399);
            this.linButtonAddtoDrawing.Name = "linButtonAddtoDrawing";
            this.linButtonAddtoDrawing.Size = new System.Drawing.Size(180, 40);
            this.linButtonAddtoDrawing.TabIndex = 8;
            this.linButtonAddtoDrawing.Text = "<< Add to Drawing";
            this.linButtonAddtoDrawing.UseVisualStyleBackColor = true;
            this.linButtonAddtoDrawing.Click += new System.EventHandler(this.linButtonAddtoDrawing_Click);
            // 
            // linCheckboxOverwrite
            // 
            this.linCheckboxOverwrite.AutoSize = true;
            this.linCheckboxOverwrite.Checked = true;
            this.linCheckboxOverwrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.linCheckboxOverwrite.Location = new System.Drawing.Point(14, 376);
            this.linCheckboxOverwrite.Name = "linCheckboxOverwrite";
            this.linCheckboxOverwrite.Size = new System.Drawing.Size(110, 17);
            this.linCheckboxOverwrite.TabIndex = 6;
            this.linCheckboxOverwrite.Text = "Overwrite Existing";
            this.linCheckboxOverwrite.UseVisualStyleBackColor = true;
            // 
            // linListboxLinetypes
            // 
            this.linListboxLinetypes.FormattingEnabled = true;
            this.linListboxLinetypes.Location = new System.Drawing.Point(11, 26);
            this.linListboxLinetypes.Name = "linListboxLinetypes";
            this.linListboxLinetypes.Size = new System.Drawing.Size(180, 342);
            this.linListboxLinetypes.TabIndex = 5;
            this.linListboxLinetypes.SelectedIndexChanged += new System.EventHandler(this.linListboxLinetypes_SelectedIndexChanged);
            // 
            // linLabelSelectLinetype
            // 
            this.linLabelSelectLinetype.AutoSize = true;
            this.linLabelSelectLinetype.Location = new System.Drawing.Point(10, 10);
            this.linLabelSelectLinetype.Name = "linLabelSelectLinetype";
            this.linLabelSelectLinetype.Size = new System.Drawing.Size(112, 13);
            this.linLabelSelectLinetype.TabIndex = 4;
            this.linLabelSelectLinetype.Text = "Select Linetype Group";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResult.Location = new System.Drawing.Point(203, 464);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(42, 13);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Results";
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDone.Location = new System.Drawing.Point(973, 492);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(89, 34);
            this.btnDone.TabIndex = 10;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // ldrCheckBoxAnno
            // 
            this.ldrCheckBoxAnno.AutoSize = true;
            this.ldrCheckBoxAnno.Checked = true;
            this.ldrCheckBoxAnno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ldrCheckBoxAnno.Location = new System.Drawing.Point(11, 26);
            this.ldrCheckBoxAnno.Name = "ldrCheckBoxAnno";
            this.ldrCheckBoxAnno.Size = new System.Drawing.Size(174, 17);
            this.ldrCheckBoxAnno.TabIndex = 9;
            this.ldrCheckBoxAnno.Text = "Show Annotative Leader Styles";
            this.ldrCheckBoxAnno.UseVisualStyleBackColor = true;
            this.ldrCheckBoxAnno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ldrCheckBoxAnno_MouseUp);
            // 
            // ldrComboBoxGroup
            // 
            this.ldrComboBoxGroup.FormattingEnabled = true;
            this.ldrComboBoxGroup.Location = new System.Drawing.Point(11, 49);
            this.ldrComboBoxGroup.Name = "ldrComboBoxGroup";
            this.ldrComboBoxGroup.Size = new System.Drawing.Size(180, 21);
            this.ldrComboBoxGroup.TabIndex = 10;
            this.ldrComboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.ldrComboBoxGroup_SelectedIndexChanged);
            // 
            // linGroupBoxFilters
            // 
            this.linGroupBoxFilters.Controls.Add(this.linCheckBoxProp);
            this.linGroupBoxFilters.Location = new System.Drawing.Point(985, 7);
            this.linGroupBoxFilters.Name = "linGroupBoxFilters";
            this.linGroupBoxFilters.Size = new System.Drawing.Size(79, 51);
            this.linGroupBoxFilters.TabIndex = 22;
            this.linGroupBoxFilters.TabStop = false;
            this.linGroupBoxFilters.Text = "Filter";
            // 
            // linCheckBoxProp
            // 
            this.linCheckBoxProp.Appearance = System.Windows.Forms.Appearance.Button;
            this.linCheckBoxProp.AutoSize = true;
            this.linCheckBoxProp.Location = new System.Drawing.Point(9, 18);
            this.linCheckBoxProp.Name = "linCheckBoxProp";
            this.linCheckBoxProp.Size = new System.Drawing.Size(62, 23);
            this.linCheckBoxProp.TabIndex = 13;
            this.linCheckBoxProp.Text = "Proposed";
            this.linCheckBoxProp.UseVisualStyleBackColor = true;
            this.linCheckBoxProp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.linCheckBoxProp_MouseUp);
            // 
            // linGroupBoxSearch
            // 
            this.linGroupBoxSearch.Controls.Add(this.linTextBoxSearch);
            this.linGroupBoxSearch.Location = new System.Drawing.Point(208, 7);
            this.linGroupBoxSearch.Name = "linGroupBoxSearch";
            this.linGroupBoxSearch.Size = new System.Drawing.Size(771, 51);
            this.linGroupBoxSearch.TabIndex = 21;
            this.linGroupBoxSearch.TabStop = false;
            this.linGroupBoxSearch.Text = "Search";
            // 
            // linTextBoxSearch
            // 
            this.linTextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linTextBoxSearch.Location = new System.Drawing.Point(9, 19);
            this.linTextBoxSearch.Name = "linTextBoxSearch";
            this.linTextBoxSearch.Size = new System.Drawing.Size(754, 20);
            this.linTextBoxSearch.TabIndex = 3;
            this.linTextBoxSearch.TextChanged += new System.EventHandler(this.linTextBoxSearch_TextChanged);
            // 
            // linListViewLinetypes
            // 
            this.linListViewLinetypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linListViewLinetypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLineName,
            this.colLineDescription});
            this.linListViewLinetypes.FullRowSelect = true;
            this.linListViewLinetypes.GridLines = true;
            this.linListViewLinetypes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.linListViewLinetypes.HideSelection = false;
            this.linListViewLinetypes.Location = new System.Drawing.Point(208, 62);
            this.linListViewLinetypes.Name = "linListViewLinetypes";
            this.linListViewLinetypes.Size = new System.Drawing.Size(856, 373);
            this.linListViewLinetypes.TabIndex = 20;
            this.linListViewLinetypes.UseCompatibleStateImageBehavior = false;
            this.linListViewLinetypes.View = System.Windows.Forms.View.Details;
            // 
            // colLineName
            // 
            this.colLineName.Text = "Linetype Name";
            this.colLineName.Width = 275;
            // 
            // colLineDescription
            // 
            this.colLineDescription.Text = "Description";
            this.colLineDescription.Width = 500;
            // 
            // StandardsManager
            // 
            this.AcceptButton = this.btnDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDone;
            this.ClientSize = new System.Drawing.Size(1080, 543);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tabStandards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StandardsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Standards Manager";
            this.Load += new System.EventHandler(this.StandardsManager_Load);
            this.tabStandards.ResumeLayout(false);
            this.tabLayers.ResumeLayout(false);
            this.tabLayers.PerformLayout();
            this.grpSuffix.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.tabTextStyles.ResumeLayout(false);
            this.tabTextStyles.PerformLayout();
            this.txtImagePanel.ResumeLayout(false);
            this.txtImagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImagePreview)).EndInit();
            this.tabDimStyles.ResumeLayout(false);
            this.tabDimStyles.PerformLayout();
            this.dimImagePanel.ResumeLayout(false);
            this.dimImagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimImagePreview)).EndInit();
            this.tabLeaderStyles.ResumeLayout(false);
            this.tabLeaderStyles.PerformLayout();
            this.ldrImagePanel.ResumeLayout(false);
            this.ldrImagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ldrImagePreview)).EndInit();
            this.tabLinetypes.ResumeLayout(false);
            this.tabLinetypes.PerformLayout();
            this.linGroupBoxFilters.ResumeLayout(false);
            this.linGroupBoxFilters.PerformLayout();
            this.linGroupBoxSearch.ResumeLayout(false);
            this.linGroupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabStandards;
        private System.Windows.Forms.TabPage tabLayers;
        private System.Windows.Forms.CheckBox chkAddLayerOverwrite;
        private System.Windows.Forms.GroupBox grpSuffix;
        private System.Windows.Forms.ComboBox cmbLayerSuffix;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.CheckBox chkFilterExisting;
        private System.Windows.Forms.CheckBox chkFilterSymbol;
        private System.Windows.Forms.CheckBox chkFilterText;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmdDiscipline;
        private System.Windows.Forms.ListView lstViewLayerList;
        private System.Windows.Forms.ColumnHeader colLayerName;
        private System.Windows.Forms.ColumnHeader colLayerDescription;
        private System.Windows.Forms.ColumnHeader colLayerColor;
        private System.Windows.Forms.ColumnHeader colLayerLinetype;
        private System.Windows.Forms.Button btnAddtoDrawing;
        private System.Windows.Forms.ListBox lstGroups;
        private System.Windows.Forms.TabPage tabTextStyles;
        private System.Windows.Forms.Button txtButtonAddtoDrawing;
        private System.Windows.Forms.Panel txtImagePanel;
        private System.Windows.Forms.PictureBox txtImagePreview;
        private System.Windows.Forms.CheckBox txtCheckboxOverwrite;
        private System.Windows.Forms.ListBox txtListTextStyles;
        private System.Windows.Forms.Label txtLabelSelectText;
        private System.Windows.Forms.TabPage tabDimStyles;
        private System.Windows.Forms.Button dimButtonAddtoDrawing;
        private System.Windows.Forms.Panel dimImagePanel;
        private System.Windows.Forms.PictureBox dimImagePreview;
        private System.Windows.Forms.CheckBox dimCheckboxOverwrite;
        private System.Windows.Forms.ListBox dimListboxDimStyles;
        private System.Windows.Forms.Label dimLabelSelectDimStyle;
        private System.Windows.Forms.TabPage tabLeaderStyles;
        private System.Windows.Forms.Button ldrButtonAddtoDrawing;
        private System.Windows.Forms.Panel ldrImagePanel;
        private System.Windows.Forms.PictureBox ldrImagePreview;
        private System.Windows.Forms.CheckBox ldrCheckboxOverwrite;
        private System.Windows.Forms.ListBox ldrListboxLeaders;
        private System.Windows.Forms.Label ldrLabelSelectLeader;
        private System.Windows.Forms.TabPage tabLinetypes;
        private System.Windows.Forms.Button linButtonAddtoDrawing;
        private System.Windows.Forms.CheckBox linCheckboxOverwrite;
        private System.Windows.Forms.ListBox linListboxLinetypes;
        private System.Windows.Forms.Label linLabelSelectLinetype;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.CheckBox txtCheckboxAnno;
        private System.Windows.Forms.ComboBox dimComboBoxGroup;
        private System.Windows.Forms.CheckBox dimCheckBoxAnno;
        private System.Windows.Forms.ComboBox ldrComboBoxGroup;
        private System.Windows.Forms.CheckBox ldrCheckBoxAnno;
        private System.Windows.Forms.GroupBox linGroupBoxFilters;
        private System.Windows.Forms.CheckBox linCheckBoxProp;
        private System.Windows.Forms.GroupBox linGroupBoxSearch;
        private System.Windows.Forms.TextBox linTextBoxSearch;
        private System.Windows.Forms.ListView linListViewLinetypes;
        private System.Windows.Forms.ColumnHeader colLineName;
        private System.Windows.Forms.ColumnHeader colLineDescription;
    }
}