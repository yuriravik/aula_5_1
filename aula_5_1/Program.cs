using System;

namespace aula_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator novoCarro = new CarroCreator();
            Creator novaMoto = new MotoCreator();
            Carro meuCarro = (Carro)novoCarro.criarVeiculo();
            Moto minhaMoto = (Moto)novaMoto.criarVeiculo();

            meuCarro.getTipo();
            minhaMoto.getTipo();

        }
    }
}
