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
    public partial class main_frm : Form
    {
        ContactCenterDBEntities DB;
        public main_frm()
        {
            DB = new ContactCenterDBEntities();
            InitializeComponent();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void main_frm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.Contacts.ToList().Select(x => new
            {
                x.id,
                x.FirstName,
                x.LastName,
                x.LandlineNumber,
                x.PhoneNumber,
                x.Email,
                GroupContact = GetGroupName(x.GroupContact),
                x.Address,
                x.Description,
            }

           ) .ToList();

            dataGridView1.Columns[0].HeaderText = "row";
            dataGridView1.Columns[1].HeaderText = "FirstName";
            dataGridView1.Columns[2].HeaderText = "LastName";
            dataGridView1.Columns[3].HeaderText = "LandlineNumber";
            dataGridView1.Columns[4].HeaderText = "PhoneNumber";
            dataGridView1.Columns[5].HeaderText = "Email";
            dataGridView1.Columns[6].HeaderText = "Group";
            dataGridView1.Columns[7].HeaderText = "Address";  
            dataGridView1.Columns[8].HeaderText = "Description";




        }

        private void mnuitemtools_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addcontactbtn_Click(object sender, EventArgs e)
        {
            contactform contactform = new contactform();
            contactform.ShowDialog();

        }

        private void partnersbtn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string GetGroupName(int groupNumber)
        {
            var result = "";

            switch (groupNumber)
            {
                case 0:
                    result = "normal";
                    break;

                case 1:
                    result = "partners";
                    break;
                
                case 2:
                    result = "friends";
                    break;

                case 3:
                    result = "family";
                    break;

                case 4:
                    result = "emergency";
                    break;
            }
            return "H";
            //switch (groupNumber)
            //{
            //    

            //    
            //    case 3:
            //        result = "family";
            //        break;
            //    case 4:
            //        result = "emergency";
            //        break;

            //        switch (groupNumber)
            //        {   
            //             case 2:
            //                { 
            //                    result = "friends";
            //                    break;
            //                }
            //            case 3:
            //                result = "family";
            //                break;
            //            case 4:
            //                result = "emergency";
            //                break;

            //                switch (groupNumber)
            //            {
            //                case 3:
            //                    result = "family";
            //                    break;
            //            }

            //            switch (groupNumber)
            //            {
            //                case 4:
            //                    result = "emergency";
            //                    break;
            //            }
            //        }


            //    }
        }

        private void main_frm_Activated(object sender, EventArgs e)
        {

        }

        private void editcontactbutton_Click(object sender, EventArgs e)
        {
            var ContactId = int.Parse (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            var con = DB.Contacts.Where(x => x.id == ContactId).FirstOrDefault();
            contactform contactform = new contactform();
            contactform.ContactEdit = con;
            contactform.ShowDialog();
        }
    }

    public enum GroupContactEnum
        {
         normal,
         partner,
         friends,
         family,
         emergency,
        }

    }

