using System;

using R5T.Herulia.Extensions;


namespace Microsoft.AspNetCore.Hosting
{
    public static class WebHostBuilderHelper
    {
        /// <summary>
        /// Default includes:
        /// * UseKestrel().
        /// * UseDefaultContentRoot() (current directory as the default content root).
        /// * UseIISIntegration().
        /// </summary>
        public static IWebHostBuilder GetDefaultWebHostBuilder()
        {
            var webHostBuilder = new WebHostBuilder()
                .UseKestrel()
                .UseDefaultContentRoot()
                .UseIISIntegration()
                ;

            return webHostBuilder;
        }
    }
}
