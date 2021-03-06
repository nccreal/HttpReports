using System;
using System.Collections.Generic;
using System.Text;

namespace HttpReports.Collector.Grpc
{
    public partial class RequestDetail 
    {
        private DateTime? _createTime = null;

        public new DateTime CreateTime
        {
            get
            {
                if (_createTime == null)
                {
                    _createTime = new DateTime(CreateTimeStamp);
                }
                return _createTime.Value;
            }
            set
            {
                _createTime = value;
                CreateTimeStamp = value.Ticks;
            }
        }

    }
}
