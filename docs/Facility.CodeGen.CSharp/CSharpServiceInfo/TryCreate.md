# CSharpServiceInfo.TryCreate method

Attempts to create C# info for a service.

```csharp
public static bool TryCreate(ServiceInfo serviceInfo, out CSharpServiceInfo csharpServiceInfo, 
    out IReadOnlyList<ServiceDefinitionError> errors)
```

## Return Value

True if there are no errors.

## Remarks

Even if there are errors, an invalid HTTP mapping will be returned.

## See Also

* class [CSharpServiceInfo](../CSharpServiceInfo.md)
* namespace [Facility.CodeGen.CSharp](../../Facility.CodeGen.CSharp.md)

<!-- DO NOT EDIT: generated by xmldocmd for Facility.CodeGen.CSharp.dll -->
