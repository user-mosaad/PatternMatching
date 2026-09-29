# Pattern Matching in C#

| Feature | `is` Keyword | `as` Keyword |
| ---- | ---- | ---- |
| **Primary Purpose** | **Type-checking** (Is this object a specific type?) | **Safe casting** (Cast this object to this type if possible) |
| **Return Type** | `bool` (`true` or `false`) | The converted **object reference** or `null` |
| **Supported Types** | Reference types, value types, and nullable types | Only **reference types** or **nullable value types** |
| **On Failure** | Returns `false` | 	Returns `null` (never throws an exception) |

## The `is` Keyword
The `is` operator checks if the runtime type of an object matches or is compatible with a given type.

Before C# 7.0, you used `is` just to verify a type before manually casting it.

Since **C# 7.0**, the `is` keyword supports **pattern matching**. This allows you to check the type and assign it to a new, strongly typed variable in a single, elegant step

## The `as` Keyword
The `as` operator attempts to explicitly convert an object to a specified reference type or nullable value type. If the conversion fails, it cleanly returns `null` instead of crashing your program.

⚠️ **Crucial Limitation**: You cannot use `as` with non-nullable value types (like `int`, `bool` or `double`) because value types cannot hold a `null` value. For example, `obj as int` will cause a compiler error. To circumvent this, you must use a nullable type: `obj as int?`.

## Which one should you use?
- Use `is` (**with pattern matching**) as your default choice for modern C# development. It is safe, highly readable and handles both value types and reference types seamlessly.
- Use `as` if you prefer working directly with `null` checks or want to utilise the null-coalescing operator (`??`) to provide a fallback default value:

``` csharp
// If the cast fails, fall back to an empty string
string result = (myObject as string) ?? "Default Value";
```
