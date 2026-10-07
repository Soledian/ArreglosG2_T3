using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos.logica
{
    public class MiArreglo
    {
        private int _tope;

        private int[] _arreglo;

        public MiArreglo(int n)
        {
            N = n;
            _arreglo = new int[N];
            _tope = 0;


        }

        public int N { get; }

        public Boolean EstaVacio => _tope == 0;
        public Boolean EstaLleno => _tope == N;
    }
}
