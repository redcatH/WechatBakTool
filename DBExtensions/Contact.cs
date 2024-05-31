using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WechatBakTool.DBExtensions;

public class Contact
{
    [Key]
    public Guid Id { get; set; }
    public bool IsChatRoom => UserName.Contains("@chatroom");
    public string UserName { get; set; } = "";
    public string Alias { get; set; } = "";
    public string NickName { get; set; } = "";
    public string LastMsg { get; set; } = "";
    public string Remark { get; set; } = "";

    public virtual List<Message> Messages { get; set; }

    public Contact()
    {
        
    }
}