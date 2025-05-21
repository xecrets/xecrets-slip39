#### [Xecrets.Slip39](index.md 'index')
### [Xecrets.Slip39](Xecrets.Slip39.md 'Xecrets.Slip39')

## GroupedShares Class

A collection of groups of shares, possibly complete, or incomplete.

```csharp
public class GroupedShares :
System.IEquatable<Xecrets.Slip39.GroupedShares>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; GroupedShares

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[GroupedShares](Xecrets.Slip39.GroupedShares.md 'Xecrets.Slip39.GroupedShares')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')
### Constructors

<a name='Xecrets.Slip39.GroupedShares.GroupedShares(Xecrets.Slip39.Share[][],byte[])'></a>

## GroupedShares(Share[][], byte[]) Constructor

A collection of groups of shares, possibly complete, or incomplete.

```csharp
public GroupedShares(Xecrets.Slip39.Share[][] ShareGroups, byte[] Secret);
```
#### Parameters

<a name='Xecrets.Slip39.GroupedShares.GroupedShares(Xecrets.Slip39.Share[][],byte[]).ShareGroups'></a>

`ShareGroups` [Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

An array of groups of shares.

<a name='Xecrets.Slip39.GroupedShares.GroupedShares(Xecrets.Slip39.Share[][],byte[]).Secret'></a>

`Secret` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The secret encoded by the shares, or an empty array
### Properties

<a name='Xecrets.Slip39.GroupedShares.Secret'></a>

## GroupedShares.Secret Property

The secret encoded by the shares, or an empty array

```csharp
public byte[] Secret { get; set; }
```

#### Property Value
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

<a name='Xecrets.Slip39.GroupedShares.ShareGroups'></a>

## GroupedShares.ShareGroups Property

An array of groups of shares.

```csharp
public Xecrets.Slip39.Share[][] ShareGroups { get; set; }
```

#### Property Value
[Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')