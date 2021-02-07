using ConfrenceGraphQL.Data;
using ConfrenceGraphQL.DataLoader;
using ConfrenceGraphQL.Speakers;
using ConfrenceGraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConfrenceGraphQL
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddPooledDbContextFactory<ApplicationDbContext>(options => options.UseSqlite("Data Source=confrence.db"));
            services.AddGraphQLServer()
                    .AddQueryType(d => d.Name("Query"))
                        .AddTypeExtension<SpeakerQuery>()
                    .AddMutationType(d => d.Name("Mutation"))
                        .AddTypeExtension<SpeakerMutation>()
                    .AddType<SpeakerType>()
                    .EnableRelaySupport()
                    .AddDataLoader<SpeakerByIdDataLoader>()
                    .AddDataLoader<SessionByIdDataLoader>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}
