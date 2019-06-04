using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCodeFirst
{
    public partial class Form1 : Form
    {

        DbModel db = new DbModel();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            gridKlijenti.DataSource = null;
            gridServisi.DataSource = null;            

            GetData();
        }

        private void GetData()
        {
            Cursor = Cursors.WaitCursor;

            try
            {                            
                gridKlijenti.DataSource = db.Klijents.ToList();
                gridServisi.DataSource = db.Servis.ToList();

                gridKlijenti.ClearSelection();
                gridServisi.ClearSelection();
                gridKlijenti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridServisi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridKlijenti.MultiSelect = false;
                gridServisi.MultiSelect = false;

                cmbKlijenti.DataSource = db.Klijents.ToList();
                cmbKlijenti.DisplayMember = "NazivKlijenta";
                cmbKlijenti.ValueMember = "Id";
                
                txtImeKlijenta.Text = null;
                txtKontakt.Text = null;
                txtRegBr.Text = null;
                txtDodatniKom.Text = null;
                txtOpisUsluge.Text = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void txtDodajKlijenta_Click(object sender, EventArgs e)
        {
            Klijent novKlijent = new Klijent();

            try
            {
                if (string.IsNullOrEmpty(txtImeKlijenta.Text))
                {
                    MessageBox.Show("Unesite ime!");
                    txtImeKlijenta.Focus();
                    return;
                }
                else
                {
                    novKlijent.NazivKlijenta = txtImeKlijenta.Text;
                }

                if (string.IsNullOrEmpty(txtRegBr.Text))
                {
                    MessageBox.Show("Unesite registarski broj!");
                    txtRegBr.Focus();
                    return;
                }
                else
                {
                    novKlijent.RegistarskiBroj = txtRegBr.Text;
                }

                if (string.IsNullOrEmpty(txtKontakt.Text))
                {
                    MessageBox.Show("Unesite kontakt!");
                    txtKontakt.Focus();
                    return;
                }
                else
                {
                    novKlijent.Kontakt = txtKontakt.Text;
                }

                novKlijent.DodatniKomentar = txtDodatniKom.Text;

                db.Klijents.Add(novKlijent);

                int ret = db.SaveChanges();

                if (ret != 0)
                {
                    MessageBox.Show("Sacuvano!");
                }

                GetData();
            }
            catch (DbEntityValidationException EFex)
            {
                foreach (DbEntityValidationResult s in EFex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }
                }
                
                db.Dispose();
                db = new DbModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnDodajServis_Click(object sender, EventArgs e)
        {
            Servis novServis = new Servis();

            try
            {
                if (string.IsNullOrEmpty(txtOpisUsluge.Text))
                {
                    MessageBox.Show("Unesite opis usluge!");
                    txtOpisUsluge.Focus();
                    return;
                }
                else
                {
                    novServis.OpisUsluge = txtOpisUsluge.Text;
                }

                if (dtpUsluga.Value == null)
                {
                    MessageBox.Show("Izaberite datum usluge!");
                    dtpUsluga.Focus();
                    return;
                }
                else
                {
                    novServis.DatumServisa = dtpUsluga.Value;
                }

                if (cmbKlijenti.SelectedValue == null)
                {
                    MessageBox.Show("Izaberite klijenta!");
                    cmbKlijenti.Focus();
                    return;
                }
                else
                {
                    novServis.KlijentId = Convert.ToInt32(cmbKlijenti.SelectedValue);
                }

                db.Servis.Add(novServis);

                int ret = db.SaveChanges();

                if (ret != 0)
                {
                    MessageBox.Show("Sacuvano!");
                }

                GetData();
            }
            catch (DbEntityValidationException EFex)
            {
                foreach (DbEntityValidationResult s in EFex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }
                }

                db.Dispose();
                db = new DbModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnObrisiKlijenta_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (gridKlijenti.SelectedRows.Count > 0)
                {
                    int klijentId = Convert.ToInt32(gridKlijenti.SelectedRows[0].Cells[0].Value);
                    Klijent klijentZaBrisanje = db.Klijents.SingleOrDefault(k => k.Id == klijentId);

                    db.Klijents.Remove(klijentZaBrisanje);
                }                

                if (gridServisi.SelectedRows.Count > 0)
                {
                    int servisId = Convert.ToInt32(gridServisi.SelectedRows[0].Cells[0].Value);
                    Servis servisZaBrisanje = db.Servis.SingleOrDefault(s => s.Id == servisId);

                    db.Servis.Remove(servisZaBrisanje);
                }
                
                int ret = db.SaveChanges();

                if (ret != 0)
                {
                    MessageBox.Show("Obrisano!");
                }

                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnIzmeniKlijenta_Click(object sender, EventArgs e)
        {
            int ret = db.SaveChanges();

            if (ret != 0)
            {
                MessageBox.Show("Izmenjeno!");
            }

            GetData();
        }

        private void btnServisiZaKlijenta_Click(object sender, EventArgs e)
        {
            int klijentId = Convert.ToInt32(cmbKlijenti.SelectedValue);
            Klijent klijent = db.Klijents.SingleOrDefault(k => k.Id == klijentId);

            gridServisiZaKlijenta.DataSource = klijent.Servisi;
        }
    }
}
