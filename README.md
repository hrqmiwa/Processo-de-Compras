# 💳 Sistema de Processamento de Pagamentos em C#

## 📌 Descrição

Este projeto foi desenvolvido como atividade de fixação com o objetivo de aplicar os conceitos de **Herança** e **Polimorfismo** em C#.

O sistema simula diferentes formas de pagamento, onde todas compartilham características em comum, mas possuem comportamentos específicos ao processar o pagamento.

---

## 🎯 Objetivo

Implementar um sistema que permita:

* Criar diferentes tipos de pagamento
* Compartilhar atributos comuns entre eles
* Executar ações específicas para cada tipo

---

## 🧠 Conceitos utilizados

* Programação Orientada a Objetos (POO)
* Herança
* Polimorfismo
* Métodos virtuais e sobrescrita (`virtual` e `override`)

---

## 🏗️ Estrutura do Projeto

### 🔹 Classe Base

**Pagamento**

* `Valor` (double)
* `Data` (DateTime)
* Método: `Processar()`

### 🔹 Classes Derivadas

**CartaoCredito**

* `NumeroCartao`
* `Parcelas`

**Pix**

* `ChavePix`
* `CodigoCopiaECola`

**Boleto**

* `CodigoBarras`
* `DataVencimento`

---

## ⚙️ Funcionamento

Cada classe herda de `Pagamento` e sobrescreve o método `Processar()`, exibindo uma mensagem específica:

* 💳 Cartão: simula pagamento parcelado
* ⚡ Pix: simula validação instantânea
* 🧾 Boleto: simula geração com vencimento

---

## ▶️ Como Executar

1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/seu-repositorio.git
```

2. Abra o projeto no Visual Studio ou VS Code

3. Execute o arquivo `Program.cs`

---

## 🧪 Exemplo de Saída

```bash
Pagamento de R$ 500 realizado no cartão 1234-5678-9012-3456 em 5x.
Chave Pix email@teste.com validada. Aguardando recebimento instantâneo.
Boleto gerado com sucesso. Vencimento para o dia 25/03/2026.
```

---

## 📁 Organização

* `Pagamento.cs`
* `CartaoCredito.cs`
* `Pix.cs`
* `Boleto.cs`
* `Program.cs`

---

## 👨‍💻 Autor

Projeto desenvolvido para fins acadêmicos.
