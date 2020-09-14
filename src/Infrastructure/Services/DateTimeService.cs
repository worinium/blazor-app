using blazor_app.Application.Common.Interfaces;
using System;

namespace blazor_app.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
