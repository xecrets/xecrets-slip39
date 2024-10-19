#### [Xecrets.Slip39](index.md 'index')
### [Xecrets.Slip39](Xecrets.Slip39.md 'Xecrets.Slip39')

## Share Class

A representation of a Shamir secret sharing share.

```csharp
public class Share
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Share
### Methods

<a name='Xecrets.Slip39.Share.Parse(string)'></a>

## Share.Parse(string) Method

Parse a share string into a [Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share') object.

```csharp
public static Xecrets.Slip39.Share Parse(string stringValue);
```
#### Parameters

<a name='Xecrets.Slip39.Share.Parse(string).stringValue'></a>

`stringValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The string to parse.

#### Returns
[Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share')  
A [Share](Xecrets.Slip39.Share.md 'Xecrets.Slip39.Share') object.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')

<a name='Xecrets.Slip39.Share.ToString()'></a>

## Share.ToString() Method

Returns a string that represents the current object.

```csharp
public override string ToString();
```

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
A string that represents the current object.

<a name='Xecrets.Slip39.Share.ToString(string)'></a>

## Share.ToString(string) Method

Returns a string that represents the current object.

```csharp
public string ToString(string format);
```
#### Parameters

<a name='Xecrets.Slip39.Share.ToString(string).format'></a>

`format` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

How the string should be formated. Empty and "G" produces a list of space separated  
            mnemonic words. "64" produces an URL-safe base 64 representation. "X" produces a hex string.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The string representation.

#### Exceptions

[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')