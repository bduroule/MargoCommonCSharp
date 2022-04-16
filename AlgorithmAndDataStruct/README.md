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
