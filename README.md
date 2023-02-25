# JuegoDeLaVidaDeConway
Juego de la vida de Conway realizado en el lenguaje C#

-Requisitos a la hora de hacer el juego:

En esta práctica se pide programar el famoso Juego de la vida de Conway en un aplicación de consola.

1º Crear una matriz bidimensional de 50 de ancho y 50 de alto.

2º Al iniciar, por cada celda en la matriz pon aleatoriamente si está vivo o muerto (probabilidad del 50%).

3º Las iteraciones serán infinitas con un tiempo de espera entre cada una de 250 milisegundos.

4º En cada iteración aplica las normas del Juego de la vida en la matriz creada.

-Reglas del juego:

  .El universo del Juego de la Vida es una cuadrícula ortogonal infinita y bidimensional de células cuadradas, cada una de las cuales se encuentra en uno de los dos estados posibles, vivas o muertas (o pobladas y despobladas, respectivamente). Cada celda interactúa con sus ocho, que son las celdas que son horizontal, vertical o diagonalmente adyacentes.

  .Las reglas, se pueden condensar en lo siguiente:

  .Cualquier célula viva con dos o tres vecinos vivos sobrevive.
  .Cualquier célula muerta con tres vecinos vivos se convierte en una célula viva.
  .Todas las demás células vivas mueren en la próxima generación. Del mismo modo, todas las demás células muertas permanecen muertas.
  .El patrón inicial constituye la semilla del sistema. La primera generación se crea aplicando las reglas anteriores simultáneamente a cada célula de la semilla, viva o muerta; los nacimientos y las muertes ocurren simultáneamente, y el momento discreto en el que esto sucede a veces se llama garrapata.

  .Una nueva generación comienza cuando todas las celdas se han actualizado una vez. Esto significa que la próxima generación comienza desde cero, sin memoria de lo que sucedió en generaciones anteriores.
