using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Fine_Management_System.Popup
{
    public partial class shareMail : Form
    {
        OpenFileDialog ofdAttachment;
        string fileName = " ";
        public shareMail()
        {
            InitializeComponent();
        }

        private void Browse_click(object sender, MouseEventArgs e)
        {
            try
            {
                ofdAttachment = new OpenFileDialog();
                ofdAttachment.Filter = "Images(.jpg,.png)|*.png;*.jpg;|Pdf Files|*,pdf";
                if (ofdAttachment.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofdAttachment.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendmail_click(object sender, MouseEventArgs e)
        {
            try
            {
                SmtpClient clientDetail = new SmtpClient();
                clientDetail.Host = "smtp.gmail.com";
                clientDetail.Port = 587;
                clientDetail.EnableSsl = true;
                clientDetail.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetail.UseDefaultCredentials = false;
                clientDetail.Credentials = new NetworkCredential("finexpayment@gmail.com", "Sinerugroup9");
                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress("finexpayment@gmail.com");
                mailDetails.To.Add(txtRecipientEmail.Text.Trim());
                mailDetails.Subject = txtSubject.Text.Trim();
                mailDetails.Body = rtbBody.Text.Trim();

                if (fileName.Length > 0)
                {
                    Attachment attachment = new Attachment(fileName);
                    mailDetails.Attachments.Add(attachment);
                }
                clientDetail.Send(mailDetails);
                MessageBox.Show("Your mail has been sent");
                fileName = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addUsrBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
