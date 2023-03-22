Este código em C# solicita ao usuário que digite uma palavra e, em seguida, inverte a palavra e a imprime na tela.

O programa começa definindo duas variáveis do tipo string: original e invertida. A primeira será usada para armazenar a palavra digitada pelo usuário e a segunda será usada para armazenar a palavra invertida.

Em seguida, o programa solicita que o usuário digite uma palavra usando a função Console.ReadLine(). A palavra digitada é armazenada na variável original.

O programa então usa um loop for para percorrer a palavra original da direita para a esquerda e adicionar cada letra à variável invertida. O loop começa no último caractere da palavra original (cujo índice é original.Length - 1) e termina no primeiro caractere (cujo índice é 0). A cada iteração do loop, a letra correspondente é adicionada ao final da string invertida.

Finalmente, o programa imprime a palavra invertida na tela usando a função Console.WriteLine(). O resultado será a palavra digitada pelo usuário, mas com as letras na ordem inversa.
