using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS03
{
    class Catalog
    {
        private string _topicDept;
        public string TopicDept
        {
            get { return _topicDept; }
            set { _topicDept = value; }
        }
        Catalog()
        {
            TopicDept = "VOID";
        }
        Catalog( string TopicDept)
        {
            TopicDept = _topicDept;
        }
    }
}
