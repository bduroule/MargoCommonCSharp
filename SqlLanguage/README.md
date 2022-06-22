# Langage SQL

## La manipulation de tables

### mot clef

- `SELECT * FROM table WERE condition` = selectionne tous d'une pour une condition 
- `GROUP BY` regroup les donner dune meme ressource ex : 

|Nom| valeur|
|--|--|
| A|10|
|A|9|
|B| 10|
|A| 1|
|B| 2|

`SELECT nom, SOMME(valeur F) FROM table GROUP BY nom`

|Nom| valeur|
|--|--|
| A|20|
|B| 12|

- `SELECT v1, v2 FROM table GROUP BY v1 HAVING COUNT(v2) > 2` La clause `HAVING` a été ajoutée à SQL car le mot clé WHERE ne peut pas être utilisé avec les fonctions d'agrégation.
- Supprimer un element:  `DELETE FROM table_name WHERE condition`
- Supprimer toute les donnee d'une table: `TRUNCATE TABLE utilisateur`  
- Supprimer la talbe `DROP TABLE nom_table` 
- metre a jour des donner : `UPDATE table SET nom_colonne_1 = 'nouvelle valeur' WHERE condition `
-  Renomer table: `RENAME TABLE old_table_name TO new_table_name`
-  Insérer une colonne : `ALTER TABLE nom_table ADD nom_colonne type_donnees`
- Supprimer une colonne `ALTER TABLE nom_table DROP columne`

## Jointure

une jointure permet de fusionner les resultats de plusieur table il ya 6 type de jointure : 

### INNER JOIN 

![](Image/inner.jpg) 
jointure interne pour retourner les enregistrements quand la condition est vrai dans les 2 tables. C’est l’une des jointures les plus communes.
```sql
SELECT tableA.value1, tableB.value1, tableA.value2 
FROM tableA
INNER JOIN tableB
ON condition # souvent :: tableA.tablebId = tableB.id
WHERE condition
```

### LEFT JOIN 

![](Image/left.jpg) 
jointure qui renvoie tous element de la `Table A` et les element de la `Table B` repondand a une condition.
```sql
SELECT tableA.value1, tableB.value1, tableA.value2 
FROM tableA
LEFT JOIN tableB
ON condition # souvent :: tableA.tablebId = tableB.id
WHERE condition
```

### RIGHT JOIN 

![](Image/right.jpg) 
jointure qui renvoie tous element de la `Table B` et les element de la `Table A` repondand a une condition.
```sql
SELECT tableA.value1, tableB.value1, tableA.value2 
FROM tableA
RIGHT JOIN tableB
ON condition # souvent :: tableA.tablebId = tableB.id
WHERE condition
```

### FULL JOIN

![](Image/full.jpg) 
jointure externe pour retourner les résultats quand la condition est vrai dans au moins une des 2 tables. le champ qui match pas sont remplasser par `null`

```sql
SELECT tableA.value1, tableB.value1, tableA.value2 
FROM tableA
RIGHT JOIN tableB
ON condition
WHERE condition
```

### NATURAL JOIN

le natural join premet de fusionner deux table qui une ou des colonne en commun et sortira tous les champ identique, il n'y a pas besoin de `ON` du coup.

```sql
SELECT *
FROM table1
NATURAL JOIN table2
```

### CROSS JOIN

![](Image/cross.jpg)
Le `CROSS JOIN` permet de, pour chaque ligne dune table A, on retournera toute les ligne d'une table B jointe a la ligne en question. Elle est souvent jointe a un `WHERE` pour filtrer les résultats.

```sql
SELECT *
FROM table1
CROSS JOIN table2
```

### SELF JOIN

SELF JOIN permet de joindre une table avec elle meme [......]

```sql
SELECT `u1`.`u_id`, `u1`.`u_nom`, `u2`.`u_id`, `u2`.`u_nom`
FROM `utilisateur` as `u1`
LEFT OUTER JOIN `utilisateur` as `u2` ON `u2`.`u_manager_id` = `u1`.`u_id`
```

## Mise en application

En SQL un index est une clef unique permentant d'identifier un element dans une table. Il sont utilisés pour récupérer les données de la base de données plus rapidement qu'autrement. Les utilisateurs ne peuvent pas les voir, ils sont juste utilisés pour accélérer les recherches/requêtes.pour creer un Index il faut utiliser l'instruction CREATE INDEX.

```sql
# cree un index
CREATE  INDEX  _index_name_  
ON  _table_name_ 

#cree un index unique 
CREATE  UNIQUE  INDEX  _index_name_  
ON  _table_name_
```
On peut aussi creer un index sur ou plusieur colonne 
```sql
#Une col
CREATE  INDEX  _index_name_  
ON  _table_name_ (_column1_);
# Plusieur col
CREATE  INDEX  _index_name_  
ON  _table_name_ (_column1_, _column2_, ...);
```
