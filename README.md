# efcore-bulk-extensions
Usando a biblioteca EFCore BulkExtensions para realizar operações de inserção, atualização e exclusão em massa de forma eficiente com C#

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

## Sobre o projeto
Este projeto mostra como usar a biblioteca EFCore BulkExtensions para realizar operações de inserção, atualização e exclusão em massa de forma eficiente com C#.

Em vez de interagir com o banco de dados linha por linha, o EFCore.BulkExtensions permite que você manipule grandes conjuntos de dados em uma única operação, o que geralmente resulta em melhor desempenho em cenários onde muitas entidades precisam ser processadas de uma só vez.

Essa biblioteca é útil em situações em que você precisa lidar com grandes volumes de dados e deseja minimizar o tempo de execução das operações de banco de dados. Ao usar EFCore.BulkExtensions, você pode inserir milhares ou até milhões de registros de uma só vez, em vez de iterar individualmente sobre cada entidade.

Lembre-se de que, embora seja poderosa para operações em massa, é importante entender como e quando usar essas operações para evitar impactos negativos no desempenho do banco de dados e para garantir a consistência dos dados.

<div align="center">
    <img src="https://github.com/jfs-dev/efcore-bulk-extensions/assets/54154628/149a2f77-9ab9-4697-aef6-19716a4c9ee6"</img>
</div>

## Referências
https://entityframework-extensions.net/

https://entityframework-extensions.net/bulk-extensions/

## Licença
GPL-3.0 license
