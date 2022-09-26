/* eslint-disable react-hooks/rules-of-hooks */
import React, { Component } from 'react';
import PropTypes from 'prop-types';
import './styles.css';
// import { LoginUserModel } from  '../../../../Request/Login.cs';
// pagina do login

export class Login extends Component {
  static displayName = Login.name;
  // const [email, setEmail] = useState();
  // const [password, setPassword] = useState();

  // const handleSubmit = async e => {
  //   e.preventDefault();
  //   const token = await authUserLogin({
  //     email,
  //     password
  //   });
  //   setToken(token);

  render() {
    return (
      <div class="login-page">
        <div class="form">
          <form class="login-form" /*onSubmit={handleSubmit}*/>
            <input type="email" placeholder="Seu email" /*onChange={e => setEmail(e.target.value)} *//>
            <input type="password" placeholder="Sua senha" /* onChange={e => setPassword(e.target.value)} *//>
            <button>login</button>
            <p class="message">Não tem uma conta? <a href="./cadastro">Crie uma conta</a></p>
          </form>
        </div>
      </div>
    );
    
  }
  
  
}


Login.propTypes = {
  setToken: PropTypes.func.isRequired
};

async function authUserLogin(credentials) {
 return Login;
}

