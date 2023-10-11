// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> A video analyzer preset that extracts insights (rich metadata) from both audio and video, and outputs a JSON format file. </summary>
    public partial class VideoAnalyzerPreset : AudioAnalyzerPreset
    {
        /// <summary> Initializes a new instance of VideoAnalyzerPreset. </summary>
        public VideoAnalyzerPreset()
        {
            OdataType = "#Microsoft.Media.VideoAnalyzerPreset";
        }

        /// <summary> Initializes a new instance of VideoAnalyzerPreset. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="audioLanguage"> The language for the audio payload in the input using the BCP-47 format of 'language tag-region' (e.g: 'en-US').  If you know the language of your content, it is recommended that you specify it. The language must be specified explicitly for AudioAnalysisMode::Basic, since automatic language detection is not included in basic mode. If the language isn't specified or set to null, automatic language detection will choose the first language detected and process with the selected language for the duration of the file. It does not currently support dynamically switching between languages after the first language is detected. The automatic detection works best with audio recordings with clearly discernable speech. If automatic detection fails to find the language, transcription would fallback to 'en-US'." The list of supported languages is available here: https://go.microsoft.com/fwlink/?linkid=2109463. </param>
        /// <param name="mode"> Determines the set of audio analysis operations to be performed. If unspecified, the Standard AudioAnalysisMode would be chosen. </param>
        /// <param name="experimentalOptions"> Dictionary containing key value pairs for parameters not exposed in the preset itself. </param>
        /// <param name="insightsToExtract"> Defines the type of insights that you want the service to generate. The allowed values are 'AudioInsightsOnly', 'VideoInsightsOnly', and 'AllInsights'. The default is AllInsights. If you set this to AllInsights and the input is audio only, then only audio insights are generated. Similarly if the input is video only, then only video insights are generated. It is recommended that you not use AudioInsightsOnly if you expect some of your inputs to be video only; or use VideoInsightsOnly if you expect some of your inputs to be audio only. Your Jobs in such conditions would error out. </param>
        internal VideoAnalyzerPreset(string odataType, string audioLanguage, AudioAnalysisMode? mode, IDictionary<string, string> experimentalOptions, InsightsType? insightsToExtract) : base(odataType, audioLanguage, mode, experimentalOptions)
        {
            InsightsToExtract = insightsToExtract;
            OdataType = odataType ?? "#Microsoft.Media.VideoAnalyzerPreset";
        }

        /// <summary> Defines the type of insights that you want the service to generate. The allowed values are 'AudioInsightsOnly', 'VideoInsightsOnly', and 'AllInsights'. The default is AllInsights. If you set this to AllInsights and the input is audio only, then only audio insights are generated. Similarly if the input is video only, then only video insights are generated. It is recommended that you not use AudioInsightsOnly if you expect some of your inputs to be video only; or use VideoInsightsOnly if you expect some of your inputs to be audio only. Your Jobs in such conditions would error out. </summary>
        public InsightsType? InsightsToExtract { get; set; }
    }
}