using CleanArchitecture.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities
{
    public class Employee: BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
