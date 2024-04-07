# O Galo da Velha

## Autoria

Paulo Silva, a22206205;

Lee Dias, a22302809;

João Rodrigues, a22302667.

## Lista de Tarefas

| Data | Nome | Tarefa |
|------|------|--------|
|27/3|Paulo Silva|Cria Enum com cada tipo de peça|
|28/3|Paulo Silva|Adiciona símbolos unicode para cada peça|
|5/4|Paulo Silva|Update do constructor da criação das peças|
|5/4|Lee Dias|Adiciona o tabuleiro|
|6/4|Lee Dias|Faz o loop de jogo|
|6/4|Paulo Silva|Faz alterações na verificação do fim|
|6/4|João Rodrigues|Corrige bugs no Program.cs e adiciona cores|
|6/4|Paulo Silva|Finaliza o sistema de verificação do fim|
|6/4|João Rodrigues|Atualiza o Program.cs e faz o Tutorial.cs|
|6/4|Lee Dias|Adiciona a verificação do fim ao Program.cs|
|6/4|Lee Dias|Adiciona comentários ao Program.cs|
|6/4|Lee Dias|Mostra as peças restantes durante o jogo|
|6/4|Paulo Silva|Corrige o VerificarFim.cs|
|6/4|João Rodrigues|Finaliza o tutorial e adiciona ao Program.cs|
|7/4|Paulo Silva|Adiciona documentação XML|
|7/4|João Rodrigues|Faz o README|
|7/4|João Rodrigues|Corrige erros e melhora a interface|
|7/4|Lee Dias|Adiciona o método de empate|
|7/4|Paulo Silva|Adiciona o fluxograma ao README|
|7/4|João Rodrigues|Finaliza o README.md|


## [>Repositório Git<](https://github.com/Pninja12/O-galo-velho)

## Arquitetura da Solução

### Descrição

 Começou-se por criar um enumerador para identificar o tipo de peça
(TipoPecas.cs)

 O program.cs foi organizado por primeiro tentar fazer as peças aparecerem no
ecrã, em seguida fazer com que um tabuleiro apareça com espaços vazios,
representados por "-",  pedir aos jogadores a peça que vai ser utilizada
e a posição e substituir o "-" da posição escolhida pela peça escolhida,
utilizando o CriarPecas.cs.
Em seguida fazer as validações e finalmente meter o jogo em um loop e juntar
com o VerificarFim.cs. Na verificação da vitória de cada jogador, a classe
VerificarFim recebe a lista de peças e depois vai de 4 em 4 peças verificar se
existe algum conjunto que está na mesma linha/coluna/diagonal e se sim então
retorna true, caso não então retorna false.

 Um dos algorítmos não triviais adicionados foi o try e catch, para fazer com
que caso algum dos jogadores nao respeite uma indicação, em vez de dar erro,
o programa simplesmente mostra o erro que estava a ser cometido.
Outro algorítmo não trivial é a forma de mostrar o tabuleiro, que em vez de usar
linhas e colunas, simplesmente fizemos uma lista de 1 a 16 em que de 4 em 4 "-",
passa para a linha de baixo para fazer o efeito de um tabuleiro 4x4.

### Fluxograma

```mermaid
flowchart TD
    Comeco([Começo]) --> 
    Criar[Criação das 16 peças] -->
    Tutorial[Chamar a classe Tutorial]
    TutorialInit([Tutorial])
    Pecas/Tabuleiro[Descrição das peças e do tabuleiro]
    Regras[Explicação das regras, do objetivo e de como chegar lá]
    Tutorial --> TutorialInit -->
    Pecas/Tabuleiro --> Regras --> Jogo
    Jogo[Inicialização da classe Jogo]
    JogoInit([Jogo])
    Amostra[Mostrar o tabuleiro e as peças nele colocadas]
    Ganhou{Verifica se alguém ganhou}
    Vitória([O PlayerX ganhou])
    Ganhou -->|Sim| Vitória
    Ganhou -->|Não| PedirPeça
    PedirPeça[Pede a peça ao outro jogador]
    ColocarPeça[Pergunta onde o jogador quer colocar a peça]
    Troca[Troca os jogadores]
    Jogo-->JogoInit
    JogoInit-->Amostra-->Ganhou
    PedirPeça-->ColocarPeça-->Troca
    Troca-->Amostra
