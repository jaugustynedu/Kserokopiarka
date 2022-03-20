﻿using System;

namespace Kserokopiarka { 
public class PDFDocument : AbstractDocument
    {
        public PDFDocument(string filename) : base(filename) { }
        public override IDocument.FormatType GetFormatType() => IDocument.FormatType.PDF;
    }
}