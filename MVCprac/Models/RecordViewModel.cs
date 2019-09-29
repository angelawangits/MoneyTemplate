using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCprac.Models
{
    public class RecordViewModel
    {
        public RecordViewModel( int numCount, string category, DateTime date, int amount )
        {
            NumCount = numCount;
            Category = category;
            Date = date;
            Amount = amount;
        }

        public string Category { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public int NumCount { get; set; }


        //public List<RecordViewModel> viewModelList()
        //{
        //    int amount = GetRandomAmount(10, 10000);
        //    var categoryType = GetRandomType();
        //    DateTime dateTime = GetRandomDate();

        //    List<RecordViewModel> randomList = new List<RecordViewModel>();
        //    for (var count = 1; count <= 50; count++)
        //    {
        //        randomList.Add(new RecordViewModel(count, GetRandomType(), GetRandomDate(), GetRandomAmount(10, 10000)));
        //    }

        //    return randomList;
        //}

        //public DateTime GetRandomDate()
        //{
        //    var random = new Random();
        //    var year = random.Next(2000, 2020);
        //    var month = random.Next(1, 13);
        //    var day = random.Next(1, DateTime.DaysInMonth(year, month) + 1);

        //    return new DateTime(year, month, day);
        //}

        //public string GetRandomType()
        //{
        //    var random = new Random();
        //    var type = new List<string>
        //    {
        //        "支出",
        //        "收入"
        //    };
        //    return type[random.Next(0, type.Count)];
        //}

        //public int GetRandomAmount(int min, int max)
        //{
        //    var random = new Random();
        //    var amount = random.Next(min, max + 1);
        //    return amount;
        //}
    }
}