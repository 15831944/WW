﻿// Decompiled with JetBrains decompiler
// Type: ns0.Class72
// Assembly: WW.Pdf, Version=4.0.37.140, Culture=neutral, PublicKeyToken=87d16b8f7b531b65
// MVID: 39BBA07C-9C80-4987-8C90-32F5A6207B92
// Assembly location: C:\Users\MSN99\Desktop\Cleaned\WW.Pdf.dll

using System.Collections.Generic;

namespace ns0
{
  internal class Class72
  {
    private static readonly IDictionary<string, Class72> idictionary_0 = (IDictionary<string, Class72>) new Dictionary<string, Class72>();
    private static readonly int[] int_0 = new int[308]{ 32, 32, 32, 160, 33, 33, 34, 34, 35, 35, 36, 36, 37, 37, 38, 38, 39, 8217, 40, 40, 41, 41, 42, 42, 43, 43, 44, 44, 45, 45, 45, 173, 46, 46, 47, 47, 48, 48, 49, 49, 50, 50, 51, 51, 52, 52, 53, 53, 54, 54, 55, 55, 56, 56, 57, 57, 58, 58, 59, 59, 60, 60, 61, 61, 62, 62, 63, 63, 64, 64, 65, 65, 66, 66, 67, 67, 68, 68, 69, 69, 70, 70, 71, 71, 72, 72, 73, 73, 74, 74, 75, 75, 76, 76, 77, 77, 78, 78, 79, 79, 80, 80, 81, 81, 82, 82, 83, 83, 84, 84, 85, 85, 86, 86, 87, 87, 88, 88, 89, 89, 90, 90, 91, 91, 92, 92, 93, 93, 94, 94, 95, 95, 96, 8216, 97, 97, 98, 98, 99, 99, 100, 100, 101, 101, 102, 102, 103, 103, 104, 104, 105, 105, 106, 106, 107, 107, 108, 108, 109, 109, 110, 110, 111, 111, 112, 112, 113, 113, 114, 114, 115, 115, 116, 116, 117, 117, 118, 118, 119, 119, 120, 120, 121, 121, 122, 122, 123, 123, 124, 124, 125, 125, 126, 126, 161, 161, 162, 162, 163, 163, 164, 8260, 164, 8725, 165, 165, 166, 402, 167, 167, 168, 164, 169, 39, 170, 8220, 171, 171, 172, 8249, 173, 8250, 174, 64257, 175, 64258, 177, 8211, 178, 8224, 179, 8225, 180, 183, 180, 8729, 182, 182, 183, 8226, 184, 8218, 185, 8222, 186, 8221, 187, 187, 188, 8230, 189, 8240, 191, 191, 193, 96, 194, 180, 195, 710, 196, 732, 197, 175, 197, 713, 198, 728, 199, 729, 200, 168, 202, 730, 203, 184, 205, 733, 206, 731, 207, 711, 208, 8212, 225, 198, 227, 170, 232, 321, 233, 216, 234, 338, 235, 186, 241, 230, 245, 305, 248, 322, 249, 248, 250, 339, 251, 223 };
    private static readonly int[] int_1 = new int[410]{ 32, 32, 32, 160, 33, 33, 34, 34, 35, 35, 36, 36, 37, 37, 38, 38, 39, 8217, 40, 40, 41, 41, 42, 42, 43, 43, 44, 44, 45, 8722, 46, 46, 47, 47, 48, 48, 49, 49, 50, 50, 51, 51, 52, 52, 53, 53, 54, 54, 55, 55, 56, 56, 57, 57, 58, 58, 59, 59, 60, 60, 61, 61, 62, 62, 63, 63, 64, 64, 65, 65, 66, 66, 67, 67, 68, 68, 69, 69, 70, 70, 71, 71, 72, 72, 73, 73, 74, 74, 75, 75, 76, 76, 77, 77, 78, 78, 79, 79, 80, 80, 81, 81, 82, 82, 83, 83, 84, 84, 85, 85, 86, 86, 87, 87, 88, 88, 89, 89, 90, 90, 91, 91, 92, 92, 93, 93, 94, 94, 95, 95, 96, 8216, 97, 97, 98, 98, 99, 99, 100, 100, 101, 101, 102, 102, 103, 103, 104, 104, 105, 105, 106, 106, 107, 107, 108, 108, 109, 109, 110, 110, 111, 111, 112, 112, 113, 113, 114, 114, 115, 115, 116, 116, 117, 117, 118, 118, 119, 119, 120, 120, 121, 121, 122, 122, 123, 123, 124, 124, 125, 125, 126, 126, 144, 305, 145, 96, 147, 710, 148, 732, 150, 728, 151, 729, 154, 730, 157, 733, 158, 731, 159, 711, 161, 161, 162, 162, 163, 163, 164, 164, 165, 165, 166, 166, 167, 167, 168, 168, 169, 169, 170, 170, 171, 171, 172, 172, 173, 45, 173, 173, 174, 174, 175, 175, 175, 713, 176, 176, 177, 177, 178, 178, 179, 179, 180, 180, 181, 181, 181, 956, 182, 182, 183, 183, 183, 8729, 184, 184, 185, 185, 186, 186, 187, 187, 188, 188, 189, 189, 190, 190, 191, 191, 192, 192, 193, 193, 194, 194, 195, 195, 196, 196, 197, 197, 198, 198, 199, 199, 200, 200, 201, 201, 202, 202, 203, 203, 204, 204, 205, 205, 206, 206, 207, 207, 208, 208, 209, 209, 210, 210, 211, 211, 212, 212, 213, 213, 214, 214, 215, 215, 216, 216, 217, 217, 218, 218, 219, 219, 220, 220, 221, 221, 222, 222, 223, 223, 224, 224, 225, 225, 226, 226, 227, 227, 228, 228, 229, 229, 230, 230, 231, 231, 232, 232, 233, 233, 234, 234, 235, 235, 236, 236, 237, 237, 238, 238, 239, 239, 240, 240, 241, 241, 242, 242, 243, 243, 244, 244, 245, 245, 246, 246, 247, 247, 248, 248, 249, 249, 250, 250, 251, 251, 252, 252, 253, 253, 254, 254, (int) byte.MaxValue, (int) byte.MaxValue };
    private static readonly int[] int_2 = new int[442]{ 32, 32, 32, 160, 33, 33, 34, 34, 35, 35, 36, 36, 37, 37, 38, 38, 39, 39, 40, 40, 41, 41, 42, 42, 43, 43, 44, 44, 45, 45, 45, 173, 46, 46, 47, 47, 48, 48, 49, 49, 50, 50, 51, 51, 52, 52, 53, 53, 54, 54, 55, 55, 56, 56, 57, 57, 58, 58, 59, 59, 60, 60, 61, 61, 62, 62, 63, 63, 64, 64, 65, 65, 66, 66, 67, 67, 68, 68, 69, 69, 70, 70, 71, 71, 72, 72, 73, 73, 74, 74, 75, 75, 76, 76, 77, 77, 78, 78, 79, 79, 80, 80, 81, 81, 82, 82, 83, 83, 84, 84, 85, 85, 86, 86, 87, 87, 88, 88, 89, 89, 90, 90, 91, 91, 92, 92, 93, 93, 94, 94, 95, 95, 96, 96, 97, 97, 98, 98, 99, 99, 100, 100, 101, 101, 102, 102, 103, 103, 104, 104, 105, 105, 106, 106, 107, 107, 108, 108, 109, 109, 110, 110, 111, 111, 112, 112, 113, 113, 114, 114, 115, 115, 116, 116, 117, 117, 118, 118, 119, 119, 120, 120, 121, 121, 122, 122, 123, 123, 124, 124, 125, 125, 126, 126, 130, 8218, 132, 8222, 133, 8230, 134, 8224, 135, 8225, 137, 8240, 138, 352, 139, 8249, 140, 346, 141, 356, 142, 381, 143, 377, 145, 8216, 146, 8217, 147, 8220, 148, 8221, 149, 8226, 150, 8211, 151, 8212, 153, 8482, 154, 353, 155, 8250, 156, 347, 157, 357, 158, 382, 159, 378, 161, 711, 162, 728, 163, 321, 164, 164, 165, 260, 166, 166, 167, 167, 168, 168, 169, 169, 170, 536, 171, 171, 172, 172, 174, 174, 175, 379, 176, 176, 177, 177, 178, 731, 179, 322, 180, 180, 181, 181, 181, 956, 182, 182, 183, 183, 183, 8729, 184, 184, 185, 261, 186, 537, 187, 187, 188, 317, 189, 733, 190, 318, 191, 380, 192, 340, 193, 193, 194, 194, 195, 258, 196, 196, 197, 313, 198, 262, 199, 199, 200, 268, 201, 201, 202, 280, 203, 203, 204, 282, 205, 205, 206, 206, 207, 270, 208, 272, 209, 323, 210, 327, 211, 211, 212, 212, 213, 336, 214, 214, 215, 215, 216, 344, 217, 366, 218, 218, 219, 368, 220, 220, 221, 221, 222, 354, 222, 538, 223, 223, 224, 341, 225, 225, 226, 226, 227, 259, 228, 228, 229, 314, 230, 263, 231, 231, 232, 269, 233, 233, 234, 281, 235, 235, 236, 283, 237, 237, 238, 238, 239, 271, 240, 273, 241, 324, 242, 328, 243, 243, 244, 244, 245, 337, 246, 246, 247, 247, 248, 345, 249, 367, 250, 250, 251, 369, 252, 252, 253, 253, 254, 355, 254, 539, (int) byte.MaxValue, 729 };
    private static readonly int[] int_3 = new int[426]{ 32, 32, 32, 160, 33, 33, 34, 34, 35, 35, 36, 36, 37, 37, 38, 38, 39, 39, 40, 40, 41, 41, 42, 42, 43, 43, 44, 44, 45, 45, 45, 173, 46, 46, 47, 47, 48, 48, 49, 49, 50, 50, 51, 51, 52, 52, 53, 53, 54, 54, 55, 55, 56, 56, 57, 57, 58, 58, 59, 59, 60, 60, 61, 61, 62, 62, 63, 63, 64, 64, 65, 65, 66, 66, 67, 67, 68, 68, 69, 69, 70, 70, 71, 71, 72, 72, 73, 73, 74, 74, 75, 75, 76, 76, 77, 77, 78, 78, 79, 79, 80, 80, 81, 81, 82, 82, 83, 83, 84, 84, 85, 85, 86, 86, 87, 87, 88, 88, 89, 89, 90, 90, 91, 91, 92, 92, 93, 93, 94, 94, 95, 95, 96, 96, 97, 97, 98, 98, 99, 99, 100, 100, 101, 101, 102, 102, 103, 103, 104, 104, 105, 105, 106, 106, 107, 107, 108, 108, 109, 109, 110, 110, 111, 111, 112, 112, 113, 113, 114, 114, 115, 115, 116, 116, 117, 117, 118, 118, 119, 119, 120, 120, 121, 121, 123, 123, 124, 124, 125, 125, 126, 126, 128, 196, 129, 197, 130, 199, 131, 201, 132, 209, 133, 214, 134, 220, 135, 225, 136, 224, 137, 226, 138, 228, 139, 227, 140, 229, 141, 231, 142, 233, 143, 232, 144, 234, 145, 235, 146, 237, 147, 236, 148, 238, 149, 239, 150, 241, 151, 243, 152, 242, 153, 244, 154, 246, 155, 245, 156, 250, 157, 249, 158, 251, 159, 252, 160, 8224, 161, 176, 162, 162, 163, 163, 164, 167, 165, 8226, 166, 182, 167, 223, 168, 174, 169, 169, 170, 8482, 171, 180, 172, 168, 174, 198, 175, 216, 177, 177, 181, 181, 181, 956, 187, 170, 188, 186, 190, 230, 191, 248, 192, 191, 193, 161, 194, 172, 196, 402, 199, 171, 200, 187, 201, 8230, 203, 192, 204, 195, 205, 213, 206, 338, 207, 339, 208, 8211, 209, 8212, 210, 8220, 211, 8221, 212, 8216, 213, 8217, 214, 247, 217, 376, 218, 8260, 218, 8725, 219, 164, 220, 8249, 221, 8250, 222, 64257, 223, 64258, 224, 8225, 225, 183, 225, 8729, 226, 8218, 227, 8222, 228, 8240, 229, 194, 230, 202, 231, 193, 232, 203, 233, 200, 234, 205, 235, 206, 236, 207, 237, 204, 238, 211, 239, 212, 241, 210, 242, 218, 243, 219, 244, 217, 245, 305, 246, 710, 247, 732, 248, 175, 248, 713, 249, 728, 250, 729, 251, 730, 252, 184, 253, 733, 254, 731, (int) byte.MaxValue, 711, 216, (int) byte.MaxValue, 180, 165, 122, 122 };
    private static readonly int[] int_4 = new int[442]{ 32, 32, 32, 160, 33, 33, 34, 34, 35, 35, 36, 36, 37, 37, 38, 38, 39, 39, 40, 40, 41, 41, 42, 42, 43, 43, 44, 44, 45, 45, 45, 173, 46, 46, 47, 47, 48, 48, 49, 49, 50, 50, 51, 51, 52, 52, 53, 53, 54, 54, 55, 55, 56, 56, 57, 57, 58, 58, 59, 59, 60, 60, 61, 61, 62, 62, 63, 63, 64, 64, 65, 65, 66, 66, 67, 67, 68, 68, 69, 69, 70, 70, 71, 71, 72, 72, 73, 73, 74, 74, 75, 75, 76, 76, 77, 77, 78, 78, 79, 79, 80, 80, 81, 81, 82, 82, 83, 83, 84, 84, 85, 85, 86, 86, 87, 87, 88, 88, 89, 89, 90, 90, 91, 91, 92, 92, 93, 93, 94, 94, 95, 95, 96, 96, 97, 97, 98, 98, 99, 99, 100, 100, 101, 101, 102, 102, 103, 103, 104, 104, 105, 105, 106, 106, 107, 107, 108, 108, 109, 109, 110, 110, 111, 111, 112, 112, 113, 113, 114, 114, 115, 115, 116, 116, 117, 117, 118, 118, 119, 119, 120, 120, 121, 121, 122, 122, 123, 123, 124, 124, 125, 125, 126, 126, 128, 8364, 130, 8218, 131, 402, 132, 8222, 133, 8230, 134, 8224, 135, 8225, 136, 710, 137, 8240, 138, 352, 139, 8249, 140, 338, 142, 381, 145, 8216, 146, 8217, 147, 8220, 148, 8221, 149, 8226, 150, 8211, 151, 8212, 152, 732, 153, 8482, 154, 353, 155, 8250, 156, 339, 158, 382, 159, 376, 161, 161, 162, 162, 163, 163, 164, 164, 165, 165, 166, 166, 167, 167, 168, 168, 169, 169, 170, 170, 171, 171, 172, 172, 174, 174, 175, 175, 175, 713, 176, 176, 177, 177, 178, 178, 179, 179, 180, 180, 181, 181, 181, 956, 182, 182, 183, 183, 183, 8729, 184, 184, 185, 185, 186, 186, 187, 187, 188, 188, 189, 189, 190, 190, 191, 191, 192, 192, 193, 193, 194, 194, 195, 195, 196, 196, 197, 197, 198, 198, 199, 199, 200, 200, 201, 201, 202, 202, 203, 203, 204, 204, 205, 205, 206, 206, 207, 207, 208, 208, 209, 209, 210, 210, 211, 211, 212, 212, 213, 213, 214, 214, 215, 215, 216, 216, 217, 217, 218, 218, 219, 219, 220, 220, 221, 221, 222, 222, 223, 223, 224, 224, 225, 225, 226, 226, 227, 227, 228, 228, 229, 229, 230, 230, 231, 231, 232, 232, 233, 233, 234, 234, 235, 235, 236, 236, 237, 237, 238, 238, 239, 239, 240, 240, 241, 241, 242, 242, 243, 243, 244, 244, 245, 245, 246, 246, 247, 247, 248, 248, 249, 249, 250, 250, 251, 251, 252, 252, 253, 253, 254, 254, (int) byte.MaxValue, (int) byte.MaxValue };
    private static readonly int[] int_5 = new int[470]{ 24, 728, 25, 711, 26, 710, 27, 729, 28, 733, 29, 731, 30, 730, 31, 732, 32, 32, 32, 160, 33, 33, 34, 34, 35, 35, 36, 36, 37, 37, 38, 38, 39, 39, 40, 40, 41, 41, 42, 42, 43, 43, 44, 44, 45, 45, 45, 173, 46, 46, 47, 47, 48, 48, 49, 49, 50, 50, 51, 51, 52, 52, 53, 53, 54, 54, 55, 55, 56, 56, 57, 57, 58, 58, 59, 59, 60, 60, 61, 61, 62, 62, 63, 63, 64, 64, 65, 65, 66, 66, 67, 67, 68, 68, 69, 69, 70, 70, 71, 71, 72, 72, 73, 73, 74, 74, 75, 75, 76, 76, 77, 77, 78, 78, 79, 79, 80, 80, 81, 81, 82, 82, 83, 83, 84, 84, 85, 85, 86, 86, 87, 87, 88, 88, 89, 89, 90, 90, 91, 91, 92, 92, 93, 93, 94, 94, 95, 95, 96, 96, 97, 97, 98, 98, 99, 99, 100, 100, 101, 101, 102, 102, 103, 103, 104, 104, 105, 105, 106, 106, 107, 107, 108, 108, 109, 109, 110, 110, 111, 111, 112, 112, 113, 113, 114, 114, 115, 115, 116, 116, 117, 117, 118, 118, 119, 119, 120, 120, 121, 121, 122, 122, 123, 123, 124, 124, 125, 125, 126, 126, 128, 8226, 129, 8224, 130, 8225, 131, 8230, 132, 8212, 133, 8211, 134, 402, 135, 8260, 135, 8725, 136, 8249, 137, 8250, 138, 8722, 139, 8240, 140, 8222, 141, 8220, 142, 8221, 143, 8216, 144, 8217, 145, 8218, 146, 8482, 147, 64257, 148, 64258, 149, 321, 150, 338, 151, 352, 152, 376, 153, 381, 154, 305, 155, 322, 156, 339, 157, 353, 158, 382, 160, 8364, 161, 161, 162, 162, 163, 163, 164, 164, 165, 165, 166, 166, 167, 167, 168, 168, 169, 169, 170, 170, 171, 171, 172, 172, 174, 174, 175, 175, 175, 713, 176, 176, 177, 177, 178, 178, 179, 179, 180, 180, 181, 181, 181, 956, 182, 182, 183, 183, 183, 8729, 184, 184, 185, 185, 186, 186, 187, 187, 188, 188, 189, 189, 190, 190, 191, 191, 192, 192, 193, 193, 194, 194, 195, 195, 196, 196, 197, 197, 198, 198, 199, 199, 200, 200, 201, 201, 202, 202, 203, 203, 204, 204, 205, 205, 206, 206, 207, 207, 208, 208, 209, 209, 210, 210, 211, 211, 212, 212, 213, 213, 214, 214, 215, 215, 216, 216, 217, 217, 218, 218, 219, 219, 220, 220, 221, 221, 222, 222, 223, 223, 224, 224, 225, 225, 226, 226, 227, 227, 228, 228, 229, 229, 230, 230, 231, 231, 232, 232, 233, 233, 234, 234, 235, 235, 236, 236, 237, 237, 238, 238, 239, 239, 240, 240, 241, 241, 242, 242, 243, 243, 244, 244, 245, 245, 246, 246, 247, 247, 248, 248, 249, 249, 250, 250, 251, 251, 252, 252, 253, 253, 254, 254, (int) byte.MaxValue, (int) byte.MaxValue };
    private static readonly int[] int_6 = new int[388]{ 32, 32, 32, 160, 33, 33, 34, 8704, 35, 35, 36, 8707, 37, 37, 38, 38, 39, 8715, 40, 40, 41, 41, 42, 8727, 43, 43, 44, 44, 45, 8722, 46, 46, 47, 47, 48, 48, 49, 49, 50, 50, 51, 51, 52, 52, 53, 53, 54, 54, 55, 55, 56, 56, 57, 57, 58, 58, 59, 59, 60, 60, 61, 61, 62, 62, 63, 63, 64, 8773, 65, 913, 66, 914, 67, 935, 68, 8710, 68, 916, 69, 917, 70, 934, 71, 915, 72, 919, 73, 921, 74, 977, 75, 922, 76, 923, 77, 924, 78, 925, 79, 927, 80, 928, 81, 920, 82, 929, 83, 931, 84, 932, 85, 933, 86, 962, 87, 8486, 87, 937, 88, 926, 89, 936, 90, 918, 91, 91, 92, 8756, 93, 93, 94, 8869, 95, 95, 96, 63717, 97, 945, 98, 946, 99, 967, 100, 948, 101, 949, 102, 966, 103, 947, 104, 951, 105, 953, 106, 981, 107, 954, 108, 955, 109, 181, 109, 956, 110, 957, 111, 959, 112, 960, 113, 952, 114, 961, 115, 963, 116, 964, 117, 965, 118, 982, 119, 969, 120, 958, 121, 968, 122, 950, 123, 123, 124, 124, 125, 125, 126, 8764, 160, 8364, 161, 978, 162, 8242, 163, 8804, 164, 8260, 164, 8725, 165, 8734, 166, 402, 167, 9827, 168, 9830, 169, 9829, 170, 9824, 171, 8596, 172, 8592, 173, 8593, 174, 8594, 175, 8595, 176, 176, 177, 177, 178, 8243, 179, 8805, 180, 215, 181, 8733, 182, 8706, 183, 8226, 184, 247, 185, 8800, 186, 8801, 187, 8776, 188, 8230, 189, 63718, 190, 63719, 191, 8629, 192, 8501, 193, 8465, 194, 8476, 195, 8472, 196, 8855, 197, 8853, 198, 8709, 199, 8745, 200, 8746, 201, 8835, 202, 8839, 203, 8836, 204, 8834, 205, 8838, 206, 8712, 207, 8713, 208, 8736, 209, 8711, 210, 63194, 211, 63193, 212, 63195, 213, 8719, 214, 8730, 215, 8901, 216, 172, 217, 8743, 218, 8744, 219, 8660, 220, 8656, 221, 8657, 222, 8658, 223, 8659, 224, 9674, 225, 9001, 226, 63720, 227, 63721, 228, 63722, 229, 8721, 230, 63723, 231, 63724, 232, 63725, 233, 63726, 234, 63727, 235, 63728, 236, 63729, 237, 63730, 238, 63731, 239, 63732, 241, 9002, 242, 8747, 243, 8992, 244, 63733, 245, 8993, 246, 63734, 247, 63735, 248, 63736, 249, 63737, 250, 63738, 251, 63739, 252, 63740, 253, 63741, 254, 63742 };
    private static readonly int[] int_7 = new int[406]{ 32, 32, 32, 160, 33, 9985, 34, 9986, 35, 9987, 36, 9988, 37, 9742, 38, 9990, 39, 9991, 40, 9992, 41, 9993, 42, 9755, 43, 9758, 44, 9996, 45, 9997, 46, 9998, 47, 9999, 48, 10000, 49, 10001, 50, 10002, 51, 10003, 52, 10004, 53, 10005, 54, 10006, 55, 10007, 56, 10008, 57, 10009, 58, 10010, 59, 10011, 60, 10012, 61, 10013, 62, 10014, 63, 10015, 64, 10016, 65, 10017, 66, 10018, 67, 10019, 68, 10020, 69, 10021, 70, 10022, 71, 10023, 72, 9733, 73, 10025, 74, 10026, 75, 10027, 76, 10028, 77, 10029, 78, 10030, 79, 10031, 80, 10032, 81, 10033, 82, 10034, 83, 10035, 84, 10036, 85, 10037, 86, 10038, 87, 10039, 88, 10040, 89, 10041, 90, 10042, 91, 10043, 92, 10044, 93, 10045, 94, 10046, 95, 10047, 96, 10048, 97, 10049, 98, 10050, 99, 10051, 100, 10052, 101, 10053, 102, 10054, 103, 10055, 104, 10056, 105, 10057, 106, 10058, 107, 10059, 108, 9679, 109, 10061, 110, 9632, 111, 10063, 112, 10064, 113, 10065, 114, 10066, 115, 9650, 116, 9660, 117, 9670, 118, 10070, 119, 9687, 120, 10072, 121, 10073, 122, 10074, 123, 10075, 124, 10076, 125, 10077, 126, 10078, 128, 63703, 129, 63704, 130, 63705, 131, 63706, 132, 63707, 133, 63708, 134, 63709, 135, 63710, 136, 63711, 137, 63712, 138, 63713, 139, 63714, 140, 63715, 141, 63716, 161, 10081, 162, 10082, 163, 10083, 164, 10084, 165, 10085, 166, 10086, 167, 10087, 168, 9827, 169, 9830, 170, 9829, 171, 9824, 172, 9312, 173, 9313, 174, 9314, 175, 9315, 176, 9316, 177, 9317, 178, 9318, 179, 9319, 180, 9320, 181, 9321, 182, 10102, 183, 10103, 184, 10104, 185, 10105, 186, 10106, 187, 10107, 188, 10108, 189, 10109, 190, 10110, 191, 10111, 192, 10112, 193, 10113, 194, 10114, 195, 10115, 196, 10116, 197, 10117, 198, 10118, 199, 10119, 200, 10120, 201, 10121, 202, 10122, 203, 10123, 204, 10124, 205, 10125, 206, 10126, 207, 10127, 208, 10128, 209, 10129, 210, 10130, 211, 10131, 212, 10132, 213, 8594, 214, 8596, 215, 8597, 216, 10136, 217, 10137, 218, 10138, 219, 10139, 220, 10140, 221, 10141, 222, 10142, 223, 10143, 224, 10144, 225, 10145, 226, 10146, 227, 10147, 228, 10148, 229, 10149, 230, 10150, 231, 10151, 232, 10152, 233, 10153, 234, 10154, 235, 10155, 236, 10156, 237, 10157, 238, 10158, 239, 10159, 241, 10161, 242, 10162, 243, 10163, 244, 10164, 245, 10165, 246, 10166, 247, 10167, 248, 10168, 249, 10169, 250, 10170, 251, 10171, 252, 10172, 253, 10173, 254, 10174 };
    private readonly string string_0;
    private readonly ushort[] ushort_0;
    private readonly ushort[] ushort_1;
    private readonly ushort[] ushort_2;

    private Class72(string name, int[] table)
    {
      this.string_0 = name;
      int length = 0;
      this.ushort_0 = new ushort[256];
      for (int index = 0; index < table.Length; index += 2)
      {
        if (table[index + 1] < 256)
          this.ushort_0[table[index + 1]] = (ushort) table[index];
        else
          ++length;
      }
      this.ushort_1 = new ushort[length];
      this.ushort_2 = new ushort[length];
      int num = 0;
      for (int index1 = 0; index1 < table.Length; index1 += 2)
      {
        char ch = (char) table[index1 + 1];
        if (ch >= 'Ā')
        {
          ++num;
          for (int index2 = num - 1; index2 >= 0; --index2)
          {
            if (index2 > 0 && (int) this.ushort_1[index2 - 1] >= (int) ch)
            {
              this.ushort_1[index2] = this.ushort_1[index2 - 1];
              this.ushort_2[index2] = this.ushort_2[index2 - 1];
            }
            else
            {
              this.ushort_1[index2] = (ushort) ch;
              this.ushort_2[index2] = (ushort) table[index1];
              break;
            }
          }
        }
      }
    }

    public ushort method_0(char c)
    {
      if (c < 'Ā')
        return this.ushort_0[(int) c];
      int num1 = 0;
      int num2 = this.ushort_1.Length - 1;
      while (num2 >= num1)
      {
        int index = (num1 + num2) / 2;
        ushort num3 = this.ushort_1[index];
        if ((int) c == (int) num3)
          return this.ushort_2[index];
        if ((int) c < (int) num3)
          num2 = index - 1;
        else
          num1 = index + 1;
      }
      return 0;
    }

    public string Name
    {
      get
      {
        return this.string_0;
      }
    }

    public static Class72 smethod_0(string encoding)
    {
      return Class72.idictionary_0[encoding];
    }

    static Class72()
    {
      Class72.idictionary_0["StandardEncoding"] = new Class72("StandardEncoding", Class72.int_0);
      Class72.idictionary_0["ISOLatin1Encoding"] = new Class72("ISOLatin1Encoding", Class72.int_1);
      Class72.idictionary_0["CEEncoding"] = new Class72("CEEncoding", Class72.int_2);
      Class72.idictionary_0["MacRomanEncoding"] = new Class72("MacRomanEncoding", Class72.int_3);
      Class72.idictionary_0["WinAnsiEncoding"] = new Class72("WinAnsiEncoding", Class72.int_4);
      Class72.idictionary_0["PDFDocEncoding"] = new Class72("PDFDocEncoding", Class72.int_5);
      Class72.idictionary_0["SymbolEncoding"] = new Class72("SymbolEncoding", Class72.int_6);
      Class72.idictionary_0["ZapfDingbatsEncoding"] = new Class72("ZapfDingbatsEncoding", Class72.int_7);
    }
  }
}