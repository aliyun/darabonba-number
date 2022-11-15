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

        public static Int64 Itol(Int32 raw)
        {
            return Convert.ToInt64(raw);
        }

        public static Int32 Ltoi(Int64 raw)
        {
            return Convert.ToInt32(raw);
        }

        public static Int64 Add(Int64 raw1,Int64 raw2)
        {
            return raw1 + raw2;
        }

        public static Int64 Sub(Int64 raw1, Int64 raw2)
        {
            return raw1 - raw2;
        }

        public static Int64 Mul(Int64 raw1, Int64 raw2)
        {
            return raw1 * raw2;
        }

        public static Double Div(Int64 raw1, Int64 raw2)
        {
            return Convert.ToDouble(raw1 / raw2);
        }

        public static Boolean Gt(Int64 raw1, Int64 raw2)
        {
            return raw1 > raw2;
        }

        public static Boolean Gte(Int64 raw1, Int64 raw2)
        {
            return raw1 >= raw2;
        }

        public static Boolean Lt(Int64 raw1, Int64 raw2)
        {
            return raw1 < raw2;
        }


        public static Boolean Lte(Int64 raw1, Int64 raw2)
        {
            return raw1 <= raw2;
        }
    }
}
