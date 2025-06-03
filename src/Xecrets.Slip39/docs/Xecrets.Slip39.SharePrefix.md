#### [Xecrets.Slip39](index.md 'index')
### [Xecrets.Slip39](Xecrets.Slip39.md 'Xecrets.Slip39')

## SharePrefix Class

A representation of the share prefix, which consists of the parameters for the share.

```csharp
public class SharePrefix
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SharePrefix
### Constructors

<a name='Xecrets.Slip39.SharePrefix.SharePrefix(byte[])'></a>

## SharePrefix(byte[]) Constructor

Instantiate a [SharePrefix](Xecrets.Slip39.SharePrefix.md 'Xecrets.Slip39.SharePrefix') from a binary representation.

```csharp
public SharePrefix(byte[] prefix);
```
#### Parameters

<a name='Xecrets.Slip39.SharePrefix.SharePrefix(byte[]).prefix'></a>

`prefix` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

A [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[] containing the binary prefix.
### Fields

<a name='Xecrets.Slip39.SharePrefix.LengthBits'></a>

## SharePrefix.LengthBits Field

The total length in bits of the share prefix.

```csharp
public static readonly int LengthBits;
```

#### Field Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
### Properties

<a name='Xecrets.Slip39.SharePrefix.Extendable'></a>

## SharePrefix.Extendable Property

The extendable backup flag (ext) field indicates that the id is used as
salt in the encryption of the master secret when ext = 0.

```csharp
public bool Extendable { get; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='Xecrets.Slip39.SharePrefix.GroupCount'></a>

## SharePrefix.GroupCount Property

The group count (g) indicates the total number of groups. The actual value is encoded as g = G − 1.

```csharp
public int GroupCount { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='Xecrets.Slip39.SharePrefix.GroupIndex'></a>

## SharePrefix.GroupIndex Property

The group index (GI) field is the x value of the group share.

```csharp
public int GroupIndex { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='Xecrets.Slip39.SharePrefix.GroupThreshold'></a>

## SharePrefix.GroupThreshold Property

The group threshold (Gt) field indicates how many group shares are needed to reconstruct the master secret. The
actual value is encoded as Gt = GT − 1, so a value of 0 indicates that a single group share is needed (GT = 1),
a value of 1 indicates that two group shares are needed (GT = 2) etc.

```csharp
public int GroupThreshold { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='Xecrets.Slip39.SharePrefix.Id'></a>

## SharePrefix.Id Property

The identifier (id) field is a random 15-bit value which is the same for all shares and is used to verify that
the shares belong together.

```csharp
public int Id { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='Xecrets.Slip39.SharePrefix.IterationExponent'></a>

## SharePrefix.IterationExponent Property

The iteration exponent (e) field indicates the total number of iterations to be used in PBKDF2. The number of
iterations is calculated as 10000×2^e.

```csharp
public int IterationExponent { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='Xecrets.Slip39.SharePrefix.MemberIndex'></a>

## SharePrefix.MemberIndex Property

The member index (I) field is the x value of the member share in the given group.

```csharp
public int MemberIndex { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='Xecrets.Slip39.SharePrefix.MemberThreshold'></a>

## SharePrefix.MemberThreshold Property

The member threshold (t) field indicates how many member shares are needed to reconstruct the group share. The
actual value is encoded as t = T − 1.

```csharp
public int MemberThreshold { get; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
### Methods

<a name='Xecrets.Slip39.SharePrefix.GenerateId(Xecrets.Slip39.IRandom)'></a>

## SharePrefix.GenerateId(IRandom) Method

Generate a random id for the prefix.

```csharp
public static int GenerateId(Xecrets.Slip39.IRandom random);
```
#### Parameters

<a name='Xecrets.Slip39.SharePrefix.GenerateId(Xecrets.Slip39.IRandom).random'></a>

`random` [IRandom](Xecrets.Slip39.md#Xecrets.Slip39.IRandom 'Xecrets.Slip39.IRandom')

The [IRandom](Xecrets.Slip39.md#Xecrets.Slip39.IRandom 'Xecrets.Slip39.IRandom') instance to use.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
An integer suitable as a random id for a share.