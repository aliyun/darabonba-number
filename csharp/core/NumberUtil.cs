/**
 * This is a number module
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;


namespace AlibabaCloud.DarabonbaNumber
{
    public class NumberUtil 
    {

        public static int ParseInt(string raw)
        {
            return Convert.ToInt32(raw);
        }

        public static long ParseLong(string raw)
        {
            return Convert.ToInt64(raw);
        }

        public static float ParseFloat(string raw)
        {
            return Convert.ToSingle(raw);
        }

        public static double ParseDouble(string raw)
        {
            return Convert.ToDouble(raw);
        }

        public static long Itol(int? val)
        {
            return Convert.ToInt64(val);
        }

        public static int Ltoi(long? val)
        {
            return Convert.ToInt32(val);
        }

        public static long Add(long? val1, long? val2)
        {
            return (long)(val1 + val2);
        }

        public static long Sub(long? val1, long? val2)
        {
            return (long)(val1 - val2);
        }

        public static long Mul(long? val1, long? val2)
        {
            return (long)(val1 * val2);
        }

        public static double Div(long? val1, long? val2)
        {
            return Convert.ToDouble(val1 / val2);
        }

        public static bool Gt(long? val1, long? val2)
        {
            return val1 > val2;
        }

        public static bool Gte(long? val1, long? val2)
        {
            return val1 >= val2;
        }

        public static bool Lt(long? val1, long? val2)
        {
            return val1 < val2;
        }


        public static bool Lte(long? val1, long? val2)
        {
            return val1 <= val2;
        }
    }
}
