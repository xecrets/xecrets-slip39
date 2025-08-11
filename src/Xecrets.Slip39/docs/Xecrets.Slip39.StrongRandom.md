#### [Xecrets.Slip39](index.md 'index')
### [Xecrets.Slip39](Xecrets.Slip39.md 'Xecrets.Slip39')

## StrongRandom Class

An [IRandom](Xecrets.Slip39.md#Xecrets.Slip39.IRandom 'Xecrets.Slip39.IRandom') implementation using [System.Security.Cryptography.RandomNumberGenerator](https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.randomnumbergenerator 'System.Security.Cryptography.RandomNumberGenerator').

```csharp
public class StrongRandom : Xecrets.Slip39.IRandom
```

Inheritance [System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System.Object') &#129106; StrongRandom

Implements [IRandom](Xecrets.Slip39.md#Xecrets.Slip39.IRandom 'Xecrets.Slip39.IRandom')
### Methods

<a name='Xecrets.Slip39.StrongRandom.GetBytes(byte[])'></a>

## StrongRandom.GetBytes(byte[]) Method

Fill the provided buffer with random byte values.

```csharp
public void GetBytes(byte[] buffer);
```
#### Parameters

<a name='Xecrets.Slip39.StrongRandom.GetBytes(byte[]).buffer'></a>

`buffer` [System.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System.Byte')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')

The buffer to fill.

Implements [GetBytes(byte[])](Xecrets.Slip39.md#Xecrets.Slip39.IRandom.GetBytes(byte[]) 'Xecrets.Slip39.IRandom.GetBytes(byte[])')

<a name='Xecrets.Slip39.StrongRandom.GetBytes(int)'></a>

## StrongRandom.GetBytes(int) Method

Get a [System.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System.Byte')[] with random bytes.

```csharp
public byte[] GetBytes(int count);
```
#### Parameters

<a name='Xecrets.Slip39.StrongRandom.GetBytes(int).count'></a>

`count` [System.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System.Int32')

The number of random bytes to get.

Implements [GetBytes(int)](Xecrets.Slip39.md#Xecrets.Slip39.IRandom.GetBytes(int) 'Xecrets.Slip39.IRandom.GetBytes(int)')

#### Returns
[System.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System.Byte')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')  
A [System.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System.Byte')[] with random bytes.