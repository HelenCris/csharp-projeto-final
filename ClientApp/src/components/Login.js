import React, { Component } from 'react';
import './Login.css';
// pagina do login

export class Login extends Component {
  static displayName = Login.name;

  render() {
    return (
      <div class="login-page">
        <div class="form">
          <form class="login-form">
            <input type="email" placeholder="Seu email"/>
            <input type="password" placeholder="Sua senha"/>
            <button>login</button>
            <p class="message">Não tem uma conta? <a href="./cadastro">Crie uma conta</a></p>
          </form>
        </div>
      </div>
    );
  }
}
