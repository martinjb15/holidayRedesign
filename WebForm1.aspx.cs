using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace holidayRedesign
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Set Mailbox send for each department
        public void Conferene()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("anjaf@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("Conference");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);

        }

        public void IS()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("ray@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.To.Add("tom@abbey.ie");
            message.Body = table("IS");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }

        public void HR()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("helen@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("HR");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }

        public void Accounts()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("edward@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.To.Add("Aisling@abbey.ie");
            message.To.Add("enda@abbey.ie");
            message.To.Add("Paolo@abbey.ie");
            message.Body = table("Accounts");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }

        public void International()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("sineadk@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.To.Add("yvonnef@abbey.ie");
            message.To.Add("colin@abbey.ie");
            message.Body = table("International");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }

        public void German()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("claudia@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.To.Add("lena@abbey.ie");
            message.Body = table("German");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }

        public void accmmodation()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("pauline@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("Accmmodation");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }

        public void operations()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("TheresaT@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("Operations");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }

        public void nordics()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("Ruta@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("Nordics");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }

        public void FrenchCaroline()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("Caroline@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("French");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }
        public void FrenchAurelie()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("AurelieG@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("French");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }
        public void FrenchCarene()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("carene@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("French");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }

        public void FrenchTeresa()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("teresa@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("French");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }


        public void contracting()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("paula@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.To.Add("mark@abbey.ie");
            message.Body = table("Contracting");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }

        public void Meds()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("ines@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("Meds");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }

        public void FIT()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("alma@abbey.ie");
            MailMessage message = new MailMessage(from, to);
            message.To.Add("dermot@abbey.ie");
            message.Body = table("FIT");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }

        public void moloney()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("michael@moloneykelly.com");
            MailMessage message = new MailMessage(from, to);
            message.To.Add("yasmine@abbey.ie");
            message.Body = table("Moloney & Kelly");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }

        public void Product()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("KarinG@abbeyuk.com");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("Product");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }

            public void OperationsDirector()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("Timd@abbeyuk.com");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("OperationsDirector");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }

        public void WMOF()
        {
            SmtpClient client = new SmtpClient("mailhost");
            MailAddress from = new MailAddress("staffholiday@abbey.ie");
            MailAddress to = new MailAddress("emmaw@abbeyuk.com");
            MailMessage message = new MailMessage(from, to);
            message.Body = table("WMOF");
            message.IsBodyHtml = true;
            message.Subject = "Staff Weekend request";
            client.Send(message);
        }
        // Build html table(for emails) linked with the data entered in c#
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
            if (DropDownList9.SelectedItem.Text == "Conference")
                Conferene();
            if (DropDownList9.SelectedItem.Text == "Info Systems")
                IS();
            if (DropDownList9.SelectedItem.Text == "HR")
                HR();
            if (DropDownList9.SelectedItem.Text == "Accounts")
                Accounts();
            if (DropDownList9.SelectedItem.Text == "International")
                International();
            if (DropDownList9.SelectedItem.Text == "German")
                German();
            if (DropDownList9.SelectedItem.Text == "Accommodation")
                accmmodation();
            if (DropDownList9.SelectedItem.Text == "Operations")
                operations();
            if (DropDownList9.SelectedItem.Text == "Nordics")
                nordics();
            if (DropDownList9.SelectedItem.Text == "French(Caroline)")
                FrenchCaroline();
            if (DropDownList9.SelectedItem.Text == "French(Aurelie)")
                FrenchAurelie();
            if (DropDownList9.SelectedItem.Text == "French(Carene)")
                FrenchCarene();
            if (DropDownList9.SelectedItem.Text == "Contracting")
                contracting();
            if (DropDownList9.SelectedItem.Text == "FIT")
                FIT();
            if (DropDownList9.SelectedItem.Text == "Meds")
                Meds();
            if (DropDownList9.SelectedItem.Text == "Moloney")
                moloney();
            if (DropDownList9.SelectedItem.Text == "French(Teresa)")
                FrenchTeresa();
            if (DropDownList9.SelectedItem.Text == "Operations Director")
                OperationsDirector();
            if (DropDownList9.SelectedItem.Text == "WMOF")
                WMOF();

            Server.Transfer("HtmlPage1.html");
            Server.Transfer("HTMLPage1.html");

        }
    }
}