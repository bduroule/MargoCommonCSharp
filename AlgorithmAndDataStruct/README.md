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
2. Pour renverser le une liste il faut parcourir la liste en swapent les maillons jusqu'au dernier élément
```cs 
public void ReversList()
{
    MyLinkedListNode<T> prev = null;
    MyLinkedListNode<T> cur = Head;
    MyLinkedListNode<T> tmp;

    while(cur != null) {
        tmp = cur.next;
        cur.next = prev;
        prev = cur;
        cur = tmp;
    }
    Head = prev;
}
```
3. Pour trouver le milieux d'une liste il faut parcourir cette dernière jusqu'a la moitié du nombre totale de ces élément soit avec un `Count` soit avec une fonction qui vas les compter. Et retourner de dernier élément parcouru 
```cs
public MyLinkedListNode<T> SortMiddleList()
{
    MyLinkedListNode<T> TmpList = Head;

    for (int i = 0; i < Count / 2; i++) {
        TmpList = TmpList.next;
    }
    return TmpList;
}
```
### tableau
- La principale différence entre un tableau et une liste c'est la manière dont elle sont stocker dans la mémoire la liste a ces maillons éparpiller dans la mémoire la ou le tableau est un suite d'élément qui ce suivent dans la mémoire 
- voir trie dans le chapitre dédier

## Les arbres binaires

- Un arbre en informatique est un maniere de structure des donne pour pouvoir hierachiser ces dernieres Un arbre est constitué de **nœuds**, reliés entre eux par des **arêtes** selon une relations parent enfant. On distingue trois types de  **nœuds**  :

  - La  **racine**  de l’arbre est l’unique nœud ne possédant  pas de parent. *(ici noeud 1)*
  - les  **feuilles**  (ou  _nœuds externes_), éléments ne possédant  pas de fils  dans l’arbre ; *(ici noeud 4 a 7)*
   - les  **nœuds**  **internes**, éléments possédant des fils (sous-branches). *(ici noeud 2 et 3)*
  
  Le **chemin à la racine** d’un nœud est la liste des nœuds qu’il faut parcourir depuis la racine jusqu’au nœud considéré. voir ci-dessou : 
  
  
![](Image/tree.jpg)


un arbre binaire est arbre qui n'as que maximum 2 **noeud** enfant par **noeud** parent, pour ce qui est d'un arbre binaire de recherche il s'agit d'un arbre binaire dont chaque nœud du sous-arbre **gauche** ait une clé inférieure ou égale à celle du nœud considéré, et que chaque nœud du sous-arbre **droit** possède une clé supérieure ou égale à celle-ci trouver une valeur dans un arbre de recherche implique une complexité moyenne de $$O(log(n))$$ et de $$ O(n) $$ dans un cas critique ou l'arbre est complètement **déséquilibré** et ressemble à une liste chaînée car il  dans ce cas il devras parcourir les *n* element *(cette complexité est la meme pour ce qui d'ajouter de nouveau element)*


![](Image/BinaryTree.jpg)


- Pour implanter un Heap array il faut ajouter dans le tableaux d'abord les **Noeud** et après les **Noeud** enfant 



![](Image/ArrayTree.jpg)
