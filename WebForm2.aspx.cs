using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace holidayRedesign
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void MedsCustomerCare()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("Marisac@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("MedsCustomerCare");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);

        }
        public void ManagingDirector()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("Rebecca@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("ManagingDirector");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);

        }
        public void FITUKLondonoffice()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("elisab@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("FITUKLondonoffice");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);

        }
        public void ContractingUk()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("Carolinem@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("ContractingUk");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);

        }
        public void OperationsUK()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("karing@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("OperationsUK");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);

        }
        public void FITUKEdinburghoffice()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("Derek@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("MedsCustomerCare");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);

        }
        public void CustomerCareIntlMktsEdinburgh()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("irene@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("CustomerCareIntlMktsEdinburgh");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);

        }
        public void CustomerCareMedsEdinburgh()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("Montse@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("MedsCustomerCare");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);

        }
        public void CustomerCareGermanNordicsEdin()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("Mariah@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("CustomerCareGermanNordicsEdin");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);

        }
        public void AccommodationEdinburghoffice()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("Laird@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("AccommodationEdinburghoffice");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);

        }
        public void AccommodationDirector()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("Jamie@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("AccommodationDirector");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);

        }
        public void CustomerCareDirector()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("Johnc@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("CustomerCareDirector");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);

        }
        public void Accounts()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("joyl@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("Accounts");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);

        }


        public string table(string type)
        {
            string tb = "<br>" + "<table><tr><td>" + Label1.InnerText + "</td><td>" + textbox1.Text.ToString() +
            " </td><td>&nbsp;</td></tr><tr><td> " + Label2.InnerText + "</td><td>" + textbox2.Text.ToString() +
            "</td><td>&nbsp;</td></tr><tr><td>" + Label3.InnerText + "</td><td>" + DropDownList1.Text +
            "</td><td>&nbsp;</td></tr><tr><td>" + Label4.InnerText + "</td><td>" + DropDownList2.Text +
            "</td><td>&nbsp;</td></tr><tr><td >" + Label5.InnerText + "</td><td>" + DropDownList3.Text + "\\" + DropDownList4.Text + "\\" + DropDownList5.Text
            + "</td><td>&nbsp;</td></tr><tr><td >" + Label6.InnerText + "</td><td>" + textbox3.Text.ToString() +
            "</td><td>&nbsp;</td></tr><tr><td>" + Label7.InnerText + "</td><td>" + textbox4.Text.ToString() +
            "</td><td>&nbsp;</td></tr><tr><td>" + Label8.InnerText + "</td><td>" + DropDownList6.Text + "\\" + DropDownList7.Text + "\\" + DropDownList8.Text +
            "</td><td>&nbsp;</td></tr><tr><td>" + Label9.InnerText + "</td><td>" + textbox6.Text.ToString() +
            "</td><td>&nbsp;</td></tr><tr><td>" + Label10.InnerText + "</td><td>" + textbox7.Text.ToString()
            + "</td><td ></td>   </table>";

            return tb;
        }
        //Send to each individual department based on what department they chose on the drop down list
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList9.SelectedItem.Text == "MedsCustomerCare")
                MedsCustomerCare();
            if (DropDownList9.SelectedItem.Text == "Managing Director")
                ManagingDirector();
            if (DropDownList9.SelectedItem.Text == "FIT UK (London office)")
                FITUKLondonoffice();
            if (DropDownList9.SelectedItem.Text == "Contracting Uk")
                ContractingUk();
            if (DropDownList9.SelectedItem.Text == "Operations UK")
                OperationsUK();
            if (DropDownList9.SelectedItem.Text == "FIT UK (Edinburgh office)")
                FITUKEdinburghoffice();
            if (DropDownList9.SelectedItem.Text == "Customer Care Intl Mkts Edinburgh")
                CustomerCareIntlMktsEdinburgh();
            if (DropDownList9.SelectedItem.Text == "Customer Care Meds Edinburgh")
                CustomerCareMedsEdinburgh();
            if (DropDownList9.SelectedItem.Text == "Customer Care German/Nordics Edin")
                CustomerCareGermanNordicsEdin();
            if (DropDownList9.SelectedItem.Text == "Accommodation (Edinburgh office)")
                AccommodationEdinburghoffice();
            if (DropDownList9.SelectedItem.Text == "Accommodation Director")
                AccommodationDirector();
            if (DropDownList9.SelectedItem.Text == "Customer Care Director")
                CustomerCareDirector();
            if (DropDownList9.SelectedItem.Text == "Accounts")
                Accounts();
            

            Server.Transfer("HtmlPage1.html");
            Server.Transfer("HTMLPage1.html");
        }
    }
}