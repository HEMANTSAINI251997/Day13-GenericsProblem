using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    public class Maximum<T> where T: IComparable 

    {
        public T data_one;
        public T data_two;
        public T data_three;
        public Maximum(T data_one, T data_two, T data_three)
        {
            this.data_one = data_one;
            this.data_two = data_two;
            this.data_three = data_three;
        }
         public static T Checkmax( T data_one ,T  data_two,T  data_three) 
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
        public T MaxMethod()
        {
            T result = Maximum<T>.Checkmax(this.data_one, this.data_two, this.data_three);
            return result;
        }
    }
}
