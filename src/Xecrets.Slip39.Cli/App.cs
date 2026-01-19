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

using System.CommandLine;
using System.CommandLine.Parsing;
using System.Diagnostics;

namespace Xecrets.Slip39.Cli;

internal class App(IShamirsSecretSharing sss)
{
    public async Task<int> Run(string[] args)
    {
        Option<bool> debugOption = new(name: "--debug")
        {
            Description = "Perform a debug break.",
            Recursive =  true,
        };

        Option<StringEncoding> formatOption = new(name: "--format")
        {
            Description = "Specify the format of the secret.",
            Required = true,
        };

        Option<int> countOption = new(name: "--count")
        {
            Description = "The number of shares to generate.",
        };

        Option<int> thresholdOption = new(name: "--threshold")
        {
            Description = "The number of shares required to recover the master secret.",
        };

        Option<string> secretOption = new(name: "--secret")
        {
            Description = "The secret to split into shares.",
        };

        Command splitCommand = new(name: "split", description: "Split the secret into shares")
        {
            countOption,
            thresholdOption,
            secretOption,
            formatOption,
        };

        splitCommand.SetAction(parseResult =>
        {
            int threshold = parseResult.GetValue(thresholdOption);
            int count = parseResult.GetValue(countOption);
            string secret = parseResult.GetValue(secretOption) ?? string.Empty;
            StringEncoding format = parseResult.GetValue(formatOption);
            
            Share[] shares = sss.GenerateShares(threshold, count, secret, format);
            foreach (Share share in shares)
            {
                Console.WriteLine(share);
            }
        });

        Option<string[]> shareOption = new(name: "--share")
        {
            Description = "Combine this and any additional shares to recover the master secret.",
            AllowMultipleArgumentsPerToken = true,
            Required = true,
        };

        Command combineCommand = new(name: "combine", description: "Combine the given number of shares and recover the secret.")
        {
            shareOption,
            formatOption,
        };

        combineCommand.SetAction(parseResult =>
        {
            bool debug = parseResult.GetValue(debugOption);
            string[] shares = parseResult.GetValue(shareOption) ?? [];
            StringEncoding format = parseResult.GetValue(formatOption);
            
            if (debug)
            {
                Debugger.Launch();
            }

            GroupedShares groupedShares = sss.CombineShares([.. shares.Select(Share.Parse)]);
            string secret = format switch
            {
                StringEncoding.Base64 => groupedShares.Secret.ToUrlSafeBase64(),
                StringEncoding.Hex => groupedShares.Secret.ToHex(),
                StringEncoding.Bip39 => groupedShares.Secret.ToBip39(),
                StringEncoding.None => groupedShares.Secret.ToSecretString(),
                _ => throw new NotSupportedException("This format is not supported."),
            };
            Console.WriteLine(secret);
        });

        RootCommand rootCommand = new("Simple app to generate Shamir secret shares and combine them again.")
        {
            splitCommand,
            combineCommand,
        };
        rootCommand.Options.Add(debugOption);
        
        ParseResult parseResult = rootCommand.Parse(args);
        if (parseResult.Errors.Any())
        {
            foreach (ParseError parseError in parseResult.Errors)
            {
                await Console.Error.WriteLineAsync(parseError.Message);
            }

            return 1;
        }
        
        return await parseResult.InvokeAsync();
    }
}
