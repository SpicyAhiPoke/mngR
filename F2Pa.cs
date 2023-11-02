using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_
{
    public partial class F2Pa : Form
    {
        F1M Main = new F1M();
        int i;
        decimal d;
        public bool EventCheck = false;

        public F2Pa()
        {
            InitializeComponent();

        }
        public F2Pa(Part pa)
        {
            InitializeComponent();
            modPart(pa);
        }

        public void modPart(Part pa)
        {
            EventCheck = true;
            tbID.Text = Inventory.CurrPart.ID.ToString();
            tbName.Text = Inventory.CurrPart.Name;
            tbInv.Text = Inventory.CurrPart.Inv.ToString();
            tbPrice.Text = Inventory.CurrPart.Price.ToString();
            tbMin.Text = Inventory.CurrPart.Min.ToString();
            tbMax.Text = Inventory.CurrPart.Max.ToString();

            if (Inventory.CurrPart is Inhouse)
            {
                Inhouse ih = (Inhouse)Inventory.CurrPart;
                tbSrc.Text = ih.MachID.ToString();
                rdIn.Checked = true;
            }
            else
            {
                Outsource os = (Outsource)Inventory.CurrPart;
                tbSrc.Text = os.CompanyName;
                rdOut.Checked = true;
            }
            EventCheck = false;
        }
        internal bool saveMe()
        {
            return 
                (!(string.IsNullOrWhiteSpace(tbName.Text) || (Int32.TryParse(tbName.Text, out i))) &&
                (!(string.IsNullOrWhiteSpace(tbInv.Text) || (!Int32.TryParse(tbInv.Text, out i))) &&
                (!(string.IsNullOrWhiteSpace(tbPrice.Text) || (!Decimal.TryParse(tbPrice.Text, out d))) &&
                (!(string.IsNullOrWhiteSpace(tbMin.Text) || (!Int32.TryParse(tbMin.Text, out i))) &&
                (!(string.IsNullOrWhiteSpace(tbMax.Text) || (!Int32.TryParse(tbMax.Text, out i))) &&
                (!(string.IsNullOrWhiteSpace(tbSrc.Text) || (rdIn.Checked && !Int32.TryParse(tbSrc.Text, out i)))))))));
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbInv.Text) || string.IsNullOrWhiteSpace(tbPrice.Text) || string.IsNullOrWhiteSpace(tbMin.Text) || string.IsNullOrWhiteSpace(tbMax.Text))
            {
                MessageBox.Show("Input(s) empty.", "Be Like Water");
            }
            else if ((tbName.BackColor == Color.MistyRose) || (tbInv.BackColor == Color.MistyRose) || (tbPrice.BackColor == Color.MistyRose) || (tbMin.BackColor == Color.MistyRose) || (tbMax.BackColor == Color.MistyRose))
            {
                MessageBox.Show("Input(s) invalid.", "Not Today");
            }
            else if (lbPartT.Text == "Add")
            {
                if (rdIn.Checked)
                {
                    Part pa = new Inhouse(Inventory.paID++, tbName.Text, int.Parse(tbInv.Text), decimal.Parse(tbPrice.Text), int.Parse(tbMin.Text), int.Parse(tbMax.Text), int.Parse(tbSrc.Text));
                    Inventory.AddPart(pa);

                }
                else
                {
                    Part pa = new Outsource(Inventory.paID++, tbName.Text, int.Parse(tbInv.Text), decimal.Parse(tbPrice.Text), int.Parse(tbMin.Text), int.Parse(tbMax.Text), tbSrc.Text);
                    Inventory.AddPart(pa);
                }
            }
            else if (lbPartT.Text == "Modify")
            {
                if (rdIn.Checked)
                {
                    Part pa = new Inhouse(int.Parse(tbID.Text), tbName.Text, int.Parse(tbInv.Text), decimal.Parse(tbPrice.Text), int.Parse(tbMin.Text), int.Parse(tbMax.Text), int.Parse(tbSrc.Text));
                    Inventory.UpdatePart(i, pa);
                }
                else
                {
                    Part pa = new Outsource(int.Parse(tbID.Text), tbName.Text, int.Parse(tbInv.Text), decimal.Parse(tbPrice.Text), int.Parse(tbMin.Text), int.Parse(tbMax.Text), tbSrc.Text);
                    Inventory.UpdatePart(i, pa);
                }
            }
            Hide();
            Main.Show();
            btSave.Enabled = saveMe();
        }
        private void btCc_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Show();
            MessageBox.Show("Input cleared.");
        }

        private void rdSrc()
        {
            btSave.Enabled = saveMe();

            if (string.IsNullOrEmpty(tbSrc.Text) || rdIn.Checked && !Int32.TryParse(tbSrc.Text, out i))
            {
                tbSrc.BackColor = Color.MistyRose;
            }
            else
            {
                tbSrc.BackColor = SystemColors.Window;
            }
        }
        private void rdIn_CheckedChanged(object sender, EventArgs e)
        {
            lbSrc.Text = "Mach. ID";
            rdSrc();
        }
        private void rdOut_CheckedChanged(object sender, EventArgs e)
        {
            lbSrc.Text = "Co. Name";
            rdSrc();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) || Int32.TryParse(tbName.Text, out i))
            {
                tbName.BackColor = Color.MistyRose;
            }
            else
            {
                tbName.BackColor = SystemColors.Window;
            }
            btSave.Enabled = saveMe();
        }
        private void tbInv_TextChanged(object sender, EventArgs e)
        {
            if (EventCheck)
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(tbInv.Text) || !Int32.TryParse(tbInv.Text, out i))
            {
                tbInv.BackColor = Color.MistyRose;
            }
            else if (Convert.ToInt32(tbInv.Text) < Convert.ToInt32(tbMin.Text) || Convert.ToInt32(tbInv.Text) > Convert.ToInt32(tbMax.Text))
            {
                tbInv.BackColor = Color.MistyRose;
                MessageBox.Show(">= Min & <= Max");
            }
            else
            {
                tbInv.BackColor = SystemColors.Window;
            }
            btSave.Enabled = saveMe();
        }
        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPrice.Text) || !Decimal.TryParse(tbPrice.Text, out d))
            {
                tbPrice.BackColor = Color.MistyRose;
            }
            else
            {
                tbPrice.BackColor = SystemColors.Window;
            }
            btSave.Enabled = saveMe();
        }
        private void tbMin_TextChanged(object sender, EventArgs e)
        {
            if (EventCheck)
            {
                return;
            }
            if (string.IsNullOrEmpty(tbMin.Text) || !Int32.TryParse(tbMin.Text, out i))
            {
                tbMin.BackColor = Color.MistyRose;
            }
            else if (Convert.ToInt32(tbMin.Text) > Convert.ToInt32(tbMax.Text) || Convert.ToInt32(tbMin.Text) > Convert.ToInt32(tbInv.Text))
            {
                tbMin.BackColor = Color.MistyRose;
                MessageBox.Show("<= Max & Inv");
            }
            else
            {
                tbMin.BackColor = SystemColors.Window;
            }
            btSave.Enabled = saveMe();
        }
        private void tbMax_TextChanged(object sender, EventArgs e)
        {
            if (EventCheck)
            {
                return;
            }
            if (string.IsNullOrEmpty(tbMax.Text) || !Int32.TryParse(tbMax.Text, out i))
            {
                tbMax.BackColor = Color.MistyRose;
            }
            else if (Int32.Parse(tbMax.Text) < Int32.Parse(tbMin.Text) || Int32.Parse(tbMax.Text) < Int32.Parse(tbInv.Text))
            {
                tbMax.BackColor = Color.MistyRose;
                MessageBox.Show(">= Min & Inv");
            }
            else
            {
                tbMax.BackColor = SystemColors.Window;
            }
            btSave.Enabled = saveMe();
        }
        private void tbSrc_TextChanged(object sender, EventArgs e)
        {
            rdSrc();
        }

        private void F2Pa_Load(object sender, EventArgs e)
        {

        }
    }
}
