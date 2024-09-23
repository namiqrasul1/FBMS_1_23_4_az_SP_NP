using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using System.Net;
using System.Net.Mail;

// ixqt lygx zlfr evqn

#region SMTP

using var client = new SmtpClient("smtp.gmail.com", 587);
client.DeliveryMethod = SmtpDeliveryMethod.Network;
client.EnableSsl = true;

client.UseDefaultCredentials = false;

client.Credentials = new NetworkCredential(
    userName: "n.resul11@gmail.com",
    password: "ixqt lygx zlfr evqn"
    );

var message = new MailMessage()
{
    Body = @"<h1 style='color:red'>Salam</h1>",
    Subject = "Just for fun",
    From = new MailAddress("n.resul11@gmail.com", "Babat Insan"),
    IsBodyHtml = true,
};

message.To.Add("namiq_rasullu@itstep.org");
message.CC.Add("mirtalibemirli498@gmail.com");

client.Send(message);


#endregion


#region IMAP

using var imap = new ImapClient();

imap.Connect("imap.gmail.com", 993);
imap.Authenticate("n.resul11@gmail.com", "ixqt lygx zlfr evqn");

var inbox = imap.GetFolder("Inbox");

inbox.Open(FolderAccess.ReadOnly);
var ids = inbox.Search(SearchQuery.All);

foreach (var id in ids)
{
    Console.WriteLine(inbox.GetMessage(id).Subject);
}


inbox.Open(FolderAccess.ReadWrite);
inbox.SetFlags([0, 1], MessageFlags.Deleted, true);
inbox.Expunge();




#endregion

