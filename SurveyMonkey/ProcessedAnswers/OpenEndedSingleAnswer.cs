﻿namespace SurveyMonkey.ProcessedAnswers
{
    public class OpenEndedSingleAnswer : IProcessedResponse
    {
        public string Text { get; set; }
        public string Printable => Text;
    }
}