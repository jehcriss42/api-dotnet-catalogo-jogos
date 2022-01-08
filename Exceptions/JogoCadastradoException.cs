using System;

namespace ApiCatalogoJogos.Exceptions
{
    public class JogoCadastradoException : Exception
    {
        public JogoCadastradoException()
            : base ("Esse jogo ja esta cadastrado")
        {
        }
    }
}
