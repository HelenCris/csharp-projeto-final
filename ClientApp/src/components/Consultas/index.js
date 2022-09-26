import React, { Component } from 'react';
import { BiSearchAlt } from 'react-icons/bi';
import './styles.css';

// pagina da consulta
export class Consultas extends Component {
  
  render() {
    return (
      <div className="container">
        <div className="child-row">
        <input
          type='text'
          className='input'
          onChange={this.handleChange}
          placeholder='Pesquise um livro...'
        />
        <BiSearchAlt size={30} onClick={this.handleChange}/>
        </div>
       
      </div>
      
    )
  }

}