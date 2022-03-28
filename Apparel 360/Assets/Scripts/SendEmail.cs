using System;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class SendEmail : MonoBehaviour
{
    public Button submit;
    public GameObject model;
    public InputField senderEmail;
    public InputField password;
    public InputField receiver;
    
    private void Start()
    {
        submit.onClick.AddListener(delegate
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(senderEmail.text);
            mail.To.Add(receiver.text);
            mail.Subject = "Order on " + DateTime.Now;
            mail.Body = "button 1 + collar 2";
            SmtpClient server = new SmtpClient("smtp.gmail.com");
            server.Port = 587;
            server.Credentials = new NetworkCredential(senderEmail.text,password.text) as ICredentialsByHost;
            server.EnableSsl = true;
            server.Send( mail );
        });
    }

}
