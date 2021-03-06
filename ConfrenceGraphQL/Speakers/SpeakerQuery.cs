using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ConfrenceGraphQL.Data;
using ConfrenceGraphQL.DataLoader;
using ConfrenceGraphQL.Extensions;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using Microsoft.EntityFrameworkCore;

namespace ConfrenceGraphQL.Speakers
{
    [ExtendObjectType(Name = "Query")]
    public class SpeakerQuery
    {
        [UseApplicationDbContext]
        public Task<List<Speaker>> GetSpeakers([ScopedService] ApplicationDbContext context) =>
             context.Speakers.ToListAsync();

        public Task<Speaker> GetSpeakerAsync(
            [ID(nameof(Speaker))] int id,
            SpeakerByIdDataLoader dataLoader,
            CancellationToken cancellationToken) =>
            dataLoader.LoadAsync(id, cancellationToken);
    }
}