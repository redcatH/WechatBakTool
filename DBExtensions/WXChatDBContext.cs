using System.IO;
using Microsoft.EntityFrameworkCore;

namespace WechatBakTool.DBExtensions;

public class WXChatDBContext : DbContext
{
    public string DbPath { get; }
    
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Message> Messages { get; set; }
    
    public WXChatDBContext(string path)
    {
        DbPath = Path.Join(path, "wxChatDB.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source="+DbPath);
        base.OnConfiguring(optionsBuilder);
    }
}

public static class GetDb
{
    public static WXChatDBContext GetDbDbContext(string path)
    {
        var wxChatDbContext = new WXChatDBContext(path);
        wxChatDbContext.Database.EnsureCreatedAsync().ConfigureAwait(false).GetAwaiter().GetResult();
        return wxChatDbContext;
    }
}