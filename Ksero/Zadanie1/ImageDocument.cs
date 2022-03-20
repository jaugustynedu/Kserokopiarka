﻿using System;

namespace Kserokopiarka
{
    public class TextDocument : AbstractDocument
    {
        public TextDocument(string filename) : base(filename) { }
        public override IDocument.FormatType GetFormatType() => IDocument.FormatType.TXT;
    }
}