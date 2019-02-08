namespace Microsoft.Extensions.DependencyInjection
{
    public static partial class ServiceCollectionHostedServiceExtensions
    {
        public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddHostedService<THostedService>(this Microsoft.Extensions.DependencyInjection.IServiceCollection services) where THostedService : class, Microsoft.Extensions.Hosting.IHostedService { throw null; }
    }
}
namespace Microsoft.Extensions.Hosting
{
    public abstract partial class BackgroundService : Microsoft.Extensions.Hosting.IHostedService, System.IDisposable
    {
        protected BackgroundService() { }
        public virtual void Dispose() { }
        protected abstract System.Threading.Tasks.Task ExecuteAsync(System.Threading.CancellationToken stoppingToken);
        public virtual System.Threading.Tasks.Task StartAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public virtual System.Threading.Tasks.Task StopAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    public static partial class EnvironmentName
    {
        public static readonly string Development;
        public static readonly string Production;
        public static readonly string Staging;
    }
    public partial class HostBuilderContext
    {
        public HostBuilderContext(System.Collections.Generic.IDictionary<object, object> properties) { }
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Microsoft.Extensions.Hosting.IHostingEnvironment HostingEnvironment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Generic.IDictionary<object, object> Properties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public static partial class HostDefaults
    {
        public static readonly string ApplicationKey;
        public static readonly string ContentRootKey;
        public static readonly string EnvironmentKey;
    }
    public static partial class HostingAbstractionsHostBuilderExtensions
    {
        public static Microsoft.Extensions.Hosting.IHost Start(this Microsoft.Extensions.Hosting.IHostBuilder hostBuilder) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static System.Threading.Tasks.Task<Microsoft.Extensions.Hosting.IHost> StartAsync(this Microsoft.Extensions.Hosting.IHostBuilder hostBuilder, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class HostingAbstractionsHostExtensions
    {
        public static void Run(this Microsoft.Extensions.Hosting.IHost host) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static System.Threading.Tasks.Task RunAsync(this Microsoft.Extensions.Hosting.IHost host, System.Threading.CancellationToken token = default(System.Threading.CancellationToken)) { throw null; }
        public static void Start(this Microsoft.Extensions.Hosting.IHost host) { }
        public static System.Threading.Tasks.Task StopAsync(this Microsoft.Extensions.Hosting.IHost host, System.TimeSpan timeout) { throw null; }
        public static void WaitForShutdown(this Microsoft.Extensions.Hosting.IHost host) { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public static System.Threading.Tasks.Task WaitForShutdownAsync(this Microsoft.Extensions.Hosting.IHost host, System.Threading.CancellationToken token = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class HostingEnvironmentExtensions
    {
        public static bool IsDevelopment(this Microsoft.Extensions.Hosting.IHostingEnvironment hostingEnvironment) { throw null; }
        public static bool IsEnvironment(this Microsoft.Extensions.Hosting.IHostingEnvironment hostingEnvironment, string environmentName) { throw null; }
        public static bool IsProduction(this Microsoft.Extensions.Hosting.IHostingEnvironment hostingEnvironment) { throw null; }
        public static bool IsStaging(this Microsoft.Extensions.Hosting.IHostingEnvironment hostingEnvironment) { throw null; }
    }
    public partial interface IApplicationLifetime
    {
        System.Threading.CancellationToken ApplicationStarted { get; }
        System.Threading.CancellationToken ApplicationStopped { get; }
        System.Threading.CancellationToken ApplicationStopping { get; }
        void StopApplication();
    }
    public partial interface IHost : System.IDisposable
    {
        System.IServiceProvider Services { get; }
        System.Threading.Tasks.Task StartAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        System.Threading.Tasks.Task StopAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
    public partial interface IHostBuilder
    {
        System.Collections.Generic.IDictionary<object, object> Properties { get; }
        Microsoft.Extensions.Hosting.IHost Build();
        Microsoft.Extensions.Hosting.IHostBuilder ConfigureAppConfiguration(System.Action<Microsoft.Extensions.Hosting.HostBuilderContext, Microsoft.Extensions.Configuration.IConfigurationBuilder> configureDelegate);
        Microsoft.Extensions.Hosting.IHostBuilder ConfigureContainer<TContainerBuilder>(System.Action<Microsoft.Extensions.Hosting.HostBuilderContext, TContainerBuilder> configureDelegate);
        Microsoft.Extensions.Hosting.IHostBuilder ConfigureHostConfiguration(System.Action<Microsoft.Extensions.Configuration.IConfigurationBuilder> configureDelegate);
        Microsoft.Extensions.Hosting.IHostBuilder ConfigureServices(System.Action<Microsoft.Extensions.Hosting.HostBuilderContext, Microsoft.Extensions.DependencyInjection.IServiceCollection> configureDelegate);
        Microsoft.Extensions.Hosting.IHostBuilder UseServiceProviderFactory<TContainerBuilder>(Microsoft.Extensions.DependencyInjection.IServiceProviderFactory<TContainerBuilder> factory);
        Microsoft.Extensions.Hosting.IHostBuilder UseServiceProviderFactory<TContainerBuilder>(System.Func<Microsoft.Extensions.Hosting.HostBuilderContext, Microsoft.Extensions.DependencyInjection.IServiceProviderFactory<TContainerBuilder>> factory);
    }
    public partial interface IHostedService
    {
        System.Threading.Tasks.Task StartAsync(System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task StopAsync(System.Threading.CancellationToken cancellationToken);
    }
    public partial interface IHostingEnvironment
    {
        string ApplicationName { get; set; }
        Microsoft.Extensions.FileProviders.IFileProvider ContentRootFileProvider { get; set; }
        string ContentRootPath { get; set; }
        string EnvironmentName { get; set; }
    }
    public partial interface IHostLifetime
    {
        System.Threading.Tasks.Task StopAsync(System.Threading.CancellationToken cancellationToken);
        System.Threading.Tasks.Task WaitForStartAsync(System.Threading.CancellationToken cancellationToken);
    }
}