﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Apartment.Common
{
    public static class IdentityGenerator
    {
        private static long IndexCoden;

        static IdentityGenerator()
        {

        }

        /// <summary>
        /// This algorithm generates secuential GUIDs across system boundaries, ideal for databases 
        /// </summary>
        /// <returns></returns>
        public static Guid NewSequentialGuid()
        {
            byte[] uid = Guid.NewGuid().ToByteArray();
            byte[] binDate = BitConverter.GetBytes(DateTime.UtcNow.Ticks);

            byte[] secuentialGuid = new byte[uid.Length];

            secuentialGuid[0] = uid[0];
            secuentialGuid[1] = uid[1];
            secuentialGuid[2] = uid[2];
            secuentialGuid[3] = uid[3];
            secuentialGuid[4] = uid[4];
            secuentialGuid[5] = uid[5];
            secuentialGuid[6] = uid[6];
            // set the first part of the 8th byte to '1100' so     
            // later we'll be able to validate it was generated by us   

            secuentialGuid[7] = (byte)(0xc0 | (0xf & uid[7]));

            // the last 8 bytes are sequential,    
            // it minimizes index fragmentation   
            // to a degree as long as there are not a large    
            // number of Secuential-Guids generated per millisecond  

            secuentialGuid[9] = binDate[0];
            secuentialGuid[8] = binDate[1];
            secuentialGuid[15] = binDate[2];
            secuentialGuid[14] = binDate[3];
            secuentialGuid[13] = binDate[4];
            secuentialGuid[12] = binDate[5];
            secuentialGuid[11] = binDate[6];
            secuentialGuid[10] = binDate[7];

            return new Guid(secuentialGuid);
        }
        public static string NewGuidString()
        {
            return NewSequentialGuid().ToString().Replace("-", "");
        }

        public static string GenarateNo(string fix)
        {
            return string.Format("{0}{1}{2}", fix, DateTime.Now.ToString("yyyyMMdd"), Utils.Number(6));
        }


        [MethodImpl(MethodImplOptions.Synchronized)]
        public static long NewSequentialDomainId()
        {
            Interlocked.Increment(ref IndexCoden);
            string guid2Int = IndexCoden.ToString().PadLeft(19, '0');
            var timecoden = 1 + DateTime.Now.ToString("yyyyMMddHHmmss").PadRight(17, '0');
            return Convert.ToInt64(timecoden) + Convert.ToInt64(guid2Int);
        }
    }
}
