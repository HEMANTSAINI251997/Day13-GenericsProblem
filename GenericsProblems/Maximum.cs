﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    public class Maximum
    {
         public string Checkmax( string data_one ,string  data_two,string  data_three)
        {
            if (data_one.CompareTo(data_two)>=0 && data_one.CompareTo(data_three)>=0 )
            {
                return data_one;
            }
            if (data_two.CompareTo(data_one)>=0 && data_two.CompareTo(data_three)>=0)
            {
                return data_two;
            }
            if(data_three.CompareTo(data_one)>=0 && data_three.CompareTo(data_one)>=0)
            {
                return data_three;
            }
            return data_one;

        }
    }
}
