using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net.Mail;
using System.IO;
using System.Net;
using System.Net.Mime;

namespace SendEmail
{
    public partial class FormSendEmail : Form
    {
public FormSendEmail()
{
    InitializeComponent();
}

private void bSend_Click(object sender, EventArgs e)
{
    MailMessage email = new MailMessage();
    //必须是提供smtp服务的邮件服务器
    //添加发件人电子邮件地址和发件人名称
    email.From = new MailAddress("test@sina.com", tBSubject.Text);
    email.To.Add(new MailAddress(tBAddressee.Text));    //添加接收人地址
    email.Subject = tBSubject.Text;                     //设置电子邮件主题
    email.CC.Add(new MailAddress(tBAddressee.Text));    //添加抄送收件人地址
    email.Bcc.Add(new MailAddress(tBAddressee.Text));   //添加密件抄送收件人地址
    email.IsBodyHtml = true;                            //设置电子邮件正文是否为html格式
    email.BodyEncoding = System.Text.Encoding.UTF8;     //设置电子邮件正文编码格式
    email.Body = rTBBody.Text;                          //设置电子邮件正文
    email.Priority = System.Net.Mail.MailPriority.High; //设置电子邮件优先级
    SmtpClient client = new SmtpClient("smtp.sina.com");//实例化SMTP客户端
    //发件人身份凭证，即发件人的电子邮箱名和密码
    client.Credentials = new NetworkCredential("test@sina.com", "123456");
    client.EnableSsl = true;                            //设置电子邮件是否启用SSL加密连接 
    Attachment attachment;                                    //声明附件变量
    foreach (string attachmentFile in lBAttachment.Items)
    {
        attachment = new Attachment(attachmentFile);    //实例化附件  
        attachment.ContentType.Name = "image/jpg";      //配置附件类型
        attachment.ContentId = "test";                  //设置附件ID,邮件正文会用到
        attachment.ContentDisposition.Inline = true;    //设置是否内联
        attachment.TransferEncoding = TransferEncoding.Base64;//设置附件编码格式
        email.Attachments.Add(attachment);              //向电子邮件中添加附件
    }
    try
    {
        client.Send(email);                             //发送邮件
        MessageBox.Show("邮件已经成功发送到" + email.To.ToString());
    }
    catch (Exception Ex)
    {
        MessageBox.Show(Ex.Message);
    }
}

private void bAdd_Click(object sender, EventArgs e)
{
    oFDAttachment.ShowDialog();                         //打开添加文件对话框
}

private void oFDAttachment_FileOk(object sender, CancelEventArgs e)
{
    lBAttachment.Items.Add(oFDAttachment.FileName);     //添加附件
}


    }
}
