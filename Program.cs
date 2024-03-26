using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace OYTamn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo("ja-JP");
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ja-JP");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
            Stopwatch sw = new Stopwatch();
            sw.Start();



            //模型.MBAc1D();
            //模型.MBAc2D_88();
            //模型.MBAc2D_68();
            //模型.MBAc2D_87();
            //模型.MBAc2D_5();
            //模型.MBAc2D_89();
            //模型.MBAc2D_40();
            //模型.MBAc2D_0();
            //模型.MBAc2D_39();
            //模型.MBAc2D_63();
            //模型.MBAc2D_40_4();
            //模型.MBAc2D_133();
            //模型.MBAc2D_88_4();
            //模型.MBAc2D_70();
            //模型.MBAc2D_118();
            //模型.MBAc2D_117();
            //模型.MBAc2D_137();
            //模型.MBAc2D_120();
            //模型.MBAc2D_31();
            //模型.MBAc2D_132();
            //模型.MBAc2D_30();
            //模型.MBAc2D_14();
            //模型.MBAc2D_144();
            //模型.MBAc2D_100();
            //模型.MBAc2D_73();
            //模型.MBAc2D_58();
            //模型.MBAc2D_61();
            //模型.MBAc2D_17();
            //模型.MBAc2D_134();
            //模型.MBAc2D_52();
            //模型.MBAc2D_114();
            //模型.MBAc2D_39_8();
            //模型.MBAc2D_23();
            //模型.MBAc2D_100_8();
            //模型.MBAc2D_125();
            //模型.MBAc2D_139();
            //模型.MBAc2D_98();
            //模型.MBAc2D_33();
            //模型.MBAc2D_11();
            //模型.MBAc3D_5_14();
            //模型.MBAc3D_5_61();
            //模型.MBAc3D_14_68();
            //模型.MBAc3D_17_68();
            //模型.MBAc3D_23_100();
            //模型.MBAc3D_23_89();
            //模型.MBAc3D_23_87();
            //模型.MBAc3D_23_66();
            //模型.MBAc3D_23_88();
            //模型.MBAc3D_23_111();
            //模型.MBAc3D_30_137();
            //模型.MBAc3D_30_70();
            //模型.MBAc3D_30_134();
            //模型.MBAc3D_30_71();
            //模型.MBAc3D_30_138();
            //模型.MBAc3D_30_139();
            //模型.MBAc3D_31_50();
            //模型.MBAc3D_31_39();
            //模型.MBAc3D_31_144();
            //模型.MBAc3D_31_134();
            //模型.MBAc3D_31_137();
            //模型.MBAc3D_31_138();
            //模型.MBAc3D_31_139();
            //模型.MBAc3D_31_73();
            //模型.MBAc3D_31_72();
            //模型.MBAc3D_33_39();
            //模型.MBAc3D_33_134();
            //模型.MBAc3D_33_144();
            //模型.MBAc3D_33_137();
            //模型.MBAc3D_23_33();
            //模型.MBAc3D_25_33();
            //模型.MBAc3D_33_120();
            //模型.MBAc3D_39_64();
            //模型.MBAc3D_39_58();
            //模型.MBAc3D_29_39();
            //模型.MBAc3D_39_134();
            //模型.MBAc3D_39_88();
            //模型.MBAc3D_31_86();
            //模型.MBAc3D_30_88();
            //模型.MBAc3D_5_30();
            //模型.MBAc3D_5_17();
            //模型.MBAc3D_39_87();
            //模型.MBAc3D_39_89();
            //模型.MBAc3D_40_144();
            //模型.MBAc3D_40_68();
            //模型.MBAc3D_40_100();
            //模型.MBAc3D_23_40();
            //模型.MBAc3D_18_40();
            //模型.MBAc3D_5_40();
            //模型.MBAc3D_21_40();
            //模型.MBAc3D_40_58();
            //模型.MBAc3D_40_88();
            //模型.MBAc3D_52_63();
            //模型.MBAc3D_49_58();
            //模型.MBAc3D_61_68();
            //模型.MBAc3D_37_63();
            //模型.MBAc3D_63_87();
            //模型.MBAc3D_43_68();
            //模型.MBAc3D_70_114();
            //模型.MBAc3D_31_70();
            //模型.MBAc3D_73_132();
            //模型.MBAc3D_73_87();
            //模型.MBAc3D_6_88();
            //模型.MBAc3D_88_114();
            //模型.MBAc3D_88_92();
            //模型.MBAc3D_89_114();
            //模型.MBAc3D_89_123();
            //模型.MBAc3D_89_124();
            //模型.MBAc3D_11_98();
            //模型.MBAc3D_10_98();
            //模型.MBAc3D_119_100();
            //模型.MBAc3D_120_100();
            //模型.MBAc3D_144_100();
            //模型.MBAc3D_63_100();
            //模型.MBAc3D_100_134();
            //模型.MBAc3D_100_137();
            //模型.MBAc3D_26_100();
            //模型.MBAc3D_100_123();
            //模型.MBAc3D_100_125();
            //模型.MBAc3D_71_114();
            //模型.MBAc3D_68_114();
            //模型.MBAc3D_87_114();
            //模型.MBAc3D_33_117();
            //模型.MBAc3D_33_118();
            //模型.MBAc3D_100_120();
            //模型.MBAc3D_38_125();
            //模型.MBAc3D_37_125();
            //模型.MBAc3D_99_125();
            //模型.MBAc3D_104_125();
            //模型.MBAc3D_61_125();
            //模型.MBAc3D_30_132();
            //模型.MBAc3D_31_132();
            //模型.MBAc3D_30_133();
            //模型.MBAc3D_31_133();
            //模型.MBAc3D_73_133();
            //模型.MBAc3D_91_134();
            //模型.MBAc3D_74_137();
            //模型.MBAc3D_39_137();
            //模型.MBAc3D_120_139();
            //模型.MBAc3D_29_144();
            //模型.MBAc3D_74_144();
            //模型.MBAc3D_100_144();
            //模型.MBAc3D_30_144();
            //模型.MBAc3D_63_64();
            //模型.MBAc4D_5_14_30();
            //模型.MBAc4D_5_14_57();
            //模型.MBAc4D_5_14_69();
            //模型.MBAc4D_5_14_30();
            //模型.MBAc4D_5_17_73();
            //模型.MBAc4D_5_20_40();
            //模型.MBAc4D_5_24_61();
            //模型.MBAc4D_10_98_98();
            //模型.MBAc4D_10_98_114();
            //模型.MBAc4D_10_50_98();
            //模型.MBAc4D_11_52_98();
            //模型.MBAc4D_11_28_98();
            //模型.MBAc4D_14_57_68();
            //模型.MBAc4D_14_46_68();
            //模型.MBAc4D_14_60_68();
            //模型.MBAc4D_17_68_73();
            //模型.MBAc4D_23_33_49();
            //模型.MBAc4D_12_23_40();
            //模型.MBAc4D_23_40_68();
            //模型.MBAc4D_23_40_65();
            //模型.MBAc4D_23_40_41();
            //模型.MBAc4D_14_23_66();
            //模型.MBAc4D_14_23_87();
            //模型.MBAc4D_14_23_88();
            //模型.MBAc4D_15_23_88();
            //模型.MBAc4D_14_23_89();
            //模型.MBAc4D_23_39_89();
            //模型.MBAc4D_15_23_89();
            //模型.MBAc4D_23_39_100();
            //模型.MBAc4D_14_23_100();
            //模型.MBAc4D_23_63_100();
            //模型.MBAc4D_23_39_111();
            //模型.MBAc4D_26_100_120();
            //模型.MBAc4D_29_39_86();
            //模型.MBAc4D_29_39_74();
            //模型.MBAc4D_26_29_144();
            //模型.MBAc4D_30_70_114();
            //模型.MBAc4D_30_70_44();
            //模型.MBAc4D_30_44_71();
            //模型.MBAc4D_14_30_132();
            //模型.MBAc4D_18_30_132();
            //模型.MBAc4D_30_132_138();
            //模型.MBAc4D_14_30_133();
            //模型.MBAc4D_18_30_134();
            //模型.MBAc4D_30_43_137();
            //模型.MBAc4D_18_30_138();
            //模型.MBAc4D_18_30_139();
            //模型.MBAc4D_14_30_139();
            //模型.MBAc4D_18_30_144();
            //模型.MBAc4D_30_60_144();
            //模型.MBAc4D_30_43_144();
            //模型.MBAc4D_31_39_86();
            //模型.MBAc4D_5_31_50();
            //模型.MBAc4D_3_31_50();
            //模型.MBAc4D_31_70_114();
            //模型.MBAc4D_31_39_72();
            //模型.MBAc4D_31_32_72();
            //模型.MBAc4D_31_49_73();
            //模型.MBAc4D_31_74_86();
            //模型.MBAc4D_4_31_132();
            //模型.MBAc4D_17_31_132();
            //模型.MBAc4D_4_31_133();
            //模型.MBAc4D_14_31_133();
            //模型.MBAc4D_4_31_138();
            //模型.MBAc4D_31_50_138();
            //模型.MBAc4D_4_31_139();
            //模型.MBAc4D_31_50_139();
            //模型.MBAc4D_31_39h_134();
            //模型.MBAc4D_20_31_134();
            //模型.MBAc4D_31_39_137();
            //模型.MBAc4D_20_31_137();
            //模型.MBAc4D_20_31_144();
            //模型.MBAc4D_4_31_144();
            //模型.MBAc4D_33_39_49();
            //模型.MBAc4D_20_33_39();
            //模型.MBAc4D_33_112_117();
            //模型.MBAc4D_33_112_118();
            //模型.MBAc4D_33_112_120();
            //模型.MBAc4D_9_33_134();
            //模型.MBAc4D_20_33_134();
            //模型.MBAc4D_31_38_125();
            //模型.MBAc4D_39_58_73();
            //模型.MBAc4D_32_39_58();
            //模型.MBAc4D_39_58_72();
            //模型.MBAc4D_39_58_84();
            //模型.MBAc4D_39_58_99();
            //模型.MBAc4D_30_39_58();
            //模型.MBAc4D_39_64_76();
            //模型.MBAc4D_24_39_64();
            //模型.MBAc4D_39_49_64();
            //模型.MBAc4D_31_39_88();
            //模型.MBAc4D_31_39d_134();
            //模型.MBAc4D_31_39_87();
            //模型.MBAc4D_23_39_87();
            //模型.MBAc4D_8_39_87();
            //模型.MBAc4D_39_92_137();
            //模型.MBAc4D_40_45_88();
            //模型.MBAc4D_18_40_88();
            //模型.MBAc4D_40_111_144();
            //模型.MBAc4D_2_43_68();
            //模型.MBAc4D_49_58_73();
            //模型.MBAc4D_49_58_139();
            //模型.MBAc4D_49_49_58();
            //模型.MBAc4D_6_61_68();
            //模型.MBAc4D_63_73_100();
            //模型.MBAc4D_10_68_114();
            //模型.MBAc4D_29_70_114();
            //模型.MBAc4D_70_114_139();
            //模型.MBAc4D_30_71_114();
            //模型.MBAc4D_49_73_87();
            //模型.MBAc4D_49_87_114();
            //模型.MBAc4D_23_87_114();
            //模型.MBAc4D_49_88_114();
            //模型.MBAc4D_31_88_114();
            //模型.MBAc4D_49_89_114();
            //模型.MBAc4D_23_88_114();
            //模型.MBAc4D_89_91_123();
            //模型.MBAc4D_14_99_125();
            //模型.MBAc4D_11_99_125();
            //模型.MBAc4D_49_100_120();
            //模型.MBAc4D_73_100_123();
            //模型.MBAc4D_73_100_125();
            //模型.MBAc4D_100_114_144();
            //模型.MBAc4D_100_119_144();
            //模型.MBAc4D_26_100_119();
            //模型.MBAc4D_49_120_139();
            //模型.MBAc4D_23_89_91();
            //模型.MBAc4D_31_39_61();
            //模型.MBAc4D_31_50_86();
            //模型.MBAcV3D(new int[3] { 4, 8, 4 }, new int[3] { 5, 14, 30 });
            //模型.MBAcV3D(new int[3] { 4, 8, 8 }, new int[3] { 10, 24, 98 });
            //模型.MBAcV3D(new int[3] { 4, 4, 8 }, new int[3] { 10, 50, 98 });
            //模型.MBAcV3D(new int[3] { 4, 8, 9 }, new int[3] { 10, 98, 98 });
            //模型.MBAcV3D(new int[3] { 4, 4, 8 }, new int[3] { 11, 52, 98 });
            //模型.MBAcV3D(new int[3] { 4, 4, 8 }, new int[3] { 11, 48, 98 });
            //模型.MBAcV3D(new int[3] { 4, 9, 8 }, new int[3] { 14, 68, 85 });
            //模型.MBAcV3D(new int[3] { 4, 4, 8 }, new int[3] { 23, 33, 49 });
            //模型.MBAcV3D(new int[3] { 4, 4, 8 }, new int[3] { 23, 40, 41 });
            //模型.MBAcV3D(new int[3] { 8, 4, 9 }, new int[3] { 14, 23, 66 });
            //模型.MBAcV3D(new int[3] { 4, 8, 9 }, new int[3] { 23, 49, 66 });
            //模型.MBAcV3D(new int[3] { 8, 4, 9 }, new int[3] { 14, 23, 87 });
            //模型.MBAcV3D(new int[3] { 8, 4, 9 }, new int[3] { 14, 23, 88 });
            //模型.MBAcV3D(new int[3] { 8, 4, 9 }, new int[3] { 14, 23, 89 });
            //模型.MBAcV3D(new int[3] { 4, 8, 9 }, new int[3] { 23, 49, 89 });
            //模型.MBAcV3D(new int[3] { 8, 4, 9 }, new int[3] { 15, 23, 100 });
            //模型.MBAcV3D(new int[3] { 4, 8, 4 }, new int[3] { 30, 44, 71 });
            //模型.MBAcV3D(new int[3] { 4, 8, 4 }, new int[3] { 30, 44, 51 });
            //模型.MBAcV3D(new int[3] { 4, 8, 4 }, new int[3] { 30, 66, 132 });
            //模型.MBAcV3D(new int[3] { 4, 4, 8 }, new int[3] { 30, 132, 138 });
            //模型.MBAcV3D(new int[3] { 4, 4, 4 }, new int[3] { 31, 50, 65 });
            //模型.MBAcV3D(new int[3] { 4, 4, 4 }, new int[3] { 3, 31, 50 });
            //模型.MBAcV3D(new int[3] { 4, 8, 9 }, new int[3] { 31, 49, 72 });
            //模型.MBAcV3D(new int[3] { 4, 8, 9 }, new int[3] { 31, 49, 73 });
            //模型.MBAcV3D(new int[3] { 8, 4, 9 }, new int[3] { 12, 31, 86 });
            //模型.MBAcV3D(new int[3] { 4, 3, 4 }, new int[3] { 33, 49, 118 });
            //模型.MBAcV3D(new int[3] { 4, 8, 8 }, new int[3] { 37, 43, 125 });
            //模型.MBAcV3D(new int[3] { 4, 4, 8 }, new int[3] { 27, 38, 125 });
            //模型.MBAcV3D(new int[3] { 4, 3, 4 }, new int[3] { 39, 49, 58 });
            //模型.MBAcV3D(new int[3] { 8, 4, 9 }, new int[3] { 49, 58, 73 });
            //模型.MBAcV3D(new int[3] { 8, 4, 9 }, new int[3] { 49, 58, 72 });
            //模型.MBAcV3D(new int[3] { 8, 4, 4 }, new int[3] { 49, 58, 139 });
            //模型.MBAcV3D(new int[3] { 8, 4, 4 }, new int[3] { 49, 58, 138 });
            //模型.MBAcV3D(new int[3] { 8, 4, 9 }, new int[3] { 49, 58, 64 });
            //模型.MBAcV3D(new int[3] { 4, 4, 9 }, new int[3] { 6, 61, 68 });
            //模型.MBAcV3D(new int[3] { 4, 9, 4 }, new int[3] { 61, 68, 84 });
            //模型.MBAcV3D(new int[3] { 8, 9, 8 }, new int[3] { 17, 61, 125 });
            //模型.MBAcV3D(new int[3] { 8, 4, 9 }, new int[3] { 49, 63, 64 });
            //模型.MBAcV3D(new int[3] { 8, 9, 8 }, new int[3] { 14, 68, 114 });
            //模型.MBAcV3D(new int[3] { 8, 8, 9 }, new int[3] { 49, 73, 87 });
            //模型.MBAcV3D(new int[3] { 8, 9, 8 }, new int[3] { 49, 87, 114 });
            //模型.MBAcV3D(new int[3] { 8, 9, 8 }, new int[3] { 49, 88, 114 });
            //模型.MBAcV3D(new int[3] { 8, 4, 8 }, new int[3] { 14, 99, 125 });
            //模型.MBAcV3D(new int[3] { 8, 4, 8 }, new int[3] { 17, 99, 125 });
            //模型.MBAcV3D(new int[3] { 8, 4, 8 }, new int[3] { 49, 120, 139 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 3, 5, 31, 50 });
            //模型.MBAcV4D(new int[4] { 4, 9, 4, 4 }, new int[4] { 3, 5, 31, 50 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 9 }, new int[4] { 3, 31, 50, 63 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 9 }, new int[4] { 3, 31, 50, 65 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 3, 31, 50, 124 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 3, 31, 50, 125 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 4 }, new int[4] { 3, 31, 41, 50 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 0, 3, 31, 50 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 9 }, new int[4] { 3, 31, 50, 104 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 4 }, new int[4] { 4, 20, 31, 144 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 4, 30, 31, 132 });
            //模型.MBAcV4D(new int[4] { 9, 4, 8, 4 }, new int[4] { 4, 31, 49, 132 });
            //模型.MBAcV4D(new int[4] { 9, 4, 8, 4 }, new int[4] { 4, 31, 49, 138 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 8 }, new int[4] { 4, 31, 132, 138 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 4, 31, 32, 132 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 4 }, new int[4] { 4, 14, 31, 139 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 4, 30, 31, 139 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 9 }, new int[4] { 5, 31, 50, 112 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 9 }, new int[4] { 5, 31, 50, 114 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 5, 31, 50, 52 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 4 }, new int[4] { 5, 31, 38, 50 });
            //模型.MBAcV4D(new int[4] { 4, 9, 4, 4 }, new int[4] { 5, 24, 31, 50 });
            //模型.MBAcV4D(new int[4] { 4, 9, 4, 4 }, new int[4] { 5, 9, 31, 50 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 9 }, new int[4] { 5, 31, 50, 111 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 4 }, new int[4] { 5, 31, 43, 50 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 5, 31, 50, 109 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 5, 31, 33, 50 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 4 }, new int[4] { 5, 31, 50, 54 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 8 }, new int[4] { 5, 14, 30, 49 });
            //模型.MBAcV4D(new int[4] { 9, 4, 8, 4 }, new int[4] { 5, 14, 14, 30 });
            //模型.MBAcV4D(new int[4] { 9, 4, 8, 4 }, new int[4] { 5, 14, 18, 30 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 3 }, new int[4] { 5, 14, 30, 122 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 5, 14, 30, 36 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 5, 14, 57, 144 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 5, 14, 57, 141 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 5, 14, 57, 140 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 5, 14, 25, 57 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 5, 14, 27, 57 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 5, 14, 57, 139 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 5, 14, 57, 134 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 5, 14, 57, 137 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 5, 14, 57, 138 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 5, 9, 14, 57 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 5, 14, 23, 57 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 5, 14, 57, 58 });
            //模型.MBAcV4D(new int[4] { 9, 4, 8, 4 }, new int[4] { 5, 14, 17, 57 });
            //模型.MBAcV4D(new int[4] { 9, 4, 3, 4 }, new int[4] { 5, 14, 51, 57 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 4 }, new int[4] { 5, 14, 23, 30 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 8 }, new int[4] { 5, 14, 30, 51 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 9 }, new int[4] { 5, 14, 30, 113 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 8 }, new int[4] { 5, 14, 30, 111 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 3 }, new int[4] { 5, 14, 30, 122 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 9 }, new int[4] { 5, 14, 30, 128 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 4 }, new int[4] { 5, 14, 30, 126 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 4 }, new int[4] { 5, 14, 30, 49 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 4 }, new int[4] { 5, 14, 30, 70 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 8 }, new int[4] { 5, 14, 30, 72 });
            //模型.MBAcV4D(new int[4] { 9, 8, 9, 4 }, new int[4] { 5, 14, 29, 30 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 4 }, new int[4] { 5, 14, 24, 30 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 4 }, new int[4] { 5, 14, 25, 30 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 4 }, new int[4] { 5, 14, 30, 60 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 4 }, new int[4] { 5, 14, 15, 30 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 9 }, new int[4] { 5, 14, 30, 45 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 9 }, new int[4] { 5, 14, 30, 46 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 9 }, new int[4] { 5, 14, 30, 47 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 4 }, new int[4] { 5, 14, 30, 55 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 5, 17, 60, 73 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 5, 17, 66, 73 });
            //模型.MBAcV4D(new int[4] { 9, 4, 8, 4 }, new int[4] { 5, 17, 17, 73 });
            //模型.MBAcV4D(new int[4] { 9, 8, 9, 4 }, new int[4] { 5, 14, 24, 61 });
            //模型.MBAcV4D(new int[4] { 9, 8, 9, 4 }, new int[4] { 5, 15, 24, 61 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 8 }, new int[4] { 6, 61, 68, 134 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 8 }, new int[4] { 6, 61, 68, 144 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 9 }, new int[4] { 6, 61, 62, 68 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 4 }, new int[4] { 6, 61, 68, 91 });
            //模型.MBAcV4D(new int[4] { 4, 4, 3, 9 }, new int[4] { 6, 61, 62, 68 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 9 }, new int[4] { 6, 61, 62, 68 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 4 }, new int[4] { 6, 61, 68, 110 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 3 }, new int[4] { 6, 61, 68, 80 });
            //模型.MBAcV4D(new int[4] { 4, 4, 3, 9 }, new int[4] { 6, 61, 67, 68 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 4 }, new int[4] { 6, 61, 68, 98 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 4 }, new int[4] { 6, 61, 68, 100 });
            //模型.MBAcV4D(new int[4] { 4, 3, 9, 8 }, new int[4] { 10, 45, 50, 98 });
            //模型.MBAcV4D(new int[4] { 4, 9, 8, 3 }, new int[4] { 10, 50, 98, 111 });
            //模型.MBAcV4D(new int[4] { 4, 9, 8, 9 }, new int[4] { 10, 50, 98, 113 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 8 }, new int[4] { 10, 43, 50, 98 });
            //模型.MBAcV4D(new int[4] { 4, 9, 9, 8 }, new int[4] { 10, 16, 50, 98 });
            //模型.MBAcV4D(new int[4] { 4, 9, 9, 8 }, new int[4] { 10, 13, 50, 98 });
            //模型.MBAcV4D(new int[4] { 4, 9, 8, 9 }, new int[4] { 10, 50, 98, 98 });
            //模型.MBAcV4D(new int[4] { 4, 3, 9, 8 }, new int[4] { 10, 41, 50, 98 });
            //模型.MBAcV4D(new int[4] { 4, 9, 3, 8 }, new int[4] { 10, 50, 56, 98 });
            //模型.MBAcV4D(new int[4] { 4, 9, 9, 8 }, new int[4] { 10, 50, 56, 98 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 8 }, new int[4] { 10, 41, 50, 98 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 8 }, new int[4] { 6, 10, 50, 98 });
            //模型.MBAcV4D(new int[4] { 4, 9, 4, 8 }, new int[4] { 10, 50, 53, 98 });
            //模型.MBAcV4D(new int[4] { 4, 8, 9, 8 }, new int[4] { 10, 43, 68, 114 });
            //模型.MBAcV4D(new int[4] { 4, 8, 9, 8 }, new int[4] { 10, 98, 98, 114 });
            //模型.MBAcV4D(new int[4] { 4, 8, 8, 9 }, new int[4] { 10, 30, 98, 98 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 9 }, new int[4] { 10, 32, 98, 98 });
            //模型.MBAcV4D(new int[4] { 4, 3, 8, 8 }, new int[4] { 10, 17, 98, 114 });
            //模型.MBAcV4D(new int[4] { 4, 9, 8, 8 }, new int[4] { 10, 18, 98, 114 });
            //模型.MBAcV4D(new int[4] { 4, 9, 8, 8 }, new int[4] { 10, 15, 98, 114 });
            //模型.MBAcV4D(new int[4] { 4, 9, 8, 8 }, new int[4] { 10, 60, 98, 114 });
            //模型.MBAcV4D(new int[4] { 4, 9, 8, 8 }, new int[4] { 10, 45, 98, 114 });
            //模型.MBAcV4D(new int[4] { 4, 9, 8, 8 }, new int[4] { 10, 47, 98, 114 });
            //模型.MBAcV4D(new int[4] { 4, 3, 8, 8 }, new int[4] { 10, 52, 98, 114 });
            //模型.MBAcV4D(new int[4] { 4, 3, 8, 8 }, new int[4] { 10, 35, 98, 114 });
            //模型.MBAcV4D(new int[4] { 4, 8, 9, 8 }, new int[4] { 10, 98, 111, 114 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 4 }, new int[4] { 11, 28, 87, 98 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 8 }, new int[4] { 11, 28, 51, 98 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 8 }, new int[4] { 11, 28, 88, 98 });
            //模型.MBAcV4D(new int[4] { 4, 9, 8, 8 }, new int[4] { 11, 52, 98, 144 });
            //模型.MBAcV4D(new int[4] { 4, 9, 4, 8 }, new int[4] { 11, 52, 66, 98 });
            //模型.MBAcV4D(new int[4] { 4, 9, 9, 8 }, new int[4] { 11, 24, 52, 98 });
            //模型.MBAcV4D(new int[4] { 4, 8, 9, 8 }, new int[4] { 11, 41, 52, 98 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 8 }, new int[4] { 2, 11, 52, 98 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 8 }, new int[4] { 11, 91, 99, 125 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 8 }, new int[4] { 11, 20, 99, 125 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 9, 12, 23, 40 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 8 }, new int[4] { 12, 23, 40, 41 });
            //模型.MBAcV4D(new int[4] { 4, 9, 4, 9 }, new int[4] { 14, 46, 58, 68 });
            //模型.MBAcV4D(new int[4] { 4, 9, 4, 9 }, new int[4] { 14, 46, 61, 68 });
            //模型.MBAcV4D(new int[4] { 4, 9, 9, 8 }, new int[4] { 14, 57, 68, 88 });
            //模型.MBAcV4D(new int[4] { 4, 9, 4, 9 }, new int[4] { 14, 57, 66, 68 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 9 }, new int[4] { 7, 14, 57, 68 });
            //模型.MBAcV4D(new int[4] { 4, 9, 9, 9 }, new int[4] { 14, 23, 57, 68 });
            //模型.MBAcV4D(new int[4] { 4, 9, 9, 8 }, new int[4] { 14, 57, 68, 87 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 9 }, new int[4] { 14, 53, 57, 68 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 9 }, new int[4] { 14, 56, 57, 68 });
            //模型.MBAcV4D(new int[4] { 4, 8, 9, 9 }, new int[4] { 14, 49, 57, 68 });
            //模型.MBAcV4D(new int[4] { 4, 9, 8, 9 }, new int[4] { 14, 60, 66, 68 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 9 }, new int[4] { 14, 50, 60, 68 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 3 }, new int[4] { 14, 23, 66, 89 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 3 }, new int[4] { 14, 23, 66, 87 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 3 }, new int[4] { 14, 23, 66, 88 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 9 }, new int[4] { 14, 23, 36, 66 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 4 }, new int[4] { 14, 23, 66, 133 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 8 }, new int[4] { 14, 23, 66, 68 });
            //模型.MBAcV4D(new int[4] { 3, 8, 4, 9 }, new int[4] { 5, 14, 23, 66 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 9 }, new int[4] { 14, 23, 48, 66 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 9 }, new int[4] { 14, 23, 25, 66 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 9 }, new int[4] { 14, 23, 25, 66 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 4 }, new int[4] { 14, 23, 66, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 9 }, new int[4] { 14, 23, 51, 66 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 8 }, new int[4] { 14, 23, 66, 139 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 9 }, new int[4] { 14, 23, 66, 66 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 4 }, new int[4] { 14, 23, 66, 127 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 9 }, new int[4] { 14, 23, 74, 87 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 3 }, new int[4] { 14, 23, 87, 111 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 9 }, new int[4] { 14, 23, 25, 87 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 9 }, new int[4] { 14, 23, 35, 87 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 9 }, new int[4] { 14, 23, 57, 87 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 9 }, new int[4] { 14, 23, 46, 87 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 9 }, new int[4] { 14, 23, 48, 87 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 4 }, new int[4] { 14, 23, 87, 103 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 3 }, new int[4] { 14, 23, 88, 111 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 4 }, new int[4] { 14, 23, 88, 102 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 4 }, new int[4] { 14, 23, 88, 104 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 4 }, new int[4] { 14, 23, 88, 89 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 9 }, new int[4] { 14, 23, 66, 88 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 9 }, new int[4] { 14, 23, 87, 88 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 9 }, new int[4] { 14, 23, 57, 88 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 4 }, new int[4] { 14, 23, 88, 95 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 9 }, new int[4] { 14, 23, 66, 89 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 9 }, new int[4] { 14, 23, 25, 89 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 9 }, new int[4] { 14, 23, 36, 89 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 3 }, new int[4] { 14, 23, 89, 111 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 9 }, new int[4] { 14, 23, 89, 100 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 9 }, new int[4] { 14, 23, 88, 100 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 9 }, new int[4] { 14, 23, 87, 100 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 9 }, new int[4] { 14, 23, 100, 100 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 9 }, new int[4] { 14, 23, 36, 100 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 8 }, new int[4] { 14, 23, 100, 139 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 4 }, new int[4] { 14, 23, 100, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 4 }, new int[4] { 14, 23, 100, 133 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 9 }, new int[4] { 14, 23, 68, 100 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 14, 30, 132, 128 });
            //模型.MBAcV4D(new int[4] { 8, 8, 4, 4 }, new int[4] { 14, 18, 30, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 14, 23, 30, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 14, 30, 46, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 4 }, new int[4] { 14, 23, 60, 132 });
            //模型.MBAcV4D(new int[4] { 8, 9, 4, 4 }, new int[4] { 14, 18, 30, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 14, 30, 44, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 4 }, new int[4] { 14, 30, 44, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 4 }, new int[4] { 14, 30, 43, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 4 }, new int[4] { 14, 30, 101, 132 });
            //模型.MBAcV4D(new int[4] { 8, 8, 4, 4 }, new int[4] { 14, 15, 30, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 14, 30, 36, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 4 }, new int[4] { 14, 30, 113, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 4 }, new int[4] { 14, 30, 111, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 14, 30, 100, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 14, 30, 46, 133 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 14, 23, 30, 133 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 14, 30, 66, 133 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 4 }, new int[4] { 14, 30, 43, 133 });
            //模型.MBAcV4D(new int[4] { 8, 8, 4, 4 }, new int[4] { 14, 18, 30, 139 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 14, 30, 46, 139 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 14, 30, 44, 139 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 4 }, new int[4] { 14, 30, 43, 139 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 4 }, new int[4] { 14, 30, 113, 139 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 14, 30, 101, 139 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 14, 30, 51, 139 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 14, 23, 30, 139 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 14, 30, 36, 139 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 14, 31, 47, 133 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 14, 31, 48, 133 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 4 }, new int[4] { 14, 31, 51, 133 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 4 }, new int[4] { 5, 14, 31, 133 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 8 }, new int[4] { 14, 48, 99, 125 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 8 }, new int[4] { 14, 99, 125, 139 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 8 }, new int[4] { 14, 97, 99, 125 });
            //模型.MBAcV4D(new int[4] { 8, 8, 4, 9 }, new int[4] { 6, 15, 23, 88 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 3 }, new int[4] { 15, 23, 88, 113 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 4 }, new int[4] { 15, 23, 88, 104 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 9 }, new int[4] { 15, 23, 87, 88 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 9 }, new int[4] { 5, 15, 23, 88 });
            //模型.MBAcV4D(new int[4] { 4, 8, 8, 9 }, new int[4] { 5, 15, 66, 88 });
            //模型.MBAcV4D(new int[4] { 4, 8, 8, 9 }, new int[4] { 5, 15, 88, 88 });
            //模型.MBAcV4D(new int[4] { 4, 8, 9, 8 }, new int[4] { 5, 15, 88, 89 });
            //模型.MBAcV4D(new int[4] { 8, 8, 4, 9 }, new int[4] { 15, 20, 23, 89 });
            //模型.MBAcV4D(new int[4] { 8, 8, 4, 9 }, new int[4] { 6, 15, 23, 89 });
            //模型.MBAcV4D(new int[4] { 3, 8, 4, 9 }, new int[4] { 5, 15, 23, 89 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 9 }, new int[4] { 15, 23, 88, 89 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 9 }, new int[4] { 15, 23, 66, 89 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 3 }, new int[4] { 15, 23, 89, 111 });
            //模型.MBAcV4D(new int[4] { 4, 9, 8, 8 }, new int[4] { 17, 68, 73, 134 });
            //模型.MBAcV4D(new int[4] { 4, 9, 8, 8 }, new int[4] { 17, 68, 73, 138 });
            //模型.MBAcV4D(new int[4] { 4, 8, 9, 8 }, new int[4] { 17, 62, 68, 73 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 17, 31, 60, 132 });
            //模型.MBAcV4D(new int[4] { 8, 8, 4, 4 }, new int[4] { 5, 17, 31, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 17, 23, 31, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 17, 31, 45, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 17, 31, 43, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 17, 31, 98, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 17, 28, 31, 132 });
            //模型.MBAcV4D(new int[4] { 8, 8, 4, 4 }, new int[4] { 14, 18, 30, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 8 }, new int[4] { 18, 30, 132, 137 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 18, 30, 80, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 18, 30, 51, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 18, 30, 67, 132 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 9 }, new int[4] { 18, 30, 132, 134 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 18, 30, 132, 134 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 18, 30, 41, 134 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 18, 30, 51, 138 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 18, 30, 132, 138 });
            //模型.MBAcV4D(new int[4] { 8, 8, 4, 4 }, new int[4] { 14, 18, 30, 139 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 18, 30, 51, 139 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 4 }, new int[4] { 23, 33, 49, 140 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 8 }, new int[4] { 9, 23, 33, 49 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 9 }, new int[4] { 23, 39, 45, 100 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 9 }, new int[4] { 14, 23, 39, 87 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 9 }, new int[4] { 14, 23, 39, 89 });
            //模型.MBAcV4D(new int[4] { 3, 4, 4, 8 }, new int[4] { 20, 23, 40, 41 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 8 }, new int[4] { 21, 23, 40, 41 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 3 }, new int[4] { 23, 40, 41, 42 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 9 }, new int[4] { 23, 40, 41, 42 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 3 }, new int[4] { 23, 40, 41, 91 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 8 }, new int[4] { 23, 40, 41, 69 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 8 }, new int[4] { 23, 40, 41, 98 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 8 }, new int[4] { 14, 23, 87, 114 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 8 }, new int[4] { 14, 23, 88, 114 });
            //模型.MBAcV4D(new int[4] { 9, 4, 8, 8 }, new int[4] { 24, 39, 49, 64 });
            //模型.MBAcV4D(new int[4] { 9, 9, 4, 4 }, new int[4] { 26, 29, 67, 144 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 8 }, new int[4] { 29, 39, 41, 74 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 9 }, new int[4] { 29, 32, 39, 86 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 9 }, new int[4] { 29, 30, 39, 86 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 4 }, new int[4] { 15, 30, 43, 137 });
            //模型.MBAcV4D(new int[4] { 9, 4, 8, 4 }, new int[4] { 13, 30, 44, 71 });
            //模型.MBAcV4D(new int[4] { 9, 4, 8, 4 }, new int[4] { 16, 30, 44, 71 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 4 }, new int[4] { 30, 44, 65, 71 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 24, 30, 44, 71 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 3 }, new int[4] { 30, 44, 71, 114 });
            //模型.MBAcV4D(new int[4] { 3, 4, 8, 4 }, new int[4] { 18, 30, 44, 71 });
            //模型.MBAcV4D(new int[4] { 4, 8, 8, 4 }, new int[4] { 30, 44, 48, 71 });
            //模型.MBAcV4D(new int[4] { 4, 8, 3, 4 }, new int[4] { 30, 44, 48, 71 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 4 }, new int[4] { 15, 30, 71, 126 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 4 }, new int[4] { 30, 44, 45, 71 });
            //模型.MBAcV4D(new int[4] { 4, 8, 3, 4 }, new int[4] { 30, 44, 60, 71 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 3 }, new int[4] { 30, 44, 70, 98 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 24, 30, 44, 70 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 16, 30, 44, 70 });
            //模型.MBAcV4D(new int[4] { 9, 4, 8, 4 }, new int[4] { 15, 30, 44, 70 });
            //模型.MBAcV4D(new int[4] { 9, 4, 8, 4 }, new int[4] { 14, 30, 44, 70 });
            //模型.MBAcV4D(new int[4] { 3, 4, 8, 4 }, new int[4] { 18, 30, 44, 70 });
            //模型.MBAcV4D(new int[4] { 9, 4, 8, 4 }, new int[4] { 11, 30, 44, 70 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 9 }, new int[4] { 30, 44, 70, 114 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 8 }, new int[4] { 30, 44, 70, 138 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 4 }, new int[4] { 30, 44, 69, 70 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 8 }, new int[4] { 18, 30, 132, 138 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 8 }, new int[4] { 11, 30, 132, 138 });
            //模型.MBAcV4D(new int[4] { 4, 3, 4, 8 }, new int[4] { 30, 111, 132, 138 });
            //模型.MBAcV4D(new int[4] { 4, 3, 4, 8 }, new int[4] { 30, 45, 132, 138 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 8 }, new int[4] { 30, 57, 132, 138 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 30, 39, 50, 58 });
            //模型.MBAcV4D(new int[4] { 8, 8, 4, 4 }, new int[4] { 14, 30, 39, 58 });
            //模型.MBAcV4D(new int[4] { 8, 8, 4, 4 }, new int[4] { 11, 30, 39, 58 });
            //模型.MBAcV4D(new int[4] { 8, 8, 4, 4 }, new int[4] { 15, 30, 39, 58 });
            //模型.MBAcV4D(new int[4] { 9, 4, 8, 3 }, new int[4] { 30, 70, 114, 122 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 8 }, new int[4] { 30, 43, 71, 114 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 9 }, new int[4] { 9, 31, 32, 72 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 8 }, new int[4] { 4, 31, 38, 125 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 8 }, new int[4] { 31, 38, 39, 125 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 8 }, new int[4] { 25, 31, 38, 125 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 8 }, new int[4] { 31, 39, 41, 61 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 8 }, new int[4] { 31, 39, 61, 112 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 9 }, new int[4] { 31, 39, 49, 72 });
            //模型.MBAcV4D(new int[4] { 4, 3, 4, 9 }, new int[4] { 31, 34, 39, 86 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 9 }, new int[4] { 31, 32, 39, 86 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 9 }, new int[4] { 0, 31, 49, 73 });
            //模型.MBAcV4D(new int[4] { 4, 8, 8, 9 }, new int[4] { 31, 42, 49, 73 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 9 }, new int[4] { 31, 39, 49, 73 });
            //模型.MBAcV4D(new int[4] { 4, 8, 9, 4 }, new int[4] { 31, 49, 73, 99 });
            //模型.MBAcV4D(new int[4] { 4, 8, 9, 8 }, new int[4] { 31, 49, 73, 125 });
            //模型.MBAcV4D(new int[4] { 4, 8, 8, 9 }, new int[4] { 31, 40, 49, 73 });
            //模型.MBAcV4D(new int[4] { 4, 8, 9, 4 }, new int[4] { 31, 49, 73, 120 });
            //模型.MBAcV4D(new int[4] { 4, 8, 9, 4 }, new int[4] { 31, 49, 73, 117 });
            //模型.MBAcV4D(new int[4] { 4, 4, 9, 8 }, new int[4] { 31, 50, 86, 100 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 9 }, new int[4] { 15, 31, 50, 86 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 9 }, new int[4] { 14, 31, 50, 86 });
            //模型.MBAcV4D(new int[4] { 3, 4, 4, 9 }, new int[4] { 14, 31, 50, 86 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 9 }, new int[4] { 31, 46, 50, 86 });
            //模型.MBAcV4D(new int[4] { 3, 4, 4, 9 }, new int[4] { 11, 31, 50, 86 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 4 }, new int[4] { 31, 50, 103, 138 });
            //模型.MBAcV4D(new int[4] { 4, 3, 8, 4 }, new int[4] { 31, 47, 50, 138 });
            //模型.MBAcV4D(new int[4] { 4, 8, 3, 4 }, new int[4] { 31, 50, 57, 138 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 4 }, new int[4] { 7, 31, 50, 138 });
            //模型.MBAcV4D(new int[4] { 3, 4, 8, 4 }, new int[4] { 14, 31, 50, 138 });
            //模型.MBAcV4D(new int[4] { 3, 4, 8, 4 }, new int[4] { 15, 31, 50, 138 });
            //模型.MBAcV4D(new int[4] { 4, 9, 8, 4 }, new int[4] { 31, 48, 50, 138 });
            //模型.MBAcV4D(new int[4] { 4, 9, 8, 4 }, new int[4] { 31, 43, 50, 138 });
            //模型.MBAcV4D(new int[4] { 4, 8, 3, 4 }, new int[4] { 31, 50, 128, 138 });
            //模型.MBAcV4D(new int[4] { 4, 3, 8, 4 }, new int[4] { 31, 35, 50, 138 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 4 }, new int[4] { 31, 50, 103, 139 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 4 }, new int[4] { 7, 31, 50, 139 });
            //模型.MBAcV4D(new int[4] { 4, 8, 8, 4 }, new int[4] { 31, 50, 57, 139 });
            //模型.MBAcV4D(new int[4] { 4, 8, 3, 4 }, new int[4] { 31, 50, 57, 139 });
            //模型.MBAcV4D(new int[4] { 4, 3, 8, 4 }, new int[4] { 31, 47, 50, 139 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 4 }, new int[4] { 31, 50, 127, 139 });
            //模型.MBAcV4D(new int[4] { 9, 4, 4, 4 }, new int[4] { 32, 39, 50, 58 });
            //模型.MBAcV4D(new int[4] { 8, 9, 4, 4 }, new int[4] { 14, 32, 39, 58 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 9 }, new int[4] { 33, 39, 49, 49 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 8 }, new int[4] { 24, 39, 49, 64 });
            //模型.MBAcV4D(new int[4] { 9, 4, 8, 8 }, new int[4] { 24, 39, 49, 64 });
            //模型.MBAcV4D(new int[4] { 4, 4, 8, 8 }, new int[4] { 25, 39, 49, 64 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 9 }, new int[4] { 39, 41, 58, 72 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 9 }, new int[4] { 39, 49, 58, 72 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 9 }, new int[4] { 39, 41, 58, 73 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 3 }, new int[4] { 39, 41, 58, 99 });
            //模型.MBAcV4D(new int[4] { 4, 8, 8, 9 }, new int[4] { 39, 41, 64, 76 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 9 }, new int[4] { 39, 64, 65, 76 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 21, 49, 49, 58 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 4 }, new int[4] { 49, 49, 58, 91 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 9 }, new int[4] { 21, 49, 58, 73 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 9 }, new int[4] { 20, 49, 58, 73 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 9 }, new int[4] { 49, 52, 58, 73 });
            //模型.MBAcV4D(new int[4] { 3, 8, 4, 9 }, new int[4] { 49, 49, 58, 73 });
            //模型.MBAcV4D(new int[4] { 8, 8, 4, 9 }, new int[4] { 38, 49, 58, 73 });
            //模型.MBAcV4D(new int[4] { 3, 8, 4, 9 }, new int[4] { 38, 49, 58, 73 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 8 }, new int[4] { 49, 58, 73, 113 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 49, 58, 94, 139 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 4 }, new int[4] { 49, 58, 73, 139 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 4 }, new int[4] { 49, 58, 71, 139 });
            //模型.MBAcV4D(new int[4] { 8, 4, 3, 4 }, new int[4] { 49, 58, 74, 139 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 4 }, new int[4] { 2, 49, 58, 139 });
            //模型.MBAcV4D(new int[4] { 9, 8, 4, 4 }, new int[4] { 1, 49, 58, 139 });
            //模型.MBAcV4D(new int[4] { 4, 8, 4, 4 }, new int[4] { 7, 49, 58, 139 });
            //模型.MBAcV4D(new int[4] { 4, 8, 8, 9 }, new int[4] { 24, 49, 73, 87 });
            //模型.MBAcV4D(new int[4] { 8, 8, 4, 9 }, new int[4] { 49, 73, 74, 87 });
            //模型.MBAcV4D(new int[4] { 8, 8, 9, 8 }, new int[4] { 49, 73, 87, 113 });
            //模型.MBAcV4D(new int[4] { 8, 8, 9, 8 }, new int[4] { 49, 73, 87, 114 });
            //模型.MBAcV4D(new int[4] { 8, 8, 9, 3 }, new int[4] { 49, 73, 87, 88 });
            //模型.MBAcV4D(new int[4] { 8, 9, 8, 8 }, new int[4] { 49, 87, 112, 114 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 8 }, new int[4] { 49, 74, 87, 114 });
            //模型.MBAcV4D(new int[4] { 9, 8, 9, 8 }, new int[4] { 1, 49, 87, 114 });
            //模型.MBAcV4D(new int[4] { 9, 8, 9, 8 }, new int[4] { 2, 49, 87, 114 });
            //模型.MBAcV4D(new int[4] { 3, 8, 9, 8 }, new int[4] { 49, 49, 87, 114 });
            //模型.MBAcV4D(new int[4] { 9, 8, 9, 8 }, new int[4] { 4, 49, 87, 114 });
            //模型.MBAcV4D(new int[4] { 8, 3, 9, 8 }, new int[4] { 49, 71, 88, 114 });
            //模型.MBAcV4D(new int[4] { 8, 3, 9, 8 }, new int[4] { 49, 70, 88, 114 });
            //模型.MBAcV4D(new int[4] { 8, 9, 4, 8 }, new int[4] { 49, 88, 94, 114 });
            //模型.MBAcV4D(new int[4] { 8, 3, 9, 8 }, new int[4] { 49, 73, 88, 114 });
            //模型.MBAcV4D(new int[4] { 3, 8, 9, 8 }, new int[4] { 4, 49, 88, 114 });
            //模型.MBAcV4D(new int[4] { 8, 9, 3, 8 }, new int[4] { 49, 88, 92, 114 });
            //模型.MBAcV4D(new int[4] { 8, 9, 9, 8 }, new int[4] { 49, 49, 88, 114 });
            //模型.MBAcV4D(new int[4] { 8, 9, 8, 8 }, new int[4] { 49, 89, 112, 114 });
            //模型.MBAcV4D(new int[4] { 8, 9, 4, 8 }, new int[4] { 49, 89, 94, 114 });
            //模型.MBAcV4D(new int[4] { 8, 4, 9, 8 }, new int[4] { 49, 74, 89, 114 });
            //模型.MBAcV4D(new int[4] { 9, 8, 9, 8 }, new int[4] { 2, 49, 89, 114 });
            //模型.MBAcV4D(new int[4] { 9, 8, 9, 8 }, new int[4] { 1, 49, 89, 114 });
            //模型.MBAcV4D(new int[4] { 9, 8, 9, 8 }, new int[4] { 49, 49, 89, 114 });
            //模型.MBAcV4D(new int[4] { 8, 4, 8, 4 }, new int[4] { 49, 72, 100, 120 });
            //模型.MBAcV4D(new int[4] { 3, 8, 8, 4 }, new int[4] { 49, 49, 100, 120 });
            //模型.MBAcV4D(new int[4] { 8, 4, 4, 8 }, new int[4] { 46, 73, 120, 139 });
            //模型.MBAcV4D(new int[4] { 4, 4, 4, 8 }, new int[4] { 41, 63, 73, 100 });
            //模型.EMtP();
            //模型.EMvP();



            //Console.WriteLine(SGKC.Exl2610.DtA0(20));



            /*
            string msg;
            DirectoryInfo di = new DirectoryInfo("D:\\ML\\OYTamn\\EV\\");
            THLogRgr.stage8(in di);
            Console.WriteLine();
            //*/



            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMinutes);
            Console.WriteLine("AllByteCT={0}MB\tAllByte={1}MB\r\nTotMem={2}MB", (double)GC.GetAllocatedBytesForCurrentThread() / 1000000, (double)GC.GetTotalAllocatedBytes() / 1000000, (double)GC.GetTotalMemory(true) / 1000000);
        }
    }
    static internal class 模型
    {
        static readonly private string ナゾナゾ記述子 = "D:\\ML\\OYTamn\\Data\\D1.csv";
        static readonly private string 乱数です = "D:\\ML\\OYTamn\\Data\\Res.csv";
        static internal void MBAc1D()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[1];
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                hs[0] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D1D\\{0}.THLRlog", cnt2));
                desin = new double[1][] { Des[cnt] };
                dind = new int[1] { cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[0] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D1D\\{0}.THLRlog", cnt2));
                desin = new double[1][] { Des[cnt] };
                dind = new int[1] { cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[0] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D1D\\{0}.THLRlog", cnt2));
                desin = new double[1][] { Des[cnt] };
                dind = new int[1] { cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[0] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D1D\\{0}.THLRlog", cnt2));
                desin = new double[1][] { Des[cnt] };
                dind = new int[1] { cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_88()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 9;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 88)
                {
                    hs[1] = 9;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_88\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[88], Des[cnt] };
                    dind = new int[2] { 88, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_88\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[88], Des[cnt] };
                dind = new int[2] { 88, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_88\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[88], Des[cnt] };
                dind = new int[2] { 88, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_88\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[88], Des[cnt] };
                dind = new int[2] { 88, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_68()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 9;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 68)
                {
                    hs[1] = 9;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_68\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[68], Des[cnt] };
                    dind = new int[2] { 68, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_68\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[68], Des[cnt] };
                dind = new int[2] { 68, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_68\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[68], Des[cnt] };
                dind = new int[2] { 68, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_68\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[68], Des[cnt] };
                dind = new int[2] { 68, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_87()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 9;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 87)
                {
                    hs[1] = 9;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_87\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[87], Des[cnt] };
                    dind = new int[2] { 87, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_87\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[87], Des[cnt] };
                dind = new int[2] { 87, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_87\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[87], Des[cnt] };
                dind = new int[2] { 87, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_87\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[87], Des[cnt] };
                dind = new int[2] { 87, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_5()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 9;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 5)
                {
                    hs[1] = 9;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_5\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[5], Des[cnt] };
                    dind = new int[2] { 5, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_5\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[5], Des[cnt] };
                dind = new int[2] { 5, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_5\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[5], Des[cnt] };
                dind = new int[2] { 5, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_5\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[5], Des[cnt] };
                dind = new int[2] { 5, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_89()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 9;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 89)
                {
                    hs[1] = 9;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_89\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[89], Des[cnt] };
                    dind = new int[2] { 89, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_89\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[89], Des[cnt] };
                dind = new int[2] { 89, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_89\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[89], Des[cnt] };
                dind = new int[2] { 89, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_89\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[89], Des[cnt] };
                dind = new int[2] { 89, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_40()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 9;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 40)
                {
                    hs[1] = 9;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_40\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[40], Des[cnt] };
                    dind = new int[2] { 40, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_40\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[40], Des[cnt] };
                dind = new int[2] { 40, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_40\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[40], Des[cnt] };
                dind = new int[2] { 40, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_40\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[40], Des[cnt] };
                dind = new int[2] { 40, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_0()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 9;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 0)
                {
                    hs[1] = 9;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_0\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[0], Des[cnt] };
                    dind = new int[2] { 0, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_0\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[0], Des[cnt] };
                dind = new int[2] { 0, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_0\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[0], Des[cnt] };
                dind = new int[2] { 0, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_0\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[0], Des[cnt] };
                dind = new int[2] { 0, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_39()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 39)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_39\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[39], Des[cnt] };
                    dind = new int[2] { 39, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_39\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[39], Des[cnt] };
                dind = new int[2] { 39, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_39\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[39], Des[cnt] };
                dind = new int[2] { 39, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_39\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[39], Des[cnt] };
                dind = new int[2] { 39, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_63()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 63)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_63\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[63], Des[cnt] };
                    dind = new int[2] { 63, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_63\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[63], Des[cnt] };
                dind = new int[2] { 63, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_63\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[63], Des[cnt] };
                dind = new int[2] { 63, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_63\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[63], Des[cnt] };
                dind = new int[2] { 63, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_40_4()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 40)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_40(4)\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[40], Des[cnt] };
                    dind = new int[2] { 40, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_40(4)\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[40], Des[cnt] };
                dind = new int[2] { 40, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_40(4)\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[40], Des[cnt] };
                dind = new int[2] { 40, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_40(4)\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[40], Des[cnt] };
                dind = new int[2] { 40, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_133()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 133)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_133\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[133], Des[cnt] };
                    dind = new int[2] { 133, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_133\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[133], Des[cnt] };
                dind = new int[2] { 133, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_133\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[133], Des[cnt] };
                dind = new int[2] { 133, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_133\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[133], Des[cnt] };
                dind = new int[2] { 133, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_88_4()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 88)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_88(4)\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[88], Des[cnt] };
                    dind = new int[2] { 88, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_88(4)\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[88], Des[cnt] };
                dind = new int[2] { 88, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_88(4)\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[88], Des[cnt] };
                dind = new int[2] { 88, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_88(4)\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[88], Des[cnt] };
                dind = new int[2] { 88, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_70()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 70)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_70\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[70], Des[cnt] };
                    dind = new int[2] { 70, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_70\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[70], Des[cnt] };
                dind = new int[2] { 70, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_70\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[70], Des[cnt] };
                dind = new int[2] { 70, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_70\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[70], Des[cnt] };
                dind = new int[2] { 70, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_118()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 118)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_118\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[118], Des[cnt] };
                    dind = new int[2] { 118, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_118\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[118], Des[cnt] };
                dind = new int[2] { 118, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_118\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[118], Des[cnt] };
                dind = new int[2] { 118, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_118\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[118], Des[cnt] };
                dind = new int[2] { 118, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_117()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 117)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_117\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[117], Des[cnt] };
                    dind = new int[2] { 117, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_117\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[117], Des[cnt] };
                dind = new int[2] { 117, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_117\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[117], Des[cnt] };
                dind = new int[2] { 117, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_117\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[117], Des[cnt] };
                dind = new int[2] { 117, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_137()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 137)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_137\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[137], Des[cnt] };
                    dind = new int[2] { 137, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_137\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[137], Des[cnt] };
                dind = new int[2] { 137, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_137\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[137], Des[cnt] };
                dind = new int[2] { 137, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_137\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[137], Des[cnt] };
                dind = new int[2] { 137, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_120()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 120)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_120\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[120], Des[cnt] };
                    dind = new int[2] { 120, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_120\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[120], Des[cnt] };
                dind = new int[2] { 120, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_120\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[120], Des[cnt] };
                dind = new int[2] { 120, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_120\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[120], Des[cnt] };
                dind = new int[2] { 120, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_31()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 31)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_31\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[31], Des[cnt] };
                    dind = new int[2] { 31, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_31\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[31], Des[cnt] };
                dind = new int[2] { 31, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_31\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[31], Des[cnt] };
                dind = new int[2] { 31, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_31\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[31], Des[cnt] };
                dind = new int[2] { 31, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_132()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 132)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_132\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[132], Des[cnt] };
                    dind = new int[2] { 132, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_132\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[132], Des[cnt] };
                dind = new int[2] { 132, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_132\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[132], Des[cnt] };
                dind = new int[2] { 132, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_132\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[132], Des[cnt] };
                dind = new int[2] { 132, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_30()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 30)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_30\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[30], Des[cnt] };
                    dind = new int[2] { 30, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_30\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[30], Des[cnt] };
                dind = new int[2] { 30, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_30\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[30], Des[cnt] };
                dind = new int[2] { 30, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_30\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[30], Des[cnt] };
                dind = new int[2] { 30, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_14()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 14)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_14\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[14], Des[cnt] };
                    dind = new int[2] { 14, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_14\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[14], Des[cnt] };
                dind = new int[2] { 14, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_14\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[14], Des[cnt] };
                dind = new int[2] { 14, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_14\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[14], Des[cnt] };
                dind = new int[2] { 14, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 144)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_144\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[144], Des[cnt] };
                    dind = new int[2] { 144, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_144\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[144], Des[cnt] };
                dind = new int[2] { 144, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_144\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[144], Des[cnt] };
                dind = new int[2] { 144, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_144\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[144], Des[cnt] };
                dind = new int[2] { 144, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_100()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 100)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_100\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[100], Des[cnt] };
                    dind = new int[2] { 100, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_100\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[100], Des[cnt] };
                dind = new int[2] { 100, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_100\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[100], Des[cnt] };
                dind = new int[2] { 100, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_100\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[100], Des[cnt] };
                dind = new int[2] { 100, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_73()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 73)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_73\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[73], Des[cnt] };
                    dind = new int[2] { 73, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_73\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[73], Des[cnt] };
                dind = new int[2] { 73, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_73\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[73], Des[cnt] };
                dind = new int[2] { 73, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_73\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[73], Des[cnt] };
                dind = new int[2] { 73, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_58()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 58)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_58\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[58], Des[cnt] };
                    dind = new int[2] { 58, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_58\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[58], Des[cnt] };
                dind = new int[2] { 58, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_58\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[58], Des[cnt] };
                dind = new int[2] { 58, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_58\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[58], Des[cnt] };
                dind = new int[2] { 58, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_61()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 61)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_61\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[61], Des[cnt] };
                    dind = new int[2] { 61, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_61\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[61], Des[cnt] };
                dind = new int[2] { 61, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_61\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[61], Des[cnt] };
                dind = new int[2] { 61, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_61\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[61], Des[cnt] };
                dind = new int[2] { 61, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_17()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 17)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_17\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[17], Des[cnt] };
                    dind = new int[2] { 17, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_17\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[17], Des[cnt] };
                dind = new int[2] { 17, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_17\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[17], Des[cnt] };
                dind = new int[2] { 17, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_17\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[17], Des[cnt] };
                dind = new int[2] { 17, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_134()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 134)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_134\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[134], Des[cnt] };
                    dind = new int[2] { 134, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_134\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[134], Des[cnt] };
                dind = new int[2] { 134, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_134\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[134], Des[cnt] };
                dind = new int[2] { 134, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_134\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[134], Des[cnt] };
                dind = new int[2] { 134, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_52()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 52)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_52\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[52], Des[cnt] };
                    dind = new int[2] { 52, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_52\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[52], Des[cnt] };
                dind = new int[2] { 52, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_52\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[52], Des[cnt] };
                dind = new int[2] { 52, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_52\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[52], Des[cnt] };
                dind = new int[2] { 52, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_23()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 23)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_23\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[23], Des[cnt] };
                    dind = new int[2] { 23, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_23\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[23], Des[cnt] };
                dind = new int[2] { 23, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_23\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[23], Des[cnt] };
                dind = new int[2] { 23, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_23\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[23], Des[cnt] };
                dind = new int[2] { 23, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_33()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 33)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_33\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[33], Des[cnt] };
                    dind = new int[2] { 33, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_33\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[33], Des[cnt] };
                dind = new int[2] { 33, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_33\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[33], Des[cnt] };
                dind = new int[2] { 33, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_33\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[33], Des[cnt] };
                dind = new int[2] { 33, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 8;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 114)
                {
                    hs[1] = 8;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_114\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[114], Des[cnt] };
                    dind = new int[2] { 114, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_114\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[114], Des[cnt] };
                dind = new int[2] { 114, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_114\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[114], Des[cnt] };
                dind = new int[2] { 114, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_114\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[114], Des[cnt] };
                dind = new int[2] { 114, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_39_8()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 8;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 39)
                {
                    hs[1] = 8;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_39(8)\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[39], Des[cnt] };
                    dind = new int[2] { 39, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_39(8)\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[39], Des[cnt] };
                dind = new int[2] { 39, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_39(8)\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[39], Des[cnt] };
                dind = new int[2] { 39, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_39(8)\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[39], Des[cnt] };
                dind = new int[2] { 39, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_100_8()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 8;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 100)
                {
                    hs[1] = 8;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_100(8)\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[100], Des[cnt] };
                    dind = new int[2] { 100, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_100(8)\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[100], Des[cnt] };
                dind = new int[2] { 100, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_100(8)\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[100], Des[cnt] };
                dind = new int[2] { 100, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_100(8)\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[100], Des[cnt] };
                dind = new int[2] { 100, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_125()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 8;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 125)
                {
                    hs[1] = 8;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_125\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[125], Des[cnt] };
                    dind = new int[2] { 125, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_125\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[125], Des[cnt] };
                dind = new int[2] { 125, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_125\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[125], Des[cnt] };
                dind = new int[2] { 125, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_125\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[125], Des[cnt] };
                dind = new int[2] { 125, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_139()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 8;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 139)
                {
                    hs[1] = 8;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_139\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[139], Des[cnt] };
                    dind = new int[2] { 139, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_139\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[139], Des[cnt] };
                dind = new int[2] { 139, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_139\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[139], Des[cnt] };
                dind = new int[2] { 139, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_139\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[139], Des[cnt] };
                dind = new int[2] { 139, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_98()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 8;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 98)
                {
                    hs[1] = 8;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_98\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[98], Des[cnt] };
                    dind = new int[2] { 98, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_98\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[98], Des[cnt] };
                dind = new int[2] { 98, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_98\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[98], Des[cnt] };
                dind = new int[2] { 98, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 4;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_98\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[98], Des[cnt] };
                dind = new int[2] { 98, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc2D_11()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[2];
            hs[0] = 4;
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                if (cnt != 11)
                {
                    hs[1] = 4;
                    fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_11\\{0}.THLRlog", cnt2));
                    desin = new double[2][] { Des[11], Des[cnt] };
                    dind = new int[2] { 11, cnt };
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[1] = 3;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_11\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[11], Des[cnt] };
                dind = new int[2] { 11, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 9;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_11\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[11], Des[cnt] };
                dind = new int[2] { 11, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[1] = 8;
                fi = new FileInfo(string.Format("D:\\ML\\OYTamn\\D2D_11\\{0}.THLRlog", cnt2));
                desin = new double[2][] { Des[11], Des[cnt] };
                dind = new int[2] { 11, cnt };
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_5_14()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_5(9)14(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[5], Des[14], Des[cnt] };
                dind = new int[3] { 5, 14, cnt };
                if (cnt != 5)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 14)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_5_61()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_5(9)61(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[5], Des[61], Des[cnt] };
                dind = new int[3] { 5, 61, cnt };
                if (cnt != 5)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 61)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_14_68()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_14(4)68(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[14], Des[68], Des[cnt] };
                dind = new int[3] { 14, 68, cnt };
                if (cnt != 68)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 14)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_17_68()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_17(4)68(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[17], Des[68], Des[cnt] };
                dind = new int[3] { 17, 68, cnt };
                if (cnt != 68)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 17)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_23_100()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_23(4)100(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[23], Des[100], Des[cnt] };
                dind = new int[3] { 23, 100, cnt };
                if (cnt != 100)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_23_89()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_23(4)89(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[23], Des[89], Des[cnt] };
                dind = new int[3] { 23, 89, cnt };
                if (cnt != 89)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_23_87()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_23(4)87(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[23], Des[87], Des[cnt] };
                dind = new int[3] { 23, 87, cnt };
                if (cnt != 87)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_23_66()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_23(4)66(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[23], Des[66], Des[cnt] };
                dind = new int[3] { 23, 66, cnt };
                if (cnt != 66)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_23_88()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_23(4)88(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[23], Des[88], Des[cnt] };
                dind = new int[3] { 23, 88, cnt };
                if (cnt != 88)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_23_111()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_23(4)111(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[23], Des[111], Des[cnt] };
                dind = new int[3] { 23, 111, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23 && cnt != 111)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_30_137()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_30(4)137(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[30], Des[137], Des[cnt] };
                dind = new int[3] { 30, 137, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 137)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_30_70()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_30(4)70(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[30], Des[70], Des[cnt] };
                dind = new int[3] { 30, 70, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 70)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_30_134()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_30(4)134(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[30], Des[134], Des[cnt] };
                dind = new int[3] { 30, 134, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 134)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_30_71()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_30(4)71(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[30], Des[71], Des[cnt] };
                dind = new int[3] { 30, 71, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 71)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_30_138()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_30(4)138(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[30], Des[138], Des[cnt] };
                dind = new int[3] { 30, 138, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 138)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_30_139()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_30(4)139(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[30], Des[139], Des[cnt] };
                dind = new int[3] { 30, 139, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 139)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_31_50()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_31(4)50(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[31], Des[50], Des[cnt] };
                dind = new int[3] { 31, 50, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 50)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_31_39()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_31(4)39(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[31], Des[39], Des[cnt] };
                dind = new int[3] { 31, 39, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 39)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_31_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_31(9)144(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[31], Des[144], Des[cnt] };
                dind = new int[3] { 31, 144, cnt };
                if (cnt != 31)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 144)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_31_134()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_31(9)134(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[31], Des[134], Des[cnt] };
                dind = new int[3] { 31, 134, cnt };
                if (cnt != 31)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 134)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_31_137()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_31(9)137(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[31], Des[137], Des[cnt] };
                dind = new int[3] { 31, 137, cnt };
                if (cnt != 31)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 137)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_31_138()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_31(4)138(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[31], Des[138], Des[cnt] };
                dind = new int[3] { 31, 138, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 138)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_31_139()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_31(4)139(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[31], Des[139], Des[cnt] };
                dind = new int[3] { 31, 139, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 139)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_31_73()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_31(4)73(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[31], Des[73], Des[cnt] };
                dind = new int[3] { 31, 73, cnt };
                if (cnt != 73)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_31_72()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_31(4)72(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[31], Des[72], Des[cnt] };
                dind = new int[3] { 31, 72, cnt };
                if (cnt != 72)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_33_39()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_33(4)39(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[33], Des[39], Des[cnt] };
                dind = new int[3] { 33, 39, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 33 && cnt != 39)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_33_134()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_33(4)134(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[33], Des[134], Des[cnt] };
                dind = new int[3] { 33, 134, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 33 && cnt != 134)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_33_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_33(9)144(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[33], Des[144], Des[cnt] };
                dind = new int[3] { 33, 144, cnt };
                if (cnt != 33)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 144)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_33_137()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_33(9)137(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[33], Des[137], Des[cnt] };
                dind = new int[3] { 33, 137, cnt };
                if (cnt != 33)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 137)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_23_33()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_23(4)33(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[23], Des[33], Des[cnt] };
                dind = new int[3] { 23, 33, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23 && cnt != 33)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_25_33()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_25(4)33(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[25], Des[33], Des[cnt] };
                dind = new int[3] { 25, 33, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 25 && cnt != 33)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_33_120()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_33(4)120(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[33], Des[120], Des[cnt] };
                dind = new int[3] { 33, 120, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 33 && cnt != 120)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_39_64()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_39(4)64(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[39], Des[64], Des[cnt] };
                dind = new int[3] { 39, 64, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 33)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 64)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_39_58()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_39(4)58(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[39], Des[58], Des[cnt] };
                dind = new int[3] { 39, 58, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 39 && cnt != 58)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_29_39()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_29(4)39(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[29], Des[39], Des[cnt] };
                dind = new int[3] { 29, 39, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 29 && cnt != 39)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_39_134()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_39(4)134(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[39], Des[134], Des[cnt] };
                dind = new int[3] { 39, 134, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 39 && cnt != 134)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_39_88()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_39(4)88(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[39], Des[88], Des[cnt] };
                dind = new int[3] { 39, 88, cnt };
                if (cnt != 88)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 39)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_31_86()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_31(4)86(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[31], Des[86], Des[cnt] };
                dind = new int[3] { 31, 86, cnt };
                if (cnt != 86)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_30_88()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_30(4)88(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[30], Des[88], Des[cnt] };
                dind = new int[3] { 30, 88, cnt };
                if (cnt != 88)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_5_30()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_5(9)30(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[5], Des[30], Des[cnt] };
                dind = new int[3] { 5, 30, cnt };
                if (cnt != 5)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_5_17()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_5(9)17(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[5], Des[17], Des[cnt] };
                dind = new int[3] { 5, 17, cnt };
                if (cnt != 5)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 17)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_39_87()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 8;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_39(8)87(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[39], Des[87], Des[cnt] };
                dind = new int[3] { 39, 87, cnt };
                if (cnt != 87)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 39)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_39_89()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 8;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_39(8)89(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[39], Des[89], Des[cnt] };
                dind = new int[3] { 39, 89, cnt };
                if (cnt != 89)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 39)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_40_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_40(9)144(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[40], Des[144], Des[cnt] };
                dind = new int[3] { 40, 144, cnt };
                if (cnt != 40)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 144)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_40_68()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_40(9)68(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[40], Des[68], Des[cnt] };
                dind = new int[3] { 40, 68, cnt };
                if (cnt != 40 && cnt != 68)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_40_100()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_40(4)100(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[40], Des[100], Des[cnt] };
                dind = new int[3] { 40, 100, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 40 && cnt != 100)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_23_40()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_23(4)40(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[23], Des[40], Des[cnt] };
                dind = new int[3] { 23, 40, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23 && cnt != 40)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_18_40()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_18(9)40(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[18], Des[40], Des[cnt] };
                dind = new int[3] { 18, 40, cnt };
                if (cnt != 18)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 40)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_5_40()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_5(9)40(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[5], Des[40], Des[cnt] };
                dind = new int[3] { 5, 40, cnt };
                if (cnt != 5)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 40)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_21_40()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_21(9)40(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[21], Des[40], Des[cnt] };
                dind = new int[3] { 21, 40, cnt };
                if (cnt != 21)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 40)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_40_58()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_40(4)58(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[40], Des[58], Des[cnt] };
                dind = new int[3] { 40, 58, cnt };
                if (cnt != 58)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 40)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_40_88()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_40(4)88(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[40], Des[88], Des[cnt] };
                dind = new int[3] { 40, 88, cnt };
                if (cnt != 88)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 40)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_52_63()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_52(9)63(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[52], Des[63], Des[cnt] };
                dind = new int[3] { 52, 63, cnt };
                if (cnt != 52)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 63)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_49_58()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 8;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_49(8)58(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[49], Des[58], Des[cnt] };
                dind = new int[3] { 49, 58, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 58)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 49)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_61_68()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_61(4)68(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[61], Des[68], Des[cnt] };
                dind = new int[3] { 61, 68, cnt };
                if (cnt != 68)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 61)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_37_63()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_37(9)63(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[37], Des[63], Des[cnt] };
                dind = new int[3] { 37, 63, cnt };
                if (cnt != 37)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 63)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_63_64()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_63(4)64(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[63], Des[64], Des[cnt] };
                dind = new int[3] { 63, 64, cnt };
                if (cnt != 64)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 63)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_63_87()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_63(4)87(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[63], Des[87], Des[cnt] };
                dind = new int[3] { 63, 87, cnt };
                if (cnt != 87)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 63)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_43_68()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_43(4)68(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[43], Des[68], Des[cnt] };
                dind = new int[3] { 43, 68, cnt };
                if (cnt != 68)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 43)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_70_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_70(4)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[70], Des[114], Des[cnt] };
                dind = new int[3] { 70, 114, cnt };

                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 70)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 114)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_31_70()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_31(4)70(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[31], Des[70], Des[cnt] };
                dind = new int[3] { 31, 70, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 70)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_73_132()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_73(4)132(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[73], Des[132], Des[cnt] };
                dind = new int[3] { 73, 132, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 73 && cnt != 132)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_73_87()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 8;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_73(8)87(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[73], Des[87], Des[cnt] };
                dind = new int[3] { 73, 87, cnt };
                if (cnt != 87)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 73)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_6_88()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 8;
            hs[1] = 9;
            fpth = "D:\\ML\\OYTamn\\D3D_6(8)88(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[6], Des[88], Des[cnt] };
                dind = new int[3] { 6, 88, cnt };
                if (cnt != 88)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 6)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_88_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_88(9)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[88], Des[114], Des[cnt] };
                dind = new int[3] { 88, 114, cnt };
                if (cnt != 88)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 114)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_88_92()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_88(4)92(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[88], Des[92], Des[cnt] };
                dind = new int[3] { 88, 92, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 88 && cnt != 92)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_89_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_89(9)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[89], Des[114], Des[cnt] };
                dind = new int[3] { 89, 114, cnt };
                if (cnt != 89)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 114)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_89_123()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_89(9)123(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[89], Des[123], Des[cnt] };
                dind = new int[3] { 89, 123, cnt };
                if (cnt != 89)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 123)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_89_124()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_89(9)124(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[89], Des[124], Des[cnt] };
                dind = new int[3] { 89, 124, cnt };
                if (cnt != 89)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 124)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_11_98()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_11(4)98(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[11], Des[98], Des[cnt] };
                dind = new int[3] { 11, 98, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 11)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 98)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_10_98()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_10(4)98(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[10], Des[98], Des[cnt] };
                dind = new int[3] { 10, 98, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 10)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 98)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_119_100()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_119(4)100(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[119], Des[100], Des[cnt] };
                dind = new int[3] { 119, 100, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 119)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_120_100()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_120(4)100(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[120], Des[100], Des[cnt] };
                dind = new int[3] { 120, 100, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 120)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_144_100()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_144(4)100(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[144], Des[100], Des[cnt] };
                dind = new int[3] { 144, 100, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 144)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_63_100()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_63(4)100(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[63], Des[100], Des[cnt] };
                dind = new int[3] { 63, 100, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 63)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_100_134()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 8;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_100(8)134(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[100], Des[134], Des[cnt] };
                dind = new int[3] { 100, 134, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 134)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_100_137()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 8;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_100(8)137(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[100], Des[137], Des[cnt] };
                dind = new int[3] { 100, 137, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 137)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_26_100()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_26(9)100(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[26], Des[100], Des[cnt] };
                dind = new int[3] { 26, 100, cnt };
                if (cnt != 26)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 100)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_100_123()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 8;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_100(8)123(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[100], Des[123], Des[cnt] };
                dind = new int[3] { 100, 123, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 123)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_100_125()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 8;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_100(8)125(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[100], Des[125], Des[cnt] };
                dind = new int[3] { 100, 125, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 125)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_71_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_71(4)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[71], Des[114], Des[cnt] };
                dind = new int[3] { 71, 114, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 71)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 114)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_68_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_68(9)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[68], Des[114], Des[cnt] };
                dind = new int[3] { 68, 114, cnt };
                if (cnt != 68)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 114)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_87_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_87(9)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[87], Des[114], Des[cnt] };
                dind = new int[3] { 87, 114, cnt };
                if (cnt != 87)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 114)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_33_117()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_33(4)117(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[33], Des[117], Des[cnt] };
                dind = new int[3] { 33, 117, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 33 && cnt != 117)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_33_118()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_33(4)118(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[33], Des[118], Des[cnt] };
                dind = new int[3] { 33, 118, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 33 && cnt != 118)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_100_120()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 8;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_100(8)120(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[100], Des[120], Des[cnt] };
                dind = new int[3] { 100, 120, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 120)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_38_125()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_38(4)125(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[38], Des[125], Des[cnt] };
                dind = new int[3] { 38, 125, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 38)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 125)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_37_125()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_37(4)125(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[37], Des[125], Des[cnt] };
                dind = new int[3] { 37, 125, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 37)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 125)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_99_125()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_99(4)125(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[99], Des[125], Des[cnt] };
                dind = new int[3] { 99, 125, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 99)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 125)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_104_125()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_104(4)125(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[104], Des[125], Des[cnt] };
                dind = new int[3] { 104, 125, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 104)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 125)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_61_125()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_61(9)125(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[61], Des[125], Des[cnt] };
                dind = new int[3] { 61, 125, cnt };
                hs[2] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 61)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 125)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_30_132()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_30(4)132(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[30], Des[132], Des[cnt] };
                dind = new int[3] { 30, 132, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 132)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_31_132()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_31(4)132(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[31], Des[132], Des[cnt] };
                dind = new int[3] { 31, 132, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 132)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_30_133()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_30(4)133(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[30], Des[133], Des[cnt] };
                dind = new int[3] { 30, 133, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 133)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_31_133()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_31(4)133(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[31], Des[133], Des[cnt] };
                dind = new int[3] { 31, 133, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 133)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_73_133()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_73(4)133(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[73], Des[133], Des[cnt] };
                dind = new int[3] { 73, 133, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 73 && cnt != 133)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_91_134()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_91(4)134(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[91], Des[134], Des[cnt] };
                dind = new int[3] { 91, 134, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 91 && cnt != 134)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_74_137()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_74(9)137(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[74], Des[137], Des[cnt] };
                dind = new int[3] { 74, 137, cnt };
                if (cnt != 74)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 137)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_39_137()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 8;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_39(8)137(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[39], Des[137], Des[cnt] };
                dind = new int[3] { 39, 137, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 137)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 39)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_120_139()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 8;
            fpth = "D:\\ML\\OYTamn\\D3D_120(4)139(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[120], Des[139], Des[cnt] };
                dind = new int[3] { 120, 139, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 120)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 139)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_29_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_29(9)144(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[29], Des[144], Des[cnt] };
                dind = new int[3] { 29, 144, cnt };
                if (cnt != 29)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 144)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_74_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 9;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_74(9)144(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[74], Des[144], Des[cnt] };
                dind = new int[3] { 74, 144, cnt };
                if (cnt != 74)
                {
                    hs[2] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 144)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc3D_100_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 8;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_100(8)144(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[100], Des[144], Des[cnt] };
                dind = new int[3] { 100, 144, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 144)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100)
                {
                    hs[2] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc3D_30_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[3];
            hs[0] = 4;
            hs[1] = 4;
            fpth = "D:\\ML\\OYTamn\\D3D_30(4)144(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[3][] { Des[30], Des[144], Des[cnt] };
                dind = new int[3] { 30, 144, cnt };
                hs[2] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[2] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 144)
                {
                    hs[2] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[2] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_5_14_69()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_5(9)14(4)69(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[5], Des[14], Des[69], Des[cnt] };
                dind = new int[4] { 5, 14, 69, cnt };
                if (cnt != 5 && cnt != 69)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 14)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_5_14_57()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_5(9)14(4)57(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[5], Des[14], Des[57], Des[cnt] };
                dind = new int[4] { 5, 14, 57, cnt };
                if (cnt != 5)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 14 && cnt != 57)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_5_14_30()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_5(9)14(8)30(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[5], Des[14], Des[30], Des[cnt] };
                dind = new int[4] { 5, 14, 30, cnt };
                if (cnt != 5)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 14)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_5_17_73()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_5(9)17(4)73(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[5], Des[17], Des[73], Des[cnt] };
                dind = new int[4] { 5, 17, 73, cnt };
                if (cnt != 5)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 17 && cnt != 73)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_5_20_40()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 9;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_5(9)20(9)40(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[5], Des[20], Des[40], Des[cnt] };
                dind = new int[4] { 5, 20, 40, cnt };
                if (cnt != 5 && cnt != 20)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 40)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_5_24_61()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 9;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_5(9)24(9)61(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[5], Des[24], Des[61], Des[cnt] };
                dind = new int[4] { 5, 24, 61, cnt };
                if (cnt != 5 && cnt != 24)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 61)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_10_98_98()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_10(4)98(8)98(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[10], Des[98], Des[98], Des[cnt] };
                dind = new int[4] { 10, 98, 98, cnt };
                if (cnt != 98)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 10)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 98)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_10_98_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_10(4)98(8)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[10], Des[98], Des[114], Des[cnt] };
                dind = new int[4] { 10, 98, 114, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 10)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 98 && cnt != 114)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_10_50_98()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_10(4)50(9)98(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[10], Des[50], Des[98], Des[cnt] };
                dind = new int[4] { 10, 50, 98, cnt };
                if (cnt != 50)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 10)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 98)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_11_52_98()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_11(4)52(9)98(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[11], Des[52], Des[98], Des[cnt] };
                dind = new int[4] { 11, 52, 98, cnt };
                if (cnt != 52)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 11)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 98)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_11_28_98()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_11(4)28(4)98(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[11], Des[28], Des[98], Des[cnt] };
                dind = new int[4] { 11, 28, 98, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 11 && cnt != 28)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 98)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_14_57_68()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_14(4)57(9)68(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[14], Des[57], Des[68], Des[cnt] };
                dind = new int[4] { 14, 57, 68, cnt };
                if (cnt != 57 && cnt != 68)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 14)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_14_46_68()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_14(4)46(9)68(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[14], Des[46], Des[68], Des[cnt] };
                dind = new int[4] { 14, 46, 68, cnt };
                if (cnt != 46 && cnt != 68)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 14)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_14_60_68()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_14(4)60(9)68(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[14], Des[60], Des[68], Des[cnt] };
                dind = new int[4] { 14, 60, 68, cnt };
                if (cnt != 60 && cnt != 68)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 14)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_17_68_73()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_17(4)68(9)73(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[17], Des[68], Des[73], Des[cnt] };
                dind = new int[4] { 17, 68, 73, cnt };
                if (cnt != 68)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 17)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 73)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_23_33_49()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_23(4)33(4)49(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[23], Des[33], Des[49], Des[cnt] };
                dind = new int[4] { 23, 33, 49, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23 && cnt != 33)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 49)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_12_23_40()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_12(4)23(4)40(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[12], Des[23], Des[40], Des[cnt] };
                dind = new int[4] { 12, 23, 40, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 12 && cnt != 23 && cnt != 40)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_23_40_68()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_23(4)40(4)68(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[23], Des[40], Des[68], Des[cnt] };
                dind = new int[4] { 23, 40, 68, cnt };
                if (cnt != 68)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23 && cnt != 40)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_23_40_65()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_23(4)40(4)65(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[23], Des[40], Des[65], Des[cnt] };
                dind = new int[4] { 23, 40, 65, cnt };
                if (cnt != 65)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23 && cnt != 40)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_23_40_41()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_23(4)40(4)41(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[23], Des[40], Des[41], Des[cnt] };
                dind = new int[4] { 23, 40, 41, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23 && cnt != 40)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 41)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_14_23_66()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_14(8)23(4)66(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[14], Des[23], Des[66], Des[cnt] };
                dind = new int[4] { 14, 23, 66, cnt };
                if (cnt != 66)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 14)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_14_23_87()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_14(8)23(4)87(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[14], Des[23], Des[87], Des[cnt] };
                dind = new int[4] { 14, 23, 87, cnt };
                if (cnt != 87)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 14)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_14_23_88()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_14(8)23(4)88(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[14], Des[23], Des[88], Des[cnt] };
                dind = new int[4] { 14, 23, 88, cnt };
                if (cnt != 88)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 14)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_15_23_88()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_15(8)23(4)88(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[15], Des[23], Des[88], Des[cnt] };
                dind = new int[4] { 15, 23, 88, cnt };
                if (cnt != 88)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 15)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_14_23_89()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_14(8)23(4)89(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[14], Des[23], Des[89], Des[cnt] };
                dind = new int[4] { 14, 23, 89, cnt };
                if (cnt != 89)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 14)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_23_39_89()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_23(4)39(8)89(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[23], Des[39], Des[89], Des[cnt] };
                dind = new int[4] { 23, 39, 89, cnt };
                if (cnt != 89)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 39)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_15_23_89()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_15(8)23(4)89(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[15], Des[23], Des[89], Des[cnt] };
                dind = new int[4] { 15, 23, 89, cnt };
                if (cnt != 89)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 15)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_23_39_100()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_23(4)39(4)100(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[23], Des[39], Des[100], Des[cnt] };
                dind = new int[4] { 23, 39, 100, cnt };
                if (cnt != 100)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23 && cnt != 39)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_14_23_100()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_14(8)23(4)100(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[14], Des[23], Des[100], Des[cnt] };
                dind = new int[4] { 14, 23, 100, cnt };
                if (cnt != 100)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 14)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_23_63_100()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_23(4)63(4)100(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[23], Des[63], Des[100], Des[cnt] };
                dind = new int[4] { 23, 63, 100, cnt };
                if (cnt != 100)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23 && cnt != 63)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_23_39_111()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_23(4)39(8)111(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[23], Des[39], Des[111], Des[cnt] };
                dind = new int[4] { 23, 39, 111, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23 && cnt != 111)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 39)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_26_100_120()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_26(9)100(8)120(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[26], Des[100], Des[120], Des[cnt] };
                dind = new int[4] { 26, 100, 120, cnt };
                if (cnt != 26)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 120)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_29_39_86()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_29(4)39(4)86(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[29], Des[39], Des[86], Des[cnt] };
                dind = new int[4] { 29, 39, 86, cnt };
                if (cnt != 86)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 29 && cnt != 39)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_29_39_74()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_29(4)39(4)74(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[29], Des[39], Des[74], Des[cnt] };
                dind = new int[4] { 29, 39, 74, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 29 && cnt != 39)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 74)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_26_29_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 9;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_26(9)29(9)144(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[26], Des[29], Des[144], Des[cnt] };
                dind = new int[4] { 26, 29, 144, cnt };
                if (cnt != 26 && cnt != 29)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 144)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_30_70_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_30(9)70(4)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[30], Des[70], Des[114], Des[cnt] };
                dind = new int[4] { 30, 70, 114, cnt };
                if (cnt != 30)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 70)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 114)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_30_70_44()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_30(4)70(4)44(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[30], Des[70], Des[44], Des[cnt] };
                dind = new int[4] { 30, 70, 44, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 70)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 44)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_30_44_71()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_30(4)44(8)71(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[30], Des[44], Des[71], Des[cnt] };
                dind = new int[4] { 30, 44, 71, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 71)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 44)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_14_30_132()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_14(8)30(4)132(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[14], Des[30], Des[132], Des[cnt] };
                dind = new int[4] { 14, 30, 132, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 132)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 14)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_18_30_132()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_18(8)30(4)132(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[18], Des[30], Des[132], Des[cnt] };
                dind = new int[4] { 18, 30, 132, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 132)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 18)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_30_132_138()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_30(4)132(4)138(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[30], Des[132], Des[138], Des[cnt] };
                dind = new int[4] { 30, 132, 138, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 132)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 138)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_14_30_133()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_14(8)30(4)133(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[14], Des[30], Des[133], Des[cnt] };
                dind = new int[4] { 14, 30, 133, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 133)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 14)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_18_30_134()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_18(8)30(4)134(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[18], Des[30], Des[134], Des[cnt] };
                dind = new int[4] { 18, 30, 134, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 134)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 18)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_30_43_137()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_30(4)43(9)137(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[30], Des[43], Des[137], Des[cnt] };
                dind = new int[4] { 30, 43, 137, cnt };
                if (cnt != 43)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 137)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_18_30_138()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_18(8)30(4)138(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[18], Des[30], Des[138], Des[cnt] };
                dind = new int[4] { 18, 30, 138, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 138)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 18)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_18_30_139()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_18(8)30(4)139(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[18], Des[30], Des[139], Des[cnt] };
                dind = new int[4] { 18, 30, 139, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 139)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 18)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_14_30_139()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_14(8)30(4)139(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[14], Des[30], Des[139], Des[cnt] };
                dind = new int[4] { 14, 30, 139, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 139)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 14)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_18_30_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_18(9)30(4)144(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[18], Des[30], Des[144], Des[cnt] };
                dind = new int[4] { 18, 30, 144, cnt };
                if (cnt != 18)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 144)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_30_60_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_30(4)60(9)144(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[30], Des[60], Des[144], Des[cnt] };
                dind = new int[4] { 30, 60, 144, cnt };
                if (cnt != 60)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 144)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_30_43_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_30(4)43(9)144(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[30], Des[43], Des[144], Des[cnt] };
                dind = new int[4] { 30, 43, 144, cnt };
                if (cnt != 43)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 30 && cnt != 144)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_31_39_86()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_31(4)39(4)86(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[39], Des[86], Des[cnt] };
                dind = new int[4] { 31, 39, 86, cnt };
                if (cnt != 86)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 39)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_5_31_50()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_5(4)31(4)50(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[5], Des[31], Des[50], Des[cnt] };
                dind = new int[4] { 5, 31, 50, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 5 && cnt != 31 && cnt != 50)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_3_31_50()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_3(4)31(4)50(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[3], Des[31], Des[50], Des[cnt] };
                dind = new int[4] { 3, 31, 50, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 3 && cnt != 31 && cnt != 50)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_31_70_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_31(4)70(4)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[70], Des[114], Des[cnt] };
                dind = new int[4] { 31, 70, 114, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 70)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 114)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_31_39_72()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_31(4)39(4)72(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[39], Des[72], Des[cnt] };
                dind = new int[4] { 31, 39, 72, cnt };
                if (cnt != 72)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 39)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_31_32_72()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_31(4)32(4)72(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[32], Des[72], Des[cnt] };
                dind = new int[4] { 31, 32, 72, cnt };
                if (cnt != 72)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 32)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_31_49_73()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_31(4)49(8)73(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[49], Des[73], Des[cnt] };
                dind = new int[4] { 31, 49, 73, cnt };
                if (cnt != 73)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 49)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_31_74_86()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_31(4)74(9)86(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[74], Des[86], Des[cnt] };
                dind = new int[4] { 31, 74, 86, cnt };
                if (cnt != 74 && cnt != 86)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_4_31_132()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_4(9)31(4)132(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[4], Des[31], Des[132], Des[cnt] };
                dind = new int[4] { 4, 31, 132, cnt };
                if (cnt != 4)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 132)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_17_31_132()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_17(8)31(4)132(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[17], Des[31], Des[132], Des[cnt] };
                dind = new int[4] { 17, 31, 132, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 132)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 17)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_4_31_133()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_4(9)31(4)133(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[4], Des[31], Des[133], Des[cnt] };
                dind = new int[4] { 4, 31, 133, cnt };
                if (cnt != 4)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 133)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_14_31_133()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_14(8)31(4)133(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[14], Des[31], Des[133], Des[cnt] };
                dind = new int[4] { 14, 31, 133, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 133)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 14)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_4_31_138()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_4(9)31(4)138(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[4], Des[31], Des[138], Des[cnt] };
                dind = new int[4] { 4, 31, 138, cnt };
                if (cnt != 4)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 138)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_31_50_138()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_31(4)50(8)138(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[50], Des[138], Des[cnt] };
                dind = new int[4] { 31, 50, 138, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 138)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 50)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_4_31_139()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_4(9)31(4)139(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[4], Des[31], Des[139], Des[cnt] };
                dind = new int[4] { 4, 31, 139, cnt };
                if (cnt != 4)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 139)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_31_50_139()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_31(4)50(8)139(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[50], Des[139], Des[cnt] };
                dind = new int[4] { 31, 50, 139, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 139)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 50)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_31_39h_134()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_31(9)39(8)134(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[39], Des[134], Des[cnt] };
                dind = new int[4] { 31, 39, 134, cnt };
                if (cnt != 31)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 134)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 39)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_20_31_134()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 9;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_20(9)31(9)134(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[20], Des[31], Des[134], Des[cnt] };
                dind = new int[4] { 20, 31, 134, cnt };
                if (cnt != 20 && cnt != 31)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 134)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_31_39_137()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_31(9)39(8)137(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[39], Des[137], Des[cnt] };
                dind = new int[4] { 31, 39, 137, cnt };
                if (cnt != 31)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 137)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 39)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_20_31_137()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 9;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_20(9)31(9)137(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[20], Des[31], Des[137], Des[cnt] };
                dind = new int[4] { 20, 31, 137, cnt };
                if (cnt != 20 && cnt != 31)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 137)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_20_31_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 9;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_20(9)31(9)144(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[20], Des[31], Des[144], Des[cnt] };
                dind = new int[4] { 20, 31, 144, cnt };
                if (cnt != 20 && cnt != 31)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 144)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_4_31_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_4(4)31(9)144(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[4], Des[31], Des[144], Des[cnt] };
                dind = new int[4] { 4, 31, 144, cnt };
                if (cnt != 31)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 4 && cnt != 144)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_33_39_49()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_33(4)39(4)49(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[33], Des[39], Des[49], Des[cnt] };
                dind = new int[4] { 33, 39, 49, cnt };
                if (cnt != 49)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 33 && cnt != 39)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_20_33_39()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_20(4)33(4)39(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[20], Des[33], Des[39], Des[cnt] };
                dind = new int[4] { 20, 33, 39, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 20 && cnt != 33 && cnt != 39)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_33_112_117()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_33(4)112(8)117(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[33], Des[112], Des[117], Des[cnt] };
                dind = new int[4] { 33, 112, 117, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 33 && cnt != 117)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 112)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_33_112_118()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_33(4)112(8)118(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[33], Des[112], Des[118], Des[cnt] };
                dind = new int[4] { 33, 112, 118, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 33 && cnt != 118)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 112)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_33_112_120()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_33(4)112(8)120(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[33], Des[112], Des[120], Des[cnt] };
                dind = new int[4] { 33, 112, 120, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 33 && cnt != 120)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 112)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_9_33_134()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_9(8)33(4)134(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[9], Des[33], Des[134], Des[cnt] };
                dind = new int[4] { 9, 33, 134, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 33 && cnt != 134)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 9)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_20_33_134()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_20(9)33(4)134(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[20], Des[33], Des[134], Des[cnt] };
                dind = new int[4] { 20, 33, 134, cnt };
                if (cnt != 20)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 33 && cnt != 134)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_31_38_125()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_31(4)38(4)125(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[38], Des[125], Des[cnt] };
                dind = new int[4] { 31, 38, 125, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 38)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 125)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_39_58_73()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_39(4)58(4)73(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[39], Des[58], Des[73], Des[cnt] };
                dind = new int[4] { 39, 58, 73, cnt };
                if (cnt != 73)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 39 && cnt != 58)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_32_39_58()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_32(9)39(4)58(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[32], Des[39], Des[58], Des[cnt] };
                dind = new int[4] { 32, 39, 58, cnt };
                if (cnt != 32)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 39 && cnt != 58)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_39_58_72()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_39(4)58(4)72(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[39], Des[58], Des[72], Des[cnt] };
                dind = new int[4] { 39, 58, 72, cnt };
                if (cnt != 72)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 39 && cnt != 58)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_39_58_84()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_39(4)58(4)84(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[39], Des[58], Des[84], Des[cnt] };
                dind = new int[4] { 39, 58, 84, cnt };
                if (cnt != 84)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 39 && cnt != 58)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_39_58_99()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_39(4)58(4)99(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[39], Des[58], Des[99], Des[cnt] };
                dind = new int[4] { 39, 58, 99, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 39 && cnt != 58 && cnt != 99)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_30_39_58()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_30(8)39(4)58(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[30], Des[39], Des[58], Des[cnt] };
                dind = new int[4] { 30, 39, 58, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 39 && cnt != 58)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 30)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_39_64_76()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_39(4)64(8)76(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[39], Des[64], Des[76], Des[cnt] };
                dind = new int[4] { 39, 64, 76, cnt };
                if (cnt != 76)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 39)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 64)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_24_39_64()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_24(9)39(4)64(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[24], Des[39], Des[64], Des[cnt] };
                dind = new int[4] { 24, 39, 64, cnt };
                if (cnt != 24)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 39)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 64)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_39_49_64()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_39(4)49(8)64(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[39], Des[49], Des[64], Des[cnt] };
                dind = new int[4] { 39, 49, 64, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 39)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 64 && cnt != 49)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_31_39_88()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_31(4)39(4)88(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[39], Des[88], Des[cnt] };
                dind = new int[4] { 31, 39, 88, cnt };
                if (cnt != 88)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 39)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_31_39d_134()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_31(4)39(4)134(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[39], Des[134], Des[cnt] };
                dind = new int[4] { 31, 39, 134, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 39 && cnt != 134)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_31_39_87()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 8;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_31(9)39(8)87(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[39], Des[87], Des[cnt] };
                dind = new int[4] { 31, 39, 87, cnt };
                if (cnt != 31 && cnt != 87)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 39)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_23_39_87()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_23(4)39(8)87(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[23], Des[39], Des[87], Des[cnt] };
                dind = new int[4] { 23, 39, 87, cnt };
                if (cnt != 87)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 39)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_8_39_87()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_8(4)39(8)87(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[8], Des[39], Des[87], Des[cnt] };
                dind = new int[4] { 8, 39, 87, cnt };
                if (cnt != 87)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 8)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 39)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_39_92_137()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_39(8)92(4)137(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[39], Des[92], Des[137], Des[cnt] };
                dind = new int[4] { 39, 92, 137, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 92 && cnt != 137)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 39)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_40_45_88()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_40(4)45(9)88(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[40], Des[45], Des[88], Des[cnt] };
                dind = new int[4] { 40, 45, 88, cnt };
                if (cnt != 45 && cnt != 88)
                    hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 40)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_18_40_88()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 3;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_18(3)40(4)88(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[18], Des[40], Des[88], Des[cnt] };
                dind = new int[4] { 18, 40, 88, cnt };
                if (cnt != 88)
                    hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 18)
                {
                    hs[3] = 3;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 40)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_40_111_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 9;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_40(9)111(9)144(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[40], Des[111], Des[144], Des[cnt] };
                dind = new int[4] { 40, 111, 144, cnt };
                if (cnt != 40 && cnt != 111)
                    hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 144)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_2_43_68()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_2(4)43(4)68(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[2], Des[43], Des[68], Des[cnt] };
                dind = new int[4] { 2, 43, 68, cnt };
                if (cnt != 68)
                    hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 2 && cnt != 43)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_49_58_73()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_49(8)58(4)73(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[49], Des[58], Des[73], Des[cnt] };
                dind = new int[4] { 49, 58, 73, cnt };
                if (cnt != 73)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 58)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 49)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_49_58_139()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_49(8)58(4)139(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[49], Des[58], Des[139], Des[cnt] };
                dind = new int[4] { 49, 58, 139, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 58 && cnt != 139)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 49)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_49_49_58()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_49(4)49(8)58(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[49], Des[49], Des[58], Des[cnt] };
                dind = new int[4] { 49, 49, 58, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 58 && cnt != 49)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 49)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_6_61_68()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_6(4)61(4)68(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[6], Des[61], Des[68], Des[cnt] };
                dind = new int[4] { 6, 61, 68, cnt };
                if (cnt != 68)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 6 && cnt != 61)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_63_73_100()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_63(4)73(4)100(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[63], Des[73], Des[100], Des[cnt] };
                dind = new int[4] { 63, 73, 100, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 63 && cnt != 73)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_10_68_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_10(4)68(9)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[10], Des[68], Des[114], Des[cnt] };
                dind = new int[4] { 10, 68, 114, cnt };
                if (cnt != 68)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 10)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 114)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_29_70_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_29(4)70(4)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[29], Des[70], Des[114], Des[cnt] };
                dind = new int[4] { 20, 70, 114, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 29 && cnt != 70)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 114)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_70_114_139()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_70(4)114(8)139(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[70], Des[114], Des[139], Des[cnt] };
                dind = new int[4] { 70, 114, 139, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 70)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 114 && cnt != 139)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_30_71_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_30(9)71(4)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[30], Des[71], Des[114], Des[cnt] };
                dind = new int[4] { 30, 71, 114, cnt };
                if (cnt != 30)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 71)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 114)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_49_73_87()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 8;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_49(8)73(8)87(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[49], Des[73], Des[87], Des[cnt] };
                dind = new int[4] { 49, 73, 87, cnt };
                if (cnt != 87)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 49 && cnt != 73)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_49_87_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 9;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_49(8)87(9)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[49], Des[87], Des[114], Des[cnt] };
                dind = new int[4] { 49, 87, 114, cnt };
                if (cnt != 87)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 49 && cnt != 114)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_23_87_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_23(4)87(9)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[23], Des[87], Des[114], Des[cnt] };
                dind = new int[4] { 23, 87, 114, cnt };
                if (cnt != 87)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 114)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_49_88_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 9;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_49(8)88(9)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[49], Des[88], Des[114], Des[cnt] };
                dind = new int[4] { 49, 88, 114, cnt };
                if (cnt != 88)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 49 && cnt != 114)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_31_88_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_31(4)88(9)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[88], Des[114], Des[cnt] };
                dind = new int[4] { 31, 88, 114, cnt };
                if (cnt != 88)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 114)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_49_89_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 9;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_49(8)89(9)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[49], Des[89], Des[114], Des[cnt] };
                dind = new int[4] { 49, 89, 114, cnt };
                if (cnt != 89)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 4;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 49 && cnt != 114)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_23_88_114()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_23(4)88(9)114(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[23], Des[88], Des[114], Des[cnt] };
                dind = new int[4] { 23, 88, 114, cnt };
                if (cnt != 88)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 114)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_89_91_123()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_89(9)91(4)123(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[89], Des[91], Des[123], Des[cnt] };
                dind = new int[4] { 89, 91, 123, cnt };
                if (cnt != 89)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 91)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 123)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_14_99_125()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_14(8)99(4)125(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[14], Des[99], Des[125], Des[cnt] };
                dind = new int[4] { 14, 99, 125, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 99)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 14 && cnt != 125)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_11_99_125()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_11(4)99(4)125(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[11], Des[99], Des[125], Des[cnt] };
                dind = new int[4] { 11, 99, 125, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 11 && cnt != 99)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 125)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_49_100_120()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_49(8)100(8)120(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[49], Des[100], Des[120], Des[cnt] };
                dind = new int[4] { 49, 100, 120, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 120)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 49 && cnt != 100)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_73_100_123()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_73(4)100(8)123(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[73], Des[100], Des[123], Des[cnt] };
                dind = new int[4] { 73, 100, 123, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 73 && cnt != 123)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_73_100_125()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_73(4)100(8)125(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[73], Des[100], Des[125], Des[cnt] };
                dind = new int[4] { 73, 100, 125, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 73 && cnt != 125)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_100_114_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_100(8)114(8)144(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[100], Des[114], Des[144], Des[cnt] };
                dind = new int[4] { 100, 114, 144, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 144)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100 && cnt != 114)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_100_119_144()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_100(8)119(4)144(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[100], Des[119], Des[144], Des[cnt] };
                dind = new int[4] { 100, 119, 144, cnt };
                if (cnt != 144)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 119)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_26_100_119()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 9;
            hs[1] = 8;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_26(9)100(8)119(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[26], Des[100], Des[119], Des[cnt] };
                dind = new int[4] { 26, 100, 119, cnt };
                if (cnt != 26)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 119)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 100)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_49_120_139()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 8;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_49(8)120(4)139(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[49], Des[120], Des[139], Des[cnt] };
                dind = new int[4] { 46, 120, 139, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 120)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 49 && cnt != 139)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_23_89_91()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 9;
            hs[2] = 4;
            fpth = "D:\\ML\\OYTamn\\D4D_23(4)89(9)91(4)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[23], Des[89], Des[91], Des[cnt] };
                dind = new int[4] { 23, 89, 91, cnt };
                if (cnt != 89)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 23 && cnt != 91)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAc4D_31_39_61()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 8;
            fpth = "D:\\ML\\OYTamn\\D4D_31(4)39(4)61(8)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[39], Des[61], Des[cnt] };
                dind = new int[4] { 31, 39, 61, cnt };
                hs[3] = 9;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 39)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                if (cnt != 61)
                {
                    hs[3] = 8;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
            }
        }
        static internal void MBAc4D_31_50_86()
        {
            int cnt, cnt2 = 0, GSK = 34340;
            int[] hs, dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            FileInfo fi;
            THLogRgr mod;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            hs = new int[4];
            hs[0] = 4;
            hs[1] = 4;
            hs[2] = 9;
            fpth = "D:\\ML\\OYTamn\\D4D_31(4)50(4)86(9)\\";
            for (cnt = 0; cnt < Des.Length; cnt++)
            {
                desin = new double[4][] { Des[31], Des[50], Des[86], Des[cnt] };
                dind = new int[4] { 31, 50, 86, cnt };
                if (cnt != 86)
                {
                    hs[3] = 9;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 3;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
                if (cnt != 31 && cnt != 50)
                {
                    hs[3] = 4;
                    fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                    mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                    mod.FOpt();
                    cnt2++;
                }
                hs[3] = 8;
                fi = new FileInfo(string.Format("{0}{1}.THLRlog", fpth, cnt2));
                mod = new THLogRgr(Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, 0, null, null, in CT, in fi);
                mod.FOpt();
                cnt2++;
            }
        }
        static internal void MBAcV3D(in int[] hs, in int[] d)
        {
            int GSK = 34340;
            int[] dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            if (!flg)
            {
                Console.WriteLine("Can not read the result file.");
            }
            fpth = string.Format("D:\\ML\\OYTamn\\V3D\\{0}({1}){2}({3}){4}({5})\\", d[0], hs[0], d[1], hs[1], d[2], hs[2]);
            DirectoryInfo di = new DirectoryInfo(fpth);
            if (!di.Exists) di = Directory.CreateDirectory(fpth);
            desin = new double[3][] { Des[d[0]], Des[d[1]], Des[d[2]] };
            dind = new int[3] { d[0], d[1], d[2] };
            flg = THLogRgr.stage7(out msg, Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, in CT, in di);
            if (!flg) Console.WriteLine(msg);
        }
        static internal void MBAcV4D(in int[] hs, in int[] d)
        {
            int GSK = 34340;
            int[] dind;
            double dtemp, xxl = 0.034;
            double CT = 0.025;
            double[] lrhp = new double[2] { 1.0, 1.0 };
            double[] Res;
            double[][] Des, desin;
            string msg, fpth;
            bool flg;
            flg = DataRW.DesR(in ナゾナゾ記述子, out Des);
            if (!flg)
            {
                Console.WriteLine("Can not read the descriptor file.");
                return;
            }
            flg = DataRW.ResR(in 乱数です, out Res, out dtemp);
            if (!flg)
            {
                Console.WriteLine("Can not read the result file.");
            }
            fpth = string.Format("D:\\ML\\OYTamn\\V4D\\{0}({1}){2}({3}){4}({5}){6}({7})\\", d[0], hs[0], d[1], hs[1], d[2], hs[2], d[3], hs[3]);
            DirectoryInfo di = new DirectoryInfo(fpth);
            if (!di.Exists) di = Directory.CreateDirectory(fpth);
            desin = new double[4][] { Des[d[0]], Des[d[1]], Des[d[2]], Des[d[3]] };
            dind = new int[4] { d[0], d[1], d[2], d[3] };
            flg = THLogRgr.stage7(out msg, Res.Length, in desin, in lrhp, in hs, in dind, in xxl, in GSK, in Res, in CT, in di);
            if (!flg) Console.WriteLine(msg);
        }
        static internal void EMtP()
        {
            string msg;
            FileInfo df = new FileInfo("D:\\ML\\OYTamn\\EM\\tD\\Des_Ac1.csv");
            DirectoryInfo di = new DirectoryInfo("D:\\ML\\OYTamn\\EM\\");
            THLogRgr.stage10(out msg, in df, in di);
            Console.WriteLine(msg);
        }
        static internal void EMvP()
        {
            string msg;
            FileInfo df = new FileInfo("D:\\ML\\OYTamn\\EM\\pD\\DPAc1.csv");
            DirectoryInfo di = new DirectoryInfo("D:\\ML\\OYTamn\\EM\\");
            THLogRgr.stage10(out msg, in df, in di);
            Console.WriteLine(msg);
        }
    }
}