﻿using System;

namespace ApiCatalogoJogos.ViewModel
{
    public class JogoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public double preco { get; set; }
    }
}
