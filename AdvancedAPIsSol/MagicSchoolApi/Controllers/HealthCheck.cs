using MagicSchoolApi.Models;
using MagicSchoolApi.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Text.Json;

namespace MagicSchoolApi.HealthChecks
{
    public class ProductHealthCheck : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var jsonFilePath = @"Resources\teachers.json";
            var jsonData = await File.ReadAllTextAsync(jsonFilePath);
            var productsData = JsonSerializer.Deserialize<List<Teacher>>(jsonData);
            int products = productsData.Count();

            if (products > 0)
            {
                return HealthCheckResult.Healthy($"There are {products} products available.");
            }
            else
            {
                return HealthCheckResult.Unhealthy($"There are {products} products available.");
            }
        }
    }
}
