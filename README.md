# INF11107 - Programmation orientée objet I

## Travail Pratique #1

Ce projet contient plusieurs programmes en C# pour répondre aux exigences du TP1 du cours INF11107.

### 1. Delta

Programme permettant de résoudre une équation du second degré en ℝ :

```
ax² + bx + c = 0
```

### 2. Division

Programme pour calculer le quotient et le reste d’une division sans utiliser les opérateurs `/` ou `%`.

### 3. HexaToBin

Programme pour convertir un nombre hexadécimal en binaire.
Exemple : `10₁₆ = 10000₂`

### 4. EcartType

Programme pour calculer l’écart-type d’un tableau saisi par l’utilisateur :

$$
\sigma = \sqrt{\frac{1}{n}\sum_{i=1}^n (x_i - \overline{x})^2}
$$

Où $\overline{x}$ est la moyenne et $n$ le nombre d’éléments.

### 5. ClasserPhrase

Programme pour classer des phrases selon leur poids (A=1, B=2, ..., Z=26).

### 6. FusionMots

Programme qui combine deux mots en alternant leurs lettres.
Exemple :

```
mot1 = "bonjour", mot2 = "soir" → mot3 = "bsoonijrour"
```

### 7. AffCaractères

Programme qui affiche des lettres (à partir de "A") selon un nombre de lignes et de lettres donné.

### 8. MachineÀSous

Programme simulant une machine à sous :

- L’utilisateur saisit un montant.
- 5 entiers aléatoires entre 0 et 9 sont générés.
- Si les 5 sont identiques : jackpot (montant^5).
- Si un chiffre apparaît 3 ou 4 fois : l’utilisateur récupère son montant.
- Une partie du code (en commentaire) permet d’empêcher de gagner le jackpot.

### 9. QCM

Programme posant 4 questions aléatoires (parmi 10), avec 3 choix de réponses chacune.

- Résultat :
  - A : 4 bonnes réponses
  - B : 3 bonnes réponses
  - D : 2 bonnes réponses
  - E : 1 ou 0 bonne réponse
- Correction : affiche les questions ratées avec la bonne réponse.

### 10. Menu Principal

Programme principal (portant le nom d’un membre de l’équipe) permettant d’exécuter chaque fonction via un menu.

## Exécution

Ce projet est écrit en C# (.NET 9.0). Pour compiler et exécuter :

```bash
dotnet build
dotnet run
```

## Utilisation

Après avoir lancé le programme avec `dotnet run`, un menu s'affiche dans la console avec la liste des exercices disponibles.

1. Saisissez le numéro de l'exercice que vous souhaitez exécuter, puis appuyez sur Entrée.
2. Suivez les instructions affichées pour chaque exercice.
3. Pour quitter le programme, choisissez l'option "0. Quitter" dans le menu.
