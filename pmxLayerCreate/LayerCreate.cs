using DataLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pmxLayerCreate
{
    public partial class LayerCreate : Form
    {
        private static Timer searchTimer;
        List<LayerModel> layers = new List<LayerModel>();
        List<LayerDisciplineModel> layerDisciplines = new List<LayerDisciplineModel>();
        List<LayerGroupModel> layerGroups = new List<LayerGroupModel>();
        string DisciplineAssoc = "";
        string GroupAssoc = "";
        string Filter = "";
        public LayerCreate()
        {
            InitializeComponent();
        }

        /// Button Event Handlers
        ///
        private void btnDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        // Create layer in drawing and display confirmation message.
        private void btnAddtoDrawing_Click(object sender, EventArgs e)
        {
            // ToDo: Create layers in drawing

            // Display confirmation message
            // ToDo: Add label and diplay meessagee there.
            MessageBox.Show(lstViewLayerList.SelectedItems.Count.ToString() + " layers added to drawing.");

        }

        /// Form Event Handlers
        /// 

        /// Form Load. Load Layer Disciplines into drop down list
        private void LayerCreate_Load(object sender, EventArgs e)
        {

            loadLayerDisciplineList();
        }

        /// Discipline Seelected. Load Layer Groups into Group list
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

        // Layeer Group Selected. Load Layers into Layer list view.
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

        // Search text entered. Filter layer list view
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

        // Text filter. Only show Text layers
        private void ckbFilterText_CheckedChanged(object sender, EventArgs e)
        {
            chkFilterSymbol.Checked = false; 
            loadLayerList();
        }

        // Symbol filter. Only show Symbol layers
        private void chkFilterSymbol_CheckedChanged(object sender, EventArgs e)
        {
            chkFilterText.Checked = false;
            loadLayerList();
        }

        // Existing filter. Only show existing layers
        private void chkFilterExisting_CheckedChanged(object sender, EventArgs e)
        {
            loadLayerList();
        }


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

            //Debug
            lblResult.Text = "Discipline: " + DisciplineAssoc + " | Group: " + GroupAssoc + " | Filter: " + Filter;

        }

        private void filterLayerList()
        {         
            string strFilter = txtSearch.Text.ToUpper();
            //char[] strFilterChArray = new char[strFilter.ToCharArray().Length];
            //strFilterChArray = strFilter.ToCharArray();

            lstViewLayerList.Items.Clear();
            foreach (LayerModel layer in layers)
            {
                if (strFilter != "")
                {
                    if (layer.LayerName.ToUpper().Contains(strFilter) || layer.LayerDescription.ToUpper().Contains(strFilter))
                    {
                        lstViewLayerList.Items.Add(new ListViewItem(new[] { layer.LayerName, layer.LayerDescription, layer.LayerColor, layer.LayerLinetype }));
                    }

                    // Check if search text contains characters matching the intended layer name/description
                    //else
                    //{
                    //    //char[] layerNameChArray = new char[layer.LayerName.Length];
                    //    //layerNameChArray = layer.LayerName.ToCharArray();

                    //    for (int strFilterIndex = 0; strFilterIndex < strFilter.Length; strFilterIndex++)
                    //    {
                    //        if (layer.LayerName.ToUpper().Contains(strFilter) || layer.LayerDescription.ToUpper().Contains(strFilter))
                    //        {
                    //            lstViewLayerList.Items.Add(new ListViewItem(new[] { layer.LayerName, layer.LayerDescription, layer.LayerColor, layer.LayerLinetype }));
                    //            break;
                    //        }

                    //        strFilter.Remove(0, 1);
                    //    }
                    //}
                }

                else
                {
                    lstViewLayerList.Items.Add(new ListViewItem(new[] { layer.LayerName, layer.LayerDescription, layer.LayerColor, layer.LayerLinetype }));
                }

            }

            lblLayerCount.Text = lstViewLayerList.Items.Count.ToString() + " Layers found.";

        }
    }
}
