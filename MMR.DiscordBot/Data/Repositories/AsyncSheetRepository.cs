using MMR.DiscordBot.Data.Entities;
using ServiceStack.OrmLite;
using System;
using System.Threading.Tasks;

namespace MMR.DiscordBot.Data.Repositories
{
    public class AsyncSheetRepository : BaseRepository<AsyncSheetEntity>
    {
        public AsyncSheetRepository(ConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public async Task<AsyncSheetEntity> GetLatest()
        {
            using (var db = ConnectionFactory.Open())
            {
                return await db.SingleAsync(db.From<AsyncSheetEntity>().OrderByDescending(s => s.DateCreated));
            }
        }
    }
}
