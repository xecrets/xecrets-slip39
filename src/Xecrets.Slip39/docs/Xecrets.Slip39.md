#### [Xecrets.Slip39](index.md 'index')

## Xecrets.Slip39 Namespace

The main entry point for the library is through the [IShamirsSecretSharing](Xecrets.Slip39.md#Xecrets.Slip39.IShamirsSecretSharing 'Xecrets.Slip39.IShamirsSecretSharing') interface, which
            has a default implementation in [ShamirsSecretSharing](Xecrets.Slip39.ShamirsSecretSharing.md 'Xecrets.Slip39.ShamirsSecretSharing'). The only other public type of importance is
            [Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share') which is how generated shares are represented and returned. It also has a static method to
            parse a share string into a [Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share') object.

| Classes | |
| :--- | :--- |
| [Extensions](Xecrets.Slip39.Extensions.md 'Xecrets.Slip39.Extensions') | A set of useful extensions. |
| [Group](Xecrets.Slip39.Group.md 'Xecrets.Slip39.Group') | Defines the main parameter of a group. |
| [GroupedShares](Xecrets.Slip39.GroupedShares.md 'Xecrets.Slip39.GroupedShares') | A collection of groups of shares, possibly complete, or incomplete. |
| [ShamirsSecretSharing](Xecrets.Slip39.ShamirsSecretSharing.md 'Xecrets.Slip39.ShamirsSecretSharing') | A class for implementing Shamir's Secret Sharing with SLIP-0039 enhancements. |
| [Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share') | A representation of a Shamir secret sharing share. |
| [SharePrefix](Xecrets.Slip39.SharePrefix.md 'Xecrets.Slip39.SharePrefix') | A representation of the share prefix, which consists of the parameters for the share. |
| [Slip39Exception](Xecrets.Slip39.Slip39Exception.md 'Xecrets.Slip39.Slip39Exception') | Creates an exception for catcheable Slip39 errors. This will only be thrown when the error is due to incorrect input data, not due to an internal error or programming errors et. |
| [StrongRandom](Xecrets.Slip39.StrongRandom.md 'Xecrets.Slip39.StrongRandom') | An [IRandom](Xecrets.Slip39.md#Xecrets.Slip39.IRandom 'Xecrets.Slip39.IRandom') implementation using [System.Security.Cryptography.RandomNumberGenerator](https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.randomnumbergenerator 'System.Security.Cryptography.RandomNumberGenerator'). |
### Interfaces

<a name='Xecrets.Slip39.IRandom'></a>

## IRandom Interface

Generate sequences of random bytes.

```csharp
public interface IRandom
```

Derived  
&#8627; [StrongRandom](Xecrets.Slip39.StrongRandom.md 'Xecrets.Slip39.StrongRandom')
### Methods

<a name='Xecrets.Slip39.IRandom.GetBytes(byte[])'></a>

## IRandom.GetBytes(byte[]) Method

Fill the provided buffer with random byte values.

```csharp
void GetBytes(byte[] buffer);
```
#### Parameters

<a name='Xecrets.Slip39.IRandom.GetBytes(byte[]).buffer'></a>

`buffer` [System.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System.Byte')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')

The buffer to fill.

<a name='Xecrets.Slip39.IRandom.GetBytes(int)'></a>

## IRandom.GetBytes(int) Method

Get a [System.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System.Byte')[] with random bytes.

```csharp
byte[] GetBytes(int count);
```
#### Parameters

<a name='Xecrets.Slip39.IRandom.GetBytes(int).count'></a>

`count` [System.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System.Int32')

The number of random bytes to get.

#### Returns
[System.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System.Byte')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')  
A [System.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System.Byte')[] with random bytes.

<a name='Xecrets.Slip39.IShamirsSecretSharing'></a>

## IShamirsSecretSharing Interface

Implement Shamirs Secret Sharing according to
<seealso href="https://github.com/satoshilabs/slips/blob/master/slip-0039.md">SLIP-039</seealso>.

```csharp
public interface IShamirsSecretSharing
```

Derived  
&#8627; [ShamirsSecretSharing](Xecrets.Slip39.ShamirsSecretSharing.md 'Xecrets.Slip39.ShamirsSecretSharing')
### Methods

<a name='Xecrets.Slip39.IShamirsSecretSharing.CombineShares(Xecrets.Slip39.Share[],string)'></a>

## IShamirsSecretSharing.CombineShares(Share[], string) Method

Recover the master secret from an appropriate set of shares.

```csharp
Xecrets.Slip39.GroupedShares CombineShares(Xecrets.Slip39.Share[] shares, string passphrase);
```
#### Parameters

<a name='Xecrets.Slip39.IShamirsSecretSharing.CombineShares(Xecrets.Slip39.Share[],string).shares'></a>

`shares` [Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')

The shares to recover the secret from.

<a name='Xecrets.Slip39.IShamirsSecretSharing.CombineShares(Xecrets.Slip39.Share[],string).passphrase'></a>

`passphrase` [System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System.String')

The (optional) passphrase to decrypt the encrypted master secret with.

#### Returns
[GroupedShares](Xecrets.Slip39.GroupedShares.md 'Xecrets.Slip39.GroupedShares')  
The original master secret.

<a name='Xecrets.Slip39.IShamirsSecretSharing.GenerateShares(bool,int,int,Xecrets.Slip39.Group[],string,byte[])'></a>

## IShamirsSecretSharing.GenerateShares(bool, int, int, Group[], string, byte[]) Method

Generate shares according to the given parameters.

```csharp
Xecrets.Slip39.Share[][] GenerateShares(bool extendable, int iterationExponent, int groupThreshold, Xecrets.Slip39.Group[] groups, string passphrase, byte[] masterSecret);
```
#### Parameters

<a name='Xecrets.Slip39.IShamirsSecretSharing.GenerateShares(bool,int,int,Xecrets.Slip39.Group[],string,byte[]).extendable'></a>

`extendable` [System.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System.Boolean')

Indicates that the id is used as salt in the encryption of the master secret when
            false.

<a name='Xecrets.Slip39.IShamirsSecretSharing.GenerateShares(bool,int,int,Xecrets.Slip39.Group[],string,byte[]).iterationExponent'></a>

`iterationExponent` [System.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System.Int32')

The total number of iterations to be used in PBKDF2, calculated as
            10000×2^e.

<a name='Xecrets.Slip39.IShamirsSecretSharing.GenerateShares(bool,int,int,Xecrets.Slip39.Group[],string,byte[]).groupThreshold'></a>

`groupThreshold` [System.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System.Int32')

The number of group shares needed to reconstruct the master secret.

<a name='Xecrets.Slip39.IShamirsSecretSharing.GenerateShares(bool,int,int,Xecrets.Slip39.Group[],string,byte[]).groups'></a>

`groups` [Group](Xecrets.Slip39.Group.md 'Xecrets.Slip39.Group')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')

The group definitions as a [Group](https://learn.microsoft.com/en-us/dotnet/api/group 'Group')[].

<a name='Xecrets.Slip39.IShamirsSecretSharing.GenerateShares(bool,int,int,Xecrets.Slip39.Group[],string,byte[]).passphrase'></a>

`passphrase` [System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System.String')

The (optional) passphrase used to encrypt the master secret.

<a name='Xecrets.Slip39.IShamirsSecretSharing.GenerateShares(bool,int,int,Xecrets.Slip39.Group[],string,byte[]).masterSecret'></a>

`masterSecret` [System.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System.Byte')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')

The master secret, at least 128 bits and a multiple of 16 bits.

#### Returns
[Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')  
A [Share](https://learn.microsoft.com/en-us/dotnet/api/share 'Share')[][] with shares that can be distributed according to the threshold
            parameters.

| Enums | |
| :--- | :--- |
| [ErrorCode](Xecrets.Slip39.ErrorCode.md 'Xecrets.Slip39.ErrorCode') | Error codes used in [Slip39Exception](https://learn.microsoft.com/en-us/dotnet/api/slip39exception 'Slip39Exception') to facilitate UI error messages to users with localization etc. The full english text of the actual error is found in the message property of the exception. |
| [StringEncoding](Xecrets.Slip39.StringEncoding.md 'Xecrets.Slip39.StringEncoding') | The master secret string encoding |
