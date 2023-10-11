// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Frequently asked question for the service health event. </summary>
    public partial class ResourceHealthEventFaq
    {
        /// <summary> Initializes a new instance of ResourceHealthEventFaq. </summary>
        internal ResourceHealthEventFaq()
        {
        }

        /// <summary> Initializes a new instance of ResourceHealthEventFaq. </summary>
        /// <param name="question"> FAQ question for the service health event. </param>
        /// <param name="answer"> FAQ answer for the service health event. </param>
        /// <param name="localeCode"> FAQ locale for the service health event. </param>
        internal ResourceHealthEventFaq(string question, string answer, string localeCode)
        {
            Question = question;
            Answer = answer;
            LocaleCode = localeCode;
        }

        /// <summary> FAQ question for the service health event. </summary>
        public string Question { get; }
        /// <summary> FAQ answer for the service health event. </summary>
        public string Answer { get; }
        /// <summary> FAQ locale for the service health event. </summary>
        public string LocaleCode { get; }
    }
}