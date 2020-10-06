# Zoo Lógico

## Desafio 1.0
#### Descrição
Você foi indicado por uma amiga de um sobrinho de um chegado seu para desenvolver o **protótipo** de um sistema de gerenciamento de um novo Zoológico. O processo todo foi dividido em etapas:

### Desafio 1.1
Nesta fase você deve dizer para o usuário para qual das jaulas abaixo os animais devem ir. Para isso o sistema deve mostrar todos os animais disponíveis, em seguida pedir para que o usuário digite o código ou nome correspondente ao animal e depois mostrar uma mensagem com o nome da jaula destinada ao bicho.

A princípio, os gerentes do lugar estão com poucas jaulas **(não precisam ser classes ou interfaces nesse momento!)**:
* Pasto (gramíneas e terreno vasto, ligeiramente regular com algumas árvores);
* Gaiola (muitas árvores altas);
* Casa em árvore (florestas...);
* Caverna de pedra (cercada por capim alto, terra, algumas árvores e rochas num terro irregular);
* Piscina Gelada (água salgada e cercada por gelo);
* Piscina (água doce e com bastante mato, árvores e terra ao redor);
* Aquário (é com água salgada e não possui muita superfície terrestre para os animais).

Os animais a serem classificados, inicialmente, são:
* Tubarão Martelo;
* Tucano;
* Arara;
* Leão;
* Orangotango;
* Chimpanzé;
* Pinguim;
* Tartagura;
* Golfinho.

### Desafio 1.2
Agora eles precisam **distribuir** animais em jaulas de forma **manual** pelo usuário, de modo que, não importando quantos animais venham a ser cadastrados no futuro, não seja necessária a intervenção de um programador para que ela seja realizada. *O número entre colchetes na lista acima é a quantidade de jaulas daquele tipo e cada jaula suporta apenas um animal*.

As jaulas são as mesmas do desafio anterior:
* Pasto [3];
* Gaiola [3];
* Casa em árvore [3];
* Caverna de pedra [3];
* Piscina Gelada [3];
* Piscina [3];
* Aquário [3].

### Desafio 1.3
Após uma alocação de animal para uma jaula, é preciso retirá-lo do menu!

### Desafio 1 Final!
Você consegue fazer esse sistema funcionar de forma automática? Cadastre outros animais e tente escrever esse programa de modo que, ao executar, ele já coloca cada animal na jaula mais adequada baseando-se somente no polimorfismo e exiba os resultados!

Sugestões de animais:
* Tigre;
* Crocodilo;
* Baleia;
* Sapo;
* Teiú;
* Morcego.

## Desafio 02 
### ~~Descrição~~ (em construção)
Você foi chamado novamente para desenvolver uma evolução do **protótipo** do sistema, pois o zoológico está em reforma.
Agora os animais viverão o mais próximo possível de seu habitat natural.
Eles precisam que o sistema seja capaz de:
* Registrar animais novos;
* Alocá-los nos seguintes habitats:
    * Floresta [8];
    * Estepes [5];
    * Montanha [3];
    * Deserto (de areia)[3];
    * Pântano [5];
    * Mar [10];
    * Lago [5];
    * Geleira [3];

Essa **distribuição** de animais em habitats deve ser feita de forma **automática** de modo que, não importando quantos animais venham a ser cadastrados no futuro, não seja necessária a intervenção de um programador para que ela seja realizada. *O número entre colchetes na lista acima é a quantidade máxima de animais que o habitat suporta*.

Os animais a serem distribuídos, inicialmente, são:
* Zebra;
* Tubarão Martelo;
* Gavial;
* Condor;
* Ibex;
* Mico Leão Dourado;
* Gorila;
* Elefante;
* Rã;
* Camaleão;
* Camelo;
* Píton.