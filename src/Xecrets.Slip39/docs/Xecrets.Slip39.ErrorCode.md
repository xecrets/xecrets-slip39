#### [Xecrets.Slip39](index.md 'index')
### [Xecrets.Slip39](Xecrets.Slip39.md 'Xecrets.Slip39')

## ErrorCode Enum

Error codes used in [Slip39Exception](https://learn.microsoft.com/en-us/dotnet/api/slip39exception 'Slip39Exception') to facilitate UI error messages to users with localization etc.
The full english text of the actual error is found in the message property of the exception.

```csharp
public enum ErrorCode
```
### Fields

<a name='Xecrets.Slip39.ErrorCode.Undefined'></a>

`Undefined` 0

The undefined, invalid, zero error code.

<a name='Xecrets.Slip39.ErrorCode.NoError'></a>

`NoError` 1

No error

<a name='Xecrets.Slip39.ErrorCode.InvalidChecksum'></a>

`InvalidChecksum` 2

A checksum or digest was found to be incorrect. Check the exception message for details.

<a name='Xecrets.Slip39.ErrorCode.InvalidGroups'></a>

`InvalidGroups` 3

Group specification or actual group meta data is invalid. Check the exception message for details.

<a name='Xecrets.Slip39.ErrorCode.InsufficientShares'></a>

`InsufficientShares` 4

The number of shares is insufficient. Check the exception message for details.

<a name='Xecrets.Slip39.ErrorCode.InconsistentShares'></a>

`InconsistentShares` 5

The set of shares have inconsistent meta data. Check the exception message for details.

<a name='Xecrets.Slip39.ErrorCode.InvalidFormat'></a>

`InvalidFormat` 6

Input is in the wrong format. Check the exception message for details.

<a name='Xecrets.Slip39.ErrorCode.InvalidMnemonic'></a>

`InvalidMnemonic` 7

An invalid mnemonic word or set of words were input. Check the exception message for details.