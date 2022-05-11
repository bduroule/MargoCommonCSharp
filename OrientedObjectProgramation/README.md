# La programmation orientée object

## Base
### les 6 principe de la OOP
les principes de base de la programmation orienter object sont :

 - L'heritage permet de réutiliser du code propre a une class de redéfinir certain de ces comportement
 - l'encapsulation est un concepte qui permet de stocker des donner en cachant l'implémentation de l'objet, c'est-à-dire en empêchant l'accès aux données par un autre moyen que les services proposés. L'encapsulation permet donc de garantir l'intégrité des données contenues dans l'objet.
 - L'abstraction permet de cacher des method ou des propriété inutile a l'utilisateur
 - Le polymorphisme permet de substituer une class parent a une class enfant
 ```cs
 public class A {}
 public class B : A {}

B instance = new A();
 ``` 
 dans cette example on voit qu'on définit un objet B qu'on instancie en luis donnant un objet `A` ca fonction car `B` hérite de `A`

 - Les Interface sont des contrat obligent les class qui les utilise a implémenté les signature cette dernière
 - les class static sont des class qui n'ont pas besoin d'être instencier pour être utiliser on peux directement appeler les method de cette dernière ce qui rejoint le principe d'abstraction vue plus haut
 
### Heritage Simple et multiple

L'heritage simple consiste a ne pouvoir hériter que d'une class comme le C# qui permet d'hériter d'une class mais de plusieurs interface, contrairement au C++ qui permet d'hériter de plusieurs class.

### Modificateurs d’accès
 
 Le C# permet de donnée l'accer ou non a certaine ressource en fonction de modificateurs que sont : 
 

 - public: accessible partout
 - private: accessible uniquement dans la class
 - protected: accessible dans la class et dans les class hériter
 - internal: accessible dans une même assembly
 - sealed: ne peut pas être hériter
 - static: ...
 - readonly: ..

## Les classes

### Class et object

Une class est un plan selon le quelle on vas construire notre objet, le programme ne manipule pas de class mais des objet, pour le programme un objet est la concrétisation d'une class.

### Class et struct 

Une structure est un ensemble de donner qui se suive dans la memoir elle sont stocker dans la stack, alors qu'une class doit être instancier et est stocker dans la hype.

###  Structures de donnée

ils existe plusieurs structures de donnée chacune d'entre elle hérite de `IEnumerable` ce qui permet de les parcourir grace a un `foreach` comme :

- les `Dictionary` qui permette de stocker dans un format clef / valeur 
- les `List` qui est un tableau a allocation dynamique
- les `Hashset` qui un tableau de clef unique

### Implémentation Dictionnaire

Le Dictionnaire est une structure de donner qui stock dans un format clef / valeur, il faut comprendre par la une clef par valeur et cette doit être unique, pour ce faire il fair un table de hachage qui transformer la clef en un int que l'on vas pouvoir utiliser comme index dans un tableau pour ce faire on vas utiliser `GetHashCode`  pour générer un hash et `Equale` pour comparer les hash, a noter que si on utilise un objet en tant que clef il faut `overide` ces deux méthode. 

### Constructeur

un constructeur est une méthode qui est appeler à l'initialisation de l'objet. [...]


## Les Design Patterns

### Définition 

Les design pattern (patron de conception) est un arrangement standard de modules, pour fair simple il s'agit de solution standard pour répondre une problématique courante, il est considerer comme _bonne pratique_ d'utiliser des  design pattern dans le développement de logiciel.

### Gang of Four

Le gang of four est un group de 4 auteur qui on définit un certain nombre de design patterns qu'ils classent en 3 catégorie

- les patron de creation qui couvre les instanciation de class, c'est à dire de création et de configuration d'objets
- les patron de structure qui couvre la structure des class pour avoir le moins de dépendance possible entre l'implémentation et l'utilisation
- les patron de comportement qui définissent le comportement d'une class

### Singleton

Singleton est un design pattern qui permet d'instancier un objet unique comme suit
```cs
public sealed class SingletonNotLazy<R>
{  
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
```
on peut voir que nous avons un class sealed qui as une instance d'un objet `T` qui si il est deja instancier ne seras pas reinstancier le lock permet d'être **_thread safe_** ce qui veut dire que deux thread ne peuvent pas accéder a un meme element en meme temps.
```cs
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
```
ont peut voir dans cette nouvelle version qu'ont ne regarde plus si la propriété est instancier car la method est static est donc ne s'execute qu'une fois par processus de l'application 
`Lazy` dans ce contexte permet de faire de l'initialisation tardive ce qui veut dire que l'objet seras instancier a sont utilisation.

### Decorateur

