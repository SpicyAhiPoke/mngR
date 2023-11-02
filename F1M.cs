using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace IMS_
{
    public partial class F1M : Form
    {
        public int XSel = -1;

        public void ShowMe()
        {
            dgvPart.AutoGenerateColumns = false;
            dgvPart.DataSource = Inventory.AllParts;
            dgvPart.ClearSelection();
            dgvProd.AutoGenerateColumns = false;
            dgvProd.DataSource = Inventory.Products;
            dgvProd.ClearSelection();
        }

        public F1M()
        {
            InitializeComponent();
            ShowMe();
        }
        private void F1M_Click(object sender, EventArgs e)
        {
            dgvPart.ClearSelection();
            dgvProd.ClearSelection();
            btAdd.Enabled = true;
            btAdd1.Enabled = true;
            btMod.Enabled = false;
            btMod1.Enabled = false;
            btDel.Enabled = false;
            btDel1.Enabled = false;
        }

        private void dgvPart_DataBindinComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPart.ClearSelection();
        }
        private void dgvProd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProd.ClearSelection();
        }
        private void dgvPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            XSel = dgvPart.CurrentCell.RowIndex;
            Inventory.CurrID = (int)dgvPart.Rows[XSel].Cells[0].Value;
            Inventory.CurrPart = Inventory.LookupPart(Inventory.CurrID);
            btAdd.Enabled = false;
            btAdd1.Enabled = false;
            btMod.Enabled = true;
            btMod1.Enabled = false;
            btDel.Enabled = true;
            btDel1.Enabled = false;

            if (XSel >= 0)
            {
                dgvProd.ClearSelection();
            }
        }
        private void dgvProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            XSel = dgvProd.CurrentCell.RowIndex;
            Inventory.CurrID = (int)dgvProd.Rows[XSel].Cells[0].Value;
            Inventory.CurrProd = Inventory.LookupProduct(Inventory.CurrID);
            btAdd1.Enabled = false;
            btAdd.Enabled = false;
            btMod1.Enabled = true;
            btMod.Enabled = false;
            btDel1.Enabled = true;
            btDel.Enabled = false;

            if (XSel >= 0)
            {
                dgvPart.ClearSelection();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Leaving application.", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dgvPart.DataSource = Inventory.AllParts;
        }
        private void tbSearch1_TextChanged(object sender, EventArgs e)
        {
            dgvProd.DataSource = Inventory.Products;
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
        private void btSearch1_Click(object sender, EventArgs e)
        {
            BindingList<Product> FilterThis = new BindingList<Product>();
            bool found = false;
            if (tbSearch1.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(tbSearch1.Text.ToUpper()))
                    {
                        FilterThis.Add(Inventory.Products[i]);
                        found = true;
                    }
                }
                if (found)
                {
                    dgvProd.DataSource = FilterThis;
                }
                if (!found)
                {
                    MessageBox.Show("Product(s) " + '"' + tbSearch1.Text + '"' + " not found.");
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Hide();
            F2Pa addPart = new F2Pa();
            addPart.Show();
        }
        private void btAdd1_Click(object sender, EventArgs e)
        {
            F3Pr modProd = new F3Pr();
            Hide();
            modProd.Show();
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            if (XSel >= 0)
            {
                Hide();
                DataGridViewRow XSel = dgvPart.SelectedRows[0];
                Part pa = Inventory.LookupPart(Convert.ToInt32(XSel.Cells["clID"].Value));
                F2Pa modPart = new F2Pa(pa);
                modPart.Show();
                modPart.lbPartT.Text = "Modify";
            }
            else
            {
                MessageBox.Show("Select a Part.", "Modify");
            }
        }
        private void btMod1_Click(object sender, EventArgs e)
        {
            if (XSel >= 0)
            {
                Hide();
                DataGridViewRow XSel = dgvProd.SelectedRows[0];
                Product pr = Inventory.LookupProduct(Convert.ToInt32(XSel.Cells["clID1"].Value));
                F3Pr modProd = new F3Pr(pr);
                modProd.Show();
                modProd.lbProdT.Text = "Modify";
            }
            else
            {
                MessageBox.Show("Select a Product.", "Modify");
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (XSel >= 0)
            {
                if (MessageBox.Show("Confirm delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow XSel = dgvPart.SelectedRows[0];
                    Part pa = Inventory.LookupPart(Convert.ToInt32(XSel.Cells["clID"].Value));
                    Inventory.DeletePart(pa);
                    ShowMe();
                }
            }
            else
            {
                MessageBox.Show("Select a Part.", "Delete");
            }
        }
        private void btDel1_Click(object sender, EventArgs e)
        {
            if (XSel >= 0)
            {               
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].ID == (int)dgvProd.Rows[XSel].Cells[0].Value)
                    {
                        DataGridViewRow XSel = dgvProd.SelectedRows[0];
                        Product pr = Inventory.LookupProduct(Convert.ToInt32(XSel.Cells["clID1"].Value));

                        if (pr.AssociatedParts.Count > 0)
                        {
                            MessageBox.Show("Delete Product's Parts.");
                        }
                        else if(MessageBox.Show("Confirm delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes);
                        {
                            Inventory.RemoveProduct(i);
                        }
                    }
                }
                ShowMe();
                XSel = -1;
                
            }

            else
            {
                MessageBox.Show("Select a Product.", "Delete");
            }
        }
    }
}
