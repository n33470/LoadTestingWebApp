using System;

namespace LoadTestWebApp.Domain.Models
{
    public interface IAuditable
    {
        DateTime UpdateDate {get;set;}
        string UpdatedBy { get; set; }
    }
}
