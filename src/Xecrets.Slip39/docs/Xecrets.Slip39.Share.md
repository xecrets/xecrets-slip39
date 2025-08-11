#### [Xecrets.Slip39](index.md 'index')
### [Xecrets.Slip39](Xecrets.Slip39.md 'Xecrets.Slip39')

## Share Class

A representation of a Shamir secret sharing share.

```csharp
public class Share
```

Inheritance [System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System.Object') &#129106; Share
### Properties

<a name='Xecrets.Slip39.Share.Prefix'></a>

## Share.Prefix Property

The [SharePrefix](https://learn.microsoft.com/en-us/dotnet/api/shareprefix 'SharePrefix') meta data of the share.

```csharp
public Xecrets.Slip39.SharePrefix Prefix { get; }
```

#### Property Value
[SharePrefix](Xecrets.Slip39.SharePrefix.md 'Xecrets.Slip39.SharePrefix')
### Methods

<a name='Xecrets.Slip39.Share.Parse(string)'></a>

## Share.Parse(string) Method

Parse a share string into a [Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share') object.

```csharp
public static Xecrets.Slip39.Share Parse(string stringValue);
```
#### Parameters

<a name='Xecrets.Slip39.Share.Parse(string).stringValue'></a>

`stringValue` [System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System.String')

The string to parse.

#### Returns
[Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share')  
A [Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share') object.

#### Exceptions

[Slip39Exception](Xecrets.Slip39.Slip39Exception.md 'Xecrets.Slip39.Slip39Exception')

<a name='Xecrets.Slip39.Share.ToString()'></a>

## Share.ToString() Method

Returns a string that represents the current object.

```csharp
public override string ToString();
```

#### Returns
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System.String')  
A string that represents the current object.

<a name='Xecrets.Slip39.Share.ToString(string)'></a>

## Share.ToString(string) Method

Returns a string that represents the current object.

```csharp
public string ToString(string format);
```
#### Parameters

<a name='Xecrets.Slip39.Share.ToString(string).format'></a>

`format` [System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System.String')

How the string should be formated. Empty and "G" produces a list of space separated
            mnemonic words. "64" produces an URL-safe base 64 representation. "X" produces a hex string.

#### Returns
[System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System.String')  
The string representation.

#### Exceptions

[System.FormatException](https://learn.microsoft.com/en-us/dotnet/api/system.formatexception 'System.FormatException')