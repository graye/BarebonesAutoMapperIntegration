using System;
using AutoMapper;

namespace BarebonesAutoMapperIntegration.Service
{
    // Internal: mapper config should only be accessible by this project and it's associated test project
    internal sealed class MapperConfig
    {
        public static IConfigurationProvider Default => DefaultLazy.Value;
        
        // Thread safe lazy loading
        private static readonly Lazy<IConfigurationProvider> DefaultLazy = new Lazy<IConfigurationProvider>(() =>
            new MapperConfiguration(cfg =>
            {
                // Auto discover all mapping profiles
                cfg.AddProfiles(typeof(MapperConfig));
                
                // Add custom mappings here too
            }), true);
    }
}