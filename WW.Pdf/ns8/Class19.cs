﻿// Decompiled with JetBrains decompiler
// Type: ns8.Class19
// Assembly: WW.Pdf, Version=4.0.37.140, Culture=neutral, PublicKeyToken=87d16b8f7b531b65
// MVID: 39BBA07C-9C80-4987-8C90-32F5A6207B92
// Assembly location: C:\Users\MSN99\Desktop\Cleaned\WW.Pdf.dll

using ns0;
using ns4;

namespace ns8
{
  internal class Class19 : Class14
  {
    private static readonly Class72 class72_1 = Class72.smethod_0("WinAnsiEncoding");
    private static readonly int[] int_6 = new int[256];

    public Class19()
      : base("Times-Roman", 662, 683, -217, 32, (int) byte.MaxValue, Class19.int_6, Class19.class72_1)
    {
    }

    static Class19()
    {
      Class19.int_6[65] = 722;
      Class19.int_6[198] = 889;
      Class19.int_6[193] = 722;
      Class19.int_6[194] = 722;
      Class19.int_6[196] = 722;
      Class19.int_6[192] = 722;
      Class19.int_6[197] = 722;
      Class19.int_6[195] = 722;
      Class19.int_6[66] = 667;
      Class19.int_6[67] = 667;
      Class19.int_6[199] = 667;
      Class19.int_6[68] = 722;
      Class19.int_6[69] = 611;
      Class19.int_6[201] = 611;
      Class19.int_6[202] = 611;
      Class19.int_6[203] = 611;
      Class19.int_6[200] = 611;
      Class19.int_6[208] = 722;
      Class19.int_6[128] = 500;
      Class19.int_6[70] = 556;
      Class19.int_6[71] = 722;
      Class19.int_6[72] = 722;
      Class19.int_6[73] = 333;
      Class19.int_6[205] = 333;
      Class19.int_6[206] = 333;
      Class19.int_6[207] = 333;
      Class19.int_6[204] = 333;
      Class19.int_6[74] = 389;
      Class19.int_6[75] = 722;
      Class19.int_6[76] = 611;
      Class19.int_6[77] = 889;
      Class19.int_6[78] = 722;
      Class19.int_6[209] = 722;
      Class19.int_6[79] = 722;
      Class19.int_6[140] = 889;
      Class19.int_6[211] = 722;
      Class19.int_6[212] = 722;
      Class19.int_6[214] = 722;
      Class19.int_6[210] = 722;
      Class19.int_6[216] = 722;
      Class19.int_6[213] = 722;
      Class19.int_6[80] = 556;
      Class19.int_6[81] = 722;
      Class19.int_6[82] = 667;
      Class19.int_6[83] = 556;
      Class19.int_6[138] = 556;
      Class19.int_6[84] = 611;
      Class19.int_6[222] = 556;
      Class19.int_6[85] = 722;
      Class19.int_6[218] = 722;
      Class19.int_6[219] = 722;
      Class19.int_6[220] = 722;
      Class19.int_6[217] = 722;
      Class19.int_6[86] = 722;
      Class19.int_6[87] = 944;
      Class19.int_6[88] = 722;
      Class19.int_6[89] = 722;
      Class19.int_6[221] = 722;
      Class19.int_6[159] = 722;
      Class19.int_6[90] = 611;
      Class19.int_6[97] = 444;
      Class19.int_6[225] = 444;
      Class19.int_6[226] = 444;
      Class19.int_6[180] = 333;
      Class19.int_6[228] = 444;
      Class19.int_6[230] = 667;
      Class19.int_6[224] = 444;
      Class19.int_6[38] = 778;
      Class19.int_6[229] = 444;
      Class19.int_6[94] = 469;
      Class19.int_6[126] = 541;
      Class19.int_6[42] = 500;
      Class19.int_6[64] = 921;
      Class19.int_6[227] = 444;
      Class19.int_6[98] = 500;
      Class19.int_6[92] = 278;
      Class19.int_6[124] = 200;
      Class19.int_6[123] = 480;
      Class19.int_6[125] = 480;
      Class19.int_6[91] = 333;
      Class19.int_6[93] = 333;
      Class19.int_6[166] = 200;
      Class19.int_6[149] = 350;
      Class19.int_6[99] = 444;
      Class19.int_6[231] = 444;
      Class19.int_6[184] = 333;
      Class19.int_6[162] = 500;
      Class19.int_6[136] = 333;
      Class19.int_6[58] = 278;
      Class19.int_6[44] = 250;
      Class19.int_6[169] = 760;
      Class19.int_6[164] = 500;
      Class19.int_6[100] = 500;
      Class19.int_6[134] = 500;
      Class19.int_6[135] = 500;
      Class19.int_6[176] = 400;
      Class19.int_6[168] = 333;
      Class19.int_6[247] = 564;
      Class19.int_6[36] = 500;
      Class19.int_6[101] = 444;
      Class19.int_6[233] = 444;
      Class19.int_6[234] = 444;
      Class19.int_6[235] = 444;
      Class19.int_6[232] = 444;
      Class19.int_6[56] = 500;
      Class19.int_6[133] = 1000;
      Class19.int_6[151] = 1000;
      Class19.int_6[150] = 500;
      Class19.int_6[61] = 564;
      Class19.int_6[240] = 500;
      Class19.int_6[33] = 333;
      Class19.int_6[161] = 333;
      Class19.int_6[102] = 333;
      Class19.int_6[53] = 500;
      Class19.int_6[131] = 500;
      Class19.int_6[52] = 500;
      Class19.int_6[164] = 167;
      Class19.int_6[103] = 500;
      Class19.int_6[223] = 500;
      Class19.int_6[96] = 333;
      Class19.int_6[62] = 564;
      Class19.int_6[171] = 500;
      Class19.int_6[187] = 500;
      Class19.int_6[139] = 333;
      Class19.int_6[155] = 333;
      Class19.int_6[104] = 500;
      Class19.int_6[45] = 333;
      Class19.int_6[105] = 278;
      Class19.int_6[237] = 278;
      Class19.int_6[238] = 278;
      Class19.int_6[239] = 278;
      Class19.int_6[236] = 278;
      Class19.int_6[106] = 278;
      Class19.int_6[107] = 500;
      Class19.int_6[108] = 278;
      Class19.int_6[60] = 564;
      Class19.int_6[172] = 564;
      Class19.int_6[109] = 778;
      Class19.int_6[175] = 333;
      Class19.int_6[45] = 324;
      Class19.int_6[181] = 500;
      Class19.int_6[215] = 564;
      Class19.int_6[110] = 500;
      Class19.int_6[57] = 500;
      Class19.int_6[241] = 500;
      Class19.int_6[35] = 500;
      Class19.int_6[111] = 500;
      Class19.int_6[243] = 500;
      Class19.int_6[244] = 500;
      Class19.int_6[246] = 500;
      Class19.int_6[156] = 722;
      Class19.int_6[242] = 500;
      Class19.int_6[49] = 500;
      Class19.int_6[189] = 750;
      Class19.int_6[188] = 750;
      Class19.int_6[185] = 300;
      Class19.int_6[170] = 276;
      Class19.int_6[186] = 310;
      Class19.int_6[248] = 500;
      Class19.int_6[245] = 500;
      Class19.int_6[112] = 500;
      Class19.int_6[182] = 453;
      Class19.int_6[40] = 333;
      Class19.int_6[41] = 333;
      Class19.int_6[37] = 833;
      Class19.int_6[46] = 250;
      Class19.int_6[183] = 250;
      Class19.int_6[137] = 1000;
      Class19.int_6[43] = 564;
      Class19.int_6[177] = 564;
      Class19.int_6[113] = 500;
      Class19.int_6[63] = 444;
      Class19.int_6[191] = 444;
      Class19.int_6[34] = 408;
      Class19.int_6[132] = 444;
      Class19.int_6[147] = 444;
      Class19.int_6[148] = 444;
      Class19.int_6[145] = 333;
      Class19.int_6[146] = 333;
      Class19.int_6[130] = 333;
      Class19.int_6[39] = 180;
      Class19.int_6[114] = 333;
      Class19.int_6[174] = 760;
      Class19.int_6[115] = 389;
      Class19.int_6[154] = 389;
      Class19.int_6[167] = 500;
      Class19.int_6[59] = 278;
      Class19.int_6[55] = 500;
      Class19.int_6[54] = 500;
      Class19.int_6[47] = 278;
      Class19.int_6[32] = 250;
      Class19.int_6[160] = 250;
      Class19.int_6[163] = 500;
      Class19.int_6[116] = 278;
      Class19.int_6[254] = 500;
      Class19.int_6[51] = 500;
      Class19.int_6[190] = 750;
      Class19.int_6[179] = 300;
      Class19.int_6[152] = 333;
      Class19.int_6[153] = 980;
      Class19.int_6[50] = 500;
      Class19.int_6[178] = 300;
      Class19.int_6[117] = 500;
      Class19.int_6[250] = 500;
      Class19.int_6[251] = 500;
      Class19.int_6[252] = 500;
      Class19.int_6[249] = 500;
      Class19.int_6[95] = 500;
      Class19.int_6[118] = 500;
      Class19.int_6[119] = 722;
      Class19.int_6[120] = 500;
      Class19.int_6[121] = 500;
      Class19.int_6[253] = 500;
      Class19.int_6[(int) byte.MaxValue] = 500;
      Class19.int_6[165] = 500;
      Class19.int_6[122] = 444;
      Class19.int_6[48] = 500;
    }
  }
}