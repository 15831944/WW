﻿// Decompiled with JetBrains decompiler
// Type: WW.Pdf.IFilter
// Assembly: WW.Pdf, Version=4.0.37.140, Culture=neutral, PublicKeyToken=87d16b8f7b531b65
// MVID: 39BBA07C-9C80-4987-8C90-32F5A6207B92
// Assembly location: C:\Users\MSN99\Desktop\Cleaned\WW.Pdf.dll

namespace WW.Pdf
{
  public interface IFilter
  {
    IPdfObject Name { get; }

    IPdfObject DecodeParameters { get; }

    bool HasDecodeParameters { get; }

    byte[] Encode(byte[] data);
  }
}