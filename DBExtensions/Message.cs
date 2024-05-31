using System;
using System.ComponentModel.DataAnnotations;

namespace WechatBakTool.DBExtensions;

public class Message
{
    [Key] public Guid Id { get; set; }
    public Guid ContactId { get; set; }

    public int LocalId { get; set; }
    public int MsgSequence { get; set; }
    public int Type { get; set; }
    public int SubType { get; set; }
    public long CreateTime { get; set; }
    public bool IsSender { get; set; }
    public string MsgSvrID { get; set; } = "";
    public string StrTalker { get; set; } = "";
    public string StrContent { get; set; } = "";
    public string DisplayContent { get; set; } = "";
    public byte[]? CompressContent { get; set; }
    public byte[]? BytesExtra { get; set; }
    public string NickName { get; set; } = "";
    public string? ImageUrl { get; set; }

    public MsgType BusinessType { get; set; }
    public string? VideoUrl { get; set; }
    public string? EmojiUrl { get; set; }
    public string? FileUrl { get; set; }
    public string? XMLRefText { get; set; }
    public string? XMLMergeText { get; set; }
    public string? XMLText { get; set; }
    public string? AudioUrl { get; set; }

    public Message()
    {
    }
}