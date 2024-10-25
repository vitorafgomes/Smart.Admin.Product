namespace Smart.Admin.Products.Infrastructure.CrossCutting.Configuration;

public class ApplicationSettings
{
    public string ServiceName { get; set; }
    
    public string ServiceNamespace { get; set; }
    
    public string ServiceVersion { get; set; }
    
    public bool AutoGenerateServiceInstanceId { get; set; }
    
    public string ServiceInstanceId { get; set; }
}