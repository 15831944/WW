﻿// Decompiled with JetBrains decompiler
// Type: ns13.Class136
// Assembly: WW.Cad, Version=4.0.37.140, Culture=neutral, PublicKeyToken=null
// MVID: E8E0F2D4-1D21-41F0-9953-8161CF39F2BE
// Assembly location: C:\Users\MSN99\Desktop\Cleaned\WW.Cad.dll

using ns7;

namespace ns13
{
  internal class Class136 : Class134
  {
    public const string string_4 = "aggregate_sharped_attribute-aggregate_geombuild_base_attribute-aggregate_body_attribute-attrib_HH-attrib";
    private Class686.Class688 class688_0;

    public override string imethod_2(int version)
    {
      return "aggregate_sharped_attribute-aggregate_geombuild_base_attribute-aggregate_body_attribute-attrib_HH-attrib";
    }

    internal override void vmethod_0(Interface8 reader)
    {
      base.vmethod_0(reader);
      reader.imethod_13((Interface39) this.class688_0);
    }

    internal override void vmethod_1(Interface9 writer)
    {
      base.vmethod_1(writer);
      writer.imethod_12((Interface39) this.class688_0);
    }
  }
}
