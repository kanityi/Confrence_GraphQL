using System.Collections.Generic;

namespace ConfrenceGraphQL.Common
{
    public abstract class Payload
    {
        protected Payload(IReadOnlyList<UseError>? errors = null)
        {
            Errors = errors;
        }

        public IReadOnlyList<UseError>? Errors { get; set; }
    }
}