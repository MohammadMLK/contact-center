using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_center
{
    public partial class contactform : Form
    {
        ContactCenterDBEntities DB;
        public Contact ContactEdit { get; set; }
        public contactform()
        {
            DB = new ContactCenterDBEntities();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void savebuttton_Click(object sender, EventArgs e)
        {
            if (ContactEdit != null)
            {
                ContactEdit.FirstName = txtname.Text.Trim();
                ContactEdit.LastName = txtfamily.Text.Trim();
                ContactEdit.LandlineNumber = txtlandline.Text.Trim();
                ContactEdit.PhoneNumber = txtmobile.Text.Trim();
                ContactEdit.Email = txtemail.Text.Trim();
                ContactEdit.GroupContact = comboBoxgroup.SelectedIndex;
                ContactEdit.Address = txtaddress.Text.Trim();
                ContactEdit.Description = txtdescription.Text.Trim();

                DB.Entry(ContactEdit).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                this.Close();
            }
            else
            {
                Contact contact = new Contact
                {
                    FirstName = txtname.Text.Trim(),
                    LastName = txtfamily.Text.Trim(),
                    LandlineNumber = txtlandline.Text.Trim(),
                    PhoneNumber = txtmobile.Text.Trim(),
                    Email = txtemail.Text.Trim(),
                    GroupContact = comboBoxgroup.SelectedIndex,
                    Address = txtaddress.Text.Trim(),
                    Description = txtdescription.Text.Trim()
                };
                DB.Contacts.Add(contact);
                DB.SaveChanges();
                this.Close();
            }



            Contact mycontact = new Contact
            {
                FirstName = txtname.Text.Trim(),
                LastName = txtfamily.Text.Trim(),
                LandlineNumber = txtlandline.Text.Trim(),
                PhoneNumber = txtmobile.Text.Trim(),
                Email = txtemail.Text.Trim(),
                GroupContact = comboBoxgroup.SelectedIndex,
                Address = txtaddress.Text.Trim(),
                Description = txtdescription.Text.Trim(),
            };
            DB.Contacts.Add(mycontact);
            DB.SaveChanges();
            this.Close();
        }

        private void contactform_Activated(object sender, EventArgs e)
        {
            if (this.ContactEdit != null)
            {
                txtname.Text = ContactEdit.FirstName;
                txtfamily.Text = ContactEdit.LastName;
                txtlandline.Text = ContactEdit.LandlineNumber;
                txtmobile.Text = ContactEdit.PhoneNumber;
                txtemail.Text = ContactEdit.Email;
                comboBoxgroup.SelectedIndex = ContactEdit.GroupContact;
                txtaddress.Text = ContactEdit.Address;
                txtdescription.Text = ContactEdit.Description;
            }
        }
    }
}
