namespace MCache;

public class MCache<T>
{
    private readonly Dictionary<object, T?> _cache = new();

    public void AddOrUpdate(object key, T data) => _cache[key] = data;

    public T? Get(object key)
    {
        if (!_cache.TryGetValue(key, out var cacheItem))
            return default; 
        if (cacheItem != null)
        {
            return cacheItem;
        }
        
        _cache.Remove(key);
        return default;
    }

    public void Remove(object key) => _cache.Remove(key);
    
    public void Clear() => _cache.Clear();
}