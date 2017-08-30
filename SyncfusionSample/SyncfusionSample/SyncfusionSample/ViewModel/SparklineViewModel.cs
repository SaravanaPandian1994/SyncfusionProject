using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionSample
{
    public class SparklineViewModel
    {
        public List<SparklineModel> Data { get; set; }

        public SparklineViewModel()
        {
            Data = new List<SparklineModel>()
            {
                new SparklineModel { Performance = 3000 },
                new SparklineModel { Performance = 5000 },
                new SparklineModel { Performance = -3000 },
                new SparklineModel { Performance = -4000 },
                new SparklineModel { Performance = 2000 },
                new SparklineModel { Performance = 3000 }
            };
        }
    }
}
