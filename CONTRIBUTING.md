# Contributing to Street Football 3D

## 🤝 Come Contribuire

Apprezziamo molto i contributi! Segui questi step:

### 1. Fork & Clone
```bash
git clone https://github.com/YOUR_USERNAME/StreetFootball3D.git
cd StreetFootball3D
git remote add upstream https://github.com/jacksemintendi013/StreetFootball3D.git
```

### 2. Crea un Branch
```bash
git checkout -b feature/your-feature-name
# o per bug fix:
git checkout -b fix/bug-description
```

### 3. Fai i Tuoi Cambiamenti
- Segui le convenzioni di codice C# (.NET)
- Commenta il codice complesso
- Testa i tuoi cambiamenti

### 4. Commit & Push
```bash
git add .
git commit -m "Add/Fix: breve descrizione del cambiamento"
git push origin feature/your-feature-name
```

### 5. Apri una Pull Request
- Descrivi chiaramente cosa hai fatto
- Allega screenshot/video se rilevante
- Attendi review

## 📋 Convenzioni di Codice

### Naming
```csharp
// Classi: PascalCase
public class PlayerController { }

// Metodi: PascalCase
public void MovePlayer() { }

// Variabili: camelCase
private float moveSpeed;

// Costanti: UPPER_CASE
private const float DEFAULT_SPEED = 5f;

// Privato: _underscore prefix (opzionale)
private float _internalSpeed;
```

### Struttura File
```csharp
using statements;

namespace StreetFootball;

[SerializeFields]
public class ClassName
{
    // Public properties
    public float PublicProperty { get; set; }
    
    // Private fields
    [SerializeField]
    private float privateField;
    
    // Constructor
    public ClassName() { }
    
    // Public methods
    public void PublicMethod() { }
    
    // Private methods
    private void PrivateMethod() { }
}
```

### Documentazione
```csharp
/// <summary>
/// Breve descrizione del metodo
/// </summary>
/// <param name="param1">Descrizione parametro</param>
/// <returns>Descrizione del valore ritornato</returns>
public void MyMethod(float param1)
{
    // Implementation
}
```

## 🎯 Aree di Contribuzione Prioritarie

### Alto Priorità
- [ ] Implementazione menù principale
- [ ] Open world city map
- [ ] Miglioramenti AI avversari
- [ ] Ottimizzazione mobile

### Medio Priorità
- [ ] Più skill moves
- [ ] Sistema reward avanzato
- [ ] Effetti particellari
- [ ] Audio/Musica

### Basso Priorità
- [ ] Cosmetics aggiuntive
- [ ] Animazioni bonus
- [ ] Tema alternativo UI

## 🧪 Testing

Prima di fare una PR, testa:

```csharp
// Unit test example
[Test]
public void PlayerMovement_ValidInput_MovesSuccessfully()
{
    // Arrange
    var player = new PlayerController();
    Vector3 inputDirection = Vector3.forward;
    
    // Act
    player.Move(inputDirection);
    
    // Assert
    Assert.AreNotEqual(Vector3.zero, player.GetPosition());
}
```

## 📝 Commit Message Format

```
[TYPE] Brief description (50 chars max)

Optional longer description explaining the change.
- Bullet point 1
- Bullet point 2

Fixes #123
```

Types: `Feature`, `Fix`, `Docs`, `Refactor`, `Perf`, `Test`

## 🐛 Report Bugs

Se trovi un bug:
1. Controlla se è già segnalato
2. Crea un nuovo issue con:
   - Descrizione del problema
   - Step per riprodurlo
   - Versione Unity
   - Platform (PC/Mobile)
   - Screenshot/Video

## 💡 Suggerimenti Feature

Hai un'idea? Apri una discussion o issue:
- Descrivi la feature
- Spiega il valore aggiunto
- Proponi implementazione (opzionale)

---

**Grazie per contribuire! 🎉**
