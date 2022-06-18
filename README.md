# TextualRPG

Textual RPG is a project to build a multi player RPG on a textual base

## Star principal

The first goal of the application is to send place location description on player action.

```mermaid
sequenceDiagram
    actor P1 as Play 1
    participant Srv as RPGServer

    P1->>Srv: Star the game
    Srv->>P1: Star place description
    loop 
        P1->>Srv: Send Action [Text]
        Srv->>P1: place description
    end 
```


## How to participate

install commitizen

```shell
npm install -g commitizen
```

use commitizen

```shell
cz
```
