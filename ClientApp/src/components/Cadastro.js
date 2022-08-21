import React, { Component } from 'react';
import './Cadastro.css';
// pagina do login

export class Cadastro extends Component {
  static displayName = Cadastro.name;

  render() {
    return (
      <div class="cadastro-page">
        <div class="form">
          <form class="cadastro-form">
            <input type="text" placeholder="Seu nome completo"/>
            <input type="email" placeholder="Seu email"/>
            <input type="password" placeholder="Digite uma senha"/>
            <input type="password" placeholder="Digite novamente sua senha"/>
            <button>cadastrar</button>
            <p class="message">Tem uma conta? <a href="./login">Entre na conta</a></p>
          </form>
        </div>
      </div>
    );
  }
}
