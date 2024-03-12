using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302220101
{
    public class KodePos
    {
        String[] kecamatan = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };

        int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };

        public int GetKodePos(String kec)
        {
            for (int i = 0; i < kecamatan.Length; i++)
            {
                if (kecamatan[i] == kec)
                {
                    return kodePos[i];
                }
            }
            return 0;
        }
    }
}
