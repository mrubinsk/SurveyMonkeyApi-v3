﻿using System;
using System.Text;

namespace SurveyMonkey.ProcessedAnswers
{
    public class SingleChoiceAnswer : IProcessedResponse
    {
        public string Choice { get; set; }
        public string OtherText { get; set; }

        public string Printable
        {
            get
            {
                var sb = new StringBuilder();
                if (Choice != null)
                {
                    sb.Append(Choice);
                    sb.Append(Environment.NewLine);
                }
                if (OtherText != null)
                {
                    sb.Append(OtherText);
                }
                return sb.ToString().TrimEnd();
            }
        }
    }
}