#region Copyright and MIT License
/* MIT License
 *
 * Copyright © 2024-2025 Svante Seleborg
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
*/
#endregion Copyright and MIT License

using System.Text;

using Xunit;

namespace Xecrets.Slip39.Test;

public class TestSharing
{
    [Fact]
    public void TestSimplifiedShortStringSecretSharing()
    {
        ShamirsSecretSharing sss = new ShamirsSecretSharing(new FakeRandom());
        Share[] shares = sss.GenerateShares(2, 4, "secret");

        Assert.Equal(16, shares[0].Value.Length);
        Assert.Equal("secret", sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal("secret", sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal("secret", sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal("secret", sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());

        string[] strings = [.. shares.Select(s => s.ToString())];
        shares = [.. strings.Select(s => Share.Parse(s))];

        Assert.Equal(16, shares[0].Value.Length);
        Assert.Equal("secret", sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal("secret", sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal("secret", sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal("secret", sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());

        strings = [.. shares.Select(s => s.ToString("64"))];
        shares = [.. strings.Select(s => Share.Parse(s))];

        Assert.Equal(16, shares[0].Value.Length);
        Assert.Equal("secret", sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal("secret", sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal("secret", sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal("secret", sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());
    }

    [Fact]
    public void TestSimplifiedUnpaddedStringSecretSharing()
    {
        ShamirsSecretSharing sss = new ShamirsSecretSharing(new FakeRandom());
        Share[] shares = sss.GenerateShares(2, 4, "abcdefghijklmnop");

        Assert.Equal(18, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());

        string[] strings = [.. shares.Select(s => s.ToString())];
        shares = [.. strings.Select(s => Share.Parse(s))];

        Assert.Equal(18, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());

        strings = [.. shares.Select(s => s.ToString("64"))];
        shares = [.. strings.Select(s => Share.Parse(s))];

        Assert.Equal(18, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());
    }

    [Fact]
    public void TestSimplifiedOddLengthPaddedStringSecretSharing()
    {
        ShamirsSecretSharing sss = new ShamirsSecretSharing(new FakeRandom());
        Share[] shares = sss.GenerateShares(2, 4, "abcdefghijklmnopq");

        Assert.Equal(18, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());

        string[] strings = [.. shares.Select(s => s.ToString())];
        shares = [.. strings.Select(s => Share.Parse(s))];

        Assert.Equal(18, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());

        strings = [.. shares.Select(s => s.ToString("64"))];
        shares = [.. strings.Select(s => Share.Parse(s))];

        Assert.Equal(18, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());
    }

    [Fact]
    public void TestSimplifiedLongEvenPaddedStringSecretSharing()
    {
        ShamirsSecretSharing sss = new ShamirsSecretSharing(new FakeRandom());
        Share[] shares = sss.GenerateShares(2, 4, "abcdefghijklmnopqr");

        Assert.Equal(20, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());

        string[] strings = [.. shares.Select(s => s.ToString())];
        shares = [.. strings.Select(s => Share.Parse(s))];

        Assert.Equal(20, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());

        strings = [.. shares.Select(s => s.ToString("64"))];
        shares = [.. strings.Select(s => Share.Parse(s))];

        Assert.Equal(20, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());
    }

    [Fact]
    public void TestBip39FallbackStringSecretSharing()
    {
        ShamirsSecretSharing sss = new ShamirsSecretSharing(new FakeRandom());
        Share[] shares = sss.GenerateShares(2, 4, "abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon about", StringEncoding.Bip39);

        Assert.Equal(16, shares[0].Value.Length);
        Assert.Equal("abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon about", sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal("abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon about", sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal("abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon about", sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal("abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon abandon about", sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());
    }

    [Fact]
    public void TestBip39StringSecretSharing()
    {
        ShamirsSecretSharing sss = new ShamirsSecretSharing(new FakeRandom());

        Share[] shares = sss.GenerateShares(extendable: true, iterationExponent: 0, 1, [new Group(2, 4)], string.Empty,
            [0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10])[0];

        Assert.Equal(16, shares[0].Value.Length);
        Assert.Equal("absurd avoid scissors anxiety gather lottery category door army half long camera", sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal("absurd avoid scissors anxiety gather lottery category door army half long camera", sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal("absurd avoid scissors anxiety gather lottery category door army half long camera", sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal("absurd avoid scissors anxiety gather lottery category door army half long camera", sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());
    }

    [Fact]
    public void TestNonPrintableStringSecretSharing()
    {
        ShamirsSecretSharing sss = new ShamirsSecretSharing(new FakeRandom());

        Share[] shares = sss.GenerateShares(extendable: true, iterationExponent: 0, 1, [new Group(2, 4)], string.Empty,
            [0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0xFF])[0];

        Assert.Equal(16, shares[0].Value.Length);
        Assert.Equal("absurd avoid scissors anxiety gather lottery category door army half loop young", sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal("absurd avoid scissors anxiety gather lottery category door army half loop young", sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal("absurd avoid scissors anxiety gather lottery category door army half loop young", sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal("absurd avoid scissors anxiety gather lottery category door army half loop young", sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());
    }

    [Fact]
    public void TestInvalidUtf8StringSecretSharing()
    {
        ShamirsSecretSharing sss = new ShamirsSecretSharing(new FakeRandom());

        Share[] shares = sss.GenerateShares(extendable: true, iterationExponent: 0, 1, [new Group(2, 4)], string.Empty,
            [0xE2, 0x28, 0xA1, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0xFF])[0];

        Assert.Equal(16, shares[0].Value.Length);
        Assert.Equal("timber eagle donate anxiety gather lottery category door army half loop yard", sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal("timber eagle donate anxiety gather lottery category door army half loop yard", sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal("timber eagle donate anxiety gather lottery category door army half loop yard", sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal("timber eagle donate anxiety gather lottery category door army half loop yard", sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());
    }

    [Fact]
    public void TestExoticUtf8StringSecretSharing()
    {
        ShamirsSecretSharing sss = new ShamirsSecretSharing(new FakeRandom());

        byte[] utf8 =
        [
            0xD8, 0xB4,             // ش (U+0634)
            0xE2, 0x80, 0x8C,       // ZWNJ (U+200C)
            0xF0, 0x9E, 0xB0, 0x83  // 𞸃 (U+1EC03, surrogate pair)
        ];

        Share[] shares = sss.GenerateShares(extendable: true, iterationExponent: 0, 1, [new Group(2, 4)], string.Empty,
            [.. utf8, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF])[0];

        string expected = Encoding.UTF8.GetString(utf8);

        Assert.Equal(16, shares[0].Value.Length);
        Assert.Equal(expected, sss.CombineShares(shares[..2]).Secret.ToSecretString());
        Assert.Equal(expected, sss.CombineShares(shares[1..3]).Secret.ToSecretString());
        Assert.Equal(expected, sss.CombineShares(shares[2..]).Secret.ToSecretString());
        Assert.Equal(expected, sss.CombineShares([shares[3], shares[0]]).Secret.ToSecretString());
    }
}
