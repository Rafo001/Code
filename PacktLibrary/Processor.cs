using System;
using System.Collections.Generic;
namespace Packt.Shared
{
    public class Processor
    {
        public TextAndNumber GetTheData()
        {
            return new TextAndNumber
            {
                Text = "What's the meaning of life?",
                Number = 42  
            };
        }
      
    }
}