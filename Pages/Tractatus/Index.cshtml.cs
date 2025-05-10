using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json; // Required for System.Text.Json
using System.Collections.Generic;
using System.Linq; // Required for LINQ operations like Select
using System.IO; // Added for file operations
using Microsoft.AspNetCore.Hosting; // Added for IWebHostEnvironment

namespace ASP_site.Pages
{
    public class TractatusModel : PageModel
    {
        private readonly IWebHostEnvironment _environment; // Added

        // We'll populate these later, perhaps from a service that parses the Tractatus
        public string? TractatusJsonData { get; private set; }
        public string? TranslationsJsonData { get; private set; }

        // Placeholder for Tractatus data structures
        public class TractatusPropositionNode
        {
            public string Id { get; set; } = "";
            public List<TractatusPropositionNode> Children { get; set; } = new List<TractatusPropositionNode>();
            public int ReadingOrderIndex { get; set; } // New property
        }

        public class TractatusTranslationData
        {
            public Dictionary<string, Dictionary<string, string>> TranslationsByLanguage { get; set; } = new Dictionary<string, Dictionary<string, string>>();
            public List<LanguageMetadata> AvailableTranslations { get; set; } = new List<LanguageMetadata>();
        }

        public class LanguageMetadata
        {
            public string LanguageKey { get; set; } = "";
            public string DisplayName { get; set; } = "";
            public string SourceInfo { get; set; } = "";
            public string DataFile { get; set; } = ""; // Added property
            public int? Tier { get; set; } // New property for tiered display (e.g., 1 for primary, 2 for secondary)
            public bool? IsDefaultInTier { get; set; } // New property to suggest pre-selection
        }

        // Helper class for deserializing structure.json
        public class TractatusPropositionNodeStructure
        {
            public string Id { get; set; } = "";
            public List<TractatusPropositionNodeStructure> Children { get; set; } = new List<TractatusPropositionNodeStructure>();
        }

        // Constructor for IWebHostEnvironment injection
        public TractatusModel(IWebHostEnvironment environment) // Added
        { // Added
            _environment = environment; // Added
        } // Added

        private void AssignReadingOrder(List<TractatusPropositionNode> propositions, ref int currentIndex, int totalPropositions)
        {
            foreach (var prop in propositions)
            {
                prop.ReadingOrderIndex = currentIndex;
                currentIndex++;
                if (prop.Children.Any())
                {
                    AssignReadingOrder(prop.Children, ref currentIndex, totalPropositions);
                }
            }
        }

        private int CountTotalPropositions(List<TractatusPropositionNode> propositions)
        {
            int count = 0;
            foreach (var prop in propositions)
            {
                count++;
                if (prop.Children.Any())
                {
                    count += CountTotalPropositions(prop.Children);
                }
            }
            return count;
        }

        // New recursive helper method to build the main proposition structure
        private List<TractatusPropositionNode> BuildPropositionNodes(
            List<TractatusPropositionNodeStructure> structureNodes)
        {
            var propositionNodes = new List<TractatusPropositionNode>();
            if (structureNodes == null) return propositionNodes;

            foreach (var structureNode in structureNodes)
            {
                var propNode = new TractatusPropositionNode
                {
                    Id = structureNode.Id
                };

                if (structureNode.Children != null && structureNode.Children.Any())
                {
                    propNode.Children = BuildPropositionNodes(structureNode.Children);
                }
                propositionNodes.Add(propNode);
            }
            return propositionNodes;
        }

        public void OnGet()
        {
            var webRootPath = _environment.WebRootPath;
            var dataPath = Path.Combine(webRootPath, "data");

            var languageInfoFilePath = Path.Combine(dataPath, "language-info.json");
            var structureFilePath = Path.Combine(dataPath, "structure.json");

            List<LanguageMetadata> allLanguageMetadata = new List<LanguageMetadata>();
            if (System.IO.File.Exists(languageInfoFilePath))
            {
                var languageInfoJson = System.IO.File.ReadAllText(languageInfoFilePath);
                allLanguageMetadata = JsonSerializer.Deserialize<List<LanguageMetadata>>(languageInfoJson) ?? new List<LanguageMetadata>();
            }

            var structureJson = System.IO.File.ReadAllText(structureFilePath);
            var baseStructure = JsonSerializer.Deserialize<List<TractatusPropositionNodeStructure>>(structureJson);

            if (baseStructure == null)
            {
                // Handle error: essential data missing
                TractatusJsonData = "[]";
                TranslationsJsonData = "{}";
                return;
            }

            var propositions = BuildPropositionNodes(baseStructure);
            int totalPropositions = CountTotalPropositions(propositions);
            int tempReadingOrderIndex = 0;
            AssignReadingOrder(propositions, ref tempReadingOrderIndex, totalPropositions);

            var serializationOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = false // Minify JSON for transfer
            };
            TractatusJsonData = JsonSerializer.Serialize(propositions, serializationOptions);

            // Prepare translations data based on language-info.json
            var translationsData = new TractatusTranslationData();
            foreach (var langMeta in allLanguageMetadata)
            {
                var langFilePath = Path.Combine(dataPath, langMeta.DataFile);
                if (System.IO.File.Exists(langFilePath))
                {
                    var langJson = System.IO.File.ReadAllText(langFilePath);
                    var langTexts = JsonSerializer.Deserialize<Dictionary<string, string>>(langJson);
                    if (langTexts != null)
                    {
                        translationsData.TranslationsByLanguage[langMeta.LanguageKey] = langTexts;
                        if (!translationsData.AvailableTranslations.Any(t => t.LanguageKey == langMeta.LanguageKey))
                        {
                           translationsData.AvailableTranslations.Add(langMeta);
                        }
                    }
                }
            }

            // Sort AvailableTranslations: first by Tier (nulls last or treat as a high number), then by DisplayName
            translationsData.AvailableTranslations = translationsData.AvailableTranslations
                .OrderBy(lm => lm.Tier ?? int.MaxValue) // Treat null Tier as lowest priority
                //.ThenBy(lm => lm.DisplayName)
                .ToList();
            
            TranslationsJsonData = JsonSerializer.Serialize(translationsData, serializationOptions);

            // Further escape backslashes for safe embedding in JavaScript single-quoted string for JSON.parse
            if (TractatusJsonData != null)
            {
                TractatusJsonData = TractatusJsonData.Replace("\\", "\\\\"); // \ -> \\
            }
            if (TranslationsJsonData != null)
            {
                TranslationsJsonData = TranslationsJsonData.Replace("\\", "\\\\"); // \ -> \\
            }
        }
    }
} 