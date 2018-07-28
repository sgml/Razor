﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Razor.Language
{
    internal static class SyntaxFactory
    {
        internal static HtmlDocumentSyntax.Green HtmlDocument(
            HtmlDeclarationSyntax.Green doctype,
            InternalSyntaxList<GreenNode> precedingMisc,
            HtmlNodeSyntax.Green body,
            InternalSyntaxList<GreenNode> followingMisc,
            SkippedTokensTriviaSyntax.Green skippedTokens,
            SyntaxToken.Green eof)
        {
            return new HtmlDocumentSyntax.Green(doctype, precedingMisc.Node, body, followingMisc.Node, skippedTokens, eof);
        }

        internal static HtmlTextSyntax.Green HtmlText(InternalSyntaxList<SyntaxToken.Green> textTokens)
        {
            return new HtmlTextSyntax.Green(textTokens.Node);
        }

        internal static HtmlTextTokenSyntax.Green HtmlTextToken(string text, params RazorDiagnostic[] diagnostics)
        {
            return new HtmlTextTokenSyntax.Green(text, diagnostics);
        }

        internal static UnknownTokenSyntax.Green UnknownToken(string text, params RazorDiagnostic[] diagnostics)
        {
            return new UnknownTokenSyntax.Green(text, diagnostics);
        }
    }
}
