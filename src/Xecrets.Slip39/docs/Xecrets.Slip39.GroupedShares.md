#### [Xecrets.Slip39](index.md 'index')
### [Xecrets.Slip39](Xecrets.Slip39.md 'Xecrets.Slip39')

## GroupedShares Class

A collection of groups of shares, possibly complete, or incomplete.

```csharp
public record GroupedShares : System.IEquatable<Xecrets.Slip39.GroupedShares>
```

Inheritance [System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System.Object') &#129106; GroupedShares

Implements [System.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System.IEquatable`1')[GroupedShares](Xecrets.Slip39.GroupedShares.md 'Xecrets.Slip39.GroupedShares')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System.IEquatable`1')
### Constructors

<a name='Xecrets.Slip39.GroupedShares.GroupedShares(Xecrets.Slip39.Share[][],byte[])'></a>

## GroupedShares(Share[][], byte[]) Constructor

A collection of groups of shares, possibly complete, or incomplete.

```csharp
public GroupedShares(Xecrets.Slip39.Share[][] ShareGroups, byte[] Secret);
```
#### Parameters

<a name='Xecrets.Slip39.GroupedShares.GroupedShares(Xecrets.Slip39.Share[][],byte[]).ShareGroups'></a>

`ShareGroups` [Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')

An array of groups of shares.

<a name='Xecrets.Slip39.GroupedShares.GroupedShares(Xecrets.Slip39.Share[][],byte[]).Secret'></a>

`Secret` [System.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System.Byte')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')

The secret encoded by the shares, or an empty array
### Properties

<a name='Xecrets.Slip39.GroupedShares.Secret'></a>

## GroupedShares.Secret Property

The secret encoded by the shares, or an empty array

```csharp
public byte[] Secret { get; init; }
```

#### Property Value
[System.Byte](https://learn.microsoft.com/en-us/dotnet/api/system.byte 'System.Byte')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')

<a name='Xecrets.Slip39.GroupedShares.ShareGroups'></a>

## GroupedShares.ShareGroups Property

An array of groups of shares.

```csharp
public Xecrets.Slip39.Share[][] ShareGroups { get; init; }
```

#### Property Value
[Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')[[]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System.Array')