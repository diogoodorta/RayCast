# RayCast# 
cena feita no unity, utilizando o raycast e conceitos de iluminação.

Nomes: Diogo Silva e Caio de Oliveira

Explicação da cena:

Foi utilizada a cápsula para o personagem e os inimigos, no personagem foi colocado o script de "movimento", fazendo ele se mover e rotacionar, menos para cima e para baixo. Também foi colocado dois cubos para representar as suas mãos. 

RayCast: O script do Raycast, foi colado em uma das mãos do personagem, esse script cria uma linha azul, que só pode ser vista no modo Scene, que ao entrar em contato com as cápsulas inimigas e dar o hit, as cápsulas vão mudar para a cor verde, essas cápsulas possuem a tag "RayCast" para só funcionar com elas.


linha que é feita:

![image](https://github.com/diogoodorta/RayCast/assets/101647390/c8c63ac2-19ae-4bee-b992-c41073cb18c6)



depois que as cápsulas tomam o hit:

![image](https://github.com/diogoodorta/RayCast/assets/101647390/a73258d2-cc1c-4686-87c7-ca7bb317343e)


Na parte da iluminação: Tiramos o Directional Light, para a cena ficar mais escura e criamos um sistema para "lanterna". Na outra mão do personagem, colocamos um Spot Light e dentro do Spot Light, foi colocado o script "luz", que ao apertar o botão direito do mouse, a luz acende e ao apertar de novo, ela apaga. Também mexemos na intensidade dela e no seu ângulo. 

Luz que é criada ao apertar o botão direito do mouse:

![image](https://github.com/diogoodorta/RayCast/assets/101647390/0489e3da-d586-42dc-95a2-72b79f5a14d6)

