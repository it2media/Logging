# Logging
Extensions for ILogger in Microsoft.Extensions.Logging.Abstractions

## Usage

Simply add the namespace   
   
`using IT2media.Extensions.Logging.Abstractions;`  
   
and start logging:  
    
`_logger.LogError(ex);`   
   
`_logger.LogTrace("I was here");`  
   

## Sample

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using IT2media.Extensions.Logging.Abstractions;

namespace WpfApplication
{
    public class Class
    {
        private readonly ILogger _logger;

        public Class(ILogger logger)
        {
            _logger = logger;
        }

        public void Method()
        {
            int int1 = 0;
            object object1 = new object();

            try
            {
                //Do something
                int1 = 42;
                object1 = GetObject(int1);
            }
            catch (Exception ex)
            {
                //Simplify your Logging: (no need for EventIDs)
                _logger.LogError(ex);

                //Or log with params to the LogProvider of your choice
                _logger.LogError(ex, int1, object1);
            }
        }

        private object GetObject(int int1)
        {
            throw new NotImplementedException();
        }
    }
}
```