using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataEntryTest
{
    public partial class frmdataentry : Form
    {

 string[] ID = new String[100];
            string[] Forename = new String[100];
            string[] Surname = new String[100];
            string[] Address = new String[100];
            string[] City = new String[100];
            string[] Zip = new String[100];

            int Idx = 0;
            string sID;
            int LastRecord = 0;
            int FirstRecord = 999;
            int CurrentRecord = -99;

        public void DisplayRecord(int i)
        {
            txtid.Text = ID[i];
            txtfirstname.Text = Forename[i];
            txtsurname.Text = Surname[i];
            txtaddress.Text = Address[i];
            txtcity.Text = City[i];
            txtzip.Text = Zip[i];
        }

        public void ClearDisplay()
        {
            txtid.Clear();
            txtfirstname.Clear();
            txtsurname.Clear();
            txtaddress.Clear();
            txtcity.Clear();
            txtzip.Clear();
        }

        public frmdataentry()
        {
            InitializeComponent();
           
        }

        private void frmdataentry_Load(object sender, EventArgs e)
        {

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("customer.dat");
                while ((sID = sr.ReadLine()) != null)
                {
                    Idx = Int32.Parse(sID);
                    if (LastRecord < Idx) LastRecord = Idx;
                    if (FirstRecord > Idx) FirstRecord = Idx;
                    ID[Idx] = sID;
                    Forename[Idx] = sr.ReadLine();
                    Surname[Idx] = sr.ReadLine();
                    Address[Idx] = sr.ReadLine();
                    City[Idx] = sr.ReadLine();
                    Zip[Idx] = sr.ReadLine();
                }
            }
            catch (IOException error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                if (sr != null) { sr.Close(); }
            }
        }
        private void btnfirstrec_Click(object sender, EventArgs e)
        {
            CurrentRecord = FirstRecord;
            DisplayRecord(CurrentRecord);
        }

        private void btnlastrec_Click(object sender, EventArgs e)
        {
            CurrentRecord = LastRecord;
            DisplayRecord(CurrentRecord);
        }

        private void btnnextrec_Click(object sender, EventArgs e)
        {
            if (CurrentRecord < LastRecord)
            {
                for (int i = CurrentRecord+1; i <= LastRecord; i++)
                {
                    if (Int32.Parse(ID[i]) > 0)
                    {
                        CurrentRecord = i;
                        DisplayRecord(CurrentRecord);
                        break;
                    }
                }
            }
        }

        private void btnprerec_Click(object sender, EventArgs e)
        {
            if (CurrentRecord > FirstRecord)
            {
                for (int i = CurrentRecord - 1; i <= FirstRecord; i--)
                {
                    if (Int32.Parse(ID[i]) > 0)
                    {
                        CurrentRecord = i;
                        DisplayRecord(CurrentRecord);
                        break;
                    }
                }
            }
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            int NextRecord = LastRecord + 1;
            txtid.Text = NextRecord.ToString();

            txtfirstname.Clear();
            txtsurname.Clear();
            txtaddress.Clear();
            txtcity.Clear();
            txtzip.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Idx = Math.Abs(Int32.Parse(txtid.Text));
            if (LastRecord < Idx) LastRecord = Idx;

            ID[Idx] = txtid.Text;
            Forename[Idx] = txtfirstname.Text;
            Surname[Idx] = txtsurname.Text;
            Address[Idx] = txtaddress.Text;
            City[Idx] = txtcity.Text;
            Zip[Idx] = txtzip.Text;

        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            StreamWriter sw = null;
            sw = new StreamWriter("customer.dat");

            for(int i = FirstRecord; i <= LastRecord; i++)
            {
                sw.WriteLine(ID[i]);
                sw.WriteLine(Forename[i]);
                sw.WriteLine(Surname[i]);
                sw.WriteLine(Address[i]);
                sw.WriteLine(City[i]);
                sw.WriteLine(Zip[i]);
            }
            sw.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            statusStrip1.Text = "Searching";
            String SearchText = txtsearch.Text;
            String DataString = "";
            DialogResult Found = DialogResult.Yes;
            DialogResult Cancel = DialogResult.No;

            for(int i = FirstRecord; i <= LastRecord; i++)
            {
                DataString = Forename[i] + " " + Surname[i];
                if (DataString .Contains (SearchText))
                {
                    statusStrip1.Text = "match Found";
                    CurrentRecord = i;
                    DisplayRecord(CurrentRecord);
                    DialogResult Result = MessageBox.Show("Is this the correct record?", "Search", MessageBoxButtons.YesNoCancel);
                        if (Result == Found)
                    {
                        break;
                    }
                        else
                    {
                        ClearDisplay();
                        if (Result == Cancel)
                        {
                            statusStrip1.Text = "search cancelled";
                            break;
                        }  
                    }
                }
            }

        }

        private void btnsearchmessage_Click(object sender, EventArgs e)
        {
            statusStrip1.Text = "Searching";
            String SearchText = txtsearch.Text;
            String DataString = "";
            DialogResult Found = DialogResult.Yes;
            DialogResult Cancel = DialogResult.No;

            for (int i = FirstRecord; i <= LastRecord; i++)
            {
                statusStrip1.Text = "match Found";
                CurrentRecord = i;
                DisplayRecord(CurrentRecord);

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Idx = Int32.Parse(txtid.Text);
            int i = Idx;
            ID[Idx] = i.ToString();

            CurrentRecord = FirstRecord;
            DisplayRecord(CurrentRecord);
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            tspLoading.Minimum = FirstRecord;
            tspLoading.Maximum = LastRecord;
            tspLoading.Value = CurrentRecord;

        }
    }
}
