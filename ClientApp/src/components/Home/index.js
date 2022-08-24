import React, { Component } from 'react';
import './styles.css';

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
      <h1 className="home-title">Bem vindo a biblioteca!!</h1>
    );
  }
}
