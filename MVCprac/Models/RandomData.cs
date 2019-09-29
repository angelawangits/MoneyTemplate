using System;
using System.Collections.Generic;
namespace MVCprac.Models
{
    public class RandomData
    {
        private readonly Random _random = new Random();
        public List<RecordViewModel> viewModelList()
        {
            List<RecordViewModel> randomList = new List<RecordViewModel>();

            for (var count = 1; count <= 50; count++)
            {
                randomList.Add(new RecordViewModel(count, GetRandomType(), GetRandomDate(), GetRandomAmount(10, 10000)));
            }
            return randomList;
        }

        public DateTime GetRandomDate()
        {
            var year = _random.Next(2000, 2020);
            var month = _random.Next(1, 13);
            var day = _random.Next(1, DateTime.DaysInMonth(year, month) + 1);

            return new DateTime(year, month, day);
        }

        public string GetRandomType()
        {
            var type = new List<string>
            {
                "支出",
                "收入"
            };
            return type[_random.Next(0, type.Count)];
        }

        public int GetRandomAmount(int min, int max)
        {
            var amount = _random.Next(min, max + 1);
            return amount;
        }
    }
}