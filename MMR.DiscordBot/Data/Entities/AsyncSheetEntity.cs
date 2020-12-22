using System;
using ServiceStack.DataAnnotations;

namespace MMR.DiscordBot.Data.Entities
{
    [Alias("AsyncSheets")]
    public class AsyncSheetEntity
    {
        [PrimaryKey, AutoIncrement]
        public ulong Id { get; set; }

        public string SheetId { get; set; }

        public DateTime DateCreated { get; set; }

        public string FolderId { get; set; }
    }
}
