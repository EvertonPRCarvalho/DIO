# Jogo RPG - Prática de POO
Versão 1.0

## Organização dos Arquivos
O diretório 'src' agrupa todos os diretorios criados para implementação da lógica e armazenamento do jogo. 
Então, se houvesse a necessidade de ter um diretório com arquivos CSV, por exemplo, tal diretório estaria contido em './src'.
O diretório Models contém todas as minhas classes, até o momento são: Batalha e Personagem.

## O Jogo
Como pode ser compreendido na classe Personagem, cada personagem possui nome, seu tipo, o level, que inicia com 1, o HP, que inicia com 10 e pode ser maior caso o jogador receba mais HP's ao longo da partida. O mais esperado vem agora, o personagem tem um conjunto de ataques onde acada ataque tem um potencial de dano. Além disso, o personagem também possui uma lista com as defesas que consegue fazer para determinados ataques. 
Tanto os ataques quanto os contra-ataques são habilidades particulares de cada tipo de personagem e podem ser adquiridas ao longo do jogo.

## DEMO 
### PLAYER 01
Ivon :mage_man: | Mago | HP [==========] | Level 2

Ataques 
        [Magia Congelante  - Dano 2]

        [Flecha Mágica     - Dano 1]

        [Machado Cinzento  - Dano 2]

Defesas 
        [Flecha Flamejante - Contra-ataque 1]

        [Espada Mortal     - Contra-ataque 2]
### PLAYER 02
Strar :guardsman:| Guerreiro | HP [==========] | Level 1

Ataques 
        [Espada Mortal     - Dano 1]

        [Machado de Bronze - Dano 1]
        
Defesas 
        [Magia Congelante  - Contra-ataque 1]

        [Espada Mortal     - Contra-ataque 1]
### BATALHAR
Ivon :mage_man:    Mago       HP [==========]   Level 2

Ataque 
        [Magia Congelante  - Dano 2]

:space_invader::dash::snowflake:

Strar :guardsman:  Guerreiro  HP [=========  ]  Level 1

Defesa 
        [Magia Congelante  - Contra-ataque 1]

:guardsman::anger:
