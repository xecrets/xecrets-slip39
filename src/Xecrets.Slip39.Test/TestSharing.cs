﻿#region Copyright and MIT License
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
        Assert.Equal("secret", sss.CombineShares(shares[..2]).ToSecretString());
        Assert.Equal("secret", sss.CombineShares(shares[1..3]).ToSecretString());
        Assert.Equal("secret", sss.CombineShares(shares[2..]).ToSecretString());
        Assert.Equal("secret", sss.CombineShares([shares[3], shares[0]]).ToSecretString());

        string[] strings = shares.Select(s => s.ToString()).ToArray();
        shares = strings.Select(s => Share.Parse(s)).ToArray();

        Assert.Equal(16, shares[0].Value.Length);
        Assert.Equal("secret", sss.CombineShares(shares[..2]).ToSecretString());
        Assert.Equal("secret", sss.CombineShares(shares[1..3]).ToSecretString());
        Assert.Equal("secret", sss.CombineShares(shares[2..]).ToSecretString());
        Assert.Equal("secret", sss.CombineShares([shares[3], shares[0]]).ToSecretString());

        strings = shares.Select(s => s.ToString("64")).ToArray();
        shares = strings.Select(s => Share.Parse(s)).ToArray();

        Assert.Equal(16, shares[0].Value.Length);
        Assert.Equal("secret", sss.CombineShares(shares[..2]).ToSecretString());
        Assert.Equal("secret", sss.CombineShares(shares[1..3]).ToSecretString());
        Assert.Equal("secret", sss.CombineShares(shares[2..]).ToSecretString());
        Assert.Equal("secret", sss.CombineShares([shares[3], shares[0]]).ToSecretString());
    }

    [Fact]
    public void TestSimplifiedUnpaddedStringSecretSharing()
    {
        ShamirsSecretSharing sss = new ShamirsSecretSharing(new FakeRandom());
        Share[] shares = sss.GenerateShares(2, 4, "abcdefghijklmnop");

        Assert.Equal(16, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[..2]).ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[1..3]).ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[2..]).ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares([shares[3], shares[0]]).ToSecretString());

        string[] strings = shares.Select(s => s.ToString()).ToArray();
        shares = strings.Select(s => Share.Parse(s)).ToArray();

        Assert.Equal(16, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[..2]).ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[1..3]).ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[2..]).ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares([shares[3], shares[0]]).ToSecretString());

        strings = shares.Select(s => s.ToString("64")).ToArray();
        shares = strings.Select(s => Share.Parse(s)).ToArray();

        Assert.Equal(16, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[..2]).ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[1..3]).ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares(shares[2..]).ToSecretString());
        Assert.Equal("abcdefghijklmnop", sss.CombineShares([shares[3], shares[0]]).ToSecretString());
    }

    [Fact]
    public void TestSimplifiedOddLengthPaddedStringSecretSharing()
    {
        ShamirsSecretSharing sss = new ShamirsSecretSharing(new FakeRandom());
        Share[] shares = sss.GenerateShares(2, 4, "abcdefghijklmnopq");

        Assert.Equal(18, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[..2]).ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[1..3]).ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[2..]).ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares([shares[3], shares[0]]).ToSecretString());

        string[] strings = shares.Select(s => s.ToString()).ToArray();
        shares = strings.Select(s => Share.Parse(s)).ToArray();

        Assert.Equal(18, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[..2]).ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[1..3]).ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[2..]).ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares([shares[3], shares[0]]).ToSecretString());

        strings = shares.Select(s => s.ToString("64")).ToArray();
        shares = strings.Select(s => Share.Parse(s)).ToArray();

        Assert.Equal(18, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[..2]).ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[1..3]).ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares(shares[2..]).ToSecretString());
        Assert.Equal("abcdefghijklmnopq", sss.CombineShares([shares[3], shares[0]]).ToSecretString());
    }

    [Fact]
    public void TestSimplifiedLongNoPaddedStringSecretSharing()
    {
        ShamirsSecretSharing sss = new ShamirsSecretSharing(new FakeRandom());
        Share[] shares = sss.GenerateShares(2, 4, "abcdefghijklmnopqr");

        Assert.Equal(18, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[..2]).ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[1..3]).ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[2..]).ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares([shares[3], shares[0]]).ToSecretString());

        string[] strings = shares.Select(s => s.ToString()).ToArray();
        shares = strings.Select(s => Share.Parse(s)).ToArray();

        Assert.Equal(18, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[..2]).ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[1..3]).ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[2..]).ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares([shares[3], shares[0]]).ToSecretString());

        strings = shares.Select(s => s.ToString("64")).ToArray();
        shares = strings.Select(s => Share.Parse(s)).ToArray();

        Assert.Equal(18, shares[0].Value.Length);
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[..2]).ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[1..3]).ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares(shares[2..]).ToSecretString());
        Assert.Equal("abcdefghijklmnopqr", sss.CombineShares([shares[3], shares[0]]).ToSecretString());
    }
}
