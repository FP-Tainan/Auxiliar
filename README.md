PROJETO: Windows Forms - Auxiliar
---------------------------------------------------------

OBJETIVO:
---------
Este projeto tem como finalidade registrar credenciais de acesso a uma rede interna (intranet),
listar pastas compartilhadas de uma máquina da rede e permitir o mapeamento dessas pastas
em uma letra de unidade do Windows, Além de outras funções como instalar programas, cadastrar
etapas de um processo e alterar seus status entre (Aberto, Em Andamento, Pausado, Concluído e Cancelado)

ESTRUTURA DO PROJETO:
----------------------

📁 Model
    - Contém as classes de modelo (objetos de dados).
    - Exemplo:
        - IntranetInfo.cs → representa os dados de acesso (IP, usuário, senha)
        - ResultadoOperacao<T>.cs → estrutura genérica para retorno padronizado

📁 Controller
    - Contém a lógica de negócio que interage com comandos do sistema (cmd.exe).
    - Exemplo:
        - Intranet.cs → realiza as operações reais como:
            - RegistrarCredenciais
            - ListarPastasCompartilhadas
            - MapearPasta
            - ObterLetrasDisponiveis

📁 Service
    - Camada intermediária que realiza validações antes de chamar o controller.
    - Útil para reaproveitamento, testes e manutenção.
    - Exemplo:
        - IntranetService.cs → valida os dados e chama o controller correspondente.

📁 View
    - Interface gráfica (Windows Forms).
    - Exibe os dados para o usuário e interage com a camada Service.


FLUXO DO SISTEMA:
------------------
1. O usuário preenche os campos no formulário (IP, usuário, senha).
2. A camada View envia os dados para a Service.
3. A Service valida os dados e repassa para a Controller.
4. A Controller executa comandos no sistema (cmd) para autenticação e mapeamento.
5. O resultado (sucesso ou erro) volta até a View via `ResultadoOperacao<T>`.

-----------------------------------------------------------

ARQUITETURA: Camada separada (View → Service → Controller → OS)
Boas práticas aplicadas:
* Validação centralizada
* Separação de responsabilidades
* Uso de tipos genéricos para retorno (Result Pattern).

