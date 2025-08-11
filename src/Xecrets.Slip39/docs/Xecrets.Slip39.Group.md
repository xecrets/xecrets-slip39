#### [Xecrets.Slip39](index.md 'index')
### [Xecrets.Slip39](Xecrets.Slip39.md 'Xecrets.Slip39')

## Group Class

Defines the main parameter of a group.

```csharp
public record Group : System.IEquatable<Xecrets.Slip39.Group>
```

Inheritance [System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System.Object') &#129106; Group

Implements [System.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System.IEquatable`1')[Group](Xecrets.Slip39.Group.md 'Xecrets.Slip39.Group')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System.IEquatable`1')
### Constructors

<a name='Xecrets.Slip39.Group.Group(int,int)'></a>

## Group(int, int) Constructor

Defines the main parameter of a group.

```csharp
public Group(int ShareThreshold, int ShareCount);
```
#### Parameters

<a name='Xecrets.Slip39.Group.Group(int,int).ShareThreshold'></a>

`ShareThreshold` [System.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System.Int32')

Share threshold for group i, a positive integer, 1 ≤ Ti ≤ Ni.

<a name='Xecrets.Slip39.Group.Group(int,int).ShareCount'></a>

`ShareCount` [System.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System.Int32')

Total number of shares in group i, a positive integer, 1 ≤ Ni ≤ 16.
### Properties

<a name='Xecrets.Slip39.Group.ShareCount'></a>

## Group.ShareCount Property

Total number of shares in group i, a positive integer, 1 ≤ Ni ≤ 16.

```csharp
public int ShareCount { get; init; }
```

#### Property Value
[System.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System.Int32')

<a name='Xecrets.Slip39.Group.ShareThreshold'></a>

## Group.ShareThreshold Property

Share threshold for group i, a positive integer, 1 ≤ Ti ≤ Ni.

```csharp
public int ShareThreshold { get; init; }
```

#### Property Value
[System.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System.Int32')