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
ON condition // souvent :: tableA.tablebId = tableB.id
WHERE condition
```

### LEFT JOIN 

![](Image/left.jpg) 
jointure qui renvoie tous element de la `Table A` et les element de la `Table B` repondand a une condition.
```sql
SELECT tableA.value1, tableB.value1, tableA.value2 
FROM tableA
LEFT JOIN tableB
ON condition // souvent :: tableA.tablebId = tableB.id
WHERE condition
```

### RIGHT JOIN 

![](Image/right.jpg) 
jointure qui renvoie tous element de la `Table B` et les element de la `Table A` repondand a une condition.
```sql
SELECT tableA.value1, tableB.value1, tableA.value2 
FROM tableA
RIGHT JOIN tableB
ON condition // souvent :: tableA.tablebId = tableB.id
WHERE condition
```
