using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DDD1.Domain.Repositories
{
    public interface IWeatherRepository
    {
        DataTable GetLatest(int areaId);
    }
}
