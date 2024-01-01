# MCache 🗄️

A simple caching library in C# for storing and retrieving data by key.

## Usage

### Installation

To use this library, include the `MCache` namespace in your C# project.

```csharp
using MCache;
```
### Example

```csharp
// Create an instance of the Cache
Cache<string> myCache = new Cache<string>();

// Add or update data in the cache
myCache.AddOrUpdate("key1", "value1");
myCache.AddOrUpdate("key2", "value2");

// Retrieve data from the cache
string? data = myCache.Get("key1");
if (data != null)
{
    Console.WriteLine($"Data for key1: {data}");
}

// Remove data from the cache
myCache.Remove("key2");

// Clear the entire cache
myCache.Clear();
```

## Class Structure

### `Cache<T>`

#### Methods

- `AddOrUpdate(object key, T data)`: Adds or updates data in the cache for the specified key.
- `Get(object key)`: Retrieves data associated with the provided key from the cache.
- `Remove(object key)`: Removes data associated with the provided key from the cache.
- `Clear()`: Clears all data stored in the cache.

Feel free to customize and integrate this simple caching mechanism into your C# projects!
