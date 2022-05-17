# Culture Générale

## API RESTful

Une API est une interface de programmation, qui permet, via des requête http dans le cas d'une API REST, d'interagir avec des donnée que ce soit DB (Data Base) ou via d'autre API dit externe, en faisant des CRUD (Creation, Read, Update, Delete) par exemple.  Une requête est constituer de plusieurs élément que sont l'URL http, le header ou on vas pouvoir mettre un certain nombre d'indication comme un token d'identification, la norme de codage de charactere..., le body qui vas permettre d'envoyer des donner a l'API en JSON par exemple, la réponse qui vas contenire les élément demander, ou les donner qui on été ajouter ou modifier par exemple, et le statu pour l'état du retour de la requête qui est normé comme suit 

- 2XX: Succès de la requête
- 4XX: échec du a une erreur de l'utilisateur  
- 5XX: qui sont dû a une erreur server

comme 200 qui dit que tout c'est bien passer ou 404 qui indique qu'il n'a pas trouver la ressource.

une API REST a plusieur type de requête comme :

- POST (Publier) qui sert, le plus souvent, via un body a ajouter des ressource,
- GET (Obtenir) qui est utiliser le plus souvent pour remonter des donnée
- PUT (Mettre) qui est le plus souvent utiliser pour mettre a jour des donnée 
- DELET (Supprimer) qui le plus souvent est utiliser pour supprimer des donnée
- PATCH (corriger) sert a mettre a jour une partie des donner

## SOLID

SOLID est un principe de programmation orienter objet **POO** ou **OPP**  en anglais qui compte 5 principe qui sont : 

- **S**  Responsabilité unique (Single responsibility principle)
- **O**   Ouvert/fermé (Open/closed principle)
- **L**  - Substitution de Liskov (Liskov substitution principle)
- **I**  - Ségrégation des interfaces (Interface segregation principle)
- **D**  - Inversion des dépendances (Dependency inversion principle)

### Single responsibility

Ce principe indique que  

> Une classe doit avoir une seule et unique raison de changer, ce qui signifie qu’une classe ne doit appartenir qu’à une seule tâche.

Ce qui signifie que chaque class, méthode, propriétaire ou autre doit avoir un seule raison d'exister
imaginons un class qui calcul la somme de 2 nombre et retourne du code html qui affiche le résultat, si ont veut maintenant récupérer le résultat en JSON on vas devoir refaire la méthode.

### Open / Close

Le principe ouvert/fermé précise ce qui suit :

> Les objets ou entités devraient être ouverts à l’extension mais fermés à la modification.

ce qui veut dire qu'une class doit être extensible via l'héritage par exemple ou via décorateur (voir design pattern), mais pas modifiable. Imaginons notre class calcule somme qui calculerait la somme d'un rectangle, donc elle si on voulais calculer la somme d'un triangle il faudrait rajouter une méthode a cette class. Mais il faudrait mieux créer une class qui calcule une somme, et créer une class pour chaque type de forme qui hériterai de cette class en réecrivent la méthode somme.

### Liskov substitution

Le principe de substitution de Liskov précise ce qui suit :

> Si q(x) est une propriété démontrable pour tout objet x de type T, alors q(y) est vraie pour tout objet y de type S tel que S est un sous-type de T.

Ça signifie que chaque class qui est dériver d'une autre doit pouvoir être substituer a sa class mère en suivant le principe du polymorphisme. Si nous avons une class A qui calcule la somme et renvoie un tableau de somme, et un class B qui calcule le carrer de cette somme et le rend dans du code html. Dans ce cas nous ne pourrons pas substituer la class A a la class B

### Ségrégation des interfaces

Le principe de ségrégation des interfaces indique ce qui suit :

>Un client ne doit jamais être forcé à installer une interface qu’il n’utilise pas et les clients ne doivent pas être forcés à dépendre de méthodes qu’ils n’utilisent pas.

Ce qui signifie que si on code un système de collection nous devons mettre dans l'interface uniquement ce qui est nécessaire pour faire fonctionner.

### Inversion des dépendances

Le principe d’inversion des dépendances précise :

> Les entités doivent dépendre des abstractions, pas des implémentations. Il indique que le module de haut niveau ne doit pas dépendre du module de bas niveau, mais qu’ils doivent dépendre des abstractions.

Ça signifie qu'il faut toujours faire dépendre des interface qui définisse un contrat, plutôt que de fair hériter des class sucéptible d'être modifier.

## TDD

TDD ou Test Driven Développement est une pratique qui consiste a déveuloper les test avant le d'écrire le code ce qui veut dire qu'on vas d'abord établir le comportement et les retour attendu du code avant de l'implémanter. L'un des avantages des ces test est qu'il peuvent servire de documentation. Le deveulopement ce fait sur plusieurs iteration, chaque itération ce fait sur 3 etape

- **red** test corespondand au resultat attendu
- **green** code de production passent le test
- **refactor** factorise le code sans ajouter ou modifier le comportement

Uncle Bob du TDD évoque trois règle :

- écrire un test qui échoue avant n'importe qu'elle code de production 
- ne pas écrire plus de teste que necéssaire pour faire échouer ou ne pas compiler
- écrire que le code suffisant pour faire reussire les teste

## BDD

**BDD** ou **behaviour-driven development**  (_programmation pilotée par le comportement_), il a pour but de faire colaborer les développeur et le méier (_product owner_) pour maximiser le logiciel, ca ce fait par la conversation entre justement les développeur, les PO, et les QA (tester) pour essayer de clarifier au mieux le besoin. Pour ce faire on vas fonctionner par exemple ces exemple seront dicter a l'orale mais aussi a l'écrit, on redige alors des senario, qu'on ecrit en gerkin (un language semi naturel), les senario doivent etre bref et doivent utiliser le vocabulaire du metier pour etre au plus pres de la demande, lorsque les senario sont définit on peut, si besoin metre en place le troisième pilier du **BDD** a savoir: 'lautomatisation.

## DDD
 
DDD ou Domain Driven Design n'est pas une méthodologie comme TDD ou BDD mais plutôt une approche dériver du blue book qui a pour but de controler la complexité, on peut observer 3 grand principe dans le DDD qui sont :

- la compréhension du domaine, avoir une vision commune avec les expert du métier
- la tactique qui consiste a avoir une implémantation au plus prés de l'image mantal qu'on c'est fait.
- la strategie qui consiste a decouper les domaine en sous domaine eu-même découpé et a definir ces sous domaine aussi que leur relation entre eux

le pattern du DDD est donc de travailler en micro-service connecter les un au autre.
