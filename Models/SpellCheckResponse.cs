﻿using System.Collections.Generic;

namespace Models
{
    public class Suggestions
    {
        public string Suggestion { get; set; }
        public int Score { get; set; }
    }

    public class FlaggedToken
    {
        public int Offset { get; set; }
        public string Token { get; set; }
        public string Type { get; set; }
        public List<Suggestions> Suggestions { get; set; }
    }

    public class SpellCheckResponse
    {
        // ReSharper disable once InconsistentNaming
        public string _type { get; set; }
        public List<FlaggedToken> FlaggedTokens { get; set; }
        public string CorrectionType { get; set; }
    }
}