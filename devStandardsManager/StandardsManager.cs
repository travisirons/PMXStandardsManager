using DataLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devStandardsManager
{
    public partial class StandardsManager : Form
    {

        private static Timer searchTimer;
        
        List<LayerModel> layers = new List<LayerModel>();
        List<LayerDisciplineModel> layerDisciplines = new List<LayerDisciplineModel>();
        List<LayerGroupModel> layerGroups = new List<LayerGroupModel>();
        List<TextStyleModel> textStyles = new List<TextStyleModel>();
        List<DimensionStyleModel> dimensionStyles = new List<DimensionStyleModel>();
        List<LeaderStyleModel> leaderStyles = new List<LeaderStyleModel>();
        List<LinetypeModel> linetypes = new List<LinetypeModel>();
        List<LinetypeGroupModel> linetypeGroups = new List<LinetypeGroupModel>();

        string DisciplineAssoc = "";
        string GroupAssoc = "";
        string Filter = "";

        public StandardsManager()
        {
            InitializeComponent();
        }

        private void StandardsManager_Load(object sender, EventArgs e)
        {
            //ToDo: Add command line arg to switch to specific tab
            tabStandards.SelectedIndex = 0;
        }

        private void tabStandards_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabStandards.SelectedIndex)
            {
                case 0:
                    loadLayerDisciplineList();
                    break;

                case 1:
                    loadTextStyleList();
                    break;

                case 2:
                    loadDimensionGroups();
                    loadDimensionStyleList();
                    break;

                case 3:
                    loadLeaderGroups();
                    loadLeaderStyleList();
                    break;

                case 4:
                    loadLinetypeGroupList();
                    loadLinetypeList();
                    break;

                default:
                    break;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }


        /// 
        /// Begin Layer Tab Code
        #region Layers
        /// Functions
        /// 
        private void loadLayerDisciplineList()
        {
            layerDisciplines = SqliteDataAccess.LoadLayerDisciplines();

            cmdDiscipline.DataSource = null;
            cmdDiscipline.DataSource = layerDisciplines;
            cmdDiscipline.DisplayMember = "DisciplineName";
            cmdDiscipline.ValueMember = "DisciplineAssoc";
            cmdDiscipline.SelectedIndex = 1;
        }

        private void loadLayerGroupList(string DisciplineAssoc)
        {
            // Disable change event to stop the listview loading too soon.
            lstGroups.SelectedIndexChanged -= new EventHandler(lstGroups_SelectedIndexChanged);

            layerGroups = SqliteDataAccess.LoadLayerGroups(DisciplineAssoc);

            lstGroups.DataSource = null;
            lstGroups.DataSource = layerGroups;
            lstGroups.DisplayMember = "GroupName";
            lstGroups.ValueMember = "GroupAssoc";
            lstGroups.SelectedIndex = -1;

            // Re-enable change event
            lstGroups.SelectedIndexChanged += new EventHandler(lstGroups_SelectedIndexChanged);
        }

        private void loadLayerList()
        {
            Filter = "";
            if (chkFilterText.Checked) { Filter = "TEXT"; };
            if (chkFilterSymbol.Checked) { Filter = "SYMB"; };

            layers = SqliteDataAccess.LoadLayers(DisciplineAssoc, GroupAssoc, Filter, chkFilterExisting.Checked);

            filterLayerList();

        }

        private void filterLayerList()
        {

            string strFilter = txtSearch.Text.ToUpper();

            lstViewLayerList.Items.Clear();
            foreach (LayerModel layer in layers)
            {
                if (strFilter != "")
                {
                    if (layer.LayerName.ToUpper().Contains(strFilter) || layer.LayerDescription.ToUpper().Contains(strFilter))
                    {
                        lstViewLayerList.Items.Add(new ListViewItem(new[] { layer.LayerName, layer.LayerDescription, layer.LayerColor, layer.LayerLinetype }));
                    }
                }
                else
                {
                    lstViewLayerList.Items.Add(new ListViewItem(new[] { layer.LayerName, layer.LayerDescription, layer.LayerColor, layer.LayerLinetype }));
                }

            }

            lblResult.Text = lstViewLayerList.Items.Count.ToString() + " Layers found.";

        }

        /// Form Event Handlers
        /// 

        private void cmdDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdDiscipline.SelectedValue is string)
            {
                lstViewLayerList.Items.Clear();
                txtSearch.Text = "";
                txtSearch.Focus();
                DisciplineAssoc = cmdDiscipline.SelectedValue.ToString();
                GroupAssoc = "";
                loadLayerGroupList(DisciplineAssoc);
                loadLayerList();
            }
        }

        private void lstGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGroups.SelectedIndex != -1)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
                GroupAssoc = lstGroups.SelectedValue.ToString();
                loadLayerList();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Add 300ms delay on text input before search
            if (searchTimer == null)
            {
                searchTimer = new Timer();
                searchTimer.Interval = 300;
                searchTimer.Tick += new EventHandler(this.searchTime_TimerTimout);
            }
            searchTimer.Stop();
            searchTimer.Tag = (sender as TextBox).Text;
            searchTimer.Start();
        }
        private void searchTime_TimerTimout(object sender, EventArgs e)
        {
            var timer = sender as Timer;
            if (timer == null)
            {
                return;
            }

            //do something when time is up
            filterLayerList();

            timer.Stop();
        }

        private void chkFilterText_MouseUp(object sender, MouseEventArgs e)
        {
            chkFilterSymbol.Checked = false;
            loadLayerList();
        }

        private void chkFilterSymbol_MouseUp(object sender, MouseEventArgs e)
        {
            chkFilterText.Checked = false;
            loadLayerList();
        }

        private void chkFilterExisting_MouseUp(object sender, MouseEventArgs e)
        {
            loadLayerList();
        }

        /// Button Event Handlers
        /// 
        private void btnAddtoDrawing_Click(object sender, EventArgs e)
        {
            lblResult.Text = lstViewLayerList.SelectedItems.Count.ToString() + " layers added to drawing.";
            foreach (ListViewItem listViewItem in lstViewLayerList.SelectedItems)
            {
                MessageBox.Show(listViewItem.SubItems[0].Text);
            }
        }

        #endregion
        /// End of Layer Tab Code
        /// 

        /// 
        /// Begin Text Tab Code
        #region Text

        /// Functions
        /// 
        private void loadTextStyleList()
        {
            textStyles = SqliteDataAccess.LoadTextStyles(txtCheckboxAnno.Checked);

            txtListTextStyles.DataSource = null;
            txtListTextStyles.DataSource = textStyles;
            txtListTextStyles.DisplayMember = "StyleName";

            lblResult.Text = txtListTextStyles.Items.Count.ToString() + " Text Styles found.";
        }

        /// Form Event Handlers
        /// 
        private void txtCheckboxAnno_MouseUp(object sender, MouseEventArgs e)
        {
            loadTextStyleList();
        }

        /// Button Event Handlers
        /// 
        private void txtButtonAddtoDrawing_Click(object sender, EventArgs e)
        {
            foreach (TextStyleModel textStyleModel in txtListTextStyles.SelectedItems)
            {
                MessageBox.Show(textStyleModel.StyleName);
            }
        }

        #endregion
        /// End of Text Tab Code
        /// 

        /// 
        /// Begin Dimension Tab Code
        #region Dimension

        /// Functions
        /// 
        private void loadDimensionGroups()
        {
            dimComboBoxGroup.DisplayMember = "Text";
            dimComboBoxGroup.ValueMember = "Value";

            List<Object> dimGroups = new List<Object>();
            dimGroups.Add(new { Text = "Civil", Value = "DIMNote12" });
            dimGroups.Add(new { Text = "Survey", Value = "DIMSurvey" });
            dimGroups.Add(new { Text = "Figure", Value = "DIMFignote" });
            dimComboBoxGroup.DataSource = dimGroups;

        }
        private void loadDimensionStyleList()
        {

            dimensionStyles = SqliteDataAccess.LoadDimensionStyles(dimCheckBoxAnno.Checked, dimComboBoxGroup.SelectedValue.ToString());

            dimListboxDimStyles.DataSource = null;
            dimListboxDimStyles.DataSource = dimensionStyles;
            dimListboxDimStyles.DisplayMember = "DIMSTYLE";

            lblResult.Text = dimListboxDimStyles.Items.Count.ToString() + " Dimension Styles found.";
        }

        /// Form Event Handlers
        /// 
        private void dimCheckBoxAnno_MouseUp(object sender, MouseEventArgs e)
        {
            loadDimensionStyleList();
        }

        private void dimComboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDimensionStyleList();
        }

        /// Button Event Handlers
        /// 
        private void dimButtonAddtoDrawing_Click(object sender, EventArgs e)
        {
            foreach (DimensionStyleModel dimensionStyleModel in dimListboxDimStyles.SelectedItems)
            {
                MessageBox.Show(dimensionStyleModel.DIMSTYLE);
            }
        }

        #endregion
        /// End of Dimensin Tab Code
        /// 

        /// 
        /// Begin Leaders Tab Code
        #region Leaders


        /// Functions
        /// 
        private void loadLeaderGroups()
        {
            ldrComboBoxGroup.DisplayMember = "Text";
            ldrComboBoxGroup.ValueMember = "Value";

            List<Object> ldrGroups = new List<Object>();
            ldrGroups.Add(new { Text = "General", Value = "876" });
            ldrGroups.Add(new { Text = "Civil", Value = "878" });
            ldrGroups.Add(new { Text = "Electrical", Value = "880" });
            ldrGroups.Add(new { Text = "Mechanical", Value = "888" });
            ldrGroups.Add(new { Text = "Structural", Value = "884" });
            ldrGroups.Add(new { Text = "Survey", Value = "886" });
            ldrGroups.Add(new { Text = "Figure", Value = "882" });
            ldrComboBoxGroup.DataSource = ldrGroups;

        }

        private void loadLeaderStyleList()
        {
            leaderStyles = SqliteDataAccess.LoadLeaderStyles(ldrCheckBoxAnno.Checked, ldrComboBoxGroup.SelectedValue.ToString());

            ldrListboxLeaders.DataSource = null;
            ldrListboxLeaders.DataSource = leaderStyles;
            ldrListboxLeaders.DisplayMember = "LeaderName";
            //ldrListboxLeaders.ValueMember = "DisciplineAssoc";
            ldrListboxLeaders.SelectedIndex = 1;

            lblResult.Text = ldrListboxLeaders.Items.Count.ToString() + " Leader Styles found.";
        }

        /// Form Event Handlers
        /// 
        private void ldrCheckBoxAnno_MouseUp(object sender, MouseEventArgs e)
        {
            loadLeaderStyleList();
        }

        private void ldrComboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadLeaderStyleList();
        }

        /// Button Event Handlers
        /// 
        private void ldrButtonAddtoDrawing_Click(object sender, EventArgs e)
        {
            foreach (LeaderStyleModel leaderStyleModel in ldrListboxLeaders.SelectedItems)
            {
                MessageBox.Show(leaderStyleModel.LeaderName);
            }
        }


        #endregion
        /// End of Leaders Tab Code
        /// 

        /// 
        /// Begin Linetype Tab Code
        #region Linetype

        /// Functions
        /// 
        private void loadLinetypeGroupList()
        {
            // Disable change event to stop the listview loading too soon.
            //lstGroups.SelectedIndexChanged -= new EventHandler(lstGroups_SelectedIndexChanged);

            linetypeGroups = SqliteDataAccess.LoadLinetypeGroups();

            linListboxLinetypes.DataSource = null;
            linListboxLinetypes.DataSource = linetypeGroups;
            linListboxLinetypes.DisplayMember = "GroupName";
            linListboxLinetypes.ValueMember = "GroupAssoc";
            linListboxLinetypes.SelectedIndex = -1;

            // Re-enable change event
            //lstGroups.SelectedIndexChanged += new EventHandler(lstGroups_SelectedIndexChanged);
        }

        private void loadLinetypeList()
        {
            Filter = "";
            if (linCheckBoxProp.Checked) { Filter = "_P"; };

            linetypes = SqliteDataAccess.LoadLinetypes(Filter);

            filterLinetypeList();

        }

        private void filterLinetypeList()
        {

            string strFilter = linTextBoxSearch.Text.ToUpper();

            linListViewLinetypes.Items.Clear();
            foreach (LinetypeModel linetype in linetypes)
            {
                if (strFilter != "")
                {
                    if (linetype.Linetype.ToUpper().Contains(strFilter) || linetype.Description.ToUpper().Contains(strFilter))
                    {
                        linListViewLinetypes.Items.Add(new ListViewItem(new[] { linetype.Linetype, linetype.Description }));
                    }
                }
                else
                {
                    linListViewLinetypes.Items.Add(new ListViewItem(new[] { linetype.Linetype, linetype.Description }));
                }

            }

            lblResult.Text = linListViewLinetypes.Items.Count.ToString() + " Linetypes found.";

        }

        private void linListboxLinetypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// Form Event Handlers
        /// 
        private void linTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // Add 300ms delay on text input before search
            if (searchTimer == null)
            {
                searchTimer = new Timer();
                searchTimer.Interval = 300;
                searchTimer.Tick += new EventHandler(this.searchLinetype_TimerTimout);
            }
            searchTimer.Stop();
            searchTimer.Tag = (sender as TextBox).Text;
            searchTimer.Start();
        }
        private void searchLinetype_TimerTimout(object sender, EventArgs e)
        {
            var timer = sender as Timer;
            if (timer == null)
            {
                return;
            }

            //do something when time is up
            filterLinetypeList();

            timer.Stop();
        }

        private void linCheckBoxProp_MouseUp(object sender, MouseEventArgs e)
        {
            //ToDo: build proposed linetype filters if needed.
        }

        private void linButtonAddtoDrawing_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItems in linListViewLinetypes.SelectedItems)
            {
                MessageBox.Show(listViewItems.SubItems[0].Text);
            }
        }

        /// Button Event Handlers
        /// 

        #endregion

        /// End of Linetype Tab Code
        /// 
















    }
}
