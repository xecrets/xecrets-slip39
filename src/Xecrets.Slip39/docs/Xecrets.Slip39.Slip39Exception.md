#### [Xecrets.Slip39](index.md 'index')
### [Xecrets.Slip39](Xecrets.Slip39.md 'Xecrets.Slip39')

## Slip39Exception Class

Creates an exception for catcheable Slip39 errors. This will only be thrown when the error is due to incorrect
input data, not due to an internal error or programming errors et.

```csharp
public class Slip39Exception : System.Exception
```

Inheritance [System.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System.Object') &#129106; [System.Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception 'System.Exception') &#129106; Slip39Exception
### Constructors

<a name='Xecrets.Slip39.Slip39Exception.Slip39Exception(Xecrets.Slip39.ErrorCode,string)'></a>

## Slip39Exception(ErrorCode, string) Constructor

Creates an exception for catcheable Slip39 errors. This will only be thrown when the error is due to incorrect
input data, not due to an internal error or programming errors et.

```csharp
public Slip39Exception(Xecrets.Slip39.ErrorCode errorCode, string message);
```
#### Parameters

<a name='Xecrets.Slip39.Slip39Exception.Slip39Exception(Xecrets.Slip39.ErrorCode,string).errorCode'></a>

`errorCode` [ErrorCode](Xecrets.Slip39.ErrorCode.md 'Xecrets.Slip39.ErrorCode')

The error code associated with the error.

<a name='Xecrets.Slip39.Slip39Exception.Slip39Exception(Xecrets.Slip39.ErrorCode,string).message'></a>

`message` [System.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System.String')

The message associated with the error.
### Properties

<a name='Xecrets.Slip39.Slip39Exception.ErrorCode'></a>

## Slip39Exception.ErrorCode Property

The error code associated with the error.

```csharp
public Xecrets.Slip39.ErrorCode ErrorCode { get; }
```

#### Property Value
[ErrorCode](Xecrets.Slip39.ErrorCode.md 'Xecrets.Slip39.ErrorCode')