using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OYTamn
{
    internal class SGKC
    {
        static internal class Exl2610
        {
            static internal string DtA(int s)//(1から始まるの)10進数から(Aから始まるの)26進数へ変換
            {
                if (s <= 0) return "NaN";
                StringBuilder sb = new StringBuilder();
                int r;
                int d = s;
                while (true)
                {
                    d = Math.DivRem(d, 26, out r);
                    r--;
                    if (r == -1) sb.Append('Z');
                    else
                    {
                        sb.Insert(0, (char)(65 + r));
                    }
                    if (d == 0) break;
                }
                return sb.ToString();
            }
            static internal int AtD(string s)//(1から始まるの)10進数から(Aから始まるの)26進数へ変換
            {
                int r = 0;
                int itemp = s.Length - 1;
                int o, itemp2;
                for (int cnt = 0; cnt < s.Length; cnt++)
                {
                    o = 1;
                    for (int cnt2 = 0; cnt2 < itemp - cnt; cnt2++)
                    {
                        o *= 26;
                    }
                    itemp2 = Convert.ToInt32(s[cnt]) - 64;
                    if (itemp2 < 1 || itemp2 > 26)
                    {
                        return -1;
                    }
                    r += o * itemp2;
                }
                return r;
            }
            static internal string DtA0(int s)//(0から始まるの)10進数から(Aから始まるの)26進数へ変換
            {
                if (s < 0) return "NaN";
                StringBuilder sb = new StringBuilder();
                int r;
                int d = Math.DivRem(s, 26, out r);
                sb.Insert(0, (char)(65 + r));
                if (d == 0) return sb.ToString();
                while (true)
                {
                    d = Math.DivRem(d, 26, out r);
                    sb.Insert(0, (char)(64 + r));
                    if (d == 0) break;
                }
                return sb.ToString();
            }
        }
    }
}
