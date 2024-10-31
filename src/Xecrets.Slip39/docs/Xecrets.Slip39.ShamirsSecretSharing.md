#### [Xecrets.Slip39](index.md 'index')
### [Xecrets.Slip39](Xecrets.Slip39.md 'Xecrets.Slip39')

## ShamirsSecretSharing Class

A class for implementing Shamir's Secret Sharing with SLIP-0039 enhancements.

```csharp
public class ShamirsSecretSharing :
Xecrets.Slip39.IShamirsSecretSharing
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ShamirsSecretSharing

Implements [IShamirsSecretSharing](Xecrets.Slip39.md#Xecrets.Slip39.IShamirsSecretSharing 'Xecrets.Slip39.IShamirsSecretSharing')
### Constructors

<a name='Xecrets.Slip39.ShamirsSecretSharing.ShamirsSecretSharing(Xecrets.Slip39.IRandom)'></a>

## ShamirsSecretSharing(IRandom) Constructor

A class for implementing Shamir's Secret Sharing with SLIP-0039 enhancements.

```csharp
public ShamirsSecretSharing(Xecrets.Slip39.IRandom random);
```
#### Parameters

<a name='Xecrets.Slip39.ShamirsSecretSharing.ShamirsSecretSharing(Xecrets.Slip39.IRandom).random'></a>

`random` [IRandom](Xecrets.Slip39.md#Xecrets.Slip39.IRandom 'Xecrets.Slip39.IRandom')
### Methods

<a name='Xecrets.Slip39.ShamirsSecretSharing.CombineShares(Xecrets.Slip39.Share[],string)'></a>

## ShamirsSecretSharing.CombineShares(Share[], string) Method

Combines shares to reconstruct the original secret.

```csharp
public byte[] CombineShares(Xecrets.Slip39.Share[] shares, string passphrase);
```
#### Parameters

<a name='Xecrets.Slip39.ShamirsSecretSharing.CombineShares(Xecrets.Slip39.Share[],string).shares'></a>

`shares` [Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The array of shares to combine.

<a name='Xecrets.Slip39.ShamirsSecretSharing.CombineShares(Xecrets.Slip39.Share[],string).passphrase'></a>

`passphrase` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The passphrase used for decrypting the shares.

Implements [CombineShares(Share[], string)](Xecrets.Slip39.md#Xecrets.Slip39.IShamirsSecretSharing.CombineShares(Xecrets.Slip39.Share[],string) 'Xecrets.Slip39.IShamirsSecretSharing.CombineShares(Xecrets.Slip39.Share[], string)')

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The reconstructed secret.

#### Exceptions

[Slip39Exception](Xecrets.Slip39.Slip39Exception.md 'Xecrets.Slip39.Slip39Exception')  
Thrown when the shares are insufficient or invalid.

<a name='Xecrets.Slip39.ShamirsSecretSharing.GenerateShares(bool,int,int,Xecrets.Slip39.Group[],string,byte[])'></a>

## ShamirsSecretSharing.GenerateShares(bool, int, int, Group[], string, byte[]) Method

Generates SLIP-0039 shares from a given master secret.

```csharp
public Xecrets.Slip39.Share[][] GenerateShares(bool extendable, int iterationExponent, int groupThreshold, Xecrets.Slip39.Group[] groups, string passphrase, byte[] masterSecret);
```
#### Parameters

<a name='Xecrets.Slip39.ShamirsSecretSharing.GenerateShares(bool,int,int,Xecrets.Slip39.Group[],string,byte[]).extendable'></a>

`extendable` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='Xecrets.Slip39.ShamirsSecretSharing.GenerateShares(bool,int,int,Xecrets.Slip39.Group[],string,byte[]).iterationExponent'></a>

`iterationExponent` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Exponent to determine the number of iterations for the encryption  
            algorithm.

<a name='Xecrets.Slip39.ShamirsSecretSharing.GenerateShares(bool,int,int,Xecrets.Slip39.Group[],string,byte[]).groupThreshold'></a>

`groupThreshold` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of groups required to reconstruct the secret.

<a name='Xecrets.Slip39.ShamirsSecretSharing.GenerateShares(bool,int,int,Xecrets.Slip39.Group[],string,byte[]).groups'></a>

`groups` [Group](Xecrets.Slip39.Group.md 'Xecrets.Slip39.Group')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

Array of tuples where each tuple represents (groupThreshold, shareCount) for each  
            group.

<a name='Xecrets.Slip39.ShamirsSecretSharing.GenerateShares(bool,int,int,Xecrets.Slip39.Group[],string,byte[]).passphrase'></a>

`passphrase` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The passphrase used for encryption.

<a name='Xecrets.Slip39.ShamirsSecretSharing.GenerateShares(bool,int,int,Xecrets.Slip39.Group[],string,byte[]).masterSecret'></a>

`masterSecret` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The secret to be split into shares.

Implements [GenerateShares(bool, int, int, Group[], string, byte[])](Xecrets.Slip39.md#Xecrets.Slip39.IShamirsSecretSharing.GenerateShares(bool,int,int,Xecrets.Slip39.Group[],string,byte[]) 'Xecrets.Slip39.IShamirsSecretSharing.GenerateShares(bool, int, int, Xecrets.Slip39.Group[], string, byte[])')

#### Returns
[Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
A list of shares that can be used to reconstruct the secret.

#### Exceptions

[Slip39Exception](Xecrets.Slip39.Slip39Exception.md 'Xecrets.Slip39.Slip39Exception')  
Thrown when inputs do not meet the required constraints.