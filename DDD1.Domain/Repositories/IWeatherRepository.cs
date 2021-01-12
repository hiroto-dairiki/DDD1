using DDD1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DDD1.Domain.Repositories
{
    public interface IWeatherRepository
    {
        WeatherEntity GetLatest(int areaId);
    }
}
