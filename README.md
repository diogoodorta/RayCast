# RayCast# Raycasthit
cena feita no unity, utilizando o raycast e conceitos de iluminação.

Nomes: Diogo Silva e Caio de Oliveira

Explicação da cena:

Foi utilizada a cápsula para o personagem e os inimigos, no personagem foi colocado o script de "movimento", fazendo ele se mover e rotacionar, menos para cima e para baixo. Também foi colocado dois cubos para representar as suas mãos. 

![p](https://github.com/diogoodorta/Raycasthit/assets/101647390/cff60c54-4de9-448c-8de2-ccc556b2b058)

RayCast: O script do Raycast, foi colado em uma das mãos do personagem, esse script cria uma linha azul, que só pode ser vista no modo Scene, que ao entrar em contato com as cápsulas inimigas e dar o hit, as cápsulas vão mudar para a cor verde, essas cápsulas possuem a tag "RayCast" para só funcionar com elas.
linha que é feita:

![image](https://github.com/diogoodorta/Raycasthit/assets/101647390/3a72c958-c460-4379-b9a6-eff4b001589a)


depois que as cápsulas tomam o hit:

![image](https://github.com/diogoodorta/Raycasthit/assets/101647390/e0b6a72e-3b75-460e-94fe-e87a3f83cd52)

Na parte da iluminação: Tiramos o Directional Light, para a cena ficar mais escura e criamos um sistema para "lanterna". Na outra mão do personagem, colocamos um Spot Light e dentro do Spot Light, foi colocado o script "luz", que ao apertar o botão direito do mouse, a luz acende e ao apertar de novo, ela apaga. Também mexemos na intensidade dela e no seu ângulo. 

Luz que é criada ao apertar o botão direito do mouse:

![image](https://github.com/diogoodorta/Raycasthit/assets/101647390/aa29c8ba-5d54-46bb-a65c-3bb321770da2)
