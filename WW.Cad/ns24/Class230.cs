﻿// Decompiled with JetBrains decompiler
// Type: ns24.Class230
// Assembly: WW.Cad, Version=4.0.37.140, Culture=neutral, PublicKeyToken=null
// MVID: E8E0F2D4-1D21-41F0-9953-8161CF39F2BE
// Assembly location: C:\Users\MSN99\Desktop\Cleaned\WW.Cad.dll

using ns7;

namespace ns24
{
  internal class Class230 : Class224
  {
    public const string string_4 = "blend_int_cur";
    public const string string_5 = "bldcur";
    private Class686.Class697 class697_0;

    public override string imethod_2(int version)
    {
      return "blend_int_cur";
    }

    public override void imethod_0(Interface8 reader)
    {
      base.imethod_0(reader);
      if (reader.FileFormatVersion < Class250.int_10)
        return;
      this.class697_0 = new Class686.Class697(reader);
    }

    public override void imethod_1(Interface9 writer)
    {
      base.imethod_1(writer);
      if (writer.FileFormatVersion < Class250.int_10)
        return;
      writer.imethod_12((Interface39) this.class697_0);
    }

    protected override int vmethod_0()
    {
      return 20900;
    }
  }
}
