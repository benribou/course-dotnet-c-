# Exercices de C# - TP1, TP2 et TP3

Réalisé par Benjamin Ribou ✍️

## Structure du Projet

Le dépôt est divisé en trois parties principales : **TP1**, **TP2** et **TP3**. Chaque partie contient des dossiers correspondant aux exercices traités.

---

### 📂 TP1

Les exercices du TP1 portent sur la création de classes et la manipulation d'objets en C#. Voici un aperçu des dossiers :

1. **1_ARTICLE**  
   - Création d'une classe `Article` avec des propriétés telles que `Name`, `Price` et `Quantity`.
   - Implémentation de méthodes pour afficher, ajouter ou retirer des articles, ainsi que pour créer un nouvel article via une saisie utilisateur.

2. **2_ARTICLE_TYPÉ**  
   - Extension de la classe `Article` pour inclure un champ `Type` utilisant une énumération (`Alimentaire`, `Droguerie`, `Habillement`, `Loisir`).
   - Gestion des articles avec leur type et test via la saisie utilisateur.

3. **3_ARTICLE_TABLE**  
   - Manipulation d'un tableau d'articles (`Article[]`).
   - Initialisation, affichage et modification des articles contenus dans le tableau.

---

### 📂 TP2

Les exercices du TP2 explorent des concepts avancés de programmation orientée objet, notamment les interfaces, les classes abstraites et les délégués.

1. **1_INTERFACES**  
   - Création de l'interface `IRentable` avec la méthode `CalculateRent`.
   - Implémentation de l'interface dans des classes comme `Livre`, `Disque` et `Vidéo`.
   - Utilisation polymorphique des objets via une liste d'articles (`List<IRentable>`).

2. **2_CLASSES_ABSTRAITES**  
   - Création d'une classe abstraite `Publication` avec une méthode abstraite `PublishDetails`.
   - Implémentation dans les classes dérivées (`Livre`, `Disque`, `Vidéo`) pour afficher les détails spécifiques à chaque type.
   - Test des fonctionnalités via une liste générique de publications (`List<Publication>`).

3. **3_DÉLÉGUÉS**  
   - Déclaration d'un délégué `DiscountStrategy` pour calculer des remises.
   - Implémentation de différentes stratégies de remise : remise fixe, remise par type, et remise par quantité.
   - Application des stratégies de remise à une liste d'articles pour afficher le prix final après la meilleure remise.

---

### 📂 TP3

Les exercices du TP3 introduisent des notions avancées de manipulation de données avec **LINQ**, **expressions lambda**, et **sérialisation JSON**.

1. **1_ANALYSE_LINQ**  
   - Utilisation de **LINQ** pour :
     - Filtrer des articles en fonction de leur type.
     - Trier les articles par prix.
     - Calculer des statistiques comme la valeur totale du stock.
   - Utilisation de **types anonymes** pour projeter des vues simplifiées.

2. **2_MÉTHODES_EXTENSION**  
   - Création d'une méthode d'extension `AfficherTous` pour afficher les détails de tous les articles d'une liste directement.

3. **3_EXPORT_IMPORT_JSON**  
   - Exportation de la liste d'articles en JSON à l'aide de la bibliothèque **System.Text.Json**.
   - Importation des données depuis un fichier JSON pour recréer et afficher les articles.

---

## 🚀 Comment Exécuter les Exercices

1. Clonez le dépôt :
   ```bash
   https://github.com/benribou/course-dotnet-csharp.git
