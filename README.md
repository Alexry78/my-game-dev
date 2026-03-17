classDiagram
    class Game {
        +Run()
        -Update()
        -Draw()
    }
    class Map {
        +Width
        +Height
        +Tiles
    }
    class Entity {
        #Health
        #Name
        +TakeDamage(int damage)
    }
    class Player {
        +Experience
        +LevelUp()
    }
    class Enemy {
        +Damage
        +Attack(Player target)
    }
    class Item {
        +Name
        +Effect
    }
    Game --> Map
    Game --> Player
    Game --> Enemy
    Entity <|-- Player
    Entity <|-- Enemy
    Map --> Item