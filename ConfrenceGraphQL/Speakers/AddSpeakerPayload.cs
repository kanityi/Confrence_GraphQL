using System.Collections.Generic;
using ConfrenceGraphQL.Common;
using ConfrenceGraphQL.Data;

namespace ConfrenceGraphQL.Speakers
{
    public class AddSpeakerPayload : SpeakerPaloadBase
    {
        public AddSpeakerPayload(Speaker speaker) : base(speaker)
        {
        }

        public AddSpeakerPayload(IReadOnlyList<UseError>? errors = null) : base(errors)
        {
        }
    }
}