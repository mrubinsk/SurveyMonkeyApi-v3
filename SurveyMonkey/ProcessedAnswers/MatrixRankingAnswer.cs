﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SurveyMonkey.ProcessedAnswers
{
    public class MatrixRankingAnswer : IProcessedResponse
    {
        public Dictionary<int, string> Ranking { get; set; }
        public List<string> NotApplicable { get; set; }

        public string Printable
        {
            get
            {
                if ((Ranking == null || !Ranking.Any()) && (NotApplicable == null || !NotApplicable.Any()))
                {
                    return null;
                }
                var sb = new StringBuilder();
                if (Ranking != null)
                {
                    var keys = Ranking.Keys.ToList();
                    keys.Sort();
                    foreach (var key in keys)
                    {
                        sb.Append($"{key}: {Ranking[key]}{Environment.NewLine}");
                    }
                }
                if (NotApplicable != null && NotApplicable.Any())
                {
                    sb.Append("Not applicable:");
                    sb.Append(Environment.NewLine);
                    foreach (var item in NotApplicable)
                    {
                        sb.Append(item);
                        sb.Append(Environment.NewLine);
                    }
                }
                return sb.ToString().TrimEnd();
            }
        }
    }
}