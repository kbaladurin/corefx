﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// This file has been auto-generated. Do not edit by hand.
// Instead open Developer Command prompt and run: TextTransform FileName.tt
// Or set AllowTlsCipherSuiteGeneration=true and open VS and edit there directly

// This line is needed so that file compiles both as a T4 template and C# file<#+

#if PRODUCT
namespace System.Net.Security
{
#endif
    [CLSCompliant(false)]
    public enum TlsCipherSuite : ushort
    {
        TLS_NULL_WITH_NULL_NULL = 0x0000, // rfc5246
        TLS_RSA_WITH_NULL_MD5 = 0x0001, // rfc5246
        TLS_RSA_WITH_NULL_SHA = 0x0002, // rfc5246
        TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 0x0003, // rfc4346, rfc6347
        TLS_RSA_WITH_RC4_128_MD5 = 0x0004, // rfc5246, rfc6347
        TLS_RSA_WITH_RC4_128_SHA = 0x0005, // rfc5246, rfc6347
        TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 0x0006, // rfc4346
        TLS_RSA_WITH_IDEA_CBC_SHA = 0x0007, // rfc5469
        TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 0x0008, // rfc4346
        TLS_RSA_WITH_DES_CBC_SHA = 0x0009, // rfc5469
        TLS_RSA_WITH_3DES_EDE_CBC_SHA = 0x000A, // rfc5246
        TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 0x000B, // rfc4346
        TLS_DH_DSS_WITH_DES_CBC_SHA = 0x000C, // rfc5469
        TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 0x000D, // rfc5246
        TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 0x000E, // rfc4346
        TLS_DH_RSA_WITH_DES_CBC_SHA = 0x000F, // rfc5469
        TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 0x0010, // rfc5246
        TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 0x0011, // rfc4346
        TLS_DHE_DSS_WITH_DES_CBC_SHA = 0x0012, // rfc5469
        TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 0x0013, // rfc5246
        TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 0x0014, // rfc4346
        TLS_DHE_RSA_WITH_DES_CBC_SHA = 0x0015, // rfc5469
        TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 0x0016, // rfc5246
        TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 0x0017, // rfc4346, rfc6347
        TLS_DH_anon_WITH_RC4_128_MD5 = 0x0018, // rfc5246, rfc6347
        TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 0x0019, // rfc4346
        TLS_DH_anon_WITH_DES_CBC_SHA = 0x001A, // rfc5469
        TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 0x001B, // rfc5246
        TLS_KRB5_WITH_DES_CBC_SHA = 0x001E, // rfc2712
        TLS_KRB5_WITH_3DES_EDE_CBC_SHA = 0x001F, // rfc2712
        TLS_KRB5_WITH_RC4_128_SHA = 0x0020, // rfc2712, rfc6347
        TLS_KRB5_WITH_IDEA_CBC_SHA = 0x0021, // rfc2712
        TLS_KRB5_WITH_DES_CBC_MD5 = 0x0022, // rfc2712
        TLS_KRB5_WITH_3DES_EDE_CBC_MD5 = 0x0023, // rfc2712
        TLS_KRB5_WITH_RC4_128_MD5 = 0x0024, // rfc2712, rfc6347
        TLS_KRB5_WITH_IDEA_CBC_MD5 = 0x0025, // rfc2712
        TLS_KRB5_EXPORT_WITH_DES_CBC_40_SHA = 0x0026, // rfc2712
        TLS_KRB5_EXPORT_WITH_RC2_CBC_40_SHA = 0x0027, // rfc2712
        TLS_KRB5_EXPORT_WITH_RC4_40_SHA = 0x0028, // rfc2712, rfc6347
        TLS_KRB5_EXPORT_WITH_DES_CBC_40_MD5 = 0x0029, // rfc2712
        TLS_KRB5_EXPORT_WITH_RC2_CBC_40_MD5 = 0x002A, // rfc2712
        TLS_KRB5_EXPORT_WITH_RC4_40_MD5 = 0x002B, // rfc2712, rfc6347
        TLS_PSK_WITH_NULL_SHA = 0x002C, // rfc4785
        TLS_DHE_PSK_WITH_NULL_SHA = 0x002D, // rfc4785
        TLS_RSA_PSK_WITH_NULL_SHA = 0x002E, // rfc4785
        TLS_RSA_WITH_AES_128_CBC_SHA = 0x002F, // rfc5246
        TLS_DH_DSS_WITH_AES_128_CBC_SHA = 0x0030, // rfc5246
        TLS_DH_RSA_WITH_AES_128_CBC_SHA = 0x0031, // rfc5246
        TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 0x0032, // rfc5246
        TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 0x0033, // rfc5246
        TLS_DH_anon_WITH_AES_128_CBC_SHA = 0x0034, // rfc5246
        TLS_RSA_WITH_AES_256_CBC_SHA = 0x0035, // rfc5246
        TLS_DH_DSS_WITH_AES_256_CBC_SHA = 0x0036, // rfc5246
        TLS_DH_RSA_WITH_AES_256_CBC_SHA = 0x0037, // rfc5246
        TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 0x0038, // rfc5246
        TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 0x0039, // rfc5246
        TLS_DH_anon_WITH_AES_256_CBC_SHA = 0x003A, // rfc5246
        TLS_RSA_WITH_NULL_SHA256 = 0x003B, // rfc5246
        TLS_RSA_WITH_AES_128_CBC_SHA256 = 0x003C, // rfc5246
        TLS_RSA_WITH_AES_256_CBC_SHA256 = 0x003D, // rfc5246
        TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 0x003E, // rfc5246
        TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 0x003F, // rfc5246
        TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 0x0040, // rfc5246
        TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 0x0041, // rfc5932
        TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 0x0042, // rfc5932
        TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 0x0043, // rfc5932
        TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 0x0044, // rfc5932
        TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 0x0045, // rfc5932
        TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 0x0046, // rfc5932
        TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 0x0067, // rfc5246
        TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 0x0068, // rfc5246
        TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 0x0069, // rfc5246
        TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 0x006A, // rfc5246
        TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 0x006B, // rfc5246
        TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 0x006C, // rfc5246
        TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 0x006D, // rfc5246
        TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 0x0084, // rfc5932
        TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 0x0085, // rfc5932
        TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 0x0086, // rfc5932
        TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 0x0087, // rfc5932
        TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 0x0088, // rfc5932
        TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 0x0089, // rfc5932
        TLS_PSK_WITH_RC4_128_SHA = 0x008A, // rfc4279, rfc6347
        TLS_PSK_WITH_3DES_EDE_CBC_SHA = 0x008B, // rfc4279
        TLS_PSK_WITH_AES_128_CBC_SHA = 0x008C, // rfc4279
        TLS_PSK_WITH_AES_256_CBC_SHA = 0x008D, // rfc4279
        TLS_DHE_PSK_WITH_RC4_128_SHA = 0x008E, // rfc4279, rfc6347
        TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 0x008F, // rfc4279
        TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 0x0090, // rfc4279
        TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 0x0091, // rfc4279
        TLS_RSA_PSK_WITH_RC4_128_SHA = 0x0092, // rfc4279, rfc6347
        TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 0x0093, // rfc4279
        TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 0x0094, // rfc4279
        TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 0x0095, // rfc4279
        TLS_RSA_WITH_SEED_CBC_SHA = 0x0096, // rfc4162
        TLS_DH_DSS_WITH_SEED_CBC_SHA = 0x0097, // rfc4162
        TLS_DH_RSA_WITH_SEED_CBC_SHA = 0x0098, // rfc4162
        TLS_DHE_DSS_WITH_SEED_CBC_SHA = 0x0099, // rfc4162
        TLS_DHE_RSA_WITH_SEED_CBC_SHA = 0x009A, // rfc4162
        TLS_DH_anon_WITH_SEED_CBC_SHA = 0x009B, // rfc4162
        TLS_RSA_WITH_AES_128_GCM_SHA256 = 0x009C, // rfc5288
        TLS_RSA_WITH_AES_256_GCM_SHA384 = 0x009D, // rfc5288
        TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 0x009E, // rfc5288
        TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 0x009F, // rfc5288
        TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 0x00A0, // rfc5288
        TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 0x00A1, // rfc5288
        TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 0x00A2, // rfc5288
        TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 0x00A3, // rfc5288
        TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 0x00A4, // rfc5288
        TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 0x00A5, // rfc5288
        TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 0x00A6, // rfc5288
        TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 0x00A7, // rfc5288
        TLS_PSK_WITH_AES_128_GCM_SHA256 = 0x00A8, // rfc5487
        TLS_PSK_WITH_AES_256_GCM_SHA384 = 0x00A9, // rfc5487
        TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 0x00AA, // rfc5487
        TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 0x00AB, // rfc5487
        TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 0x00AC, // rfc5487
        TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 0x00AD, // rfc5487
        TLS_PSK_WITH_AES_128_CBC_SHA256 = 0x00AE, // rfc5487
        TLS_PSK_WITH_AES_256_CBC_SHA384 = 0x00AF, // rfc5487
        TLS_PSK_WITH_NULL_SHA256 = 0x00B0, // rfc5487
        TLS_PSK_WITH_NULL_SHA384 = 0x00B1, // rfc5487
        TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 0x00B2, // rfc5487
        TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 0x00B3, // rfc5487
        TLS_DHE_PSK_WITH_NULL_SHA256 = 0x00B4, // rfc5487
        TLS_DHE_PSK_WITH_NULL_SHA384 = 0x00B5, // rfc5487
        TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 0x00B6, // rfc5487
        TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 0x00B7, // rfc5487
        TLS_RSA_PSK_WITH_NULL_SHA256 = 0x00B8, // rfc5487
        TLS_RSA_PSK_WITH_NULL_SHA384 = 0x00B9, // rfc5487
        TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 0x00BA, // rfc5932
        TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 0x00BB, // rfc5932
        TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 0x00BC, // rfc5932
        TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 0x00BD, // rfc5932
        TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 0x00BE, // rfc5932
        TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 0x00BF, // rfc5932
        TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 0x00C0, // rfc5932
        TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 0x00C1, // rfc5932
        TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 0x00C2, // rfc5932
        TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 0x00C3, // rfc5932
        TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 0x00C4, // rfc5932
        TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 0x00C5, // rfc5932
        TLS_AES_128_GCM_SHA256 = 0x1301, // rfc8446
        TLS_AES_256_GCM_SHA384 = 0x1302, // rfc8446
        TLS_CHACHA20_POLY1305_SHA256 = 0x1303, // rfc8446
        TLS_AES_128_CCM_SHA256 = 0x1304, // rfc8446
        TLS_AES_128_CCM_8_SHA256 = 0x1305, // rfc8446
        TLS_ECDH_ECDSA_WITH_NULL_SHA = 0xC001, // rfc8422
        TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 0xC002, // rfc8422, rfc6347
        TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 0xC003, // rfc8422
        TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 0xC004, // rfc8422
        TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 0xC005, // rfc8422
        TLS_ECDHE_ECDSA_WITH_NULL_SHA = 0xC006, // rfc8422
        TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 0xC007, // rfc8422, rfc6347
        TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 0xC008, // rfc8422
        TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 0xC009, // rfc8422
        TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 0xC00A, // rfc8422
        TLS_ECDH_RSA_WITH_NULL_SHA = 0xC00B, // rfc8422
        TLS_ECDH_RSA_WITH_RC4_128_SHA = 0xC00C, // rfc8422, rfc6347
        TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 0xC00D, // rfc8422
        TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 0xC00E, // rfc8422
        TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 0xC00F, // rfc8422
        TLS_ECDHE_RSA_WITH_NULL_SHA = 0xC010, // rfc8422
        TLS_ECDHE_RSA_WITH_RC4_128_SHA = 0xC011, // rfc8422, rfc6347
        TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 0xC012, // rfc8422
        TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 0xC013, // rfc8422
        TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 0xC014, // rfc8422
        TLS_ECDH_anon_WITH_NULL_SHA = 0xC015, // rfc8422
        TLS_ECDH_anon_WITH_RC4_128_SHA = 0xC016, // rfc8422, rfc6347
        TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 0xC017, // rfc8422
        TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 0xC018, // rfc8422
        TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 0xC019, // rfc8422
        TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 0xC01A, // rfc5054
        TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 0xC01B, // rfc5054
        TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 0xC01C, // rfc5054
        TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 0xC01D, // rfc5054
        TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 0xC01E, // rfc5054
        TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 0xC01F, // rfc5054
        TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 0xC020, // rfc5054
        TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 0xC021, // rfc5054
        TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 0xC022, // rfc5054
        TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 0xC023, // rfc5289
        TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 0xC024, // rfc5289
        TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 0xC025, // rfc5289
        TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 0xC026, // rfc5289
        TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 0xC027, // rfc5289
        TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 0xC028, // rfc5289
        TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 0xC029, // rfc5289
        TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 0xC02A, // rfc5289
        TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 0xC02B, // rfc5289
        TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 0xC02C, // rfc5289
        TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 0xC02D, // rfc5289
        TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 0xC02E, // rfc5289
        TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 0xC02F, // rfc5289
        TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 0xC030, // rfc5289
        TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 0xC031, // rfc5289
        TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 0xC032, // rfc5289
        TLS_ECDHE_PSK_WITH_RC4_128_SHA = 0xC033, // rfc5489, rfc6347
        TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 0xC034, // rfc5489
        TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 0xC035, // rfc5489
        TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 0xC036, // rfc5489
        TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 0xC037, // rfc5489
        TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 0xC038, // rfc5489
        TLS_ECDHE_PSK_WITH_NULL_SHA = 0xC039, // rfc5489
        TLS_ECDHE_PSK_WITH_NULL_SHA256 = 0xC03A, // rfc5489
        TLS_ECDHE_PSK_WITH_NULL_SHA384 = 0xC03B, // rfc5489
        TLS_RSA_WITH_ARIA_128_CBC_SHA256 = 0xC03C, // rfc6209
        TLS_RSA_WITH_ARIA_256_CBC_SHA384 = 0xC03D, // rfc6209
        TLS_DH_DSS_WITH_ARIA_128_CBC_SHA256 = 0xC03E, // rfc6209
        TLS_DH_DSS_WITH_ARIA_256_CBC_SHA384 = 0xC03F, // rfc6209
        TLS_DH_RSA_WITH_ARIA_128_CBC_SHA256 = 0xC040, // rfc6209
        TLS_DH_RSA_WITH_ARIA_256_CBC_SHA384 = 0xC041, // rfc6209
        TLS_DHE_DSS_WITH_ARIA_128_CBC_SHA256 = 0xC042, // rfc6209
        TLS_DHE_DSS_WITH_ARIA_256_CBC_SHA384 = 0xC043, // rfc6209
        TLS_DHE_RSA_WITH_ARIA_128_CBC_SHA256 = 0xC044, // rfc6209
        TLS_DHE_RSA_WITH_ARIA_256_CBC_SHA384 = 0xC045, // rfc6209
        TLS_DH_anon_WITH_ARIA_128_CBC_SHA256 = 0xC046, // rfc6209
        TLS_DH_anon_WITH_ARIA_256_CBC_SHA384 = 0xC047, // rfc6209
        TLS_ECDHE_ECDSA_WITH_ARIA_128_CBC_SHA256 = 0xC048, // rfc6209
        TLS_ECDHE_ECDSA_WITH_ARIA_256_CBC_SHA384 = 0xC049, // rfc6209
        TLS_ECDH_ECDSA_WITH_ARIA_128_CBC_SHA256 = 0xC04A, // rfc6209
        TLS_ECDH_ECDSA_WITH_ARIA_256_CBC_SHA384 = 0xC04B, // rfc6209
        TLS_ECDHE_RSA_WITH_ARIA_128_CBC_SHA256 = 0xC04C, // rfc6209
        TLS_ECDHE_RSA_WITH_ARIA_256_CBC_SHA384 = 0xC04D, // rfc6209
        TLS_ECDH_RSA_WITH_ARIA_128_CBC_SHA256 = 0xC04E, // rfc6209
        TLS_ECDH_RSA_WITH_ARIA_256_CBC_SHA384 = 0xC04F, // rfc6209
        TLS_RSA_WITH_ARIA_128_GCM_SHA256 = 0xC050, // rfc6209
        TLS_RSA_WITH_ARIA_256_GCM_SHA384 = 0xC051, // rfc6209
        TLS_DHE_RSA_WITH_ARIA_128_GCM_SHA256 = 0xC052, // rfc6209
        TLS_DHE_RSA_WITH_ARIA_256_GCM_SHA384 = 0xC053, // rfc6209
        TLS_DH_RSA_WITH_ARIA_128_GCM_SHA256 = 0xC054, // rfc6209
        TLS_DH_RSA_WITH_ARIA_256_GCM_SHA384 = 0xC055, // rfc6209
        TLS_DHE_DSS_WITH_ARIA_128_GCM_SHA256 = 0xC056, // rfc6209
        TLS_DHE_DSS_WITH_ARIA_256_GCM_SHA384 = 0xC057, // rfc6209
        TLS_DH_DSS_WITH_ARIA_128_GCM_SHA256 = 0xC058, // rfc6209
        TLS_DH_DSS_WITH_ARIA_256_GCM_SHA384 = 0xC059, // rfc6209
        TLS_DH_anon_WITH_ARIA_128_GCM_SHA256 = 0xC05A, // rfc6209
        TLS_DH_anon_WITH_ARIA_256_GCM_SHA384 = 0xC05B, // rfc6209
        TLS_ECDHE_ECDSA_WITH_ARIA_128_GCM_SHA256 = 0xC05C, // rfc6209
        TLS_ECDHE_ECDSA_WITH_ARIA_256_GCM_SHA384 = 0xC05D, // rfc6209
        TLS_ECDH_ECDSA_WITH_ARIA_128_GCM_SHA256 = 0xC05E, // rfc6209
        TLS_ECDH_ECDSA_WITH_ARIA_256_GCM_SHA384 = 0xC05F, // rfc6209
        TLS_ECDHE_RSA_WITH_ARIA_128_GCM_SHA256 = 0xC060, // rfc6209
        TLS_ECDHE_RSA_WITH_ARIA_256_GCM_SHA384 = 0xC061, // rfc6209
        TLS_ECDH_RSA_WITH_ARIA_128_GCM_SHA256 = 0xC062, // rfc6209
        TLS_ECDH_RSA_WITH_ARIA_256_GCM_SHA384 = 0xC063, // rfc6209
        TLS_PSK_WITH_ARIA_128_CBC_SHA256 = 0xC064, // rfc6209
        TLS_PSK_WITH_ARIA_256_CBC_SHA384 = 0xC065, // rfc6209
        TLS_DHE_PSK_WITH_ARIA_128_CBC_SHA256 = 0xC066, // rfc6209
        TLS_DHE_PSK_WITH_ARIA_256_CBC_SHA384 = 0xC067, // rfc6209
        TLS_RSA_PSK_WITH_ARIA_128_CBC_SHA256 = 0xC068, // rfc6209
        TLS_RSA_PSK_WITH_ARIA_256_CBC_SHA384 = 0xC069, // rfc6209
        TLS_PSK_WITH_ARIA_128_GCM_SHA256 = 0xC06A, // rfc6209
        TLS_PSK_WITH_ARIA_256_GCM_SHA384 = 0xC06B, // rfc6209
        TLS_DHE_PSK_WITH_ARIA_128_GCM_SHA256 = 0xC06C, // rfc6209
        TLS_DHE_PSK_WITH_ARIA_256_GCM_SHA384 = 0xC06D, // rfc6209
        TLS_RSA_PSK_WITH_ARIA_128_GCM_SHA256 = 0xC06E, // rfc6209
        TLS_RSA_PSK_WITH_ARIA_256_GCM_SHA384 = 0xC06F, // rfc6209
        TLS_ECDHE_PSK_WITH_ARIA_128_CBC_SHA256 = 0xC070, // rfc6209
        TLS_ECDHE_PSK_WITH_ARIA_256_CBC_SHA384 = 0xC071, // rfc6209
        TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 0xC072, // rfc6367
        TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 0xC073, // rfc6367
        TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 0xC074, // rfc6367
        TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 0xC075, // rfc6367
        TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 0xC076, // rfc6367
        TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 0xC077, // rfc6367
        TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 0xC078, // rfc6367
        TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 0xC079, // rfc6367
        TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 0xC07A, // rfc6367
        TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 0xC07B, // rfc6367
        TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 0xC07C, // rfc6367
        TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 0xC07D, // rfc6367
        TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 0xC07E, // rfc6367
        TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 0xC07F, // rfc6367
        TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 0xC080, // rfc6367
        TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 0xC081, // rfc6367
        TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 0xC082, // rfc6367
        TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 0xC083, // rfc6367
        TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 0xC084, // rfc6367
        TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 0xC085, // rfc6367
        TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 0xC086, // rfc6367
        TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 0xC087, // rfc6367
        TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 0xC088, // rfc6367
        TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 0xC089, // rfc6367
        TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 0xC08A, // rfc6367
        TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 0xC08B, // rfc6367
        TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 0xC08C, // rfc6367
        TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 0xC08D, // rfc6367
        TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 0xC08E, // rfc6367
        TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 0xC08F, // rfc6367
        TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 0xC090, // rfc6367
        TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 0xC091, // rfc6367
        TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 0xC092, // rfc6367
        TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 0xC093, // rfc6367
        TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 0xC094, // rfc6367
        TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 0xC095, // rfc6367
        TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 0xC096, // rfc6367
        TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 0xC097, // rfc6367
        TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 0xC098, // rfc6367
        TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 0xC099, // rfc6367
        TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 0xC09A, // rfc6367
        TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 0xC09B, // rfc6367
        TLS_RSA_WITH_AES_128_CCM = 0xC09C, // rfc6655
        TLS_RSA_WITH_AES_256_CCM = 0xC09D, // rfc6655
        TLS_DHE_RSA_WITH_AES_128_CCM = 0xC09E, // rfc6655
        TLS_DHE_RSA_WITH_AES_256_CCM = 0xC09F, // rfc6655
        TLS_RSA_WITH_AES_128_CCM_8 = 0xC0A0, // rfc6655
        TLS_RSA_WITH_AES_256_CCM_8 = 0xC0A1, // rfc6655
        TLS_DHE_RSA_WITH_AES_128_CCM_8 = 0xC0A2, // rfc6655
        TLS_DHE_RSA_WITH_AES_256_CCM_8 = 0xC0A3, // rfc6655
        TLS_PSK_WITH_AES_128_CCM = 0xC0A4, // rfc6655
        TLS_PSK_WITH_AES_256_CCM = 0xC0A5, // rfc6655
        TLS_DHE_PSK_WITH_AES_128_CCM = 0xC0A6, // rfc6655
        TLS_DHE_PSK_WITH_AES_256_CCM = 0xC0A7, // rfc6655
        TLS_PSK_WITH_AES_128_CCM_8 = 0xC0A8, // rfc6655
        TLS_PSK_WITH_AES_256_CCM_8 = 0xC0A9, // rfc6655
        TLS_PSK_DHE_WITH_AES_128_CCM_8 = 0xC0AA, // rfc6655
        TLS_PSK_DHE_WITH_AES_256_CCM_8 = 0xC0AB, // rfc6655
        TLS_ECDHE_ECDSA_WITH_AES_128_CCM = 0xC0AC, // rfc7251
        TLS_ECDHE_ECDSA_WITH_AES_256_CCM = 0xC0AD, // rfc7251
        TLS_ECDHE_ECDSA_WITH_AES_128_CCM_8 = 0xC0AE, // rfc7251
        TLS_ECDHE_ECDSA_WITH_AES_256_CCM_8 = 0xC0AF, // rfc7251
        TLS_ECCPWD_WITH_AES_128_GCM_SHA256 = 0xC0B0, // rfc8492
        TLS_ECCPWD_WITH_AES_256_GCM_SHA384 = 0xC0B1, // rfc8492
        TLS_ECCPWD_WITH_AES_128_CCM_SHA256 = 0xC0B2, // rfc8492
        TLS_ECCPWD_WITH_AES_256_CCM_SHA384 = 0xC0B3, // rfc8492
        TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 0xCCA8, // rfc7905
        TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 0xCCA9, // rfc7905
        TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 0xCCAA, // rfc7905
        TLS_PSK_WITH_CHACHA20_POLY1305_SHA256 = 0xCCAB, // rfc7905
        TLS_ECDHE_PSK_WITH_CHACHA20_POLY1305_SHA256 = 0xCCAC, // rfc7905
        TLS_DHE_PSK_WITH_CHACHA20_POLY1305_SHA256 = 0xCCAD, // rfc7905
        TLS_RSA_PSK_WITH_CHACHA20_POLY1305_SHA256 = 0xCCAE, // rfc7905
        TLS_ECDHE_PSK_WITH_AES_128_GCM_SHA256 = 0xD001, // rfc8442
        TLS_ECDHE_PSK_WITH_AES_256_GCM_SHA384 = 0xD002, // rfc8442
        TLS_ECDHE_PSK_WITH_AES_128_CCM_8_SHA256 = 0xD003, // rfc8442
        TLS_ECDHE_PSK_WITH_AES_128_CCM_SHA256 = 0xD005, // rfc8442
#if PRODUCT
    }
#endif
}
//#>
