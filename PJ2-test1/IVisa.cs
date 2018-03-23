using System;
using System.Data.SqlTypes;

namespace PJ2_test1
{
    public interface IVisa
    {
        new bool? Approved { get; }

        new string Name { get; set; }

        new double? Payment { get; set; }
    }
}