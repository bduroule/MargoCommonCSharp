// class<out T, in R>
// variance et contrevariance

// Wakereferance

// di p 
// factory 
// SOLID

namespace DesignPatern;

public sealed class SingletonNotLazy<R> {  
    SingletonNotLazy() {}  

    private static readonly object lockObj = new object();  
    private static R instance = null;  
    public static R Instance {  
        get {  
            lock(lockObj) {  
                if (instance == null) {  
                    instance = new R();  
                }  
                return instance;  
            }  
        }  
    }  
} 

public sealed class Singleton<R> where R: new()
{
    private Singleton()
    {}

    private static readonly Lazy<R> lazy = new Lazy<R>(() => new R()); 
    public static R Instance    
    {    
        get    
        {
            return lazy.Value;    
        }    
    }
}

