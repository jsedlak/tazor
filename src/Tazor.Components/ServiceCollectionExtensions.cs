using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tazor.Components;

public static class ServiceCollectionExtensions
{
    public static void AddTazor(this IServiceCollection services)
    {
        services.AddScoped<OnlineStatusInterop>();
    }
}

