using System.Reflection;
using ConfrenceGraphQL.Data;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;

namespace ConfrenceGraphQL.Extensions
{
    public class UseApplicationDbContextAttribute : ObjectFieldDescriptorAttribute
    {
        public override void OnConfigure(IDescriptorContext context, IObjectFieldDescriptor descriptor, MemberInfo member)
        {
            descriptor.UseDbContext<ApplicationDbContext>();
        }
    }
}