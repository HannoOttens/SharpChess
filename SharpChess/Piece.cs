using System;
using System.Collections.Generic;
using System.Text;

namespace SharpChess
{
    readonly struct Piece
    {
        readonly byte id;

        public Piece(byte id) => this.id = id;
    }
}
