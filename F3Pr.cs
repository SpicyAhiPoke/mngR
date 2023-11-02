using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS_
{
    public partial class F3Pr : Form
    {
        F1M Main = new F1M();
        F2Pa f2 = new F2Pa();
        int i;
        decimal d;
        private int XSel = -1;
        public bool EventCheck = false;


        public BindingList<Part> AssociatedParts = new BindingList<Part>(); //Creates list to hold Product's Parts

        public F3Pr()
        {
            InitializeComponent();
            ShowMe();
        }
        public F3Pr(Product pr)
        {
            InitializeComponent();
            modProd(pr);
        }

        public void ShowMe()
        {
            dgvPart.AutoGenerateColumns = false;
            dgvPart.DataSource = Inventory.AllParts;
            dgvPart.ClearSelection();
            dgvProdParts.AutoGenerateColumns = false;
            dgvProdParts.DataSource = AssociatedParts;
            dgvProdParts.ClearSelection();
        }

        private void modProd(Product pr)
        {
            EventCheck = true;
            ShowMe();
            tbID.Text = Inventory.CurrProd.ID.ToString();
            tbName.Text = Inventory.CurrProd.Name;
            tbInv.Text = Inventory.CurrProd.Inv.ToString();
            tbPrice.Text = Inventory.CurrProd.Price.ToString();
            tbMin.Text = Inventory.CurrProd.Min.ToString();
            tbMax.Text = Inventory.CurrProd.Max.ToString();
            for (int i = 0; i < pr.AssociatedParts.Count; i++)
            {
                AssociatedParts.Add(pr.AssociatedParts[i]);
            }
            EventCheck = false;
        }

        private void F3Pr_Click(object sender, EventArgs e)
        {
            dgvPart.ClearSelection();
            dgvProdParts.ClearSelection();
            btAdd.Enabled = false;
            btDel.Enabled = false;
        }

        private void dgvPart_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPart.ClearSelection();
        }
        private void dgvProdParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProdParts.ClearSelection();
        }
        private void dgvPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            XSel = dgvPart.CurrentCell.RowIndex;
            Inventory.CurrID = (int)dgvPart.Rows[XSel].Cells[0].Value;
            Inventory.CurrPart = Inventory.LookupPart(Inventory.CurrID);
            btAdd.Enabled = true;
            btDel.Enabled = false;
            if (XSel >= 0)
            {
                dgvProdParts.ClearSelection();
            }

        }
        private void dgvProdParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            XSel = dgvProdParts.CurrentCell.RowIndex;
            Inventory.CurrID = (int)dgvProdParts.Rows[XSel].Cells[0].Value;
            //Inventory.CurrPart = Product.LookupAssociatedPart(Inventory.CurrID);
            btAdd.Enabled = false;
            btDel.Enabled = true;
            if (XSel >= 0)
            {
                dgvPart.ClearSelection();
            }

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
            else if (lbProdT.Text == "Add")
            {
                Product pr = new Product(Inventory.prID++, tbName.Text, int.Parse(tbInv.Text), decimal.Parse(tbPrice.Text), int.Parse(tbMin.Text), int.Parse(tbMax.Text));
                Inventory.AddProduct(pr);
                for (int i = 0; i < AssociatedParts.Count; i++)
                {
                    pr.AddAssociatedPart(AssociatedParts[i]);
                }
                Hide();
                Main.Show();
            }
            else if (lbProdT.Text == "Modify")
            {
                Product pr = new Product(int.Parse(tbID.Text), tbName.Text, int.Parse(tbInv.Text), decimal.Parse(tbPrice.Text), int.Parse(tbMin.Text), int.Parse(tbMax.Text));
                
                Inventory.UpdateProduct(i, pr);
                for (int i = 0; i < AssociatedParts.Count; i++)
                {
                    pr.AddAssociatedPart(AssociatedParts[i]);
                }
                Hide();
                Main.Show();
            }
            f2.saveMe();
        }
        private void btCc_Click(object sender, EventArgs e)
        {
            Hide();
            Main.Show();
            MessageBox.Show("Not Saved.");
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dgvPart.DataSource = Inventory.AllParts;
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            BindingList<Part> FilterThis = new BindingList<Part>();
            bool found = false;
            if (tbSearch.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(tbSearch.Text.ToUpper()))
                    {
                        FilterThis.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if (found)
                {
                    dgvPart.DataSource = FilterThis;
                }
                if (!found)
                {
                    MessageBox.Show("Part(s) " + '"' + tbSearch.Text + '"' + " not found.");
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (XSel >= 0)
            {
                Part pa = dgvPart.CurrentRow.DataBoundItem as Part;
                AssociatedParts.Add(pa);
                dgvPart.ClearSelection();
                btAdd.Enabled = false;

                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].ID == (int)dgvPart.Rows[XSel].Cells[0].Value)
                    {
                        Inventory.CurrPart = Inventory.AllParts[i];
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a Part.", "Add to Product");
            }
        }
        private void btDel_Click(object sender, EventArgs e)
        {
            if (XSel >= 0)
            {
                for (int i = 0; i < AssociatedParts.Count; i++)
                {
                    if (AssociatedParts[i].ID == (int)dgvProdParts.Rows[XSel].Cells[0].Value)
                    {
                        if (MessageBox.Show("Confirm delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            AssociatedParts.RemoveAt(i);
                            break;
                        }
                    }
                }
                ShowMe();
                XSel = -1;
            }
            else
            {
                MessageBox.Show("Select a Part.", "Delete from Product");
            }
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
            f2.saveMe();
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
            else if (Int32.Parse(tbInv.Text) < Int32.Parse(tbMin.Text) || Int32.Parse(tbInv.Text) > Int32.Parse(tbMax.Text))
            {
                tbInv.BackColor = Color.MistyRose;
                MessageBox.Show(">= Min & <= Max");
            }
            else
            {
                tbInv.BackColor = SystemColors.Window;
            }
            f2.saveMe();
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
            f2.saveMe();
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
            else if (Int32.Parse(tbMin.Text) > Int32.Parse(tbMax.Text) || Int32.Parse(tbMin.Text) > Int32.Parse(tbInv.Text))
            {
                tbMin.BackColor = Color.MistyRose;
                MessageBox.Show("<= Max & Inv");
            }
            else
            {
                tbMin.BackColor = SystemColors.Window;
            }
            f2.saveMe();
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
                MessageBox.Show(">= Min &Max");
            }
            else
            {
                tbMax.BackColor = SystemColors.Window;
            }
            f2.saveMe();
        }
    }
}
