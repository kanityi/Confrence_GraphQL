using System.Threading.Tasks;
using ConfrenceGraphQL.Data;
using ConfrenceGraphQL.Extensions;
using HotChocolate;
using HotChocolate.Types;

namespace ConfrenceGraphQL.Speakers
{
    [ExtendObjectType(Name = "Mutation")]
    public class SpeakerMutation
    {
        [UseApplicationDbContext]
        public async Task<AddSpeakerPayload> AddSpeakerAsync(AddSpeakerInput input, [ScopedService] ApplicationDbContext context)
        {
            var speaker = new Speaker
            {
                Name = input.Name,
                Bio = input.Bio,
                Website = input.Website
            };

            context.Speakers.Add(speaker);
            await context.SaveChangesAsync();

            return new AddSpeakerPayload(speaker);
        }

    }
}