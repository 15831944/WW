﻿// Decompiled with JetBrains decompiler
// Type: ns24.Class231
// Assembly: WW.Cad, Version=4.0.37.140, Culture=neutral, PublicKeyToken=null
// MVID: E8E0F2D4-1D21-41F0-9953-8161CF39F2BE
// Assembly location: C:\Users\MSN99\Desktop\Cleaned\WW.Cad.dll

using ns7;

namespace ns24
{
  internal class Class231 : Class224
  {
    public const string string_4 = "off_int_cur";
    public const string string_5 = "offintcur";
    private double double_2;
    private double double_3;

    public override string imethod_2(int version)
    {
      return "off_int_cur";
    }

    public override void imethod_0(Interface8 reader)
    {
      base.imethod_0(reader);
      this.double_2 = reader.imethod_8();
      this.double_3 = reader.imethod_8();
    }

    public override void imethod_1(Interface9 writer)
    {
      base.imethod_1(writer);
      writer.imethod_7(this.double_2);
      writer.imethod_7(this.double_3);
    }

    protected override int vmethod_0()
    {
      return 20900;
    }
  }
}
