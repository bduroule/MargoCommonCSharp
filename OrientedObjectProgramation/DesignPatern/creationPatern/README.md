# Disigne pattern de Création

## Singleton

Singleton est un pattern qui sert a créer un instance unique et offre un point d'accès unique a cette instance, ce qui fait qu'avec singleton on s'assure qu'il ne peut pas y avoir plusieurs instance d'un type précis  il y a plusieurs façon d'implementer un Singleton mais elle on toutes ces point commun: 

- Un constructeur privée sans paramètre, unique pour empécher d'autre class de l'instancier (on peut utiliser sealed)
- Une variable statique qui garde l'instance unique
- Un accès unique a linstance unique créer 

### Version de base non thread safe

```cs
public sealed class Singleton
{  
	private static Singleton instance = null;
    Singleton() {}  
    
    public static Singleton Instance {  
        get {   
                if (instance == null) {  
                    instance = new R(); 
                }  
                return instance;  
	     }  
	}  
}
```
Le problème avec cette version c'est que si deux thread vérifie la condition   `if (instance == null)` en meme temps les deux vont entrer dans la condition et créer deux instance, ce qui casse le pattern. Pour éviter ça il faut fair un implementation dite **Thread Safe**.

### Version Thread Safe

pour faire un version **Thread safe** de Singleton il y a plusieurs approche possible que nous allons détailler ci-dessous  

- la premiere est d'utiliser un `Lock`, `Lock` est une Instruction qui permet de pérmètre a un seule tread a la fois d'accéder au block determiner ce qui rèsous le problème. on peut egalement faire un double check pour plus de surter : 

```cs
public sealed class Singleton
{  
	private static readonly object lockObj = new object();
    private static Singleton instance = null;
    
    Singleton() {}  
    
    public static Singleton InstanceSimpleCheck {  
        get {  
            lock(lockObj) {  
                if (instance == null) {  
                    instance = new R();  
                }  
                return instance;  
            }  
        }  
    } 
    
    public static Singleton InstanceDoubleCheck {  
        get {
		     if (instance == null) {
	            lock(lockObj) {  
	                if (instance == null) {  
	                    instance = new R();  
	                }  
	                return instance;  
	            }  
	        } 
        } 
    }  
}
```
- On peut également utiliser un constructeur static car en C# car ils sont utilisés pour s'exécuter seulement lorsqu'une instance de la classe est créée ou qu'un membre statique est référencé et pour s'exécuter seulement une fois par AppDomain
```cs
public sealed class Singleton
{  
	private static Singleton instance = new Singleton();
	
    private Singleton() {} 

	static Singleton() {} 
    
    public static Singleton Instance {  
        get {
	         return instance;  
	     }  
	}  
}
```
- On peut egalement utiliser `Lazy` qui est une class qui permet de faire de l'initialisation tardive, on vas donc donner le constructeur de `Singleton` a un delegate de `Lazy`.

```cs
public sealed class Singleton
{
    private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
	private static Singleton instance { get { return lazy.Value; } }
	
    private Singleton() {} 
     
}
``` 

## Factory

Factory est un pattern qui permet entre autre de repondre au principe **SOLID** de **l'inversion de dépandence** *('il faut toujours faire dépendre des interface qui définisse un contrat, plutôt que de fair hériter des class sucéptible d'être modifier.)* pour ce faire 
