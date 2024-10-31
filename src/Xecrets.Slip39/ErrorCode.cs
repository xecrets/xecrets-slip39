#region Copyright and MIT License
/* MIT License
 *
 * Copyright © 2024 Svante Seleborg
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

namespace Xecrets.Slip39;

/// <summary>
/// Error codes used in <see cref="T:Slip39Exception"/> to facilitate UI error messages to users with localization etc.
/// The full english text of the actual error is found in the message property of the exception.
/// </summary>
public enum ErrorCode
{
    /// <summary>
    /// The undefined, invalid, zero error code.
    /// </summary>
    Undefined = 0,

    /// <summary>
    /// No error
    /// </summary>
    NoError,

    /// <summary>
    /// A checksum or digest was found to be incorrect. Check the exception message for details.
    /// </summary>
    InvalidChecksum,

    /// <summary>
    /// Group specification or actual group meta data is invalid. Check the exception message for details.
    /// </summary>
    InvalidGroups,

    /// <summary>
    /// The number of shares is insufficient. Check the exception message for details.
    /// </summary>
    InsufficientShares,

    /// <summary>
    /// The set of shares have inconsistent meta data. Check the exception message for details.
    /// </summary>
    InconsistentShares,

    /// <summary>
    /// Input is in the wrong format. Check the exception message for details.
    /// </summary>
    InvalidFormat,

    /// <summary>
    /// An invalid mnemonic word or set of words were input. Check the exception message for details.
    /// </summary>
    InvalidMnemonic,
}
