using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Policy;

namespace lab1
{
    public partial class FillForm : Form
    {
        private MuveszekDAL muveszekDAL;
        private MualkotasDAL mualkotasDAL;
        private string errMess;
        private int errNumber;

        public FillForm()
        {
            InitializeComponent();
            string error = string.Empty;
            mualkotasDAL = new MualkotasDAL(ref error);

            if (error != "OK")
            {
                errNumber = 1;
                errMess = "Error" + errNumber + Environment.NewLine + "Mualkotas objektumot nem tudtam letrehozni. " + error;
            }
            else
            {
                errMess = "OK";
                muveszekDAL = new MuveszekDAL();
            }

        }

        private bool first;

        private void FillForm_Load(object sender, EventArgs e)
        {
            if (errMess == "OK")
            {
                FillCbMuveszek();
                InitializeListView();
                first = true;
                FillLvMualkotasok(false, "a", -1);
                first = false;
                panelModositas.Visible = false;
                panelRadio.Visible = false;
                panelTorles.Visible = false;
            }


        }

        private void FillCbMuveszek()
        {
            string error = string.Empty;
            List<Muvesz> muveszList = muveszekDAL.GetMuveszList(ref error);

            if (error != "OK")
            {
                errNumber++;
                if (errMess == "OK")
                {
                    errMess = string.Empty;
                    errMess = errMess + Environment.NewLine +
                   "Error" + errNumber + Environment.NewLine + "Hiba a ComboBox feltoltesenel." + error;
                }

            }
            else
            {
                cbMuveszFilter.DataSource = muveszList;
                cbMuveszFilter.DisplayMember = "MuveszNev";
                cbMuveszFilter.ValueMember = "MuveszId";
            }


        }


        private void InitializeListView()
        {
            listView.View = View.Details;
            listView.LabelEdit = true;
            listView.AllowColumnReorder = true;
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Sorting = SortOrder.Ascending;

            listView.Columns.Add("MualkotasCim", 150, HorizontalAlignment.Left);
            listView.Columns.Add("Muvesz(ek)Nev(ei)", 300, HorizontalAlignment.Left);
            listView.Columns.Add("AlkotasEve", 100, HorizontalAlignment.Left);
            listView.Columns.Add("StilusIranyzat", 150, HorizontalAlignment.Left);
            listView.Columns.Add("Ar", 100, HorizontalAlignment.Right);
            this.Controls.Add(listView);
        }


        private void FillLvMualkotasok(bool vanSzoveg, string szoveg, int muveszId)
        {
            if (!first)
            {
                listView.Clear();
                InitializeListView();
            }

            string error = string.Empty;
            List<Mualkotas> mualkotasList = mualkotasDAL.GetMualkotasListDataReader(vanSzoveg, szoveg, muveszId, ref error);
            if ((mualkotasList.Count != 0) && (error == "OK"))
            {
                foreach (Mualkotas item in mualkotasList)
                {
                    string[] s = new string[]
                    {
                        item.MualkotasCim,
                        item.MualkotasMuveszek,
                        item.AlkotasEve.ToString(),
                        item.MualkotasStilusiranyzat,
                        item.MualkotasAr.ToString()
                    };

                    ListViewItem lvi = new ListViewItem(s);
                    lvi.Tag = new { Id = item.MualkotasId, Verzio = item.Verzioszam };
                    listView.Items.Add(lvi);
                }
                listView.Items[0].Selected = true;
                listView.Select();
            }
            else if (error != "OK")
            {
                errNumber++;
                if (errMess == "OK") errMess = string.Empty;
                errMess = errMess + Environment.NewLine +
                    "Error" + errNumber + Environment.NewLine + "Hiba a ListView feltoltesenel." + error;
            }
        }

        //szures combobox alapjan
        private void btnFilter_Click(object sender, EventArgs e)
        {
            FillLvMualkotasok(false, "a", Convert.ToInt32(cbMuveszFilter.SelectedValue));
            if (errMess != "OK")
            {
                ErrorForm errorForm = new ErrorForm(errMess);
                errorForm.Show();
                errorForm.Focus();
            }
        }

        //szures textbox alapjan
        private void btnFilter2_Click(object sender, EventArgs e)
        {
            FillLvMualkotasok(true, textBox.Text, Convert.ToInt32(cbMuveszFilter.SelectedValue));
            if (errMess != "OK")
            {
                ErrorForm errorForm = new ErrorForm(errMess);
                errorForm.Show();
                errorForm.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FillForm_Shown(object sender, EventArgs e)
        {
            if (errMess != "OK")
            {
                ErrorForm errorForm = new ErrorForm(errMess);
                errorForm.Show();
                errorForm.Focus();
            }
        }


        private void keresesMenuItem_Click(object sender, EventArgs e)
        {
            panelKereses.Visible = true;
            panelModositas.Visible = false;
            panelTorles.Visible = false;

        }

        private void torlesMenuItem_Click(object sender, EventArgs e)
        {
            panelKereses.Visible = false;
            panelModositas.Visible = false;
            panelTorles.Visible = true;

        }

        private void modositasMenuItem_Click(object sender, EventArgs e)
        {
            panelKereses.Visible = false;
            panelModositas.Visible = true;
            panelTorles.Visible = false;

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"Biztosan törölni szeretné a(z) '{listView.SelectedItems[0].SubItems[0].Text}' műalkotást?\nEz több másik táblában is hatással lehet az adatokra!",
                "Megerősítés",
                   MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                string error = string.Empty;
                var tagObj = (dynamic)listView.SelectedItems[0].Tag;
                int mualkotasId = tagObj.Id;
                int verzioSzam = tagObj.Verzio;
                //int mualkotasId = Convert.ToInt32(listView.SelectedItems[0].Tag.Id);
                mualkotasDAL.deleteSelectedMualkotas(mualkotasId, ref error);
                if (error == "OK")
                {
                    MessageBox.Show($"A(z) '{listView.SelectedItems[0].SubItems[0].Text}' törlése sikeresen megtörtént.", "Törlés kész", MessageBoxButtons.OK, MessageBoxIcon.Information);       
                    listView.Items.Remove(listView.SelectedItems[0]);
                }
                else
                {
                    MessageBox.Show($"Hiba történt a törlés során: {error}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("A törlés megszakítva.", "Művelet megszakítva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void modositButton_Click(object sender, EventArgs e)
        {

            string ujErtek = textBoxModosit.Text;
            if (string.IsNullOrEmpty(ujErtek))
            {
                MessageBox.Show("Kérlek, adj meg egy árat", "Hibás adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ujAr = 0;

            try
            {
                ujAr = Convert.ToInt32(ujErtek);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kérlek, egész számot adj meg az árhoz!", "Hibás adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            if (ujAr < 0)
            {
                MessageBox.Show("Az ár nem lehet negatív!", "Hibás adat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var tagObj = (dynamic)listView.SelectedItems[0].Tag;
            int mualkotasID = tagObj.Id;
            int verzioSzam = tagObj.Verzio;
            //int mualkotasID = Convert.ToInt32(listView.SelectedItems[0].Tag);
            string error = string.Empty;
            int verzioSzamJelen = mualkotasDAL.selectVerzioSzam(mualkotasID, ref error);
            if(error != "OK")
            {
                MessageBox.Show("Something went wrong","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            error = string.Empty;

            if(verzioSzamJelen != verzioSzam)
            {
                MessageBox.Show("Az ár már módosításra került\n Válassz értéket ", "Válassz értéket", MessageBoxButtons.OK, MessageBoxIcon.Error);
                panelRadio.Visible = true;
                radioButton1.Text = listView.SelectedItems[0].SubItems[4].Text;
                radioButton2.Text = ujAr.ToString();
                radioButton3.Text = mualkotasDAL.selectAr(mualkotasID, ref error).ToString();
                return;
            }

            mualkotasDAL.updateMualkotasAr(mualkotasID, ujAr, ref error);

            if (error != "OK")
            {
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillLvMualkotasok(true, textBox.Text, Convert.ToInt32(cbMuveszFilter.SelectedValue));

        }


        private void radioModosit_Click(object sender, EventArgs e)
        {

            string kivalasztottErtek = "";

            if (radioButton1.Checked)
            {
               kivalasztottErtek = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                kivalasztottErtek = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
               kivalasztottErtek = radioButton3.Text;
            }

            int ar = Convert.ToInt32(kivalasztottErtek);

            var tagObj = (dynamic)listView.SelectedItems[0].Tag;
            int mualkotasID = tagObj.Id;
            string error = string.Empty;
          // int mualkotasID = Convert.ToInt32(listView.SelectedItems[0].Tag.Id);
           mualkotasDAL.updateMualkotasAr(mualkotasID,ar, ref error);

            if (error != "OK")
            {
               MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FillLvMualkotasok(true, textBox.Text, Convert.ToInt32(cbMuveszFilter.SelectedValue));

            panelRadio.Visible = false;
        }
    }
}
