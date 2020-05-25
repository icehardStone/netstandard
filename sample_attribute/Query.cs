using System;
using sample_attribute;

namespace sample_attribute
{
    public class Query
    {
        [QueryAttribute(sql="select * from person")]
        public void QueryFromSql()
        {
            
        }
    }
}