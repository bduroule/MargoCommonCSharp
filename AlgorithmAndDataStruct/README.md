# L’algorithmique et les structures de données
## Les listes chaînées et les tableaux
### Les listes chaînées

 -  sur la figure ci-dessous on peux voire une représentation schématiquement une liste chaînée d’entiers. 
 ![](Image/Untitled.jpg) 
 qui est represanter par un objet `Node` qui implemanent une proprieter `Value` qui est un entier, une instance `Node` qui point sur le maillons suivant
 ```cs
public class Node
{
	public int Value { get; set; }
	public Node Next { get; set; }
}
 ```
 - Pour définir une liste avec un type de donnée stockée définissable au moment de l’instanciation de LinkedList il faut utiliser un type génerique `T` dans la signature de la class LinkedList
```cs
public class LinkedList<T>
{
	// code
}
```
et initialiser de la magnere suivante 
```cs
LinkedList<int> numbers = new LinkedList<int>();
LinkedList<string> strings = new LinkedList<string>();
```
- Algoritm
 1. pour Supprimer un élément on va parcourir la liste en en regardant si le mallion d'après est la valeur a supprimer si c'est le cas on sort de la boucle et définit que le maillon suivant (élément a supprimer)  est égale a sont suivant.
```cs
public void Remove(T item)
{
    MyLinkedListNode<T> tmpListToRemove = Head;

    while (tmpListToRemove.next != null) {
        if (tmpListToRemove.next.item.Equals(item)) {
            break ;
        }
        tmpListToRemove = tmpListToRemove.next;
    }
    if (tmpListToRemove.next != null)
        tmpListToRemove.next = tmpListToRemove.next.next;
    else
        RemoveLast();
}
```
