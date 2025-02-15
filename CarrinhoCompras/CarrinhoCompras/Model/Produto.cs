﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CarrinhoCompras.Model
{
    public class Produto
    {
        [PrimaryKey, AutoIncrement] //Faz com que o sqlit crie os registros internamente
        public int id { get; set; }
        public string descricao { get; set; }
        public double quantidade { get; set; }
        public double preco { get; set; }
    }
}
