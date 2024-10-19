#### [Xecrets.Slip39](index.md 'index')
### [Xecrets.Slip39](Xecrets.Slip39.md 'Xecrets.Slip39')

## StringEncoding Enum

The master secret string encoding

```csharp
public enum StringEncoding
```
### Fields

<a name='Xecrets.Slip39.StringEncoding.Base64'></a>

`Base64` 2

The secret is string encoded as a URL-safe base64 string.

<a name='Xecrets.Slip39.StringEncoding.Bip39'></a>

`Bip39` 4

The secret is string encoded as a BIP-0039 mnemonic string.  
[https://bips.dev/39/](https://bips.dev/39/ 'https://bips.dev/39/').

<a name='Xecrets.Slip39.StringEncoding.Hex'></a>

`Hex` 3

The secret is string encoded as a hexadecimal string.

<a name='Xecrets.Slip39.StringEncoding.None'></a>

`None` 1

No encoding, the string is the raw value. Internally it's a UTF-8 string, with 0xFF padding if necessary.

<a name='Xecrets.Slip39.StringEncoding.Unknown'></a>

`Unknown` 0

The encoding is unknown. This is not a valid value.