﻿namespace RogueLike
{
    internal class Image
    {
        public char _symbol { get; set; }
        public Image() => _symbol = '_';

        public Image(char symbol) => _symbol = symbol;
    }
}
