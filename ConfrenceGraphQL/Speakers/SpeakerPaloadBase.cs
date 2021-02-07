using System.Collections.Generic;
using ConfrenceGraphQL.Common;
using ConfrenceGraphQL.Data;

namespace ConfrenceGraphQL.Speakers
{
    public class SpeakerPaloadBase : Payload
    {
        protected SpeakerPaloadBase(Speaker speaker)
        {
            Speaker = speaker;
        }
        protected SpeakerPaloadBase(IReadOnlyList<UseError>? errors = null) : base(errors)
        {
        }

        public Speaker? Speaker { get; }
    }
}