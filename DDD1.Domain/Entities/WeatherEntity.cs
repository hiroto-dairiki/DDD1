﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DDD1.Domain.Entities
{
    public sealed class WeatherEntity
    {
        // 完全コンストラクタパターン
        public WeatherEntity(int areaId,
                             DateTime dataDate,
                             int condition,
                             float temperature
                             )
        {
            AreaId = areaId;
            DataDate = dataDate;
            Condition = condition;
            Temperature = temperature;

        }


        public int AreaId { get; }
        public DateTime DataDate { get; }
        public int Condition { get; }
        public float Temperature { get; }

        public bool IsOK()
        {
            if (DataDate < DateTime.Now.AddMonths(-1))
            {
                if (Temperature < 10)
                {
                    return false;
                }
            }

            return false;
        }
    }
}
