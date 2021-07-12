using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fine_Management_System.AddUser
{
    public partial class AddUsr : Form
    {
        public AddUsr()
        {
            InitializeComponent();
        }

        private void addUsrBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            fName.Clear();
            lName.Clear();
            nicNo.Clear();
            address.Clear();
            contactNo.Clear();
            emailAddress.Clear();
            fullName.Clear();
            post.Clear();
            dateTimePickerAddUsr.ResetText();
            usrImage.Image = null;

        }

        OpenFileDialog file = new OpenFileDialog();
        
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            file.Filter = "ImageFiles(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            file.ShowDialog();
            usrImage.Image = new Bitmap(file.FileName);
            uploadBtn.Text = "Change";
        }
    }
}
