# 🕹️ Infinite Side Scroller – Geometry Dash Style

Projet Unity URP 3D : un jeu de type "runner" inspiré de Geometry Dash.  
Le joueur saute pour éviter des pièges générés de manière procédurale, collecte des pièces, et essaie d’atteindre le score final.

---

## 📌 Fonctionnalités

- Gameplay en 2D simulé dans un environnement 3D
- Joueur fixe (le monde bouge autour de lui)
- Double saut
- Génération procédurale de pièges
- Collectibles (coins) avec score
- Système de pause avec menu
- Menu principal avec scènes séparées
- Victoire à 30 points

---

## 🧱 Scènes du projet

- 🎬 `Menu.unity` – menu principal avec boutons "Play" et "Quit"
- 🎮 `Game.unity` – jeu principal avec tous les systèmes actifs

---

## 🎮 Contrôles

| Touche     | Action        |
|------------|----------------|
| Espace     | Saut (double saut autorisé) |
| Échap      | Pause / Reprendre |

---

## 🛠 Technologies

- Unity - Universal (URP 3D)
- C#
- TextMeshPro pour l’UI
- PlayerPrefs pour sauvegarde du score max

---

## ▶️ Lancer le projet

```bash
git clone https://github.com/Swixos/infinite-side-scroller.git
```

- Ouvre le projet avec Unity Hub

- Ajoute Menu.unity et Game.unity dans les Build Settings

- Lance la scène Menu.unity et clique sur "Play"

## 📁 Structure du projet

```
Assets/
├── Scenes/               # Menu.unity et Game.unity
├── Scripts/
│   ├── PlayerController.cs       # Double saut + mort
│   ├── PlatformSpawner.cs        # Spawn des traps + coins
│   ├── PlatformMover.cs          # Mouvement des pièges/pièces
│   ├── ScoreManager.cs           # Score + high score
│   ├── PauseMenu.cs              # Menu pause avec Escape
│   └── MenuUI.cs                 # Boutons du menu principal
├── Prefabs/              # Traps, coins...
├── UI/                   # Textes, canvas, win menu
├── TextMesh Pro/         # Ressources TMP
├── Materials/            # Apparence des objets
```

## 📌 Déroulement du jeu

- Le joueur saute pour éviter les pièges (tag Trap)

- Il peut collecter des pièces (Coin) pour augmenter son score

- À 30 points, un message de victoire s’affiche

- Le score est sauvegardé dans les préférences (PlayerPrefs)

- Possibilité de revenir au menu ou de quitter le jeu
